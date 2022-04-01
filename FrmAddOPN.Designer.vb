<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddOPN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddOPN))
        Me.TboxMaterial = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LblMaterial = New System.Windows.Forms.Label()
        Me.TboxOPN = New System.Windows.Forms.TextBox()
        Me.LblOPN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TboxMaterial
        '
        Me.TboxMaterial.Location = New System.Drawing.Point(146, 12)
        Me.TboxMaterial.Name = "TboxMaterial"
        Me.TboxMaterial.Size = New System.Drawing.Size(194, 23)
        Me.TboxMaterial.TabIndex = 0
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(146, 70)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 29)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'LblMaterial
        '
        Me.LblMaterial.AutoSize = True
        Me.LblMaterial.Location = New System.Drawing.Point(12, 15)
        Me.LblMaterial.Name = "LblMaterial"
        Me.LblMaterial.Size = New System.Drawing.Size(100, 15)
        Me.LblMaterial.TabIndex = 0
        Me.LblMaterial.Text = "Material Number:"
        '
        'TboxOPN
        '
        Me.TboxOPN.Location = New System.Drawing.Point(146, 41)
        Me.TboxOPN.Name = "TboxOPN"
        Me.TboxOPN.Size = New System.Drawing.Size(194, 23)
        Me.TboxOPN.TabIndex = 1
        '
        'LblOPN
        '
        Me.LblOPN.AutoSize = True
        Me.LblOPN.Location = New System.Drawing.Point(12, 44)
        Me.LblOPN.Name = "LblOPN"
        Me.LblOPN.Size = New System.Drawing.Size(128, 15)
        Me.LblOPN.TabIndex = 1
        Me.LblOPN.Text = "Ordering Part Number:"
        '
        'FrmAddOPN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 107)
        Me.Controls.Add(Me.LblOPN)
        Me.Controls.Add(Me.TboxOPN)
        Me.Controls.Add(Me.LblMaterial)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TboxMaterial)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddOPN"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Material"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TboxMaterial As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents LblMaterial As Label
    Friend WithEvents TboxOPN As TextBox
    Friend WithEvents LblOPN As Label
End Class
