<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sales
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.dgvsales = New System.Windows.Forms.DataGridView()
        Me.headdashlbl = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.todaysales = New System.Windows.Forms.Label()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.monthsales = New System.Windows.Forms.Label()
        Me.Guna2Elipse5 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse6 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.dtpfrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpto = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnpdf = New Guna.UI2.WinForms.Guna2Button()
        Me.excelbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.FILTERBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.searchtb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.alertpdfinv = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.dgvsales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.alertpdfinv.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'dgvsales
        '
        Me.dgvsales.AllowUserToAddRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvsales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvsales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvsales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvsales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsales.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvsales.EnableHeadersVisualStyles = False
        Me.dgvsales.GridColor = System.Drawing.Color.LightGray
        Me.dgvsales.Location = New System.Drawing.Point(28, 197)
        Me.dgvsales.Name = "dgvsales"
        Me.dgvsales.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsales.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvsales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        Me.dgvsales.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvsales.RowTemplate.Height = 40
        Me.dgvsales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsales.Size = New System.Drawing.Size(1539, 764)
        Me.dgvsales.TabIndex = 13
        '
        'headdashlbl
        '
        Me.headdashlbl.AutoSize = True
        Me.headdashlbl.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headdashlbl.Location = New System.Drawing.Point(706, 19)
        Me.headdashlbl.Name = "headdashlbl"
        Me.headdashlbl.Size = New System.Drawing.Size(123, 34)
        Me.headdashlbl.TabIndex = 14
        Me.headdashlbl.Text = "S A L E S"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2Panel1.Controls.Add(Me.todaysales)
        Me.Guna2Panel1.Location = New System.Drawing.Point(29, 83)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(149, 102)
        Me.Guna2Panel1.TabIndex = 15
        '
        'todaysales
        '
        Me.todaysales.AutoSize = True
        Me.todaysales.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todaysales.Location = New System.Drawing.Point(22, 60)
        Me.todaysales.Name = "todaysales"
        Me.todaysales.Size = New System.Drawing.Size(50, 26)
        Me.todaysales.TabIndex = 23
        Me.todaysales.Text = "0.00"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 20
        Me.Guna2Elipse2.TargetControl = Me.Guna2Panel1
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 20
        Me.Guna2Elipse3.TargetControl = Me.Guna2Panel3
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Guna2Panel3.Controls.Add(Me.Label2)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Location = New System.Drawing.Point(28, 83)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(150, 39)
        Me.Guna2Panel3.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 26)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "TODAY SALES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 26)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "TODAY SALES"
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 20
        Me.Guna2Elipse4.TargetControl = Me.Guna2Panel3
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Location = New System.Drawing.Point(200, 83)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(161, 39)
        Me.Guna2Panel2.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "MONTHLY SALES"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2Panel4.Controls.Add(Me.monthsales)
        Me.Guna2Panel4.Location = New System.Drawing.Point(201, 83)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(160, 102)
        Me.Guna2Panel4.TabIndex = 19
        '
        'monthsales
        '
        Me.monthsales.AutoSize = True
        Me.monthsales.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthsales.Location = New System.Drawing.Point(24, 58)
        Me.monthsales.Name = "monthsales"
        Me.monthsales.Size = New System.Drawing.Size(50, 26)
        Me.monthsales.TabIndex = 24
        Me.monthsales.Text = "0.00"
        '
        'Guna2Elipse5
        '
        Me.Guna2Elipse5.BorderRadius = 20
        Me.Guna2Elipse5.TargetControl = Me.Guna2Panel4
        '
        'Guna2Elipse6
        '
        Me.Guna2Elipse6.BorderRadius = 20
        Me.Guna2Elipse6.TargetControl = Me.Guna2Panel2
        '
        'dtpfrom
        '
        Me.dtpfrom.Checked = True
        Me.dtpfrom.FillColor = System.Drawing.Color.White
        Me.dtpfrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpfrom.Location = New System.Drawing.Point(872, 143)
        Me.dtpfrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpfrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(217, 42)
        Me.dtpfrom.TabIndex = 21
        Me.dtpfrom.Value = New Date(2025, 11, 13, 5, 18, 35, 263)
        '
        'dtpto
        '
        Me.dtpto.Checked = True
        Me.dtpto.FillColor = System.Drawing.Color.White
        Me.dtpto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpto.Location = New System.Drawing.Point(1095, 143)
        Me.dtpto.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpto.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(217, 42)
        Me.dtpto.TabIndex = 22
        Me.dtpto.Value = New Date(2025, 11, 13, 5, 18, 35, 263)
        '
        'btnpdf
        '
        Me.btnpdf.BorderRadius = 7
        Me.btnpdf.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnpdf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnpdf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnpdf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnpdf.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnpdf.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnpdf.ForeColor = System.Drawing.Color.Black
        Me.btnpdf.Location = New System.Drawing.Point(376, 141)
        Me.btnpdf.Name = "btnpdf"
        Me.btnpdf.Size = New System.Drawing.Size(237, 44)
        Me.btnpdf.TabIndex = 23
        Me.btnpdf.Text = "EXPORT TO PDF"
        '
        'excelbtn
        '
        Me.excelbtn.BorderRadius = 7
        Me.excelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.excelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.excelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.excelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.excelbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.excelbtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.excelbtn.ForeColor = System.Drawing.Color.Black
        Me.excelbtn.Location = New System.Drawing.Point(376, 83)
        Me.excelbtn.Name = "excelbtn"
        Me.excelbtn.Size = New System.Drawing.Size(237, 44)
        Me.excelbtn.TabIndex = 24
        Me.excelbtn.Text = "EXPORT TO EXCEL"
        '
        'FILTERBTN
        '
        Me.FILTERBTN.BorderColor = System.Drawing.Color.Gray
        Me.FILTERBTN.BorderRadius = 8
        Me.FILTERBTN.BorderThickness = 2
        Me.FILTERBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.FILTERBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.FILTERBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.FILTERBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.FILTERBTN.FillColor = System.Drawing.Color.Gainsboro
        Me.FILTERBTN.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.FILTERBTN.ForeColor = System.Drawing.Color.Black
        Me.FILTERBTN.Location = New System.Drawing.Point(1327, 141)
        Me.FILTERBTN.Name = "FILTERBTN"
        Me.FILTERBTN.Size = New System.Drawing.Size(237, 44)
        Me.FILTERBTN.TabIndex = 25
        Me.FILTERBTN.Text = "FILTER"
        '
        'searchtb
        '
        Me.searchtb.BackColor = System.Drawing.Color.WhiteSmoke
        Me.searchtb.BorderColor = System.Drawing.Color.DimGray
        Me.searchtb.BorderRadius = 7
        Me.searchtb.BorderThickness = 2
        Me.searchtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchtb.DefaultText = ""
        Me.searchtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchtb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.searchtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchtb.IconLeft = Global.posinvcs.My.Resources.Resources.search__1_
        Me.searchtb.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.searchtb.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.searchtb.Location = New System.Drawing.Point(1194, 83)
        Me.searchtb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.PlaceholderText = ""
        Me.searchtb.SelectedText = ""
        Me.searchtb.Size = New System.Drawing.Size(373, 43)
        Me.searchtb.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1092, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 17)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "TO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(869, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "FROM"
        '
        'alertpdfinv
        '
        Me.alertpdfinv.Controls.Add(Me.PictureBox1)
        Me.alertpdfinv.Controls.Add(Me.Button2)
        Me.alertpdfinv.Controls.Add(Me.Label23)
        Me.alertpdfinv.Controls.Add(Me.Panel2)
        Me.alertpdfinv.Location = New System.Drawing.Point(590, 371)
        Me.alertpdfinv.Name = "alertpdfinv"
        Me.alertpdfinv.Size = New System.Drawing.Size(412, 244)
        Me.alertpdfinv.TabIndex = 55
        Me.alertpdfinv.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.posinvcs.My.Resources.Resources.icons8_success
        Me.PictureBox1.Location = New System.Drawing.Point(53, 78)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(36, 193)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(344, 28)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(125, 90)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(219, 48)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "Report Successfully" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Exported!"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(412, 42)
        Me.Panel2.TabIndex = 49
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Lucida Fax", 13.0!)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(16, 11)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(122, 21)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Sales Report"
        '
        'sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1593, 986)
        Me.Controls.Add(Me.alertpdfinv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FILTERBTN)
        Me.Controls.Add(Me.excelbtn)
        Me.Controls.Add(Me.btnpdf)
        Me.Controls.Add(Me.dtpto)
        Me.Controls.Add(Me.dtpfrom)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.headdashlbl)
        Me.Controls.Add(Me.dgvsales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sales"
        Me.Text = "sales"
        CType(Me.dgvsales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.alertpdfinv.ResumeLayout(False)
        Me.alertpdfinv.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents dgvsales As DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents headdashlbl As Label
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents searchtb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse5 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse6 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpto As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpfrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnpdf As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents todaysales As Label
    Friend WithEvents monthsales As Label
    Friend WithEvents excelbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FILTERBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents alertpdfinv As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label21 As Label
End Class
