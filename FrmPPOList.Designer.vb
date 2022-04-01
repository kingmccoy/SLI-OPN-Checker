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
        Me.DGVPPOList = New System.Windows.Forms.DataGridView()
        Me.PPOList = New SLI_OPN_Checker.PPOList()
        Me.DataTablePPOListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.DGVPPOList.AutoGenerateColumns = False
        Me.DGVPPOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPPOList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NeworderingpartnumberDataGridViewTextBoxColumn, Me.FirmwareDataGridViewTextBoxColumn, Me.MaterialDataGridViewTextBoxColumn, Me.LotnumberDataGridViewTextBoxColumn, Me.FulltracecodeDataGridViewTextBoxColumn, Me.PpoqtyDataGridViewTextBoxColumn, Me.SapgrqtyDataGridViewTextBoxColumn, Me.GrdateDataGridViewTextBoxColumn})
        Me.DGVPPOList.DataSource = Me.DataTablePPOListBindingSource
        Me.DGVPPOList.Location = New System.Drawing.Point(12, 41)
        Me.DGVPPOList.Name = "DGVPPOList"
        Me.DGVPPOList.ReadOnly = True
        Me.DGVPPOList.Size = New System.Drawing.Size(651, 379)
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
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NeworderingpartnumberDataGridViewTextBoxColumn
        '
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.DataPropertyName = "new_ordering_part_number"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.HeaderText = "new_ordering_part_number"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.Name = "NeworderingpartnumberDataGridViewTextBoxColumn"
        '
        'FirmwareDataGridViewTextBoxColumn
        '
        Me.FirmwareDataGridViewTextBoxColumn.DataPropertyName = "firmware"
        Me.FirmwareDataGridViewTextBoxColumn.HeaderText = "firmware"
        Me.FirmwareDataGridViewTextBoxColumn.Name = "FirmwareDataGridViewTextBoxColumn"
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "material"
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "material"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        '
        'LotnumberDataGridViewTextBoxColumn
        '
        Me.LotnumberDataGridViewTextBoxColumn.DataPropertyName = "lot_number"
        Me.LotnumberDataGridViewTextBoxColumn.HeaderText = "lot_number"
        Me.LotnumberDataGridViewTextBoxColumn.Name = "LotnumberDataGridViewTextBoxColumn"
        '
        'FulltracecodeDataGridViewTextBoxColumn
        '
        Me.FulltracecodeDataGridViewTextBoxColumn.DataPropertyName = "full_trace_code"
        Me.FulltracecodeDataGridViewTextBoxColumn.HeaderText = "full_trace_code"
        Me.FulltracecodeDataGridViewTextBoxColumn.Name = "FulltracecodeDataGridViewTextBoxColumn"
        '
        'PpoqtyDataGridViewTextBoxColumn
        '
        Me.PpoqtyDataGridViewTextBoxColumn.DataPropertyName = "ppo_qty"
        Me.PpoqtyDataGridViewTextBoxColumn.HeaderText = "ppo_qty"
        Me.PpoqtyDataGridViewTextBoxColumn.Name = "PpoqtyDataGridViewTextBoxColumn"
        '
        'SapgrqtyDataGridViewTextBoxColumn
        '
        Me.SapgrqtyDataGridViewTextBoxColumn.DataPropertyName = "sap_gr_qty"
        Me.SapgrqtyDataGridViewTextBoxColumn.HeaderText = "sap_gr_qty"
        Me.SapgrqtyDataGridViewTextBoxColumn.Name = "SapgrqtyDataGridViewTextBoxColumn"
        '
        'GrdateDataGridViewTextBoxColumn
        '
        Me.GrdateDataGridViewTextBoxColumn.DataPropertyName = "gr_date"
        Me.GrdateDataGridViewTextBoxColumn.HeaderText = "gr_date"
        Me.GrdateDataGridViewTextBoxColumn.Name = "GrdateDataGridViewTextBoxColumn"
        '
        'FrmPPOList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 450)
        Me.Controls.Add(Me.DGVPPOList)
        Me.Name = "FrmPPOList"
        Me.Text = "FrmPPOList"
        CType(Me.DGVPPOList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPOList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTablePPOListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVPPOList As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NeworderingpartnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirmwareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FulltracecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PpoqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SapgrqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataTablePPOListBindingSource As BindingSource
    Friend WithEvents PPOList As PPOList
End Class
