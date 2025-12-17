<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockinhistory
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.searchtb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnpdf = New Guna.UI2.WinForms.Guna2Button()
        Me.datagridview1 = New System.Windows.Forms.DataGridView()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPrev = New Guna.UI2.WinForms.Guna2Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblEntriesInfo = New System.Windows.Forms.Label()
        Me.cmbQuickFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbEntries = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchtb
        '
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
        Me.searchtb.Location = New System.Drawing.Point(1194, 142)
        Me.searchtb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.PlaceholderText = ""
        Me.searchtb.SelectedText = ""
        Me.searchtb.Size = New System.Drawing.Size(373, 43)
        Me.searchtb.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(604, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 34)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "S T O C K  -  I N   H I S T O R Y "
        '
        'btnpdf
        '
        Me.btnpdf.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnpdf.BorderRadius = 8
        Me.btnpdf.BorderThickness = 1
        Me.btnpdf.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnpdf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnpdf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnpdf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnpdf.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnpdf.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnpdf.ForeColor = System.Drawing.Color.Black
        Me.btnpdf.Location = New System.Drawing.Point(28, 141)
        Me.btnpdf.Name = "btnpdf"
        Me.btnpdf.Size = New System.Drawing.Size(237, 44)
        Me.btnpdf.TabIndex = 25
        Me.btnpdf.Text = "PRINT REPORT"
        '
        'datagridview1
        '
        Me.datagridview1.AllowUserToAddRows = False
        Me.datagridview1.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.datagridview1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridview1.DefaultCellStyle = DataGridViewCellStyle8
        Me.datagridview1.EnableHeadersVisualStyles = False
        Me.datagridview1.GridColor = System.Drawing.Color.LightGray
        Me.datagridview1.Location = New System.Drawing.Point(29, 200)
        Me.datagridview1.MultiSelect = False
        Me.datagridview1.Name = "datagridview1"
        Me.datagridview1.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.datagridview1.RowHeadersVisible = False
        Me.datagridview1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.datagridview1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.datagridview1.RowTemplate.Height = 40
        Me.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridview1.Size = New System.Drawing.Size(1538, 741)
        Me.datagridview1.TabIndex = 57
        '
        'btnNext
        '
        Me.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNext.FillColor = System.Drawing.Color.Gainsboro
        Me.btnNext.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(1463, 947)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(36, 34)
        Me.btnNext.TabIndex = 62
        Me.btnNext.Text = ">"
        '
        'btnPrev
        '
        Me.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrev.FillColor = System.Drawing.Color.Gainsboro
        Me.btnPrev.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.Black
        Me.btnPrev.Location = New System.Drawing.Point(1423, 947)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(36, 34)
        Me.btnPrev.TabIndex = 61
        Me.btnPrev.Text = "<"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(1502, 952)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 25)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "NEXT"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(1322, 952)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 25)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "PREVIOUS"
        '
        'lblEntriesInfo
        '
        Me.lblEntriesInfo.AutoSize = True
        Me.lblEntriesInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblEntriesInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntriesInfo.ForeColor = System.Drawing.Color.Black
        Me.lblEntriesInfo.Location = New System.Drawing.Point(45, 948)
        Me.lblEntriesInfo.Name = "lblEntriesInfo"
        Me.lblEntriesInfo.Size = New System.Drawing.Size(34, 30)
        Me.lblEntriesInfo.TabIndex = 58
        Me.lblEntriesInfo.Text = "10"
        '
        'cmbQuickFilter
        '
        Me.cmbQuickFilter.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbQuickFilter.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmbQuickFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbQuickFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuickFilter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbQuickFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbQuickFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmbQuickFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbQuickFilter.ItemHeight = 30
        Me.cmbQuickFilter.Items.AddRange(New Object() {"Today", "This Week", "This Month", "This Year", "All Records"})
        Me.cmbQuickFilter.Location = New System.Drawing.Point(985, 149)
        Me.cmbQuickFilter.Name = "cmbQuickFilter"
        Me.cmbQuickFilter.Size = New System.Drawing.Size(202, 36)
        Me.cmbQuickFilter.TabIndex = 66
        '
        'cmbEntries
        '
        Me.cmbEntries.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbEntries.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmbEntries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEntries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEntries.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbEntries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbEntries.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmbEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbEntries.ItemHeight = 30
        Me.cmbEntries.Items.AddRange(New Object() {"10", "20", "50", "100", "500", "1000"})
        Me.cmbEntries.Location = New System.Drawing.Point(346, 149)
        Me.cmbEntries.Name = "cmbEntries"
        Me.cmbEntries.Size = New System.Drawing.Size(106, 36)
        Me.cmbEntries.TabIndex = 65
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(452, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 30)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "Entries"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(274, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 30)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Show"
        '
        'stockinhistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1593, 986)
        Me.Controls.Add(Me.cmbQuickFilter)
        Me.Controls.Add(Me.cmbEntries)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblEntriesInfo)
        Me.Controls.Add(Me.datagridview1)
        Me.Controls.Add(Me.btnpdf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.searchtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stockinhistory"
        Me.Text = "stockinhistory"
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchtb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnpdf As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents datagridview1 As DataGridView
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPrev As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblEntriesInfo As Label
    Friend WithEvents cmbQuickFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbEntries As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
End Class
