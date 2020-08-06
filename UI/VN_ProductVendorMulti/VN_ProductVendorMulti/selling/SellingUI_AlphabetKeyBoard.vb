Public Class SellingUI_AlphabetKeyBoard
    Private myForm As MyForm
    Private myBox As Control

    Private myButValidate As Button
    Private myCell As DataGridViewCell

    Public Sub ShowMe(ByVal cell As DataGridViewCell)
        myCell = cell
        Me.Show()
        Try
            Me.Focus()
            GroupBox1.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ShowMe(ByVal form As MyForm, ByVal txtControl As Control, ByVal butValidate As Button)
        myForm = form
        myBox = txtControl
        myButValidate = butValidate

        myString = txtControl.Text
        Dim x = ControlLocation.XPos(myBox)
        Dim y = ControlLocation.YPos(myBox) + 40

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

    Dim myString As String = ""
    Private Sub NumericKeyBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmacyDataSet.Client' table. You can move, or remove it, as needed.
        myString = ""
    End Sub

    Private Sub displayVal()
        myString = Viethoa(myString)
        myBox.Text = myString
        GroupBox1.Focus()
    End Sub

    Private Sub but_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_0.Click
        myString = myString & "0"
        displayVal()

    End Sub

    Private Sub but_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_1.Click
        myString = myString & "1"
        displayVal()
    End Sub

    Private Sub but_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_2.Click
        myString = myString & "2"
        displayVal()
    End Sub

    Private Sub but_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_3.Click
        myString = myString & "3"
        displayVal()
    End Sub

    Private Sub but_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_4.Click
        myString = myString & "4"
        displayVal()
    End Sub

    Private Sub but_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_5.Click
        myString = myString & "5"
        displayVal()
    End Sub

    Private Sub but_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_6.Click
        myString = myString & "6"
        displayVal()
    End Sub

    Private Sub but_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_7.Click
        myString = myString & "7"
        displayVal()
    End Sub

    Private Sub but_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_8.Click
        myString = myString & "8"
        displayVal()
    End Sub

    Private Sub but_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_9.Click
        myString = myString & "9"
        displayVal()
    End Sub



    Private Sub but_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_OK.Click
        If (Not IsNothing(myBox)) Then
            'myBox.Text = myBox.Text & Environment.NewLine
            myBox.Focus()
            SendKeys.Send("{ENTER}")

            myForm = Nothing
            myBox = Nothing
            myButValidate = Nothing
        End If

        Me.Hide()
    End Sub

    Private Sub but_00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_00.Click
        myString = myString & "."
        displayVal()
    End Sub



    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        myString = ""
        displayVal()
    End Sub

    Private Sub NumericKeyBoard_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.Focus()
    End Sub


    Private Sub but_a_Click(sender As System.Object, e As System.EventArgs) Handles but_a.Click
        myString = myString & but_a.Text
        displayVal()
    End Sub

    Private Sub but_b_Click(sender As System.Object, e As System.EventArgs) Handles but_b.Click
        myString = myString & but_b.Text
        displayVal()
    End Sub

    Private Sub but_c_Click(sender As System.Object, e As System.EventArgs) Handles but_c.Click
        myString = myString & but_c.Text
        displayVal()
    End Sub

    Private Sub but_d_Click(sender As System.Object, e As System.EventArgs) Handles but_d.Click
        myString = myString & but_d.Text
        displayVal()
    End Sub

    Private Sub but_e_Click(sender As System.Object, e As System.EventArgs) Handles but_e.Click
        myString = myString & but_e.Text
        displayVal()
    End Sub
    Private Sub but_f_Click(sender As System.Object, e As System.EventArgs) Handles but_f.Click
        myString = myString & but_f.Text
        displayVal()
    End Sub
    Private Sub but_g_Click(sender As System.Object, e As System.EventArgs) Handles but_g.Click
        myString = myString & but_g.Text
        displayVal()
    End Sub
    Private Sub but_k_Click(sender As System.Object, e As System.EventArgs) Handles but_k.Click
        myString = myString & but_k.Text
        displayVal()
    End Sub
    Private Sub but_h_Click(sender As System.Object, e As System.EventArgs) Handles but_h.Click
        myString = myString & but_h.Text
        displayVal()
    End Sub
    Private Sub but_i_Click(sender As System.Object, e As System.EventArgs) Handles but_i.Click
        myString = myString & but_i.Text
        displayVal()
    End Sub
    Private Sub but_l_Click(sender As System.Object, e As System.EventArgs) Handles but_l.Click
        myString = myString & but_l.Text
        displayVal()
    End Sub
    Private Sub but_m_Click(sender As System.Object, e As System.EventArgs) Handles but_m.Click
        myString = myString & but_m.Text
        displayVal()
    End Sub
    Private Sub but_n_Click(sender As System.Object, e As System.EventArgs) Handles but_n.Click
        myString = myString & but_n.Text
        displayVal()
    End Sub
    Private Sub but_o_Click(sender As System.Object, e As System.EventArgs) Handles but_o.Click
        myString = myString & but_o.Text
        displayVal()
    End Sub
    Private Sub but_p_Click(sender As System.Object, e As System.EventArgs) Handles but_p.Click
        myString = myString & but_p.Text
        displayVal()
    End Sub
    Private Sub but_q_Click(sender As System.Object, e As System.EventArgs) Handles but_q.Click
        myString = myString & but_q.Text
        displayVal()
    End Sub
    Private Sub but_r_Click(sender As System.Object, e As System.EventArgs) Handles but_r.Click
        myString = myString & but_r.Text
        displayVal()
    End Sub
    Private Sub but_s_Click(sender As System.Object, e As System.EventArgs) Handles but_s.Click
        myString = myString & but_s.Text
        displayVal()
    End Sub
    Private Sub but_t_Click(sender As System.Object, e As System.EventArgs) Handles but_t.Click
        myString = myString & but_t.Text
        displayVal()
    End Sub
    Private Sub but_u_Click(sender As System.Object, e As System.EventArgs) Handles but_u.Click
        myString = myString & but_u.Text
        displayVal()
    End Sub
    Private Sub but_w_Click(sender As System.Object, e As System.EventArgs) Handles but_w.Click
        myString = myString & but_w.Text
        displayVal()
    End Sub
    Private Sub but_y_Click(sender As System.Object, e As System.EventArgs) Handles but_y.Click
        myString = myString & but_y.Text
        displayVal()
    End Sub
    Private Sub but_z_Click(sender As System.Object, e As System.EventArgs) Handles but_z.Click
        myString = myString & but_z.Text
        displayVal()
    End Sub
    Private Sub but_x_Click(sender As System.Object, e As System.EventArgs) Handles but_x.Click
        myString = myString & but_x.Text
        displayVal()
    End Sub

    Private Sub but_Opt01_Click(sender As System.Object, e As System.EventArgs) Handles but_Opt01.Click
        myString = myString & but_Opt01.Text
        displayVal()
    End Sub

    Private Sub but_Opt02_Click(sender As System.Object, e As System.EventArgs) Handles but_Opt02.Click
        myString = myString & but_Opt02.Text
        displayVal()
    End Sub

    Private Sub but_Opt03_Click(sender As System.Object, e As System.EventArgs) Handles but_Opt03.Click
        myString = myString & but_Opt03.Text
        displayVal()
    End Sub

    Private isUpcase As Boolean = False
    Private Sub but_UpLoCase_Click(sender As System.Object, e As System.EventArgs) Handles but_UpLoCase.Click
        isUpcase = Not isUpcase
        If (isUpcase) Then
            but_a.Text = UCase(but_a.Text)
            but_b.Text = UCase(but_b.Text)
            but_c.Text = UCase(but_c.Text)
            but_d.Text = UCase(but_d.Text)
            but_e.Text = UCase(but_e.Text)
            but_f.Text = UCase(but_f.Text)
            but_g.Text = UCase(but_g.Text)
            but_h.Text = UCase(but_h.Text)
            but_i.Text = UCase(but_i.Text)
            but_k.Text = UCase(but_k.Text)
            but_l.Text = UCase(but_l.Text)
            but_m.Text = UCase(but_m.Text)
            but_n.Text = UCase(but_n.Text)
            but_o.Text = UCase(but_o.Text)
            but_p.Text = UCase(but_p.Text)
            but_s.Text = UCase(but_s.Text)
            but_r.Text = UCase(but_r.Text)
            but_t.Text = UCase(but_t.Text)
            but_u.Text = UCase(but_u.Text)
            but_v.Text = UCase(but_v.Text)
            but_w.Text = UCase(but_w.Text)
            but_y.Text = UCase(but_y.Text)
            but_z.Text = UCase(but_z.Text)
            but_x.Text = UCase(but_x.Text)
            but_q.Text = UCase(but_q.Text)
        Else
            but_a.Text = LCase(but_a.Text)
            but_b.Text = LCase(but_b.Text)
            but_c.Text = LCase(but_c.Text)
            but_d.Text = LCase(but_d.Text)
            but_e.Text = LCase(but_e.Text)
            but_f.Text = LCase(but_f.Text)
            but_g.Text = LCase(but_g.Text)
            but_h.Text = LCase(but_h.Text)
            but_i.Text = LCase(but_i.Text)
            but_k.Text = LCase(but_k.Text)
            but_l.Text = LCase(but_l.Text)
            but_m.Text = LCase(but_m.Text)
            but_n.Text = LCase(but_n.Text)
            but_o.Text = LCase(but_o.Text)
            but_p.Text = LCase(but_p.Text)
            but_s.Text = LCase(but_s.Text)
            but_r.Text = LCase(but_r.Text)
            but_t.Text = LCase(but_t.Text)
            but_u.Text = LCase(but_u.Text)
            but_v.Text = LCase(but_v.Text)
            but_w.Text = LCase(but_w.Text)
            but_y.Text = LCase(but_y.Text)
            but_z.Text = LCase(but_z.Text)
            but_x.Text = LCase(but_x.Text)
            but_q.Text = LCase(but_q.Text)
        End If
    End Sub

    Private Sub but_Space_Click(sender As System.Object, e As System.EventArgs) Handles but_Space.Click
        myString = myString & " "
        displayVal()
    End Sub

    Private Sub but_Clear_Click(sender As System.Object, e As System.EventArgs) Handles but_Clear.Click
        myString = Strings.Left(myString, Math.Max(Len(myString) - 1, 0))
        displayVal()
    End Sub

    Function Viethoa(chuoi As String)
        Dim i As Integer
        Dim j As Integer
        For j = 1 To 2
            For i = 2 To Len(chuoi)
                Dim charNext = Mid(chuoi, i, 1) 'lay 1 ky tu
                Dim charChk = Mid(chuoi, i - 1, 1)
                Dim strLeft = Strings.Left(chuoi, i - 2)
                Dim strRight = Strings.Right(chuoi, Len(chuoi) - i)
                Select Case charNext
                    Case "1"
                        'a
                        If charChk = "a" Then
                            chuoi = strLeft & ChrW(&HE1) & strRight
                        End If
                        If charChk = "A" Then
                            chuoi = strLeft & ChrW(&HC1) & strRight
                        End If

                        If charChk = ChrW(&HE2) Then
                            chuoi = strLeft & ChrW(&H1EA5) & strRight
                        End If
                        If charChk = ChrW(&HC2) Then
                            chuoi = strLeft & ChrW(&H1EA4) & strRight
                        End If

                        If charChk = ChrW(&H103) Then
                            chuoi = strLeft & ChrW(&H1EAF) & strRight
                        End If
                        If charChk = ChrW(&H102) Then
                            chuoi = strLeft & ChrW(&H1EAE) & strRight
                        End If

                        'e
                        If charChk = "e" Then
                            chuoi = strLeft & ChrW(&HE9) & strRight
                        End If
                        If charChk = "E" Then
                            chuoi = strLeft & ChrW(&HC9) & strRight
                        End If

                        If charChk = ChrW(&HEA) Then
                            chuoi = strLeft & ChrW(&H1EBF) & strRight
                        End If
                        If charChk = ChrW(&HCA) Then
                            chuoi = strLeft & ChrW(&H1EBE) & strRight
                        End If

                        'i
                        If charChk = "i" Then
                            chuoi = strLeft & ChrW(&HED) & strRight
                        End If
                        If charChk = "I" Then
                            chuoi = strLeft & ChrW(&HCD) & strRight
                        End If

                        'o
                        If charChk = "o" Then
                            chuoi = strLeft & ChrW(&HF3) & strRight
                        End If
                        If charChk = "O" Then
                            chuoi = strLeft & ChrW(&HD3) & strRight
                        End If

                        If charChk = ChrW(&HF4) Then
                            chuoi = strLeft & ChrW(&H1ED1) & strRight
                        End If
                        If charChk = ChrW(&HDA) Then
                            chuoi = strLeft & ChrW(&H1ED0) & strRight
                        End If

                        If charChk = ChrW(&H1A1) Then
                            chuoi = strLeft & ChrW(&H1EDB) & strRight
                        End If
                        If charChk = ChrW(&H1A0) Then
                            chuoi = strLeft & ChrW(&H1EDA) & strRight
                        End If

                        'u
                        If charChk = "u" Then
                            chuoi = strLeft & ChrW(&HFA) & strRight
                        End If
                        If charChk = "U" Then
                            chuoi = strLeft & ChrW(&HDA) & strRight
                        End If

                        If charChk = ChrW(&H1B0) Then
                            chuoi = strLeft & ChrW(&H1EE9) & strRight
                        End If
                        If charChk = ChrW(&H1AF) Then
                            chuoi = strLeft & ChrW(&H1EE8) & strRight
                        End If

                        'y
                        If charChk = "y" Then
                            chuoi = strLeft & ChrW(&HFD) & strRight
                        End If
                        If charChk = "Y" Then
                            chuoi = strLeft & ChrW(&HDD) & strRight
                        End If

                    Case "2"
                        'a
                        If charChk = "a" Then
                            chuoi = strLeft & ChrW(&HE0) & strRight
                        End If
                        If charChk = "A" Then
                            chuoi = strLeft & ChrW(&HC0) & strRight
                        End If

                        If charChk = ChrW(&HE2) Then
                            chuoi = strLeft & ChrW(&H1EA7) & strRight
                        End If
                        If charChk = ChrW(&HC2) Then
                            chuoi = strLeft & ChrW(&H1EA6) & strRight
                        End If

                        If charChk = ChrW(&H103) Then
                            chuoi = strLeft & ChrW(&H1EB1) & strRight
                        End If
                        If charChk = ChrW(&H102) Then
                            chuoi = strLeft & ChrW(&H1EB0) & strRight
                        End If

                        'e
                        If charChk = "e" Then
                            chuoi = strLeft & ChrW(&HE8) & strRight
                        End If
                        If charChk = "E" Then
                            chuoi = strLeft & ChrW(&HC8) & strRight
                        End If

                        If charChk = ChrW(&HEA) Then
                            chuoi = strLeft & ChrW(&H1EC1) & strRight
                        End If
                        If charChk = ChrW(&HCA) Then
                            chuoi = strLeft & ChrW(&H1EC0) & strRight
                        End If

                        'i
                        If charChk = "i" Then
                            chuoi = strLeft & ChrW(&HEC) & strRight
                        End If
                        If charChk = "I" Then
                            chuoi = strLeft & ChrW(&HCC) & strRight
                        End If

                        'o
                        If charChk = "o" Then
                            chuoi = strLeft & ChrW(&HF2) & strRight
                        End If
                        If charChk = "O" Then
                            chuoi = strLeft & ChrW(&HD2) & strRight
                        End If

                        If charChk = ChrW(&HF4) Then
                            chuoi = strLeft & ChrW(&H1ED3) & strRight
                        End If
                        If charChk = ChrW(&HDA) Then
                            chuoi = strLeft & ChrW(&H1ED2) & strRight
                        End If

                        If charChk = ChrW(&H1A1) Then
                            chuoi = strLeft & ChrW(&H1EDD) & strRight
                        End If
                        If charChk = ChrW(&H1A0) Then
                            chuoi = strLeft & ChrW(&H1EDC) & strRight
                        End If

                        'u
                        If charChk = "u" Then
                            chuoi = strLeft & ChrW(&HF9) & strRight
                        End If
                        If charChk = "U" Then
                            chuoi = strLeft & ChrW(&HD9) & strRight
                        End If

                        If charChk = ChrW(&H1B0) Then
                            chuoi = strLeft & ChrW(&H1EEB) & strRight
                        End If
                        If charChk = ChrW(&H1AF) Then
                            chuoi = strLeft & ChrW(&H1EEA) & strRight
                        End If

                        'y
                        If charChk = "y" Then
                            chuoi = strLeft & ChrW(&H1EF3) & strRight
                        End If
                        If charChk = "Y" Then
                            chuoi = strLeft & ChrW(&H1EF2) & strRight
                        End If

                    Case "3"
                        'a
                        If charChk = "a" Then
                            chuoi = strLeft & ChrW(&H1EA3) & strRight
                        End If
                        If charChk = "A" Then
                            chuoi = strLeft & ChrW(&H1EA2) & strRight
                        End If

                        If charChk = ChrW(&HE2) Then
                            chuoi = strLeft & ChrW(&H1EA9) & strRight
                        End If
                        If charChk = ChrW(&HC2) Then
                            chuoi = strLeft & ChrW(&H1EA8) & strRight
                        End If

                        If charChk = ChrW(&H103) Then
                            chuoi = strLeft & ChrW(&H1EB3) & strRight
                        End If
                        If charChk = ChrW(&H102) Then
                            chuoi = strLeft & ChrW(&H1EB2) & strRight
                        End If

                        'e
                        If charChk = "e" Then
                            chuoi = strLeft & ChrW(&H1EBB) & strRight
                        End If
                        If charChk = "E" Then
                            chuoi = strLeft & ChrW(&H1EBA) & strRight
                        End If

                        If charChk = ChrW(&HEA) Then
                            chuoi = strLeft & ChrW(&H1EC3) & strRight
                        End If
                        If charChk = ChrW(&HCA) Then
                            chuoi = strLeft & ChrW(&H1EC2) & strRight
                        End If

                        'i
                        If charChk = "i" Then
                            chuoi = strLeft & ChrW(&H1EC9) & strRight
                        End If
                        If charChk = "I" Then
                            chuoi = strLeft & ChrW(&H1EC8) & strRight
                        End If

                        'o
                        If charChk = "o" Then
                            chuoi = strLeft & ChrW(&H1ECF) & strRight
                        End If
                        If charChk = "O" Then
                            chuoi = strLeft & ChrW(&H1ECE) & strRight
                        End If

                        If charChk = ChrW(&HF4) Then
                            chuoi = strLeft & ChrW(&H1ED5) & strRight
                        End If
                        If charChk = ChrW(&HDA) Then
                            chuoi = strLeft & ChrW(&H1ED4) & strRight
                        End If

                        If charChk = ChrW(&H1A1) Then
                            chuoi = strLeft & ChrW(&H1EDF) & strRight
                        End If
                        If charChk = ChrW(&H1A0) Then
                            chuoi = strLeft & ChrW(&H1EDE) & strRight
                        End If

                        'u
                        If charChk = "u" Then
                            chuoi = strLeft & ChrW(&H1EE7) & strRight
                        End If
                        If charChk = "U" Then
                            chuoi = strLeft & ChrW(&H1EE6) & strRight
                        End If

                        If charChk = ChrW(&H1B0) Then
                            chuoi = strLeft & ChrW(&H1EED) & strRight
                        End If
                        If charChk = ChrW(&H1AF) Then
                            chuoi = strLeft & ChrW(&H1EEC) & strRight
                        End If

                        'y
                        If charChk = "y" Then
                            chuoi = strLeft & ChrW(&H1EF7) & strRight
                        End If
                        If charChk = "Y" Then
                            chuoi = strLeft & ChrW(&H1EF6) & strRight
                        End If

                    Case "4"
                        'a
                        If charChk = "a" Then
                            chuoi = strLeft & ChrW(&HE3) & strRight
                        End If
                        If charChk = "A" Then
                            chuoi = strLeft & ChrW(&HC3) & strRight
                        End If

                        If charChk = ChrW(&HE2) Then
                            chuoi = strLeft & ChrW(&H1EAB) & strRight
                        End If
                        If charChk = ChrW(&HC2) Then
                            chuoi = strLeft & ChrW(&H1EAA) & strRight
                        End If

                        If charChk = ChrW(&H103) Then
                            chuoi = strLeft & ChrW(&H1EB5) & strRight
                        End If
                        If charChk = ChrW(&H102) Then
                            chuoi = strLeft & ChrW(&H1EB4) & strRight
                        End If

                        'e
                        If charChk = "e" Then
                            chuoi = strLeft & ChrW(&H1EBD) & strRight
                        End If
                        If charChk = "E" Then
                            chuoi = strLeft & ChrW(&H1EBC) & strRight
                        End If

                        If charChk = ChrW(&HEA) Then
                            chuoi = strLeft & ChrW(&H1EC5) & strRight
                        End If
                        If charChk = ChrW(&HCA) Then
                            chuoi = strLeft & ChrW(&H1EC4) & strRight
                        End If

                        'i
                        If charChk = "i" Then
                            chuoi = strLeft & ChrW(&H129) & strRight
                        End If
                        If charChk = "I" Then
                            chuoi = strLeft & ChrW(&H128) & strRight
                        End If

                        'o
                        If charChk = "o" Then
                            chuoi = strLeft & ChrW(&HF5) & strRight
                        End If
                        If charChk = "O" Then
                            chuoi = strLeft & ChrW(&HD5) & strRight
                        End If

                        If charChk = ChrW(&HF4) Then
                            chuoi = strLeft & ChrW(&H1ED7) & strRight
                        End If
                        If charChk = ChrW(&HDA) Then
                            chuoi = strLeft & ChrW(&H1ED6) & strRight
                        End If

                        If charChk = ChrW(&H1A1) Then
                            chuoi = strLeft & ChrW(&H1EE1) & strRight
                        End If
                        If charChk = ChrW(&H1A0) Then
                            chuoi = strLeft & ChrW(&H1EE0) & strRight
                        End If

                        'u
                        If charChk = "u" Then
                            chuoi = strLeft & ChrW(&H169) & strRight
                        End If
                        If charChk = "U" Then
                            chuoi = strLeft & ChrW(&H168) & strRight
                        End If

                        If charChk = ChrW(&H1B0) Then
                            chuoi = strLeft & ChrW(&H1EEF) & strRight
                        End If
                        If charChk = ChrW(&H1AF) Then
                            chuoi = strLeft & ChrW(&H1EEE) & strRight
                        End If

                        'y
                        If charChk = "y" Then
                            chuoi = strLeft & ChrW(&H1EF9) & strRight
                        End If
                        If charChk = "Y" Then
                            chuoi = strLeft & ChrW(&H1EF8) & strRight
                        End If

                    Case "5"
                        'a
                        If charChk = "a" Then
                            chuoi = strLeft & ChrW(&H1EA1) & strRight
                        End If
                        If charChk = "A" Then
                            chuoi = strLeft & ChrW(&H1EA0) & strRight
                        End If

                        If charChk = ChrW(&HE2) Then
                            chuoi = strLeft & ChrW(&H1EAD) & strRight
                        End If
                        If charChk = ChrW(&HC2) Then
                            chuoi = strLeft & ChrW(&H1EAC) & strRight
                        End If

                        If charChk = ChrW(&H103) Then
                            chuoi = strLeft & ChrW(&H1EB7) & strRight
                        End If
                        If charChk = ChrW(&H102) Then
                            chuoi = strLeft & ChrW(&H1EB6) & strRight
                        End If

                        'e
                        If charChk = "e" Then
                            chuoi = strLeft & ChrW(&H1EB9) & strRight
                        End If
                        If charChk = "E" Then
                            chuoi = strLeft & ChrW(&H1EB8) & strRight
                        End If

                        If charChk = ChrW(&HEA) Then
                            chuoi = strLeft & ChrW(&H1EC7) & strRight
                        End If
                        If charChk = ChrW(&HCA) Then
                            chuoi = strLeft & ChrW(&H1EC6) & strRight
                        End If

                        'i
                        If charChk = "i" Then
                            chuoi = strLeft & ChrW(&H1ECB) & strRight
                        End If
                        If charChk = "I" Then
                            chuoi = strLeft & ChrW(&H1ECA) & strRight
                        End If

                        'o
                        If charChk = "o" Then
                            chuoi = strLeft & ChrW(&H1ECD) & strRight
                        End If
                        If charChk = "O" Then
                            chuoi = strLeft & ChrW(&H1ECC) & strRight
                        End If

                        If charChk = ChrW(&HF4) Then
                            chuoi = strLeft & ChrW(&H1ED9) & strRight
                        End If
                        If charChk = ChrW(&HD4) Then
                            chuoi = strLeft & ChrW(&H1ED8) & strRight
                        End If

                        If charChk = ChrW(&H1A1) Then
                            chuoi = strLeft & ChrW(&H1EE3) & strRight
                        End If
                        If charChk = ChrW(&H1A0) Then
                            chuoi = strLeft & ChrW(&H1EE2) & strRight
                        End If

                        'u
                        If charChk = "u" Then
                            chuoi = strLeft & ChrW(&H1EE5) & strRight
                        End If
                        If charChk = "U" Then
                            chuoi = strLeft & ChrW(&H1EE4) & strRight
                        End If

                        If charChk = ChrW(&H1B0) Then
                            chuoi = strLeft & ChrW(&H1EF1) & strRight
                        End If
                        If charChk = ChrW(&H1AF) Then
                            chuoi = strLeft & ChrW(&H1EF0) & strRight
                        End If

                        'y
                        If charChk = "y" Then
                            chuoi = strLeft & ChrW(&H1EF5) & strRight
                        End If
                        If charChk = "Y" Then
                            chuoi = strLeft & ChrW(&H1EF4) & strRight
                        End If

                    Case "6"
                        'a
                        If charChk = "a" Then
                            chuoi = strLeft & ChrW(&HE2) & strRight
                        End If
                        If charChk = "A" Then
                            chuoi = strLeft & ChrW(&HC2) & strRight
                        End If

                        'e
                        If charChk = "e" Then
                            chuoi = strLeft & ChrW(&HEA) & strRight
                        End If
                        If charChk = "E" Then
                            chuoi = strLeft & ChrW(&HCA) & strRight
                        End If

                        'o
                        If charChk = "o" Then
                            chuoi = strLeft & ChrW(&HF4) & strRight
                        End If
                        If charChk = "O" Then
                            chuoi = strLeft & ChrW(&HD4) & strRight
                        End If

                    Case "7"
                        'o
                        If charChk = "o" Then
                            chuoi = strLeft & ChrW(&H1A1) & strRight
                        End If
                        If charChk = "O" Then
                            chuoi = strLeft & ChrW(&H1A0) & strRight
                        End If

                        'u
                        If charChk = "u" Then
                            chuoi = strLeft & ChrW(&H1B0) & strRight
                        End If
                        If charChk = "U" Then
                            chuoi = strLeft & ChrW(&H1AF) & strRight
                        End If

                    Case "8"
                        'a
                        If charChk = "a" Then
                            chuoi = strLeft & ChrW(&H103) & strRight
                        End If
                        If charChk = "A" Then
                            chuoi = strLeft & ChrW(&H102) & strRight
                        End If

                    Case "9"
                        'd
                        If charChk = "d" Then
                            chuoi = strLeft & ChrW(&H111) & strRight
                        End If
                        If charChk = "D" Then
                            chuoi = strLeft & ChrW(&H110) & strRight
                        End If
                End Select
            Next i
        Next j
        Viethoa = chuoi
    End Function

    Function Viet_Telex(chuoi As String)
        Dim i As Integer
        Dim j As Integer
        For j = 1 To 2
            For i = 2 To Len(chuoi)


            Next
        Next
        Viet_Telex = chuoi
    End Function


    Private Sub but_v_Click(sender As System.Object, e As System.EventArgs) Handles but_v.Click
        myString = myString & but_v.Text
        displayVal()
    End Sub
End Class