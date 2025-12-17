<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSKU = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblCurrentQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSaveStockIn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lblCategory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_back = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.dgvStockHistory = New System.Windows.Forms.DataGridView()
        Me.stockinalert = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgvStockHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stockinalert.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(334, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "STOCK-IN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "SKU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 260)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 325)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Current Quantity"
        '
        'lblSKU
        '
        Me.lblSKU.Animated = True
        Me.lblSKU.BorderColor = System.Drawing.Color.DimGray
        Me.lblSKU.BorderRadius = 8
        Me.lblSKU.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSKU.DefaultText = ""
        Me.lblSKU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblSKU.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblSKU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblSKU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblSKU.FillColor = System.Drawing.Color.Gainsboro
        Me.lblSKU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSKU.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblSKU.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSKU.Location = New System.Drawing.Point(34, 88)
        Me.lblSKU.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lblSKU.Name = "lblSKU"
        Me.lblSKU.PlaceholderText = ""
        Me.lblSKU.ReadOnly = True
        Me.lblSKU.SelectedText = ""
        Me.lblSKU.Size = New System.Drawing.Size(306, 36)
        Me.lblSKU.TabIndex = 12
        '
        'lblItemName
        '
        Me.lblItemName.Animated = True
        Me.lblItemName.BorderColor = System.Drawing.Color.DimGray
        Me.lblItemName.BorderRadius = 7
        Me.lblItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblItemName.DefaultText = ""
        Me.lblItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblItemName.FillColor = System.Drawing.Color.Gainsboro
        Me.lblItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblItemName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblItemName.Location = New System.Drawing.Point(34, 153)
        Me.lblItemName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.PlaceholderText = ""
        Me.lblItemName.ReadOnly = True
        Me.lblItemName.SelectedText = ""
        Me.lblItemName.Size = New System.Drawing.Size(306, 36)
        Me.lblItemName.TabIndex = 13
        '
        'lblPrice
        '
        Me.lblPrice.Animated = True
        Me.lblPrice.BorderColor = System.Drawing.Color.DimGray
        Me.lblPrice.BorderRadius = 7
        Me.lblPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblPrice.DefaultText = ""
        Me.lblPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblPrice.FillColor = System.Drawing.Color.Gainsboro
        Me.lblPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(34, 283)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.PlaceholderText = ""
        Me.lblPrice.ReadOnly = True
        Me.lblPrice.SelectedText = ""
        Me.lblPrice.Size = New System.Drawing.Size(306, 36)
        Me.lblPrice.TabIndex = 14
        '
        'lblCurrentQty
        '
        Me.lblCurrentQty.Animated = True
        Me.lblCurrentQty.BorderColor = System.Drawing.Color.DimGray
        Me.lblCurrentQty.BorderRadius = 7
        Me.lblCurrentQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblCurrentQty.DefaultText = ""
        Me.lblCurrentQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblCurrentQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblCurrentQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblCurrentQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblCurrentQty.FillColor = System.Drawing.Color.Gainsboro
        Me.lblCurrentQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCurrentQty.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCurrentQty.Location = New System.Drawing.Point(34, 348)
        Me.lblCurrentQty.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lblCurrentQty.Name = "lblCurrentQty"
        Me.lblCurrentQty.PlaceholderText = ""
        Me.lblCurrentQty.ReadOnly = True
        Me.lblCurrentQty.SelectedText = ""
        Me.lblCurrentQty.Size = New System.Drawing.Size(306, 36)
        Me.lblCurrentQty.TabIndex = 15
        '
        'btnSaveStockIn
        '
        Me.btnSaveStockIn.Animated = True
        Me.btnSaveStockIn.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveStockIn.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnSaveStockIn.BorderRadius = 7
        Me.btnSaveStockIn.BorderThickness = 1
        Me.btnSaveStockIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveStockIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveStockIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaveStockIn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaveStockIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSaveStockIn.FillColor = System.Drawing.Color.SkyBlue
        Me.btnSaveStockIn.FillColor2 = System.Drawing.Color.SkyBlue
        Me.btnSaveStockIn.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveStockIn.ForeColor = System.Drawing.Color.Black
        Me.btnSaveStockIn.Location = New System.Drawing.Point(34, 463)
        Me.btnSaveStockIn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveStockIn.Name = "btnSaveStockIn"
        Me.btnSaveStockIn.Size = New System.Drawing.Size(306, 38)
        Me.btnSaveStockIn.TabIndex = 16
        Me.btnSaveStockIn.Text = "ADD NEW STOCK"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'lblCategory
        '
        Me.lblCategory.Animated = True
        Me.lblCategory.BorderColor = System.Drawing.Color.DimGray
        Me.lblCategory.BorderRadius = 7
        Me.lblCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblCategory.DefaultText = ""
        Me.lblCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblCategory.FillColor = System.Drawing.Color.Gainsboro
        Me.lblCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(34, 218)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.PlaceholderText = ""
        Me.lblCategory.ReadOnly = True
        Me.lblCategory.SelectedText = ""
        Me.lblCategory.Size = New System.Drawing.Size(306, 36)
        Me.lblCategory.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 195)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Category"
        '
        'txtAddQty
        '
        Me.txtAddQty.Animated = True
        Me.txtAddQty.BorderColor = System.Drawing.Color.DimGray
        Me.txtAddQty.BorderRadius = 7
        Me.txtAddQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddQty.DefaultText = ""
        Me.txtAddQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddQty.FillColor = System.Drawing.Color.Gainsboro
        Me.txtAddQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddQty.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtAddQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddQty.Location = New System.Drawing.Point(34, 413)
        Me.txtAddQty.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAddQty.Name = "txtAddQty"
        Me.txtAddQty.PlaceholderText = ""
        Me.txtAddQty.SelectedText = ""
        Me.txtAddQty.Size = New System.Drawing.Size(306, 36)
        Me.txtAddQty.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 390)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Add Quantity"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel1.Controls.Add(Me.btn_back)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(779, 41)
        Me.Guna2Panel1.TabIndex = 23
        '
        'btn_back
        '
        Me.btn_back.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_back.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_back.Image = Global.posinvcs.My.Resources.Resources.back
        Me.btn_back.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_back.ImageRotate = 0!
        Me.btn_back.ImageSize = New System.Drawing.Size(100, 100)
        Me.btn_back.Location = New System.Drawing.Point(670, 3)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_back.Size = New System.Drawing.Size(106, 37)
        Me.btn_back.TabIndex = 24
        '
        'dgvStockHistory
        '
        Me.dgvStockHistory.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvStockHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStockHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStockHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStockHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStockHistory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStockHistory.EnableHeadersVisualStyles = False
        Me.dgvStockHistory.GridColor = System.Drawing.Color.LightGray
        Me.dgvStockHistory.Location = New System.Drawing.Point(367, 67)
        Me.dgvStockHistory.Name = "dgvStockHistory"
        Me.dgvStockHistory.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStockHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgvStockHistory.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStockHistory.RowTemplate.Height = 40
        Me.dgvStockHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockHistory.Size = New System.Drawing.Size(387, 434)
        Me.dgvStockHistory.TabIndex = 24
        '
        'stockinalert
        '
        Me.stockinalert.Controls.Add(Me.Guna2Panel3)
        Me.stockinalert.Controls.Add(Me.Button2)
        Me.stockinalert.Controls.Add(Me.Label6)
        Me.stockinalert.Controls.Add(Me.PictureBox1)
        Me.stockinalert.Location = New System.Drawing.Point(206, 153)
        Me.stockinalert.Name = "stockinalert"
        Me.stockinalert.Size = New System.Drawing.Size(381, 231)
        Me.stockinalert.TabIndex = 25
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel3.Controls.Add(Me.Label9)
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(381, 36)
        Me.Guna2Panel3.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Fax", 13.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(7, 8)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 21)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Stock In"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(18, 178)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(344, 28)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(73, 137)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(243, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Stock-in recorded successfully."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.posinvcs.My.Resources.Resources.icons8_success
        Me.PictureBox1.Location = New System.Drawing.Point(162, 63)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'stockin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(779, 525)
        Me.Controls.Add(Me.stockinalert)
        Me.Controls.Add(Me.dgvStockHistory)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.txtAddQty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSaveStockIn)
        Me.Controls.Add(Me.lblCurrentQty)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.lblSKU)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(121, 96)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "stockin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Stock"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.dgvStockHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stockinalert.ResumeLayout(False)
        Me.stockinalert.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSKU As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCurrentQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSaveStockIn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents dgvStockHistory As DataGridView
    Friend WithEvents stockinalert As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label9 As Label
End Class
