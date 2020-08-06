Public Class MyFunct
    Public Shared Sub fillProductInfo(ByVal idProdInfo, ByVal ProductInfoTableAdapter,
                             ByVal cmbProductName, ByVal txtCodingBarOrig, ByVal txtCodingBar, ByVal txtRegNum,
                             ByVal cmbLocation)
        Try
            Dim rows = ProductInfoTableAdapter.GetBy_Id(idProdInfo)
            Dim row = rows(0)

            cmbProductName.Text = row("ProductName")
            txtCodingBarOrig.text = row("BarCode_Origin")
            txtCodingBar.Text = row("BarCode")
            txtRegNum.Text = row("NumReg")
            cmbLocation.Text = row("Location")
            Try
                cmbProductName.SelectedValue = row("id")
            Catch ex As Exception

            End Try
            Try
                cmbLocation.SelectedValue = row("idLocation")
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MsgBox("Ereur o fillProductInfo")
        End Try
    End Sub

    Public Shared Function formatNum(ByVal num) As String
        If num Is Nothing Or num Is DBNull.Value Then
            Return "0"
        End If

        Return Format(num, formatNumber)
    End Function
    Public Shared Function formatString(ByVal s As String) As String
        While (s.Contains("  "))
            s = s.Replace("  ", " ")
        End While
        Return s.Trim().ToUpper()
    End Function
    Public Shared Function formatUnit(ByVal s As String) As String
        While (s.Contains("  "))
            s = s.Replace("  ", " ")
        End While
        Dim separator() As Char = {" ", "/", "\"}

        Dim words As String() = s.Split(separator)
        If words.Length > 1 Then
            s = words(0) & "/"
        Else
            s = words(0)
        End If
        For i = 1 To words.Length - 1
            s = s & words(i)
        Next
        Return s.Trim().ToUpper()
    End Function


    Public Shared formatNumber As String = "### ### ### ###.00"
    Public Shared formatDate As String = "dd/MM/yyyy"
    Public Shared screenW = Screen.PrimaryScreen.Bounds.Width
    Public Shared screenH = Screen.PrimaryScreen.Bounds.Height
    Public Shared Sub resizeForm(ByVal form As Form)
        Dim w = Math.Min(screenW * 4 / 5, 1000)
        Dim h = Math.Min(screenH * 4 / 5, 700)
        form.Size = New System.Drawing.Size(w, h)
    End Sub
    Public Shared Function getVal(ByVal s As String) As Decimal
        Try
            Dim s1 As String = s.Replace(" ", "") 'ky tu ki la tuong tu klhoang trong trong string
            s1 = s1.Replace(" ", "")
            s1 = s1.Replace(",", ".")
            Dim k As Decimal = Val(s1)
            Return k
        Catch ex As Exception
            MsgBox("Có lỗi đổi số")
            Return -1
        End Try
    End Function

    Public Shared Function crypter(ByVal chaîneACrypter As String) As String
        '---------------------------------------------------------------------------------------
        ' Objet     : Crypter la chaîne chaîneACrypter en fonction d'une clef et de la méthode
        '               de Vigenère
        '---------------------------------------------------------------------------------------
        '
        Dim sLettres As String = Nothing
        Dim lCompteur As Long
        Dim lLongueur As Long
        Dim lBoucle As Long

        'Définition des constantes utiles pour la fonction (Clé et nombre d'itérations de la fonction maximum)
        Const CLEF As String = "nbvfdszé""'(-è_ijhgfcKLKjhgyuilM^+)àçiu-('32azsDRtvBhujkoç_è6tre""zsXWqazerfcx<;:<?"
        Const NBROTATIONSMAX As Long = 13

        'Définition de la longueur de la chaîne à crypter et de la chaîne de résultat
        lLongueur = Len(chaîneACrypter)

        For lCompteur = 1 To lLongueur
            sLettres &= Chr(0)
        Next
        'sLettres = String(lLongueur, Chr(0))

        'Boucler en fonction du nombre de rotations attendues
        For lBoucle = 1 To NBROTATIONSMAX
            'boucler pour chaque caractère de la chaîne initiale
            For lCompteur = 1 To lLongueur
                'Remplacer le caractère de la chaîne à crypter par le caractère correspondant à
                '   le reste de
                '       la valeur ascii du caractère à crypter
                '       plus
                '       la valeur ascii du caractère correspondant dans la clé, multiplié par la longueur de la clé
                '   quand on le divise par 256
                Mid(sLettres, lCompteur, 1) = Chr((Asc(Mid(chaîneACrypter, lCompteur, 1)) + _
         (Asc(Mid(CLEF, (lCompteur Mod Len(CLEF)) + 1, 1)) * lLongueur)) Mod 256)
                'recommencer
            Next
            'réaffecter la chaîne à crypter par le résultat trouvé pour pouvoir recommencer une itération
            chaîneACrypter = sLettres
            'Nouvelle itération
        Next
        'Renvoyer le résultat final
        Return sLettres
    End Function

    Function getGroup(ByVal code As String) As String
        If (IsNothing(code) Or Len(code) < 10) Then
            Return ""
        Else
            Try
                Dim v As Integer = Val(code.Substring(4, 2))
                If (v = 0) Then Return ""
                Select Case (v)
                    Case 1 : Return "Tiêu hóa"
                    Case 2 : Return "Tim mạch"
                    Case 3 : Return "Hô hấp"
                    Case 4 : Return "Thần kinh giảm đau"""
                    Case 5 : Return "Cơ xương"
                    Case 6 : Return "Hormon"
                    Case 7 : Return "Ngừa thai"
                    Case 8 : Return "Kháng sinh"
                    Case 9 : Return "Ung thư"
                    Case 10 : Return "Tiết niệu"
                    Case 11 : Return "Nội tiết"
                    Case 12 : Return "Viamin"
                    Case 13 : Return "Dinh dưỡng"
                    Case 14 : Return "Mắt"
                    Case 15 : Return "Tai-Mũi-Họng"
                    Case 16 : Return "Da liễu"
                    Case 17 : Return "Gây mê"
                    Case 18 : Return "Dị ứng"
                    Case 19 : Return "Giải độc"
                    Case 20 : Return "Dung dịch"
                    Case 21 : Return "Chống viêm"
                    Case 22 : Return "Đông dược"
                    Case 23 : Return "TP chức năng"
                    Case 24 : Return "Mỹ phẩm"
                    Case 25 : Return "VT"
                    Case 26 : Return "Kháng khuẩn dùng ngoài"
                    Case 27 : Return "Khác (dd xoa bóp, dầu…)"
                    Case 28 : Return "Phụ khoa"
                    Case 29 : Return "Hạ sốt giảm đau"
                End Select
            Catch ex As Exception
                Return ""
            End Try

        End If
        Return ""
    End Function
End Class
