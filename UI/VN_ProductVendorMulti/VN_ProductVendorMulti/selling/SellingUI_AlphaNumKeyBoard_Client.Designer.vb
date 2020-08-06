<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellingUI_AlphaNumKeyBoard_Client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellingUI_AlphaNumKeyBoard_Client))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.but_v = New System.Windows.Forms.Button()
        Me.but_Clear = New System.Windows.Forms.Button()
        Me.but_UpLoCase = New System.Windows.Forms.Button()
        Me.but_Space = New System.Windows.Forms.Button()
        Me.but_Opt02 = New System.Windows.Forms.Button()
        Me.but_Opt03 = New System.Windows.Forms.Button()
        Me.but_Opt01 = New System.Windows.Forms.Button()
        Me.but_y = New System.Windows.Forms.Button()
        Me.but_z = New System.Windows.Forms.Button()
        Me.but_w = New System.Windows.Forms.Button()
        Me.but_u = New System.Windows.Forms.Button()
        Me.but_s = New System.Windows.Forms.Button()
        Me.but_t = New System.Windows.Forms.Button()
        Me.but_r = New System.Windows.Forms.Button()
        Me.but_p = New System.Windows.Forms.Button()
        Me.but_q = New System.Windows.Forms.Button()
        Me.but_o = New System.Windows.Forms.Button()
        Me.but_n = New System.Windows.Forms.Button()
        Me.but_l = New System.Windows.Forms.Button()
        Me.but_m = New System.Windows.Forms.Button()
        Me.but_k = New System.Windows.Forms.Button()
        Me.but_h = New System.Windows.Forms.Button()
        Me.but_i = New System.Windows.Forms.Button()
        Me.but_g = New System.Windows.Forms.Button()
        Me.but_f = New System.Windows.Forms.Button()
        Me.but_d = New System.Windows.Forms.Button()
        Me.but_e = New System.Windows.Forms.Button()
        Me.but_c = New System.Windows.Forms.Button()
        Me.but_a = New System.Windows.Forms.Button()
        Me.but_b = New System.Windows.Forms.Button()
        Me.but_00 = New System.Windows.Forms.Button()
        Me.butClose = New System.Windows.Forms.Button()
        Me.but_OK = New System.Windows.Forms.Button()
        Me.but_x = New System.Windows.Forms.Button()
        Me.but_0 = New System.Windows.Forms.Button()
        Me.but_2 = New System.Windows.Forms.Button()
        Me.but_9 = New System.Windows.Forms.Button()
        Me.but_6 = New System.Windows.Forms.Button()
        Me.but_7 = New System.Windows.Forms.Button()
        Me.but_3 = New System.Windows.Forms.Button()
        Me.but_1 = New System.Windows.Forms.Button()
        Me.but_8 = New System.Windows.Forms.Button()
        Me.but_4 = New System.Windows.Forms.Button()
        Me.but_5 = New System.Windows.Forms.Button()
        Me.lbVal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbClientName = New System.Windows.Forms.ComboBox()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmacyDataSet = New MyApplication.pharmacyDataSet()
        Me.ClientTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.ClientTableAdapter()
        Me.TableAdapterManager = New MyApplication.pharmacyDataSetTableAdapters.TableAdapterManager()
        Me.Fact_UpdateInsertDeleteTableAdapter1 = New MyApplication.factManagementDataSetTableAdapters.Fact_UpdateInsertDeleteTableAdapter()
        Me.FactManagementDB = New MyApplication.factManagementDataSet()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactManagementDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.but_v)
        Me.GroupBox1.Controls.Add(Me.but_Clear)
        Me.GroupBox1.Controls.Add(Me.but_UpLoCase)
        Me.GroupBox1.Controls.Add(Me.but_Space)
        Me.GroupBox1.Controls.Add(Me.but_Opt02)
        Me.GroupBox1.Controls.Add(Me.but_Opt03)
        Me.GroupBox1.Controls.Add(Me.but_Opt01)
        Me.GroupBox1.Controls.Add(Me.but_y)
        Me.GroupBox1.Controls.Add(Me.but_z)
        Me.GroupBox1.Controls.Add(Me.but_w)
        Me.GroupBox1.Controls.Add(Me.but_u)
        Me.GroupBox1.Controls.Add(Me.but_s)
        Me.GroupBox1.Controls.Add(Me.but_t)
        Me.GroupBox1.Controls.Add(Me.but_r)
        Me.GroupBox1.Controls.Add(Me.but_p)
        Me.GroupBox1.Controls.Add(Me.but_q)
        Me.GroupBox1.Controls.Add(Me.but_o)
        Me.GroupBox1.Controls.Add(Me.but_n)
        Me.GroupBox1.Controls.Add(Me.but_l)
        Me.GroupBox1.Controls.Add(Me.but_m)
        Me.GroupBox1.Controls.Add(Me.but_k)
        Me.GroupBox1.Controls.Add(Me.but_h)
        Me.GroupBox1.Controls.Add(Me.but_i)
        Me.GroupBox1.Controls.Add(Me.but_g)
        Me.GroupBox1.Controls.Add(Me.but_f)
        Me.GroupBox1.Controls.Add(Me.but_d)
        Me.GroupBox1.Controls.Add(Me.but_e)
        Me.GroupBox1.Controls.Add(Me.but_c)
        Me.GroupBox1.Controls.Add(Me.but_a)
        Me.GroupBox1.Controls.Add(Me.but_b)
        Me.GroupBox1.Controls.Add(Me.but_00)
        Me.GroupBox1.Controls.Add(Me.butClose)
        Me.GroupBox1.Controls.Add(Me.but_OK)
        Me.GroupBox1.Controls.Add(Me.but_x)
        Me.GroupBox1.Controls.Add(Me.but_0)
        Me.GroupBox1.Controls.Add(Me.but_2)
        Me.GroupBox1.Controls.Add(Me.but_9)
        Me.GroupBox1.Controls.Add(Me.but_6)
        Me.GroupBox1.Controls.Add(Me.but_7)
        Me.GroupBox1.Controls.Add(Me.but_3)
        Me.GroupBox1.Controls.Add(Me.but_1)
        Me.GroupBox1.Controls.Add(Me.but_8)
        Me.GroupBox1.Controls.Add(Me.but_4)
        Me.GroupBox1.Controls.Add(Me.but_5)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(4, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(590, 390)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'but_v
        '
        Me.but_v.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_v.ForeColor = System.Drawing.Color.DarkRed
        Me.but_v.Location = New System.Drawing.Point(506, 120)
        Me.but_v.Name = "but_v"
        Me.but_v.Size = New System.Drawing.Size(70, 45)
        Me.but_v.TabIndex = 84
        Me.but_v.Text = "v"
        Me.but_v.UseVisualStyleBackColor = True
        '
        'but_Clear
        '
        Me.but_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_Clear.ForeColor = System.Drawing.Color.Red
        Me.but_Clear.Location = New System.Drawing.Point(342, 325)
        Me.but_Clear.Name = "but_Clear"
        Me.but_Clear.Size = New System.Drawing.Size(70, 49)
        Me.but_Clear.TabIndex = 83
        Me.but_Clear.Text = "Xóa"
        Me.but_Clear.UseVisualStyleBackColor = True
        '
        'but_UpLoCase
        '
        Me.but_UpLoCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_UpLoCase.ForeColor = System.Drawing.Color.Navy
        Me.but_UpLoCase.Location = New System.Drawing.Point(10, 324)
        Me.but_UpLoCase.Name = "but_UpLoCase"
        Me.but_UpLoCase.Size = New System.Drawing.Size(152, 50)
        Me.but_UpLoCase.TabIndex = 82
        Me.but_UpLoCase.Text = "V.Hoa/Thường"
        Me.but_UpLoCase.UseVisualStyleBackColor = True
        '
        'but_Space
        '
        Me.but_Space.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_Space.ForeColor = System.Drawing.Color.DimGray
        Me.but_Space.Location = New System.Drawing.Point(426, 171)
        Me.but_Space.Name = "but_Space"
        Me.but_Space.Size = New System.Drawing.Size(150, 45)
        Me.but_Space.TabIndex = 81
        Me.but_Space.Text = " Ký tự trống"
        Me.but_Space.UseVisualStyleBackColor = True
        '
        'but_Opt02
        '
        Me.but_Opt02.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_Opt02.ForeColor = System.Drawing.Color.DarkRed
        Me.but_Opt02.Location = New System.Drawing.Point(426, 274)
        Me.but_Opt02.Name = "but_Opt02"
        Me.but_Opt02.Size = New System.Drawing.Size(70, 45)
        Me.but_Opt02.TabIndex = 79
        Me.but_Opt02.Text = "/"
        Me.but_Opt02.UseVisualStyleBackColor = True
        '
        'but_Opt03
        '
        Me.but_Opt03.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_Opt03.ForeColor = System.Drawing.Color.DarkRed
        Me.but_Opt03.Location = New System.Drawing.Point(506, 274)
        Me.but_Opt03.Name = "but_Opt03"
        Me.but_Opt03.Size = New System.Drawing.Size(70, 45)
        Me.but_Opt03.TabIndex = 80
        Me.but_Opt03.Text = ","
        Me.but_Opt03.UseVisualStyleBackColor = True
        '
        'but_Opt01
        '
        Me.but_Opt01.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_Opt01.ForeColor = System.Drawing.Color.DarkRed
        Me.but_Opt01.Location = New System.Drawing.Point(342, 274)
        Me.but_Opt01.Name = "but_Opt01"
        Me.but_Opt01.Size = New System.Drawing.Size(70, 45)
        Me.but_Opt01.TabIndex = 78
        Me.but_Opt01.Text = "-"
        Me.but_Opt01.UseVisualStyleBackColor = True
        '
        'but_y
        '
        Me.but_y.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_y.ForeColor = System.Drawing.Color.DarkRed
        Me.but_y.Location = New System.Drawing.Point(94, 171)
        Me.but_y.Name = "but_y"
        Me.but_y.Size = New System.Drawing.Size(70, 45)
        Me.but_y.TabIndex = 76
        Me.but_y.Text = "y"
        Me.but_y.UseVisualStyleBackColor = True
        '
        'but_z
        '
        Me.but_z.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_z.ForeColor = System.Drawing.Color.DarkRed
        Me.but_z.Location = New System.Drawing.Point(176, 171)
        Me.but_z.Name = "but_z"
        Me.but_z.Size = New System.Drawing.Size(70, 45)
        Me.but_z.TabIndex = 77
        Me.but_z.Text = "z"
        Me.but_z.UseVisualStyleBackColor = True
        '
        'but_w
        '
        Me.but_w.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_w.ForeColor = System.Drawing.Color.DarkRed
        Me.but_w.Location = New System.Drawing.Point(10, 171)
        Me.but_w.Name = "but_w"
        Me.but_w.Size = New System.Drawing.Size(70, 45)
        Me.but_w.TabIndex = 75
        Me.but_w.Text = "w"
        Me.but_w.UseVisualStyleBackColor = True
        '
        'but_u
        '
        Me.but_u.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_u.ForeColor = System.Drawing.Color.DarkRed
        Me.but_u.Location = New System.Drawing.Point(426, 120)
        Me.but_u.Name = "but_u"
        Me.but_u.Size = New System.Drawing.Size(70, 45)
        Me.but_u.TabIndex = 74
        Me.but_u.Text = "u"
        Me.but_u.UseVisualStyleBackColor = True
        '
        'but_s
        '
        Me.but_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_s.ForeColor = System.Drawing.Color.DarkRed
        Me.but_s.Location = New System.Drawing.Point(260, 120)
        Me.but_s.Name = "but_s"
        Me.but_s.Size = New System.Drawing.Size(70, 45)
        Me.but_s.TabIndex = 72
        Me.but_s.Text = "s"
        Me.but_s.UseVisualStyleBackColor = True
        '
        'but_t
        '
        Me.but_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_t.ForeColor = System.Drawing.Color.DarkRed
        Me.but_t.Location = New System.Drawing.Point(342, 120)
        Me.but_t.Name = "but_t"
        Me.but_t.Size = New System.Drawing.Size(70, 45)
        Me.but_t.TabIndex = 73
        Me.but_t.Text = "t"
        Me.but_t.UseVisualStyleBackColor = True
        '
        'but_r
        '
        Me.but_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_r.ForeColor = System.Drawing.Color.DarkRed
        Me.but_r.Location = New System.Drawing.Point(176, 120)
        Me.but_r.Name = "but_r"
        Me.but_r.Size = New System.Drawing.Size(70, 45)
        Me.but_r.TabIndex = 71
        Me.but_r.Text = "r"
        Me.but_r.UseVisualStyleBackColor = True
        '
        'but_p
        '
        Me.but_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_p.ForeColor = System.Drawing.Color.DarkRed
        Me.but_p.Location = New System.Drawing.Point(10, 120)
        Me.but_p.Name = "but_p"
        Me.but_p.Size = New System.Drawing.Size(70, 45)
        Me.but_p.TabIndex = 69
        Me.but_p.Text = "p"
        Me.but_p.UseVisualStyleBackColor = True
        '
        'but_q
        '
        Me.but_q.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_q.ForeColor = System.Drawing.Color.DarkRed
        Me.but_q.Location = New System.Drawing.Point(92, 120)
        Me.but_q.Name = "but_q"
        Me.but_q.Size = New System.Drawing.Size(70, 45)
        Me.but_q.TabIndex = 70
        Me.but_q.Text = "q"
        Me.but_q.UseVisualStyleBackColor = True
        '
        'but_o
        '
        Me.but_o.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_o.ForeColor = System.Drawing.Color.DarkRed
        Me.but_o.Location = New System.Drawing.Point(506, 69)
        Me.but_o.Name = "but_o"
        Me.but_o.Size = New System.Drawing.Size(70, 45)
        Me.but_o.TabIndex = 68
        Me.but_o.Text = "o"
        Me.but_o.UseVisualStyleBackColor = True
        '
        'but_n
        '
        Me.but_n.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_n.ForeColor = System.Drawing.Color.DarkRed
        Me.but_n.Location = New System.Drawing.Point(426, 69)
        Me.but_n.Name = "but_n"
        Me.but_n.Size = New System.Drawing.Size(70, 45)
        Me.but_n.TabIndex = 67
        Me.but_n.Text = "n"
        Me.but_n.UseVisualStyleBackColor = True
        '
        'but_l
        '
        Me.but_l.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_l.ForeColor = System.Drawing.Color.DarkRed
        Me.but_l.Location = New System.Drawing.Point(260, 69)
        Me.but_l.Name = "but_l"
        Me.but_l.Size = New System.Drawing.Size(70, 45)
        Me.but_l.TabIndex = 65
        Me.but_l.Text = "l"
        Me.but_l.UseVisualStyleBackColor = True
        '
        'but_m
        '
        Me.but_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_m.ForeColor = System.Drawing.Color.DarkRed
        Me.but_m.Location = New System.Drawing.Point(342, 69)
        Me.but_m.Name = "but_m"
        Me.but_m.Size = New System.Drawing.Size(70, 45)
        Me.but_m.TabIndex = 66
        Me.but_m.Text = "m"
        Me.but_m.UseVisualStyleBackColor = True
        '
        'but_k
        '
        Me.but_k.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_k.ForeColor = System.Drawing.Color.DarkRed
        Me.but_k.Location = New System.Drawing.Point(176, 69)
        Me.but_k.Name = "but_k"
        Me.but_k.Size = New System.Drawing.Size(70, 45)
        Me.but_k.TabIndex = 64
        Me.but_k.Text = "k"
        Me.but_k.UseVisualStyleBackColor = True
        '
        'but_h
        '
        Me.but_h.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_h.ForeColor = System.Drawing.Color.DarkRed
        Me.but_h.Location = New System.Drawing.Point(10, 69)
        Me.but_h.Name = "but_h"
        Me.but_h.Size = New System.Drawing.Size(70, 45)
        Me.but_h.TabIndex = 62
        Me.but_h.Text = "h"
        Me.but_h.UseVisualStyleBackColor = True
        '
        'but_i
        '
        Me.but_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_i.ForeColor = System.Drawing.Color.DarkRed
        Me.but_i.Location = New System.Drawing.Point(92, 69)
        Me.but_i.Name = "but_i"
        Me.but_i.Size = New System.Drawing.Size(70, 45)
        Me.but_i.TabIndex = 63
        Me.but_i.Text = "i"
        Me.but_i.UseVisualStyleBackColor = True
        '
        'but_g
        '
        Me.but_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_g.ForeColor = System.Drawing.Color.DarkRed
        Me.but_g.Location = New System.Drawing.Point(506, 18)
        Me.but_g.Name = "but_g"
        Me.but_g.Size = New System.Drawing.Size(70, 45)
        Me.but_g.TabIndex = 61
        Me.but_g.Text = "g"
        Me.but_g.UseVisualStyleBackColor = True
        '
        'but_f
        '
        Me.but_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_f.ForeColor = System.Drawing.Color.DarkRed
        Me.but_f.Location = New System.Drawing.Point(426, 18)
        Me.but_f.Name = "but_f"
        Me.but_f.Size = New System.Drawing.Size(70, 45)
        Me.but_f.TabIndex = 60
        Me.but_f.Text = "f"
        Me.but_f.UseVisualStyleBackColor = True
        '
        'but_d
        '
        Me.but_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_d.ForeColor = System.Drawing.Color.DarkRed
        Me.but_d.Location = New System.Drawing.Point(260, 18)
        Me.but_d.Name = "but_d"
        Me.but_d.Size = New System.Drawing.Size(70, 45)
        Me.but_d.TabIndex = 58
        Me.but_d.Text = "d"
        Me.but_d.UseVisualStyleBackColor = True
        '
        'but_e
        '
        Me.but_e.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_e.ForeColor = System.Drawing.Color.DarkRed
        Me.but_e.Location = New System.Drawing.Point(342, 18)
        Me.but_e.Name = "but_e"
        Me.but_e.Size = New System.Drawing.Size(70, 45)
        Me.but_e.TabIndex = 59
        Me.but_e.Text = "e"
        Me.but_e.UseVisualStyleBackColor = True
        '
        'but_c
        '
        Me.but_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_c.ForeColor = System.Drawing.Color.DarkRed
        Me.but_c.Location = New System.Drawing.Point(176, 18)
        Me.but_c.Name = "but_c"
        Me.but_c.Size = New System.Drawing.Size(70, 45)
        Me.but_c.TabIndex = 57
        Me.but_c.Text = "c"
        Me.but_c.UseVisualStyleBackColor = True
        '
        'but_a
        '
        Me.but_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_a.ForeColor = System.Drawing.Color.DarkRed
        Me.but_a.Location = New System.Drawing.Point(10, 18)
        Me.but_a.Name = "but_a"
        Me.but_a.Size = New System.Drawing.Size(70, 45)
        Me.but_a.TabIndex = 55
        Me.but_a.Text = "a"
        Me.but_a.UseVisualStyleBackColor = True
        '
        'but_b
        '
        Me.but_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_b.ForeColor = System.Drawing.Color.DarkRed
        Me.but_b.Location = New System.Drawing.Point(92, 18)
        Me.but_b.Name = "but_b"
        Me.but_b.Size = New System.Drawing.Size(70, 45)
        Me.but_b.TabIndex = 56
        Me.but_b.Text = "b"
        Me.but_b.UseVisualStyleBackColor = True
        '
        'but_00
        '
        Me.but_00.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_00.ForeColor = System.Drawing.Color.Purple
        Me.but_00.Location = New System.Drawing.Point(260, 273)
        Me.but_00.Name = "but_00"
        Me.but_00.Size = New System.Drawing.Size(70, 45)
        Me.but_00.TabIndex = 53
        Me.but_00.Text = "."
        Me.but_00.UseVisualStyleBackColor = True
        '
        'butClose
        '
        Me.butClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.butClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butClose.Location = New System.Drawing.Point(176, 325)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(154, 49)
        Me.butClose.TabIndex = 52
        Me.butClose.Text = "Xóa hết"
        Me.butClose.UseVisualStyleBackColor = True
        '
        'but_OK
        '
        Me.but_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_OK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.but_OK.Location = New System.Drawing.Point(426, 324)
        Me.but_OK.Name = "but_OK"
        Me.but_OK.Size = New System.Drawing.Size(150, 50)
        Me.but_OK.TabIndex = 51
        Me.but_OK.Text = "OK"
        Me.but_OK.UseVisualStyleBackColor = True
        '
        'but_x
        '
        Me.but_x.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_x.ForeColor = System.Drawing.Color.Maroon
        Me.but_x.Location = New System.Drawing.Point(260, 171)
        Me.but_x.Name = "but_x"
        Me.but_x.Size = New System.Drawing.Size(70, 45)
        Me.but_x.TabIndex = 50
        Me.but_x.Text = "x"
        Me.but_x.UseVisualStyleBackColor = True
        '
        'but_0
        '
        Me.but_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_0.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.but_0.Location = New System.Drawing.Point(10, 222)
        Me.but_0.Name = "but_0"
        Me.but_0.Size = New System.Drawing.Size(70, 45)
        Me.but_0.TabIndex = 49
        Me.but_0.Text = "0"
        Me.but_0.UseVisualStyleBackColor = True
        '
        'but_2
        '
        Me.but_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.but_2.Location = New System.Drawing.Point(176, 222)
        Me.but_2.Name = "but_2"
        Me.but_2.Size = New System.Drawing.Size(70, 45)
        Me.but_2.TabIndex = 48
        Me.but_2.Text = "2"
        Me.but_2.UseVisualStyleBackColor = True
        '
        'but_9
        '
        Me.but_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_9.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.but_9.Location = New System.Drawing.Point(176, 273)
        Me.but_9.Name = "but_9"
        Me.but_9.Size = New System.Drawing.Size(70, 45)
        Me.but_9.TabIndex = 47
        Me.but_9.Text = "9"
        Me.but_9.UseVisualStyleBackColor = True
        '
        'but_6
        '
        Me.but_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_6.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.but_6.Location = New System.Drawing.Point(506, 222)
        Me.but_6.Name = "but_6"
        Me.but_6.Size = New System.Drawing.Size(70, 45)
        Me.but_6.TabIndex = 46
        Me.but_6.Text = "6"
        Me.but_6.UseVisualStyleBackColor = True
        '
        'but_7
        '
        Me.but_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_7.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.but_7.Location = New System.Drawing.Point(10, 273)
        Me.but_7.Name = "but_7"
        Me.but_7.Size = New System.Drawing.Size(70, 45)
        Me.but_7.TabIndex = 37
        Me.but_7.Text = "7"
        Me.but_7.UseVisualStyleBackColor = True
        '
        'but_3
        '
        Me.but_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.but_3.Location = New System.Drawing.Point(260, 222)
        Me.but_3.Name = "but_3"
        Me.but_3.Size = New System.Drawing.Size(70, 45)
        Me.but_3.TabIndex = 45
        Me.but_3.Text = "3"
        Me.but_3.UseVisualStyleBackColor = True
        '
        'but_1
        '
        Me.but_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.but_1.Location = New System.Drawing.Point(92, 222)
        Me.but_1.Name = "but_1"
        Me.but_1.Size = New System.Drawing.Size(70, 45)
        Me.but_1.TabIndex = 38
        Me.but_1.Text = "1"
        Me.but_1.UseVisualStyleBackColor = True
        '
        'but_8
        '
        Me.but_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_8.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.but_8.Location = New System.Drawing.Point(92, 273)
        Me.but_8.Name = "but_8"
        Me.but_8.Size = New System.Drawing.Size(70, 45)
        Me.but_8.TabIndex = 44
        Me.but_8.Text = "8"
        Me.but_8.UseVisualStyleBackColor = True
        '
        'but_4
        '
        Me.but_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_4.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.but_4.Location = New System.Drawing.Point(342, 222)
        Me.but_4.Name = "but_4"
        Me.but_4.Size = New System.Drawing.Size(70, 45)
        Me.but_4.TabIndex = 42
        Me.but_4.Text = "4"
        Me.but_4.UseVisualStyleBackColor = True
        '
        'but_5
        '
        Me.but_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.but_5.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.but_5.Location = New System.Drawing.Point(426, 222)
        Me.but_5.Name = "but_5"
        Me.but_5.Size = New System.Drawing.Size(70, 45)
        Me.but_5.TabIndex = 43
        Me.but_5.Text = "5"
        Me.but_5.UseVisualStyleBackColor = True
        '
        'lbVal
        '
        Me.lbVal.AutoSize = True
        Me.lbVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbVal.ForeColor = System.Drawing.Color.Blue
        Me.lbVal.Location = New System.Drawing.Point(504, 14)
        Me.lbVal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbVal.Name = "lbVal"
        Me.lbVal.Size = New System.Drawing.Size(48, 25)
        Me.lbVal.TabIndex = 43
        Me.lbVal.Text = " ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(598, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 426)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'cmbClientName
        '
        Me.cmbClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClientName.DataSource = Me.ClientBindingSource
        Me.cmbClientName.DisplayMember = "clientName"
        Me.cmbClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClientName.FormattingEnabled = True
        Me.cmbClientName.ItemHeight = 20
        Me.cmbClientName.Location = New System.Drawing.Point(6, 11)
        Me.cmbClientName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbClientName.MaxDropDownItems = 4
        Me.cmbClientName.Name = "cmbClientName"
        Me.cmbClientName.Size = New System.Drawing.Size(496, 28)
        Me.cmbClientName.TabIndex = 45
        Me.cmbClientName.ValueMember = "id"
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "Client"
        Me.ClientBindingSource.DataSource = Me.PharmacyDataSet
        '
        'PharmacyDataSet
        '
        Me.PharmacyDataSet.DataSetName = "pharmacyDataSet"
        Me.PharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CIPTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Me.ClientTableAdapter
        Me.TableAdapterManager.CSeTableAdapter = Nothing
        Me.TableAdapterManager.CSTableAdapter = Nothing
        Me.TableAdapterManager.DocteurTableAdapter = Nothing
        Me.TableAdapterManager.InputPriceTableAdapter = Nothing
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.PrescriptionContentTableAdapter = Nothing
        Me.TableAdapterManager.PrescriptionTableAdapter = Nothing
        Me.TableAdapterManager.ProductInfoTableAdapter = Nothing
        Me.TableAdapterManager.ProductUnitTableAdapter = Nothing
        Me.TableAdapterManager.RS_Docteur_CSeTableAdapter = Nothing
        Me.TableAdapterManager.RS_Prescription_CSeTableAdapter = Nothing
        Me.TableAdapterManager.RS_Seller_CSeTableAdapter = Nothing
        Me.TableAdapterManager.RS_Stock_SellingTableAdapter = Nothing
        Me.TableAdapterManager.SellingPriceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyApplication.pharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WaitToUpdateRQTableAdapter = Nothing
        '
        'Fact_UpdateInsertDeleteTableAdapter1
        '
        Me.Fact_UpdateInsertDeleteTableAdapter1.ClearBeforeFill = True
        '
        'FactManagementDB
        '
        Me.FactManagementDB.DataSetName = "factManagementDB"
        Me.FactManagementDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlphabetKeyBoard
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 446)
        Me.Controls.Add(Me.cmbClientName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbVal)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AlphabetKeyBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Khách hàng"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactManagementDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents but_OK As System.Windows.Forms.Button
    Friend WithEvents but_x As System.Windows.Forms.Button
    Friend WithEvents but_0 As System.Windows.Forms.Button
    Friend WithEvents but_9 As System.Windows.Forms.Button
    Friend WithEvents but_7 As System.Windows.Forms.Button
    Friend WithEvents but_8 As System.Windows.Forms.Button
    Friend WithEvents but_00 As System.Windows.Forms.Button
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents lbVal As System.Windows.Forms.Label
    Friend WithEvents but_UpLoCase As System.Windows.Forms.Button
    Friend WithEvents but_Space As System.Windows.Forms.Button
    Friend WithEvents but_Opt02 As System.Windows.Forms.Button
    Friend WithEvents but_Opt03 As System.Windows.Forms.Button
    Friend WithEvents but_Opt01 As System.Windows.Forms.Button
    Friend WithEvents but_y As System.Windows.Forms.Button
    Friend WithEvents but_z As System.Windows.Forms.Button
    Friend WithEvents but_w As System.Windows.Forms.Button
    Friend WithEvents but_u As System.Windows.Forms.Button
    Friend WithEvents but_s As System.Windows.Forms.Button
    Friend WithEvents but_t As System.Windows.Forms.Button
    Friend WithEvents but_r As System.Windows.Forms.Button
    Friend WithEvents but_p As System.Windows.Forms.Button
    Friend WithEvents but_q As System.Windows.Forms.Button
    Friend WithEvents but_o As System.Windows.Forms.Button
    Friend WithEvents but_n As System.Windows.Forms.Button
    Friend WithEvents but_l As System.Windows.Forms.Button
    Friend WithEvents but_m As System.Windows.Forms.Button
    Friend WithEvents but_k As System.Windows.Forms.Button
    Friend WithEvents but_h As System.Windows.Forms.Button
    Friend WithEvents but_i As System.Windows.Forms.Button
    Friend WithEvents but_g As System.Windows.Forms.Button
    Friend WithEvents but_f As System.Windows.Forms.Button
    Friend WithEvents but_d As System.Windows.Forms.Button
    Friend WithEvents but_e As System.Windows.Forms.Button
    Friend WithEvents but_c As System.Windows.Forms.Button
    Friend WithEvents but_a As System.Windows.Forms.Button
    Friend WithEvents but_b As System.Windows.Forms.Button
    Friend WithEvents but_2 As System.Windows.Forms.Button
    Friend WithEvents but_6 As System.Windows.Forms.Button
    Friend WithEvents but_3 As System.Windows.Forms.Button
    Friend WithEvents but_1 As System.Windows.Forms.Button
    Friend WithEvents but_4 As System.Windows.Forms.Button
    Friend WithEvents but_5 As System.Windows.Forms.Button
    Friend WithEvents but_Clear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbClientName As System.Windows.Forms.ComboBox
    Friend WithEvents PharmacyDataSet As MyApplication.pharmacyDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As MyApplication.pharmacyDataSetTableAdapters.ClientTableAdapter
    Friend WithEvents TableAdapterManager As MyApplication.pharmacyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Fact_UpdateInsertDeleteTableAdapter1 As MyApplication.factManagementDataSetTableAdapters.Fact_UpdateInsertDeleteTableAdapter
    Friend WithEvents FactManagementDB As MyApplication.factManagementDataSet
    Friend WithEvents but_v As System.Windows.Forms.Button
End Class
