<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmList))
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderingpartnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTableOPNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPN = New SLI_OPN_Checker.OPN()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TBoxSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableOPNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeRows = False
        Me.dgvList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvList.AutoGenerateColumns = False
        Me.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MaterialnoDataGridViewTextBoxColumn, Me.OrderingpartnoDataGridViewTextBoxColumn})
        Me.dgvList.DataSource = Me.DataTableOPNBindingSource
        Me.dgvList.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.dgvList.Location = New System.Drawing.Point(0, 43)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.Size = New System.Drawing.Size(365, 317)
        Me.dgvList.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.IdDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterialnoDataGridViewTextBoxColumn
        '
        Me.MaterialnoDataGridViewTextBoxColumn.DataPropertyName = "material_no"
        Me.MaterialnoDataGridViewTextBoxColumn.FillWeight = 104.3147!
        Me.MaterialnoDataGridViewTextBoxColumn.HeaderText = "Material No."
        Me.MaterialnoDataGridViewTextBoxColumn.Name = "MaterialnoDataGridViewTextBoxColumn"
        Me.MaterialnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderingpartnoDataGridViewTextBoxColumn
        '
        Me.OrderingpartnoDataGridViewTextBoxColumn.DataPropertyName = "ordering_part_no"
        Me.OrderingpartnoDataGridViewTextBoxColumn.FillWeight = 104.3147!
        Me.OrderingpartnoDataGridViewTextBoxColumn.HeaderText = "Ordering Part No."
        Me.OrderingpartnoDataGridViewTextBoxColumn.Name = "OrderingpartnoDataGridViewTextBoxColumn"
        Me.OrderingpartnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataTableOPNBindingSource
        '
        Me.DataTableOPNBindingSource.DataMember = "DataTableOPN"
        Me.DataTableOPNBindingSource.DataSource = Me.OPN
        '
        'OPN
        '
        Me.OPN.DataSetName = "OPN"
        Me.OPN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(203, 10)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(87, 27)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TBoxSearch
        '
        Me.TBoxSearch.Location = New System.Drawing.Point(12, 12)
        Me.TBoxSearch.Name = "TBoxSearch"
        Me.TBoxSearch.Size = New System.Drawing.Size(185, 23)
        Me.TBoxSearch.TabIndex = 3
        '
        'FrmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 360)
        Me.Controls.Add(Me.TBoxSearch)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.dgvList)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(381, 399)
        Me.Name = "FrmList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OPN List"
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableOPNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvList As DataGridView
    Friend WithEvents DataTableOPNBindingSource As BindingSource
    Friend WithEvents OPN As OPN
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TBoxSearch As TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderingpartnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
