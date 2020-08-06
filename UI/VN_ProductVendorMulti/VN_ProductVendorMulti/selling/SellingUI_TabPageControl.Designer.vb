<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellingUI_TabPageControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim Label13 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellingUI_TabPageControl))
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle65 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle66 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ProductInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pharmacyDataSet = New MyApplication.pharmacyDataSet()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceForSellingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductInfoTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.ProductInfoTableAdapter()
        Me.ProductNameTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.ProductNameTableAdapter()
        Me.ProductUnitTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.ProductUnitTableAdapter()
        Me.LocationTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.LocationTableAdapter()
        Me.TableAdapterManager = New MyApplication.pharmacyDataSetTableAdapters.TableAdapterManager()
        Me.InputPriceTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.InputPriceTableAdapter()
        Me.CSeTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.CSeTableAdapter()
        Me.CSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.CSTableAdapter()
        Me.PriceForSellingTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.PriceForSellingTableAdapter()
        Me.SellingPriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SellingPriceTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.SellingPriceTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.butReset = New System.Windows.Forms.Button()
        Me.butClientClose = New System.Windows.Forms.Button()
        Me.butRePrint = New System.Windows.Forms.Button()
        Me.Fact_UpdateInsertDeleteTableAdapter1 = New MyApplication.factManagementDataSetTableAdapters.Fact_UpdateInsertDeleteTableAdapter()
        Me.TableAdapterManager_Fact = New MyApplication.factManagementDataSetTableAdapters.TableAdapterManager()
        Me.FactManagementDB = New MyApplication.factManagementDataSet()
        Me.RS_Stock_SellingTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.RS_Stock_SellingTableAdapter()
        Me.RS_Stock_SellingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllStocksForSellingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllStocksForSellingTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.AllStocksForSellingTableAdapter()
        Me.PriceInputMaxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceInputMaxTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.PriceInputMaxTableAdapter()
        Me.RQOfProductTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.RQOfProductTableAdapter()
        Me.WaitToUpdateRQTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.WaitToUpdateRQTableAdapter()
        Me.RS_Seller_CSeTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.RS_Seller_CSeTableAdapter()
        Me.RS_Seller_CSeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTableAdapter = New MyApplication.posprinterDataSetTableAdapters.dataTableAdapter()
        Me.RS_Prescription_CSeTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.RS_Prescription_CSeTableAdapter()
        Me.RS_Prescription_CSeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.group_03 = New System.Windows.Forms.GroupBox()
        Me.label_lastIdSell = New System.Windows.Forms.Label()
        Me.chkPrinter = New System.Windows.Forms.CheckBox()
        Me.butClientCalcul = New System.Windows.Forms.Button()
        Me.butClientMoney = New System.Windows.Forms.Button()
        Me.txtDiscountPercent = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.butClientEnd = New System.Windows.Forms.Button()
        Me.txtSumReturn = New System.Windows.Forms.TextBox()
        Me.txtSumReception = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.group_01 = New System.Windows.Forms.GroupBox()
        Me.butKeyboard_Presc = New System.Windows.Forms.Button()
        Me.butKeyboard_Productname = New System.Windows.Forms.Button()
        Me.butKeyboard_BarCode = New System.Windows.Forms.Button()
        Me.butPrescription = New System.Windows.Forms.Button()
        Me.txtClientId = New System.Windows.Forms.TextBox()
        Me.butAddClient = New System.Windows.Forms.Button()
        Me.txtCodingPrescription = New System.Windows.Forms.TextBox()
        Me.txtSeller = New System.Windows.Forms.TextBox()
        Me.ProductDetailPopup = New System.Windows.Forms.GroupBox()
        Me.groupStock = New System.Windows.Forms.GroupBox()
        Me.chkAthenB = New System.Windows.Forms.CheckBox()
        Me.chkB = New System.Windows.Forms.CheckBox()
        Me.chkA = New System.Windows.Forms.CheckBox()
        Me.chkBthenA = New System.Windows.Forms.CheckBox()
        Me.butClosePopup = New System.Windows.Forms.Button()
        Me.ProductInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.colProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdProdInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodingBarOrig = New System.Windows.Forms.TextBox()
        Me.cmbPrice = New System.Windows.Forms.ComboBox()
        Me.cmbSellingUnit = New System.Windows.Forms.ComboBox()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.butOK = New System.Windows.Forms.Button()
        Me.txtQuant = New System.Windows.Forms.TextBox()
        Me.group_02 = New System.Windows.Forms.GroupBox()
        Me.groupAll = New System.Windows.Forms.SplitContainer()
        Me.groupA = New System.Windows.Forms.GroupBox()
        Me.butDown = New System.Windows.Forms.Button()
        Me.SListDataGridView = New System.Windows.Forms.DataGridView()
        Me.colSTT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdSPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRatio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupB = New System.Windows.Forms.SplitContainer()
        Me.butRight = New System.Windows.Forms.Button()
        Me.PrescripDataGridView = New System.Windows.Forms.DataGridView()
        Me.colPrescripOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrescripName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrescripPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrescripQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrescripAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrescripId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.butLeft = New System.Windows.Forms.Button()
        Me.butUp = New System.Windows.Forms.Button()
        Me.PrescripDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.colProdName_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQ_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnit_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdProd_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStock_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQOut_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdSPrice_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdStock_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRatio_Cache = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMyPrescripOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.butDelLine = New System.Windows.Forms.Button()
        Me.butCorrect = New System.Windows.Forms.Button()
        Me.butDiscount = New System.Windows.Forms.Button()
        Me.CipTableAdapter = New MyApplication.pharmacyDataSetTableAdapters.CIPTableAdapter()
        Me.POSPrint = New System.Drawing.Printing.PrintDocument()
        Label13 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.ProductInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pharmacyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceForSellingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellingPriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactManagementDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RS_Stock_SellingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllStocksForSellingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceInputMaxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RS_Seller_CSeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RS_Prescription_CSeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_03.SuspendLayout()
        Me.group_01.SuspendLayout()
        Me.ProductDetailPopup.SuspendLayout()
        Me.groupStock.SuspendLayout()
        CType(Me.ProductInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_02.SuspendLayout()
        CType(Me.groupAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupAll.Panel1.SuspendLayout()
        Me.groupAll.Panel2.SuspendLayout()
        Me.groupAll.SuspendLayout()
        Me.groupA.SuspendLayout()
        CType(Me.SListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupB.Panel1.SuspendLayout()
        Me.groupB.Panel2.SuspendLayout()
        Me.groupB.SuspendLayout()
        CType(Me.PrescripDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrescripDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Label13.ForeColor = System.Drawing.Color.Red
        Label13.Location = New System.Drawing.Point(793, 55)
        Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(22, 18)
        Label13.TabIndex = 38
        Label13.Text = "%"
        Label13.Visible = False
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label11.Location = New System.Drawing.Point(5, 60)
        Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(84, 25)
        Label11.TabIndex = 36
        Label11.Text = "Kh.mãi"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label10.Location = New System.Drawing.Point(228, 60)
        Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(100, 25)
        Label10.TabIndex = 30
        Label10.Text = "Tiền trả:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label9.Location = New System.Drawing.Point(227, 19)
        Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(117, 25)
        Label9.TabIndex = 28
        Label9.Text = "Tiền nhận"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label8.Location = New System.Drawing.Point(5, 19)
        Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(72, 25)
        Label8.TabIndex = 26
        Label8.Text = "Tổng "
        '
        'Label12
        '
        Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.Blue
        Label12.Location = New System.Drawing.Point(678, 16)
        Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(99, 24)
        Label12.TabIndex = 57
        Label12.Text = "Dựng sẵn"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Maroon
        Label3.Location = New System.Drawing.Point(6, 103)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(113, 24)
        Label3.TabIndex = 53
        Label3.Text = "Người bán:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Blue
        Label4.Location = New System.Drawing.Point(5, 16)
        Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(41, 24)
        Label4.TabIndex = 41
        Label4.Text = "MV"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.Blue
        Label7.Location = New System.Drawing.Point(539, 57)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(46, 24)
        Label7.TabIndex = 32
        Label7.Text = "S.L."
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.Blue
        Label6.Location = New System.Drawing.Point(273, 57)
        Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(61, 24)
        Label6.TabIndex = 30
        Label6.Text = "Đ.Giá"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.Blue
        Label5.Location = New System.Drawing.Point(3, 57)
        Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(50, 24)
        Label5.TabIndex = 28
        Label5.Text = "Đ.V."
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Blue
        Label1.Location = New System.Drawing.Point(273, 16)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(81, 24)
        Label1.TabIndex = 23
        Label1.Text = "S.phẩm"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Maroon
        Label2.Location = New System.Drawing.Point(273, 103)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(82, 24)
        Label2.TabIndex = 58
        Label2.Text = "K.hàng:"
        '
        'ProductInfoBindingSource
        '
        Me.ProductInfoBindingSource.DataMember = "ProductInfo"
        Me.ProductInfoBindingSource.DataSource = Me.pharmacyDataSet
        '
        'pharmacyDataSet
        '
        Me.pharmacyDataSet.DataSetName = "pharmacyDataSet"
        Me.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "Location"
        Me.LocationBindingSource.DataSource = Me.pharmacyDataSet
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
        'butReset
        '
        Me.butReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butReset.BackgroundImage = Global.MyApplication.My.Resources.Resources.rules_icon_32
        Me.butReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.butReset.Location = New System.Drawing.Point(858, 510)
        Me.butReset.Name = "butReset"
        Me.butReset.Size = New System.Drawing.Size(80, 45)
        Me.butReset.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.butReset, "Khởi tạo lại")
        Me.butReset.UseVisualStyleBackColor = True
        '
        'butClientClose
        '
        Me.butClientClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butClientClose.BackgroundImage = Global.MyApplication.My.Resources.Resources.Pause_icon_32
        Me.butClientClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.butClientClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClientClose.ForeColor = System.Drawing.Color.Red
        Me.butClientClose.Location = New System.Drawing.Point(858, 558)
        Me.butClientClose.Name = "butClientClose"
        Me.butClientClose.Size = New System.Drawing.Size(80, 45)
        Me.butClientClose.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.butClientClose, "Bỏ qua")
        Me.butClientClose.UseVisualStyleBackColor = True
        '
        'butRePrint
        '
        Me.butRePrint.BackgroundImage = Global.MyApplication.My.Resources.Resources.cash_register_icon_32
        Me.butRePrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.butRePrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.butRePrint.Location = New System.Drawing.Point(805, 14)
        Me.butRePrint.Name = "butRePrint"
        Me.butRePrint.Size = New System.Drawing.Size(40, 29)
        Me.butRePrint.TabIndex = 45
        Me.butRePrint.Tag = "In lại"
        Me.ToolTip1.SetToolTip(Me.butRePrint, "In lại hóa đơn")
        Me.butRePrint.UseVisualStyleBackColor = True
        '
        'Fact_UpdateInsertDeleteTableAdapter1
        '
        Me.Fact_UpdateInsertDeleteTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager_Fact
        '
        Me.TableAdapterManager_Fact.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager_Fact.Connection = Nothing
        Me.TableAdapterManager_Fact.Fact_UpdateInsertDeleteTableAdapter = Nothing
        Me.TableAdapterManager_Fact.UpdateOrder = MyApplication.factManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FactManagementDB
        '
        Me.FactManagementDB.DataSetName = "factManagementDB"
        Me.FactManagementDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RS_Stock_SellingTableAdapter
        '
        Me.RS_Stock_SellingTableAdapter.ClearBeforeFill = True
        '
        'AllStocksForSellingBindingSource
        '
        Me.AllStocksForSellingBindingSource.DataSource = Me.pharmacyDataSet
        Me.AllStocksForSellingBindingSource.Position = 0
        '
        'AllStocksForSellingTableAdapter
        '
        Me.AllStocksForSellingTableAdapter.ClearBeforeFill = True
        '
        'PriceInputMaxBindingSource
        '
        Me.PriceInputMaxBindingSource.DataSource = Me.pharmacyDataSet
        Me.PriceInputMaxBindingSource.Position = 0
        '
        'PriceInputMaxTableAdapter
        '
        Me.PriceInputMaxTableAdapter.ClearBeforeFill = True
        '
        'RQOfProductTableAdapter
        '
        Me.RQOfProductTableAdapter.ClearBeforeFill = True
        '
        'WaitToUpdateRQTableAdapter
        '
        Me.WaitToUpdateRQTableAdapter.ClearBeforeFill = True
        '
        'RS_Seller_CSeTableAdapter
        '
        Me.RS_Seller_CSeTableAdapter.ClearBeforeFill = True
        '
        'RS_Seller_CSeBindingSource
        '
        Me.RS_Seller_CSeBindingSource.DataMember = "RS_Seller_CSe"
        Me.RS_Seller_CSeBindingSource.DataSource = Me.pharmacyDataSet
        '
        'DataTableAdapter
        '
        Me.DataTableAdapter.ClearBeforeFill = True
        '
        'RS_Prescription_CSeTableAdapter
        '
        Me.RS_Prescription_CSeTableAdapter.ClearBeforeFill = True
        '
        'RS_Prescription_CSeBindingSource
        '
        Me.RS_Prescription_CSeBindingSource.DataMember = "RS_Prescription_CSe"
        Me.RS_Prescription_CSeBindingSource.DataSource = Me.pharmacyDataSet
        '
        'group_03
        '
        Me.group_03.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group_03.Controls.Add(Me.butRePrint)
        Me.group_03.Controls.Add(Me.label_lastIdSell)
        Me.group_03.Controls.Add(Me.chkPrinter)
        Me.group_03.Controls.Add(Me.butClientCalcul)
        Me.group_03.Controls.Add(Me.butClientMoney)
        Me.group_03.Controls.Add(Label13)
        Me.group_03.Controls.Add(Me.txtDiscountPercent)
        Me.group_03.Controls.Add(Label11)
        Me.group_03.Controls.Add(Me.txtDiscount)
        Me.group_03.Controls.Add(Me.butClientEnd)
        Me.group_03.Controls.Add(Label10)
        Me.group_03.Controls.Add(Me.txtSumReturn)
        Me.group_03.Controls.Add(Label9)
        Me.group_03.Controls.Add(Me.txtSumReception)
        Me.group_03.Controls.Add(Label8)
        Me.group_03.Controls.Add(Me.txtTotalAmount)
        Me.group_03.Enabled = False
        Me.group_03.Location = New System.Drawing.Point(6, 503)
        Me.group_03.Name = "group_03"
        Me.group_03.Size = New System.Drawing.Size(851, 100)
        Me.group_03.TabIndex = 4
        Me.group_03.TabStop = False
        '
        'label_lastIdSell
        '
        Me.label_lastIdSell.AutoSize = True
        Me.label_lastIdSell.ForeColor = System.Drawing.Color.Maroon
        Me.label_lastIdSell.Location = New System.Drawing.Point(699, 22)
        Me.label_lastIdSell.Name = "label_lastIdSell"
        Me.label_lastIdSell.Size = New System.Drawing.Size(25, 13)
        Me.label_lastIdSell.TabIndex = 43
        Me.label_lastIdSell.Text = "N°: "
        '
        'chkPrinter
        '
        Me.chkPrinter.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkPrinter.Checked = True
        Me.chkPrinter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrinter.ForeColor = System.Drawing.Color.Red
        Me.chkPrinter.Location = New System.Drawing.Point(699, 46)
        Me.chkPrinter.Name = "chkPrinter"
        Me.chkPrinter.Size = New System.Drawing.Size(146, 44)
        Me.chkPrinter.TabIndex = 41
        Me.chkPrinter.Text = "In hóa đơn"
        Me.chkPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkPrinter.UseVisualStyleBackColor = True
        '
        'butClientCalcul
        '
        Me.butClientCalcul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.butClientCalcul.Location = New System.Drawing.Point(513, 55)
        Me.butClientCalcul.Name = "butClientCalcul"
        Me.butClientCalcul.Size = New System.Drawing.Size(67, 35)
        Me.butClientCalcul.TabIndex = 40
        Me.butClientCalcul.Text = "Tính"
        Me.butClientCalcul.UseVisualStyleBackColor = True
        '
        'butClientMoney
        '
        Me.butClientMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.butClientMoney.Location = New System.Drawing.Point(513, 14)
        Me.butClientMoney.Name = "butClientMoney"
        Me.butClientMoney.Size = New System.Drawing.Size(67, 34)
        Me.butClientMoney.TabIndex = 39
        Me.butClientMoney.Text = "Tiền"
        Me.butClientMoney.UseVisualStyleBackColor = True
        Me.butClientMoney.Visible = False
        '
        'txtDiscountPercent
        '
        Me.txtDiscountPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiscountPercent.ForeColor = System.Drawing.Color.Olive
        Me.txtDiscountPercent.Location = New System.Drawing.Point(727, 16)
        Me.txtDiscountPercent.Name = "txtDiscountPercent"
        Me.txtDiscountPercent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiscountPercent.Size = New System.Drawing.Size(72, 26)
        Me.txtDiscountPercent.TabIndex = 37
        Me.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDiscountPercent.Visible = False
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Olive
        Me.txtDiscount.Location = New System.Drawing.Point(101, 57)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiscount.Size = New System.Drawing.Size(123, 31)
        Me.txtDiscount.TabIndex = 9
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'butClientEnd
        '
        Me.butClientEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.butClientEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClientEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butClientEnd.Image = Global.MyApplication.My.Resources.Resources.Floppy_Small_icon_48
        Me.butClientEnd.Location = New System.Drawing.Point(594, 15)
        Me.butClientEnd.Name = "butClientEnd"
        Me.butClientEnd.Size = New System.Drawing.Size(75, 75)
        Me.butClientEnd.TabIndex = 11
        Me.butClientEnd.UseVisualStyleBackColor = True
        '
        'txtSumReturn
        '
        Me.txtSumReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSumReturn.ForeColor = System.Drawing.Color.Red
        Me.txtSumReturn.Location = New System.Drawing.Point(351, 57)
        Me.txtSumReturn.Name = "txtSumReturn"
        Me.txtSumReturn.ReadOnly = True
        Me.txtSumReturn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSumReturn.Size = New System.Drawing.Size(150, 31)
        Me.txtSumReturn.TabIndex = 29
        Me.txtSumReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSumReception
        '
        Me.txtSumReception.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSumReception.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSumReception.Location = New System.Drawing.Point(351, 16)
        Me.txtSumReception.Name = "txtSumReception"
        Me.txtSumReception.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSumReception.Size = New System.Drawing.Size(150, 31)
        Me.txtSumReception.TabIndex = 10
        Me.txtSumReception.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalAmount.Location = New System.Drawing.Point(102, 16)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalAmount.Size = New System.Drawing.Size(122, 31)
        Me.txtTotalAmount.TabIndex = 25
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'group_01
        '
        Me.group_01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group_01.Controls.Add(Me.butKeyboard_Presc)
        Me.group_01.Controls.Add(Me.butKeyboard_Productname)
        Me.group_01.Controls.Add(Me.butKeyboard_BarCode)
        Me.group_01.Controls.Add(Me.butPrescription)
        Me.group_01.Controls.Add(Label2)
        Me.group_01.Controls.Add(Label12)
        Me.group_01.Controls.Add(Me.txtClientId)
        Me.group_01.Controls.Add(Me.butAddClient)
        Me.group_01.Controls.Add(Me.txtCodingPrescription)
        Me.group_01.Controls.Add(Label3)
        Me.group_01.Controls.Add(Me.txtSeller)
        Me.group_01.Controls.Add(Me.ProductDetailPopup)
        Me.group_01.Controls.Add(Label4)
        Me.group_01.Controls.Add(Me.txtCodingBarOrig)
        Me.group_01.Controls.Add(Me.cmbPrice)
        Me.group_01.Controls.Add(Me.cmbSellingUnit)
        Me.group_01.Controls.Add(Me.cmbProductName)
        Me.group_01.Controls.Add(Me.butOK)
        Me.group_01.Controls.Add(Label7)
        Me.group_01.Controls.Add(Me.txtQuant)
        Me.group_01.Controls.Add(Label6)
        Me.group_01.Controls.Add(Label5)
        Me.group_01.Controls.Add(Label1)
        Me.group_01.Enabled = False
        Me.group_01.Location = New System.Drawing.Point(3, 3)
        Me.group_01.Name = "group_01"
        Me.group_01.Size = New System.Drawing.Size(944, 139)
        Me.group_01.TabIndex = 5
        Me.group_01.TabStop = False
        '
        'butKeyboard_Presc
        '
        Me.butKeyboard_Presc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butKeyboard_Presc.BackgroundImage = CType(resources.GetObject("butKeyboard_Presc.BackgroundImage"), System.Drawing.Image)
        Me.butKeyboard_Presc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butKeyboard_Presc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.butKeyboard_Presc.ForeColor = System.Drawing.Color.Maroon
        Me.butKeyboard_Presc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.butKeyboard_Presc.Location = New System.Drawing.Point(897, 11)
        Me.butKeyboard_Presc.Name = "butKeyboard_Presc"
        Me.butKeyboard_Presc.Size = New System.Drawing.Size(36, 36)
        Me.butKeyboard_Presc.TabIndex = 62
        Me.butKeyboard_Presc.UseVisualStyleBackColor = True
        '
        'butKeyboard_Productname
        '
        Me.butKeyboard_Productname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butKeyboard_Productname.BackgroundImage = CType(resources.GetObject("butKeyboard_Productname.BackgroundImage"), System.Drawing.Image)
        Me.butKeyboard_Productname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butKeyboard_Productname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.butKeyboard_Productname.ForeColor = System.Drawing.Color.Maroon
        Me.butKeyboard_Productname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.butKeyboard_Productname.Location = New System.Drawing.Point(635, 10)
        Me.butKeyboard_Productname.Name = "butKeyboard_Productname"
        Me.butKeyboard_Productname.Size = New System.Drawing.Size(36, 36)
        Me.butKeyboard_Productname.TabIndex = 61
        Me.butKeyboard_Productname.UseVisualStyleBackColor = True
        '
        'butKeyboard_BarCode
        '
        Me.butKeyboard_BarCode.BackgroundImage = CType(resources.GetObject("butKeyboard_BarCode.BackgroundImage"), System.Drawing.Image)
        Me.butKeyboard_BarCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butKeyboard_BarCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.butKeyboard_BarCode.ForeColor = System.Drawing.Color.Maroon
        Me.butKeyboard_BarCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.butKeyboard_BarCode.Location = New System.Drawing.Point(231, 10)
        Me.butKeyboard_BarCode.Name = "butKeyboard_BarCode"
        Me.butKeyboard_BarCode.Size = New System.Drawing.Size(36, 36)
        Me.butKeyboard_BarCode.TabIndex = 60
        Me.butKeyboard_BarCode.UseVisualStyleBackColor = True
        '
        'butPrescription
        '
        Me.butPrescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butPrescription.ForeColor = System.Drawing.Color.Blue
        Me.butPrescription.Location = New System.Drawing.Point(783, 50)
        Me.butPrescription.Name = "butPrescription"
        Me.butPrescription.Size = New System.Drawing.Size(152, 80)
        Me.butPrescription.TabIndex = 59
        Me.butPrescription.Text = "Lấy theo d.sẵn"
        Me.butPrescription.UseVisualStyleBackColor = True
        '
        'txtClientId
        '
        Me.txtClientId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientId.ForeColor = System.Drawing.Color.Maroon
        Me.txtClientId.Location = New System.Drawing.Point(364, 101)
        Me.txtClientId.Name = "txtClientId"
        Me.txtClientId.Size = New System.Drawing.Size(74, 29)
        Me.txtClientId.TabIndex = 55
        Me.txtClientId.Text = "0"
        Me.txtClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'butAddClient
        '
        Me.butAddClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butAddClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddClient.ForeColor = System.Drawing.Color.Maroon
        Me.butAddClient.Location = New System.Drawing.Point(444, 100)
        Me.butAddClient.Name = "butAddClient"
        Me.butAddClient.Size = New System.Drawing.Size(93, 31)
        Me.butAddClient.TabIndex = 54
        Me.butAddClient.Text = "Tìm"
        Me.butAddClient.UseVisualStyleBackColor = True
        '
        'txtCodingPrescription
        '
        Me.txtCodingPrescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodingPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodingPrescription.ForeColor = System.Drawing.Color.Maroon
        Me.txtCodingPrescription.Location = New System.Drawing.Point(783, 14)
        Me.txtCodingPrescription.Name = "txtCodingPrescription"
        Me.txtCodingPrescription.Size = New System.Drawing.Size(100, 29)
        Me.txtCodingPrescription.TabIndex = 56
        '
        'txtSeller
        '
        Me.txtSeller.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeller.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSeller.Location = New System.Drawing.Point(155, 101)
        Me.txtSeller.Name = "txtSeller"
        Me.txtSeller.Size = New System.Drawing.Size(112, 29)
        Me.txtSeller.TabIndex = 52
        Me.txtSeller.Text = "0"
        Me.txtSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProductDetailPopup
        '
        Me.ProductDetailPopup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductDetailPopup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductDetailPopup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProductDetailPopup.Controls.Add(Me.groupStock)
        Me.ProductDetailPopup.Controls.Add(Me.butClosePopup)
        Me.ProductDetailPopup.Controls.Add(Me.ProductInfoDataGridView)
        Me.ProductDetailPopup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductDetailPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProductDetailPopup.Location = New System.Drawing.Point(775, 104)
        Me.ProductDetailPopup.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductDetailPopup.Name = "ProductDetailPopup"
        Me.ProductDetailPopup.Padding = New System.Windows.Forms.Padding(2)
        Me.ProductDetailPopup.Size = New System.Drawing.Size(117, 0)
        Me.ProductDetailPopup.TabIndex = 8
        Me.ProductDetailPopup.TabStop = False
        Me.ProductDetailPopup.Text = "       Chọn nhanh một dòng phù hợp"
        Me.ProductDetailPopup.Visible = False
        '
        'groupStock
        '
        Me.groupStock.Controls.Add(Me.chkAthenB)
        Me.groupStock.Controls.Add(Me.chkB)
        Me.groupStock.Controls.Add(Me.chkA)
        Me.groupStock.Controls.Add(Me.chkBthenA)
        Me.groupStock.Location = New System.Drawing.Point(370, 22)
        Me.groupStock.Name = "groupStock"
        Me.groupStock.Size = New System.Drawing.Size(94, 79)
        Me.groupStock.TabIndex = 40
        Me.groupStock.TabStop = False
        Me.groupStock.Visible = False
        '
        'chkAthenB
        '
        Me.chkAthenB.AutoSize = True
        Me.chkAthenB.Enabled = False
        Me.chkAthenB.Location = New System.Drawing.Point(6, 30)
        Me.chkAthenB.Name = "chkAthenB"
        Me.chkAthenB.Size = New System.Drawing.Size(57, 17)
        Me.chkAthenB.TabIndex = 41
        Me.chkAthenB.Text = "A rồi B"
        Me.chkAthenB.UseVisualStyleBackColor = True
        Me.chkAthenB.Visible = False
        '
        'chkB
        '
        Me.chkB.AutoSize = True
        Me.chkB.Location = New System.Drawing.Point(6, 46)
        Me.chkB.Name = "chkB"
        Me.chkB.Size = New System.Drawing.Size(50, 17)
        Me.chkB.TabIndex = 40
        Me.chkB.Text = "chỉ B"
        Me.chkB.UseVisualStyleBackColor = True
        '
        'chkA
        '
        Me.chkA.AutoSize = True
        Me.chkA.Location = New System.Drawing.Point(6, 13)
        Me.chkA.Name = "chkA"
        Me.chkA.Size = New System.Drawing.Size(50, 17)
        Me.chkA.TabIndex = 39
        Me.chkA.Text = "chỉ A"
        Me.chkA.UseVisualStyleBackColor = True
        '
        'chkBthenA
        '
        Me.chkBthenA.AutoSize = True
        Me.chkBthenA.Checked = True
        Me.chkBthenA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBthenA.Enabled = False
        Me.chkBthenA.Location = New System.Drawing.Point(6, 61)
        Me.chkBthenA.Name = "chkBthenA"
        Me.chkBthenA.Size = New System.Drawing.Size(57, 17)
        Me.chkBthenA.TabIndex = 38
        Me.chkBthenA.Text = "B rồi A"
        Me.chkBthenA.UseVisualStyleBackColor = True
        Me.chkBthenA.Visible = False
        '
        'butClosePopup
        '
        Me.butClosePopup.Location = New System.Drawing.Point(2, 0)
        Me.butClosePopup.Margin = New System.Windows.Forms.Padding(2)
        Me.butClosePopup.Name = "butClosePopup"
        Me.butClosePopup.Size = New System.Drawing.Size(20, 19)
        Me.butClosePopup.TabIndex = 1
        Me.butClosePopup.Tag = "Đóng cửa sổ"
        Me.butClosePopup.Text = "X"
        Me.butClosePopup.UseVisualStyleBackColor = True
        '
        'ProductInfoDataGridView
        '
        Me.ProductInfoDataGridView.AllowUserToAddRows = False
        Me.ProductInfoDataGridView.AllowUserToDeleteRows = False
        Me.ProductInfoDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.Lavender
        Me.ProductInfoDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle34
        Me.ProductInfoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductInfoDataGridView.AutoGenerateColumns = False
        Me.ProductInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductInfoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle35
        Me.ProductInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProductName, Me.colIdProdInfo})
        Me.ProductInfoDataGridView.DataSource = Me.ProductInfoBindingSource
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductInfoDataGridView.DefaultCellStyle = DataGridViewCellStyle36
        Me.ProductInfoDataGridView.Location = New System.Drawing.Point(8, 15)
        Me.ProductInfoDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductInfoDataGridView.Name = "ProductInfoDataGridView"
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductInfoDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle37
        Me.ProductInfoDataGridView.RowHeadersWidth = 30
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductInfoDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle38
        Me.ProductInfoDataGridView.RowTemplate.Height = 24
        Me.ProductInfoDataGridView.Size = New System.Drawing.Size(113, 0)
        Me.ProductInfoDataGridView.TabIndex = 3
        '
        'colProductName
        '
        Me.colProductName.DataPropertyName = "ProductName"
        Me.colProductName.HeaderText = "Tên sản phẩm"
        Me.colProductName.Name = "colProductName"
        '
        'colIdProdInfo
        '
        Me.colIdProdInfo.DataPropertyName = "id"
        Me.colIdProdInfo.HeaderText = "id"
        Me.colIdProdInfo.Name = "colIdProdInfo"
        Me.colIdProdInfo.ReadOnly = True
        Me.colIdProdInfo.Visible = False
        Me.colIdProdInfo.Width = 40
        '
        'txtCodingBarOrig
        '
        Me.txtCodingBarOrig.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodingBarOrig.ForeColor = System.Drawing.Color.Maroon
        Me.txtCodingBarOrig.Location = New System.Drawing.Point(82, 14)
        Me.txtCodingBarOrig.Name = "txtCodingBarOrig"
        Me.txtCodingBarOrig.Size = New System.Drawing.Size(145, 29)
        Me.txtCodingBarOrig.TabIndex = 40
        '
        'cmbPrice
        '
        Me.cmbPrice.DataSource = Me.PriceForSellingBindingSource
        Me.cmbPrice.DisplayMember = "SellingPrice"
        Me.cmbPrice.Enabled = False
        Me.cmbPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrice.ForeColor = System.Drawing.Color.Red
        Me.cmbPrice.FormatString = "N2"
        Me.cmbPrice.FormattingEnabled = True
        Me.cmbPrice.ItemHeight = 24
        Me.cmbPrice.Location = New System.Drawing.Point(364, 53)
        Me.cmbPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPrice.MaxDropDownItems = 4
        Me.cmbPrice.Name = "cmbPrice"
        Me.cmbPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbPrice.Size = New System.Drawing.Size(173, 32)
        Me.cmbPrice.TabIndex = 39
        Me.cmbPrice.TabStop = False
        Me.cmbPrice.ValueMember = "idSellingPrice"
        '
        'cmbSellingUnit
        '
        Me.cmbSellingUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSellingUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSellingUnit.DataSource = Me.PriceForSellingBindingSource
        Me.cmbSellingUnit.DisplayMember = "Unit"
        Me.cmbSellingUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSellingUnit.FormattingEnabled = True
        Me.cmbSellingUnit.ItemHeight = 24
        Me.cmbSellingUnit.Location = New System.Drawing.Point(82, 53)
        Me.cmbSellingUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSellingUnit.MaxDropDownItems = 4
        Me.cmbSellingUnit.Name = "cmbSellingUnit"
        Me.cmbSellingUnit.Size = New System.Drawing.Size(185, 32)
        Me.cmbSellingUnit.TabIndex = 5
        Me.cmbSellingUnit.ValueMember = "idSellingPrice"
        '
        'cmbProductName
        '
        Me.cmbProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProductName.DataSource = Me.ProductNameBindingSource
        Me.cmbProductName.DisplayMember = "ProductName"
        Me.cmbProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.ItemHeight = 24
        Me.cmbProductName.Location = New System.Drawing.Point(364, 12)
        Me.cmbProductName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbProductName.MaxDropDownItems = 20
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(258, 32)
        Me.cmbProductName.TabIndex = 3
        Me.cmbProductName.ValueMember = "id"
        '
        'butOK
        '
        Me.butOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butOK.Image = Global.MyApplication.My.Resources.Resources.Ok_icon_48
        Me.butOK.Location = New System.Drawing.Point(682, 51)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(80, 80)
        Me.butOK.TabIndex = 7
        Me.butOK.UseVisualStyleBackColor = True
        '
        'txtQuant
        '
        Me.txtQuant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuant.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQuant.Location = New System.Drawing.Point(596, 55)
        Me.txtQuant.Name = "txtQuant"
        Me.txtQuant.Size = New System.Drawing.Size(75, 29)
        Me.txtQuant.TabIndex = 6
        Me.txtQuant.Text = "1"
        Me.txtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'group_02
        '
        Me.group_02.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group_02.Controls.Add(Me.groupAll)
        Me.group_02.Controls.Add(Me.butDelLine)
        Me.group_02.Controls.Add(Me.butCorrect)
        Me.group_02.Controls.Add(Me.butDiscount)
        Me.group_02.Enabled = False
        Me.group_02.Location = New System.Drawing.Point(3, 148)
        Me.group_02.Name = "group_02"
        Me.group_02.Size = New System.Drawing.Size(944, 358)
        Me.group_02.TabIndex = 3
        Me.group_02.TabStop = False
        '
        'groupAll
        '
        Me.groupAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.groupAll.Location = New System.Drawing.Point(3, 13)
        Me.groupAll.Name = "groupAll"
        Me.groupAll.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'groupAll.Panel1
        '
        Me.groupAll.Panel1.Controls.Add(Me.groupA)
        Me.groupAll.Panel1MinSize = 0
        '
        'groupAll.Panel2
        '
        Me.groupAll.Panel2.Controls.Add(Me.groupB)
        Me.groupAll.Panel2MinSize = 0
        Me.groupAll.Size = New System.Drawing.Size(851, 339)
        Me.groupAll.SplitterDistance = 183
        Me.groupAll.SplitterIncrement = 2
        Me.groupAll.SplitterWidth = 5
        Me.groupAll.TabIndex = 205
        '
        'groupA
        '
        Me.groupA.Controls.Add(Me.butDown)
        Me.groupA.Controls.Add(Me.SListDataGridView)
        Me.groupA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupA.Location = New System.Drawing.Point(0, 0)
        Me.groupA.Name = "groupA"
        Me.groupA.Size = New System.Drawing.Size(847, 179)
        Me.groupA.TabIndex = 52
        Me.groupA.TabStop = False
        '
        'butDown
        '
        Me.butDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butDown.BackgroundImage = CType(resources.GetObject("butDown.BackgroundImage"), System.Drawing.Image)
        Me.butDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butDown.Location = New System.Drawing.Point(817, 149)
        Me.butDown.Name = "butDown"
        Me.butDown.Size = New System.Drawing.Size(30, 30)
        Me.butDown.TabIndex = 208
        Me.butDown.UseVisualStyleBackColor = True
        '
        'SListDataGridView
        '
        Me.SListDataGridView.AllowUserToAddRows = False
        Me.SListDataGridView.AllowUserToDeleteRows = False
        Me.SListDataGridView.AllowUserToOrderColumns = True
        Me.SListDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SListDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle58
        Me.SListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SListDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle59
        Me.SListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSTT, Me.colProdName, Me.colUnit, Me.colPrice, Me.colQ, Me.colAmount, Me.colIdProd, Me.colStock, Me.colQOut, Me.colIdSPrice, Me.colIdStock, Me.colRatio})
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle64.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SListDataGridView.DefaultCellStyle = DataGridViewCellStyle64
        Me.SListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SListDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.SListDataGridView.Name = "SListDataGridView"
        Me.SListDataGridView.ReadOnly = True
        DataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle65.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle65.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle65.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle65.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SListDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle65
        Me.SListDataGridView.RowHeadersWidth = 25
        DataGridViewCellStyle66.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SListDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle66
        Me.SListDataGridView.RowTemplate.Height = 24
        Me.SListDataGridView.Size = New System.Drawing.Size(841, 160)
        Me.SListDataGridView.TabIndex = 202
        '
        'colSTT
        '
        DataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle60.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSTT.DefaultCellStyle = DataGridViewCellStyle60
        Me.colSTT.FillWeight = 35.1391!
        Me.colSTT.HeaderText = "STT"
        Me.colSTT.Name = "colSTT"
        Me.colSTT.ReadOnly = True
        Me.colSTT.Width = 53
        '
        'colProdName
        '
        Me.colProdName.FillWeight = 110.9391!
        Me.colProdName.HeaderText = "Tên sản phẩm"
        Me.colProdName.Name = "colProdName"
        Me.colProdName.ReadOnly = True
        Me.colProdName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colUnit
        '
        Me.colUnit.FillWeight = 110.9391!
        Me.colUnit.HeaderText = "Đơn vị"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.ReadOnly = True
        Me.colUnit.Width = 63
        '
        'colPrice
        '
        DataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle61.Format = "N1"
        DataGridViewCellStyle61.NullValue = Nothing
        Me.colPrice.DefaultCellStyle = DataGridViewCellStyle61
        Me.colPrice.FillWeight = 110.9391!
        Me.colPrice.HeaderText = "Giá bán"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 69
        '
        'colQ
        '
        DataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle62.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colQ.DefaultCellStyle = DataGridViewCellStyle62
        Me.colQ.FillWeight = 110.9391!
        Me.colQ.HeaderText = "Số lượng"
        Me.colQ.Name = "colQ"
        Me.colQ.ReadOnly = True
        Me.colQ.Width = 74
        '
        'colAmount
        '
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle63.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle63.Format = "N1"
        DataGridViewCellStyle63.NullValue = Nothing
        Me.colAmount.DefaultCellStyle = DataGridViewCellStyle63
        Me.colAmount.FillWeight = 110.9391!
        Me.colAmount.HeaderText = "Tổng cộng"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.ReadOnly = True
        Me.colAmount.Width = 84
        '
        'colIdProd
        '
        Me.colIdProd.HeaderText = "colIdProd"
        Me.colIdProd.Name = "colIdProd"
        Me.colIdProd.ReadOnly = True
        Me.colIdProd.Visible = False
        Me.colIdProd.Width = 77
        '
        'colStock
        '
        Me.colStock.FillWeight = 35.13909!
        Me.colStock.HeaderText = "Kho"
        Me.colStock.Name = "colStock"
        Me.colStock.ReadOnly = True
        Me.colStock.Visible = False
        Me.colStock.Width = 51
        '
        'colQOut
        '
        Me.colQOut.HeaderText = "qOut"
        Me.colQOut.Name = "colQOut"
        Me.colQOut.ReadOnly = True
        Me.colQOut.Visible = False
        Me.colQOut.Width = 55
        '
        'colIdSPrice
        '
        Me.colIdSPrice.HeaderText = "idSPrice"
        Me.colIdSPrice.Name = "colIdSPrice"
        Me.colIdSPrice.ReadOnly = True
        Me.colIdSPrice.Visible = False
        Me.colIdSPrice.Width = 71
        '
        'colIdStock
        '
        Me.colIdStock.HeaderText = "idStock"
        Me.colIdStock.Name = "colIdStock"
        Me.colIdStock.ReadOnly = True
        Me.colIdStock.Visible = False
        Me.colIdStock.Width = 68
        '
        'colRatio
        '
        Me.colRatio.HeaderText = "ratio"
        Me.colRatio.Name = "colRatio"
        Me.colRatio.ReadOnly = True
        Me.colRatio.Visible = False
        Me.colRatio.Width = 52
        '
        'groupB
        '
        Me.groupB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.groupB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupB.Location = New System.Drawing.Point(0, 0)
        Me.groupB.Name = "groupB"
        '
        'groupB.Panel1
        '
        Me.groupB.Panel1.Controls.Add(Me.butRight)
        Me.groupB.Panel1.Controls.Add(Me.PrescripDataGridView)
        Me.groupB.Panel1MinSize = 0
        '
        'groupB.Panel2
        '
        Me.groupB.Panel2.Controls.Add(Me.butLeft)
        Me.groupB.Panel2.Controls.Add(Me.butUp)
        Me.groupB.Panel2.Controls.Add(Me.PrescripDetailDataGridView)
        Me.groupB.Panel2MinSize = 0
        Me.groupB.Size = New System.Drawing.Size(851, 151)
        Me.groupB.SplitterDistance = 387
        Me.groupB.SplitterIncrement = 2
        Me.groupB.SplitterWidth = 5
        Me.groupB.TabIndex = 61
        '
        'butRight
        '
        Me.butRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butRight.BackgroundImage = CType(resources.GetObject("butRight.BackgroundImage"), System.Drawing.Image)
        Me.butRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butRight.Location = New System.Drawing.Point(352, 117)
        Me.butRight.Name = "butRight"
        Me.butRight.Size = New System.Drawing.Size(30, 30)
        Me.butRight.TabIndex = 208
        Me.butRight.UseVisualStyleBackColor = True
        '
        'PrescripDataGridView
        '
        Me.PrescripDataGridView.AllowUserToAddRows = False
        Me.PrescripDataGridView.AllowUserToDeleteRows = False
        Me.PrescripDataGridView.AllowUserToOrderColumns = True
        Me.PrescripDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PrescripDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle39
        Me.PrescripDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrescripDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle40
        Me.PrescripDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrescripDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPrescripOrder, Me.colPrescripName, Me.colPrescripPrice, Me.colPrescripQ, Me.colPrescripAmount, Me.colPrescripId})
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PrescripDataGridView.DefaultCellStyle = DataGridViewCellStyle45
        Me.PrescripDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrescripDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PrescripDataGridView.Name = "PrescripDataGridView"
        Me.PrescripDataGridView.ReadOnly = True
        DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrescripDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle46
        Me.PrescripDataGridView.RowHeadersWidth = 25
        DataGridViewCellStyle47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrescripDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle47
        Me.PrescripDataGridView.RowTemplate.Height = 24
        Me.PrescripDataGridView.Size = New System.Drawing.Size(383, 147)
        Me.PrescripDataGridView.TabIndex = 203
        '
        'colPrescripOrder
        '
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPrescripOrder.DefaultCellStyle = DataGridViewCellStyle41
        Me.colPrescripOrder.FillWeight = 35.1391!
        Me.colPrescripOrder.HeaderText = "STT"
        Me.colPrescripOrder.Name = "colPrescripOrder"
        Me.colPrescripOrder.ReadOnly = True
        Me.colPrescripOrder.Width = 53
        '
        'colPrescripName
        '
        Me.colPrescripName.FillWeight = 110.9391!
        Me.colPrescripName.HeaderText = "Tên sản phẩm"
        Me.colPrescripName.Name = "colPrescripName"
        Me.colPrescripName.ReadOnly = True
        Me.colPrescripName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colPrescripPrice
        '
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle42.Format = "N1"
        DataGridViewCellStyle42.NullValue = Nothing
        Me.colPrescripPrice.DefaultCellStyle = DataGridViewCellStyle42
        Me.colPrescripPrice.FillWeight = 110.9391!
        Me.colPrescripPrice.HeaderText = "Giá bán"
        Me.colPrescripPrice.Name = "colPrescripPrice"
        Me.colPrescripPrice.ReadOnly = True
        Me.colPrescripPrice.Width = 69
        '
        'colPrescripQ
        '
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle43.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPrescripQ.DefaultCellStyle = DataGridViewCellStyle43
        Me.colPrescripQ.FillWeight = 110.9391!
        Me.colPrescripQ.HeaderText = "Số lượng"
        Me.colPrescripQ.Name = "colPrescripQ"
        Me.colPrescripQ.ReadOnly = True
        Me.colPrescripQ.Width = 74
        '
        'colPrescripAmount
        '
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle44.Format = "N1"
        DataGridViewCellStyle44.NullValue = Nothing
        Me.colPrescripAmount.DefaultCellStyle = DataGridViewCellStyle44
        Me.colPrescripAmount.FillWeight = 110.9391!
        Me.colPrescripAmount.HeaderText = "Tổng cộng"
        Me.colPrescripAmount.Name = "colPrescripAmount"
        Me.colPrescripAmount.ReadOnly = True
        Me.colPrescripAmount.Width = 84
        '
        'colPrescripId
        '
        Me.colPrescripId.HeaderText = "colIdPrescription"
        Me.colPrescripId.Name = "colPrescripId"
        Me.colPrescripId.ReadOnly = True
        Me.colPrescripId.Visible = False
        Me.colPrescripId.Width = 110
        '
        'butLeft
        '
        Me.butLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butLeft.BackgroundImage = CType(resources.GetObject("butLeft.BackgroundImage"), System.Drawing.Image)
        Me.butLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butLeft.Location = New System.Drawing.Point(2, 118)
        Me.butLeft.Name = "butLeft"
        Me.butLeft.Size = New System.Drawing.Size(30, 30)
        Me.butLeft.TabIndex = 209
        Me.butLeft.UseVisualStyleBackColor = True
        '
        'butUp
        '
        Me.butUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butUp.BackgroundImage = CType(resources.GetObject("butUp.BackgroundImage"), System.Drawing.Image)
        Me.butUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butUp.Location = New System.Drawing.Point(419, 0)
        Me.butUp.Name = "butUp"
        Me.butUp.Size = New System.Drawing.Size(30, 30)
        Me.butUp.TabIndex = 207
        Me.butUp.UseVisualStyleBackColor = True
        '
        'PrescripDetailDataGridView
        '
        Me.PrescripDetailDataGridView.AllowUserToAddRows = False
        Me.PrescripDetailDataGridView.AllowUserToDeleteRows = False
        Me.PrescripDetailDataGridView.AllowUserToOrderColumns = True
        Me.PrescripDetailDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PrescripDetailDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle48
        Me.PrescripDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrescripDetailDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle49
        Me.PrescripDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrescripDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProdName_Cache, Me.colQ_Cache, Me.colUnit_Cache, Me.colPrice_Cache, Me.colAmount_Cache, Me.colIdProd_Cache, Me.colStock_Cache, Me.colQOut_Cache, Me.colIdSPrice_Cache, Me.colIdStock_Cache, Me.colRatio_Cache, Me.colMyPrescripOrder})
        DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle55.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PrescripDetailDataGridView.DefaultCellStyle = DataGridViewCellStyle55
        Me.PrescripDetailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrescripDetailDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PrescripDetailDataGridView.Name = "PrescripDetailDataGridView"
        Me.PrescripDetailDataGridView.ReadOnly = True
        DataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle56.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle56.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle56.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrescripDetailDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle56
        Me.PrescripDetailDataGridView.RowHeadersWidth = 25
        DataGridViewCellStyle57.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrescripDetailDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle57
        Me.PrescripDetailDataGridView.RowTemplate.Height = 24
        Me.PrescripDetailDataGridView.Size = New System.Drawing.Size(455, 147)
        Me.PrescripDetailDataGridView.TabIndex = 204
        '
        'colProdName_Cache
        '
        DataGridViewCellStyle50.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colProdName_Cache.DefaultCellStyle = DataGridViewCellStyle50
        Me.colProdName_Cache.FillWeight = 110.9391!
        Me.colProdName_Cache.HeaderText = "Tên sản phẩm"
        Me.colProdName_Cache.Name = "colProdName_Cache"
        Me.colProdName_Cache.ReadOnly = True
        Me.colProdName_Cache.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colQ_Cache
        '
        DataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle51.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colQ_Cache.DefaultCellStyle = DataGridViewCellStyle51
        Me.colQ_Cache.FillWeight = 110.9391!
        Me.colQ_Cache.HeaderText = "Số lượng"
        Me.colQ_Cache.Name = "colQ_Cache"
        Me.colQ_Cache.ReadOnly = True
        Me.colQ_Cache.Width = 74
        '
        'colUnit_Cache
        '
        Me.colUnit_Cache.FillWeight = 110.9391!
        Me.colUnit_Cache.HeaderText = "Đơn vị"
        Me.colUnit_Cache.Name = "colUnit_Cache"
        Me.colUnit_Cache.ReadOnly = True
        Me.colUnit_Cache.Width = 63
        '
        'colPrice_Cache
        '
        DataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle52.Format = "N1"
        DataGridViewCellStyle52.NullValue = Nothing
        Me.colPrice_Cache.DefaultCellStyle = DataGridViewCellStyle52
        Me.colPrice_Cache.FillWeight = 110.9391!
        Me.colPrice_Cache.HeaderText = "Giá bán"
        Me.colPrice_Cache.Name = "colPrice_Cache"
        Me.colPrice_Cache.ReadOnly = True
        Me.colPrice_Cache.Visible = False
        Me.colPrice_Cache.Width = 69
        '
        'colAmount_Cache
        '
        DataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle53.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle53.Format = "N1"
        DataGridViewCellStyle53.NullValue = Nothing
        Me.colAmount_Cache.DefaultCellStyle = DataGridViewCellStyle53
        Me.colAmount_Cache.FillWeight = 110.9391!
        Me.colAmount_Cache.HeaderText = "Tổng cộng"
        Me.colAmount_Cache.Name = "colAmount_Cache"
        Me.colAmount_Cache.ReadOnly = True
        Me.colAmount_Cache.Visible = False
        Me.colAmount_Cache.Width = 84
        '
        'colIdProd_Cache
        '
        Me.colIdProd_Cache.HeaderText = "colIdProd"
        Me.colIdProd_Cache.Name = "colIdProd_Cache"
        Me.colIdProd_Cache.ReadOnly = True
        Me.colIdProd_Cache.Visible = False
        Me.colIdProd_Cache.Width = 77
        '
        'colStock_Cache
        '
        Me.colStock_Cache.FillWeight = 35.13909!
        Me.colStock_Cache.HeaderText = "Kho"
        Me.colStock_Cache.Name = "colStock_Cache"
        Me.colStock_Cache.ReadOnly = True
        Me.colStock_Cache.Visible = False
        Me.colStock_Cache.Width = 51
        '
        'colQOut_Cache
        '
        Me.colQOut_Cache.HeaderText = "qOut"
        Me.colQOut_Cache.Name = "colQOut_Cache"
        Me.colQOut_Cache.ReadOnly = True
        Me.colQOut_Cache.Visible = False
        Me.colQOut_Cache.Width = 55
        '
        'colIdSPrice_Cache
        '
        Me.colIdSPrice_Cache.HeaderText = "idSPrice"
        Me.colIdSPrice_Cache.Name = "colIdSPrice_Cache"
        Me.colIdSPrice_Cache.ReadOnly = True
        Me.colIdSPrice_Cache.Visible = False
        Me.colIdSPrice_Cache.Width = 71
        '
        'colIdStock_Cache
        '
        Me.colIdStock_Cache.HeaderText = "idStock"
        Me.colIdStock_Cache.Name = "colIdStock_Cache"
        Me.colIdStock_Cache.ReadOnly = True
        Me.colIdStock_Cache.Visible = False
        Me.colIdStock_Cache.Width = 68
        '
        'colRatio_Cache
        '
        Me.colRatio_Cache.HeaderText = "ratio"
        Me.colRatio_Cache.Name = "colRatio_Cache"
        Me.colRatio_Cache.ReadOnly = True
        Me.colRatio_Cache.Visible = False
        Me.colRatio_Cache.Width = 52
        '
        'colMyPrescripOrder
        '
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle54.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMyPrescripOrder.DefaultCellStyle = DataGridViewCellStyle54
        Me.colMyPrescripOrder.FillWeight = 35.1391!
        Me.colMyPrescripOrder.HeaderText = "Đơn"
        Me.colMyPrescripOrder.Name = "colMyPrescripOrder"
        Me.colMyPrescripOrder.ReadOnly = True
        Me.colMyPrescripOrder.Width = 52
        '
        'butDelLine
        '
        Me.butDelLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butDelLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.butDelLine.ForeColor = System.Drawing.Color.Purple
        Me.butDelLine.Location = New System.Drawing.Point(858, 287)
        Me.butDelLine.Name = "butDelLine"
        Me.butDelLine.Size = New System.Drawing.Size(80, 60)
        Me.butDelLine.TabIndex = 203
        Me.butDelLine.Text = "Xóa"
        Me.butDelLine.UseVisualStyleBackColor = True
        '
        'butCorrect
        '
        Me.butCorrect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCorrect.Enabled = False
        Me.butCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCorrect.Location = New System.Drawing.Point(858, 215)
        Me.butCorrect.Name = "butCorrect"
        Me.butCorrect.Size = New System.Drawing.Size(75, 23)
        Me.butCorrect.TabIndex = 1
        Me.butCorrect.Text = "Sửa"
        Me.butCorrect.UseVisualStyleBackColor = True
        Me.butCorrect.Visible = False
        '
        'butDiscount
        '
        Me.butDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butDiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDiscount.Location = New System.Drawing.Point(858, 13)
        Me.butDiscount.Name = "butDiscount"
        Me.butDiscount.Size = New System.Drawing.Size(80, 120)
        Me.butDiscount.TabIndex = 204
        Me.butDiscount.Text = "Khả năng khuyến mãi"
        Me.butDiscount.UseVisualStyleBackColor = True
        '
        'CipTableAdapter
        '
        Me.CipTableAdapter.ClearBeforeFill = True
        '
        'POSPrint
        '
        '
        'SellingUI_TabPageControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.butClientClose)
        Me.Controls.Add(Me.butReset)
        Me.Controls.Add(Me.group_03)
        Me.Controls.Add(Me.group_01)
        Me.Controls.Add(Me.group_02)
        Me.Name = "SellingUI_TabPageControl"
        Me.Size = New System.Drawing.Size(950, 606)
        CType(Me.ProductInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pharmacyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceForSellingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellingPriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactManagementDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RS_Stock_SellingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllStocksForSellingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceInputMaxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RS_Seller_CSeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RS_Prescription_CSeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_03.ResumeLayout(False)
        Me.group_03.PerformLayout()
        Me.group_01.ResumeLayout(False)
        Me.group_01.PerformLayout()
        Me.ProductDetailPopup.ResumeLayout(False)
        Me.groupStock.ResumeLayout(False)
        Me.groupStock.PerformLayout()
        CType(Me.ProductInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_02.ResumeLayout(False)
        Me.groupAll.Panel1.ResumeLayout(False)
        Me.groupAll.Panel2.ResumeLayout(False)
        CType(Me.groupAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupAll.ResumeLayout(False)
        Me.groupA.ResumeLayout(False)
        CType(Me.SListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupB.Panel1.ResumeLayout(False)
        Me.groupB.Panel2.ResumeLayout(False)
        CType(Me.groupB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupB.ResumeLayout(False)
        CType(Me.PrescripDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrescripDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProductInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents pharmacyDataSet As MyApplication.pharmacyDataSet
    Friend WithEvents LocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PriceForSellingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductInfoTableAdapter As MyApplication.pharmacyDataSetTableAdapters.ProductInfoTableAdapter
    Friend WithEvents ProductNameTableAdapter As MyApplication.pharmacyDataSetTableAdapters.ProductNameTableAdapter
    Friend WithEvents ProductUnitTableAdapter As MyApplication.pharmacyDataSetTableAdapters.ProductUnitTableAdapter
    Friend WithEvents LocationTableAdapter As MyApplication.pharmacyDataSetTableAdapters.LocationTableAdapter
    Friend WithEvents TableAdapterManager As MyApplication.pharmacyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InputPriceTableAdapter As MyApplication.pharmacyDataSetTableAdapters.InputPriceTableAdapter
    Friend WithEvents CSeTableAdapter As MyApplication.pharmacyDataSetTableAdapters.CSeTableAdapter
    Friend WithEvents CSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CSTableAdapter As MyApplication.pharmacyDataSetTableAdapters.CSTableAdapter
    Friend WithEvents PriceForSellingTableAdapter As MyApplication.pharmacyDataSetTableAdapters.PriceForSellingTableAdapter
    Friend WithEvents SellingPriceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SellingPriceTableAdapter As MyApplication.pharmacyDataSetTableAdapters.SellingPriceTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Fact_UpdateInsertDeleteTableAdapter1 As MyApplication.factManagementDataSetTableAdapters.Fact_UpdateInsertDeleteTableAdapter
    Friend WithEvents TableAdapterManager_Fact As MyApplication.factManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FactManagementDB As MyApplication.factManagementDataSet
    Friend WithEvents RS_Stock_SellingTableAdapter As MyApplication.pharmacyDataSetTableAdapters.RS_Stock_SellingTableAdapter
    Friend WithEvents RS_Stock_SellingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AllStocksForSellingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AllStocksForSellingTableAdapter As MyApplication.pharmacyDataSetTableAdapters.AllStocksForSellingTableAdapter
    Friend WithEvents PriceInputMaxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PriceInputMaxTableAdapter As MyApplication.pharmacyDataSetTableAdapters.PriceInputMaxTableAdapter
    Friend WithEvents RQOfProductTableAdapter As MyApplication.pharmacyDataSetTableAdapters.RQOfProductTableAdapter
    Friend WithEvents WaitToUpdateRQTableAdapter As MyApplication.pharmacyDataSetTableAdapters.WaitToUpdateRQTableAdapter
    Friend WithEvents RS_Seller_CSeTableAdapter As MyApplication.pharmacyDataSetTableAdapters.RS_Seller_CSeTableAdapter
    Friend WithEvents RS_Seller_CSeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTableAdapter As MyApplication.posprinterDataSetTableAdapters.dataTableAdapter
    Friend WithEvents RS_Prescription_CSeTableAdapter As MyApplication.pharmacyDataSetTableAdapters.RS_Prescription_CSeTableAdapter
    Friend WithEvents RS_Prescription_CSeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents group_03 As System.Windows.Forms.GroupBox
    Friend WithEvents label_lastIdSell As System.Windows.Forms.Label
    Friend WithEvents chkPrinter As System.Windows.Forms.CheckBox
    Friend WithEvents butClientCalcul As System.Windows.Forms.Button
    Friend WithEvents butClientMoney As System.Windows.Forms.Button
    Friend WithEvents txtDiscountPercent As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents butClientEnd As System.Windows.Forms.Button
    Friend WithEvents txtSumReturn As System.Windows.Forms.TextBox
    Friend WithEvents txtSumReception As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents group_01 As System.Windows.Forms.GroupBox
    Friend WithEvents txtClientId As System.Windows.Forms.TextBox
    Friend WithEvents butAddClient As System.Windows.Forms.Button
    Friend WithEvents txtCodingPrescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSeller As System.Windows.Forms.TextBox
    Friend WithEvents ProductDetailPopup As System.Windows.Forms.GroupBox
    Friend WithEvents groupStock As System.Windows.Forms.GroupBox
    Friend WithEvents chkAthenB As System.Windows.Forms.CheckBox
    Friend WithEvents chkB As System.Windows.Forms.CheckBox
    Friend WithEvents chkA As System.Windows.Forms.CheckBox
    Friend WithEvents chkBthenA As System.Windows.Forms.CheckBox
    Friend WithEvents butClosePopup As System.Windows.Forms.Button
    Friend WithEvents ProductInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents colProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdProdInfo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCodingBarOrig As System.Windows.Forms.TextBox
    Friend WithEvents cmbPrice As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSellingUnit As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents butOK As System.Windows.Forms.Button
    Friend WithEvents txtQuant As System.Windows.Forms.TextBox
    Friend WithEvents group_02 As System.Windows.Forms.GroupBox
    Friend WithEvents groupAll As System.Windows.Forms.SplitContainer
    Friend WithEvents groupA As System.Windows.Forms.GroupBox
    Friend WithEvents SListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents colSTT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProdName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdProd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdSPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRatio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrescripDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents colProdName_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQ_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnit_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdProd_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStock_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQOut_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdSPrice_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdStock_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRatio_Cache As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyPrescripOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrescripDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents colPrescripOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrescripName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrescripPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrescripQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrescripAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrescripId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents butDelLine As System.Windows.Forms.Button
    Friend WithEvents butCorrect As System.Windows.Forms.Button
    Friend WithEvents butDiscount As System.Windows.Forms.Button
    Friend WithEvents CipTableAdapter As MyApplication.pharmacyDataSetTableAdapters.CIPTableAdapter
    Friend WithEvents butReset As System.Windows.Forms.Button
    Friend WithEvents butClientClose As System.Windows.Forms.Button
    Friend WithEvents butPrescription As System.Windows.Forms.Button
    Friend WithEvents butDown As System.Windows.Forms.Button
    Friend WithEvents butLeft As System.Windows.Forms.Button
    Friend WithEvents butRight As System.Windows.Forms.Button
    Friend WithEvents butUp As System.Windows.Forms.Button
    Friend WithEvents groupB As System.Windows.Forms.SplitContainer
    Friend WithEvents butRePrint As Button
    Friend WithEvents POSPrint As Printing.PrintDocument
    Friend WithEvents butKeyboard_Presc As System.Windows.Forms.Button
    Friend WithEvents butKeyboard_Productname As System.Windows.Forms.Button
    Friend WithEvents butKeyboard_BarCode As System.Windows.Forms.Button
End Class
