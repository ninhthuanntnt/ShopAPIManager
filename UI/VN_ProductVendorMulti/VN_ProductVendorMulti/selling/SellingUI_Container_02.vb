Imports System.Globalization


Public Class SellingUI_Container_02
    Implements MyForm
    Private r_1 As Boolean
    Private r_2 As Boolean
    Private r_3 As Boolean
    Private r_4 As Boolean
    Public Function preLoad(ByVal r1, ByVal r2, ByVal r3, ByVal r4) As Boolean Implements MyForm.preLoad
        Return True
    End Function
    Public Sub ShowMe(ByVal menItem) Implements MyForm.ShowMe
        Me.Show()
    End Sub

    Private Sub init()
    End Sub


    Public Sub clear_0()
    End Sub
    Public Sub clear_1()

    End Sub
    Public Sub clear_2()

    End Sub
    Private Sub clear_3()

    End Sub

    Private Sub SellingInterface_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

    End Sub

    Private Sub SellingInterface_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub SellingInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'NumericKeyBoard.doSetMdiParent(Me)
        'AlphabetKeyBoard.doSetMdiParent(Me)
        'SellingInterface_FromGroup.doSetMdiParent(Me)
    End Sub
    Private Sub butClose_Click(sender As System.Object, e As System.EventArgs) Handles butAppClose.Click
        closeAllSubWin()

        Dim ok = MsgBox("Thật sự bạn muốn tắt chương trình?", MsgBoxStyle.YesNo, "Chú ý")
        If ok = MsgBoxResult.Yes Then
            Me.Close()
        End If
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

    'Private numericKeyBoard = New NumericKeyBoard
    Private Sub butBeginSell_Click(sender As System.Object, e As System.EventArgs) Handles butClientNew.Click
        'If IsNothing(numericKeyBoard) Then numericKeyBoard = New NumericKeyBoard
        'Dim msd As SubDelegate = AddressOf Me.doClientNew
        'numericKeyBoard.ShowMe(txtClientNum, msd, ControlLocation.XPos(butClientNew), ControlLocation.YPos(butClientNew) + 10)
        'numericKeyBoard = Nothing
        closeAllSubWin()
        doClientNew()

    End Sub

    Private tabClientPage As Hashtable = New Hashtable
    Private Sub doClientNew()
        Dim numVal = -1
        For i = 0 To client_num - 1
            If (Not client_stat(i)) Then
                numVal = i
                Exit For
            End If
        Next


        If (numVal < 0) Then
            MsgBox("Đang có 3 khách chưa kết thúc, vui lòng kết thúc trước?", MsgBoxStyle.YesNo, "Chú ý")
            Return
        End If

        Dim tabPage As TabPage = tabClientPage(numVal)
        If (IsNothing(tabPage)) Then
            tabPage = New TabPage
            tabPage.Text = " SH:  " & numVal & " "


            Dim sellingUIControl = New SellingUI_TabPageControl
            sellingUIControl.doInitView()
            sellingUIControl.doSetConfig02(Me, numVal & "")


            sellingUIControl.Parent = tabPage
            tabControl_Client.TabPages.Add(tabPage)
            tabControl_Client.SelectedTab = tabPage

            tabClientPage.Add(numVal, tabPage)

            client_stat(numVal) = True
        Else
            tabPage.Focus()
            tabControl_Client.SelectedTab = tabPage
        End If
    End Sub

    Private Sub doClientChange(ByVal numVal As Integer)
        If (numVal < 0) Then
            Return
        End If

        Dim tabPage As TabPage = tabClientPage(numVal)
        If (IsNothing(tabPage)) Then
            MsgBox("Không tồn tại khách hành với số được chọn", vbExclamation, "Chú ý")
        Else
            tabPage.Focus()
            tabControl_Client.SelectedTab = tabPage
        End If
    End Sub

    Public Sub doClientRemove(ByVal numVal As Integer)
        If (numVal < 0 Or numVal >= client_num) Then
            Return
        End If

        Dim tabPage As TabPage = tabClientPage(numVal)
        If (IsNothing(tabPage)) Then
            MsgBox("Không tồn tại khách hành với số được chọn", vbExclamation, "Chú ý")
        Else
            Me.tabControl_Client.TabPages.Remove(tabPage)
            tabClientPage.Remove(numVal)
            client_stat(numVal) = False
        End If
    End Sub

    Private Sub butAppMinimize_Click(sender As System.Object, e As System.EventArgs) Handles butAppMinimize.Click
        closeAllSubWin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub butAppMinimize_MouseEnter(sender As Object, e As System.EventArgs) Handles butAppMinimize.MouseEnter
        ToolTip1.SetToolTip(butAppMinimize, "Trở về Window")
    End Sub

    Private Sub butAppClose_MouseEnter(sender As Object, e As System.EventArgs) Handles butAppClose.MouseEnter
        ToolTip1.SetToolTip(butAppClose, "Tắt hoàn toàn chương trình")
    End Sub


    Private Sub butConf_Click(sender As System.Object, e As System.EventArgs) Handles butConf.Click
        SysConfig.Show()
        SysConfig.Focus()
    End Sub

    Private Sub butKeyboard_Productname_02_Click(sender As System.Object, e As System.EventArgs) Handles butKeyboard_Productname_02.Click
        'If Me.oskProcess IsNot Nothing Then
        'If Not showKeyBoard Then
        'showKeyBoard = Not showKeyBoard
        'End If
        'End If

        ' If (Not showKeyBoard) Then
        showVirtualKeyboard()
        'Else
        'hideVirtualKeyboard()
        'End If

        ' showKeyBoard = Not showKeyBoard
        'cmbProductName.Focus()
    End Sub

    Private oskProcess As Process
    Private Sub showVirtualKeyboard()

        'If Me.oskProcess IsNot Nothing Then
        'Me.oskProcess.Kill()
        'Me.oskProcess.Close()
        'End If

        Me.oskProcess = Process.Start("osk")


        'If (oskProcess Is Nothing) Then
        'oskProcess = System.Diagnostics.Process.Start("osk.exe")
        'Else
        'End If
    End Sub

    Private Sub hideVirtualKeyboard()
        If Me.oskProcess IsNot Nothing Then
            Me.oskProcess.Kill()
            Me.oskProcess.Close()
        End If
        oskProcess = Nothing

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Dim client_num = 3
    Dim client_stat = New Boolean() {False, False, False}

    Private Sub butClientChange_Click(sender As System.Object, e As System.EventArgs) Handles butClientChange_01.Click
        doClientChange(0)
    End Sub

   
    Private Sub butClientChange_02_Click(sender As System.Object, e As System.EventArgs) Handles butClientChange_02.Click
        doClientChange(1)
    End Sub

    Private Sub butClientChange_03_Click(sender As System.Object, e As System.EventArgs) Handles butClientChange_03.Click
        doClientChange(2)
    End Sub
End Class



