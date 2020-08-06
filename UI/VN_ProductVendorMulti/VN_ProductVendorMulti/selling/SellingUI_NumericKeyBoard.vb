Imports System.Threading
Public Delegate Sub SubDelegate(ByVal numVal As String)

Public Class SellingUI_NumericKeyBoard
    Private myForm As MyForm
    Private myTextBox As TextBox
    Private myButValidate As Button



    Private myCell As DataGridViewCell
    Private myCallBack As SubDelegate

    Public Sub ShowMe(ByVal cell As DataGridViewCell)
        myCell = cell
        Me.Show()
        Try
            Me.Focus()
            GroupBox1.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ShowMe(ByVal txtBox As TextBox)
        ShowMe(Nothing, txtBox, Nothing)
    End Sub
    Public Sub ShowMe(ByVal form As MyForm, ByVal txtBox As TextBox, ByVal butValidate As Button)
        myForm = form
        myTextBox = txtBox
        myButValidate = butValidate

        numericString = ""
        Dim x = ControlLocation.XPos(txtBox)
        Dim y = ControlLocation.YPos(txtBox) + 10

        x = Math.Min(x, MyFunct.screenW - Me.Width)
        y = Math.Min(y, MyFunct.screenH - Me.Height)


        'y = Math.Min(y, 300)
        'x = Math.Min(700, x)
        Dim loc = New Point(x, y)
        Me.Location = loc


        Me.Show()
        Try
            Me.Focus()
            GroupBox1.Focus()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ShowMe(ByVal txtBox As TextBox, ByVal CallBack As SubDelegate)
        ShowMe(txtBox, CallBack, -1, -1)
    End Sub
    Public Sub ShowMe(ByVal txtBox As TextBox, ByVal CallBack As SubDelegate, ByVal x As Integer, ByVal y As Integer)
        myForm = Nothing
        myTextBox = txtBox
        myCallBack = CallBack

        numericString = ""
        If (x <= 0) Then x = ControlLocation.XPos(txtBox)
        If (y <= 0) Then y = ControlLocation.YPos(txtBox) + 10

        x = Math.Min(x, MyFunct.screenW - Me.Width)
        y = Math.Min(y, MyFunct.screenH - Me.Height)


        'y = Math.Min(y, 300)
        'x = Math.Min(700, x)
        Dim loc = New Point(x, y)
        Me.Location = loc


        Me.Show()
        Try
            Me.Focus()
            GroupBox1.Focus()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub setLocation(ByVal x, ByVal y)
        Dim loc = New Point(x, y)
        Me.Location = loc
    End Sub

    Dim numericString As String = ""
    Private Sub NumericKeyBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        numericString = ""
    End Sub

    Public Sub doSetMdiParent(control01 As SellingInterface_Mobile)
        Me.MdiParent = SellingInterface_Mobile
    End Sub

    Public Sub doSetMdiParent(mainCotnrol As SellingUI_Container)
        Me.MdiParent = SellingUI_Container
    End Sub

    Private Sub displayVal()
        Dim value = Val(numericString.Replace(",", ".").Replace(" ", ""))
        lbVal.Text = MyFunct.formatNum(value)
        GroupBox1.Focus()
    End Sub

    Private Sub but_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_0.Click
        numericString = numericString & "0"
        displayVal()

    End Sub

    Private Sub but_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_1.Click
        numericString = numericString & "1"
        displayVal()
    End Sub

    Private Sub but_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_2.Click
        numericString = numericString & "2"
        displayVal()
    End Sub

    Private Sub but_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_3.Click
        numericString = numericString & "3"
        displayVal()
    End Sub

    Private Sub but_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_4.Click
        numericString = numericString & "4"
        displayVal()
    End Sub

    Private Sub but_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_5.Click
        numericString = numericString & "5"
        displayVal()
    End Sub

    Private Sub but_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_6.Click
        numericString = numericString & "6"
        displayVal()
    End Sub

    Private Sub but_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_7.Click
        numericString = numericString & "7"
        displayVal()
    End Sub

    Private Sub but_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_8.Click
        numericString = numericString & "8"
        displayVal()
    End Sub

    Private Sub but_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_9.Click
        numericString = numericString & "9"
        displayVal()
    End Sub

    Private Sub but_X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_X.Click
        numericString = ""
        displayVal()
    End Sub

    Private Sub but_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_OK.Click
        If (Not IsNothing(myTextBox)) Then
            If numericString = "" Then numericString = "1"
            myTextBox.Text = numericString
            myForm = Nothing
            myTextBox = Nothing
        End If

        If (Not myCell Is Nothing) Then
            myCell.Value = numericString
        End If

        'call button validate

        If Not (myButValidate Is Nothing) Then
            Try
                Thread.Sleep(200)
                myButValidate.PerformClick()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        ElseIf Not (myCallBack Is Nothing) Then
            myCallBack(numericString)
        End If
        myButValidate = Nothing

        Me.Dispose()
        Me.Close()


    End Sub

    Private Sub but_00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_00.Click
        numericString = numericString & "."
        displayVal()
    End Sub

    Private Sub but_000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_000.Click
        numericString = numericString & "000"
        displayVal()
    End Sub

    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        myForm = Nothing
        myTextBox = Nothing
        myButValidate = Nothing

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub NumericKeyBoard_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.Focus()
    End Sub



End Class