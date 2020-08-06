<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellingUI_GroupProduct
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellingUI_GroupProduct))
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pharmacyDataSet = New MyApplication.pharmacyDataSet()
        Me.ProductInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceForSellingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductInfoTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.ProductInfoTableAdapter()
        Me.ProductNameTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.ProductNameTableAdapter()
        Me.ProductUnitTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.ProductUnitTableAdapter()
        Me.LocationTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.LocationTableAdapter()
        Me.TableAdapterManager = New MyApplication.pharmacyDataSetTableAdapters.TableAdapterManager()
        Me.InputPriceTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.InputPriceTableAdapter()
        Me.CipTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.CIPTableAdapter()
        Me.CSeTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.CSeTableAdapter()
        Me.CSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.CSTableAdapter()
        Me.PriceForSellingTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.PriceForSellingTableAdapter()
        Me.SellingPriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SellingPriceTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.SellingPriceTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButGroup_TC = New System.Windows.Forms.Button()
        Me.ButGroup_00 = New System.Windows.Forms.Button()
        Me.ButGroup_09 = New System.Windows.Forms.Button()
        Me.ButGroup_02 = New System.Windows.Forms.Button()
        Me.ButGroup_03 = New System.Windows.Forms.Button()
        Me.ButGroup_04 = New System.Windows.Forms.Button()
        Me.ButGroup_05 = New System.Windows.Forms.Button()
        Me.ButGroup_06 = New System.Windows.Forms.Button()
        Me.ButGroup_07 = New System.Windows.Forms.Button()
        Me.ButGroup_08 = New System.Windows.Forms.Button()
        Me.ButGroup_01 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAmount = New System.Windows.Forms.ComboBox()
        Me.PrescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbDetailVisible = New System.Windows.Forms.ComboBox()
        Me.cmbComment = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPrescription = New System.Windows.Forms.ComboBox()
        Me.PresciptionContentDataGridView = New System.Windows.Forms.DataGridView()
        Me.colPrescriptionIdProd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colPrescriptionQuant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrescriptionIdUnit = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductUnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPrescriptionPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrescriptionComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrescriptionIdPrescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProdBarCoding = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PrescriptionContentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrescriptionContentTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.PrescriptionContentTableAdapter()
        Me.butAddAllToSelling = New System.Windows.Forms.Button()
        Me.OneSPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OneSPTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.OneSPTableAdapter()
        Me.PrescriptionTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.PrescriptionTableAdapter()
        Me.butClose = New System.Windows.Forms.Button()
        Me.butDel = New System.Windows.Forms.Button()
        Me.butModif = New System.Windows.Forms.Button()
        Me.but_Ratio = New System.Windows.Forms.Button()
        Me.txtRatio = New System.Windows.Forms.TextBox()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pharmacyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceForSellingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellingPriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PrescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresciptionContentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductUnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrescriptionContentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OneSPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "Location"
        Me.LocationBindingSource.DataSource = Me.pharmacyDataSet
        '
        'pharmacyDataSet
        '
        Me.pharmacyDataSet.DataSetName = "pharmacyDataSet"
        Me.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductInfoBindingSource
        '
        Me.ProductInfoBindingSource.DataMember = "ProductInfo"
        Me.ProductInfoBindingSource.DataSource = Me.pharmacyDataSet
        '
        'PriceForSellingBindingSource
        '
        Me.PriceForSellingBindingSource.DataMember = "PriceForSelling"
        Me.PriceForSellingBindingSource.DataSource = Me.pharmacyDataSet
        '
        'ProductNameBindingSource
        '
        Me.ProductNameBindingSource.DataMember = "ProductName"
        Me.ProductNameBindingSource.DataSource = Me.pharmacyDataSet
        '
        'ProductInfoTableAdapter
        '
        Me.ProductInfoTableAdapter.ClearBeforeFill = True
        '
        'ProductNameTableAdapter
        '
        Me.ProductNameTableAdapter.ClearBeforeFill = True
        '
        'ProductUnitTableAdapter
        '
        Me.ProductUnitTableAdapter.ClearBeforeFill = True
        '
        'LocationTableAdapter
        '
        Me.LocationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CIPTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'InputPriceTableAdapter
        '
        Me.InputPriceTableAdapter.ClearBeforeFill = True
        '
        'CipTableAdapter
        '
        Me.CipTableAdapter.ClearBeforeFill = True
        '
        'CSeTableAdapter
        '
        Me.CSeTableAdapter.ClearBeforeFill = True
        '
        'CSBindingSource
        '
        Me.CSBindingSource.DataMember = "CS"
        Me.CSBindingSource.DataSource = Me.pharmacyDataSet
        '
        'CSTableAdapter
        '
        Me.CSTableAdapter.ClearBeforeFill = True
        '
        'PriceForSellingTableAdapter
        '
        Me.PriceForSellingTableAdapter.ClearBeforeFill = True
        '
        'SellingPriceBindingSource
        '
        Me.SellingPriceBindingSource.DataMember = "SellingPrice"
        Me.SellingPriceBindingSource.DataSource = Me.pharmacyDataSet
        '
        'SellingPriceTableAdapter
        '
        Me.SellingPriceTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ButGroup_TC)
        Me.GroupBox2.Controls.Add(Me.ButGroup_00)
        Me.GroupBox2.Controls.Add(Me.ButGroup_09)
        Me.GroupBox2.Controls.Add(Me.ButGroup_02)
        Me.GroupBox2.Controls.Add(Me.ButGroup_03)
        Me.GroupBox2.Controls.Add(Me.ButGroup_04)
        Me.GroupBox2.Controls.Add(Me.ButGroup_05)
        Me.GroupBox2.Controls.Add(Me.ButGroup_06)
        Me.GroupBox2.Controls.Add(Me.ButGroup_07)
        Me.GroupBox2.Controls.Add(Me.ButGroup_08)
        Me.GroupBox2.Controls.Add(Me.ButGroup_01)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbAmount)
        Me.GroupBox2.Controls.Add(Me.cmbDetailVisible)
        Me.GroupBox2.Controls.Add(Me.cmbComment)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbPrescription)
        Me.GroupBox2.Controls.Add(Me.PresciptionContentDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(612, 453)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'ButGroup_TC
        '
        Me.ButGroup_TC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_TC.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_TC.Location = New System.Drawing.Point(558, 15)
        Me.ButGroup_TC.Name = "ButGroup_TC"
        Me.ButGroup_TC.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_TC.TabIndex = 61
        Me.ButGroup_TC.Text = "T"
        Me.ButGroup_TC.UseVisualStyleBackColor = True
        '
        'ButGroup_00
        '
        Me.ButGroup_00.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_00.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_00.Location = New System.Drawing.Point(78, 15)
        Me.ButGroup_00.Name = "ButGroup_00"
        Me.ButGroup_00.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_00.TabIndex = 60
        Me.ButGroup_00.Text = "0"
        Me.ButGroup_00.UseVisualStyleBackColor = True
        '
        'ButGroup_09
        '
        Me.ButGroup_09.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_09.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_09.Location = New System.Drawing.Point(510, 15)
        Me.ButGroup_09.Name = "ButGroup_09"
        Me.ButGroup_09.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_09.TabIndex = 59
        Me.ButGroup_09.Text = "9"
        Me.ButGroup_09.UseVisualStyleBackColor = True
        '
        'ButGroup_02
        '
        Me.ButGroup_02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_02.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_02.Location = New System.Drawing.Point(174, 15)
        Me.ButGroup_02.Name = "ButGroup_02"
        Me.ButGroup_02.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_02.TabIndex = 58
        Me.ButGroup_02.Text = "2"
        Me.ButGroup_02.UseVisualStyleBackColor = True
        '
        'ButGroup_03
        '
        Me.ButGroup_03.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_03.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_03.Location = New System.Drawing.Point(222, 15)
        Me.ButGroup_03.Name = "ButGroup_03"
        Me.ButGroup_03.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_03.TabIndex = 57
        Me.ButGroup_03.Text = "3"
        Me.ButGroup_03.UseVisualStyleBackColor = True
        '
        'ButGroup_04
        '
        Me.ButGroup_04.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_04.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_04.Location = New System.Drawing.Point(270, 15)
        Me.ButGroup_04.Name = "ButGroup_04"
        Me.ButGroup_04.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_04.TabIndex = 56
        Me.ButGroup_04.Text = "4"
        Me.ButGroup_04.UseVisualStyleBackColor = True
        '
        'ButGroup_05
        '
        Me.ButGroup_05.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_05.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_05.Location = New System.Drawing.Point(318, 15)
        Me.ButGroup_05.Name = "ButGroup_05"
        Me.ButGroup_05.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_05.TabIndex = 55
        Me.ButGroup_05.Text = "5"
        Me.ButGroup_05.UseVisualStyleBackColor = True
        '
        'ButGroup_06
        '
        Me.ButGroup_06.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_06.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_06.Location = New System.Drawing.Point(366, 15)
        Me.ButGroup_06.Name = "ButGroup_06"
        Me.ButGroup_06.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_06.TabIndex = 54
        Me.ButGroup_06.Text = "6"
        Me.ButGroup_06.UseVisualStyleBackColor = True
        '
        'ButGroup_07
        '
        Me.ButGroup_07.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_07.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_07.Location = New System.Drawing.Point(414, 16)
        Me.ButGroup_07.Name = "ButGroup_07"
        Me.ButGroup_07.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_07.TabIndex = 53
        Me.ButGroup_07.Text = "7"
        Me.ButGroup_07.UseVisualStyleBackColor = True
        '
        'ButGroup_08
        '
        Me.ButGroup_08.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_08.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_08.Location = New System.Drawing.Point(462, 15)
        Me.ButGroup_08.Name = "ButGroup_08"
        Me.ButGroup_08.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_08.TabIndex = 52
        Me.ButGroup_08.Text = "8"
        Me.ButGroup_08.UseVisualStyleBackColor = True
        '
        'ButGroup_01
        '
        Me.ButGroup_01.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGroup_01.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButGroup_01.Location = New System.Drawing.Point(126, 15)
        Me.ButGroup_01.Name = "ButGroup_01"
        Me.ButGroup_01.Size = New System.Drawing.Size(40, 40)
        Me.ButGroup_01.TabIndex = 51
        Me.ButGroup_01.Text = "1"
        Me.ButGroup_01.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nhóm"
        '
        'cmbAmount
        '
        Me.cmbAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAmount.DataSource = Me.PrescriptionBindingSource
        Me.cmbAmount.DisplayMember = "SellingAmount"
        Me.cmbAmount.DropDownHeight = 10
        Me.cmbAmount.Enabled = False
        Me.cmbAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbAmount.FormatString = "N1"
        Me.cmbAmount.FormattingEnabled = True
        Me.cmbAmount.IntegralHeight = False
        Me.cmbAmount.Location = New System.Drawing.Point(78, 96)
        Me.cmbAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAmount.MaxDropDownItems = 20
        Me.cmbAmount.Name = "cmbAmount"
        Me.cmbAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbAmount.Size = New System.Drawing.Size(184, 26)
        Me.cmbAmount.TabIndex = 49
        Me.cmbAmount.ValueMember = "ID"
        '
        'PrescriptionBindingSource
        '
        Me.PrescriptionBindingSource.DataMember = "Prescription"
        Me.PrescriptionBindingSource.DataSource = Me.pharmacyDataSet
        '
        'cmbDetailVisible
        '
        Me.cmbDetailVisible.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDetailVisible.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbDetailVisible.DataSource = Me.PrescriptionBindingSource
        Me.cmbDetailVisible.DisplayMember = "DetailVisible"
        Me.cmbDetailVisible.DropDownHeight = 10
        Me.cmbDetailVisible.Enabled = False
        Me.cmbDetailVisible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDetailVisible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbDetailVisible.FormattingEnabled = True
        Me.cmbDetailVisible.IntegralHeight = False
        Me.cmbDetailVisible.Location = New System.Drawing.Point(78, 98)
        Me.cmbDetailVisible.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDetailVisible.MaxDropDownItems = 20
        Me.cmbDetailVisible.Name = "cmbDetailVisible"
        Me.cmbDetailVisible.Size = New System.Drawing.Size(22, 23)
        Me.cmbDetailVisible.TabIndex = 48
        Me.cmbDetailVisible.ValueMember = "ID"
        '
        'cmbComment
        '
        Me.cmbComment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbComment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbComment.DataSource = Me.PrescriptionBindingSource
        Me.cmbComment.DisplayMember = "Comment"
        Me.cmbComment.DropDownHeight = 10
        Me.cmbComment.Enabled = False
        Me.cmbComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbComment.FormattingEnabled = True
        Me.cmbComment.IntegralHeight = False
        Me.cmbComment.Location = New System.Drawing.Point(266, 95)
        Me.cmbComment.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbComment.MaxDropDownItems = 20
        Me.cmbComment.Name = "cmbComment"
        Me.cmbComment.Size = New System.Drawing.Size(332, 28)
        Me.cmbComment.TabIndex = 47
        Me.cmbComment.ValueMember = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label2.Location = New System.Drawing.Point(5, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Tên "
        '
        'cmbPrescription
        '
        Me.cmbPrescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPrescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPrescription.DataSource = Me.PrescriptionBindingSource
        Me.cmbPrescription.DisplayMember = "Name"
        Me.cmbPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPrescription.FormattingEnabled = True
        Me.cmbPrescription.Location = New System.Drawing.Point(78, 59)
        Me.cmbPrescription.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPrescription.MaxDropDownItems = 20
        Me.cmbPrescription.Name = "cmbPrescription"
        Me.cmbPrescription.Size = New System.Drawing.Size(520, 32)
        Me.cmbPrescription.TabIndex = 2
        Me.cmbPrescription.ValueMember = "ID"
        '
        'PresciptionContentDataGridView
        '
        Me.PresciptionContentDataGridView.AllowUserToAddRows = False
        Me.PresciptionContentDataGridView.AllowUserToDeleteRows = False
        Me.PresciptionContentDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PresciptionContentDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PresciptionContentDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PresciptionContentDataGridView.AutoGenerateColumns = False
        Me.PresciptionContentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PresciptionContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresciptionContentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPrescriptionIdProd, Me.colPrescriptionQuant, Me.colPrescriptionIdUnit, Me.colPrescriptionPrice, Me.colPrescriptionComment, Me.colPrescriptionIdPrescrip, Me.colProdBarCoding})
        Me.PresciptionContentDataGridView.DataSource = Me.PrescriptionContentBindingSource
        Me.PresciptionContentDataGridView.Location = New System.Drawing.Point(9, 127)
        Me.PresciptionContentDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.PresciptionContentDataGridView.Name = "PresciptionContentDataGridView"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PresciptionContentDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.PresciptionContentDataGridView.RowHeadersWidth = 10
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresciptionContentDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.PresciptionContentDataGridView.RowTemplate.Height = 24
        Me.PresciptionContentDataGridView.Size = New System.Drawing.Size(589, 322)
        Me.PresciptionContentDataGridView.TabIndex = 1
        '
        'colPrescriptionIdProd
        '
        Me.colPrescriptionIdProd.DataPropertyName = "idProductInfo"
        Me.colPrescriptionIdProd.DataSource = Me.ProductNameBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPrescriptionIdProd.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPrescriptionIdProd.DisplayMember = "ProductName"
        Me.colPrescriptionIdProd.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.colPrescriptionIdProd.HeaderText = "Tên sản phẩm"
        Me.colPrescriptionIdProd.Name = "colPrescriptionIdProd"
        Me.colPrescriptionIdProd.ReadOnly = True
        Me.colPrescriptionIdProd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPrescriptionIdProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colPrescriptionIdProd.ValueMember = "id"
        '
        'colPrescriptionQuant
        '
        Me.colPrescriptionQuant.DataPropertyName = "quant"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrescriptionQuant.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPrescriptionQuant.HeaderText = "SL"
        Me.colPrescriptionQuant.Name = "colPrescriptionQuant"
        Me.colPrescriptionQuant.Width = 45
        '
        'colPrescriptionIdUnit
        '
        Me.colPrescriptionIdUnit.DataPropertyName = "idUnit"
        Me.colPrescriptionIdUnit.DataSource = Me.ProductUnitBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colPrescriptionIdUnit.DefaultCellStyle = DataGridViewCellStyle4
        Me.colPrescriptionIdUnit.DisplayMember = "Unit"
        Me.colPrescriptionIdUnit.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.colPrescriptionIdUnit.HeaderText = "ĐV"
        Me.colPrescriptionIdUnit.Name = "colPrescriptionIdUnit"
        Me.colPrescriptionIdUnit.ReadOnly = True
        Me.colPrescriptionIdUnit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPrescriptionIdUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colPrescriptionIdUnit.ValueMember = "id"
        Me.colPrescriptionIdUnit.Width = 47
        '
        'ProductUnitBindingSource
        '
        Me.ProductUnitBindingSource.DataMember = "ProductUnit"
        Me.ProductUnitBindingSource.DataSource = Me.pharmacyDataSet
        '
        'colPrescriptionPrice
        '
        Me.colPrescriptionPrice.DataPropertyName = "idPrescription"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N1"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.colPrescriptionPrice.DefaultCellStyle = DataGridViewCellStyle5
        Me.colPrescriptionPrice.HeaderText = "Đơn giá"
        Me.colPrescriptionPrice.Name = "colPrescriptionPrice"
        Me.colPrescriptionPrice.ReadOnly = True
        Me.colPrescriptionPrice.Visible = False
        Me.colPrescriptionPrice.Width = 69
        '
        'colPrescriptionComment
        '
        Me.colPrescriptionComment.DataPropertyName = "Comment"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colPrescriptionComment.DefaultCellStyle = DataGridViewCellStyle6
        Me.colPrescriptionComment.HeaderText = "Ghi chú"
        Me.colPrescriptionComment.Name = "colPrescriptionComment"
        Me.colPrescriptionComment.ReadOnly = True
        Me.colPrescriptionComment.Width = 69
        '
        'colPrescriptionIdPrescrip
        '
        Me.colPrescriptionIdPrescrip.DataPropertyName = "idPrescription"
        Me.colPrescriptionIdPrescrip.HeaderText = "idPrescription"
        Me.colPrescriptionIdPrescrip.Name = "colPrescriptionIdPrescrip"
        Me.colPrescriptionIdPrescrip.Visible = False
        Me.colPrescriptionIdPrescrip.Width = 95
        '
        'colProdBarCoding
        '
        Me.colProdBarCoding.DataPropertyName = "idProductInfo"
        Me.colProdBarCoding.DataSource = Me.ProductInfoBindingSource
        Me.colProdBarCoding.DisplayMember = "BarCode"
        Me.colProdBarCoding.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.colProdBarCoding.HeaderText = "Mã vạch"
        Me.colProdBarCoding.Name = "colProdBarCoding"
        Me.colProdBarCoding.ReadOnly = True
        Me.colProdBarCoding.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colProdBarCoding.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colProdBarCoding.ValueMember = "id"
        Me.colProdBarCoding.Width = 74
        '
        'PrescriptionContentBindingSource
        '
        Me.PrescriptionContentBindingSource.DataMember = "PrescriptionContent"
        Me.PrescriptionContentBindingSource.DataSource = Me.pharmacyDataSet
        '
        'PrescriptionContentTableAdapter
        '
        Me.PrescriptionContentTableAdapter.ClearBeforeFill = True
        '
        'butAddAllToSelling
        '
        Me.butAddAllToSelling.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.butAddAllToSelling.Image = Global.MyApplication.My.Resources.Resources.Ok_icon_32
        Me.butAddAllToSelling.Location = New System.Drawing.Point(626, 142)
        Me.butAddAllToSelling.Name = "butAddAllToSelling"
        Me.butAddAllToSelling.Size = New System.Drawing.Size(60, 60)
        Me.butAddAllToSelling.TabIndex = 42
        Me.butAddAllToSelling.UseVisualStyleBackColor = True
        '
        'OneSPBindingSource
        '
        Me.OneSPBindingSource.DataMember = "OneSP"
        Me.OneSPBindingSource.DataSource = Me.pharmacyDataSet
        '
        'OneSPTableAdapter
        '
        Me.OneSPTableAdapter.ClearBeforeFill = True
        '
        'PrescriptionTableAdapter
        '
        Me.PrescriptionTableAdapter.ClearBeforeFill = True
        '
        'butClose
        '
        Me.butClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClose.ForeColor = System.Drawing.Color.Red
        Me.butClose.Location = New System.Drawing.Point(627, 11)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(53, 27)
        Me.butClose.TabIndex = 45
        Me.butClose.Text = "X"
        Me.butClose.UseVisualStyleBackColor = True
        Me.butClose.Visible = False
        '
        'butDel
        '
        Me.butDel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.butDel.Location = New System.Drawing.Point(627, 393)
        Me.butDel.Name = "butDel"
        Me.butDel.Size = New System.Drawing.Size(60, 60)
        Me.butDel.TabIndex = 46
        Me.butDel.UseVisualStyleBackColor = True
        '
        'butModif
        '
        Me.butModif.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.butModif.Image = Global.MyApplication.My.Resources.Resources.Text_Edit_icon_32
        Me.butModif.Location = New System.Drawing.Point(627, 327)
        Me.butModif.Name = "butModif"
        Me.butModif.Size = New System.Drawing.Size(60, 60)
        Me.butModif.TabIndex = 47
        Me.butModif.UseVisualStyleBackColor = True
        '
        'but_Ratio
        '
        Me.but_Ratio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.but_Ratio.Image = Global.MyApplication.My.Resources.Resources.rules_icon_32
        Me.but_Ratio.Location = New System.Drawing.Point(627, 242)
        Me.but_Ratio.Name = "but_Ratio"
        Me.but_Ratio.Size = New System.Drawing.Size(60, 60)
        Me.but_Ratio.TabIndex = 48
        Me.but_Ratio.UseVisualStyleBackColor = True
        Me.but_Ratio.Visible = False
        '
        'txtRatio
        '
        Me.txtRatio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRatio.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRatio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRatio.Location = New System.Drawing.Point(627, 63)
        Me.txtRatio.Name = "txtRatio"
        Me.txtRatio.Size = New System.Drawing.Size(59, 35)
        Me.txtRatio.TabIndex = 49
        Me.txtRatio.Text = "1"
        Me.txtRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SellingUI_GroupProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(699, 468)
        Me.Controls.Add(Me.txtRatio)
        Me.Controls.Add(Me.but_Ratio)
        Me.Controls.Add(Me.butModif)
        Me.Controls.Add(Me.butDel)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butAddAllToSelling)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SellingUI_GroupProduct"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhóm sản phẩm bán gộp"
        Me.TopMost = True
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pharmacyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceForSellingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellingPriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PrescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresciptionContentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductUnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrescriptionContentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OneSPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pharmacyDataSet As MyApplication.pharmacyDataSet

    Friend WithEvents TableAdapterManager As MyApplication.pharmacyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductInfoTableAdapter As MyApplication.pharmacyDataSetTableAdapters.ProductInfoTableAdapter
    Friend WithEvents ProductNameTableAdapter As MyApplication.pharmacyDataSetTableAdapters.ProductNameTableAdapter
    Friend WithEvents ProductUnitTableAdapter As MyApplication.pharmacyDataSetTableAdapters.ProductUnitTableAdapter
    Friend WithEvents ProductNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocationTableAdapter As MyApplication.pharmacyDataSetTableAdapters.LocationTableAdapter
    Friend WithEvents InputPriceTableAdapter As MyApplication.pharmacyDataSetTableAdapters.InputPriceTableAdapter
    Friend WithEvents CipTableAdapter As MyApplication.pharmacyDataSetTableAdapters.CIPTableAdapter
    Friend WithEvents CSeTableAdapter As MyApplication.pharmacyDataSetTableAdapters.CSeTableAdapter
    Friend WithEvents CSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CSTableAdapter As MyApplication.pharmacyDataSetTableAdapters.CSTableAdapter
    Friend WithEvents idName As System.Windows.Forms.DataGridViewComboBoxColumn

    Friend WithEvents PriceForSellingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PriceForSellingTableAdapter As MyApplication.pharmacyDataSetTableAdapters.PriceForSellingTableAdapter
    Friend WithEvents SellingPriceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SellingPriceTableAdapter As MyApplication.pharmacyDataSetTableAdapters.SellingPriceTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PresciptionContentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PrescriptionContentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrescriptionContentTableAdapter As MyApplication.pharmacyDataSetTableAdapters.PrescriptionContentTableAdapter
    Friend WithEvents ProductUnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents butAddAllToSelling As System.Windows.Forms.Button
    Friend WithEvents OneSPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OneSPTableAdapter As MyApplication.pharmacyDataSetTableAdapters.OneSPTableAdapter

    Friend WithEvents cmbPrescription As System.Windows.Forms.ComboBox
    Friend WithEvents PrescriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrescriptionTableAdapter As MyApplication.pharmacyDataSetTableAdapters.PrescriptionTableAdapter
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents butDel As System.Windows.Forms.Button
    Friend WithEvents butModif As System.Windows.Forms.Button
    Friend WithEvents but_Ratio As System.Windows.Forms.Button
    Friend WithEvents txtRatio As System.Windows.Forms.TextBox
    Friend WithEvents cmbComment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDetailVisible As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAmount As System.Windows.Forms.ComboBox
    Friend WithEvents ButGroup_TC As System.Windows.Forms.Button
    Friend WithEvents ButGroup_00 As System.Windows.Forms.Button
    Friend WithEvents ButGroup_09 As System.Windows.Forms.Button
    Friend WithEvents ButGroup_02 As System.Windows.Forms.Button
    Friend WithEvents ButGroup_03 As System.Windows.Forms.Button
    Friend WithEvents ButGroup_04 As System.Windows.Forms.Button
    Friend WithEvents ButGroup_05 As System.Windows.Forms.Button
    Friend WithEvents ButGroup_06 As System.Windows.Forms.Button
    Friend WithEvents ButGroup_07 As System.Windows.Forms.Button
    Friend WithEvents ButGroup_08 As System.Windows.Forms.Button
    Friend WithEvents ButGroup_01 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colPrescriptionIdProd As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colPrescriptionQuant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrescriptionIdUnit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colPrescriptionPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrescriptionComment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrescriptionIdPrescrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProdBarCoding As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
