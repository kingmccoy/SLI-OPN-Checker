<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOPNInformation
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
        Me.TboxPPOQty = New System.Windows.Forms.TextBox()
        Me.TboxFullTraccode = New System.Windows.Forms.TextBox()
        Me.TboxLotNum = New System.Windows.Forms.TextBox()
        Me.TboxFirmware = New System.Windows.Forms.TextBox()
        Me.TboxOPN = New System.Windows.Forms.TextBox()
        Me.TboxMaterial = New System.Windows.Forms.TextBox()
        Me.LblPPOQty = New System.Windows.Forms.Label()
        Me.LblFullTraccode = New System.Windows.Forms.Label()
        Me.LblLotNum = New System.Windows.Forms.Label()
        Me.LblFirmware = New System.Windows.Forms.Label()
        Me.LblOPN = New System.Windows.Forms.Label()
        Me.LblMaterial = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TboxPPOQty
        '
        Me.TboxPPOQty.Location = New System.Drawing.Point(98, 156)
        Me.TboxPPOQty.Name = "TboxPPOQty"
        Me.TboxPPOQty.ReadOnly = True
        Me.TboxPPOQty.Size = New System.Drawing.Size(151, 23)
        Me.TboxPPOQty.TabIndex = 18
        '
        'TboxFullTraccode
        '
        Me.TboxFullTraccode.Location = New System.Drawing.Point(98, 129)
        Me.TboxFullTraccode.Name = "TboxFullTraccode"
        Me.TboxFullTraccode.ReadOnly = True
        Me.TboxFullTraccode.Size = New System.Drawing.Size(151, 23)
        Me.TboxFullTraccode.TabIndex = 16
        '
        'TboxLotNum
        '
        Me.TboxLotNum.Location = New System.Drawing.Point(98, 100)
        Me.TboxLotNum.Name = "TboxLotNum"
        Me.TboxLotNum.ReadOnly = True
        Me.TboxLotNum.Size = New System.Drawing.Size(151, 23)
        Me.TboxLotNum.TabIndex = 14
        '
        'TboxFirmware
        '
        Me.TboxFirmware.Location = New System.Drawing.Point(98, 71)
        Me.TboxFirmware.Name = "TboxFirmware"
        Me.TboxFirmware.ReadOnly = True
        Me.TboxFirmware.Size = New System.Drawing.Size(151, 23)
        Me.TboxFirmware.TabIndex = 12
        '
        'TboxOPN
        '
        Me.TboxOPN.Location = New System.Drawing.Point(98, 44)
        Me.TboxOPN.Name = "TboxOPN"
        Me.TboxOPN.ReadOnly = True
        Me.TboxOPN.Size = New System.Drawing.Size(151, 23)
        Me.TboxOPN.TabIndex = 10
        '
        'TboxMaterial
        '
        Me.TboxMaterial.Location = New System.Drawing.Point(98, 15)
        Me.TboxMaterial.Name = "TboxMaterial"
        Me.TboxMaterial.ReadOnly = True
        Me.TboxMaterial.Size = New System.Drawing.Size(151, 23)
        Me.TboxMaterial.TabIndex = 8
        '
        'LblPPOQty
        '
        Me.LblPPOQty.AutoSize = True
        Me.LblPPOQty.Location = New System.Drawing.Point(10, 160)
        Me.LblPPOQty.Name = "LblPPOQty"
        Me.LblPPOQty.Size = New System.Drawing.Size(79, 15)
        Me.LblPPOQty.TabIndex = 19
        Me.LblPPOQty.Text = "PPO Quantity"
        '
        'LblFullTraccode
        '
        Me.LblFullTraccode.AutoSize = True
        Me.LblFullTraccode.Location = New System.Drawing.Point(10, 133)
        Me.LblFullTraccode.Name = "LblFullTraccode"
        Me.LblFullTraccode.Size = New System.Drawing.Size(82, 15)
        Me.LblFullTraccode.TabIndex = 17
        Me.LblFullTraccode.Text = "Full Tracecode"
        '
        'LblLotNum
        '
        Me.LblLotNum.AutoSize = True
        Me.LblLotNum.Location = New System.Drawing.Point(10, 104)
        Me.LblLotNum.Name = "LblLotNum"
        Me.LblLotNum.Size = New System.Drawing.Size(71, 15)
        Me.LblLotNum.TabIndex = 15
        Me.LblLotNum.Text = "Lot Number"
        '
        'LblFirmware
        '
        Me.LblFirmware.AutoSize = True
        Me.LblFirmware.Location = New System.Drawing.Point(10, 75)
        Me.LblFirmware.Name = "LblFirmware"
        Me.LblFirmware.Size = New System.Drawing.Size(56, 15)
        Me.LblFirmware.TabIndex = 13
        Me.LblFirmware.Text = "Firmware"
        '
        'LblOPN
        '
        Me.LblOPN.AutoSize = True
        Me.LblOPN.Location = New System.Drawing.Point(10, 48)
        Me.LblOPN.Name = "LblOPN"
        Me.LblOPN.Size = New System.Drawing.Size(32, 15)
        Me.LblOPN.TabIndex = 11
        Me.LblOPN.Text = "OPN"
        '
        'LblMaterial
        '
        Me.LblMaterial.AutoSize = True
        Me.LblMaterial.Location = New System.Drawing.Point(10, 19)
        Me.LblMaterial.Name = "LblMaterial"
        Me.LblMaterial.Size = New System.Drawing.Size(50, 15)
        Me.LblMaterial.TabIndex = 9
        Me.LblMaterial.Text = "Material"
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(98, 185)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(81, 31)
        Me.BtnOK.TabIndex = 20
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'FrmOPNInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.TboxPPOQty)
        Me.Controls.Add(Me.TboxFullTraccode)
        Me.Controls.Add(Me.TboxLotNum)
        Me.Controls.Add(Me.TboxFirmware)
        Me.Controls.Add(Me.TboxOPN)
        Me.Controls.Add(Me.TboxMaterial)
        Me.Controls.Add(Me.LblPPOQty)
        Me.Controls.Add(Me.LblFullTraccode)
        Me.Controls.Add(Me.LblLotNum)
        Me.Controls.Add(Me.LblFirmware)
        Me.Controls.Add(Me.LblOPN)
        Me.Controls.Add(Me.LblMaterial)
        Me.Controls.Add(Me.BtnOK)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmOPNInformation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OPN Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TboxPPOQty As TextBox
    Friend WithEvents TboxFullTraccode As TextBox
    Friend WithEvents TboxLotNum As TextBox
    Friend WithEvents TboxFirmware As TextBox
    Friend WithEvents TboxOPN As TextBox
    Friend WithEvents TboxMaterial As TextBox
    Friend WithEvents LblPPOQty As Label
    Friend WithEvents LblFullTraccode As Label
    Friend WithEvents LblLotNum As Label
    Friend WithEvents LblFirmware As Label
    Friend WithEvents LblOPN As Label
    Friend WithEvents LblMaterial As Label
    Friend WithEvents BtnOK As Button
End Class
