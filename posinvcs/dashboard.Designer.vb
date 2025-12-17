<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _1dashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.headdashlbl = New System.Windows.Forms.Label()
        Me.TotalSaleSum = New System.Windows.Forms.Label()
        Me.TotalStockInSum = New System.Windows.Forms.Label()
        Me.DGV_LowStock = New System.Windows.Forms.DataGridView()
        Me.CategoriesPanel = New System.Windows.Forms.Panel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totaldmg = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.dtTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.chartBestCategory = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2CustomGradientPanel4 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel7 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CustomGradientPanel5 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        CType(Me.DGV_LowStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel5.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel6.SuspendLayout()
        CType(Me.chartBestCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel4.SuspendLayout()
        Me.Guna2CustomGradientPanel7.SuspendLayout()
        Me.Guna2CustomGradientPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'headdashlbl
        '
        Me.headdashlbl.AutoSize = True
        Me.headdashlbl.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headdashlbl.Location = New System.Drawing.Point(676, 19)
        Me.headdashlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.headdashlbl.Name = "headdashlbl"
        Me.headdashlbl.Size = New System.Drawing.Size(230, 34)
        Me.headdashlbl.TabIndex = 1
        Me.headdashlbl.Text = "D A S H B O A R D"
        '
        'TotalSaleSum
        '
        Me.TotalSaleSum.AutoSize = True
        Me.TotalSaleSum.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSaleSum.Location = New System.Drawing.Point(25, 46)
        Me.TotalSaleSum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TotalSaleSum.Name = "TotalSaleSum"
        Me.TotalSaleSum.Size = New System.Drawing.Size(26, 30)
        Me.TotalSaleSum.TabIndex = 8
        Me.TotalSaleSum.Text = "0"
        '
        'TotalStockInSum
        '
        Me.TotalStockInSum.AutoSize = True
        Me.TotalStockInSum.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalStockInSum.Location = New System.Drawing.Point(40, 46)
        Me.TotalStockInSum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TotalStockInSum.Name = "TotalStockInSum"
        Me.TotalStockInSum.Size = New System.Drawing.Size(26, 30)
        Me.TotalStockInSum.TabIndex = 9
        Me.TotalStockInSum.Text = "0"
        '
        'DGV_LowStock
        '
        Me.DGV_LowStock.AllowUserToAddRows = False
        Me.DGV_LowStock.AllowUserToDeleteRows = False
        Me.DGV_LowStock.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_LowStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_LowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_LowStock.BackgroundColor = System.Drawing.Color.White
        Me.DGV_LowStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_LowStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGV_LowStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_LowStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_LowStock.ColumnHeadersHeight = 18
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_LowStock.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_LowStock.EnableHeadersVisualStyles = False
        Me.DGV_LowStock.Location = New System.Drawing.Point(1102, 110)
        Me.DGV_LowStock.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV_LowStock.Name = "DGV_LowStock"
        Me.DGV_LowStock.ReadOnly = True
        Me.DGV_LowStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_LowStock.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_LowStock.RowHeadersWidth = 51
        Me.DGV_LowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_LowStock.Size = New System.Drawing.Size(458, 469)
        Me.DGV_LowStock.TabIndex = 10
        '
        'CategoriesPanel
        '
        Me.CategoriesPanel.BackColor = System.Drawing.Color.SkyBlue
        Me.CategoriesPanel.Location = New System.Drawing.Point(28, 553)
        Me.CategoriesPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.CategoriesPanel.Name = "CategoriesPanel"
        Me.CategoriesPanel.Size = New System.Drawing.Size(0, 0)
        Me.CategoriesPanel.TabIndex = 12
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.SteelBlue
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.DarkBlue
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DodgerBlue
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(35, 87)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(80, 145)
        Me.Guna2CustomGradientPanel1.TabIndex = 18
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.TotalSaleSum)
        Me.Guna2Panel2.Location = New System.Drawing.Point(60, 87)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(434, 145)
        Me.Guna2Panel2.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.posinvcs.My.Resources.Resources.sales
        Me.PictureBox1.Location = New System.Drawing.Point(342, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SALES TODAY"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.Controls.Add(Me.TotalStockInSum)
        Me.Guna2Panel3.Location = New System.Drawing.Point(60, 434)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(434, 145)
        Me.Guna2Panel3.TabIndex = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.posinvcs.My.Resources.Resources.stockin
        Me.PictureBox2.Location = New System.Drawing.Point(342, 37)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "TODAY STOCKIN"
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.SlateBlue
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Indigo
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Violet
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(34, 434)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(84, 145)
        Me.Guna2CustomGradientPanel2.TabIndex = 20
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.White
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.PictureBox3)
        Me.Guna2Panel4.Controls.Add(Me.Label4)
        Me.Guna2Panel4.Controls.Add(Me.totaldmg)
        Me.Guna2Panel4.Location = New System.Drawing.Point(60, 262)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(434, 145)
        Me.Guna2Panel4.TabIndex = 23
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.posinvcs.My.Resources.Resources.damage
        Me.PictureBox3.Location = New System.Drawing.Point(342, 39)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 25)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "TOTAL DAMAGE"
        '
        'totaldmg
        '
        Me.totaldmg.AutoSize = True
        Me.totaldmg.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaldmg.Location = New System.Drawing.Point(35, 46)
        Me.totaldmg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totaldmg.Name = "totaldmg"
        Me.totaldmg.Size = New System.Drawing.Size(26, 30)
        Me.totaldmg.TabIndex = 9
        Me.totaldmg.Text = "0"
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Crimson
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.DarkRed
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.Orchid
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(35, 262)
        Me.Guna2CustomGradientPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(84, 145)
        Me.Guna2CustomGradientPanel3.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "LOW STOCK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.White
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.Label6)
        Me.Guna2Panel5.Controls.Add(Me.Label8)
        Me.Guna2Panel5.Controls.Add(Me.Chart1)
        Me.Guna2Panel5.Controls.Add(Me.btnFilter)
        Me.Guna2Panel5.Controls.Add(Me.dtTo)
        Me.Guna2Panel5.Controls.Add(Me.dtFrom)
        Me.Guna2Panel5.Location = New System.Drawing.Point(35, 614)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(1525, 346)
        Me.Guna2Panel5.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1062, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 25)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "TO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(776, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 25)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "FROM"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(25, 85)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(2)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
        Series1.Legend = "Legend1"
        Series1.Name = "Sales"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1468, 244)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.LightGray
        Me.btnFilter.Location = New System.Drawing.Point(1326, 51)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(129, 39)
        Me.btnFilter.TabIndex = 3
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'dtTo
        '
        Me.dtTo.Checked = True
        Me.dtTo.FillColor = System.Drawing.Color.White
        Me.dtTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtTo.Location = New System.Drawing.Point(1103, 56)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(2)
        Me.dtTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(213, 29)
        Me.dtTo.TabIndex = 2
        Me.dtTo.Value = New Date(2025, 11, 27, 19, 34, 30, 508)
        '
        'dtFrom
        '
        Me.dtFrom.Checked = True
        Me.dtFrom.FillColor = System.Drawing.Color.White
        Me.dtFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtFrom.Location = New System.Drawing.Point(840, 56)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.dtFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(217, 29)
        Me.dtFrom.TabIndex = 1
        Me.dtFrom.Value = New Date(2025, 11, 27, 19, 34, 30, 508)
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.White
        Me.Guna2Panel6.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel6.BorderThickness = 1
        Me.Guna2Panel6.Controls.Add(Me.chartBestCategory)
        Me.Guna2Panel6.Location = New System.Drawing.Point(526, 87)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(546, 492)
        Me.Guna2Panel6.TabIndex = 27
        '
        'chartBestCategory
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartBestCategory.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartBestCategory.Legends.Add(Legend2)
        Me.chartBestCategory.Location = New System.Drawing.Point(33, 48)
        Me.chartBestCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.chartBestCategory.Name = "chartBestCategory"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartBestCategory.Series.Add(Series2)
        Me.chartBestCategory.Size = New System.Drawing.Size(481, 418)
        Me.chartBestCategory.TabIndex = 1
        Me.chartBestCategory.Text = "Chart2"
        '
        'Guna2CustomGradientPanel4
        '
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel4.FillColor = System.Drawing.Color.SteelBlue
        Me.Guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.DarkBlue
        Me.Guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.DodgerBlue
        Me.Guna2CustomGradientPanel4.Location = New System.Drawing.Point(1102, 87)
        Me.Guna2CustomGradientPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel4.Name = "Guna2CustomGradientPanel4"
        Me.Guna2CustomGradientPanel4.Size = New System.Drawing.Size(458, 27)
        Me.Guna2CustomGradientPanel4.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(4, 1)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "TRANSACTION CHART"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 1)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "SALES CHART"
        '
        'Guna2CustomGradientPanel7
        '
        Me.Guna2CustomGradientPanel7.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel7.FillColor = System.Drawing.Color.SteelBlue
        Me.Guna2CustomGradientPanel7.FillColor2 = System.Drawing.Color.DarkBlue
        Me.Guna2CustomGradientPanel7.FillColor4 = System.Drawing.Color.DodgerBlue
        Me.Guna2CustomGradientPanel7.Location = New System.Drawing.Point(35, 614)
        Me.Guna2CustomGradientPanel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel7.Name = "Guna2CustomGradientPanel7"
        Me.Guna2CustomGradientPanel7.Size = New System.Drawing.Size(1525, 27)
        Me.Guna2CustomGradientPanel7.TabIndex = 19
        '
        'Guna2CustomGradientPanel5
        '
        Me.Guna2CustomGradientPanel5.Controls.Add(Me.Label7)
        Me.Guna2CustomGradientPanel5.FillColor = System.Drawing.Color.SteelBlue
        Me.Guna2CustomGradientPanel5.FillColor2 = System.Drawing.Color.DarkBlue
        Me.Guna2CustomGradientPanel5.FillColor4 = System.Drawing.Color.DodgerBlue
        Me.Guna2CustomGradientPanel5.Location = New System.Drawing.Point(526, 87)
        Me.Guna2CustomGradientPanel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel5.Name = "Guna2CustomGradientPanel5"
        Me.Guna2CustomGradientPanel5.Size = New System.Drawing.Size(546, 27)
        Me.Guna2CustomGradientPanel5.TabIndex = 25
        '
        '_1dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1593, 986)
        Me.Controls.Add(Me.Guna2CustomGradientPanel5)
        Me.Controls.Add(Me.Guna2CustomGradientPanel7)
        Me.Controls.Add(Me.Guna2CustomGradientPanel4)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.CategoriesPanel)
        Me.Controls.Add(Me.DGV_LowStock)
        Me.Controls.Add(Me.headdashlbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "_1dashboard"
        Me.Text = "_1dashboard"
        CType(Me.DGV_LowStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel6.ResumeLayout(False)
        CType(Me.chartBestCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel4.ResumeLayout(False)
        Me.Guna2CustomGradientPanel4.PerformLayout()
        Me.Guna2CustomGradientPanel7.ResumeLayout(False)
        Me.Guna2CustomGradientPanel7.PerformLayout()
        Me.Guna2CustomGradientPanel5.ResumeLayout(False)
        Me.Guna2CustomGradientPanel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headdashlbl As Label
    Friend WithEvents TotalSaleSum As Label
    Friend WithEvents TotalStockInSum As Label
    Friend WithEvents DGV_LowStock As DataGridView
    Friend WithEvents CategoriesPanel As Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents totaldmg As Label
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CustomGradientPanel4 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2CustomGradientPanel7 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel5 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents chartBestCategory As DataVisualization.Charting.Chart
    Friend WithEvents dtTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnFilter As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
