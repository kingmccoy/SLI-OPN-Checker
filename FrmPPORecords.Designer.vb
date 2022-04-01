<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPPORecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPPORecords))
        Me.TboxNOPN = New System.Windows.Forms.TextBox()
        Me.LblNOPN = New System.Windows.Forms.Label()
        Me.TboxFw = New System.Windows.Forms.TextBox()
        Me.LblFw = New System.Windows.Forms.Label()
        Me.TboxMat = New System.Windows.Forms.TextBox()
        Me.LblMat = New System.Windows.Forms.Label()
        Me.TboxLotNum = New System.Windows.Forms.TextBox()
        Me.LblLotNum = New System.Windows.Forms.Label()
        Me.TboxFTC = New System.Windows.Forms.TextBox()
        Me.LblFTC = New System.Windows.Forms.Label()
        Me.TboxPPOQty = New System.Windows.Forms.TextBox()
        Me.LblPPOQty = New System.Windows.Forms.Label()
        Me.TboxGRQty = New System.Windows.Forms.TextBox()
        Me.LblGRQty = New System.Windows.Forms.Label()
        Me.TboxGRDate = New System.Windows.Forms.TextBox()
        Me.LblGRDate = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TboxNOPN
        '
        Me.TboxNOPN.Location = New System.Drawing.Point(172, 34)
        Me.TboxNOPN.Name = "TboxNOPN"
        Me.TboxNOPN.Size = New System.Drawing.Size(153, 20)
        Me.TboxNOPN.TabIndex = 0
        '
        'LblNOPN
        '
        Me.LblNOPN.AutoSize = True
        Me.LblNOPN.Location = New System.Drawing.Point(12, 38)
        Me.LblNOPN.Name = "LblNOPN"
        Me.LblNOPN.Size = New System.Drawing.Size(134, 13)
        Me.LblNOPN.TabIndex = 1
        Me.LblNOPN.Text = "New Ordering Part Number"
        '
        'TboxFw
        '
        Me.TboxFw.Location = New System.Drawing.Point(172, 60)
        Me.TboxFw.Name = "TboxFw"
        Me.TboxFw.Size = New System.Drawing.Size(153, 20)
        Me.TboxFw.TabIndex = 0
        '
        'LblFw
        '
        Me.LblFw.AutoSize = True
        Me.LblFw.Location = New System.Drawing.Point(12, 64)
        Me.LblFw.Name = "LblFw"
        Me.LblFw.Size = New System.Drawing.Size(49, 13)
        Me.LblFw.TabIndex = 1
        Me.LblFw.Text = "Firmware"
        '
        'TboxMat
        '
        Me.TboxMat.Location = New System.Drawing.Point(172, 86)
        Me.TboxMat.Name = "TboxMat"
        Me.TboxMat.Size = New System.Drawing.Size(153, 20)
        Me.TboxMat.TabIndex = 0
        '
        'LblMat
        '
        Me.LblMat.AutoSize = True
        Me.LblMat.Location = New System.Drawing.Point(12, 90)
        Me.LblMat.Name = "LblMat"
        Me.LblMat.Size = New System.Drawing.Size(44, 13)
        Me.LblMat.TabIndex = 1
        Me.LblMat.Text = "Material"
        '
        'TboxLotNum
        '
        Me.TboxLotNum.Location = New System.Drawing.Point(172, 112)
        Me.TboxLotNum.Name = "TboxLotNum"
        Me.TboxLotNum.Size = New System.Drawing.Size(153, 20)
        Me.TboxLotNum.TabIndex = 0
        '
        'LblLotNum
        '
        Me.LblLotNum.AutoSize = True
        Me.LblLotNum.Location = New System.Drawing.Point(12, 116)
        Me.LblLotNum.Name = "LblLotNum"
        Me.LblLotNum.Size = New System.Drawing.Size(62, 13)
        Me.LblLotNum.TabIndex = 1
        Me.LblLotNum.Text = "Lot Number"
        '
        'TboxFTC
        '
        Me.TboxFTC.Location = New System.Drawing.Point(172, 138)
        Me.TboxFTC.Name = "TboxFTC"
        Me.TboxFTC.Size = New System.Drawing.Size(153, 20)
        Me.TboxFTC.TabIndex = 0
        '
        'LblFTC
        '
        Me.LblFTC.AutoSize = True
        Me.LblFTC.Location = New System.Drawing.Point(12, 141)
        Me.LblFTC.Name = "LblFTC"
        Me.LblFTC.Size = New System.Drawing.Size(82, 13)
        Me.LblFTC.TabIndex = 1
        Me.LblFTC.Text = "Full Trace Code"
        '
        'TboxPPOQty
        '
        Me.TboxPPOQty.Location = New System.Drawing.Point(172, 164)
        Me.TboxPPOQty.Name = "TboxPPOQty"
        Me.TboxPPOQty.Size = New System.Drawing.Size(153, 20)
        Me.TboxPPOQty.TabIndex = 0
        '
        'LblPPOQty
        '
        Me.LblPPOQty.AutoSize = True
        Me.LblPPOQty.Location = New System.Drawing.Point(12, 168)
        Me.LblPPOQty.Name = "LblPPOQty"
        Me.LblPPOQty.Size = New System.Drawing.Size(48, 13)
        Me.LblPPOQty.TabIndex = 1
        Me.LblPPOQty.Text = "PPO Qty"
        '
        'TboxGRQty
        '
        Me.TboxGRQty.Location = New System.Drawing.Point(172, 190)
        Me.TboxGRQty.Name = "TboxGRQty"
        Me.TboxGRQty.Size = New System.Drawing.Size(153, 20)
        Me.TboxGRQty.TabIndex = 0
        '
        'LblGRQty
        '
        Me.LblGRQty.AutoSize = True
        Me.LblGRQty.Location = New System.Drawing.Point(12, 194)
        Me.LblGRQty.Name = "LblGRQty"
        Me.LblGRQty.Size = New System.Drawing.Size(66, 13)
        Me.LblGRQty.TabIndex = 1
        Me.LblGRQty.Text = "SAP GR Qty"
        '
        'TboxGRDate
        '
        Me.TboxGRDate.Location = New System.Drawing.Point(172, 216)
        Me.TboxGRDate.Name = "TboxGRDate"
        Me.TboxGRDate.Size = New System.Drawing.Size(153, 20)
        Me.TboxGRDate.TabIndex = 0
        '
        'LblGRDate
        '
        Me.LblGRDate.AutoSize = True
        Me.LblGRDate.Location = New System.Drawing.Point(12, 219)
        Me.LblGRDate.Name = "LblGRDate"
        Me.LblGRDate.Size = New System.Drawing.Size(49, 13)
        Me.LblGRDate.TabIndex = 1
        Me.LblGRDate.Text = "GR Date"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(250, 266)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'FrmPPORecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.LblGRDate)
        Me.Controls.Add(Me.TboxGRDate)
        Me.Controls.Add(Me.LblGRQty)
        Me.Controls.Add(Me.TboxGRQty)
        Me.Controls.Add(Me.LblPPOQty)
        Me.Controls.Add(Me.TboxPPOQty)
        Me.Controls.Add(Me.LblFTC)
        Me.Controls.Add(Me.TboxFTC)
        Me.Controls.Add(Me.LblLotNum)
        Me.Controls.Add(Me.TboxLotNum)
        Me.Controls.Add(Me.LblMat)
        Me.Controls.Add(Me.TboxMat)
        Me.Controls.Add(Me.LblFw)
        Me.Controls.Add(Me.TboxFw)
        Me.Controls.Add(Me.LblNOPN)
        Me.Controls.Add(Me.TboxNOPN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPPORecords"
        Me.Text = "PPO Records"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TboxNOPN As TextBox
    Friend WithEvents LblNOPN As Label
    Friend WithEvents TboxFw As TextBox
    Friend WithEvents LblFw As Label
    Friend WithEvents TboxMat As TextBox
    Friend WithEvents LblMat As Label
    Friend WithEvents TboxLotNum As TextBox
    Friend WithEvents LblLotNum As Label
    Friend WithEvents TboxFTC As TextBox
    Friend WithEvents LblFTC As Label
    Friend WithEvents TboxPPOQty As TextBox
    Friend WithEvents LblPPOQty As Label
    Friend WithEvents TboxGRQty As TextBox
    Friend WithEvents LblGRQty As Label
    Friend WithEvents TboxGRDate As TextBox
    Friend WithEvents LblGRDate As Label
    Friend WithEvents BtnAdd As Button
End Class
