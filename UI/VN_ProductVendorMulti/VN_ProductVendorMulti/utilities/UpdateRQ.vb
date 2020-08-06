Public Class UpdateRQ
    Public Shared Sub launchThreadUpdate( _
                                    ByVal factTableAdapter As MyApplication.factManagementDataSetTableAdapters.Fact_UpdateInsertDeleteTableAdapter, _
                                    ByVal waitUpdateTableAdapter As MyApplication.pharmacyDataSetTableAdapters.WaitToUpdateRQTableAdapter, _
                                    ByVal allStockTableAdapter As MyApplication.pharmacyDataSetTableAdapters.AllStocksForSellingTableAdapter, _
                                    ByVal RSTableAdapter As MyApplication.pharmacyDataSetTableAdapters.RS_Stock_SellingTableAdapter, _
                                    ByVal ATableAdapter As MyApplication.pharmacyDataSetTableAdapters.InputPriceTableAdapter, _
                                    ByVal BTableAdapter As MyApplication.pharmacyDataSetTableAdapters.CIPTableAdapter)

        Dim instance As New ThreadForUpdate
        instance.factTableAdapter = factTableAdapter
        instance.waitUpdateTableAdapter = waitUpdateTableAdapter
        instance.allStockTableAdapter = allStockTableAdapter
        instance.RSTableAdapter = RSTableAdapter
        instance.ATableAdapter = ATableAdapter
        instance.BTableAdapter = BTableAdapter

        Dim th As New Threading.Thread(AddressOf instance.UpdateRQAllStock)
        th.IsBackground = True
        th.Start()
    End Sub
    Private Shared ThreadLock = ""
    Private Shared LockInObj = 2005
    Class ThreadForUpdate
        Public factTableAdapter As MyApplication.factManagementDataSetTableAdapters.Fact_UpdateInsertDeleteTableAdapter
        Public waitUpdateTableAdapter As MyApplication.pharmacyDataSetTableAdapters.WaitToUpdateRQTableAdapter
        Public allStockTableAdapter As MyApplication.pharmacyDataSetTableAdapters.AllStocksForSellingTableAdapter
        Public RSTableAdapter As MyApplication.pharmacyDataSetTableAdapters.RS_Stock_SellingTableAdapter
        Public ATableAdapter As MyApplication.pharmacyDataSetTableAdapters.InputPriceTableAdapter
        Public BTableAdapter As MyApplication.pharmacyDataSetTableAdapters.CIPTableAdapter
       
        Public Function UpdateRQAllStock() As Boolean
           

            Try

                Dim tabUpdate = waitUpdateTableAdapter.Get_ByUpdState(False)
                For line = 0 To tabUpdate.Rows.Count - 1
                    Dim idUpdateWait As Integer = tabUpdate.Rows(line)("id")
                    Dim idProductInfo As Integer = tabUpdate.Rows(line)("idProduct")
                    Dim idCS As Integer = tabUpdate.Rows(line)("idCS")
                    Dim idSellPr As Integer = tabUpdate.Rows(line)("idSellPr")

                    Dim stockAB = allStockTableAdapter.GetStockABBy_IdProduct(idProductInfo, 0, 1)
                    Dim quantToSell As Decimal = tabUpdate.Rows(line)("QToSell") 'Q nay da hieu co ratio 
                    If idCS > 0 And idProductInfo > 0 Then
                        Dim k = 0
                        While (quantToSell > 0) And (k < stockAB.Rows.Count)
                            Dim stockIndice = CType(stockAB.Rows(k)("stock"), Integer)
                            Dim idInput As Integer = stockAB.Rows(k)("idInput")
                            Dim rq = CType(stockAB.Rows(k)("RQ"), Decimal)
                            Dim qOut As Decimal = 0

                            If quantToSell > rq Then
                                qOut = rq
                                quantToSell = Math.Abs(quantToSell) - qOut
                            Else
                                qOut = quantToSell
                                If (rq - qOut < 0.002) Then qOut = rq 'ratio 1/500
                                quantToSell = 0
                            End If


                            If stockIndice = 0 Then
                                If (qOut = rq) Then
                                    ATableAdapter.Update_RQ_Exact(0, idInput)
                                Else
                                    ATableAdapter.Update_RQ(qOut, idInput)
                                End If
                                RSTableAdapter.Insert(idCS, idInput, 0, qOut, idSellPr)

                                factTableAdapter.Insert("UpdateRQ", "UpdateRQAllStock", "InputPrice", "Update_RQ", qOut & ":" & idInput, Date.Now, 0)
                                factTableAdapter.Insert("UpdateRQ", "UpdateRQAllStock", " RS_Stock_Selling", "Insert", idCS & ":" & idInput & ":" & 0 & ":" & qOut & ":" & idSellPr, Date.Now, 0)

                            Else
                                BTableAdapter.Update_RQ(qOut, idInput)
                                RSTableAdapter.Insert(idCS, idInput, 1, qOut, idSellPr)

                                factTableAdapter.Insert("UpdateRQ", "UpdateRQAllStock", "Cip", "Update_RQ", qOut & ":" & idInput, Date.Now, 0)
                                factTableAdapter.Insert("UpdateRQ", "UpdateRQAllStock", " RS_Stock_Selling", "Insert", idCS & ":" & idInput & ":" & 1 & ":" & qOut & ":" & idSellPr, Date.Now, 0)

                            End If

                            k = k + 1
                        End While
                        waitUpdateTableAdapter.Update_UpdState_ById(True, Date.Now, idUpdateWait)
                        factTableAdapter.Insert("UpdateRQ", "UpdateRQAllStock", " WaitToUpdateRQ", "Update_UpdState_ById", True & ":" & idUpdateWait, Date.Now, 0)

                    End If
                Next

                Return True
            Catch ex As Exception
                MsgBox("Có lỗi tại func UpdateRQAllStock", MsgBoxStyle.Critical, "Lỗi")

                Return False
            End Try

        End Function
    End Class


End Class
