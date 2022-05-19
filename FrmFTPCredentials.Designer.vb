<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFTPCredentials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFTPCredentials))
        Me.TBoxHost = New System.Windows.Forms.TextBox()
        Me.LblHost = New System.Windows.Forms.Label()
        Me.TBoxUsername = New System.Windows.Forms.TextBox()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.TBoxPassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TBoxPath = New System.Windows.Forms.TextBox()
        Me.LblPath = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBoxHost
        '
        Me.TBoxHost.Location = New System.Drawing.Point(53, 15)
        Me.TBoxHost.Name = "TBoxHost"
        Me.TBoxHost.Size = New System.Drawing.Size(121, 23)
        Me.TBoxHost.TabIndex = 0
        '
        'LblHost
        '
        Me.LblHost.AutoSize = True
        Me.LblHost.Location = New System.Drawing.Point(12, 19)
        Me.LblHost.Name = "LblHost"
        Me.LblHost.Size = New System.Drawing.Size(35, 15)
        Me.LblHost.TabIndex = 0
        Me.LblHost.Text = "Host:"
        '
        'TBoxUsername
        '
        Me.TBoxUsername.Location = New System.Drawing.Point(254, 15)
        Me.TBoxUsername.Name = "TBoxUsername"
        Me.TBoxUsername.Size = New System.Drawing.Size(121, 23)
        Me.TBoxUsername.TabIndex = 1
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(185, 19)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(63, 15)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "Username:"
        '
        'TBoxPassword
        '
        Me.TBoxPassword.Location = New System.Drawing.Point(455, 15)
        Me.TBoxPassword.Name = "TBoxPassword"
        Me.TBoxPassword.Size = New System.Drawing.Size(121, 23)
        Me.TBoxPassword.TabIndex = 2
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(389, 19)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(60, 15)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "Password:"
        '
        'TBoxPath
        '
        Me.TBoxPath.Location = New System.Drawing.Point(53, 50)
        Me.TBoxPath.Name = "TBoxPath"
        Me.TBoxPath.Size = New System.Drawing.Size(523, 23)
        Me.TBoxPath.TabIndex = 4
        '
        'LblPath
        '
        Me.LblPath.AutoSize = True
        Me.LblPath.Location = New System.Drawing.Point(12, 54)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(34, 15)
        Me.LblPath.TabIndex = 4
        Me.LblPath.Text = "Path:"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(580, 47)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(72, 29)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(580, 12)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(72, 29)
        Me.BtnConnect.TabIndex = 5
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'FrmFTPCredentials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 90)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblPath)
        Me.Controls.Add(Me.TBoxPath)
        Me.Controls.Add(Me.TBoxPassword)
        Me.Controls.Add(Me.TBoxUsername)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.LblHost)
        Me.Controls.Add(Me.TBoxHost)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFTPCredentials"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FTP Credential"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBoxHost As TextBox
    Friend WithEvents LblHost As Label
    Friend WithEvents TBoxUsername As TextBox
    Friend WithEvents LblUsername As Label
    Friend WithEvents TBoxPassword As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents TBoxPath As TextBox
    Friend WithEvents LblPath As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnConnect As Button
End Class
