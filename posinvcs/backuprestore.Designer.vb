<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backuprestore
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnbackup = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnrestore = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.restorePicBox = New System.Windows.Forms.PictureBox()
        Me.backupPicBox = New System.Windows.Forms.PictureBox()
        Me.backupLabel = New System.Windows.Forms.Label()
        Me.RestoreLabel = New System.Windows.Forms.Label()
        CType(Me.restorePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backupPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnbackup
        '
        Me.btnbackup.BorderColor = System.Drawing.Color.Transparent
        Me.btnbackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnbackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnbackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnbackup.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnbackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnbackup.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnbackup.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnbackup.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnbackup.ForeColor = System.Drawing.Color.Black
        Me.btnbackup.Location = New System.Drawing.Point(50, 96)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(727, 44)
        Me.btnbackup.TabIndex = 1
        Me.btnbackup.Text = "BACKUP"
        '
        'btnrestore
        '
        Me.btnrestore.BorderColor = System.Drawing.Color.Transparent
        Me.btnrestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnrestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnrestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnrestore.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnrestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnrestore.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnrestore.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnrestore.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnrestore.ForeColor = System.Drawing.Color.Black
        Me.btnrestore.Location = New System.Drawing.Point(819, 96)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(727, 44)
        Me.btnrestore.TabIndex = 2
        Me.btnrestore.Text = "RESTORE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(484, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(642, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "B A C K U P  A N D  R E S T O R E  D A T A B A S E"
        '
        'restorePicBox
        '
        Me.restorePicBox.BackColor = System.Drawing.Color.Gainsboro
        Me.restorePicBox.Image = Global.posinvcs.My.Resources.Resources.backup_copy
        Me.restorePicBox.Location = New System.Drawing.Point(819, 137)
        Me.restorePicBox.Name = "restorePicBox"
        Me.restorePicBox.Padding = New System.Windows.Forms.Padding(45, 40, 45, 40)
        Me.restorePicBox.Size = New System.Drawing.Size(727, 671)
        Me.restorePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.restorePicBox.TabIndex = 5
        Me.restorePicBox.TabStop = False
        '
        'backupPicBox
        '
        Me.backupPicBox.BackColor = System.Drawing.Color.Gainsboro
        Me.backupPicBox.Image = Global.posinvcs.My.Resources.Resources.backup
        Me.backupPicBox.Location = New System.Drawing.Point(50, 137)
        Me.backupPicBox.Name = "backupPicBox"
        Me.backupPicBox.Padding = New System.Windows.Forms.Padding(45, 40, 45, 40)
        Me.backupPicBox.Size = New System.Drawing.Size(727, 671)
        Me.backupPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.backupPicBox.TabIndex = 4
        Me.backupPicBox.TabStop = False
        '
        'backupLabel
        '
        Me.backupLabel.AutoSize = True
        Me.backupLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.backupLabel.Location = New System.Drawing.Point(45, 847)
        Me.backupLabel.Name = "backupLabel"
        Me.backupLabel.Size = New System.Drawing.Size(28, 30)
        Me.backupLabel.TabIndex = 6
        Me.backupLabel.Text = "..."
        '
        'RestoreLabel
        '
        Me.RestoreLabel.AutoSize = True
        Me.RestoreLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RestoreLabel.Location = New System.Drawing.Point(814, 847)
        Me.RestoreLabel.Name = "RestoreLabel"
        Me.RestoreLabel.Size = New System.Drawing.Size(28, 30)
        Me.RestoreLabel.TabIndex = 7
        Me.RestoreLabel.Text = "..."
        '
        'backuprestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1593, 986)
        Me.Controls.Add(Me.RestoreLabel)
        Me.Controls.Add(Me.backupLabel)
        Me.Controls.Add(Me.restorePicBox)
        Me.Controls.Add(Me.backupPicBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnrestore)
        Me.Controls.Add(Me.btnbackup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "backuprestore"
        Me.Text = "backuprestore"
        CType(Me.restorePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backupPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnrestore As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnbackup As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents restorePicBox As PictureBox
    Friend WithEvents backupPicBox As PictureBox
    Friend WithEvents backupLabel As Label
    Friend WithEvents RestoreLabel As Label
End Class
