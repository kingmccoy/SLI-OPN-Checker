<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.DGVLogs = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NeworderingpartnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirmwareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FulltracecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PpoqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTableLogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Logs = New SLI_OPN_Checker.Logs()
        Me.TboxSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.DtpTo = New System.Windows.Forms.DateTimePicker()
        Me.BtnFilter = New System.Windows.Forms.Button()
        CType(Me.DGVLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableLogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVLogs
        '
        Me.DGVLogs.AllowUserToAddRows = False
        Me.DGVLogs.AllowUserToDeleteRows = False
        Me.DGVLogs.AllowUserToResizeRows = False
        Me.DGVLogs.AutoGenerateColumns = False
        Me.DGVLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVLogs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGVLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MaterialDataGridViewTextBoxColumn, Me.NeworderingpartnumberDataGridViewTextBoxColumn, Me.FirmwareDataGridViewTextBoxColumn, Me.LotnumberDataGridViewTextBoxColumn, Me.FulltracecodeDataGridViewTextBoxColumn, Me.PpoqtyDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn})
        Me.DGVLogs.DataSource = Me.DataTableLogsBindingSource
        Me.DGVLogs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVLogs.Location = New System.Drawing.Point(0, 53)
        Me.DGVLogs.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGVLogs.MultiSelect = False
        Me.DGVLogs.Name = "DGVLogs"
        Me.DGVLogs.ReadOnly = True
        Me.DGVLogs.RowHeadersVisible = False
        Me.DGVLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVLogs.Size = New System.Drawing.Size(865, 466)
        Me.DGVLogs.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "material"
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "Material"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        Me.MaterialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NeworderingpartnumberDataGridViewTextBoxColumn
        '
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.DataPropertyName = "new_ordering_part_number"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.FillWeight = 205.0!
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.HeaderText = "New Ordering Part Number"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.Name = "NeworderingpartnumberDataGridViewTextBoxColumn"
        Me.NeworderingpartnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirmwareDataGridViewTextBoxColumn
        '
        Me.FirmwareDataGridViewTextBoxColumn.DataPropertyName = "firmware"
        Me.FirmwareDataGridViewTextBoxColumn.HeaderText = "Firmware"
        Me.FirmwareDataGridViewTextBoxColumn.Name = "FirmwareDataGridViewTextBoxColumn"
        Me.FirmwareDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotnumberDataGridViewTextBoxColumn
        '
        Me.LotnumberDataGridViewTextBoxColumn.DataPropertyName = "lot_number"
        Me.LotnumberDataGridViewTextBoxColumn.FillWeight = 110.0!
        Me.LotnumberDataGridViewTextBoxColumn.HeaderText = "Lot Number"
        Me.LotnumberDataGridViewTextBoxColumn.Name = "LotnumberDataGridViewTextBoxColumn"
        Me.LotnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FulltracecodeDataGridViewTextBoxColumn
        '
        Me.FulltracecodeDataGridViewTextBoxColumn.DataPropertyName = "full_trace_code"
        Me.FulltracecodeDataGridViewTextBoxColumn.FillWeight = 130.0!
        Me.FulltracecodeDataGridViewTextBoxColumn.HeaderText = "Full Trace Code"
        Me.FulltracecodeDataGridViewTextBoxColumn.Name = "FulltracecodeDataGridViewTextBoxColumn"
        Me.FulltracecodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PpoqtyDataGridViewTextBoxColumn
        '
        Me.PpoqtyDataGridViewTextBoxColumn.DataPropertyName = "ppo_qty"
        Me.PpoqtyDataGridViewTextBoxColumn.HeaderText = "PPO Qty"
        Me.PpoqtyDataGridViewTextBoxColumn.Name = "PpoqtyDataGridViewTextBoxColumn"
        Me.PpoqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataTableLogsBindingSource
        '
        Me.DataTableLogsBindingSource.DataMember = "DataTableLogs"
        Me.DataTableLogsBindingSource.DataSource = Me.Logs
        '
        'Logs
        '
        Me.Logs.DataSetName = "Logs"
        Me.Logs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DtpFrom
        '
        Me.DtpFrom.CustomFormat = "MMMM dd, yyyy"
        Me.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFrom.Location = New System.Drawing.Point(427, 18)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.Size = New System.Drawing.Size(148, 23)
        Me.DtpFrom.TabIndex = 3
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Location = New System.Drawing.Point(383, 22)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(38, 15)
        Me.LblFrom.TabIndex = 4
        Me.LblFrom.Text = "From:"
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Location = New System.Drawing.Point(581, 22)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(22, 15)
        Me.LblTo.TabIndex = 5
        Me.LblTo.Text = "To:"
        '
        'DtpTo
        '
        Me.DtpTo.CustomFormat = "MMMM dd, yyyy"
        Me.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpTo.Location = New System.Drawing.Point(609, 18)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(148, 23)
        Me.DtpTo.TabIndex = 6
        '
        'BtnFilter
        '
        Me.BtnFilter.Location = New System.Drawing.Point(764, 13)
        Me.BtnFilter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(88, 33)
        Me.BtnFilter.TabIndex = 7
        Me.BtnFilter.Text = "Filter"
        Me.BtnFilter.UseVisualStyleBackColor = True
        '
        'FrmLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 519)
        Me.Controls.Add(Me.BtnFilter)
        Me.Controls.Add(Me.DtpTo)
        Me.Controls.Add(Me.LblTo)
        Me.Controls.Add(Me.LblFrom)
        Me.Controls.Add(Me.DtpFrom)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TboxSearch)
        Me.Controls.Add(Me.DGVLogs)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogs"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Logs"
        CType(Me.DGVLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableLogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVLogs As DataGridView
    Friend WithEvents TboxSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DataTableLogsBindingSource As BindingSource
    Friend WithEvents Logs As Logs
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NeworderingpartnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirmwareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FulltracecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PpoqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DtpFrom As DateTimePicker
    Friend WithEvents LblFrom As Label
    Friend WithEvents LblTo As Label
    Friend WithEvents DtpTo As DateTimePicker
    Friend WithEvents BtnFilter As Button
End Class
