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
        Me.OPNListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FTPCredentialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PPOListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.LblCMResultInitial = New System.Windows.Forms.Label()
        Me.LblMaterialResultInitial = New System.Windows.Forms.Label()
        Me.LblLotNoResultInitial = New System.Windows.Forms.Label()
        Me.LblStationIDResultInitial = New System.Windows.Forms.Label()
        Me.LblFlowCodeResultInitial = New System.Windows.Forms.Label()
        Me.LblTimeStampResultInitial = New System.Windows.Forms.Label()
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
        Me.PbarSaving = New System.Windows.Forms.ProgressBar()
        Me.LblTotalFeedback = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BWorkerSave = New System.ComponentModel.BackgroundWorker()
        Me.LblSavingPercentage = New System.Windows.Forms.Label()
        Me.GroupBoxFormatCheck = New System.Windows.Forms.GroupBox()
        Me.GroupBoxFormat = New System.Windows.Forms.GroupBox()
        Me.GroupBoxOPNCheck = New System.Windows.Forms.GroupBox()
        Me.LblLotNoResultFinal = New System.Windows.Forms.Label()
        Me.LblMaterialResultFinal = New System.Windows.Forms.Label()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PbarFTP = New System.Windows.Forms.ProgressBar()
        Me.LblFTPProgress = New System.Windows.Forms.Label()
        Me.LblFTPPercentage = New System.Windows.Forms.Label()
        Me.BWorkerFTPUpload = New System.ComponentModel.BackgroundWorker()
        Me.ChkBoxFTPUpload = New System.Windows.Forms.CheckBox()
        Me.LblSavingProgress = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxFormatCheck.SuspendLayout()
        Me.GroupBoxFormat.SuspendLayout()
        Me.GroupBoxOPNCheck.SuspendLayout()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(724, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPNListToolStripMenuItem, Me.ReferenceToolStripMenuItem, Me.PPOListToolStripMenuItem, Me.LogsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OPNListToolStripMenuItem
        '
        Me.OPNListToolStripMenuItem.Name = "OPNListToolStripMenuItem"
        Me.OPNListToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.OPNListToolStripMenuItem.Text = "&OPN List"
        '
        'ReferenceToolStripMenuItem
        '
        Me.ReferenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FTPCredentialsToolStripMenuItem, Me.DirectoryToolStripMenuItem})
        Me.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem"
        Me.ReferenceToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ReferenceToolStripMenuItem.Text = "&Reference"
        '
        'FTPCredentialsToolStripMenuItem
        '
        Me.FTPCredentialsToolStripMenuItem.Name = "FTPCredentialsToolStripMenuItem"
        Me.FTPCredentialsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.FTPCredentialsToolStripMenuItem.Text = "&FTP Credentials"
        '
        'DirectoryToolStripMenuItem
        '
        Me.DirectoryToolStripMenuItem.Name = "DirectoryToolStripMenuItem"
        Me.DirectoryToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DirectoryToolStripMenuItem.Text = "&Directory"
        '
        'PPOListToolStripMenuItem
        '
        Me.PPOListToolStripMenuItem.Name = "PPOListToolStripMenuItem"
        Me.PPOListToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PPOListToolStripMenuItem.Text = "&PPO List"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.LogsToolStripMenuItem.Text = "&Logs"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'TboxPath
        '
        Me.TboxPath.AllowDrop = True
        Me.TboxPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TboxPath.Location = New System.Drawing.Point(57, 34)
        Me.TboxPath.Name = "TboxPath"
        Me.TboxPath.Size = New System.Drawing.Size(557, 23)
        Me.TboxPath.TabIndex = 1
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrowse.Location = New System.Drawing.Point(620, 33)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(92, 27)
        Me.BtnBrowse.TabIndex = 2
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'BtnCheck
        '
        Me.BtnCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCheck.Location = New System.Drawing.Point(620, 61)
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
        Me.TboxFolderName.Size = New System.Drawing.Size(557, 23)
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
        Me.LblCM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCM.Location = New System.Drawing.Point(6, 19)
        Me.LblCM.Name = "LblCM"
        Me.LblCM.Size = New System.Drawing.Size(134, 15)
        Me.LblCM.TabIndex = 4
        Me.LblCM.Text = "Company Manufacturer"
        '
        'LblMaterial
        '
        Me.LblMaterial.AutoSize = True
        Me.LblMaterial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterial.Location = New System.Drawing.Point(6, 39)
        Me.LblMaterial.Name = "LblMaterial"
        Me.LblMaterial.Size = New System.Drawing.Size(50, 15)
        Me.LblMaterial.TabIndex = 5
        Me.LblMaterial.Text = "Material"
        '
        'LblLotNo
        '
        Me.LblLotNo.AutoSize = True
        Me.LblLotNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLotNo.Location = New System.Drawing.Point(6, 59)
        Me.LblLotNo.Name = "LblLotNo"
        Me.LblLotNo.Size = New System.Drawing.Size(71, 15)
        Me.LblLotNo.TabIndex = 6
        Me.LblLotNo.Text = "Lot Number"
        '
        'LblStationID
        '
        Me.LblStationID.AutoSize = True
        Me.LblStationID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStationID.Location = New System.Drawing.Point(6, 79)
        Me.LblStationID.Name = "LblStationID"
        Me.LblStationID.Size = New System.Drawing.Size(58, 15)
        Me.LblStationID.TabIndex = 7
        Me.LblStationID.Text = "Station ID"
        '
        'LblFlowCode
        '
        Me.LblFlowCode.AutoSize = True
        Me.LblFlowCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlowCode.Location = New System.Drawing.Point(6, 99)
        Me.LblFlowCode.Name = "LblFlowCode"
        Me.LblFlowCode.Size = New System.Drawing.Size(63, 15)
        Me.LblFlowCode.TabIndex = 8
        Me.LblFlowCode.Text = "Flow Code"
        '
        'LblTimeStamp
        '
        Me.LblTimeStamp.AutoSize = True
        Me.LblTimeStamp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeStamp.Location = New System.Drawing.Point(6, 119)
        Me.LblTimeStamp.Name = "LblTimeStamp"
        Me.LblTimeStamp.Size = New System.Drawing.Size(70, 15)
        Me.LblTimeStamp.TabIndex = 9
        Me.LblTimeStamp.Text = "Time Stamp"
        '
        'LblCMResultInitial
        '
        Me.LblCMResultInitial.AutoSize = True
        Me.LblCMResultInitial.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCMResultInitial.Location = New System.Drawing.Point(36, 18)
        Me.LblCMResultInitial.Name = "LblCMResultInitial"
        Me.LblCMResultInitial.Size = New System.Drawing.Size(24, 15)
        Me.LblCMResultInitial.TabIndex = 4
        Me.LblCMResultInitial.Text = "OK"
        '
        'LblMaterialResultInitial
        '
        Me.LblMaterialResultInitial.AutoSize = True
        Me.LblMaterialResultInitial.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterialResultInitial.Location = New System.Drawing.Point(36, 38)
        Me.LblMaterialResultInitial.Name = "LblMaterialResultInitial"
        Me.LblMaterialResultInitial.Size = New System.Drawing.Size(24, 15)
        Me.LblMaterialResultInitial.TabIndex = 5
        Me.LblMaterialResultInitial.Text = "OK"
        '
        'LblLotNoResultInitial
        '
        Me.LblLotNoResultInitial.AutoSize = True
        Me.LblLotNoResultInitial.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLotNoResultInitial.Location = New System.Drawing.Point(36, 58)
        Me.LblLotNoResultInitial.Name = "LblLotNoResultInitial"
        Me.LblLotNoResultInitial.Size = New System.Drawing.Size(24, 15)
        Me.LblLotNoResultInitial.TabIndex = 6
        Me.LblLotNoResultInitial.Text = "OK"
        '
        'LblStationIDResultInitial
        '
        Me.LblStationIDResultInitial.AutoSize = True
        Me.LblStationIDResultInitial.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStationIDResultInitial.Location = New System.Drawing.Point(36, 78)
        Me.LblStationIDResultInitial.Name = "LblStationIDResultInitial"
        Me.LblStationIDResultInitial.Size = New System.Drawing.Size(24, 15)
        Me.LblStationIDResultInitial.TabIndex = 7
        Me.LblStationIDResultInitial.Text = "OK"
        '
        'LblFlowCodeResultInitial
        '
        Me.LblFlowCodeResultInitial.AutoSize = True
        Me.LblFlowCodeResultInitial.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlowCodeResultInitial.Location = New System.Drawing.Point(36, 98)
        Me.LblFlowCodeResultInitial.Name = "LblFlowCodeResultInitial"
        Me.LblFlowCodeResultInitial.Size = New System.Drawing.Size(24, 15)
        Me.LblFlowCodeResultInitial.TabIndex = 8
        Me.LblFlowCodeResultInitial.Text = "OK"
        '
        'LblTimeStampResultInitial
        '
        Me.LblTimeStampResultInitial.AutoSize = True
        Me.LblTimeStampResultInitial.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeStampResultInitial.Location = New System.Drawing.Point(36, 118)
        Me.LblTimeStampResultInitial.Name = "LblTimeStampResultInitial"
        Me.LblTimeStampResultInitial.Size = New System.Drawing.Size(24, 15)
        Me.LblTimeStampResultInitial.TabIndex = 9
        Me.LblTimeStampResultInitial.Text = "OK"
        '
        'LblCMFeedback
        '
        Me.LblCMFeedback.AutoSize = True
        Me.LblCMFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCMFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblCMFeedback.Location = New System.Drawing.Point(388, 135)
        Me.LblCMFeedback.Name = "LblCMFeedback"
        Me.LblCMFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblCMFeedback.TabIndex = 4
        Me.LblCMFeedback.Text = "Feedback"
        '
        'LblMaterialFeedback
        '
        Me.LblMaterialFeedback.AutoSize = True
        Me.LblMaterialFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterialFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblMaterialFeedback.Location = New System.Drawing.Point(388, 155)
        Me.LblMaterialFeedback.Name = "LblMaterialFeedback"
        Me.LblMaterialFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblMaterialFeedback.TabIndex = 5
        Me.LblMaterialFeedback.Text = "Feedback"
        '
        'LblLotNoFeedback
        '
        Me.LblLotNoFeedback.AutoSize = True
        Me.LblLotNoFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLotNoFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblLotNoFeedback.Location = New System.Drawing.Point(388, 175)
        Me.LblLotNoFeedback.Name = "LblLotNoFeedback"
        Me.LblLotNoFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblLotNoFeedback.TabIndex = 6
        Me.LblLotNoFeedback.Text = "Feedback"
        '
        'LblStationIDFeedback
        '
        Me.LblStationIDFeedback.AutoSize = True
        Me.LblStationIDFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStationIDFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblStationIDFeedback.Location = New System.Drawing.Point(388, 195)
        Me.LblStationIDFeedback.Name = "LblStationIDFeedback"
        Me.LblStationIDFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblStationIDFeedback.TabIndex = 7
        Me.LblStationIDFeedback.Text = "Feedback"
        '
        'LblFlowCodeFeedback
        '
        Me.LblFlowCodeFeedback.AutoSize = True
        Me.LblFlowCodeFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFlowCodeFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblFlowCodeFeedback.Location = New System.Drawing.Point(388, 215)
        Me.LblFlowCodeFeedback.Name = "LblFlowCodeFeedback"
        Me.LblFlowCodeFeedback.Size = New System.Drawing.Size(57, 15)
        Me.LblFlowCodeFeedback.TabIndex = 8
        Me.LblFlowCodeFeedback.Text = "Feedback"
        '
        'LblTimeStampFeedback
        '
        Me.LblTimeStampFeedback.AutoSize = True
        Me.LblTimeStampFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeStampFeedback.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblTimeStampFeedback.Location = New System.Drawing.Point(388, 235)
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
        Me.LblPass.Location = New System.Drawing.Point(519, 155)
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
        Me.LblFailed.Location = New System.Drawing.Point(519, 175)
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
        Me.LblStation.Location = New System.Drawing.Point(519, 135)
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
        Me.LblTotal.Location = New System.Drawing.Point(519, 195)
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
        Me.LblStationValue.Location = New System.Drawing.Point(569, 135)
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
        Me.LblPassCount.Location = New System.Drawing.Point(569, 155)
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
        Me.LblFailedCount.Location = New System.Drawing.Point(569, 175)
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
        Me.LblTotalCount.Location = New System.Drawing.Point(569, 195)
        Me.LblTotalCount.Name = "LblTotalCount"
        Me.LblTotalCount.Size = New System.Drawing.Size(46, 15)
        Me.LblTotalCount.TabIndex = 13
        Me.LblTotalCount.Text = "999,999"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(628, 218)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(84, 35)
        Me.BtnSave.TabIndex = 15
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'PbarSaving
        '
        Me.PbarSaving.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbarSaving.Location = New System.Drawing.Point(70, 264)
        Me.PbarSaving.Name = "PbarSaving"
        Me.PbarSaving.Size = New System.Drawing.Size(577, 23)
        Me.PbarSaving.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PbarSaving.TabIndex = 16
        '
        'LblTotalFeedback
        '
        Me.LblTotalFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalFeedback.AutoSize = True
        Me.LblTotalFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalFeedback.ForeColor = System.Drawing.Color.Red
        Me.LblTotalFeedback.Location = New System.Drawing.Point(621, 195)
        Me.LblTotalFeedback.Name = "LblTotalFeedback"
        Me.LblTotalFeedback.Size = New System.Drawing.Size(72, 15)
        Me.LblTotalFeedback.TabIndex = 14
        Me.LblTotalFeedback.Text = "Click to view"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BWorkerSave
        '
        Me.BWorkerSave.WorkerReportsProgress = True
        Me.BWorkerSave.WorkerSupportsCancellation = True
        '
        'LblSavingPercentage
        '
        Me.LblSavingPercentage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSavingPercentage.AutoSize = True
        Me.LblSavingPercentage.BackColor = System.Drawing.Color.Transparent
        Me.LblSavingPercentage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSavingPercentage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblSavingPercentage.Location = New System.Drawing.Point(653, 268)
        Me.LblSavingPercentage.Name = "LblSavingPercentage"
        Me.LblSavingPercentage.Size = New System.Drawing.Size(35, 15)
        Me.LblSavingPercentage.TabIndex = 17
        Me.LblSavingPercentage.Text = "100%"
        Me.LblSavingPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxFormatCheck
        '
        Me.GroupBoxFormatCheck.Controls.Add(Me.LblTimeStampResultInitial)
        Me.GroupBoxFormatCheck.Controls.Add(Me.LblFlowCodeResultInitial)
        Me.GroupBoxFormatCheck.Controls.Add(Me.LblStationIDResultInitial)
        Me.GroupBoxFormatCheck.Controls.Add(Me.LblLotNoResultInitial)
        Me.GroupBoxFormatCheck.Controls.Add(Me.LblMaterialResultInitial)
        Me.GroupBoxFormatCheck.Controls.Add(Me.LblCMResultInitial)
        Me.GroupBoxFormatCheck.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFormatCheck.Location = New System.Drawing.Point(184, 117)
        Me.GroupBoxFormatCheck.Name = "GroupBoxFormatCheck"
        Me.GroupBoxFormatCheck.Size = New System.Drawing.Size(96, 141)
        Me.GroupBoxFormatCheck.TabIndex = 18
        Me.GroupBoxFormatCheck.TabStop = False
        Me.GroupBoxFormatCheck.Text = "Format Check"
        '
        'GroupBoxFormat
        '
        Me.GroupBoxFormat.Controls.Add(Me.LblCM)
        Me.GroupBoxFormat.Controls.Add(Me.LblMaterial)
        Me.GroupBoxFormat.Controls.Add(Me.LblLotNo)
        Me.GroupBoxFormat.Controls.Add(Me.LblStationID)
        Me.GroupBoxFormat.Controls.Add(Me.LblFlowCode)
        Me.GroupBoxFormat.Controls.Add(Me.LblTimeStamp)
        Me.GroupBoxFormat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFormat.Location = New System.Drawing.Point(12, 117)
        Me.GroupBoxFormat.Name = "GroupBoxFormat"
        Me.GroupBoxFormat.Size = New System.Drawing.Size(166, 141)
        Me.GroupBoxFormat.TabIndex = 19
        Me.GroupBoxFormat.TabStop = False
        Me.GroupBoxFormat.Text = "OPN Format"
        '
        'GroupBoxOPNCheck
        '
        Me.GroupBoxOPNCheck.Controls.Add(Me.LblLotNoResultFinal)
        Me.GroupBoxOPNCheck.Controls.Add(Me.LblMaterialResultFinal)
        Me.GroupBoxOPNCheck.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOPNCheck.Location = New System.Drawing.Point(286, 117)
        Me.GroupBoxOPNCheck.Name = "GroupBoxOPNCheck"
        Me.GroupBoxOPNCheck.Size = New System.Drawing.Size(96, 141)
        Me.GroupBoxOPNCheck.TabIndex = 18
        Me.GroupBoxOPNCheck.TabStop = False
        Me.GroupBoxOPNCheck.Text = "OPN Check"
        '
        'LblLotNoResultFinal
        '
        Me.LblLotNoResultFinal.AutoSize = True
        Me.LblLotNoResultFinal.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLotNoResultFinal.Location = New System.Drawing.Point(36, 58)
        Me.LblLotNoResultFinal.Name = "LblLotNoResultFinal"
        Me.LblLotNoResultFinal.Size = New System.Drawing.Size(24, 15)
        Me.LblLotNoResultFinal.TabIndex = 6
        Me.LblLotNoResultFinal.Text = "OK"
        '
        'LblMaterialResultFinal
        '
        Me.LblMaterialResultFinal.AutoSize = True
        Me.LblMaterialResultFinal.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterialResultFinal.Location = New System.Drawing.Point(36, 38)
        Me.LblMaterialResultFinal.Name = "LblMaterialResultFinal"
        Me.LblMaterialResultFinal.Size = New System.Drawing.Size(24, 15)
        Me.LblMaterialResultFinal.TabIndex = 5
        Me.LblMaterialResultFinal.Text = "OK"
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'PbarFTP
        '
        Me.PbarFTP.Location = New System.Drawing.Point(70, 293)
        Me.PbarFTP.Name = "PbarFTP"
        Me.PbarFTP.Size = New System.Drawing.Size(577, 23)
        Me.PbarFTP.TabIndex = 23
        '
        'LblFTPProgress
        '
        Me.LblFTPProgress.AutoSize = True
        Me.LblFTPProgress.Location = New System.Drawing.Point(12, 297)
        Me.LblFTPProgress.Name = "LblFTPProgress"
        Me.LblFTPProgress.Size = New System.Drawing.Size(26, 15)
        Me.LblFTPProgress.TabIndex = 21
        Me.LblFTPProgress.Text = "FTP"
        '
        'LblFTPPercentage
        '
        Me.LblFTPPercentage.AutoSize = True
        Me.LblFTPPercentage.Location = New System.Drawing.Point(653, 297)
        Me.LblFTPPercentage.Name = "LblFTPPercentage"
        Me.LblFTPPercentage.Size = New System.Drawing.Size(35, 15)
        Me.LblFTPPercentage.TabIndex = 21
        Me.LblFTPPercentage.Text = "100%"
        '
        'BWorkerFTPUpload
        '
        Me.BWorkerFTPUpload.WorkerReportsProgress = True
        Me.BWorkerFTPUpload.WorkerSupportsCancellation = True
        '
        'ChkBoxFTPUpload
        '
        Me.ChkBoxFTPUpload.AutoSize = True
        Me.ChkBoxFTPUpload.Location = New System.Drawing.Point(461, 92)
        Me.ChkBoxFTPUpload.Name = "ChkBoxFTPUpload"
        Me.ChkBoxFTPUpload.Size = New System.Drawing.Size(141, 19)
        Me.ChkBoxFTPUpload.TabIndex = 34
        Me.ChkBoxFTPUpload.Text = "Upload OPN on finish"
        Me.ChkBoxFTPUpload.UseVisualStyleBackColor = True
        '
        'LblSavingProgress
        '
        Me.LblSavingProgress.AutoSize = True
        Me.LblSavingProgress.Location = New System.Drawing.Point(12, 268)
        Me.LblSavingProgress.Name = "LblSavingProgress"
        Me.LblSavingProgress.Size = New System.Drawing.Size(42, 15)
        Me.LblSavingProgress.TabIndex = 35
        Me.LblSavingProgress.Text = "Saving"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 330)
        Me.Controls.Add(Me.LblSavingProgress)
        Me.Controls.Add(Me.ChkBoxFTPUpload)
        Me.Controls.Add(Me.PbarFTP)
        Me.Controls.Add(Me.LblFTPPercentage)
        Me.Controls.Add(Me.LblFTPProgress)
        Me.Controls.Add(Me.GroupBoxFormat)
        Me.Controls.Add(Me.GroupBoxOPNCheck)
        Me.Controls.Add(Me.GroupBoxFormatCheck)
        Me.Controls.Add(Me.LblSavingPercentage)
        Me.Controls.Add(Me.LblTotalFeedback)
        Me.Controls.Add(Me.PbarSaving)
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
        Me.Controls.Add(Me.LblPath)
        Me.Controls.Add(Me.LblFolderName)
        Me.Controls.Add(Me.TboxFolderName)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.TboxPath)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(619, 313)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SLI OPN Checker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxFormatCheck.ResumeLayout(False)
        Me.GroupBoxFormatCheck.PerformLayout()
        Me.GroupBoxFormat.ResumeLayout(False)
        Me.GroupBoxFormat.PerformLayout()
        Me.GroupBoxOPNCheck.ResumeLayout(False)
        Me.GroupBoxOPNCheck.PerformLayout()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TboxPath As TextBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents BtnCheck As Button
    Friend WithEvents OPNListToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents LblCMResultInitial As Label
    Friend WithEvents LblMaterialResultInitial As Label
    Friend WithEvents LblLotNoResultInitial As Label
    Friend WithEvents LblStationIDResultInitial As Label
    Friend WithEvents LblFlowCodeResultInitial As Label
    Friend WithEvents LblTimeStampResultInitial As Label
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
    Friend WithEvents PbarSaving As ProgressBar
    Friend WithEvents LblTotalFeedback As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ReferenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BWorkerSave As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblSavingPercentage As Label
    Friend WithEvents PPOListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBoxFormatCheck As GroupBox
    Friend WithEvents GroupBoxFormat As GroupBox
    Friend WithEvents GroupBoxOPNCheck As GroupBox
    Friend WithEvents LblLotNoResultFinal As Label
    Friend WithEvents LblMaterialResultFinal As Label
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents LogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PbarFTP As ProgressBar
    Friend WithEvents LblFTPProgress As Label
    Friend WithEvents LblFTPPercentage As Label
    Friend WithEvents BWorkerFTPUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents FTPCredentialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChkBoxFTPUpload As CheckBox
    Friend WithEvents LblSavingProgress As Label
End Class
