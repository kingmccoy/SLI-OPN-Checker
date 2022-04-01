<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPPOList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPPOList))
        Me.DGVPPOList = New System.Windows.Forms.DataGridView()
        Me.PPOList = New SLI_OPN_Checker.PPOList()
        Me.DataTablePPOListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TboxSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NeworderingpartnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirmwareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FulltracecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PpoqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SapgrqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVPPOList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPOList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTablePPOListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVPPOList
        '
        Me.DGVPPOList.AllowUserToAddRows = False
        Me.DGVPPOList.AllowUserToDeleteRows = False
        Me.DGVPPOList.AllowUserToResizeRows = False
        Me.DGVPPOList.AutoGenerateColumns = False
        Me.DGVPPOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPPOList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NeworderingpartnumberDataGridViewTextBoxColumn, Me.FirmwareDataGridViewTextBoxColumn, Me.MaterialDataGridViewTextBoxColumn, Me.LotnumberDataGridViewTextBoxColumn, Me.FulltracecodeDataGridViewTextBoxColumn, Me.PpoqtyDataGridViewTextBoxColumn, Me.SapgrqtyDataGridViewTextBoxColumn, Me.GrdateDataGridViewTextBoxColumn})
        Me.DGVPPOList.DataSource = Me.DataTablePPOListBindingSource
        Me.DGVPPOList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVPPOList.Location = New System.Drawing.Point(0, 46)
        Me.DGVPPOList.MultiSelect = False
        Me.DGVPPOList.Name = "DGVPPOList"
        Me.DGVPPOList.ReadOnly = True
        Me.DGVPPOList.RowHeadersVisible = False
        Me.DGVPPOList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPPOList.Size = New System.Drawing.Size(905, 404)
        Me.DGVPPOList.TabIndex = 0
        '
        'PPOList
        '
        Me.PPOList.DataSetName = "PPOList"
        Me.PPOList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTablePPOListBindingSource
        '
        Me.DataTablePPOListBindingSource.DataMember = "DataTablePPOList"
        Me.DataTablePPOListBindingSource.DataSource = Me.PPOList
        '
        'TboxSearch
        '
        Me.TboxSearch.Location = New System.Drawing.Point(12, 16)
        Me.TboxSearch.Name = "TboxSearch"
        Me.TboxSearch.Size = New System.Drawing.Size(214, 20)
        Me.TboxSearch.TabIndex = 1
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(232, 11)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 29)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(737, 11)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 29)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(818, 11)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 29)
        Me.BtnRemove.TabIndex = 2
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'NeworderingpartnumberDataGridViewTextBoxColumn
        '
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.DataPropertyName = "new_ordering_part_number"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.HeaderText = "New Ordering Part Number"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.Name = "NeworderingpartnumberDataGridViewTextBoxColumn"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.Width = 160
        '
        'FirmwareDataGridViewTextBoxColumn
        '
        Me.FirmwareDataGridViewTextBoxColumn.DataPropertyName = "firmware"
        Me.FirmwareDataGridViewTextBoxColumn.HeaderText = "Firmware"
        Me.FirmwareDataGridViewTextBoxColumn.Name = "FirmwareDataGridViewTextBoxColumn"
        Me.FirmwareDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "material"
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "Material"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        Me.MaterialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotnumberDataGridViewTextBoxColumn
        '
        Me.LotnumberDataGridViewTextBoxColumn.DataPropertyName = "lot_number"
        Me.LotnumberDataGridViewTextBoxColumn.HeaderText = "Lot Number"
        Me.LotnumberDataGridViewTextBoxColumn.Name = "LotnumberDataGridViewTextBoxColumn"
        Me.LotnumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.LotnumberDataGridViewTextBoxColumn.Width = 85
        '
        'FulltracecodeDataGridViewTextBoxColumn
        '
        Me.FulltracecodeDataGridViewTextBoxColumn.DataPropertyName = "full_trace_code"
        Me.FulltracecodeDataGridViewTextBoxColumn.HeaderText = "Full Trace Code"
        Me.FulltracecodeDataGridViewTextBoxColumn.Name = "FulltracecodeDataGridViewTextBoxColumn"
        Me.FulltracecodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.FulltracecodeDataGridViewTextBoxColumn.Width = 120
        '
        'PpoqtyDataGridViewTextBoxColumn
        '
        Me.PpoqtyDataGridViewTextBoxColumn.DataPropertyName = "ppo_qty"
        Me.PpoqtyDataGridViewTextBoxColumn.HeaderText = "PPO Qty"
        Me.PpoqtyDataGridViewTextBoxColumn.Name = "PpoqtyDataGridViewTextBoxColumn"
        Me.PpoqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SapgrqtyDataGridViewTextBoxColumn
        '
        Me.SapgrqtyDataGridViewTextBoxColumn.DataPropertyName = "sap_gr_qty"
        Me.SapgrqtyDataGridViewTextBoxColumn.HeaderText = "SAP GR Qty"
        Me.SapgrqtyDataGridViewTextBoxColumn.Name = "SapgrqtyDataGridViewTextBoxColumn"
        Me.SapgrqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GrdateDataGridViewTextBoxColumn
        '
        Me.GrdateDataGridViewTextBoxColumn.DataPropertyName = "gr_date"
        Me.GrdateDataGridViewTextBoxColumn.HeaderText = "GR Date"
        Me.GrdateDataGridViewTextBoxColumn.Name = "GrdateDataGridViewTextBoxColumn"
        Me.GrdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmPPOList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 450)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TboxSearch)
        Me.Controls.Add(Me.DGVPPOList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPPOList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PPO List"
        CType(Me.DGVPPOList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPOList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTablePPOListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVPPOList As DataGridView
    Friend WithEvents DataTablePPOListBindingSource As BindingSource
    Friend WithEvents PPOList As PPOList
    Friend WithEvents TboxSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NeworderingpartnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirmwareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FulltracecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PpoqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SapgrqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
