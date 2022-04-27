﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogs))
        Me.DGVPPOList = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NeworderingpartnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirmwareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FulltracecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PpoqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTablePPOListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PPOList = New SLI_OPN_Checker.PPOList()
        Me.TboxSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        CType(Me.DGVPPOList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTablePPOListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPOList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVPPOList
        '
        Me.DGVPPOList.AllowUserToAddRows = False
        Me.DGVPPOList.AllowUserToDeleteRows = False
        Me.DGVPPOList.AllowUserToResizeRows = False
        Me.DGVPPOList.AutoGenerateColumns = False
        Me.DGVPPOList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVPPOList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVPPOList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGVPPOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPPOList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MaterialDataGridViewTextBoxColumn, Me.NeworderingpartnumberDataGridViewTextBoxColumn, Me.FirmwareDataGridViewTextBoxColumn, Me.LotnumberDataGridViewTextBoxColumn, Me.FulltracecodeDataGridViewTextBoxColumn, Me.PpoqtyDataGridViewTextBoxColumn})
        Me.DGVPPOList.DataSource = Me.DataTablePPOListBindingSource
        Me.DGVPPOList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVPPOList.Location = New System.Drawing.Point(0, 53)
        Me.DGVPPOList.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGVPPOList.MultiSelect = False
        Me.DGVPPOList.Name = "DGVPPOList"
        Me.DGVPPOList.ReadOnly = True
        Me.DGVPPOList.RowHeadersVisible = False
        Me.DGVPPOList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPPOList.Size = New System.Drawing.Size(813, 466)
        Me.DGVPPOList.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 15.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "material"
        Me.MaterialDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "Material"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        Me.MaterialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NeworderingpartnumberDataGridViewTextBoxColumn
        '
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.DataPropertyName = "new_ordering_part_number"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.HeaderText = "New Ordering Part Number"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.Name = "NeworderingpartnumberDataGridViewTextBoxColumn"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirmwareDataGridViewTextBoxColumn
        '
        Me.FirmwareDataGridViewTextBoxColumn.DataPropertyName = "firmware"
        Me.FirmwareDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.FirmwareDataGridViewTextBoxColumn.HeaderText = "Firmware"
        Me.FirmwareDataGridViewTextBoxColumn.Name = "FirmwareDataGridViewTextBoxColumn"
        Me.FirmwareDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotnumberDataGridViewTextBoxColumn
        '
        Me.LotnumberDataGridViewTextBoxColumn.DataPropertyName = "lot_number"
        Me.LotnumberDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.LotnumberDataGridViewTextBoxColumn.HeaderText = "Lot Number"
        Me.LotnumberDataGridViewTextBoxColumn.Name = "LotnumberDataGridViewTextBoxColumn"
        Me.LotnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FulltracecodeDataGridViewTextBoxColumn
        '
        Me.FulltracecodeDataGridViewTextBoxColumn.DataPropertyName = "full_trace_code"
        Me.FulltracecodeDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.FulltracecodeDataGridViewTextBoxColumn.HeaderText = "Full Trace Code"
        Me.FulltracecodeDataGridViewTextBoxColumn.Name = "FulltracecodeDataGridViewTextBoxColumn"
        Me.FulltracecodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PpoqtyDataGridViewTextBoxColumn
        '
        Me.PpoqtyDataGridViewTextBoxColumn.DataPropertyName = "ppo_qty"
        Me.PpoqtyDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.PpoqtyDataGridViewTextBoxColumn.HeaderText = "PPO Qty"
        Me.PpoqtyDataGridViewTextBoxColumn.Name = "PpoqtyDataGridViewTextBoxColumn"
        Me.PpoqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataTablePPOListBindingSource
        '
        Me.DataTablePPOListBindingSource.DataMember = "DataTablePPOList"
        Me.DataTablePPOListBindingSource.DataSource = Me.PPOList
        '
        'PPOList
        '
        Me.PPOList.DataSetName = "PPOList"
        Me.PPOList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TboxSearch
        '
        Me.TboxSearch.Location = New System.Drawing.Point(14, 18)
        Me.TboxSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TboxSearch.Name = "TboxSearch"
        Me.TboxSearch.Size = New System.Drawing.Size(249, 23)
        Me.TboxSearch.TabIndex = 1
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(271, 13)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(88, 33)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(622, 13)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(88, 33)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(716, 13)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(88, 33)
        Me.BtnRemove.TabIndex = 2
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'FrmLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 519)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TboxSearch)
        Me.Controls.Add(Me.DGVPPOList)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogs"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PPO List"
        CType(Me.DGVPPOList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTablePPOListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPOList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NeworderingpartnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirmwareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FulltracecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PpoqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
