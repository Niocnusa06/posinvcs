<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertLogOut
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
        Me.btnnolo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnyeslo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnolo
        '
        Me.btnnolo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue
        Me.btnnolo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnnolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnolo.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnolo.ForeColor = System.Drawing.Color.Black
        Me.btnnolo.Location = New System.Drawing.Point(195, 171)
        Me.btnnolo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnolo.Name = "btnnolo"
        Me.btnnolo.Size = New System.Drawing.Size(140, 28)
        Me.btnnolo.TabIndex = 27
        Me.btnnolo.Text = "NO"
        Me.btnnolo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Are you sure you want to log out?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 37)
        Me.Panel1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 13.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Log Out"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.posinvcs.My.Resources.Resources.icons8_warning
        Me.PictureBox1.Location = New System.Drawing.Point(153, 56)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btnyeslo
        '
        Me.btnyeslo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue
        Me.btnyeslo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnyeslo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyeslo.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnyeslo.ForeColor = System.Drawing.Color.Black
        Me.btnyeslo.Location = New System.Drawing.Point(27, 171)
        Me.btnyeslo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnyeslo.Name = "btnyeslo"
        Me.btnyeslo.Size = New System.Drawing.Size(140, 28)
        Me.btnyeslo.TabIndex = 28
        Me.btnyeslo.Text = "YES"
        Me.btnyeslo.UseVisualStyleBackColor = True
        '
        'AlertLogOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 207)
        Me.Controls.Add(Me.btnyeslo)
        Me.Controls.Add(Me.btnnolo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AlertLogOut"
        Me.Text = "AlertLogOutSureLogOut"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnnolo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnyeslo As Button
End Class
