<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TboxPath = New System.Windows.Forms.TextBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TboxFolderName = New System.Windows.Forms.TextBox()
        Me.LblFolderName = New System.Windows.Forms.Label()
        Me.LblPath = New System.Windows.Forms.Label()
        Me.LblCM = New System.Windows.Forms.Label()
        Me.LblMaterial = New System.Windows.Forms.Label()
        Me.LblLotNo = New System.Windows.Forms.Label()
        Me.LblStationID = New System.Windows.Forms.Label()
        Me.LblFlowCode = New System.Windows.Forms.Label()
        Me.LblTimeStamp = New System.Windows.Forms.Label()
        Me.LblCMResult = New System.Windows.Forms.Label()
        Me.LblMaterialResult = New System.Windows.Forms.Label()
        Me.LblLotNoResult = New System.Windows.Forms.Label()
        Me.LblStationIDResult = New System.Windows.Forms.Label()
        Me.LblFlowCodeResult = New System.Windows.Forms.Label()
        Me.LblTimeStampResult = New System.Windows.Forms.Label()
        Me.LblCMFeedback = New System.Windows.Forms.Label()
        Me.LblMaterialFeedback = New System.Windows.Forms.Label()
        Me.LblLotNoFeedback = New System.Windows.Forms.Label()
        Me.LblStationIDFeedback = New System.Windows.Forms.Label()
        Me.LblFlowCodeFeedback = New System.Windows.Forms.Label()
        Me.LblTimeStampFeedback = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblFailed = New System.Windows.Forms.Label()
        Me.LblStation = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblStationValue = New System.Windows.Forms.Label()
        Me.LblPassCount = New System.Windows.Forms.Label()
        Me.LblFailedCount = New System.Windows.Forms.Label()
        Me.LblTotalCount = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LblTotalFeedback = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LblPercent = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(603, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ListToolStripMenuItem, Me.ReferenceToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaterialToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AddToolStripMenuItem.Text = "&Add"
        '
        'MaterialToolStripMenuItem
        '
        Me.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem"
        Me.MaterialToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.MaterialToolStripMenuItem.Text = "&Material"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ListToolStripMenuItem.Text = "&List"
        '
        'ReferenceToolStripMenuItem
        '
        Me.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem"
        Me.ReferenceToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ReferenceToolStripMenuItem.Text = "&Reference"
        '
        'TboxPath
        '
        Me.TboxPath.AllowDrop = True
        Me.TboxPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TboxPath.Location = New System.Drawing.Point(57, 34)
        Me.TboxPath.Name = "TboxPath"
        Me.TboxPath.Size = New System.Drawing.Size(436, 23)
        Me.TboxPath.TabIndex = 1
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrowse.Location = New System.Drawing.Point(499, 33)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(92, 27)
        Me.BtnBrowse.TabIndex = 2
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'BtnCheck
        '
        Me.BtnCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCheck.Location = New System.Drawing.Point(499, 61)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(92, 27)
        Me.BtnCheck.TabIndex = 3
        Me.BtnCheck.Text = "Check OPN"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'TboxFolderName
        '
        Me.TboxFolderName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TboxFolderName.Location = New System.Drawing.Point(57, 63)
        Me.TboxFolderName.Name = "TboxFolderName"
        Me.TboxFolderName.Size = New System.Drawing.Size(436, 23)
        Me.TboxFolderName.TabIndex = 3
        '
        'LblFolderName
        '
        Me.LblFolderName.AutoSize = True
        Me.LblFolderName.Location = New System.Drawing.Point(12, 66)
        Me.LblFolderName.Name = "LblFolderName"
        Me.LblFolderName.Size = New System.Drawing.Size(39, 15)
        Me.LblFolderName.TabIndex = 3
        Me.LblFolderName.Text = "Name"
        '
        'LblPath
        '
        Me.LblPath.AutoSize = True
        Me.LblPath.Location = New System.Drawing.Point(12, 39)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(31, 15)
        Me.LblPath.TabIndex = 1
        Me.LblPath.Text = "Path"
        '
        'LblCM
        '
        Me.LblCM.AutoSize = True
        Me.LblCM.Location = New System.Drawing.Point(12, 103)
        Me.LblCM.Name = "LblCM"
        Me.LblCM.Size = New System.Drawing.Size(134, 15)
        Me.LblCM.TabIndex = 4
        Me.LblCM.Text = "Company Manufacturer"
        '
        'LblMaterial
        '
        Me.LblMaterial.AutoSize = True
        Me.LblMaterial.Location = New System.Drawing.Point(12, 123)
        Me.LblMaterial.Name = "LblMaterial"
        Me.LblMaterial.Size = New System.Drawing.Size(50, 15)
        Me.LblMaterial.TabIndex = 5
        Me.LblMaterial.Text = "Material"
        '
        'LblLotNo
        '
        Me.LblLotNo.AutoSize = True
        Me.LblLotNo.Location = New System.Drawing.Point(12, 143)
        Me.LblLotNo.Name = "LblLotNo"
        Me.LblLotNo.Size = New System.Drawing.Size(71, 15)
        Me.LblLotNo.TabIndex = 6
        Me.LblLotNo.Text = "Lot Number"
        '
        'LblStationID
        '
        Me.LblStationID.AutoSize = True
        Me.LblStationID.Location = New System.Drawing.Point(12, 163)
        Me.LblStationID.Name = "LblStationID"
        Me.LblStationID.Size = New System.Drawing.Size(58, 15)
        Me.LblStationID.TabIndex = 7
        Me.LblStationID.Text = "Station ID"
        '
        'LblFlowCode
        '
        Me.LblFlowCode.AutoSize = True
        Me.LblFlowCode.Location = New System.Drawing.Point(12, 183)
        Me.LblFlowCode.Name = "LblFlowCode"
        Me.LblFlowCode.Size = New System.Drawing.Size(63, 15)
        Me.LblFlowCode.TabIndex = 8
        Me.LblFlowCode.Text = "Flow Code"
        '
        'LblTimeStamp
        '
        Me.LblTimeStamp.AutoSize = True
        Me.LblTimeStamp.Location = New System.Drawing.Point(12, 203)
        Me.LblTimeStamp.Name = "LblTimeStamp"
        Me.LblTimeStamp.Size = New System.Drawing.Size(70, 15)
        Me.LblTimeStamp.TabIndex = 9
        Me.LblTimeStamp.Text = "Time Stamp"
        '
        'LblCMResult
        '
        Me.LblCMResult.AutoSize = True
        Me.LblCMResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCMResult.Location = New System.Drawing.Point(155, 103)
        Me.LblCMResult.Name = "LblCMResult"
        Me.LblCMResult.Size = New System.Drawing.Size(24, 15)
        Me.LblCMResult.TabIndex = 4
        Me.LblCMResult.Text = "OK"
        '
        'LblMaterialResult
        '
        Me.LblMaterialResult.AutoSize = True
        Me.LblMaterialResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterialResult.Location = New System.Drawing.Point(155, 123)
        Me.LblMaterialResult.Name = "LblMaterialResult"
        Me.LblMaterialResult.Size = New System.Drawing.Size(24, 15)
        Me.LblMaterialResult.TabIndex = 5
        Me.LblMaterialResult.Text = "OK"
        '
        'LblLotNoResult
        '
        Me.LblLotNoResult.AutoSize = True
        Me.LblLotNoResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLotNoResult.Location = New System.Drawing.Point(155, 143)
        Me.LblLotNoResult.Name = "LblLotNoResult"
        Me.LblLotNoResult.Size = New System.Drawing.Size(24, 15)
        Me.LblLotNoResult.TabIndex = 6
        Me.LblLotNoResult.Text = "OK"
        '
        'LblStationIDResult
        '
        Me.LblStationIDResult.AutoSize = True
        Me.LblStationIDResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStationIDResult.Location = New System.Drawing.Point(155, 163)
        Me.LblStationIDResult.Name = "LblStationIDResult"
        Me.LblStationIDResult.Size = New System.Drawing.Size(24, 15)
        Me.LblStationIDResult.TabIndex = 7
        Me.LblStationIDResult.Text = "OK"
        '
        'LblFlowCodeResult
        '
        Me.LblFlowCodeResult.AutoSize = True
        Me.LblFlowCodeResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlowCodeResult.Location = New System.Drawing.Point(155, 183)
        Me.LblFlowCodeResult.Name = "LblFlowCodeResult"
        Me.LblFlowCodeResult.Size = New System.Drawing.Size(24, 15)
        Me.LblFlowCodeResult.TabIndex = 8
        Me.LblFlowCodeResult.Text = "OK"
        '
        'LblTimeStampResult
        '
        Me.LblTimeStampResult.AutoSize = True
        Me.LblTimeStampResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeStampResult.Location = New System.Drawing.Point(155, 203)
        Me.LblTimeStampResult.Name = "LblTimeStampResult"
        Me.LblTimeStampResult.Size = New System.Drawing.Size(24, 15)
        Me.LblTimeStampResult.TabIndex = 9
        Me.LblTimeStampResult.Text = "OK"
        '
        'LblCMFeedback
        '
        Me.LblCMFeedback.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCMFeedback.AutoSize = True
        Me.LblCMFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCMFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblCMFeedback.Location = New System.Drawing.Point(256, 103)
        Me.LblCMFeedback.Name = "LblCMFeedback"
        Me.LblCMFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblCMFeedback.TabIndex = 4
        Me.LblCMFeedback.Text = "Feedback"
        '
        'LblMaterialFeedback
        '
        Me.LblMaterialFeedback.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblMaterialFeedback.AutoSize = True
        Me.LblMaterialFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterialFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblMaterialFeedback.Location = New System.Drawing.Point(256, 123)
        Me.LblMaterialFeedback.Name = "LblMaterialFeedback"
        Me.LblMaterialFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblMaterialFeedback.TabIndex = 5
        Me.LblMaterialFeedback.Text = "Feedback"
        '
        'LblLotNoFeedback
        '
        Me.LblLotNoFeedback.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblLotNoFeedback.AutoSize = True
        Me.LblLotNoFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLotNoFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblLotNoFeedback.Location = New System.Drawing.Point(256, 143)
        Me.LblLotNoFeedback.Name = "LblLotNoFeedback"
        Me.LblLotNoFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblLotNoFeedback.TabIndex = 6
        Me.LblLotNoFeedback.Text = "Feedback"
        '
        'LblStationIDFeedback
        '
        Me.LblStationIDFeedback.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblStationIDFeedback.AutoSize = True
        Me.LblStationIDFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStationIDFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblStationIDFeedback.Location = New System.Drawing.Point(256, 163)
        Me.LblStationIDFeedback.Name = "LblStationIDFeedback"
        Me.LblStationIDFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblStationIDFeedback.TabIndex = 7
        Me.LblStationIDFeedback.Text = "Feedback"
        '
        'LblFlowCodeFeedback
        '
        Me.LblFlowCodeFeedback.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblFlowCodeFeedback.AutoSize = True
        Me.LblFlowCodeFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlowCodeFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblFlowCodeFeedback.Location = New System.Drawing.Point(256, 183)
        Me.LblFlowCodeFeedback.Name = "LblFlowCodeFeedback"
        Me.LblFlowCodeFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblFlowCodeFeedback.TabIndex = 8
        Me.LblFlowCodeFeedback.Text = "Feedback"
        '
        'LblTimeStampFeedback
        '
        Me.LblTimeStampFeedback.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblTimeStampFeedback.AutoSize = True
        Me.LblTimeStampFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeStampFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblTimeStampFeedback.Location = New System.Drawing.Point(256, 203)
        Me.LblTimeStampFeedback.Name = "LblTimeStampFeedback"
        Me.LblTimeStampFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblTimeStampFeedback.TabIndex = 9
        Me.LblTimeStampFeedback.Text = "Feedback"
        '
        'LblPass
        '
        Me.LblPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPass.AutoSize = True
        Me.LblPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPass.Location = New System.Drawing.Point(398, 123)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(30, 15)
        Me.LblPass.TabIndex = 11
        Me.LblPass.Text = "Pass"
        '
        'LblFailed
        '
        Me.LblFailed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFailed.AutoSize = True
        Me.LblFailed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFailed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblFailed.Location = New System.Drawing.Point(398, 143)
        Me.LblFailed.Name = "LblFailed"
        Me.LblFailed.Size = New System.Drawing.Size(38, 15)
        Me.LblFailed.TabIndex = 12
        Me.LblFailed.Text = "Failed"
        '
        'LblStation
        '
        Me.LblStation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblStation.AutoSize = True
        Me.LblStation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblStation.Location = New System.Drawing.Point(398, 103)
        Me.LblStation.Name = "LblStation"
        Me.LblStation.Size = New System.Drawing.Size(44, 15)
        Me.LblStation.TabIndex = 10
        Me.LblStation.Text = "Station"
        '
        'LblTotal
        '
        Me.LblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTotal.Location = New System.Drawing.Point(398, 163)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(32, 15)
        Me.LblTotal.TabIndex = 13
        Me.LblTotal.Text = "Total"
        '
        'LblStationValue
        '
        Me.LblStationValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblStationValue.AutoSize = True
        Me.LblStationValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStationValue.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LblStationValue.Location = New System.Drawing.Point(448, 103)
        Me.LblStationValue.Name = "LblStationValue"
        Me.LblStationValue.Size = New System.Drawing.Size(65, 15)
        Me.LblStationValue.TabIndex = 10
        Me.LblStationValue.Text = "Calibration"
        '
        'LblPassCount
        '
        Me.LblPassCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPassCount.AutoSize = True
        Me.LblPassCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassCount.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LblPassCount.Location = New System.Drawing.Point(448, 123)
        Me.LblPassCount.Name = "LblPassCount"
        Me.LblPassCount.Size = New System.Drawing.Size(46, 15)
        Me.LblPassCount.TabIndex = 11
        Me.LblPassCount.Text = "999,999"
        '
        'LblFailedCount
        '
        Me.LblFailedCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFailedCount.AutoSize = True
        Me.LblFailedCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFailedCount.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LblFailedCount.Location = New System.Drawing.Point(448, 143)
        Me.LblFailedCount.Name = "LblFailedCount"
        Me.LblFailedCount.Size = New System.Drawing.Size(46, 15)
        Me.LblFailedCount.TabIndex = 12
        Me.LblFailedCount.Text = "999,999"
        '
        'LblTotalCount
        '
        Me.LblTotalCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalCount.AutoSize = True
        Me.LblTotalCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalCount.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LblTotalCount.Location = New System.Drawing.Point(448, 163)
        Me.LblTotalCount.Name = "LblTotalCount"
        Me.LblTotalCount.Size = New System.Drawing.Size(46, 15)
        Me.LblTotalCount.TabIndex = 13
        Me.LblTotalCount.Text = "999,999"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(507, 186)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(84, 35)
        Me.BtnSave.TabIndex = 15
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 226)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(579, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 16
        '
        'LblTotalFeedback
        '
        Me.LblTotalFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalFeedback.AutoSize = True
        Me.LblTotalFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalFeedback.ForeColor = System.Drawing.Color.Red
        Me.LblTotalFeedback.Location = New System.Drawing.Point(500, 163)
        Me.LblTotalFeedback.Name = "LblTotalFeedback"
        Me.LblTotalFeedback.Size = New System.Drawing.Size(72, 15)
        Me.LblTotalFeedback.TabIndex = 14
        Me.LblTotalFeedback.Text = "Click to view"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'LblPercent
        '
        Me.LblPercent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPercent.BackColor = System.Drawing.Color.Transparent
        Me.LblPercent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPercent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPercent.Location = New System.Drawing.Point(0, 252)
        Me.LblPercent.Name = "LblPercent"
        Me.LblPercent.Size = New System.Drawing.Size(603, 18)
        Me.LblPercent.TabIndex = 17
        Me.LblPercent.Text = "100%"
        Me.LblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 274)
        Me.Controls.Add(Me.LblPercent)
        Me.Controls.Add(Me.LblTotalFeedback)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblTotalCount)
        Me.Controls.Add(Me.LblFailedCount)
        Me.Controls.Add(Me.LblPassCount)
        Me.Controls.Add(Me.LblStationValue)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.LblStation)
        Me.Controls.Add(Me.LblFailed)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.LblTimeStampFeedback)
        Me.Controls.Add(Me.LblFlowCodeFeedback)
        Me.Controls.Add(Me.LblStationIDFeedback)
        Me.Controls.Add(Me.LblLotNoFeedback)
        Me.Controls.Add(Me.LblMaterialFeedback)
        Me.Controls.Add(Me.LblCMFeedback)
        Me.Controls.Add(Me.LblTimeStampResult)
        Me.Controls.Add(Me.LblFlowCodeResult)
        Me.Controls.Add(Me.LblStationIDResult)
        Me.Controls.Add(Me.LblLotNoResult)
        Me.Controls.Add(Me.LblMaterialResult)
        Me.Controls.Add(Me.LblCMResult)
        Me.Controls.Add(Me.LblTimeStamp)
        Me.Controls.Add(Me.LblFlowCode)
        Me.Controls.Add(Me.LblStationID)
        Me.Controls.Add(Me.LblLotNo)
        Me.Controls.Add(Me.LblMaterial)
        Me.Controls.Add(Me.LblCM)
        Me.Controls.Add(Me.LblPath)
        Me.Controls.Add(Me.LblFolderName)
        Me.Controls.Add(Me.TboxFolderName)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.TboxPath)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(619, 313)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SLI OPN Checker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TboxPath As TextBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents BtnCheck As Button
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TboxFolderName As TextBox
    Friend WithEvents LblFolderName As Label
    Friend WithEvents LblPath As Label
    Friend WithEvents LblCM As Label
    Friend WithEvents LblMaterial As Label
    Friend WithEvents LblLotNo As Label
    Friend WithEvents LblStationID As Label
    Friend WithEvents LblFlowCode As Label
    Friend WithEvents LblTimeStamp As Label
    Friend WithEvents LblCMResult As Label
    Friend WithEvents LblMaterialResult As Label
    Friend WithEvents LblLotNoResult As Label
    Friend WithEvents LblStationIDResult As Label
    Friend WithEvents LblFlowCodeResult As Label
    Friend WithEvents LblTimeStampResult As Label
    Friend WithEvents LblCMFeedback As Label
    Friend WithEvents LblMaterialFeedback As Label
    Friend WithEvents LblLotNoFeedback As Label
    Friend WithEvents LblStationIDFeedback As Label
    Friend WithEvents LblFlowCodeFeedback As Label
    Friend WithEvents LblTimeStampFeedback As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents LblFailed As Label
    Friend WithEvents LblStation As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblStationValue As Label
    Friend WithEvents LblPassCount As Label
    Friend WithEvents LblFailedCount As Label
    Friend WithEvents LblTotalCount As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LblTotalFeedback As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ReferenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblPercent As Label
End Class
