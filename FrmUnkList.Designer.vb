<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnkList
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
        Me.LstBoxUnk = New System.Windows.Forms.ListBox()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstBoxUnk
        '
        Me.LstBoxUnk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstBoxUnk.FormattingEnabled = True
        Me.LstBoxUnk.HorizontalScrollbar = True
        Me.LstBoxUnk.ItemHeight = 15
        Me.LstBoxUnk.Location = New System.Drawing.Point(0, 0)
        Me.LstBoxUnk.Name = "LstBoxUnk"
        Me.LstBoxUnk.Size = New System.Drawing.Size(249, 302)
        Me.LstBoxUnk.TabIndex = 0
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(255, 12)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(74, 32)
        Me.BtnOpen.TabIndex = 1
        Me.BtnOpen.Text = "Open"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(255, 50)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(74, 32)
        Me.BtnRemove.TabIndex = 2
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'FrmUnkList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(337, 308)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.LstBoxUnk)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUnkList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unknown Filename"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstBoxUnk As ListBox
    Friend WithEvents BtnOpen As Button
    Friend WithEvents BtnRemove As Button
End Class
