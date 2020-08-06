Imports System.Globalization
Imports Microsoft.PointOfService

Public Class PrinterUtilities


    Public Shared Sub print(ByVal m_Printer As Microsoft.PointOfService.PosPrinter, ByVal printLogo As Boolean, _
                            ByVal numSelling As String, _
                            ByVal astrItem() As String, ByVal astrUnit() As String, ByVal astrQ() As Decimal, ByVal astrPrice() As Decimal, _
                            ByVal initTotal As Double, ByVal discount As Double, ByVal total As Double,
                            ByVal clientIn As Double, ByVal clientOut As Double, ByVal idVendor As Integer)
        Dim ESC As String
        Dim optionHH As String
        Dim dateTime As DateTime = New DateTime
        Dim dateFormat As DateTimeFormatInfo = New DateTimeFormatInfo
        Dim strDate As String
        Dim sRecLineChars() As String = {""}
        Dim lRecLineCharsCount As Long



        ' Dim astrItem() As String = {"apples", "grapes", "bananas", "lemons", "oranges"}
        'Dim astrPrice() As String = {"10.00", "20.00", "30.00", "40.00", "50.00"}


        '        PRINT #1, Chr(&H1B);"!";Chr(0); "AA";AA: Normal
        'PRINT #1, Chr(&H1B);"!";Chr(8); "BB"; BB: Emphasized
        'PRINT #1, Chr(&H1B);"!";Chr(16); "CC";CC: Double-height
        'PRINT #1, Chr(&H1B);"!";Chr(24); "DD";DD: Emphasized + Double-height
        'PRINT #1, Chr(&H1B);"!";Chr(32); "EE";EE: Double-width
        'PRINT #1, Chr(&H1B);"!";Chr(40); "FF"; FF: Emphasized + Double-width
        'PRINT #1, Chr(&H1B);"!";Chr(48); "GG";GG: Double-height + Double-width
        'PRINT #1, Chr(&H1B);"!";Chr(56); "HH"; Chr(&HA); HH: Emphasized + Double-height + Double-width
        'with underline
        'PRINT #1, Chr(&H1B);"!";Chr(129); "AA";
        'PRINT #1, Chr(&H1B);"!";Chr(137); "BB"; 
        'PRINT #1, Chr(&H1B);"!";Chr(145); "CC"; 
        'PRINT #1, Chr(&H1B);"!";Chr(153); "DD"; 
        'PRINT #1, Chr(&H1B);"!";Chr(161); "EE";
        'PRINT #1, Chr(&H1B);"!";Chr(169); "FF"; 
        'PRINT #1, Chr(&H1B);"!";Chr(177); "GG"; 
        'PRINT #1, Chr(&H1B);"!";Chr(185); "HH"; Chr(&HA);


        'ESC command
        ESC = Chr(&H1B)
        optionHH = Chr(56)

        'Get current date
        dateTime = System.DateTime.Now()
        'dateFormat.MonthDayPattern = "MMMM"
        strDate = dateTime.ToString("dd/MM/yyyy HH:mm", dateFormat)

        Try

            If printLogo Then
                Try
                    m_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|1B")
                Catch ex As Exception

                End Try

                'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|100uF")
                'Dim strFilePath = IO.Directory.GetCurrentDirectory() & "\Resources\Logo.bmp"
                'm_Printer.PrintBitmap(PrinterStation.Receipt, strFilePath, m_Printer.RecLineWidth / 3, Microsoft.PointOfService.PosPrinter.PrinterBitmapLeft)
                'm_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|rA" & "67 Hải Phòng ĐN" & vbCrLf)
            End If

            'm_Printer.RecLineChars = sRecLineChars(1)
            'Print address

            ' m_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|N" & "67 Hải Phòng ĐN") ' & vbCrLf)
            'Print phone number
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|rA" & "0511-3888656" & vbCrLf)
            'm_Printer.RecLineChars = sRecLineChars(0)

            'Change the font size and print the date
            'ESC|cA = Centering char

            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" + "HÓA ĐƠN BÁN HÀNG" + vbCrLf)
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" + "Phiếu bán hàng số: " + numSelling + vbCrLf)
            'If (idVendor > 0) Then
            '    m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" + "Nhân viên bán : " + idVendor.ToString() + vbCrLf)
            'End If

            lRecLineCharsCount = GetRecLineChars(m_Printer, sRecLineChars)
            'If lRecLineCharsCount >= 2 Then
            '    m_Printer.RecLineChars = sRecLineChars(1)
            '    'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" + strDate + vbCrLf + vbCrLf)
            '    m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N" + "Phiếu bán hàng số: " + numSelling + " ")
            '    m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + strDate + vbCrLf + vbCrLf)
            '    m_Printer.RecLineChars = sRecLineChars(0)
            'Else
            '    m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N" + "Phiếu bán hàng số: " + numSelling + " ")
            '    m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + strDate + vbCrLf + vbCrLf)
            'End If
            'm_Printer.RecLineChars = sRecLineChars(1)
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "!" + optionHH + ESC + "|N" + "Phiếu bán hàng số: " + numSelling + " ")
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|N" + "Phiếu bán hàng số: " + numSelling + " ")
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + strDate + vbCrLf + vbCrLf)

            If (idVendor > 0) Then
                m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + "Nhân viên bán : " + idVendor.ToString() + vbCrLf)
            End If

            m_Printer.RecLineChars = sRecLineChars(1)
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|uC" + MakePrintString(m_Printer.RecLineChars, "", "") + vbCrLf)
            m_Printer.RecLineChars = sRecLineChars(0)

            'ESC|#uF = Line Feed
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|100uF")

            'Print buying goods
            Dim strPrintData As String = ""
            Dim limProdLen = 30
            Dim space = 5
            For i As Integer = 0 To astrItem.Length - 1
                If IsNothing(astrItem(i)) Then Exit For

                Dim prodName As String = astrItem(i)
                If (prodName.Length > 12) Then prodName = prodName.Substring(0, 11) & "."

                strPrintData = MakePrintStringProduct(limProdLen, prodName, astrUnit(i), astrQ(i))
                m_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|N" & strPrintData)
                'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + astrPrice(i).ToString("F") + "đ" + vbCrLf)
                m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + astrPrice(i).ToString("# ### ### ###") + "đ" + vbCrLf)

                'strPrintData = MakePrintString(m_Printer.RecLineChars, astrItem(i), astrQ(i).ToString("F"), astrPrice(i).ToString("F") + "đ")
                'm_Printer.PrintNormal(PrinterStation.Receipt, strPrintData + vbCrLf)
                'm_Printer.PrintNormal(PrinterStation.Receipt, strPrintData + vbCrLf)
                'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" + strPrintData)
                'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + astrPrice(i).ToString("F") + "đ" + vbCrLf)


                'total += Val(astrPrice(i))
            Next

            'Make 1mm speces
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|100uF")

            m_Printer.RecLineChars = sRecLineChars(1)
            strPrintData = MakePrintString(m_Printer.RecLineChars, "", "")
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|uC" + strPrintData + vbCrLf)
            m_Printer.RecLineChars = sRecLineChars(0)

            m_Printer.RecLineChars = sRecLineChars(1)

            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|N" & "Tổng")
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + initTotal.ToString("F") + "đ" + vbCrLf)
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + initTotal.ToString("# ### ### ###") + "đ" + vbCrLf)

            m_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|N" & "KM")
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + discount.ToString("F") + "đ" + vbCrLf)
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + discount.ToString("# ### ### ###") + "đ" + vbCrLf)

            m_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|N" & "Khách")
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + clientIn.ToString("# ### ### ###") + "đ" + vbCrLf)

            m_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|N" & "Trả")
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + clientOut.ToString("# ### ### ###") + "đ" + vbCrLf)

            'strPrintData = MakePrintString(m_Printer.RecLineChars / 2, "TC", total.ToString("F") + "đ")
            strPrintData = MakePrintString(m_Printer.RecLineChars / 2, "TC", total.ToString("# ### ### ###") + "đ")
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|2C" + strPrintData + vbCrLf)
            m_Printer.RecLineChars = sRecLineChars(0)
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" + "Quý khách kiểm tra kỹ" + vbCrLf)
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" + "Nhà thuốc không nhận hàng trả lại. Cám ơn." + vbCrLf)
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|cA" + "Xin chân thành cám ơn quý khách" + vbCrLf)

            'm_Printer.RecLineChars = sRecLineChars(1)
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|N" & "Khách đưa")
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + clientIn.ToString("F") + "đ" + vbCrLf)

            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC & "|N" & "Trả khách")
            'm_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|rA" + clientOut.ToString("F") + "đ" + vbCrLf)

            ''ESC|#fP = Line Feed and Paper cut	
            m_Printer.PrintNormal(PrinterStation.Receipt, ESC + "|fP")
            'm_Printer.CutPaper(100)

        Catch ex As PosControlException
            MsgBox("Không thể in vì không tồn tại máy in!", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Shared Function GetRecLineChars(ByVal m_Printer As Microsoft.PointOfService.PosPrinter, ByRef sRecLineChars() As String) As Long
        Dim lCount As Long
        Dim i As Integer

        'Calculate the element count.
        lCount = m_Printer.RecLineCharsList.GetLength(0)

        If lCount = 0 Then
            GetRecLineChars = 0
        Else
            'Set the element to array.
            ReDim sRecLineChars(lCount)

            For i = 0 To (lCount - 1)
                sRecLineChars(i) = m_Printer.RecLineCharsList(i)
            Next

            GetRecLineChars = lCount
        End If
    End Function
    Private Shared Function MakePrintString(ByVal iRecLineChars As Int32, ByVal strBuf As String, ByVal strPrice As String) As String

        '<<<step5>>>--Start
        Dim strValue As String
        Dim iSpace As Int32 = 0
        Dim tab As String = ""

        iSpace = iRecLineChars - (strBuf.Length + strPrice.Length)

        For i As Integer = 0 To iSpace - 1
            tab += " "
        Next

        strValue = strBuf + tab + strPrice

        MakePrintString = strValue

        '<<<step5>>>--End
    End Function
    'Private Shared Function MakePrintStringProduct(ByVal lim As Int32, ByVal distance As Int32, ByVal strBuf As String, ByVal strUnit As String, ByVal strQ As String) As String
    ' Dim strValue As String
    ' Dim tab As String = ""
    'Dim qLen = 3
    'If (strBuf.Length + strUnit.Length + qLen + distance > lim) Then
    'strBuf = strBuf.Substring(0, lim - (strUnit.Length + qLen) - distance)
    'End If


    'Dim iSpace = lim - strBuf.Length - strUnit.Length - qLen - 3
    ' For i As Integer = 0 To iSpace - 1
    'tab += " "
    'Next
    'strValue = strBuf + tab + strUnit + "  " + strQ


    Private Shared Function MakePrintStringProduct(ByVal lim As Int32, ByVal strProd As String, ByVal strUnit As String, ByVal strQ As String) As String

        Dim strValue As String
        Dim tab1 As String = ""
        Dim tab2 As String = ""
        Dim pLen = 15
        Dim uLen = 5
        Dim qLen = 4
        Dim d1 = 5
        Dim d2 = 2

        If strProd.Length > pLen Then
            strProd = strProd.Substring(0, pLen - 2)
            Try
                Dim lastSpace = strProd.LastIndexOf(" ")
                If (lastSpace > 0) Then
                    strProd = strProd.Substring(0, lastSpace + 1) & strProd.Substring(lastSpace + 1, 1)
                End If
            Catch ex As Exception

            End Try
            strProd = strProd & "."
        End If

        If strProd.Length <= pLen Then
            For i = 0 To pLen - strProd.Length - 1
                tab1 += " "
            Next
        End If

        For i = 0 To d1 - 1
            tab1 += " "
        Next


        If strUnit.Length > uLen Then
            strUnit = strUnit.Substring(0, uLen - 2) & "."
        Else
            For i = 0 To uLen - strUnit.Length - 1
                tab2 += " "
            Next
        End If
        For i = 0 To d2 - 1
            tab2 += " "
        Next

        If strQ.Length < qLen Then
            For i = 0 To qLen - strQ.Length - 1
                tab2 += " "
            Next
        End If

        strValue = strProd + tab1 + strUnit + tab2 + strQ
        Return strValue

    End Function
    Public Shared Function initPrinter(ByVal logicalname As String) As Microsoft.PointOfService.PosPrinter
        'phai co 
        '<configuration>
        '<runtime>
        '<NetFx40_LegacySecurityPolicy enabled="true"/>
        '</runtime>
        '</configuration>

        If logicalname Is Nothing Or logicalname = "" Then
            logicalname = "PosPrinter"
        End If
        'Create PosExplorer
        Dim posExplorer As Microsoft.PointOfService.PosExplorer
        Dim deviceInfo As Microsoft.PointOfService.DeviceInfo
        Dim m_Printer As Microsoft.PointOfService.PosPrinter = Nothing
        For iRetryCount = 0 To 3
            Try
                posExplorer = New Microsoft.PointOfService.PosExplorer
                deviceInfo = posExplorer.GetDevice(Microsoft.PointOfService.DeviceType.PosPrinter, logicalname)
                m_Printer = posExplorer.CreateInstance(deviceInfo)

                'Open the device
                m_Printer.Open()

                'Get the exclusive control right for the opened device.
                'Then the device is disable from other application.
                'm_Printer.Claim(1000)

                'Enable the device.
                'm_Printer.DeviceEnabled = True

                'Output by the high quality mode
                'm_Printer.RecLetterQuality = True

                'Even if using any printers, 0.01mm unit makes it possible to print neatly.
                'm_Printer.MapMode = Microsoft.PointOfService.MapMode.Metric

                'Try
                'Dim strFilePath = IO.Directory.GetCurrentDirectory() & "\Resources\Logo.bmp"
                'm_Printer.SetBitmap(1, PrinterStation.Receipt, strFilePath, _
                '          m_Printer.RecLineWidth, PosPrinter.PrinterBitmapLeft)
                'Catch ex As Exception

                'End Try
                Exit For
            Catch ex As Exception
                System.Threading.Thread.Sleep(2000)
                If iRetryCount = 3 Then
                    MsgBox("Không thể khởi động máy in!", MsgBoxStyle.Critical)
                    Return Nothing
                End If
            End Try
        Next

        Return m_Printer

    End Function

    Public Shared Sub openPrinter(ByVal m_Printer As Microsoft.PointOfService.PosPrinter)
        For iRetryCount = 0 To 5
            Try
                'Open the device
                m_Printer.Open()
                Exit For
            Catch ex As Exception
                System.Threading.Thread.Sleep(2000)
                If iRetryCount = 5 Then
                    MsgBox("Không thể sử dụng máy in!", MsgBoxStyle.Critical)
                End If
            End Try
        Next
    End Sub
    Public Shared Function enablePrinter(ByVal m_Printer As Microsoft.PointOfService.PosPrinter, ByRef hasBitmap As Boolean) As Boolean
        For iRetryCount = 0 To 5
            Try
                'Get the exclusive control right for the opened device.
                'Then the device is disable from other application.
                m_Printer.Claim(1000)

                'Enable the device.
                m_Printer.DeviceEnabled = True

                'Output by the high quality mode
                m_Printer.RecLetterQuality = True

                'Even if using any printers, 0.01mm unit makes it possible to print neatly.
                'm_Printer.MapMode = Microsoft.PointOfService.MapMode.Metric

                Try
                    If (Not hasBitmap) Then
                        Dim strFilePath = IO.Directory.GetCurrentDirectory() & "\Resources\Logo.bmp"
                        m_Printer.SetBitmap(1, PrinterStation.Receipt, strFilePath, _
                                  m_Printer.RecLineWidth, PosPrinter.PrinterBitmapLeft)
                        hasBitmap = True
                    End If
                Catch ex As Exception

                End Try
                Exit For
            Catch ex As Exception
                System.Threading.Thread.Sleep(2000)
                If iRetryCount = 5 Then
                    MsgBox("Không thể sử dụng máy in!", MsgBoxStyle.Critical)
                    Return False
                End If
            End Try
        Next
        Return True
    End Function

    Public Shared Sub closePrinter(ByVal m_Printer As Microsoft.PointOfService.PosPrinter)
        '<<<step1>>>--Start
        If m_Printer Is Nothing Then
            Return
        End If

        m_Printer.Close()

        '<<<step1>>>--End
    End Sub
    Public Shared Sub realeasePrinter(ByVal m_Printer As Microsoft.PointOfService.PosPrinter)
        '<<<step1>>>--Start
        If m_Printer Is Nothing Then
            Return
        End If

        Try
            'Cancel the device
            m_Printer.DeviceEnabled = False

            'Release the device exclusive control right.
            m_Printer.Release()


        Catch ex As PosControlException
        End Try
        '<<<step1>>>--End
    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------

    Public Shared Function getPrinters() As ArrayList
        Dim list As ArrayList = New ArrayList
        For Each printer In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            list.Add(printer.ToString)
        Next
        Return list
    End Function

    Private Shared Function getPageHeader(ByVal txtPrint As String, ByVal nbCharPerLine As Integer,
                                          ByVal numSelling As String, ByVal vendor As String) As String
        'Get current date
        Dim dateFormat As DateTimeFormatInfo = New DateTimeFormatInfo
        Dim dateTime As DateTime = System.DateTime.Now()
        Dim strDate As String = dateTime.ToString("dd/MM/yyyy HH:mm", dateFormat)

        'test to show nb max of chars per line 
        'txtPrint &= newLine_AlignRight(nbCharPerLine, " 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789") '80 chars


        Dim right = 20
        Dim left = nbCharPerLine - right
        txtPrint &= newLine_AlignLeftRight(nbCharPerLine, left, right, "Phiếu bán hàng: " & numSelling, strDate)
        txtPrint &= newLine_AlignLeft(nbCharPerLine, "Nhân viên bán: " + vendor)
        txtPrint &= Environment.NewLine

        Return txtPrint
    End Function

    Private Shared Function getPageContent(ByVal txtPrint As String, ByVal nbCharPerLine As Integer,
                                           ByVal astrItem() As String, ByVal astrUnit() As String, ByVal astrQ() As Decimal, ByVal astrPrice() As Decimal) As String

        'Print buying goods
        Dim strDesc, strPrice As String
        Dim right = 15
        Dim left = nbCharPerLine - right
        For i As Integer = 0 To astrItem.Length - 1
            If IsNothing(astrItem(i)) Then Exit For
            strDesc = getStrProductToPrint(left, astrItem(i), astrUnit(i), astrQ(i))
            strPrice = astrPrice(i).ToString("# ### ###") & "đ"

            txtPrint &= newLine_AlignLeftRight(nbCharPerLine, left, right, strDesc, strPrice)
        Next

        Dim sepa As New String("-"c, nbCharPerLine) 'This line ------
        txtPrint &= sepa
        txtPrint &= Environment.NewLine

        Return txtPrint
    End Function

    Private Shared Function getPageFooter(ByVal txtPrint As String, ByVal nbCharPerLine As Integer,
                                          ByVal initTotal As Double, ByVal discount As Double, ByVal total As Double,
                                          ByVal clientIn As Double, ByVal clientOut As Double) As String

        Dim left = 15
        Dim right = nbCharPerLine - left
        txtPrint &= newLine_AlignLeftRight(nbCharPerLine, left, right, "KM", discount.ToString("# ### ###") & "đ")
        txtPrint &= newLine_AlignLeftRight(nbCharPerLine, left, right, "Tổng", total.ToString("# ### ###") & "đ")
        txtPrint &= newLine_AlignLeftRight(nbCharPerLine, left, right, "Nhận", clientIn.ToString("# ### ###") & "đ")
        txtPrint &= newLine_AlignLeftRight(nbCharPerLine, left, right, "Trả", clientOut.ToString("# ### ###") & "đ")

        txtPrint &= Environment.NewLine
        txtPrint &= newLine_AlignCenter(nbCharPerLine, "Quý khách vui lòng kiểm tra kỹ")
        txtPrint &= newLine_AlignCenter(nbCharPerLine, "Nhà thuốc không nhận hàng trả lại")
        txtPrint &= newLine_AlignCenter(nbCharPerLine, "Xin chân thành cám ơn.")
        Return txtPrint
    End Function


    Private Shared Sub POSPrint_PrintPage(
                                   ByVal printer As System.Drawing.Printing.PrintDocument,
                                   ByVal e As System.Drawing.Printing.PrintPageEventArgs,
                                   ByVal withLogo As Boolean,
                                   ByVal logo As Image,
                                   ByVal logo_width As Integer,
                                   ByVal logo_height As Integer,
                                   ByVal txtToPrint As String,
                                   ByVal txtFont As Font)
        Static currentChar As Integer
        If (IsNothing(txtFont)) Then txtFont = New Font("Courier New", 9, FontStyle.Bold)

        Dim h, w As Integer
        Dim left, top As Integer
        With printer.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With

        If (withLogo) Then
            If (IsNothing(logo)) Then
                logo = Image.FromFile(IO.Directory.GetCurrentDirectory() & "\Resources\Logo.bmp")
            End If

            If (Not IsNothing(logo)) Then
                e.Graphics.DrawImage(logo, left, top, logo_width, logo_height)

                Dim countLine = Math.Round(logo_height / 10)
                For i = 0 To countLine
                    txtToPrint = Environment.NewLine & txtToPrint
                Next

            End If
        End If

        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer

        e.Graphics.MeasureString(Mid(txtToPrint, currentChar + 1), txtFont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(txtToPrint.Substring(currentChar, chars), txtFont, Brushes.Black, b, format)

        currentChar = currentChar + chars
        If currentChar < txtToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub

    Public Shared Sub print_receipt(
                            ByVal printer As System.Drawing.Printing.PrintDocument,
                            ByVal e As System.Drawing.Printing.PrintPageEventArgs,
                            ByVal withLogo As Boolean,
                            ByVal logo As Image,
                            ByVal logo_width As Integer,
                            ByVal logo_height As Integer,
                            ByVal nbCharPerLine As Integer,
                            ByVal txtFont As Font,
                            ByVal numSelling As String, ByVal vendor As String,
                            ByVal astrItem() As String, ByVal astrUnit() As String, ByVal astrQ() As Decimal, ByVal astrPrice() As Decimal, _
                            ByVal initTotal As Double, ByVal discount As Double, ByVal total As Double,
                            ByVal clientIn As Double, ByVal clientOut As Double)

        Dim txtPrint = getPageHeader("", nbCharPerLine, numSelling, vendor)
        txtPrint = getPageContent(txtPrint, nbCharPerLine, astrItem, astrUnit, astrQ, astrPrice)
        txtPrint = getPageFooter(txtPrint, nbCharPerLine, initTotal, discount, total, clientIn, clientOut)

        'Dim txtFont = New Font("Courier New", 9, FontStyle.Bold)
        POSPrint_PrintPage(printer, e, withLogo, logo, logo_width, logo_height, txtPrint, txtFont)

    End Sub

    Private Shared Function newLine_AlignCenter(ByVal nbCharPerLine As Integer, ByVal StringToPrint As String) As String
        Dim LineLen As Integer = StringToPrint.Length
        Dim nb = Math.Max(0, Math.Round((nbCharPerLine - LineLen) / 2))
        Dim spcLen1 As New String(" "c, nb)
        Return spcLen1 & StringToPrint & Environment.NewLine
    End Function

    Private Shared Function newLine_AlignRight(ByVal nbCharPerLine As Integer, ByVal StringToPrint As String) As String
        Dim format = "{0," & nbCharPerLine & "}"
        Return String.Format(format, StringToPrint) & Environment.NewLine

        'Dim LineLen As Integer = StringToPrint.Length
        'Dim nb = Math.Max(0, Math.Round(nbCharPerLine - LineLen))
        'Dim spcLen1 As New String(" "c, nb)
        'Return spcLen1 & StringToPrint & Environment.NewLine
    End Function

    Private Shared Function newLine_AlignLeft(ByVal nbCharPerLine As Integer, ByVal StringToPrint As String) As String
        Dim format = "{0,-" & nbCharPerLine & "}"
        Return String.Format(format, StringToPrint) & Environment.NewLine

        'Dim LineLen As Integer = StringToPrint.Length
        'Return StringToPrint & Environment.NewLine
    End Function

    Private Shared Function newLine_AlignLeftRight(ByVal nbCharPerLine As Integer,
                                                   ByVal size_left As Integer, ByVal size_right As Integer,
                                                   ByVal srtLeft As String, ByVal srtRight As String) As String

        Dim format = "{0,-" & size_left & "}{1," & size_right & "}"
        Return String.Format(format, srtLeft, srtRight) & Environment.NewLine

        'Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Bill", "Gates", 51));

        'Dim LineLenL As Integer = srtLeft.Length
        'Dim LineLenR As Integer = srtRight.Length
        'Dim nb = Math.Max(1, Math.Round(nbCharPerLine - LineLenL - LineLenR))
        'Dim spcLen1 As New String(" "c, nb)
        'Return srtLeft & spcLen1 & srtRight & Environment.NewLine
    End Function



    Private Shared Function getStrProductToPrint(ByVal lim As Int32, ByVal strProd As String, ByVal strUnit As String, ByVal strQ As String) As String

        Dim strValue As String
        Dim tab1 As String = ""
        Dim tab2 As String = ""

        Dim max = lim - 2
        Dim uLen = 5
        Dim qLen = 5
        Dim pLen = max - qLen - uLen

        Dim format = "{0,-" & pLen & "} {1,-" & uLen & "} {2," & qLen & "}"

        If strProd.Length > pLen Then
            strProd = strProd.Substring(0, pLen - 2)
            Try
                Dim lastSpace = strProd.LastIndexOf(" ")
                If (lastSpace > 0) Then
                    strProd = strProd.Substring(0, lastSpace + 1) & strProd.Substring(lastSpace + 1, 1)
                End If
            Catch ex As Exception

            End Try
            strProd = strProd & "."
        End If


        If strUnit.Length > uLen Then
            strUnit = strUnit.Substring(0, uLen - 2) & "."
        End If

        strValue = String.Format(format, strProd, strUnit, strQ)
        Return strValue

    End Function


    '-----------------------------------------------------------------------------------------------------
    Private Shared Sub POSPrint_PrintBarcode(
                                    ByVal printer As System.Drawing.Printing.PrintDocument,
                                    ByVal e As System.Drawing.Printing.PrintPageEventArgs,
                                    ByVal nbCol As Integer,
                                    ByVal rectNum As Integer,
                                    ByVal rectWidth As Integer,
                                    ByVal rectHeight As Integer,
                                    ByVal rectNbLine As Integer,
                                    ByVal line_Content()() As String,
                                    ByVal line_Font()() As Font)

        Dim lineHeight = rectHeight / rectNbLine
        Dim colActu = 0
        For count = 0 To rectNum - 1
            Dim txtPrint = line_Content(count)
            Dim txtFont = line_Font(count)

            Dim leftMarg As Integer = 5
            Dim topMarg As Integer = 5

            For l = 0 To rectNbLine
                Dim font = txtFont(l)
                Dim str = txtPrint(l)
                Dim xpos As Integer = leftMarg + colActu * rectWidth
                Dim ypos As Integer = topMarg + l * lineHeight
                Dim pRect As New Rectangle(xpos, ypos, rectWidth, rectHeight)
                e.Graphics.DrawString(str, font, Brushes.Black, pRect)
            Next

            colActu = colActu + 1
            If (colActu = nbCol) Then colActu = 0
        Next

        e.HasMorePages = False
       
        'Get the Logo and Print It
        'Dim myImage As Image = Image.FromFile("c:\temp\accept_300x300.png")
        'Dim imageRect As New Rectangle(topMargin, leftMargin, myImage.Width, myImage.Height)
        'e.Graphics.DrawImage(myImage, imageRect)
    End Sub

    Public Shared Sub print_BarCode(
                            ByVal printer As System.Drawing.Printing.PrintDocument,
                            ByVal e As System.Drawing.Printing.PrintPageEventArgs,
                            ByVal nbCol As Integer,
                                    ByVal rectNum As Integer,
                                    ByVal rectWidth As Integer,
                                    ByVal rectHeight As Integer,
                                    ByVal rectNbLine As Integer,
                                    ByVal line_Content()() As String,
                                    ByVal line_Font()() As Font
                          )

        'tao list font cho line_content

        'Dim txtFont = New Font("Courier New", 9, FontStyle.Bold)
        POSPrint_PrintBarcode(printer, e, nbCol, rectNum, rectWidth, rectHeight, rectNbLine, line_Content, line_Font)

    End Sub
End Class
