﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LblTotalFeedback = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BWorkerSave = New System.ComponentModel.BackgroundWorker()
        Me.LblPercent = New System.Windows.Forms.Label()
        Me.GroupBoxFormatCheck = New System.Windows.Forms.GroupBox()
        Me.GroupBoxFormat = New System.Windows.Forms.GroupBox()
        Me.GroupBoxOPNCheck = New System.Windows.Forms.GroupBox()
        Me.LblLotNoResultFinal = New System.Windows.Forms.Label()
        Me.LblMaterialResultFinal = New System.Windows.Forms.Label()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBoxFTPServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxBrowse = New System.Windows.Forms.TextBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.pBar2 = New System.Windows.Forms.ProgressBar()
        Me.LabelProgress = New System.Windows.Forms.Label()
        Me.ButtonUplload = New System.Windows.Forms.Button()
        Me.LabelPercentage = New System.Windows.Forms.Label()
        Me.BWorkerFTPUpload = New System.ComponentModel.BackgroundWorker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.OPNListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OPNListToolStripMenuItem.Text = "&OPN List"
        '
        'ReferenceToolStripMenuItem
        '
        Me.ReferenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FTPCredentialsToolStripMenuItem, Me.DirectoryToolStripMenuItem})
        Me.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem"
        Me.ReferenceToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReferenceToolStripMenuItem.Text = "&Reference"
        '
        'FTPCredentialsToolStripMenuItem
        '
        Me.FTPCredentialsToolStripMenuItem.Name = "FTPCredentialsToolStripMenuItem"
        Me.FTPCredentialsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FTPCredentialsToolStripMenuItem.Text = "&FTP Credentials"
        '
        'DirectoryToolStripMenuItem
        '
        Me.DirectoryToolStripMenuItem.Name = "DirectoryToolStripMenuItem"
        Me.DirectoryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DirectoryToolStripMenuItem.Text = "&Directory"
        '
        'PPOListToolStripMenuItem
        '
        Me.PPOListToolStripMenuItem.Name = "PPOListToolStripMenuItem"
        Me.PPOListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PPOListToolStripMenuItem.Text = "&PPO List"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogsToolStripMenuItem.Text = "&Logs"
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
        Me.LblCMFeedback.Location = New System.Drawing.Point(388, 121)
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
        Me.LblMaterialFeedback.Location = New System.Drawing.Point(388, 141)
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
        Me.LblLotNoFeedback.Location = New System.Drawing.Point(388, 161)
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
        Me.LblStationIDFeedback.Location = New System.Drawing.Point(388, 181)
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
        Me.LblFlowCodeFeedback.Location = New System.Drawing.Point(388, 201)
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
        Me.LblTimeStampFeedback.Location = New System.Drawing.Point(388, 221)
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
        Me.LblPass.Location = New System.Drawing.Point(519, 141)
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
        Me.LblFailed.Location = New System.Drawing.Point(519, 161)
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
        Me.LblStation.Location = New System.Drawing.Point(519, 121)
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
        Me.LblTotal.Location = New System.Drawing.Point(519, 181)
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
        Me.LblStationValue.Location = New System.Drawing.Point(569, 121)
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
        Me.LblPassCount.Location = New System.Drawing.Point(569, 141)
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
        Me.LblFailedCount.Location = New System.Drawing.Point(569, 161)
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
        Me.LblTotalCount.Location = New System.Drawing.Point(569, 181)
        Me.LblTotalCount.Name = "LblTotalCount"
        Me.LblTotalCount.Size = New System.Drawing.Size(46, 15)
        Me.LblTotalCount.TabIndex = 13
        Me.LblTotalCount.Text = "999,999"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(628, 204)
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
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 250)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(700, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 16
        '
        'LblTotalFeedback
        '
        Me.LblTotalFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalFeedback.AutoSize = True
        Me.LblTotalFeedback.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalFeedback.ForeColor = System.Drawing.Color.Red
        Me.LblTotalFeedback.Location = New System.Drawing.Point(621, 181)
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
        '
        'LblPercent
        '
        Me.LblPercent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPercent.BackColor = System.Drawing.Color.Transparent
        Me.LblPercent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPercent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPercent.Location = New System.Drawing.Point(0, 276)
        Me.LblPercent.Name = "LblPercent"
        Me.LblPercent.Size = New System.Drawing.Size(724, 18)
        Me.LblPercent.TabIndex = 17
        Me.LblPercent.Text = "100%"
        Me.LblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GroupBoxFormatCheck.Location = New System.Drawing.Point(184, 103)
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
        Me.GroupBoxFormat.Location = New System.Drawing.Point(12, 103)
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
        Me.GroupBoxOPNCheck.Location = New System.Drawing.Point(286, 103)
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
        'TextBoxFTPServer
        '
        Me.TextBoxFTPServer.Location = New System.Drawing.Point(82, 302)
        Me.TextBoxFTPServer.Name = "TextBoxFTPServer"
        Me.TextBoxFTPServer.Size = New System.Drawing.Size(124, 23)
        Me.TextBoxFTPServer.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "FTP Server:"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(336, 302)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(124, 23)
        Me.TextBoxUsername.TabIndex = 20
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(590, 302)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(124, 23)
        Me.TextBoxPassword.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(524, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "File to Upload:"
        '
        'TextBoxBrowse
        '
        Me.TextBoxBrowse.Location = New System.Drawing.Point(101, 345)
        Me.TextBoxBrowse.Name = "TextBoxBrowse"
        Me.TextBoxBrowse.Size = New System.Drawing.Size(530, 23)
        Me.TextBoxBrowse.TabIndex = 20
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(637, 342)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 29)
        Me.ButtonBrowse.TabIndex = 22
        Me.ButtonBrowse.Text = "Browse"
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'pBar2
        '
        Me.pBar2.Location = New System.Drawing.Point(101, 380)
        Me.pBar2.Name = "pBar2"
        Me.pBar2.Size = New System.Drawing.Size(483, 23)
        Me.pBar2.TabIndex = 23
        '
        'LabelProgress
        '
        Me.LabelProgress.AutoSize = True
        Me.LabelProgress.Location = New System.Drawing.Point(12, 384)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(52, 15)
        Me.LabelProgress.TabIndex = 21
        Me.LabelProgress.Text = "Progress"
        '
        'ButtonUplload
        '
        Me.ButtonUplload.Location = New System.Drawing.Point(637, 377)
        Me.ButtonUplload.Name = "ButtonUplload"
        Me.ButtonUplload.Size = New System.Drawing.Size(75, 29)
        Me.ButtonUplload.TabIndex = 22
        Me.ButtonUplload.Text = "Upload"
        Me.ButtonUplload.UseVisualStyleBackColor = True
        '
        'LabelPercentage
        '
        Me.LabelPercentage.AutoSize = True
        Me.LabelPercentage.Location = New System.Drawing.Point(587, 384)
        Me.LabelPercentage.Name = "LabelPercentage"
        Me.LabelPercentage.Size = New System.Drawing.Size(23, 15)
        Me.LabelPercentage.TabIndex = 21
        Me.LabelPercentage.Text = "0%"
        '
        'BWorkerFTPUpload
        '
        Me.BWorkerFTPUpload.WorkerReportsProgress = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 427)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(499, 23)
        Me.TextBox1.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Folder:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(606, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(606, 456)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 459)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "File:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 456)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(499, 23)
        Me.TextBox2.TabIndex = 27
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(637, 427)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Zip"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(637, 456)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Zip"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(101, 485)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(499, 23)
        Me.ProgressBar2.TabIndex = 32
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(3, 536)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(121, 97)
        Me.TreeView1.TabIndex = 33
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 665)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.pBar2)
        Me.Controls.Add(Me.ButtonUplload)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelPercentage)
        Me.Controls.Add(Me.LabelProgress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.TextBoxBrowse)
        Me.Controls.Add(Me.TextBoxFTPServer)
        Me.Controls.Add(Me.GroupBoxFormat)
        Me.Controls.Add(Me.GroupBoxOPNCheck)
        Me.Controls.Add(Me.GroupBoxFormatCheck)
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
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LblTotalFeedback As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ReferenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BWorkerSave As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblPercent As Label
    Friend WithEvents PPOListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBoxFormatCheck As GroupBox
    Friend WithEvents GroupBoxFormat As GroupBox
    Friend WithEvents GroupBoxOPNCheck As GroupBox
    Friend WithEvents LblLotNoResultFinal As Label
    Friend WithEvents LblMaterialResultFinal As Label
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents LogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pBar2 As ProgressBar
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxBrowse As TextBox
    Friend WithEvents TextBoxFTPServer As TextBox
    Friend WithEvents ButtonUplload As Button
    Friend WithEvents LabelProgress As Label
    Friend WithEvents LabelPercentage As Label
    Friend WithEvents BWorkerFTPUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FTPCredentialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
