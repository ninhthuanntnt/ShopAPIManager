﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellingUI_Container
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellingUI_Container))
        Me.butClientNew = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClientNum = New System.Windows.Forms.TextBox()
        Me.tabControl_Client = New System.Windows.Forms.TabControl()
        Me.butKeyboard_Productname_02 = New System.Windows.Forms.Button()
        Me.butConf = New System.Windows.Forms.Button()
        Me.butAppMinimize = New System.Windows.Forms.Button()
        Me.butAppClose = New System.Windows.Forms.Button()
        Me.butClientChange = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'butClientNew
        '
        Me.butClientNew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butClientNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.butClientNew.ForeColor = System.Drawing.Color.DarkMagenta
        Me.butClientNew.Location = New System.Drawing.Point(241, 9)
        Me.butClientNew.Name = "butClientNew"
        Me.butClientNew.Size = New System.Drawing.Size(350, 40)
        Me.butClientNew.TabIndex = 3
        Me.butClientNew.Text = "Bắt đầu với khách"
        Me.butClientNew.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.butKeyboard_Productname_02)
        Me.GroupBox1.Controls.Add(Me.butConf)
        Me.GroupBox1.Controls.Add(Me.butAppMinimize)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtClientNum)
        Me.GroupBox1.Controls.Add(Me.tabControl_Client)
        Me.GroupBox1.Controls.Add(Me.butAppClose)
        Me.GroupBox1.Controls.Add(Me.butClientChange)
        Me.GroupBox1.Controls.Add(Me.butClientNew)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(917, 600)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(691, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Nhóm khách đang xem :"
        '
        'txtClientNum
        '
        Me.txtClientNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClientNum.Enabled = False
        Me.txtClientNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientNum.ForeColor = System.Drawing.Color.Maroon
        Me.txtClientNum.Location = New System.Drawing.Point(847, 15)
        Me.txtClientNum.Name = "txtClientNum"
        Me.txtClientNum.Size = New System.Drawing.Size(62, 29)
        Me.txtClientNum.TabIndex = 61
        Me.txtClientNum.Text = "0"
        Me.txtClientNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tabControl_Client
        '
        Me.tabControl_Client.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl_Client.ItemSize = New System.Drawing.Size(45, 45)
        Me.tabControl_Client.Location = New System.Drawing.Point(7, 51)
        Me.tabControl_Client.Name = "tabControl_Client"
        Me.tabControl_Client.SelectedIndex = 0
        Me.tabControl_Client.Size = New System.Drawing.Size(910, 543)
        Me.tabControl_Client.TabIndex = 52
        '
        'butKeyboard_Productname_02
        '
        Me.butKeyboard_Productname_02.BackgroundImage = CType(resources.GetObject("butKeyboard_Productname_02.BackgroundImage"), System.Drawing.Image)
        Me.butKeyboard_Productname_02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butKeyboard_Productname_02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butKeyboard_Productname_02.ForeColor = System.Drawing.Color.Maroon
        Me.butKeyboard_Productname_02.Location = New System.Drawing.Point(147, 9)
        Me.butKeyboard_Productname_02.Name = "butKeyboard_Productname_02"
        Me.butKeyboard_Productname_02.Size = New System.Drawing.Size(40, 40)
        Me.butKeyboard_Productname_02.TabIndex = 65
        Me.butKeyboard_Productname_02.UseVisualStyleBackColor = True
        '
        'butConf
        '
        Me.butConf.BackgroundImage = CType(resources.GetObject("butConf.BackgroundImage"), System.Drawing.Image)
        Me.butConf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.butConf.Location = New System.Drawing.Point(102, 9)
        Me.butConf.Name = "butConf"
        Me.butConf.Size = New System.Drawing.Size(40, 40)
        Me.butConf.TabIndex = 64
        Me.butConf.UseVisualStyleBackColor = True
        '
        'butAppMinimize
        '
        Me.butAppMinimize.BackgroundImage = Global.MyApplication.My.Resources.Resources.icon_arrow_down
        Me.butAppMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butAppMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAppMinimize.ForeColor = System.Drawing.Color.Red
        Me.butAppMinimize.Location = New System.Drawing.Point(57, 9)
        Me.butAppMinimize.Name = "butAppMinimize"
        Me.butAppMinimize.Size = New System.Drawing.Size(40, 40)
        Me.butAppMinimize.TabIndex = 63
        Me.butAppMinimize.UseVisualStyleBackColor = True
        '
        'butAppClose
        '
        Me.butAppClose.BackgroundImage = Global.MyApplication.My.Resources.Resources.icon_close_round
        Me.butAppClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butAppClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAppClose.ForeColor = System.Drawing.Color.Red
        Me.butAppClose.Location = New System.Drawing.Point(12, 9)
        Me.butAppClose.Name = "butAppClose"
        Me.butAppClose.Size = New System.Drawing.Size(40, 40)
        Me.butAppClose.TabIndex = 9
        Me.butAppClose.UseVisualStyleBackColor = True
        '
        'butClientChange
        '
        Me.butClientChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butClientChange.BackgroundImage = Global.MyApplication.My.Resources.Resources.icon_play
        Me.butClientChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.butClientChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClientChange.ForeColor = System.Drawing.Color.Blue
        Me.butClientChange.Location = New System.Drawing.Point(645, 9)
        Me.butClientChange.Name = "butClientChange"
        Me.butClientChange.Size = New System.Drawing.Size(40, 40)
        Me.butClientChange.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.butClientChange, "Trỏ đến khách")
        Me.butClientChange.UseVisualStyleBackColor = True
        '
        'SellingUI_Container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(917, 600)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "SellingUI_Container"
        Me.Text = " Bán hàng trên máy nhỏ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butClientNew As System.Windows.Forms.Button

    Friend WithEvents idName As System.Windows.Forms.DataGridViewComboBoxColumn

    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents butAppClose As System.Windows.Forms.Button
    Friend WithEvents butClientChange As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tabControl_Client As System.Windows.Forms.TabControl
    Friend WithEvents txtClientNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents butAppMinimize As System.Windows.Forms.Button
    Friend WithEvents butKeyboard_Productname_02 As System.Windows.Forms.Button
    Friend WithEvents butConf As System.Windows.Forms.Button
End Class