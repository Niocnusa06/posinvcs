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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Hold = New Guna.UI2.WinForms.Guna2Button()
        Me.ViewHold = New Guna.UI2.WinForms.Guna2Button()
        Me.HoldPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.ReturnTransaction = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ListPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HoldPanel.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ItemName.Location = New System.Drawing.Point(31, 352)
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
        Me.Qty.Location = New System.Drawing.Point(31, 487)
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
        Me.Price.Location = New System.Drawing.Point(421, 487)
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
        Me.SubTotal.Location = New System.Drawing.Point(31, 622)
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
        Me.PrintButton.Location = New System.Drawing.Point(31, 785)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(339, 88)
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
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(31, 306)
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
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(31, 447)
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
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(421, 447)
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
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(31, 582)
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
        Me.ClearButton.Location = New System.Drawing.Point(31, 895)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(339, 88)
        Me.ClearButton.TabIndex = 16
        Me.ClearButton.Text = "CLEAR FORM"
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
        Me.SubmitItemButton.Location = New System.Drawing.Point(405, 785)
        Me.SubmitItemButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SubmitItemButton.Name = "SubmitItemButton"
        Me.SubmitItemButton.Size = New System.Drawing.Size(339, 88)
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.posinvcs.My.Resources.Resources._556908340_680084718110318_4498664925219955537_n
        Me.PictureBox1.Location = New System.Drawing.Point(14, 62)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1904, 48)
        Me.Panel1.TabIndex = 20
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
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Black
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1859, 4)
        Me.Guna2ControlBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(41, 41)
        Me.Guna2ControlBox3.TabIndex = 2
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1812, 4)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(41, 41)
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
        Me.Hold.Location = New System.Drawing.Point(405, 895)
        Me.Hold.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Hold.Name = "Hold"
        Me.Hold.Size = New System.Drawing.Size(339, 88)
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
        Me.HoldPanel.Location = New System.Drawing.Point(12, 59)
        Me.HoldPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HoldPanel.Name = "HoldPanel"
        Me.HoldPanel.Size = New System.Drawing.Size(1883, 943)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(43, 78)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1904, 1016)
        Me.Controls.Add(Me.HoldPanel)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HoldPanel.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
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

End Class
