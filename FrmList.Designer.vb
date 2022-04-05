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
        Me.DGVList = New System.Windows.Forms.DataGridView()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TBoxSearch = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderingpartnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTableOPNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPN = New SLI_OPN_Checker.OPN()
        CType(Me.DGVList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableOPNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVList
        '
        Me.DGVList.AllowUserToAddRows = False
        Me.DGVList.AllowUserToDeleteRows = False
        Me.DGVList.AllowUserToResizeRows = False
        Me.DGVList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVList.AutoGenerateColumns = False
        Me.DGVList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MaterialnoDataGridViewTextBoxColumn, Me.OrderingpartnoDataGridViewTextBoxColumn})
        Me.DGVList.DataSource = Me.DataTableOPNBindingSource
        Me.DGVList.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.DGVList.Location = New System.Drawing.Point(0, 43)
        Me.DGVList.MultiSelect = False
        Me.DGVList.Name = "DGVList"
        Me.DGVList.ReadOnly = True
        Me.DGVList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGVList.RowHeadersVisible = False
        Me.DGVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVList.Size = New System.Drawing.Size(488, 472)
        Me.DGVList.TabIndex = 0
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
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(296, 10)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(87, 27)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(389, 10)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(87, 27)
        Me.BtnRemove.TabIndex = 4
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
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
        'FrmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 515)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TBoxSearch)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.DGVList)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(381, 399)
        Me.Name = "FrmList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OPN List"
        CType(Me.DGVList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableOPNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVList As DataGridView
    Friend WithEvents DataTableOPNBindingSource As BindingSource
    Friend WithEvents OPN As OPN
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TBoxSearch As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderingpartnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
