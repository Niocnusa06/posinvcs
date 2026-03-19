<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SKUBarcodee = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Qty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SubTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Total = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PrintButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ClearButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SubmitItemButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ReceiptNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Hold = New Guna.UI2.WinForms.Guna2Button()
        Me.ViewHold = New Guna.UI2.WinForms.Guna2Button()
        Me.HoldPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.ReturnTransaction = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ListPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTime = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CashIn = New Guna.UI2.WinForms.Guna2Panel()
        Me.Cash = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Okaay = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DiscountTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HoldPanel.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CashIn.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SKUBarcodee
        '
        Me.SKUBarcodee.BorderColor = System.Drawing.Color.DimGray
        Me.SKUBarcodee.BorderRadius = 6
        Me.SKUBarcodee.BorderThickness = 2
        Me.SKUBarcodee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SKUBarcodee.DefaultText = ""
        Me.SKUBarcodee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SKUBarcodee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SKUBarcodee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SKUBarcodee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SKUBarcodee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SKUBarcodee.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.SKUBarcodee.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SKUBarcodee.Location = New System.Drawing.Point(31, 217)
        Me.SKUBarcodee.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SKUBarcodee.Name = "SKUBarcodee"
        Me.SKUBarcodee.PlaceholderText = ""
        Me.SKUBarcodee.SelectedText = ""
        Me.SKUBarcodee.Size = New System.Drawing.Size(713, 58)
        Me.SKUBarcodee.TabIndex = 1
        '
        'ItemName
        '
        Me.ItemName.BorderColor = System.Drawing.Color.DimGray
        Me.ItemName.BorderRadius = 6
        Me.ItemName.BorderThickness = 2
        Me.ItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ItemName.DefaultText = ""
        Me.ItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.ItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemName.Location = New System.Drawing.Point(31, 334)
        Me.ItemName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.PlaceholderText = ""
        Me.ItemName.SelectedText = ""
        Me.ItemName.Size = New System.Drawing.Size(713, 58)
        Me.ItemName.TabIndex = 2
        '
        'Qty
        '
        Me.Qty.BorderColor = System.Drawing.Color.DimGray
        Me.Qty.BorderRadius = 6
        Me.Qty.BorderThickness = 2
        Me.Qty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Qty.DefaultText = ""
        Me.Qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Qty.Location = New System.Drawing.Point(31, 452)
        Me.Qty.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Qty.Name = "Qty"
        Me.Qty.PlaceholderText = ""
        Me.Qty.SelectedText = ""
        Me.Qty.Size = New System.Drawing.Size(323, 58)
        Me.Qty.TabIndex = 3
        '
        'Price
        '
        Me.Price.BorderColor = System.Drawing.Color.DimGray
        Me.Price.BorderRadius = 6
        Me.Price.BorderThickness = 2
        Me.Price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Price.DefaultText = ""
        Me.Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Price.Location = New System.Drawing.Point(421, 452)
        Me.Price.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Price.Name = "Price"
        Me.Price.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Price.PlaceholderText = "₱ 0.00"
        Me.Price.ReadOnly = True
        Me.Price.SelectedText = ""
        Me.Price.Size = New System.Drawing.Size(323, 58)
        Me.Price.TabIndex = 4
        '
        'SubTotal
        '
        Me.SubTotal.BorderColor = System.Drawing.Color.DimGray
        Me.SubTotal.BorderRadius = 6
        Me.SubTotal.BorderThickness = 2
        Me.SubTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubTotal.DefaultText = ""
        Me.SubTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SubTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SubTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubTotal.Location = New System.Drawing.Point(31, 570)
        Me.SubTotal.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubTotal.PlaceholderText = "₱ 0.00"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.SelectedText = ""
        Me.SubTotal.Size = New System.Drawing.Size(713, 58)
        Me.SubTotal.TabIndex = 5
        '
        'Total
        '
        Me.Total.BorderColor = System.Drawing.Color.Red
        Me.Total.BorderRadius = 6
        Me.Total.BorderThickness = 2
        Me.Total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Total.DefaultText = ""
        Me.Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Total.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.Red
        Me.Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Total.Location = New System.Drawing.Point(1458, 932)
        Me.Total.Margin = New System.Windows.Forms.Padding(10, 15, 10, 15)
        Me.Total.Name = "Total"
        Me.Total.PlaceholderForeColor = System.Drawing.Color.Red
        Me.Total.PlaceholderText = "₱ 0.00"
        Me.Total.ReadOnly = True
        Me.Total.SelectedText = ""
        Me.Total.Size = New System.Drawing.Size(416, 60)
        Me.Total.TabIndex = 6
        '
        'PrintButton
        '
        Me.PrintButton.BorderColor = System.Drawing.Color.SkyBlue
        Me.PrintButton.BorderRadius = 6
        Me.PrintButton.BorderThickness = 3
        Me.PrintButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PrintButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PrintButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PrintButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PrintButton.FillColor = System.Drawing.Color.SkyBlue
        Me.PrintButton.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.PrintButton.ForeColor = System.Drawing.Color.DarkBlue
        Me.PrintButton.Location = New System.Drawing.Point(31, 797)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(339, 76)
        Me.PrintButton.TabIndex = 7
        Me.PrintButton.Text = "PRINT RECEIPT"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(31, 177)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(48, 33)
        Me.Guna2HtmlLabel1.TabIndex = 10
        Me.Guna2HtmlLabel1.Text = "SKU"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(31, 288)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(121, 33)
        Me.Guna2HtmlLabel2.TabIndex = 11
        Me.Guna2HtmlLabel2.Text = "Item Name"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(31, 412)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(41, 33)
        Me.Guna2HtmlLabel3.TabIndex = 12
        Me.Guna2HtmlLabel3.Text = "Qty"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(421, 412)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(111, 33)
        Me.Guna2HtmlLabel4.TabIndex = 13
        Me.Guna2HtmlLabel4.Text = "Item Price"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(31, 530)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(95, 33)
        Me.Guna2HtmlLabel5.TabIndex = 14
        Me.Guna2HtmlLabel5.Text = "Subtotal"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(1305, 936)
        Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(136, 56)
        Me.Guna2HtmlLabel6.TabIndex = 15
        Me.Guna2HtmlLabel6.Text = "TOTAL"
        '
        'ClearButton
        '
        Me.ClearButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClearButton.BorderRadius = 6
        Me.ClearButton.BorderThickness = 3
        Me.ClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ClearButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.ClearButton.ForeColor = System.Drawing.Color.DarkRed
        Me.ClearButton.Location = New System.Drawing.Point(31, 907)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(339, 76)
        Me.ClearButton.TabIndex = 16
        Me.ClearButton.Text = "CLEAR ORDER LIST"
        '
        'SubmitItemButton
        '
        Me.SubmitItemButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SubmitItemButton.BorderRadius = 6
        Me.SubmitItemButton.BorderThickness = 3
        Me.SubmitItemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SubmitItemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SubmitItemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SubmitItemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SubmitItemButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SubmitItemButton.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.SubmitItemButton.ForeColor = System.Drawing.Color.DarkGreen
        Me.SubmitItemButton.Location = New System.Drawing.Point(405, 797)
        Me.SubmitItemButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SubmitItemButton.Name = "SubmitItemButton"
        Me.SubmitItemButton.Size = New System.Drawing.Size(339, 76)
        Me.SubmitItemButton.TabIndex = 17
        Me.SubmitItemButton.Text = "SUBMIT"
        '
        'ReceiptNumber
        '
        Me.ReceiptNumber.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.ReceiptNumber.BorderRadius = 6
        Me.ReceiptNumber.BorderThickness = 2
        Me.ReceiptNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ReceiptNumber.DefaultText = ""
        Me.ReceiptNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ReceiptNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ReceiptNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ReceiptNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ReceiptNumber.FillColor = System.Drawing.Color.WhiteSmoke
        Me.ReceiptNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReceiptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptNumber.ForeColor = System.Drawing.Color.Black
        Me.ReceiptNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReceiptNumber.Location = New System.Drawing.Point(775, 84)
        Me.ReceiptNumber.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ReceiptNumber.Name = "ReceiptNumber"
        Me.ReceiptNumber.PlaceholderText = ""
        Me.ReceiptNumber.ReadOnly = True
        Me.ReceiptNumber.SelectedText = ""
        Me.ReceiptNumber.Size = New System.Drawing.Size(297, 49)
        Me.ReceiptNumber.TabIndex = 18
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1904, 48)
        Me.Panel1.TabIndex = 20
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.posinvcs.My.Resources.Resources.logout1
        Me.PictureBox3.Location = New System.Drawing.Point(1842, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.posinvcs.My.Resources.Resources._3671090
        Me.PictureBox2.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI Historic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(74, 9)
        Me.Guna2HtmlLabel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(78, 32)
        Me.Guna2HtmlLabel8.TabIndex = 12
        Me.Guna2HtmlLabel8.Text = "Cashier"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1790, 4)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(52, 41)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Hold
        '
        Me.Hold.BackColor = System.Drawing.Color.Transparent
        Me.Hold.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Hold.BorderRadius = 6
        Me.Hold.BorderThickness = 3
        Me.Hold.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Hold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Hold.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Hold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Hold.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Hold.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Hold.ForeColor = System.Drawing.Color.Olive
        Me.Hold.Location = New System.Drawing.Point(405, 907)
        Me.Hold.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Hold.Name = "Hold"
        Me.Hold.Size = New System.Drawing.Size(339, 76)
        Me.Hold.TabIndex = 22
        Me.Hold.Text = "HOLD"
        '
        'ViewHold
        '
        Me.ViewHold.BorderColor = System.Drawing.Color.DimGray
        Me.ViewHold.BorderRadius = 6
        Me.ViewHold.BorderThickness = 2
        Me.ViewHold.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ViewHold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ViewHold.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ViewHold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ViewHold.FillColor = System.Drawing.Color.DimGray
        Me.ViewHold.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ViewHold.ForeColor = System.Drawing.Color.White
        Me.ViewHold.Location = New System.Drawing.Point(1629, 89)
        Me.ViewHold.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ViewHold.Name = "ViewHold"
        Me.ViewHold.Size = New System.Drawing.Size(237, 44)
        Me.ViewHold.TabIndex = 23
        Me.ViewHold.Text = "VIEW HOLD"
        '
        'HoldPanel
        '
        Me.HoldPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.HoldPanel.Controls.Add(Me.ReturnTransaction)
        Me.HoldPanel.Controls.Add(Me.DataGridView2)
        Me.HoldPanel.Location = New System.Drawing.Point(1155, 59)
        Me.HoldPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HoldPanel.Name = "HoldPanel"
        Me.HoldPanel.Size = New System.Drawing.Size(749, 946)
        Me.HoldPanel.TabIndex = 24
        '
        'ReturnTransaction
        '
        Me.ReturnTransaction.BorderColor = System.Drawing.Color.DimGray
        Me.ReturnTransaction.BorderRadius = 6
        Me.ReturnTransaction.BorderThickness = 2
        Me.ReturnTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ReturnTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ReturnTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ReturnTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ReturnTransaction.FillColor = System.Drawing.Color.DimGray
        Me.ReturnTransaction.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnTransaction.ForeColor = System.Drawing.Color.White
        Me.ReturnTransaction.Location = New System.Drawing.Point(43, 15)
        Me.ReturnTransaction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReturnTransaction.Name = "ReturnTransaction"
        Me.ReturnTransaction.Size = New System.Drawing.Size(252, 44)
        Me.ReturnTransaction.TabIndex = 24
        Me.ReturnTransaction.Text = "RETURN TRANSACTION"
        Me.ReturnTransaction.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'DataGridView2
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(43, 78)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(1804, 831)
        Me.DataGridView2.TabIndex = 1
        '
        'ListPanel
        '
        Me.ListPanel.AutoRoundedCorners = True
        Me.ListPanel.AutoScroll = True
        Me.ListPanel.BackColor = System.Drawing.Color.White
        Me.ListPanel.BorderRadius = 381
        Me.ListPanel.Location = New System.Drawing.Point(779, 150)
        Me.ListPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.Size = New System.Drawing.Size(1091, 765)
        Me.ListPanel.TabIndex = 25
        '
        'PrintDocument2
        '
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.Location = New System.Drawing.Point(779, 927)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 33)
        Me.lblDate.TabIndex = 26
        Me.lblDate.Text = "Date"
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(779, 959)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(56, 33)
        Me.lblTime.TabIndex = 27
        Me.lblTime.Text = "Time"
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 1000
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(31, 648)
        Me.Guna2HtmlLabel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(99, 33)
        Me.Guna2HtmlLabel7.TabIndex = 29
        Me.Guna2HtmlLabel7.Text = "Discount"
        '
        'CashIn
        '
        Me.CashIn.Controls.Add(Me.Cash)
        Me.CashIn.Controls.Add(Me.Cancel)
        Me.CashIn.Controls.Add(Me.Okaay)
        Me.CashIn.Controls.Add(Me.Label2)
        Me.CashIn.Controls.Add(Me.Guna2Panel2)
        Me.CashIn.Location = New System.Drawing.Point(620, 389)
        Me.CashIn.Name = "CashIn"
        Me.CashIn.Size = New System.Drawing.Size(614, 303)
        Me.CashIn.TabIndex = 30
        Me.CashIn.Visible = False
        '
        'Cash
        '
        Me.Cash.BorderColor = System.Drawing.Color.DimGray
        Me.Cash.BorderRadius = 6
        Me.Cash.BorderThickness = 2
        Me.Cash.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cash.DefaultText = ""
        Me.Cash.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Cash.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Cash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Cash.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Cash.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cash.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cash.Location = New System.Drawing.Point(21, 234)
        Me.Cash.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Cash.Name = "Cash"
        Me.Cash.PlaceholderText = ""
        Me.Cash.SelectedText = ""
        Me.Cash.Size = New System.Drawing.Size(553, 58)
        Me.Cash.TabIndex = 34
        '
        'Cancel
        '
        Me.Cancel.BorderColor = System.Drawing.Color.Red
        Me.Cancel.BorderRadius = 6
        Me.Cancel.BorderThickness = 3
        Me.Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Cancel.FillColor = System.Drawing.Color.Salmon
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Cancel.ForeColor = System.Drawing.Color.SeaShell
        Me.Cancel.Location = New System.Drawing.Point(454, 141)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(120, 46)
        Me.Cancel.TabIndex = 33
        Me.Cancel.Text = "CANCEL"
        '
        'Okaay
        '
        Me.Okaay.BorderColor = System.Drawing.Color.SkyBlue
        Me.Okaay.BorderRadius = 6
        Me.Okaay.BorderThickness = 3
        Me.Okaay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Okaay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Okaay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Okaay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Okaay.FillColor = System.Drawing.Color.LightYellow
        Me.Okaay.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Okaay.ForeColor = System.Drawing.Color.DarkBlue
        Me.Okaay.Location = New System.Drawing.Point(455, 75)
        Me.Okaay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Okaay.Name = "Okaay"
        Me.Okaay.Size = New System.Drawing.Size(119, 46)
        Me.Okaay.TabIndex = 31
        Me.Okaay.Text = "OK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Cash Received:"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(614, 55)
        Me.Guna2Panel2.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cash Payment"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.BorderColor = System.Drawing.Color.DimGray
        Me.DiscountTextBox.BorderRadius = 6
        Me.DiscountTextBox.BorderThickness = 2
        Me.DiscountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DiscountTextBox.DefaultText = ""
        Me.DiscountTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DiscountTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DiscountTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DiscountTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DiscountTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.DiscountTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscountTextBox.Location = New System.Drawing.Point(31, 700)
        Me.DiscountTextBox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.PlaceholderText = ""
        Me.DiscountTextBox.SelectedText = ""
        Me.DiscountTextBox.Size = New System.Drawing.Size(713, 58)
        Me.DiscountTextBox.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.posinvcs.My.Resources.Resources._556908340_680084718110318_4498664925219955537_n
        Me.PictureBox1.Location = New System.Drawing.Point(237, 59)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1904, 1016)
        Me.Controls.Add(Me.HoldPanel)
        Me.Controls.Add(Me.DiscountTextBox)
        Me.Controls.Add(Me.CashIn)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.ViewHold)
        Me.Controls.Add(Me.Hold)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ReceiptNumber)
        Me.Controls.Add(Me.SubmitItemButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.SubTotal)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Qty)
        Me.Controls.Add(Me.ItemName)
        Me.Controls.Add(Me.SKUBarcodee)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.ListPanel)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HoldPanel.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CashIn.ResumeLayout(False)
        Me.CashIn.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SKUBarcodee As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Qty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SubTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Total As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PrintButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ClearButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SubmitItemButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ReceiptNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Hold As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ViewHold As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents HoldPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ReturnTransaction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ListPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTime As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tmrClock As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CashIn As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Okaay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DiscountTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Cash As Guna.UI2.WinForms.Guna2TextBox
End Class
