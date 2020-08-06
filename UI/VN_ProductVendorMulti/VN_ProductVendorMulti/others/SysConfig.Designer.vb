<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SysConfig))
        Me.tabUser = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbLang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panDB = New System.Windows.Forms.Panel()
        Me.txtDB_01 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDB_02 = New System.Windows.Forms.TextBox()
        Me.txtDB_03 = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.butSetConnection = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.butInstallPOS = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkMyPrinter = New System.Windows.Forms.CheckBox()
        Me.butResetConfig = New System.Windows.Forms.Button()
        Me.txtCharNbPerLine = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCharFontSize = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkLogoWith = New System.Windows.Forms.CheckBox()
        Me.txtCharFontName = New System.Windows.Forms.TextBox()
        Me.txtLogoPath = New System.Windows.Forms.TextBox()
        Me.txtLogoHeight = New System.Windows.Forms.TextBox()
        Me.txtLogoWidth = New System.Windows.Forms.TextBox()
        Me.butTestPrinter = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.butSetPrinter = New System.Windows.Forms.Button()
        Me.cmbPrinter = New System.Windows.Forms.ComboBox()
        Me.imgListLang = New System.Windows.Forms.ImageList(Me.components)
        Me.POSPrint = New System.Drawing.Printing.PrintDocument()
        Me.tabUser.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.panDB.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabUser
        '
        Me.tabUser.AllowDrop = True
        Me.tabUser.Controls.Add(Me.TabPage1)
        Me.tabUser.Controls.Add(Me.TabPage2)
        resources.ApplyResources(Me.tabUser, "tabUser")
        Me.tabUser.Name = "tabUser"
        Me.tabUser.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.cmbLang)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.panDB)
        Me.GroupBox2.Controls.Add(Me.txtIP)
        Me.GroupBox2.Controls.Add(Me.butSetConnection)
        Me.GroupBox2.Controls.Add(Me.txtPass)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtLogin)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'cmbLang
        '
        Me.cmbLang.FormattingEnabled = True
        resources.ApplyResources(Me.cmbLang, "cmbLang")
        Me.cmbLang.Name = "cmbLang"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'panDB
        '
        Me.panDB.Controls.Add(Me.txtDB_01)
        Me.panDB.Controls.Add(Me.Label7)
        Me.panDB.Controls.Add(Me.txtDB_02)
        Me.panDB.Controls.Add(Me.txtDB_03)
        resources.ApplyResources(Me.panDB, "panDB")
        Me.panDB.Name = "panDB"
        '
        'txtDB_01
        '
        resources.ApplyResources(Me.txtDB_01, "txtDB_01")
        Me.txtDB_01.Name = "txtDB_01"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtDB_02
        '
        resources.ApplyResources(Me.txtDB_02, "txtDB_02")
        Me.txtDB_02.Name = "txtDB_02"
        '
        'txtDB_03
        '
        resources.ApplyResources(Me.txtDB_03, "txtDB_03")
        Me.txtDB_03.Name = "txtDB_03"
        '
        'txtIP
        '
        resources.ApplyResources(Me.txtIP, "txtIP")
        Me.txtIP.Name = "txtIP"
        '
        'butSetConnection
        '
        resources.ApplyResources(Me.butSetConnection, "butSetConnection")
        Me.butSetConnection.Name = "butSetConnection"
        Me.butSetConnection.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        resources.ApplyResources(Me.txtPass, "txtPass")
        Me.txtPass.Name = "txtPass"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtLogin
        '
        resources.ApplyResources(Me.txtLogin, "txtLogin")
        Me.txtLogin.Name = "txtLogin"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel1)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.butInstallPOS)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.chkMyPrinter)
        Me.Panel1.Controls.Add(Me.butResetConfig)
        Me.Panel1.Controls.Add(Me.txtCharNbPerLine)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtCharFontSize)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.chkLogoWith)
        Me.Panel1.Controls.Add(Me.txtCharFontName)
        Me.Panel1.Controls.Add(Me.txtLogoPath)
        Me.Panel1.Controls.Add(Me.txtLogoHeight)
        Me.Panel1.Controls.Add(Me.txtLogoWidth)
        Me.Panel1.Controls.Add(Me.butTestPrinter)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.butSetPrinter)
        Me.Panel1.Controls.Add(Me.cmbPrinter)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'butInstallPOS
        '
        resources.ApplyResources(Me.butInstallPOS, "butInstallPOS")
        Me.butInstallPOS.Name = "butInstallPOS"
        Me.butInstallPOS.UseVisualStyleBackColor = True
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'chkMyPrinter
        '
        resources.ApplyResources(Me.chkMyPrinter, "chkMyPrinter")
        Me.chkMyPrinter.Name = "chkMyPrinter"
        Me.chkMyPrinter.UseVisualStyleBackColor = True
        '
        'butResetConfig
        '
        resources.ApplyResources(Me.butResetConfig, "butResetConfig")
        Me.butResetConfig.Name = "butResetConfig"
        Me.butResetConfig.UseVisualStyleBackColor = True
        '
        'txtCharNbPerLine
        '
        resources.ApplyResources(Me.txtCharNbPerLine, "txtCharNbPerLine")
        Me.txtCharNbPerLine.Name = "txtCharNbPerLine"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'txtCharFontSize
        '
        resources.ApplyResources(Me.txtCharFontSize, "txtCharFontSize")
        Me.txtCharFontSize.Name = "txtCharFontSize"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'chkLogoWith
        '
        resources.ApplyResources(Me.chkLogoWith, "chkLogoWith")
        Me.chkLogoWith.Checked = True
        Me.chkLogoWith.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLogoWith.Name = "chkLogoWith"
        Me.chkLogoWith.UseVisualStyleBackColor = True
        '
        'txtCharFontName
        '
        resources.ApplyResources(Me.txtCharFontName, "txtCharFontName")
        Me.txtCharFontName.Name = "txtCharFontName"
        '
        'txtLogoPath
        '
        resources.ApplyResources(Me.txtLogoPath, "txtLogoPath")
        Me.txtLogoPath.Name = "txtLogoPath"
        '
        'txtLogoHeight
        '
        resources.ApplyResources(Me.txtLogoHeight, "txtLogoHeight")
        Me.txtLogoHeight.Name = "txtLogoHeight"
        '
        'txtLogoWidth
        '
        resources.ApplyResources(Me.txtLogoWidth, "txtLogoWidth")
        Me.txtLogoWidth.Name = "txtLogoWidth"
        '
        'butTestPrinter
        '
        resources.ApplyResources(Me.butTestPrinter, "butTestPrinter")
        Me.butTestPrinter.Name = "butTestPrinter"
        Me.butTestPrinter.UseVisualStyleBackColor = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'butSetPrinter
        '
        resources.ApplyResources(Me.butSetPrinter, "butSetPrinter")
        Me.butSetPrinter.Name = "butSetPrinter"
        Me.butSetPrinter.UseVisualStyleBackColor = True
        '
        'cmbPrinter
        '
        Me.cmbPrinter.FormattingEnabled = True
        resources.ApplyResources(Me.cmbPrinter, "cmbPrinter")
        Me.cmbPrinter.Name = "cmbPrinter"
        '
        'imgListLang
        '
        Me.imgListLang.ImageStream = CType(resources.GetObject("imgListLang.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListLang.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListLang.Images.SetKeyName(0, "Vietnamese.png")
        Me.imgListLang.Images.SetKeyName(1, "French.png")
        Me.imgListLang.Images.SetKeyName(2, "English.png")
        '
        'POSPrint
        '
        '
        'SysConfig
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabUser)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SysConfig"
        Me.TopMost = True
        Me.tabUser.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.panDB.ResumeLayout(False)
        Me.panDB.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents tabUser As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDB_01 As System.Windows.Forms.TextBox
    Friend WithEvents butSetConnection As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDB_02 As System.Windows.Forms.TextBox
    Friend WithEvents txtDB_03 As System.Windows.Forms.TextBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents panDB As System.Windows.Forms.Panel
    Friend WithEvents cmbLang As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents imgListLang As System.Windows.Forms.ImageList
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkMyPrinter As System.Windows.Forms.CheckBox
    Friend WithEvents butResetConfig As System.Windows.Forms.Button
    Friend WithEvents txtCharNbPerLine As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCharFontSize As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkLogoWith As System.Windows.Forms.CheckBox
    Friend WithEvents txtCharFontName As System.Windows.Forms.TextBox
    Friend WithEvents txtLogoPath As System.Windows.Forms.TextBox
    Friend WithEvents txtLogoHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtLogoWidth As System.Windows.Forms.TextBox
    Friend WithEvents butTestPrinter As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents butSetPrinter As System.Windows.Forms.Button
    Friend WithEvents cmbPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents POSPrint As System.Drawing.Printing.PrintDocument
    Friend WithEvents butInstallPOS As System.Windows.Forms.Button
End Class
