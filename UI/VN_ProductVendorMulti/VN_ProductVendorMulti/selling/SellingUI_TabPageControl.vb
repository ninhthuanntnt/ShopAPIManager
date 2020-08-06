Public Class SellingUI_TabPageControl
    Private mainManager As SellingUI_Container
    Private mainManager02 As SellingUI_Container_02
    Private clientNum As String
    Public Sub doSetConfig(ByVal manager As SellingUI_Container, ByVal client As String)
        mainManager = manager
        clientNum = client
    End Sub

    Public Sub doSetConfig02(ByVal manager As SellingUI_Container_02, ByVal client As String)
        mainManager02 = manager
        clientNum = client
    End Sub


    Private Sub SellingUIControl_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        blockTextChanged = False
        Try
            SellingUI_NumericKeyBoard.Close()
        Catch ex As Exception

        End Try
        Try
            SellingUI_AlphaNumKeyBoard_Client.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub SellingUIControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub initConfig()
        blockTextChanged = True
        clear_0()
        clear_1()
        clear_2()
        clear_3()
        Me.txtCodingBarOrig.Select()

        blockTextChanged = False

        group_01.Enabled = True
        group_02.Enabled = True
        group_03.Enabled = True

        isSelling = True
    End Sub



    Public Sub clear_0()

    End Sub
    Public Sub clear_1()
        txtCodingPrescription.Text = ""
        txtCodingBarOrig.Text = ""
        txtCodingBarOrig.Enabled = True

        cmbProductName.Text = ""
        cmbProductName.Enabled = True

        cmbSellingUnit.Text = ""
        cmbSellingUnit.Enabled = True

        cmbPrice.Text = ""
        txtQuant.Text = ""
        txtQuant.Enabled = True
    End Sub
    Public Sub clear_2()
        txtTotalAmount.Text = ""
        txtDiscount.Text = ""
        txtSumReception.Text = ""
        txtSumReturn.Text = ""
    End Sub
    Private Sub clear_3()
        Try
            SListDataGridView.Rows.Clear()
        Catch ex As Exception
        End Try

        Try
            PrescripDataGridView.Rows.Clear()
        Catch ex As Exception
        End Try

        Try
            PrescripDetailDataGridView.Rows.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub doInitView()
        Me.Dock = DockStyle.Fill
        blockTextChanged = False

        Me.RS_Seller_CSeTableAdapter.Fill(Me.pharmacyDataSet.RS_Seller_CSe)
        Me.ProductNameTableAdapter.Fill(Me.pharmacyDataSet.ProductName)

        Dim h = Math.Abs((group_03.Location.Y - group_01.Location.Y - group_01.Height) - 2)
        groupAll.SplitterDistance = h
        groupB.Visible = False
        groupA.Visible = True

        butRight.Visible = False
        butLeft.Visible = False
        butUp.Visible = False
        butDown.Visible = False

        chkPrinter.Checked = True
        chkPrinter.Text = "In hóa đơn"

        initConfig()
    End Sub
    Public Sub doResetView()
        initConfig()
    End Sub
    Private Sub doDesactivateView()
        group_01.Enabled = False
        group_02.Enabled = False
        group_03.Enabled = False

        isSelling = False
    End Sub



    Private Sub txtCodingBarOrig_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCodingBarOrig.Click
        closeAllSubWin()

        blockTextChanged = True
        clear_1()
        blockTextChanged = False
    End Sub
    Private Sub txtCodingBarOrig_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodingBarOrig.KeyDown
        If blockTextChanged Then Return
        Try
            If e.KeyCode = Keys.Enter Then
                doFinishReadProductKey(txtCodingBarOrig.Text)
            End If
        Catch ex As Exception
            'MsgBox("Có lỗi kết nối, đợi vài giây rồi làm lại", vbOKOnly, "Thông báo")
            MsgBoxTool.doShowErr("msg_err_db_conn")
        End Try
    End Sub
    Private Sub doFinishReadProductKey(ByVal numVal As String)
        'ProductDetailPopup.Visible = True
        blockTextChanged = True
        cmbProductName.Text = ""
        blockTextChanged = False
        findListProductByCode()
        If (Not getProdInfo(0)) Then
            txtCodingBarOrig.Text = ""
            Return
        End If


        If ProductInfoDataGridView.RowCount = 1 Then
            Me.txtQuant.Select()
            'ProductDetailPopup.Visible = False
            txtQuant.Text = "1"
            SellingUI_NumericKeyBoard.ShowMe(Nothing, txtQuant, butOK)
        Else
            If ProductInfoDataGridView.RowCount > 1 Then
                'ProductDetailPopup.Focus()
                txtQuant.Text = "1"
            Else
                Me.txtCodingBarOrig.Focus()
                txtCodingBarOrig.SelectAll()
            End If
        End If
    End Sub
    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged
        If blockTextChanged Then Return
        'If ProductDetailPopup.Visible = False Then ProductDetailPopup.Visible = True
        blockTextChanged = True
        Try
            txtCodingBarOrig.Text = ""
            blockTextChanged = False
            findListProductByProdName()
            getProdInfo(0)
        Catch ex As Exception
            MsgBox("Có lỗi kết nối, đợi vài giây rồi làm lại", vbOKOnly, "Thông báo")
        End Try
    End Sub
    Private Sub cmbProductName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProductName.GotFocus
        txtCodingBarOrig.Text = ""
    End Sub

    Private Sub txtQuant_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuant.GotFocus
        ProductDetailPopup.Visible = False
        SellingUI_NumericKeyBoard.ShowMe(Nothing, txtQuant, butOK)
    End Sub
    Private Sub txtQuant_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtQuant.Click
        closeAllSubWin()

        ProductDetailPopup.Visible = False
        SellingUI_NumericKeyBoard.ShowMe(Nothing, txtQuant, butOK)
    End Sub
    Private Sub txtQuant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuant.KeyDown
        If e.KeyCode = Keys.Enter Then
            addSell()
        End If
    End Sub

    Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
        closeAllSubWin()

        Try
            addSell()
        Catch ex As Exception
            MsgBox("Có lỗi kết nối, đợi vài giây rồi làm lại", vbOKOnly, "Thông báo")
        End Try

    End Sub

    Private Sub closeAllSubWin()
        Try
            SellingUI_NumericKeyBoard.Close()
        Catch ex As Exception

        End Try
        Try
            SellingUI_AlphaNumKeyBoard_Client.Close()
        Catch ex As Exception

        End Try
        Try
            SellingUI_GroupProduct.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub butClosePopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClosePopup.Click
        ProductDetailPopup.Visible = False
    End Sub
    Private Sub chkA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkA.CheckedChanged
        If chkA.Checked = False Then Return
        chkB.Checked = False
        chkAthenB.Checked = False
        chkBthenA.Checked = False
    End Sub
    Private Sub chkB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkB.CheckedChanged
        If chkB.Checked = False Then Return
        chkA.Checked = False
        chkAthenB.Checked = False
        chkBthenA.Checked = False
    End Sub
    Private Sub chkAthenB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAthenB.CheckedChanged
        If chkAthenB.Checked = False Then Return
        chkB.Checked = False
        chkA.Checked = False
        chkBthenA.Checked = False
    End Sub
    Private Sub chkBthenA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBthenA.CheckedChanged
        If chkBthenA.Checked = False Then Return
        chkB.Checked = False
        chkA.Checked = False
        chkAthenB.Checked = False
    End Sub
    Private Sub txtSumReception_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSumReception.KeyDown
        If e.KeyCode = Keys.Enter Then
            computeSumReturn()
        End If
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            computeSumReturn()
        End If
    End Sub
    Private Sub txtDiscountPercent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscountPercent.KeyDown
        If e.KeyCode = Keys.Enter Then
            computeDiscount()
        End If
    End Sub

    ' end control------------------------------------------------------

    'Variable global
    Private indicateurFocus As Integer = 0
    Private isSelling = False
    Private blockTextChanged = False
    'Private numLine = 0
    'Private pName = ""
    'Private idProductInfo As Integer

    Private stockAB As DataTable
    Private stockAinUse As Integer = 0
    Private stockBinUse As Integer = 1



    Private Sub findListProductByCode()
        If blockTextChanged Then Return
        Dim sCoding = "%" + txtCodingBarOrig.Text.Trim + "%"
        ProductInfoTableAdapter.FillBy_BarCode(Me.pharmacyDataSet.ProductInfo, sCoding)
    End Sub
    Private Sub findListProductByProdName()
        If blockTextChanged Then Return
        Dim sName = "%" + cmbProductName.Text.Trim + "%"
        ProductInfoTableAdapter.FillBy_BarCOrig_ProdName_BarC_NumReg_Loc(Me.pharmacyDataSet.ProductInfo, "%", sName, "%", "%", "%")
    End Sub
    Private Function getProdInfo(ByVal rowIndex As Integer) As Boolean
        Try
            If ProductInfoDataGridView.RowCount <= 0 Then Return False

            blockTextChanged = True
            clear_1()

            Dim idProductInfo = ProductInfoDataGridView("colIdProdInfo", rowIndex).Value
            cmbProductName.Text = ProductInfoDataGridView("colProductName", rowIndex).Value
            cmbProductName.SelectedValue = idProductInfo
            txtQuant.Text = "1"

            blockTextChanged = False

            'get list of price
            If Not getPrice(idProductInfo) Then
                blockTextChanged = True
                cmbProductName.Text = ""
                blockTextChanged = False
                Return False
            End If
            Return True
            'If Not getStock(idProductInfo, stockAinUse, stockBinUse) Then Return

        Catch ex As Exception
            MsgBox("Có lỗi kết nối, đợi vài giây rồi làm lại", vbOKOnly, "Thông báo")
            Return False
        End Try

    End Function
    Private Function getPrice(ByVal idProduct As Integer) As Boolean
        Dim listPrices = PriceForSellingTableAdapter.GetBy_IdProductInfo(idProduct)
        If (listPrices.Rows.Count <= 0) Then
            MsgBox("sản phẩm này chưa áp dụng giá bán", MsgBoxStyle.Critical, "Cảnh báo")
            Return False
        End If

        PriceForSellingTableAdapter.FillBy_IdProductInfo(pharmacyDataSet.PriceForSelling, idProduct)
        Return True
    End Function

    Private Sub addSell()
        ProductDetailPopup.Visible = False
        If cmbSellingUnit.SelectedValue <= 0 Then
            MsgBox("Cần chọn lại đơn vị bán ra", MsgBoxStyle.Information)
            Return
        End If


        Dim quantToSelle As Decimal = CType(Val(txtQuant.Text.Replace(",", ".").Replace(" ", "")), Decimal)
        Dim idSellingPrice As Integer = cmbSellingUnit.SelectedValue
        Dim productName As String = cmbProductName.Text.Trim
        Dim idProductInfo As Integer = cmbProductName.SelectedValue

        Dim ok As Boolean = checkAvailableQuantityAndInsert(idProductInfo, productName, quantToSelle, idSellingPrice, False, 0)
        'ok = outStock(idProductInfo, pName, sQuant, idSellingPrice, False, 0)
        If ok Then
            updateSummary()
            Me.txtCodingBarOrig.Select()
        End If

    End Sub
    Public Function addPrescriptionSell(ByVal PrespId As Integer, ByVal PrescripName As String, ByVal PrescripQ As Decimal, ByVal PrescripAmount As Decimal) As Boolean
        'If Not checkPrescriptionInSellingList(PrespId) Then Return False

        If PrescripDataGridView.RowCount = 0 Then
            Dim h = (group_03.Location.Y - group_01.Location.Y - group_01.Height) - 2
            groupAll.SplitterDistance = Math.Min(120, h * 2 / 5)
            groupB.Visible = True
            groupB.SplitterDistance = 370

            butRight.Visible = True
            butLeft.Visible = True
            butUp.Visible = True
            butDown.Visible = True
        End If

        PrescripDataGridView.Rows.Add()
        Dim numLine = PrescripDataGridView.Rows.Count
        Dim row = PrescripDataGridView.Rows(numLine - 1)

        row.Cells("colPrescripOrder").Value = numLine
        row.Cells("colPrescripId").Value = PrespId
        row.Cells("colPrescripName").Value = PrescripName
        row.Cells("colPrescripPrice").Value = PrescripAmount
        row.Cells("colPrescripQ").Value = PrescripQ

        Dim amount As Decimal = PrescripQ * PrescripAmount
        row.Cells("colPrescripAmount").Value = amount

        PrescripDataGridView.ClearSelection()
        PrescripDataGridView.Rows(numLine - 1).Selected = True
        PrescripDataGridView.FirstDisplayedScrollingRowIndex = numLine - 1
        Return True
    End Function
    Private Function checkPrescriptionInSellingList(ByVal idPrescription As Integer) As Boolean
        For i = 0 To PrescripDataGridView.Rows.Count - 1
            Dim row = PrescripDataGridView.Rows(i)
            If row.Cells("colPrescripId").Value = idPrescription Then
                MsgBox("Có lỗi, không thể bán cùng 1 đơn sản phẩm 2 lần! Nếu bán số lượng nhiều hơn hoặc ít hơn dụ kiến ban đầu, hãy xóa dòng cũ rồi bán lại!", MsgBoxStyle.Critical, "Lỗi")
                Return False
            End If
        Next
        Return True

    End Function
    Public Function checkExisting(ByVal idProductInfo As Integer) As Boolean
        Dim rows = SListDataGridView.Rows
        For k = 0 To rows.Count - 1
            Dim idP As Integer = rows(k).Cells("colIdProd").Value
            If idP = idProductInfo Then
                MsgBox("Có lỗi, không thể bán cùng 1 loại sản phẩm 2 lần! Nếu bán số lượng nhiều hơn hoặc ít hơn dụ kiến ban đầu, hãy xóa dòng cũ rồi bán lại!", MsgBoxStyle.Critical, "Lỗi")
                Return False
            End If
        Next
        Return True
    End Function
    Public Function checkAvailableQuantityAndInsert(ByVal idProductInfo As Integer, ByVal productName As String, ByVal quantToSell As Decimal, ByVal idSellingPrice As Integer, ByVal forCache As Boolean, ByVal prescriptionOrder As Integer) As Boolean
        'If checkExisting(idProductInfo) Then
        Try
            Dim priceInfo = SellingPriceTableAdapter.GetBy_Id(idSellingPrice)
            Dim ratio = priceInfo.Rows(0)("ratio")
            Dim rq = RQOfProductTableAdapter.Get_RQ(idProductInfo, stockAinUse, stockBinUse).Rows(0)("rq")

            Dim rqOld = rq
            rq = Math.Round(rq, 4)
            If rq < rqOld Then rq = rq + 0.0001

            If (rq > 0 And rq * ratio >= quantToSell) Then
                insertLineToTab(idProductInfo, productName, priceInfo, quantToSell, forCache, prescriptionOrder)

                blockTextChanged = True
                clear_1()
                blockTextChanged = False

                Return True
            Else
                ' MsgBox("Với giá này, kho không dủ sản phẩm, số lượng tối đa cho phép " & Math.Round(rq * ratio, 2) & "!", MsgBoxStyle.Exclamation, "Cảnnh báo")
                MsgBox("Không được phép bán với số lượng này !", MsgBoxStyle.Exclamation, "Cảnnh báo")
                txtQuant.Text = "0" ' (rq * ratio)
                Return False
            End If

        Catch ex As Exception
            MsgBox("Không tìm thấy thông tin với giá và tỷ lệ bán của sản phẩm", MsgBoxStyle.Exclamation, "Thông báo")
        End Try
        'End If
        Return False
    End Function
    Public Function checkAvailableQuantity(ByVal idProductInfo As Integer, ByVal productName As String, ByVal quantToSell As Decimal, ByVal idSellingPrice As Integer) As Boolean
        'If checkExisting(idProductInfo) Then
        Try
            Dim priceInfo = SellingPriceTableAdapter.GetBy_Id(idSellingPrice)
            Dim ratio = priceInfo.Rows(0)("ratio")
            Dim rq = RQOfProductTableAdapter.Get_RQ(idProductInfo, stockAinUse, stockBinUse).Rows(0)("rq")

            Dim rqOld = rq
            rq = Math.Round(rq, 4)
            If rq < rqOld Then rq = rq + 0.0001

            If (rq > 0 And rq * ratio >= quantToSell) Then
                Return True
            Else
                MsgBox("Với giá này, kho không dủ sản phẩm, số lượng tối đa cho phép " & Math.Round(rq * ratio, 2) & "!", MsgBoxStyle.Exclamation, "Cảnnh báo: " & productName)
                Return False
            End If

        Catch ex As Exception
            MsgBox("Không tìm thấy thông tin với giá và tỷ lệ bán của sản phẩm", MsgBoxStyle.Exclamation, "Thông báo")
        End Try
        'End If
        Return False
    End Function

    Private Sub insertLineToTab(ByVal idProductInfo As Integer, ByVal pName As String,
                                ByVal priceInfo As DataTable, ByVal quantityToSell As Decimal,
                                ByVal forCache As Boolean, ByVal idPrescription As Integer)
        If Not forCache Then
            ' SDataGridView.Rows.Add()
            SListDataGridView.Rows.Add()
            Dim numLine = SListDataGridView.Rows.Count
            Dim row = SListDataGridView.Rows(numLine - 1)

            row.Cells("colSTT").Value = numLine
            row.Cells("colProdName").Value = pName
            row.Cells("colIdProd").Value = idProductInfo

            row.Cells("colQ").Value = quantityToSell
            Dim amount As Decimal = quantityToSell * priceInfo.Rows(0)("SellingPrice")
            row.Cells("colAmount").Value = amount

            row.Cells("colIdSPrice").Value = priceInfo.Rows(0)("id")
            row.Cells("colRatio").Value = priceInfo.Rows(0)("Ratio")
            row.Cells("colUnit").Value = priceInfo.Rows(0)("Unit")
            row.Cells("colPrice").Value = priceInfo.Rows(0)("SellingPrice")

            SListDataGridView.ClearSelection()
            SListDataGridView.Rows(numLine - 1).Selected = True
            SListDataGridView.FirstDisplayedScrollingRowIndex = numLine - 1
        Else
            ' SDataGridView.Rows.Add()
            PrescripDetailDataGridView.Rows.Add()
            Dim numLine = PrescripDetailDataGridView.Rows.Count
            Dim row = PrescripDetailDataGridView.Rows(numLine - 1)

            row.Cells("colMyPrescripOrder").Value = idPrescription
            row.Cells("colProdName_Cache").Value = pName
            row.Cells("colIdProd_Cache").Value = idProductInfo

            row.Cells("colQ_Cache").Value = quantityToSell
            Dim amount As Decimal = quantityToSell * priceInfo.Rows(0)("SellingPrice")
            row.Cells("colAmount_Cache").Value = amount

            row.Cells("colIdSPrice_Cache").Value = priceInfo.Rows(0)("id")
            row.Cells("colRatio_Cache").Value = priceInfo.Rows(0)("Ratio")
            row.Cells("colUnit_Cache").Value = priceInfo.Rows(0)("Unit")
            row.Cells("colPrice_Cache").Value = priceInfo.Rows(0)("SellingPrice")

            PrescripDetailDataGridView.ClearSelection()
            PrescripDetailDataGridView.Rows(numLine - 1).Selected = True
            PrescripDetailDataGridView.FirstDisplayedScrollingRowIndex = numLine - 1
        End If

    End Sub



    Private Function outTable(ByVal idCSe As Integer)
        If idCSe <= 0 Then Return False
        Dim rows = SListDataGridView.Rows
        For k = 0 To rows.Count - 1
            'get price info
            Dim idProdInf As Integer = rows(k).Cells("colIdProd").Value
            Dim idSellPrice As Integer = rows(k).Cells("colIdSPrice").Value
            Dim ratio As Decimal = rows(k).Cells("colRatio").Value
            Dim sellingUnit = rows(k).Cells("colUnit").Value
            Dim sQuant As Decimal = rows(k).Cells("colQ").Value
            Dim sPrice As Decimal = rows(k).Cells("colPrice").Value

            outStockToSell(idCSe, idProdInf, sQuant, idSellPrice, sellingUnit, sPrice, ratio, 0)
        Next

        rows = PrescripDetailDataGridView.Rows
        For k = 0 To rows.Count - 1
            'get price info
            Dim idPrescription As Integer = rows(k).Cells("colMyPrescripOrder").Value
            Dim idProdInf As Integer = rows(k).Cells("colIdProd_Cache").Value
            Dim idSellPrice As Integer = rows(k).Cells("colIdSPrice_Cache").Value
            Dim ratio As Decimal = rows(k).Cells("colRatio_Cache").Value
            Dim sellingUnit = rows(k).Cells("colUnit_Cache").Value
            Dim sQuant As Decimal = rows(k).Cells("colQ_Cache").Value
            Dim sPrice As Decimal = rows(k).Cells("colPrice_Cache").Value

            outStockToSell(idCSe, idProdInf, sQuant, idSellPrice, sellingUnit, sPrice, ratio, idPrescription)
        Next

        Return True
    End Function
    Private Function outStockToSell(ByVal idSell As Integer,
                                   ByVal idProductInfo As Integer, ByVal quantToSell As Decimal,
                                   ByVal idSellPrice As Integer, ByVal sellingUnit As String, ByVal sellingPr As Decimal, ByVal ratio As Decimal,
                                   ByVal idPrescription As Integer) As Boolean
        stockAB = AllStocksForSellingTableAdapter.GetStockABBy_IdProduct(idProductInfo, stockAinUse, stockBinUse)

        Try

            Dim idCS = CSTableAdapter.InsertRow(idSellPrice, idProductInfo, sellingPr, ratio, quantToSell, sellingUnit, idSell, idPrescription)
            If idCS <= 0 Then
                System.Threading.Thread.Sleep(200)
                idCS = CSTableAdapter.InsertRow(idSellPrice, idProductInfo, sellingPr, ratio, quantToSell, sellingUnit, idSell, idPrescription)
                If idCS <= 0 Then Throw New Exception("Lỗi tại CSTable-insert o outStockToSell")
            End If


            Dim idWait = WaitToUpdateRQTableAdapter.InsertRow(idProductInfo, idCS, quantToSell / ratio, False, Date.Now, Nothing, idSellPrice)

            LogTool.log("SellingUIControl_Mobile", "savingSellingList", "CS", "InsertRow", idSellPrice & ":" & idProductInfo & ":" & sellingPr & ":" & ratio & ":" & quantToSell & ":" & sellingUnit & ":" & idSell, Date.Now, idCS)
            LogTool.log("SellingUIControl_Mobile", "savingSellingList", "WaitToUpdateRQ", "InsertRow", idProductInfo & ":" & idCS & ":" & (quantToSell / ratio) & ":...:" & idSellPrice, Date.Now, idWait)

            Return True
        Catch ex As Exception
            MsgBox("Có lỗi tại func outStockToSell", MsgBoxStyle.Critical, "Lỗi")
            Return False
        End Try
    End Function

    Sub savingSellingList()

        'su dung transaction de dam bao du lieu khong bi mat neu may truc trac
        'chua ap dung vao chuong trinh chinh

        Try
            Dim sum As Decimal = Val(txtTotalAmount.Text.Replace(",", ".").Replace(" ", ""))
            Dim disc As Decimal = Val(txtDiscount.Text.Replace(",", ".").Replace(" ", ""))
            Dim disc2 As Decimal = Val(txtDiscountPercent.Text.Replace(",", "."))
            If disc2 <> 0 Then disc = sum * disc2 / 100
            txtDiscount.Text = disc

            Dim sumCl As Decimal = Val(txtSumReception.Text.Replace(",", ".").Replace(" ", ""))
            Dim sumR As Decimal = getSumReturn(sum, disc, sumCl)

            txtSumReturn.Text = MyFunct.formatNum(sumR)
            If (sumR < 0 Or sumR > sumCl) Then
                MsgBox("Kiểm tra lại số liệu bán, không thể cho không sản phẩm", MsgBoxStyle.Critical, "Cảnh báo")
                Return
            End If

            'create clientInvoice
            Dim idClient As Integer = 0
            Try
                idClient = MyFunct.getVal(txtClientId.Text.Trim)
                txtClientId.Text = "0"
            Catch ex As Exception

            End Try

            Dim sellingDate = Date.Now

            'Tham khao: http://msdn.microsoft.com/en-us/library/aa581778.aspx
            Dim withPrescription As Boolean = PrescripDataGridView.RowCount > 0
            Dim idSe As Integer = CSeTableAdapter.InsertRow(sellingDate, disc, sum, sumCl, sumR, idClient, withPrescription)
            If idSe <= 0 Then Return
            LogTool.log("SellingUIControl_Mobile", "savingSellingList", "CSe", "InsertRow", disc & ":" & sum & ":" & sumCl & ":" & sumR & ":" & idClient & ":" & withPrescription, Date.Now, idSe)

            For i = 0 To PrescripDataGridView.RowCount - 1
                Dim idPres As Integer = PrescripDataGridView.Rows(i).Cells("colPrescripId").Value
                Dim q As Decimal = PrescripDataGridView.Rows(i).Cells("colPrescripQ").Value
                If idPres > 0 Then
                    RS_Prescription_CSeTableAdapter.Insert(idPres, idSe, q, 1)
                    LogTool.log("SellingInterface", "savingSellingList", "RS_Prescription_CSe", "InsertRow", idPres & ":" & idSe, Date.Now, idSe)
                End If
            Next



            Dim idSeller As Integer = Math.Round(Val(txtSeller.Text.Replace(",", ".").Replace(" ", "")), 0)
            If idSeller > 0 Then
                RS_Seller_CSeTableAdapter.Insert(idSeller, idSe)
                LogTool.log("SellingUIControl_Mobile", "savingSellingList", " RS_Seller_CSe", "Insert", idSeller & ":" & idSe, Date.Now, 0)
            End If


            'System.Threading.Thread.Sleep(50)
            outTable(idSe)
            UpdateRQ.launchThreadUpdate(Fact_UpdateInsertDeleteTableAdapter1, WaitToUpdateRQTableAdapter, AllStocksForSellingTableAdapter, RS_Stock_SellingTableAdapter, InputPriceTableAdapter, CipTableAdapter)


            Try
                If chkPrinter.Checked Then
                    'If m_Printer Is Nothing Then m_Printer = PrinterUtilities.initPrinter("PosPrinter")
                    'PrinterUtilities.enablePrinter(m_Printer)

                    getListProductAndAmount()
                    Dim separator As String = "~~"
                    Dim sIdProduct As String = String.Join(separator, listIdProduct)
                    Dim sProduct = String.Join(separator, listProduct)
                    Dim sUnit = String.Join(separator, listUnit)
                    Dim sQ = String.Join(separator, listQ)
                    Dim sPrice = String.Join(separator, listPrice)

                    Dim clientIn As Decimal = Val(txtSumReception.Text.Replace(",", ".").Replace(" ", ""))
                    Dim clientOut As Decimal = Val(txtSumReturn.Text.Replace(",", ".").Replace(" ", ""))
                    Dim idVendor As Integer = Val(txtSeller.Text.Replace(",", ".").Replace(" ", ""))

                    Dim sumFinal As Decimal = sum - disc
                    DataTableAdapter.InsertRow(sProduct, sPrice, sQ, sum, disc, sumFinal, True, False, idSe, sIdProduct, clientIn, clientOut, idVendor, sUnit)

                    'PrinterUtilities.print(m_Printer, True, listProduct, listQ, listPrice, sum, disc, sumCl)
                    'PrinterUtilities.realeasePrinter(m_Printer)
                End If
            Catch ex As Exception

            End Try


            group_01.Enabled = False
            group_02.Enabled = False
            group_03.Enabled = False
            isSelling = False

            label_lastIdSell.Text = "N°: " & idSe

            doDesactivateView()
        Catch ex As Exception
            MsgBox("Có lỗi tại  func savingSelling, error = " & ex.Message, MsgBoxStyle.Critical, "Lỗi")
        End Try
    End Sub

    'summary'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub computeDiscount()
        Dim sum As Decimal = Val(txtTotalAmount.Text.Replace(",", ".").Replace(" ", ""))
        Dim disc As Decimal = Val(txtDiscount.Text.Replace(",", "."))
        Dim disc2 As Decimal = Val(txtDiscountPercent.Text.Replace(",", "."))
        If disc2 <> 0 Then disc = sum * disc2 / 100
        txtDiscount.Text = disc
    End Sub
    Private Sub computeSumReturn()
        computeDiscount()

        Dim sum = Val(txtTotalAmount.Text.Replace(",", ".").Replace(" ", ""))
        Dim disc = Val(txtDiscount.Text.Replace(",", ".").Replace(" ", ""))
        Dim sumCl = Val(txtSumReception.Text.Replace(",", ".").Replace(" ", ""))
        Dim sumR = getSumReturn(sum, disc, sumCl)

        txtDiscount.Text = MyFunct.formatNum(disc)
        txtSumReception.Text = MyFunct.formatNum(sumCl)
        txtSumReturn.Text = MyFunct.formatNum(sumR)
    End Sub
    Private Function getSumReturn(ByVal sum As Decimal, ByVal discount As Decimal, ByVal sumIn As Decimal) As Decimal
        Return sumIn - (sum - discount)
    End Function
    Private Function getSum() As Decimal
        Dim rows = SListDataGridView.Rows
        Dim sum As Decimal = 0
        For k = 0 To rows.Count - 1
            sum = sum + CType(rows(k).Cells("colAmount").Value, Decimal)
        Next

        rows = PrescripDataGridView.Rows
        For k = 0 To rows.Count - 1
            sum = sum + CType(rows(k).Cells("colPrescripAmount").Value, Decimal)
        Next

        Return sum

    End Function
    Public Sub updateSummary()
        txtTotalAmount.Text = MyFunct.formatNum(getSum())
    End Sub
    '-------------------------------------------------

    Private Sub butEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClientEnd.Click
        closeAllSubWin()
        savingSellingList()
    End Sub

    Private Sub butClientMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClientMoney.Click
        closeAllSubWin()
        Try
            Dim sum As Decimal = Val(txtTotalAmount.Text.Replace(",", ".").Replace(" ", ""))

            Dim disc As Decimal = Val(txtDiscount.Text.Replace(",", ".").Replace(" ", ""))
            Dim disc2 As Decimal = Val(txtDiscountPercent.Text.Replace(",", "."))
            If disc2 <> 0 Then disc = sum * disc2 / 100
            txtDiscount.Text = MyFunct.formatNum(disc)

            Dim clientSum = sum - disc
            txtSumReception.Text = MyFunct.formatNum(clientSum)

        Catch ex As Exception

        End Try

    End Sub
    Private Sub butAddOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim v = Val(txtQuant.Text)
            v = v + 1
            txtQuant.Text = v
        Catch ex As Exception
            txtQuant.Text = 1
        End Try

    End Sub
    Private Sub butAddTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim v = Val(txtQuant.Text)
            v = v + 2
            txtQuant.Text = v
        Catch ex As Exception
            txtQuant.Text = 1
        End Try
    End Sub
    Private Sub cmbSellingUnit_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbSellingUnit.Click
        closeAllSubWin()

        SellingUI_NumericKeyBoard.Hide()
    End Sub
    Private Sub cmbSellingUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSellingUnit.SelectedIndexChanged
        txtQuant.Text = 1
    End Sub

    Private Sub txtSumReception_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSumReception.Click
        closeAllSubWin()

        Dim msd As SubDelegate = AddressOf Me.computeSumReturn
        SellingUI_NumericKeyBoard.ShowMe(txtSumReception, msd)
    End Sub


    Private Sub txtDiscount_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDiscount.Click
        closeAllSubWin()

        SellingUI_NumericKeyBoard.ShowMe(txtDiscount)
    End Sub
    Private Sub txtDiscountPercent_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDiscountPercent.Click
        closeAllSubWin()

        SellingUI_NumericKeyBoard.ShowMe(txtDiscountPercent)
    End Sub

    Private Sub butClientCalcul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClientCalcul.Click
        closeAllSubWin()
        computeSumReturn()
    End Sub
    Private Sub SellingUIControl_Mobile_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.Click
        closeAllSubWin()

        Me.Focus()
    End Sub

    Private Sub butDelLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDelLine.Click
        closeAllSubWin()
        If indicateurFocus = 1 Then
            Dim row = SListDataGridView.SelectedRows
            If row.Count = 0 Then
                MsgBox("Hãy chọn một dòng", MsgBoxStyle.Exclamation, "Thông báo")
                Return
            End If
            SListDataGridView.Rows.Remove(row(0))

            For i = 0 To SListDataGridView.Rows.Count - 1
                SListDataGridView.Rows(i).Cells("colSTT").Value = (i + 1)
            Next
        ElseIf indicateurFocus = 2 Then
            Dim row = PrescripDataGridView.SelectedRows
            If row.Count = 0 Then
                MsgBox("Hãy chọn một dòng", MsgBoxStyle.Exclamation, "Thông báo")
                Return
            End If
            Dim idPres As Integer = row(0).Cells("colPrescripId").Value
            PrescripDataGridView.Rows.Remove(row(0))
            Dim k = 0
            While k < PrescripDetailDataGridView.RowCount
                If PrescripDetailDataGridView.Rows(k).Cells("colMyPrescripOrder").Value = idPres Then
                    PrescripDetailDataGridView.Rows.RemoveAt(k)
                Else
                    k = k + 1
                End If
            End While
            If PrescripDataGridView.RowCount = 0 Then
                If PrescripDataGridView.RowCount = 0 Then
                    Dim h = (group_03.Location.Y - group_01.Location.Y - group_01.Height) - 2
                    groupAll.SplitterDistance = h
                    groupB.Visible = False
                    butRight.Visible = False
                    butLeft.Visible = False
                    butUp.Visible = False
                    butDown.Visible = False
                End If
            End If
        Else : Return
        End If


        updateSummary()
    End Sub

    Private Sub butDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDiscount.Click
        closeAllSubWin()

        Dim row = SListDataGridView.SelectedRows
        If row.Count = 0 Then
            MsgBox("Hãy chọn một dòng", MsgBoxStyle.Exclamation, "Thông báo")
            Return
        End If

        Dim pName As String = SListDataGridView.SelectedRows(0).Cells("colProdName").Value
        Dim idProd As Decimal = SListDataGridView.SelectedRows(0).Cells("colIdProd").Value
        Dim idPrice As Decimal = SListDataGridView.SelectedRows(0).Cells("colIdSPrice").Value
        Dim unitPrice As String = SListDataGridView.SelectedRows(0).Cells("colUnit").Value
        Dim sQuant As Decimal = SListDataGridView.SelectedRows(0).Cells("colQ").Value

        Dim tabPriceInp As DataTable = PriceInputMaxTableAdapter.GetBy_IdProduct(idProd)
        Dim tabPriceOut As DataTable = PriceForSellingTableAdapter.GetBy_IdSellingPrice(idPrice)
        Dim priceInp As Decimal = tabPriceInp(0)("priceInputMax")
        Dim priceOut As Decimal = tabPriceOut(0)("SellingPrice")
        Dim ratio As Decimal = tabPriceOut(0)("Ratio")

        Dim discount As Integer = Math.Round(0.2 * (priceOut * ratio - priceInp) / ratio, 0)
        discount = (discount \ 100) * 100
        If discount < 500 Then discount = 0
        If discount > priceOut / 20 Then discount = priceOut / 20

        If discount > 20000 Then discount = 20000

        Dim allDiscount As Integer = discount * sQuant

        Dim sDisc As String = FormatNumber(discount, 0, TriState.True, TriState.False, TriState.True)
        Dim sAllDisc As String = FormatNumber(allDiscount, 0, TriState.True, TriState.False, TriState.True)
        Dim yesResponse = MsgBox("Cho phép khuyến mãi tối đa: " & sDisc & "đ/" & unitPrice & " và nhân lên: " & sAllDisc & "đ/" & sQuant & " " & unitPrice & ". Bạn muốn áp dụng khuyến mãi?", MsgBoxStyle.YesNo, "Khuyến mãi - " & pName)
        If yesResponse = vbYes Then
            Dim disc As Decimal = Val(txtDiscount.Text.Replace(",", ".").Replace(" ", ""))
            disc = disc + allDiscount
            txtDiscount.Text = MyFunct.formatNum(disc)
        End If

    End Sub

    Private Sub PrescripDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PrescripDataGridView.CellClick
        Try
            PrescripDataGridView.Rows(e.RowIndex).Selected = True
            indicateurFocus = 2
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SListDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SListDataGridView.CellClick
        Try
            SListDataGridView.Rows(e.RowIndex).Selected = True
            indicateurFocus = 1
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtSeller_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSeller.Click
        closeAllSubWin()

        SellingUI_NumericKeyBoard.ShowMe(txtSeller)
    End Sub

    Private listIdProduct() As Integer
    Private listProduct() As String
    Private listUnit() As String
    Private listQ() As Decimal
    Private listPrice() As Decimal
    Private Sub getListProductAndAmount()
        Dim dime = SListDataGridView.Rows.Count + PrescripDataGridView.Rows.Count - 1
        ReDim Preserve listIdProduct(dime)
        ReDim Preserve listProduct(dime)
        ReDim Preserve listUnit(dime)
        ReDim Preserve listQ(dime)
        ReDim Preserve listPrice(dime)

        Dim rows = SListDataGridView.Rows
        For k = 0 To rows.Count - 1
            Try
                listIdProduct(k) = rows(k).Cells("colIdProd").Value
                listProduct(k) = New String(rows(k).Cells("colProdName").Value)

                Dim len = listProduct(k).Length
                If (len > 18) Then len = 18
                listProduct(k) = listProduct(k).Substring(0, len)
                'Dim pos = listProduct(k).IndexOf(" ")
                'If (pos > 0 And pos < 12) Then pos = listProduct(k).IndexOf(" ", pos)
                'If pos > 12 And pos < len Then
                'listProduct(k) = listProduct(k).Substring(0, pos)
                'End If

                listUnit(k) = rows(k).Cells("colUnit").Value
                listQ(k) = Math.Round(rows(k).Cells("colQ").Value, 1)
                listPrice(k) = Math.Round(rows(k).Cells("colAmount").Value, 1)
            Catch ex As Exception

            End Try
        Next

        Dim count = rows.Count
        rows = PrescripDataGridView.Rows
        For k = 0 To rows.Count - 1
            Try
                listIdProduct(k + count) = -rows(k).Cells("colPrescripId").Value
                listProduct(k + count) = New String("* " & rows(k).Cells("colPrescripName").Value)
                listUnit(k + count) = "Liều"
                listQ(k + count) = Math.Round(rows(k).Cells("colPrescripQ").Value, 1)
                listPrice(k + count) = Math.Round(rows(k).Cells("colPrescripAmount").Value, 1)
            Catch ex As Exception

            End Try
        Next
    End Sub


    Private Sub butAddClient_Click(sender As System.Object, e As System.EventArgs) Handles butAddClient.Click
        closeAllSubWin()

        SellingUI_AlphaNumKeyBoard_Client.ShowMe(txtClientId)
    End Sub

    Private Sub txtCodingPrescription_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodingPrescription.KeyDown
        If blockTextChanged Then Return
        Try
            If e.KeyCode = Keys.Enter Then
                doFinishReadGroupKey(txtCodingPrescription.Text)
            End If
        Catch ex As Exception
            MsgBox("Có lỗi kết nối, đợi vài giây rồi làm lại", vbOKOnly, "Thông báo")
        End Try
    End Sub
    Private Sub doFinishReadGroupKey(ByVal numVal As String)
        SellingUI_GroupProduct.doSetUIControllers(Me)
        SellingUI_GroupProduct.Show()
        SellingUI_GroupProduct.Focus()
        SellingUI_GroupProduct.loadPrescriptionName(numVal)
    End Sub

    Private Sub txtCodingPrescription_Click(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtCodingPrescription.Click
        closeAllSubWin()

        blockTextChanged = True
        clear_1()
        blockTextChanged = False
    End Sub


    Private Sub chkPrinter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrinter.CheckedChanged
        If (chkPrinter.Checked) Then
            chkPrinter.Text = "In hóa đơn"
        Else
            chkPrinter.Text = "Không in HĐ"
        End If
    End Sub



    Private Sub butClientClose_Click(sender As System.Object, e As System.EventArgs) Handles butClientClose.Click
        closeAllSubWin()

        If (isSelling) Then
            Dim ok = MsgBox("Thật sự có muốn bỏ qua tất cả?", MsgBoxStyle.YesNo, "Chú ý")
            If ok = MsgBoxResult.Yes Then
                If Not (mainManager Is Nothing) Then
                    mainManager.doClientRemove(clientNum)
                    blockTextChanged = True
                    Me.Dispose()
                End If
                If Not (mainManager02 Is Nothing) Then
                    mainManager02.doClientRemove(Val(clientNum))
                    blockTextChanged = True
                    Me.Dispose()
                End If
            End If
        Else
            If Not (mainManager Is Nothing) Then
                mainManager.doClientRemove(clientNum)
                blockTextChanged = True
                Me.Dispose()
            End If
            If Not (mainManager02 Is Nothing) Then
                mainManager02.doClientRemove(Val(clientNum))
                blockTextChanged = True
                Me.Dispose()
            End If
        End If
    End Sub
    Private Sub butReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butReset.Click
        closeAllSubWin()

        If (isSelling) Then
            Dim ok = MsgBox("Thật sự có muốn bỏ qua tất cả?", MsgBoxStyle.YesNo, "Chú ý")
            If ok = MsgBoxResult.Yes Then
                doResetView()
            End If
        Else
            doResetView()
        End If

    End Sub

    Private Sub butClientClose_MouseEnter(sender As Object, e As System.EventArgs) Handles butClientClose.MouseEnter
        ToolTip1.SetToolTip(butClientClose, "Tắt bỏ cửa sổ tính toán của khách hàng này")
    End Sub
    Private Sub butReset_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles butReset.MouseEnter
        ToolTip1.SetToolTip(butReset, "Bỏ qua, tạo lại bảng mới")
    End Sub
    Private Sub butEnd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles butClientEnd.MouseEnter
        ToolTip1.SetToolTip(butClientEnd, "Kết thúc")
    End Sub

    Private Sub txtClientId_Click(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtClientId.Click
        closeAllSubWin()

        SellingUI_AlphaNumKeyBoard_Client.ShowMe(Nothing, txtClientId, Nothing)
    End Sub


    Private Sub butOK_MouseEnter(sender As Object, e As System.EventArgs) Handles butOK.MouseEnter
        ToolTip1.SetToolTip(butOK, "Bán")
    End Sub

    Private Sub butPrescription_Click(sender As System.Object, e As System.EventArgs) Handles butPrescription.Click
        closeAllSubWin()

        SellingUI_GroupProduct.doSetUIControllers(Me)
        SellingUI_GroupProduct.Show()
        SellingUI_GroupProduct.Focus()
    End Sub

    Private Sub txtCodingPrescription_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtCodingPrescription.MouseDoubleClick
        closeAllSubWin()

        ProductDetailPopup.Visible = False
        Dim msd As SubDelegate = AddressOf Me.doFinishReadGroupKey
        SellingUI_NumericKeyBoard.ShowMe(txtCodingPrescription, msd, ControlLocation.XPos(txtCodingPrescription), ControlLocation.YPos(txtCodingPrescription) + 10)
    End Sub

    Private Sub txtCodingBarOrig_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtCodingBarOrig.MouseDoubleClick
        closeAllSubWin()

        ProductDetailPopup.Visible = False
        Dim msd As SubDelegate = AddressOf Me.doFinishReadProductKey
        SellingUI_NumericKeyBoard.ShowMe(txtCodingPrescription, msd, ControlLocation.XPos(txtCodingBarOrig), ControlLocation.YPos(txtCodingBarOrig) + 10)
    End Sub



    Private Sub butCorrect_Click(sender As System.Object, e As System.EventArgs) Handles butCorrect.Click
        closeAllSubWin()
    End Sub

    Private Sub butDown_Click(sender As System.Object, e As System.EventArgs) Handles butDown.Click
        groupAll.SplitterDistance = groupAll.SplitterDistance + 10
    End Sub

    Private Sub butUp_Click(sender As System.Object, e As System.EventArgs) Handles butUp.Click
        groupAll.SplitterDistance = groupAll.SplitterDistance - 10
    End Sub

    Private Sub butRight_Click(sender As System.Object, e As System.EventArgs) Handles butRight.Click
        groupB.SplitterDistance = groupB.SplitterDistance + 10
    End Sub

    Private Sub butLeft_Click(sender As System.Object, e As System.EventArgs) Handles butLeft.Click
        groupB.SplitterDistance = groupB.SplitterDistance - 10
    End Sub

    Private Sub group_01_Enter(sender As System.Object, e As System.EventArgs) Handles group_01.Enter

    End Sub

    Private Sub butRePrint_Click(sender As Object, e As EventArgs) Handles butRePrint.Click
        Dim idSe = Val(label_lastIdSell.Text)
        printReceipt(idSe)
    End Sub

    Private Sub printReceipt(idSe As Integer)
        Try
            If chkPrinter.Checked Then
                'If m_Printer Is Nothing Then m_Printer = PrinterUtilities.initPrinter("PosPrinter")
                'PrinterUtilities.enablePrinter(m_Printer)
                Dim sum As Decimal = Val(txtTotalAmount.Text.Replace(",", ".").Replace(" ", ""))
                Dim disc As Decimal = Val(txtDiscount.Text.Replace(",", ".").Replace(" ", ""))
                Dim disc2 As Decimal = Val(txtDiscountPercent.Text.Replace(",", "."))
                If disc2 <> 0 Then disc = sum * disc2 / 100

                getListProductAndAmount()
                Dim separator As String = "~~"
                Dim sIdProduct As String = String.Join(separator, listIdProduct)
                Dim sProduct = String.Join(separator, listProduct)
                Dim sUnit = String.Join(separator, listUnit)
                Dim sQ = String.Join(separator, listQ)
                Dim sPrice = String.Join(separator, listPrice)

                Dim clientIn As Decimal = Val(txtSumReception.Text.Replace(",", ".").Replace(" ", ""))
                Dim clientOut As Decimal = Val(txtSumReturn.Text.Replace(",", ".").Replace(" ", ""))
                Dim idVendor As Integer = Val(txtSeller.Text.Replace(",", ".").Replace(" ", ""))

                Dim sumFinal As Decimal = sum - disc

                If (My.Settings.setting_printer_MySelf) Then
                    doPrint(idSe, idVendor, listProduct, listUnit, listQ, listPrice, sum, disc, sumFinal, clientIn, clientOut)
                Else
                    DataTableAdapter.InsertRow(sProduct, sPrice, sQ, sum, disc, sumFinal, True, False, idSe, sIdProduct, clientIn, clientOut, idVendor, sUnit)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------------------
    Private printer_Logo As Image
    Private printer_Ready As Boolean = False
    Private printer_MySelf As Boolean = False
    Private printer_Name As String = ""
    Private printer_Logo_With As Boolean = True
    Private printer_Logo_Width As Integer = 285
    Private printer_Logo_Height As Integer = 50
    Private printer_Logo_Path As String = IO.Directory.GetCurrentDirectory() & "\Resources\Logo.bmp"
    Private printer_Char_NbPerLine As Integer = 47
    Private printer_Char_FontName As String = "Courrier New"
    Private printer_Char_FontSize As Single = 7
    Private printer_NumSelling As String
    Private printer_Vendor As String

    Private printer_Item() As String
    Private printer_Unit() As String
    Private printer_Q() As Decimal
    Private printer_Price() As Decimal

    Private printer_Total_Init As Double
    Private printer_Discount As Double
    Private printer_Total_Final As Double

    Private printer_Sum_In As Double
    Private printer_Sum_Out As Double

    Private Sub loadPrinterConfig()
        printer_MySelf = My.Settings.setting_printer_MySelf
        printer_Name = My.Settings.setting_printer_Name
        printer_Logo_With = My.Settings.setting_printer_Logo_Opt_01
        printer_Logo_Width = MyFunct.getVal(My.Settings.setting_printer_Logo_Opt_02)
        printer_Logo_Height = MyFunct.getVal(My.Settings.setting_printer_Logo_Opt_03)
        printer_Logo_Path = My.Settings.setting_printer_Logo_Opt_04

        '--load logo
        Try
            printer_Logo = Image.FromFile(printer_Logo_Path) 'IO.Directory.GetCurrentDirectory() & "\Resources\Logo.bmp")
        Catch ex As Exception
            Try
                printer_Logo = Image.FromFile(IO.Directory.GetCurrentDirectory() & printer_Logo_Path)
            Catch ex2 As Exception
                printer_Logo_With = False
            End Try
        End Try


        printer_Char_NbPerLine = MyFunct.getVal(My.Settings.setting_printer_Line_Opt_01)
        printer_Char_FontName = My.Settings.setting_printer_Line_Opt_02
        printer_Char_FontSize = MyFunct.getVal(My.Settings.setting_printer_Line_Opt_03)

        If (printer_Name.Length > 0) Then
            doInitPosPrinter(printer_Name)
        End If
    End Sub

    Private Sub doInitPosPrinter(ByVal name)
        POSPrint.PrinterSettings.PrinterName = name
        printer_Ready = True
    End Sub

    Public Sub doPrint(ByVal numSelling As Integer, ByVal idVendor As Integer,
                      ByVal astrItem() As String, ByVal astrUnit() As String, ByVal astrQ() As Decimal, ByVal astrPrice() As Decimal,
                      ByVal initTotal As Double, ByVal discount As Double, ByVal total As Double,
                      ByVal clientIn As Double, ByVal clientOut As Double)

        If (Not printer_Ready) Then
            loadPrinterConfig()
        End If

        'http://www.visual-basic-tutorials.com/print-to-a-receipt-printer-in-visual-basic.html#sthash.UFiNmwsg.dpuf
        printer_NumSelling = numSelling & ""
        printer_Vendor = idVendor & ""


        printer_Item = astrItem
        printer_Unit = astrUnit
        printer_Q = astrQ
        printer_Price = astrPrice

        printer_Total_Init = initTotal
        printer_Discount = discount
        printer_Total_Final = total

        printer_Sum_In = clientIn
        printer_Sum_Out = clientOut

        Dim printControl = New Printing.StandardPrintController
        POSPrint.PrintController = printControl
        Try
            POSPrint.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub POSPrint_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles POSPrint.PrintPage
        Dim txtFont = New Font(printer_Char_FontName, printer_Char_FontSize, FontStyle.Regular)

        'Dim txtFont = New Font("Courier New", 7, FontStyle.Regular)
        'Dim txtFont = New Font("Calibri Light", 8, FontStyle.Regular)
        ' New Font("Calibri Light", 8, FontStyle.Regular) => 40 chars
        ' New Font("Calibri Light", 8, FontStyle.Regular) => 44 chars

        PrinterUtilities.print_receipt(POSPrint, e,
                                       printer_Logo_With, printer_Logo, printer_Logo_Width, printer_Logo_Height,
                                       printer_Char_NbPerLine, txtFont,
                                       printer_NumSelling, printer_Vendor,
                                       printer_Item, printer_Unit, printer_Q, printer_Price,
                                       printer_Total_Init, printer_Discount, printer_Total_Final,
                                       printer_Sum_In, printer_Sum_Out
                                       )
    End Sub

    Private Sub txtQuant_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtQuant.TextChanged

    End Sub

    Private Sub txtClientId_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtClientId.TextChanged

    End Sub

    Private Sub butKeyboard_BarCode_Click(sender As System.Object, e As System.EventArgs) Handles butKeyboard_BarCode.Click
        SellingUI_AlphabetKeyBoard.ShowMe(Nothing, txtCodingBarOrig, Nothing)
    End Sub

    Private Sub butKeyboard_Productname_Click(sender As System.Object, e As System.EventArgs) Handles butKeyboard_Productname.Click
        SellingUI_AlphabetKeyBoard.ShowMe(Nothing, cmbProductName, Nothing)
    End Sub

    Private Sub butKeyboard_Presc_Click(sender As System.Object, e As System.EventArgs) Handles butKeyboard_Presc.Click
        SellingUI_AlphabetKeyBoard.ShowMe(Nothing, txtCodingPrescription, Nothing)
    End Sub

    Private Sub txtCodingBarOrig_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodingBarOrig.TextChanged

    End Sub
End Class
