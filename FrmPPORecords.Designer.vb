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
        Me.components = New System.ComponentModel.Container()
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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TboxNOPN
        '
        Me.TboxNOPN.Location = New System.Drawing.Point(202, 41)
        Me.TboxNOPN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TboxNOPN.Name = "TboxNOPN"
        Me.TboxNOPN.Size = New System.Drawing.Size(178, 23)
        Me.TboxNOPN.TabIndex = 1
        '
        'LblNOPN
        '
        Me.LblNOPN.AutoSize = True
        Me.LblNOPN.Location = New System.Drawing.Point(15, 45)
        Me.LblNOPN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNOPN.Name = "LblNOPN"
        Me.LblNOPN.Size = New System.Drawing.Size(152, 15)
        Me.LblNOPN.TabIndex = 1
        Me.LblNOPN.Text = "New Ordering Part Number"
        '
        'TboxFw
        '
        Me.TboxFw.Location = New System.Drawing.Point(202, 71)
        Me.TboxFw.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TboxFw.Name = "TboxFw"
        Me.TboxFw.Size = New System.Drawing.Size(178, 23)
        Me.TboxFw.TabIndex = 2
        '
        'LblFw
        '
        Me.LblFw.AutoSize = True
        Me.LblFw.Location = New System.Drawing.Point(15, 75)
        Me.LblFw.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFw.Name = "LblFw"
        Me.LblFw.Size = New System.Drawing.Size(56, 15)
        Me.LblFw.TabIndex = 2
        Me.LblFw.Text = "Firmware"
        '
        'TboxMat
        '
        Me.TboxMat.Location = New System.Drawing.Point(202, 12)
        Me.TboxMat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TboxMat.Name = "TboxMat"
        Me.TboxMat.Size = New System.Drawing.Size(178, 23)
        Me.TboxMat.TabIndex = 0
        '
        'LblMat
        '
        Me.LblMat.AutoSize = True
        Me.LblMat.Location = New System.Drawing.Point(15, 16)
        Me.LblMat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMat.Name = "LblMat"
        Me.LblMat.Size = New System.Drawing.Size(50, 15)
        Me.LblMat.TabIndex = 0
        Me.LblMat.Text = "Material"
        '
        'TboxLotNum
        '
        Me.TboxLotNum.Location = New System.Drawing.Point(202, 100)
        Me.TboxLotNum.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TboxLotNum.Name = "TboxLotNum"
        Me.TboxLotNum.Size = New System.Drawing.Size(178, 23)
        Me.TboxLotNum.TabIndex = 3
        '
        'LblLotNum
        '
        Me.LblLotNum.AutoSize = True
        Me.LblLotNum.Location = New System.Drawing.Point(15, 104)
        Me.LblLotNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLotNum.Name = "LblLotNum"
        Me.LblLotNum.Size = New System.Drawing.Size(71, 15)
        Me.LblLotNum.TabIndex = 3
        Me.LblLotNum.Text = "Lot Number"
        '
        'TboxFTC
        '
        Me.TboxFTC.Location = New System.Drawing.Point(202, 130)
        Me.TboxFTC.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TboxFTC.Name = "TboxFTC"
        Me.TboxFTC.Size = New System.Drawing.Size(178, 23)
        Me.TboxFTC.TabIndex = 4
        '
        'LblFTC
        '
        Me.LblFTC.AutoSize = True
        Me.LblFTC.Location = New System.Drawing.Point(15, 133)
        Me.LblFTC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFTC.Name = "LblFTC"
        Me.LblFTC.Size = New System.Drawing.Size(87, 15)
        Me.LblFTC.TabIndex = 4
        Me.LblFTC.Text = "Full Trace Code"
        '
        'TboxPPOQty
        '
        Me.TboxPPOQty.Location = New System.Drawing.Point(202, 160)
        Me.TboxPPOQty.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TboxPPOQty.Name = "TboxPPOQty"
        Me.TboxPPOQty.Size = New System.Drawing.Size(178, 23)
        Me.TboxPPOQty.TabIndex = 5
        '
        'LblPPOQty
        '
        Me.LblPPOQty.AutoSize = True
        Me.LblPPOQty.Location = New System.Drawing.Point(15, 164)
        Me.LblPPOQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPPOQty.Name = "LblPPOQty"
        Me.LblPPOQty.Size = New System.Drawing.Size(52, 15)
        Me.LblPPOQty.TabIndex = 5
        Me.LblPPOQty.Text = "PPO Qty"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(202, 191)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(94, 33)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmPPORecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 236)
        Me.Controls.Add(Me.BtnAdd)
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
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPPORecords"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PPO Records"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnAdd As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
