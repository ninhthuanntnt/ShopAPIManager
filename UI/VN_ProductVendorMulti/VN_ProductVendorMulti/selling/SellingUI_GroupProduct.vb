Public Class SellingUI_GroupProduct

    Private isInitData As Boolean = False
    Private hasChangedPrescritpion As Boolean = False
    Private sellingUIControl02 As SellingUI_TabPageControl
    Private sellingUIControl01 As SellingInterface_Mobile

    Public Sub doSetMdiParent(control01 As SellingInterface_Mobile)
        Me.MdiParent = SellingInterface_Mobile
    End Sub

    Public Sub doSetMdiParent(mainCotnrol As SellingUI_Container)
        Me.MdiParent = SellingUI_Container
    End Sub

    Public Sub doSetUIControllers(control01 As SellingInterface_Mobile)
        sellingUIControl01 = control01
    End Sub

    Public Sub doSetUIControllers(control02 As SellingUI_TabPageControl)
        sellingUIControl02 = control02
    End Sub

    Private Sub SellingInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not isInitData Then
            initData()
        End If
        Me.cmbPrescription.Text = ""

    End Sub

    Public Sub loadPrescriptionName(ByVal barcode As String)
        Dim tab = PrescriptionTableAdapter.GetBy_BarCode("%" & barcode & "%", False)
        If (tab.Rows.Count > 0) Then
            Dim id = tab.Rows.Item(0)("ID")
            Dim name = tab.Rows.Item(0)("Name")
            cmbPrescription.Text = name
            cmbPrescription.SelectedValue = id
            Me.PrescriptionContentTableAdapter.FillBy_IdPrescription(Me.pharmacyDataSet.PrescriptionContent, id)
            checkPrescriptionContent()
        End If
    End Sub

    Public Sub loadPrescriptionContent(ByVal idPRescription As Integer, ByVal nameOfPrescription As String)
        initData()
        cmbPrescription.Text = nameOfPrescription
        cmbPrescription.SelectedValue = idPRescription
        Me.PrescriptionContentTableAdapter.FillBy_IdPrescription(Me.pharmacyDataSet.PrescriptionContent, idPRescription)
        checkPrescriptionContent()
    End Sub


    Sub initData()
        Me.ProductNameTableAdapter.Fill(Me.pharmacyDataSet.ProductName)
        Me.ProductInfoTableAdapter.Fill(Me.pharmacyDataSet.ProductInfo)
        Me.ProductUnitTableAdapter.Fill(Me.pharmacyDataSet.ProductUnit)
        Me.PrescriptionTableAdapter.FillBy_StopSelling(Me.pharmacyDataSet.Prescription, False)
        isInitData = True
    End Sub

    Sub checkPrescriptionContent()
        For i = 0 To PresciptionContentDataGridView.RowCount - 1
            Dim idProduct = PresciptionContentDataGridView("colPrescriptionIdProd", i).Value
            Dim idUnit = PresciptionContentDataGridView("colPrescriptionIdUnit", i).Value
            Dim tab = OneSPTableAdapter.GetBy_IdProd_IdUnit(idProduct, idUnit)
            If (tab.Rows.Count = 0) Then
                PresciptionContentDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            Else
                PresciptionContentDataGridView("colPrescriptionPrice", i).Value = tab.Rows.Item(0)("SellingPrice")
            End If
        Next
    End Sub



    Private idProductFromPrescription = 0
    Private productFromPrescription = ""
    Private Sub PresciptionContentDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresciptionContentDataGridView.CellClick
        Try
            PresciptionContentDataGridView.Rows(e.RowIndex).Selected = True
            idProductFromPrescription = PresciptionContentDataGridView("colPrescriptionIdProd", e.RowIndex).Value
            productFromPrescription = PresciptionContentDataGridView("colPrescriptionIdProd", e.RowIndex).FormattedValue
        Catch ex As Exception

        End Try

    End Sub



    Private Sub butVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ratio As Decimal = MyFunct.getVal(txtRatio.Text)
        removeSelect()
        Dim rows = PresciptionContentDataGridView.Rows
        Dim ok = True
        For k = 0 To rows.Count - 1
            If Not checkLineOfPrescription(k, ratio) Then
                PresciptionContentDataGridView.Rows(k).DefaultCellStyle.ForeColor = Color.Red
                ok = False
            Else
                PresciptionContentDataGridView.Rows(k).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
        If ok = False Then
            MsgBox("Cần phải sửa lỗi tại các dòng: xem đơn vị bán, số lượng bán, dòng sản phẩm nếu đã bán và muốn bán với số lượng nhiều hơn, hãy xóa trong danh sách bán trước", MsgBoxStyle.Critical, "Cần sữa lỗi")
        Else
            MsgBox("Kho đã được kiểm tra cho đơn sản phẩm, có thể tiếp tục bán", MsgBoxStyle.OkOnly, "Thông báo")
        End If
    End Sub

    Function checkStockForPrescription(ByVal k As Integer, ByVal ratio As Decimal, ByVal forCache As Boolean, ByVal idPrescription As Integer) As Boolean
        Dim idProd = CType(PresciptionContentDataGridView("colPrescriptionIdProd", k).Value, Decimal)
        Dim productName = PresciptionContentDataGridView("colPrescriptionIdProd", k).FormattedValue
        Dim idUnit = CType(PresciptionContentDataGridView("colPrescriptionIdUnit", k).Value, Decimal)
        Dim tab = OneSPTableAdapter.GetBy_IdProd_IdUnit(idProd, idUnit)
        Dim idSellP = CType(tab.Rows.Item(0)("idSellingPrice"), Decimal)
        Dim s = PresciptionContentDataGridView("colPrescriptionQuant", k).Value & ""
        Dim sQuant As Decimal = CType(Val(s.Replace(",", ".").Replace(" ", "")), Decimal) * ratio
        If sQuant = 0 Then Return False
        Dim check = False
        If (Not IsNothing(sellingUIControl01)) Then
            check = sellingUIControl01.checkAvailableQuantity(idProd, productName, sQuant, idSellP)
        ElseIf (Not IsNothing(sellingUIControl02)) Then
            check = sellingUIControl02.checkAvailableQuantity(idProd, productName, sQuant, idSellP)
        Else
            check = SellingInterface_Mobile.checkAvailableQuantity(idProd, productName, sQuant, idSellP)
        End If
        Return check
    End Function

    Function outStockForPrescription(ByVal k As Integer, ByVal ratio As Decimal, ByVal forCache As Boolean, ByVal idPrescription As Integer) As Boolean
        Dim idProd = CType(PresciptionContentDataGridView("colPrescriptionIdProd", k).Value, Decimal)
        Dim productName = PresciptionContentDataGridView("colPrescriptionIdProd", k).FormattedValue
        Dim idUnit = CType(PresciptionContentDataGridView("colPrescriptionIdUnit", k).Value, Decimal)
        Dim tab = OneSPTableAdapter.GetBy_IdProd_IdUnit(idProd, idUnit)
        Dim idSellP = CType(tab.Rows.Item(0)("idSellingPrice"), Decimal)
        Dim s = PresciptionContentDataGridView("colPrescriptionQuant", k).Value & ""
        Dim sQuant As Decimal = CType(Val(s.Replace(",", ".").Replace(" ", "")), Decimal) * ratio
        If sQuant = 0 Then Return False


        Dim check = False
        If (Not IsNothing(sellingUIControl01)) Then
            check = sellingUIControl01.checkAvailableQuantityAndInsert(idProd, productName, sQuant, idSellP, forCache, idPrescription)
        ElseIf (Not IsNothing(sellingUIControl02)) Then
            check = sellingUIControl02.checkAvailableQuantityAndInsert(idProd, productName, sQuant, idSellP, forCache, idPrescription)
        Else
            check = SellingInterface_Mobile.checkAvailableQuantityAndInsert(idProd, productName, sQuant, idSellP, forCache, idPrescription)
        End If
        Return check

        ' Return SellingInterface_Mobile.checkAvailableQuantityAndInsert(idProd, productName, sQuant, idSellP, forCache, idPrescription)
    End Function

    Function checkLineOfPrescription(ByVal k As Integer, ByVal multi As Decimal) As Boolean
        Dim idProd = CType(PresciptionContentDataGridView("colPrescriptionIdProd", k).Value, Decimal)
        Dim productName = PresciptionContentDataGridView("colPrescriptionIdProd", k).FormattedValue
        Dim idUnit = CType(PresciptionContentDataGridView("colPrescriptionIdUnit", k).Value, Decimal)
        Dim tab = OneSPTableAdapter.GetBy_IdProd_IdUnit(idProd, idUnit)
        Dim idSellP = CType(tab.Rows.Item(0)("idSellingPrice"), Decimal)

        If tab.Rows.Count = 0 Then
            MsgBox("Xem lại đơn vị bán", MsgBoxStyle.Exclamation, "Chú ý")
            Return False
        End If

        Dim s = PresciptionContentDataGridView("colPrescriptionQuant", k).Value & ""
        Dim sQuant As Decimal = CType(Val(s.Replace(",", ".").Replace(" ", "")), Decimal) * multi
        If sQuant < 0 Then
            MsgBox("Số lượng phải >=0", MsgBoxStyle.Exclamation, "Chú ý")
            Return False
        End If


        Dim check = False
        If (Not IsNothing(sellingUIControl01)) Then
            check = sellingUIControl01.checkAvailableQuantity(idProd, productName, sQuant, idSellP)
        ElseIf (Not IsNothing(sellingUIControl02)) Then
            check = sellingUIControl02.checkAvailableQuantity(idProd, productName, sQuant, idSellP)
        Else
            check = SellingInterface_Mobile.checkAvailableQuantity(idProd, productName, sQuant, idSellP)
        End If
        Return check


    End Function

    Sub removeSelect()
        Dim rows = PresciptionContentDataGridView.Rows
        For k = 0 To rows.Count - 1
            PresciptionContentDataGridView.Rows(k).Selected = False
        Next
    End Sub
    Private Sub butAddAllToSelling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddAllToSelling.Click
        Try
            Dim ratio As Decimal = MyFunct.getVal(txtRatio.Text)

            PresciptionContentDataGridView.EndEdit()
            removeSelect()
            Dim rows = PresciptionContentDataGridView.Rows

            If (rows.Count <= 0) Then
                Me.Close()
                Return
            End If

            Dim ok = True
            For k = 0 To rows.Count - 1
                If Not checkLineOfPrescription(k, ratio) Then
                    PresciptionContentDataGridView.Rows(k).DefaultCellStyle.ForeColor = Color.Red
                    ok = False
                Else
                    PresciptionContentDataGridView.Rows(k).DefaultCellStyle.ForeColor = Color.Black
                End If
            Next
            If ok = False Then
                MsgBox("Cần phải sửa lỗi tại các dòng: xem đơn vị bán, số lượng bán," _
                       & " dòng sản phẩm nếu đã bán và muốn bán với số lượng nhiều hơn, hãy xóa trong danh sách bán trước", _
                       MsgBoxStyle.Critical, "Cần sửa lỗi")
                Return
            End If

            'ok=> outstock

            Dim forcache As Boolean = (Not hasChangedPrescritpion) And (Not CType(cmbDetailVisible.Text, Boolean))
            Dim idPrescription As Integer = cmbPrescription.SelectedValue

            Dim canAddPrescription As Boolean = True
            For k = 0 To rows.Count - 1
                canAddPrescription = checkStockForPrescription(k, ratio, forcache, idPrescription)
            Next
            If canAddPrescription = False Then Return

            'neu forcache thi them don thuoc 
            If forcache Then
                Dim prescripName As String = cmbPrescription.Text
                Dim prescripAmount As Decimal = MyFunct.getVal(cmbAmount.Text)

                Dim check = False
                If (Not IsNothing(sellingUIControl01)) Then
                    check = sellingUIControl01.addPrescriptionSell(idPrescription, prescripName, ratio, prescripAmount)
                ElseIf (Not IsNothing(sellingUIControl02)) Then
                    check = sellingUIControl02.addPrescriptionSell(idPrescription, prescripName, ratio, prescripAmount)
                Else
                    check = SellingInterface_Mobile.addPrescriptionSell(idPrescription, prescripName, ratio, prescripAmount)
                End If

                If Not check Then Return
            End If

            For k = 0 To rows.Count - 1
                outStockForPrescription(k, ratio, forcache, idPrescription)
            Next


            If (Not IsNothing(sellingUIControl01)) Then
                sellingUIControl01.updateSummary()
            ElseIf (Not IsNothing(sellingUIControl02)) Then
                sellingUIControl02.updateSummary()
            Else
                SellingInterface_Mobile.updateSummary()
            End If

            Me.Close()
        Catch ex As Exception
            MsgBox("Có lỗi, có thể nguyên nhan do đơn vị/ giá bán của sản phẩm trong đơn, hãy kiểm tra lại đơn", MsgBoxStyle.Exclamation, " Lỗi")
        End Try

    End Sub

    Private Sub cmbPrescription_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrescription.SelectedIndexChanged
        getPrescriptionContent()
    End Sub

    Private Sub SellingInterface_FromPrescription_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.Focus()
    End Sub
    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Me.Close()
    End Sub


    Private Sub PresciptionContentDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresciptionContentDataGridView.CellContentDoubleClick
        Dim lines = PresciptionContentDataGridView.SelectedRows
        If (lines.Count > 0) Then
            Dim line = lines(0)
            SellingUI_NumericKeyBoard.ShowMe(line.Cells("colPrescriptionQuant"))
        End If

    End Sub

    Private Sub butModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butModif.Click
        Dim lines = PresciptionContentDataGridView.SelectedRows
        If (lines.Count > 0) Then
            Dim line = lines(0)
            SellingUI_NumericKeyBoard.ShowMe(line.Cells("colPrescriptionQuant"))
            SellingUI_NumericKeyBoard.setLocation(100, 100)
            hasChangedPrescritpion = True
        Else
            MsgBox("Cần chọn 1 dòng", MsgBoxStyle.Information, "Thông báo")
        End If
    End Sub

    Private Sub butDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDel.Click
        Dim lines = PresciptionContentDataGridView.SelectedRows
        If (lines.Count > 0) Then
            Dim line = lines(0)
            PresciptionContentDataGridView.Rows.Remove(line)
            hasChangedPrescritpion = True
        Else
            MsgBox("Cần chọn 1 dòng", MsgBoxStyle.Information, "Thông báo")
        End If
    End Sub

    Private Sub butModif_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles butModif.MouseEnter
        ToolTip1.SetToolTip(butModif, "Thay đổi số lượng")
    End Sub

    Private Sub butDel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles butDel.MouseEnter
        ToolTip1.SetToolTip(butDel, "Xóa dòng")
    End Sub

    Private Sub butAddAllToSelling_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles butAddAllToSelling.MouseEnter
        ToolTip1.SetToolTip(butAddAllToSelling, "Thêm tất cả danh sách sản phẩm trên cùng số lượng vào danh sách bán hàng, chỉ thực hiện được khi không có dòng đỏ")
    End Sub
    'Dim action = False
    Private Sub but_Ratio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_Ratio.Click
        SellingUI_NumericKeyBoard.ShowMe(Nothing, txtRatio, but_Ratio)
    End Sub
    Private Sub but_Ratio_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles but_Ratio.MouseEnter
        ToolTip1.SetToolTip(but_Ratio, "Nhân số lần")
    End Sub
    Private Sub ButGroup_01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_01.Click
        PrescriptionTableAdapter.FillBy_Group(pharmacyDataSet.Prescription, 1)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_02.Click
        PrescriptionTableAdapter.FillBy_Group(pharmacyDataSet.Prescription, 2)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_03.Click
        PrescriptionTableAdapter.FillBy_Group(pharmacyDataSet.Prescription, 3)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_04.Click
        PrescriptionTableAdapter.FillBy_Group(pharmacyDataSet.Prescription, 4)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_05.Click
        PrescriptionTableAdapter.FillBy_Group(pharmacyDataSet.Prescription, 5)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_06.Click
        PrescriptionTableAdapter.FillBy_Group(pharmacyDataSet.Prescription, 6)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_07.Click
        PrescriptionTableAdapter.FillBy_Group(pharmacyDataSet.Prescription, 7)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_08_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_08.Click
        PrescriptionTableAdapter.FillBy_Group(pharmacyDataSet.Prescription, 8)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_09.Click
        PrescriptionTableAdapter.FillBy_Group(pharmacyDataSet.Prescription, 9)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_00.Click
        PrescriptionTableAdapter.FillBy_Group(pharmacyDataSet.Prescription, 0)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_TC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGroup_TC.Click
        PrescriptionTableAdapter.FillBy_StopSelling(pharmacyDataSet.Prescription, False)
        changeIndexOfPrescription()
    End Sub

    Private Sub ButGroup_TC_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButGroup_TC.MouseEnter
        ToolTip1.SetToolTip(ButGroup_TC, "Hiện tất cả các đơn sản phẩm")
    End Sub

    Private Sub changeIndexOfPrescription()
        Try
            cmbPrescription.SelectedIndex = 0
            getPrescriptionContent()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub getPrescriptionContent()
        Dim idPrescrip As Integer = cmbPrescription.SelectedValue
        If (idPrescrip <= 0) Then Return
        Try
            cmbComment.SelectedIndex = cmbPrescription.SelectedIndex
            cmbDetailVisible.SelectedIndex = cmbPrescription.SelectedIndex
            cmbAmount.SelectedIndex = cmbPrescription.SelectedIndex
        Catch ex As Exception

        End Try
        Me.PrescriptionContentTableAdapter.FillBy_IdPrescription(Me.pharmacyDataSet.PrescriptionContent, idPrescrip)
        hasChangedPrescritpion = False
        txtRatio.Text = "1"
        checkPrescriptionContent()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtRatio_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtRatio.MouseClick
        SellingUI_NumericKeyBoard.ShowMe(txtRatio)
    End Sub

    
End Class