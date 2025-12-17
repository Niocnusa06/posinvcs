<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.usernametxtb = New System.Windows.Forms.TextBox()
        Me.passwordtxtb = New System.Windows.Forms.TextBox()
        Me.sanswertxtb = New System.Windows.Forms.TextBox()
        Me.squestioncombob = New System.Windows.Forms.ComboBox()
        Me.accountcombob = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UserDGV = New System.Windows.Forms.DataGridView()
        Me.recordCountLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.add_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.update_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.delete_btn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usernametxtb
        '
        Me.usernametxtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernametxtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.usernametxtb.Location = New System.Drawing.Point(188, 144)
        Me.usernametxtb.Name = "usernametxtb"
        Me.usernametxtb.Size = New System.Drawing.Size(501, 38)
        Me.usernametxtb.TabIndex = 0
        '
        'passwordtxtb
        '
        Me.passwordtxtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordtxtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.passwordtxtb.Location = New System.Drawing.Point(188, 234)
        Me.passwordtxtb.Name = "passwordtxtb"
        Me.passwordtxtb.Size = New System.Drawing.Size(501, 38)
        Me.passwordtxtb.TabIndex = 1
        '
        'sanswertxtb
        '
        Me.sanswertxtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sanswertxtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.sanswertxtb.Location = New System.Drawing.Point(188, 415)
        Me.sanswertxtb.Name = "sanswertxtb"
        Me.sanswertxtb.Size = New System.Drawing.Size(501, 38)
        Me.sanswertxtb.TabIndex = 2
        '
        'squestioncombob
        '
        Me.squestioncombob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.squestioncombob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.squestioncombob.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.squestioncombob.Location = New System.Drawing.Point(188, 324)
        Me.squestioncombob.Name = "squestioncombob"
        Me.squestioncombob.Size = New System.Drawing.Size(501, 39)
        Me.squestioncombob.TabIndex = 3
        '
        'accountcombob
        '
        Me.accountcombob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.accountcombob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.accountcombob.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.accountcombob.FormattingEnabled = True
        Me.accountcombob.Location = New System.Drawing.Point(188, 505)
        Me.accountcombob.Name = "accountcombob"
        Me.accountcombob.Size = New System.Drawing.Size(501, 39)
        Me.accountcombob.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(38, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(38, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(38, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Question"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(38, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(38, 512)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Account Type"
        '
        'UserDGV
        '
        Me.UserDGV.AllowUserToAddRows = False
        Me.UserDGV.AllowUserToDeleteRows = False
        Me.UserDGV.AllowUserToOrderColumns = True
        Me.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserDGV.BackgroundColor = System.Drawing.Color.White
        Me.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDGV.Location = New System.Drawing.Point(779, 144)
        Me.UserDGV.Name = "UserDGV"
        Me.UserDGV.ReadOnly = True
        Me.UserDGV.Size = New System.Drawing.Size(787, 813)
        Me.UserDGV.TabIndex = 11
        '
        'recordCountLbl
        '
        Me.recordCountLbl.AutoSize = True
        Me.recordCountLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recordCountLbl.Location = New System.Drawing.Point(468, 652)
        Me.recordCountLbl.Name = "recordCountLbl"
        Me.recordCountLbl.Size = New System.Drawing.Size(0, 20)
        Me.recordCountLbl.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Heavy", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(648, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(281, 37)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "U S E R  D E T A I L S"
        '
        'add_btn
        '
        Me.add_btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.add_btn.BorderRadius = 7
        Me.add_btn.BorderThickness = 1
        Me.add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.add_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.add_btn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.add_btn.ForeColor = System.Drawing.Color.Black
        Me.add_btn.HoverState.FillColor = System.Drawing.Color.SteelBlue
        Me.add_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.add_btn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.add_btn.ImageSize = New System.Drawing.Size(18, 18)
        Me.add_btn.Location = New System.Drawing.Point(413, 662)
        Me.add_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(276, 44)
        Me.add_btn.TabIndex = 34
        Me.add_btn.Text = "ADD"
        '
        'clear_btn
        '
        Me.clear_btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.clear_btn.BorderRadius = 7
        Me.clear_btn.BorderThickness = 1
        Me.clear_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.clear_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.clear_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.clear_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.clear_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.clear_btn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.clear_btn.ForeColor = System.Drawing.Color.Black
        Me.clear_btn.HoverState.FillColor = System.Drawing.Color.SteelBlue
        Me.clear_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.clear_btn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.clear_btn.ImageSize = New System.Drawing.Size(18, 18)
        Me.clear_btn.Location = New System.Drawing.Point(67, 662)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(276, 44)
        Me.clear_btn.TabIndex = 35
        Me.clear_btn.Text = "CLEAR"
        '
        'update_btn
        '
        Me.update_btn.BorderColor = System.Drawing.Color.SkyBlue
        Me.update_btn.BorderRadius = 7
        Me.update_btn.BorderThickness = 1
        Me.update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.update_btn.FillColor = System.Drawing.Color.SkyBlue
        Me.update_btn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.update_btn.ForeColor = System.Drawing.Color.Black
        Me.update_btn.HoverState.FillColor = System.Drawing.Color.SteelBlue
        Me.update_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.update_btn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.update_btn.ImageSize = New System.Drawing.Size(18, 18)
        Me.update_btn.Location = New System.Drawing.Point(413, 739)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(276, 44)
        Me.update_btn.TabIndex = 36
        Me.update_btn.Text = "UPDATE"
        '
        'delete_btn
        '
        Me.delete_btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.delete_btn.BorderRadius = 7
        Me.delete_btn.BorderThickness = 1
        Me.delete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.delete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.delete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.delete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.delete_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.delete_btn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.delete_btn.ForeColor = System.Drawing.Color.Black
        Me.delete_btn.HoverState.FillColor = System.Drawing.Color.SteelBlue
        Me.delete_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.delete_btn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.delete_btn.ImageSize = New System.Drawing.Size(18, 18)
        Me.delete_btn.Location = New System.Drawing.Point(67, 729)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(276, 44)
        Me.delete_btn.TabIndex = 37
        Me.delete_btn.Text = "DELETE"
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1593, 986)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.recordCountLbl)
        Me.Controls.Add(Me.UserDGV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.accountcombob)
        Me.Controls.Add(Me.squestioncombob)
        Me.Controls.Add(Me.sanswertxtb)
        Me.Controls.Add(Me.passwordtxtb)
        Me.Controls.Add(Me.usernametxtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernametxtb As TextBox
    Friend WithEvents passwordtxtb As TextBox
    Friend WithEvents sanswertxtb As TextBox
    Friend WithEvents squestioncombob As ComboBox
    Friend WithEvents accountcombob As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents UserDGV As DataGridView
    Friend WithEvents recordCountLbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents add_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents update_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents delete_btn As Guna.UI2.WinForms.Guna2Button
End Class
