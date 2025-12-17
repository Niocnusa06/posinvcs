<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class category
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvcategory = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcategory = New System.Windows.Forms.TextBox()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.searchtb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnadd = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvcategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(650, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 37)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "C A T E G O R I E S"
        '
        'dgvcategory
        '
        Me.dgvcategory.AllowUserToAddRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvcategory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvcategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvcategory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvcategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcategory.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvcategory.EnableHeadersVisualStyles = False
        Me.dgvcategory.GridColor = System.Drawing.Color.LightGray
        Me.dgvcategory.Location = New System.Drawing.Point(28, 197)
        Me.dgvcategory.Name = "dgvcategory"
        Me.dgvcategory.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcategory.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvcategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgvcategory.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvcategory.RowTemplate.Height = 40
        Me.dgvcategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcategory.Size = New System.Drawing.Size(1539, 764)
        Me.dgvcategory.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "NEW CATEGORY"
        '
        'txtcategory
        '
        Me.txtcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategory.Location = New System.Drawing.Point(208, 144)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(597, 38)
        Me.txtcategory.TabIndex = 31
        '
        'btnupdate
        '
        Me.btnupdate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnupdate.BorderRadius = 7
        Me.btnupdate.BorderThickness = 1
        Me.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.HoverState.FillColor = System.Drawing.Color.SteelBlue
        Me.btnupdate.Image = Global.posinvcs.My.Resources.Resources.refresh
        Me.btnupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnupdate.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnupdate.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnupdate.Location = New System.Drawing.Point(1327, 141)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(237, 44)
        Me.btnupdate.TabIndex = 33
        Me.btnupdate.Text = "UPDATE CATEGORY"
        Me.btnupdate.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Salmon
        Me.Guna2Button1.BorderRadius = 7
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Salmon
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.SteelBlue
        Me.Guna2Button1.Image = Global.posinvcs.My.Resources.Resources.cancel_button
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageOffset = New System.Drawing.Point(10, 0)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(18, 18)
        Me.Guna2Button1.Location = New System.Drawing.Point(1075, 141)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(237, 44)
        Me.Guna2Button1.TabIndex = 32
        Me.Guna2Button1.Text = "CLEAR TEXT"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(10, 0)
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
        Me.searchtb.Location = New System.Drawing.Point(1194, 83)
        Me.searchtb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.PlaceholderText = ""
        Me.searchtb.SelectedText = ""
        Me.searchtb.Size = New System.Drawing.Size(373, 43)
        Me.searchtb.TabIndex = 29
        '
        'btnadd
        '
        Me.btnadd.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.btnadd.BorderRadius = 7
        Me.btnadd.BorderThickness = 1
        Me.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnadd.FillColor = System.Drawing.Color.CornflowerBlue
        Me.btnadd.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnadd.ForeColor = System.Drawing.Color.Black
        Me.btnadd.HoverState.FillColor = System.Drawing.Color.SteelBlue
        Me.btnadd.Image = Global.posinvcs.My.Resources.Resources.post
        Me.btnadd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnadd.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnadd.Location = New System.Drawing.Point(820, 141)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(237, 44)
        Me.btnadd.TabIndex = 14
        Me.btnadd.Text = "ADD CATEGORY"
        Me.btnadd.TextOffset = New System.Drawing.Point(15, 0)
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1593, 986)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.txtcategory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.dgvcategory)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "category"
        Me.Text = "category"
        CType(Me.dgvcategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dgvcategory As DataGridView
    Friend WithEvents btnadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents searchtb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcategory As TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
End Class
