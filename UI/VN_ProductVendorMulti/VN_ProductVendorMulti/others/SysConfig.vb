Public Class SysConfig
    Public Shared commonPass As String = "hnvVendor"
    Private Sub butSetConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSetConnection.Click
        'neu dung port thi phai: localhost,8100 / localhost/HNV,8100
        Dim s = "Data Source=@ip ;Initial Catalog=@db;Encrypt=True;TrustServerCertificate=True;Persist Security Info=True;User ID=@login ;Password=@pass"
        'Dim s = "Server=@ip ;Initial Catalog=@db;Encrypt=True;TrustServerCertificate=True;Persist Security Info=True;User ID=@login ;Password=@pass"
        Dim tmp As String = ""

        tmp = s.Replace("@ip", txtIP.Text.Trim).Replace("@db", txtDB_01.Text.Trim).Replace("@login", txtLogin.Text.Trim).Replace("@pass", txtPass.Text.Trim)
        My.Settings.SetUserOverride("pharmacySQLConnectionString", tmp)

        tmp = s.Replace("@ip", txtIP.Text.Trim).Replace("@db", txtDB_02.Text.Trim).Replace("@login", txtLogin.Text.Trim).Replace("@pass", txtPass.Text.Trim)
        My.Settings.SetUserOverride("factManagementConnectionString", tmp)

        tmp = s.Replace("@ip", txtIP.Text.Trim).Replace("@db", txtDB_03.Text.Trim).Replace("@login", txtLogin.Text.Trim).Replace("@pass", txtPass.Text.Trim)
        My.Settings.SetUserOverride("posprinterConnectionString", tmp)

        My.Settings.setting_dbSource = txtIP.Text.Trim
        My.Settings.setting_dbLogin = AESTool.encrypt(txtLogin.Text.Trim, commonPass)
        My.Settings.setting_dbPass = AESTool.encrypt(txtPass.Text.Trim, commonPass)

        My.Settings.setting_dbName_01 = txtDB_01.Text.Trim
        My.Settings.setting_dbName_02 = txtDB_02.Text.Trim
        My.Settings.setting_dbName_03 = txtDB_03.Text.Trim
        
        Dim lang =  cmbLang.SelectedItem  
        My.Settings.setting_sysLang = lang

        My.Settings.Save()

       
       

        MsgBox("Kết nối cơ sở dữ liệu đã được thiết lập lại. Vui lòng khởi động lại chương trình!", MsgBoxStyle.Information, "Thay đổi thành công")

        Environment.Exit(0)
    End Sub

    Private Sub SysConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadConfig()
    End Sub
    Private Sub initCmbLang()
        Dim lang As String() = {"vi", "fr", "en"}
        Dim items(Me.imgListLang.Images.Count - 1) As String
        For i As Int32 = 0 To Me.imgListLang.Images.Count - 1
            items(i) = lang(i)
        Next
        Me.cmbLang.Items.AddRange(items)
        Me.cmbLang.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbLang.DrawMode = DrawMode.OwnerDrawVariable
        Me.cmbLang.ItemHeight = Me.imgListLang.ImageSize.Height
        Me.cmbLang.MaxDropDownItems = Me.imgListLang.Images.Count * 2

        cmbLang.SelectedItem = My.Settings.setting_sysLang
    End Sub
    Private Sub cmbLang_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles cmbLang.DrawItem
        If e.Index <> -1 Then
            e.Graphics.DrawImage(Me.imgListLang.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
            e.Graphics.DrawString(Me.cmbLang.Items(e.Index).ToString(), e.Font, New SolidBrush(e.ForeColor), e.Bounds.Left + 40, e.Bounds.Top + 10)
        End If
    End Sub

    Private Sub cmbLang_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles cmbLang.MeasureItem
        e.ItemHeight = Me.imgListLang.ImageSize.Height
        e.ItemWidth = Me.imgListLang.ImageSize.Width
    End Sub

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

    Public Sub loadConfig()
        If My.Settings.setting_dbLogin <> "" Then
            txtLogin.Text = AESTool.decrypt(My.Settings.setting_dbLogin, commonPass) 'My.Settings.setting_dbLogin
        End If

        If My.Settings.setting_dbPass <> "" Then
            txtPass.Text = AESTool.decrypt(My.Settings.setting_dbPass, commonPass) 'My.Settings.setting_dbPass
        End If

        If My.Settings.setting_dbSource <> "" Then
            txtIP.Text = My.Settings.setting_dbSource
        End If

        '----------------------------------------------------------
        '----------------------------------------------------------
        If My.Settings.setting_dbName_01 <> "" Then
            txtDB_01.Text = My.Settings.setting_dbName_01
        End If
        If My.Settings.setting_dbName_02 <> "" Then
            txtDB_02.Text = My.Settings.setting_dbName_02
        End If
        If My.Settings.setting_dbName_03 <> "" Then
            txtDB_03.Text = My.Settings.setting_dbName_03
        End If

        initCmbLang()

        '-----Printer config-----------------------------------------
        getListPrinter()
        loadPrinterConfig()
    End Sub
    Private Sub saveConfig()
        printer_MySelf = chkMyPrinter.Checked

        printer_Name = cmbPrinter.Text.Trim
        POSPrint.PrinterSettings.PrinterName = Name

        printer_Logo_With = chkLogoWith.Checked
        printer_Logo_Width = MyFunct.getVal(txtLogoWidth.Text.Trim)
        printer_Logo_Height = MyFunct.getVal(txtLogoHeight.Text.Trim)
        printer_Logo_Path = txtLogoPath.Text.Trim

        printer_Char_NbPerLine = MyFunct.getVal(txtCharNbPerLine.Text.Trim)
        printer_Char_FontName = txtCharFontName.Text.Trim
        printer_Char_FontSize = MyFunct.getVal(txtCharFontSize.Text.Trim)

        My.Settings.setting_printer_MySelf = printer_MySelf
        My.Settings.setting_printer_Name = printer_Name

        My.Settings.setting_printer_Logo_Opt_01 = printer_Logo_With
        My.Settings.setting_printer_Logo_Opt_02 = printer_Logo_Width & ""
        My.Settings.setting_printer_Logo_Opt_03 = printer_Logo_Height & ""
        My.Settings.setting_printer_Logo_Opt_04 = printer_Logo_Path

        My.Settings.setting_printer_Line_Opt_01 = printer_Char_NbPerLine & ""
        My.Settings.setting_printer_Line_Opt_02 = printer_Char_FontName
        My.Settings.setting_printer_Line_Opt_03 = printer_Char_FontSize & ""
        My.Settings.Save()

        If (printer_Name.Length > 0) Then
            doInitPosPrinter(printer_Name)
        End If
    End Sub

    Private Sub loadPrinterConfig()
        chkMyPrinter.Checked = My.Settings.setting_printer_MySelf
        cmbPrinter.Text = My.Settings.setting_printer_Name

        chkLogoWith.Checked = My.Settings.setting_printer_Logo_Opt_01
        txtLogoWidth.Text = My.Settings.setting_printer_Logo_Opt_02
        txtLogoHeight.Text = My.Settings.setting_printer_Logo_Opt_03
        txtLogoPath.Text = My.Settings.setting_printer_Logo_Opt_04
        If (txtLogoPath.Text.Length = 0) Then
            Dim dataDirectory As String = String.Format("{0}\", Environment.CurrentDirectory)
            txtLogoPath.Text = IO.Directory.GetCurrentDirectory() & "\Resources\Logo.bmp"
            'txtLogoPath.Text = IO.Directory.GetCurrentDirectory() & "\Resources\Logo.bmp"
        End If


        txtCharNbPerLine.Text = My.Settings.setting_printer_Line_Opt_01
        txtCharFontName.Text = My.Settings.setting_printer_Line_Opt_02
        txtCharFontSize.Text = My.Settings.setting_printer_Line_Opt_03

        printer_MySelf = chkMyPrinter.Checked
        printer_Name = cmbPrinter.Text.Trim
        printer_Logo_With = chkLogoWith.Checked
        printer_Logo_Width = MyFunct.getVal(txtLogoWidth.Text.Trim)
        printer_Logo_Height = MyFunct.getVal(txtLogoHeight.Text.Trim)
        printer_Logo_Path = txtLogoPath.Text.Trim
        If (Not IsNothing(printer_Logo_Path)) Then
            Try
                printer_Logo = Image.FromFile(printer_Logo_Path) 'IO.Directory.GetCurrentDirectory() & "\Resources\Logo.bmp")
            Catch ex As Exception

            End Try
        End If


        printer_Char_NbPerLine = MyFunct.getVal(txtCharNbPerLine.Text.Trim)
        printer_Char_FontName = txtCharFontName.Text.Trim
        printer_Char_FontSize = MyFunct.getVal(txtCharFontSize.Text.Trim)

        If (printer_Name.Length > 0) Then
            doInitPosPrinter(printer_Name)
        End If
    End Sub

    Sub getListPrinter()
        Dim list = PrinterUtilities.getPrinters()
        If (list.Count > 0) Then
            For Each item In list
                cmbPrinter.Items.Add(item)
            Next
        End If

        cmbPrinter.Text = My.Settings.setting_printer_Name  'get default saved

        If (Not IsNothing(My.Settings.setting_printer_Name)) Then
            printer_Ready = True
        End If
    End Sub

    Private Sub doInitPosPrinter(ByVal name)
        POSPrint.PrinterSettings.PrinterName = name
        printer_Ready = True
    End Sub

    Public Sub doPrint(ByVal numSelling As Integer, ByVal idVendor As Integer,
                      ByVal astrItem() As String, ByVal astrUnit() As String, ByVal astrQ() As Decimal, ByVal astrPrice() As Decimal, _
                      ByVal initTotal As Double, ByVal discount As Double, ByVal total As Double,
                      ByVal clientIn As Double, ByVal clientOut As Double)

        If (Not printer_Ready) Then
            getListPrinter()
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

    Private Sub butTestPrinter_Click(sender As System.Object, e As System.EventArgs) Handles butTestPrinter.Click
        Dim tmp_Name = printer_Name
        Dim tmp_Logo_01 = printer_Logo_With
        Dim tmp_Logo_02 = printer_Logo_Width
        Dim tmp_Logo_03 = printer_Logo_Height
        Dim tmp_Logo_04 = printer_Logo_Path
        Dim tmp_Logo = printer_Logo

        Dim tmp_Char_01 = printer_Char_NbPerLine
        Dim tmp_Char_02 = printer_Char_FontName
        Dim tmp_Char_03 = printer_Char_FontSize
        Try


            printer_Name = cmbPrinter.Text.Trim
            POSPrint.PrinterSettings.PrinterName = printer_Name

            printer_Logo_With = chkLogoWith.Checked
            printer_Logo_Width = MyFunct.getVal(txtLogoWidth.Text.Trim)
            printer_Logo_Height = MyFunct.getVal(txtLogoHeight.Text.Trim)
            printer_Logo_Path = txtLogoPath.Text.Trim

            If printer_Logo_With Then
                Try
                    printer_Logo = Image.FromFile(printer_Logo_Path)
                Catch ex As Exception
                    Try
                        printer_Logo = Image.FromFile(IO.Directory.GetCurrentDirectory() & printer_Logo_Path)
                    Catch ex2 As Exception
                    End Try
                End Try
            End If

            printer_Char_NbPerLine = MyFunct.getVal(txtCharNbPerLine.Text.Trim)
            printer_Char_FontName = txtCharFontName.Text.Trim
            printer_Char_FontSize = MyFunct.getVal(txtCharFontSize.Text.Trim)

            testPrinter()
        Catch ex As Exception
            MsgBox("Không in được, kiểm tra lại cấu hình", vbCritical, "Lỗi")
        End Try

        printer_Name = tmp_Name
        printer_Logo_With = tmp_Logo_01
        printer_Logo_Width = tmp_Logo_02
        printer_Logo_Height = tmp_Logo_03
        printer_Logo_Path = tmp_Logo_04
        printer_Logo = tmp_Logo

        printer_Char_NbPerLine = tmp_Char_01
        printer_Char_FontName = tmp_Char_02
        printer_Char_FontSize = tmp_Char_03

        POSPrint.PrinterSettings.PrinterName = printer_Name
    End Sub

    Private Sub testPrinter()
        'test
        Dim listProduct_ As String() = {"Sản phẩm 1 - ĐÀ NẴNG", "Sản phẩm 2 - HCM"}
        Dim listUnit_ As String() = {"Viên", "Hộp"}
        Dim listQ_ As Decimal() = {10, 100}
        Dim listPrice_ As Decimal() = {10000.0, 9000000}


        Dim initT = 1000000
        Dim discount = 1000
        Dim total = 9000000


        Dim clientIn = 100000
        Dim clientOut = 200000
        Dim idVendor = 100
        Dim numSelling = 123456

        doPrint(numSelling, idVendor, listProduct_, listUnit_, listQ_, listPrice_, initT, discount, total, clientIn, clientOut)
    End Sub

    Private Sub butResetConfig_Click(sender As System.Object, e As System.EventArgs) Handles butResetConfig.Click
        loadPrinterConfig()
    End Sub

    Private Sub butSetPrinter_Click(sender As System.Object, e As System.EventArgs) Handles butSetPrinter.Click
        saveConfig()
    End Sub

    Private Sub butInstallPOS_Click(sender As System.Object, e As System.EventArgs) Handles butInstallPOS.Click
        Try
            Process.Start("POSforDotNet-1.14.msi")
        Catch ex As Exception
            MsgBox("Cannot install POSService")
        End Try
    End Sub
End Class