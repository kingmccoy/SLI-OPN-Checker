﻿Imports System.Data.SQLite
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.IO.Compression
Imports System.ComponentModel
Imports System.Net

Public Class FrmMain
    ReadOnly conn As New SQLiteConnection
    Public ReadOnly strng As New List(Of String)
    Public defSavingPath As String = ToString()
    Public DefDir As String = ToString()
    Dim dirTrue, defFin, refFin, FtpFailed As Boolean
    Public zip As ZipArchive

    ReadOnly ftpFilePath As String = Nothing
    Dim dirPath, LogStation, LogLot As String
    Dim passed, failed, quantity As Integer

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPNListToolStripMenuItem.Click
        FrmList.ShowDialog()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SendToBack()
        TboxFolderName.ReadOnly = True
        'ProgressBar1.Visible = False
        LblSavingPercentage.Visible = False
        LblFTPPercentage.Visible = False
        ChkBoxFTPUpload.Checked = True
        'LblPercent.Text = Nothing
        Clear()

        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Sub Clear()
        LblCMResultInitial.Visible = False
        LblMaterialResultInitial.Visible = False
        LblLotNoResultInitial.Visible = False
        LblStationIDResultInitial.Visible = False
        LblFlowCodeResultInitial.Visible = False
        LblTimeStampResultInitial.Visible = False

        LblCMResultInitial.Text = Nothing
        LblMaterialResultInitial.Text = Nothing
        LblLotNoResultInitial.Text = Nothing
        LblStationIDResultInitial.Text = Nothing
        LblFlowCodeResultInitial.Text = Nothing
        LblTimeStampResultInitial.Text = Nothing

        LblMaterialResultFinal.Text = Nothing
        LblLotNoResultFinal.Text = Nothing

        LblCMFeedback.Visible = False
        LblMaterialFeedback.Visible = False
        LblLotNoFeedback.Visible = False
        LblStationIDFeedback.Visible = False
        LblFlowCodeFeedback.Visible = False
        LblTimeStampFeedback.Visible = False

        LblCMFeedback.Text = Nothing
        LblMaterialFeedback.Text = Nothing
        LblLotNoFeedback.Text = Nothing
        LblStationIDFeedback.Text = Nothing
        LblFlowCodeFeedback.Text = Nothing
        LblTimeStampFeedback.Text = Nothing

        LblStationValue.Visible = False
        LblPassCount.Visible = False
        LblFailedCount.Visible = False
        LblTotalCount.Visible = False

        LblStationValue.Text = Nothing
        LblPassCount.Text = Nothing
        LblFailedCount.Text = Nothing
        LblTotalCount.Text = Nothing

        LblTotalFeedback.Visible = False
        LblTotalFeedback.Text = Nothing

        BtnSave.Visible = False
        LblViewOPN.Visible = False
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        FolderBrowserDialog1.Description = "Select test data log"

        Dim ResultDialog As DialogResult = FolderBrowserDialog1.ShowDialog

        If ResultDialog = DialogResult.OK Then
            Dim f As New System.IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            Dim path = f.FullName
            Dim name = f.Name
            TboxPath.Text = path
            TboxFolderName.Text = name
        End If
    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        'start - Checking OPN format
        Dim rg As String = "^([ionicsIONICS]{6})_((r9113|R9113)[a-zA-Z0-9]{9})_71[0-9]{5}\.[0-9]{1,2}_([uartUART]{4}|[calibCALIB]{5}|[ftFT]{2}|)-[0-9]{2}-F[0-9]{2}_([a-zA-Z]|[FP])_[0-9]{4}[0-9]{2}[0-9]{2}[0-9]{2}[0-9]{2}[0-9]{2}$"
        'Dim rg As String = "^([a-zA-Z]+)_([a-zA-Z0-9]+)_([0-9\.0-9]+)_([a-zA-Z]+\-[0-9]+\-[a-zA-Z][0-9]*)_([a-zA-Z])_([a-zA-Z0-9]+)$"
        '"[IONICS]+_([A-Z0-9]+)_([0-9\.0-9]+)_((CALIB|FT|UART)\-[0-9]{2}\-[FR][0-9]{2})_(.*)_([0-9]+)"

        'start - directory check
        If TboxPath.Text = Nothing Then
            MessageBox.Show("Please browse the directory to proceed!", "No Direcotry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Directory.Exists(TboxPath.Text) Then
            MessageBox.Show("Directory do not exist!", "Direcotry Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Clear()
            Return
        End If
        'end

        If Regex.IsMatch(TboxFolderName.Text, rg) = False Then
            MessageBox.Show("Filename invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'end

        'start - Checking the correct format
        Dim cm = "^(IONICS)"
        Dim material = "(R9113[A-Z0-9]{9})"
        Dim lot = "(71[0-9]{5}\.[1-9][0-9]|71[0-9]{5}\.[1-9]{1,2})"
        Dim stationid = "((UART|CALIB|FT)-[0-9]{2}-F[0-9]{2})"
        Dim fcode = "([fp])"
        Dim tstamp = "([0-9]{4}[0-9]{2}[0-9]{2}[0-9]{2}[0-9]{2}[0-9]{2}$)"
        'end

        'start - Error feedback check
        Dim cmc, materialc, lotc, stationidc, fcodec, tstampc As Match
        cmc = Regex.Match(TboxFolderName.Text, "^[a-zA-Z]+")
        materialc = Regex.Match(TboxFolderName.Text, "_[a-zA-Z0-9]{14}_")
        lotc = Regex.Match(TboxFolderName.Text, "_71[0-9]{5}\.[0-9]{1,2}")
        stationidc = Regex.Match(TboxFolderName.Text, "_([uartUART]{4}|[calibCALIB]{5}|[ftFT]{2}|)-[0-9]{2}-[fF][0-9]{2}") '"_[a-zA-Z]+\-[0-9]+\-[a-zA-Z][0-9]+")
        fcodec = Regex.Match(TboxFolderName.Text, "_[a-zA-Z]_")
        tstampc = Regex.Match(TboxFolderName.Text, "[0-9]+$")
        'end

        'cmr = New Regex("^[IONICS]+")
        'materialr = New Regex("_[A-Z0-9]*")
        'lotr = New Regex("[0-9\.0-9]+")
        'stationidr = New Regex("[A-Z]+\-[0-9]{2}\-[FR][0-9]{2}")
        'fcoder = New Regex("[a-z]")
        'tstampr = New Regex("[0-9]+$")

        Dim MatList As New List(Of String)
        'Dim CountMat As Integer

        Dim r As String = Regex.IsMatch(TboxFolderName.Text, material)

        'start - Checking Company Manufacturer
        If Regex.IsMatch(TboxFolderName.Text, cm) Then
            LblCMResultInitial.Visible = True
            LblCMResultInitial.ForeColor = Color.Green
            LblCMResultInitial.Text = "✔"
            LblCMFeedback.Visible = False
            LblCMFeedback.Text = Nothing
            ErrorProvider1.SetError(LblCMFeedback, "")
        Else
            LblCMResultInitial.Visible = True
            LblCMResultInitial.ForeColor = Color.Red
            LblCMResultInitial.Text = "✘"
            LblCMFeedback.Visible = True
            LblCMFeedback.Text = cmc.Value

            If Regex.IsMatch(LblCMFeedback.Text, "[a-z]+") Then
                ErrorProvider1.SetError(LblCMFeedback, "must be uppercase")
            Else
                If Regex.IsMatch(LblCMFeedback.Text, "^(IONICS)") = False Then
                    ErrorProvider1.SetError(LblCMFeedback, "must be IONICS")
                End If
            End If
        End If
        'end

        'start - Checking Material
        'If Regex.IsMatch(TboxFolderName.Text, material) Then

        'Dim table As New DataTable

        Try
            conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
            Dim matval As Match = Regex.Match(TboxFolderName.Text, "R9113[A-Z0-9]{9}")
            Dim q = "select material_no from material where material_no='" & matval.Value & "'"
            Dim mat As String = ToString()
            Dim y As Boolean

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        mat = reader("material_no").ToString
                        y = True
                    Else
                        y = False
                    End If
                End Using
                'Dim adapter As New SQLiteDataAdapter(cmd)
                'adapter.Fill(table)
            End Using
            conn.Close()

            If y = True Then
                LblMaterialResultInitial.Visible = True
                LblMaterialResultInitial.ForeColor = Color.Green
                LblMaterialResultInitial.Text = "✔"
                LblMaterialFeedback.Visible = False
                LblMaterialFeedback.Text = Nothing
                ErrorProvider1.SetError(LblMaterialFeedback, "")
            Else
                LblMaterialResultInitial.Visible = True
                LblMaterialResultInitial.ForeColor = Color.Red
                LblMaterialResultInitial.Text = "✘"
                LblMaterialFeedback.Visible = True
                LblMaterialFeedback.Text = materialc.Value.Substring(1, 14)

                If Regex.IsMatch(LblMaterialFeedback.Text, "[a-z]") Then
                    ErrorProvider1.SetError(LblMaterialFeedback, "must be uppercase")
                Else
                    If Regex.IsMatch(LblMaterialFeedback.Text, "[A-Z0-9]+") Then
                        ErrorProvider1.SetError(LblMaterialFeedback, "do not match in the database")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



        'For Each row As DataRow In table.Rows
        '    MatList.Add(row.Item("material_no"))
        'Next

        'Dim y As Boolean

        'For Each dt In MatList
        '    Dim reg As Match
        '    reg = Regex.Match(TboxFolderName.Text, "R9113[A-Z0-9]{9}")
        '    If dt = reg.Value Then
        '        y = True
        '    End If
        'Next


        'If y = True Then


        'Else
        '    LblMaterialResultInitial.Visible = True
        '    LblMaterialResultInitial.ForeColor = Color.Red
        '    LblMaterialResultInitial.Text = "✘"
        '    LblMaterialFeedback.Visible = True
        '    LblMaterialFeedback.Text = materialc.Value.Substring(1, 14)

        '    If Regex.IsMatch(LblMaterialFeedback.Text, "[a-z]") Then
        '        ErrorProvider1.SetError(LblMaterialFeedback, "must be uppercase")
        '    Else
        '        If Regex.IsMatch(LblMaterialFeedback.Text, "[A-Z0-9]+") Then
        '            ErrorProvider1.SetError(LblMaterialFeedback, "do not match in the database")
        '        End If
        '    End If
        'End If
        'end
        'End If

        'start - Checking lot number
        If Regex.IsMatch(TboxFolderName.Text, lot) Then
            LblLotNoResultInitial.Visible = True
            LblLotNoResultInitial.ForeColor = Color.Green
            LblLotNoResultInitial.Text = "✔"
            LblLotNoFeedback.Visible = False
            LblLotNoFeedback.Text = Nothing
            ErrorProvider1.SetError(LblLotNoFeedback, "")
            FrmOPNInformation.Lot(Regex.Match(TboxFolderName.Text, lot).Value)
        Else
            LblLotNoResultInitial.Visible = True
            LblLotNoResultInitial.ForeColor = Color.Red
            LblLotNoResultInitial.Text = "✘"
            LblLotNoFeedback.Visible = True
            LblLotNoFeedback.Text = lotc.Value.Substring(1)
            ErrorProvider1.SetError(LblLotNoFeedback, "format is invalid")
        End If
        'end

        'start - Checking station ID
        If Regex.IsMatch(TboxFolderName.Text, stationid) Then
            LblStationIDResultInitial.Visible = True
            LblStationIDResultInitial.ForeColor = Color.Green
            LblStationIDResultInitial.Text = "✔"
            LblStationIDFeedback.Visible = False
            LblStationIDFeedback.Text = Nothing
            ErrorProvider1.SetError(LblStationIDFeedback, "")
        Else
            LblStationIDResultInitial.Visible = True
            LblStationIDResultInitial.ForeColor = Color.Red
            LblStationIDResultInitial.Text = "✘"
            LblStationIDFeedback.Visible = True
            LblStationIDFeedback.Text = stationidc.Value.Substring(1)

            If Regex.IsMatch(LblStationIDFeedback.Text, "[a-z]+\-[0-9]+\-[a-z][0-9]+") Or Regex.IsMatch(LblStationIDFeedback.Text, "[A-Z]+\-[0-9]+\-[a-z][0-9]+") Or Regex.IsMatch(LblStationIDFeedback.Text, "[a-z]+\-[0-9]+\-[A-Z][0-9]+") Then
                ErrorProvider1.SetError(LblStationIDFeedback, "must be uppercase")
            Else
                If Not Regex.IsMatch(LblStationIDFeedback.Text, "^(CALIB|FT|UART)") Then
                    ErrorProvider1.SetError(LblStationIDFeedback, "station is invalid")
                Else
                    If Not Regex.IsMatch(LblStationIDFeedback.Text, "-[0-9]{2}-") Or Regex.IsMatch(LblStationIDFeedback.Text, "(CALIB|FT|UART)\-[0-9]{3,}") Then
                        ErrorProvider1.SetError(LblStationIDFeedback, "station ID is invalid")
                    Else
                        If Not Regex.IsMatch(LblStationIDFeedback.Text, "-[F][0-9]{2}$") Then
                            ErrorProvider1.SetError(LblStationIDFeedback, "socket is invalid")
                        End If
                    End If
                End If
            End If
        End If
        'end

        Dim cal, ft, uart, flowcal, flowftuart As Match

        'cal = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((CALIB)\-[0-9]{2}\-[FR][0-9]{2})_([fp])_([0-9]{14}$)")
        'ft = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((FT)\-[0-9]{2}\-[FR][0-9]{2})_([fp])_([0-9]{14}$)")
        'uart = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((UART)\-[0-9]{2}\-[FR][0-9]{2})_([fp])_([0-9]{14}$)")
        'flowcal = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((CALIB)\-[0-9]{2}\-[FR][0-9]{2})_[f]_([0-9]{14})$")
        'flowftuart = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((FT|UART)\-[0-9]{2}\-[FR][0-9]{2})_([p])_([0-9]{14}$)")

        'cal = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((CALIB)\-[0-9]{2}\-[FR][0-9]{2})_([f])_([0-9]{14}$)")
        'ft = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((FT)\-[0-9]{2}\-[FR][0-9]{2})_([p])_([0-9]{14}$)")
        'uart = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((UART)\-[0-9]{2}\-[FR][0-9]{2})_([p])_([0-9]{14}$)")
        'flowcal = Regex.Match(TboxFolderName.Text, "_((CALIB)\-[0-9]{2}\-[FR][0-9]{2})_[f]_")
        'flowftuart = Regex.Match(TboxFolderName.Text, "_((FT|UART)\-[0-9]{2}\-[F][0-9]{2})_([p])_")

        'start - Checking flow code
        cal = Regex.Match(TboxFolderName.Text, "CALIB")
        ft = Regex.Match(TboxFolderName.Text, "FT")
        uart = Regex.Match(TboxFolderName.Text, "UART")
        flowcal = Regex.Match(TboxFolderName.Text, "_((CALIB)-[0-9]{2}-[F][0-9]{2})_[f]_")
        flowftuart = Regex.Match(TboxFolderName.Text, "_(([ftFT]{2}|[uartUART]{4})-[0-9]{2}-[F][0-9]{2})_([p])_")

        Dim station As String = ToString()
        Dim correct As Boolean

        If Regex.IsMatch(TboxFolderName.Text, fcode) Then
            If Regex.IsMatch(TboxPath.Text, "(_[calibCALIB]{5})") Then
                station = "CALIB"
                LogStation = station
                If Regex.IsMatch(TboxFolderName.Text, "(_f_)") Then
                    correct = True
                End If
            End If

            If Regex.IsMatch(TboxPath.Text, "(_[ftFT]{2}-)") Then
                station = "FT"
                LogStation = station
                If Regex.IsMatch(TboxFolderName.Text, "(_p_)") Then
                    correct = True
                End If
            End If

            If Regex.IsMatch(TboxPath.Text, "(_[uartUART]{4}-)") Then
                station = "UART"
                LogStation = station
                If Regex.IsMatch(TboxPath.Text, "(_p_)") Then
                    correct = True
                End If
            End If

            If Regex.IsMatch(TboxFolderName.Text, "[fp]") Then
                If station = "CALIB" Then
                    If correct = True Then
                        LblStationValue.Text = "Calibration"
                        LblFlowCodeResultInitial.Visible = True
                        LblFlowCodeResultInitial.ForeColor = Color.Green
                        LblFlowCodeResultInitial.Text = "✔"
                        LblFlowCodeFeedback.Visible = False
                        LblFlowCodeFeedback.Text = Nothing
                        ErrorProvider1.SetError(LblFlowCodeFeedback, "")
                    Else
                        LblFlowCodeResultInitial.Visible = True
                        LblFlowCodeResultInitial.ForeColor = Color.Red
                        LblFlowCodeResultInitial.Text = "✘"
                        LblFlowCodeFeedback.Visible = True
                        LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)
                        ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'f' for calibration station")
                    End If
                End If

                If station = "FT" Then
                    If correct = True Then
                        LblStationValue.Text = "FT"
                        LblFlowCodeResultInitial.Visible = True
                        LblFlowCodeResultInitial.ForeColor = Color.Green
                        LblFlowCodeResultInitial.Text = "✔"
                        LblFlowCodeFeedback.Visible = False
                        LblFlowCodeFeedback.Text = Nothing
                        ErrorProvider1.SetError(LblFlowCodeFeedback, "")
                    Else
                        LblFlowCodeResultInitial.Visible = True
                        LblFlowCodeResultInitial.ForeColor = Color.Red
                        LblFlowCodeResultInitial.Text = "✘"
                        LblFlowCodeFeedback.Visible = True
                        LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)
                        ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'p' for final test station")
                    End If
                End If

                If station = "UART" Then
                    If correct = True Then
                        LblStationValue.Text = "UART"
                        LblFlowCodeResultInitial.Visible = True
                        LblFlowCodeResultInitial.ForeColor = Color.Green
                        LblFlowCodeResultInitial.Text = "✔"
                        LblFlowCodeFeedback.Visible = False
                        LblFlowCodeFeedback.Text = Nothing
                        ErrorProvider1.SetError(LblFlowCodeFeedback, "")
                    Else
                        LblFlowCodeResultInitial.Visible = True
                        LblFlowCodeResultInitial.ForeColor = Color.Red
                        LblFlowCodeResultInitial.Text = "✘"
                        LblFlowCodeFeedback.Visible = True
                        LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)
                        ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'p' for uart station")
                    End If
                End If
            End If

            '    If TboxFolderName.Text = cal.Value Then
            '        LblStationValue.Text = "Calibration"
            '        LblFlowCodeResultInitial.Visible = True
            '        LblFlowCodeResultInitial.ForeColor = Color.Green
            '        LblFlowCodeResultInitial.Text = "✔"
            '        LblFlowCodeFeedback.Visible = False
            '        LblFlowCodeFeedback.Text = Nothing
            '        ErrorProvider1.SetError(LblFlowCodeFeedback, "")
            '        correct = True
            '    Else
            '        If TboxFolderName.Text = ft.Value Then
            '            LblStationValue.Text = "FT"
            '            LblFlowCodeResultInitial.Visible = True
            '            LblFlowCodeResultInitial.ForeColor = Color.Green
            '            LblFlowCodeResultInitial.Text = "✔"
            '            LblFlowCodeFeedback.Visible = False
            '            LblFlowCodeFeedback.Text = Nothing
            '            ErrorProvider1.SetError(LblFlowCodeFeedback, "")
            '            correct = True
            '        Else
            '            If Regex.IsMatch(TboxFolderName.Text, uart.Value) Then
            '                LblStationValue.Text = "UART"
            '                LblFlowCodeResultInitial.Visible = True
            '                LblFlowCodeResultInitial.ForeColor = Color.Green
            '                LblFlowCodeResultInitial.Text = "✔"
            '                LblFlowCodeFeedback.Visible = False
            '                LblFlowCodeFeedback.Text = Nothing
            '                ErrorProvider1.SetError(LblFlowCodeFeedback, "")
            '                correct = True
            '            Else
            '                correct = False
            '            End If
            '        End If
            '    End If

            '    If station = "CALIB" Then
            '        If correct = False Then
            '            If flowcal.Value <> Nothing Then
            '                LblFlowCodeResultInitial.Visible = True
            '                LblFlowCodeResultInitial.ForeColor = Color.Green
            '                LblFlowCodeResultInitial.Text = "✔"
            '                LblFlowCodeFeedback.Visible = False
            '                LblFlowCodeFeedback.Text = Nothing
            '                ErrorProvider1.SetError(LblFlowCodeFeedback, "")
            '            Else
            '                LblFlowCodeResultInitial.Visible = True
            '                LblFlowCodeResultInitial.ForeColor = Color.Red
            '                LblFlowCodeResultInitial.Text = "Do not match"
            '                LblFlowCodeFeedback.Visible = True
            '                LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

            '                ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'f' for calibration station")
            '            End If
            '        End If

            '        If flowcal.Value <> flowcal.ToString Then
            '            'MsgBox(TboxFolderName.Text & " " & flowcal.Value)
            '            LblFlowCodeResultInitial.Visible = True
            '            LblFlowCodeResultInitial.ForeColor = Color.Red
            '            LblFlowCodeResultInitial.Text = "Do not match"
            '            LblFlowCodeFeedback.Visible = True
            '            LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

            '            ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'f' for calibration station")
            '        End If
            '    End If

            '    If station = "FT" Then
            '        If correct = False Then
            '            If flowftuart.Value <> Nothing Then
            '                LblFlowCodeResultInitial.Visible = True
            '                LblFlowCodeResultInitial.ForeColor = Color.Green
            '                LblFlowCodeResultInitial.Text = "✔"
            '                LblFlowCodeFeedback.Visible = False
            '                LblFlowCodeFeedback.Text = Nothing
            '                ErrorProvider1.SetError(LblFlowCodeFeedback, "")
            '            Else
            '                LblFlowCodeResultInitial.Visible = True
            '                LblFlowCodeResultInitial.ForeColor = Color.Red
            '                LblFlowCodeResultInitial.Text = "Do not match"
            '                LblFlowCodeFeedback.Visible = True
            '                LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

            '                ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'p' for final test station")
            '            End If
            '        End If

            '        If flowftuart.Value <> flowftuart.ToString Then
            '            LblFlowCodeResultInitial.Visible = True
            '            LblFlowCodeResultInitial.ForeColor = Color.Red
            '            LblFlowCodeResultInitial.Text = "Do not match"
            '            LblFlowCodeFeedback.Visible = True
            '            LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

            '            ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'p' for final test station")
            '        End If
            '    End If

            '    If station = "UART" Then
            '        If correct = False Then
            '            If flowftuart.Value <> Nothing Then
            '                LblFlowCodeResultInitial.Visible = True
            '                LblFlowCodeResultInitial.ForeColor = Color.Green
            '                LblFlowCodeResultInitial.Text = "✔"
            '                LblFlowCodeFeedback.Visible = False
            '                LblFlowCodeFeedback.Text = Nothing
            '                ErrorProvider1.SetError(LblFlowCodeFeedback, "")
            '            Else
            '                LblFlowCodeResultInitial.Visible = True
            '                LblFlowCodeResultInitial.ForeColor = Color.Red
            '                LblFlowCodeResultInitial.Text = "Do not match"
            '                LblFlowCodeFeedback.Visible = True
            '                LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

            '                ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'p' for uart station")
            '            End If
            '        End If

            '        If flowftuart.Value <> flowftuart.ToString Then
            '            LblFlowCodeResultInitial.Visible = True
            '            LblFlowCodeResultInitial.ForeColor = Color.Red
            '            LblFlowCodeResultInitial.Text = "Do not match"
            '            LblFlowCodeFeedback.Visible = True
            '            LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

            '            ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'p' for uart station")
            '        End If
            '    End If
        Else
            If Regex.IsMatch(TboxFolderName.Text, "_[FP]_") Then
                LblFlowCodeResultInitial.Visible = True
                LblFlowCodeResultInitial.ForeColor = Color.Red
                LblFlowCodeResultInitial.Text = "✘"
                LblFlowCodeFeedback.Visible = True
                LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)
                ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be lower case")
            Else
                If Regex.IsMatch(LblFlowCodeFeedback.Text, "[fp]") = False Then
                    LblFlowCodeResultInitial.Visible = True
                    LblFlowCodeResultInitial.ForeColor = Color.Red
                    LblFlowCodeResultInitial.Text = "✘"
                    LblFlowCodeFeedback.Visible = True
                    LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)
                    ErrorProvider1.SetError(LblFlowCodeFeedback, "invalid flow code")
                End If
            End If
        End If
        'end

        'start - Checking time stamp
        If Regex.IsMatch(TboxFolderName.Text, tstamp) Then
            LblTimeStampResultInitial.Visible = True
            LblTimeStampResultInitial.ForeColor = Color.Green
            LblTimeStampResultInitial.Text = "✔"
            LblTimeStampFeedback.Visible = False
            LblTimeStampFeedback.Text = Nothing
            ErrorProvider1.SetError(LblTimeStampFeedback, "")
        Else
            LblTimeStampResultInitial.Visible = True
            LblTimeStampResultInitial.ForeColor = Color.Red
            LblTimeStampResultInitial.Text = "✘"
            LblTimeStampFeedback.Visible = True
            LblTimeStampFeedback.Text = tstampc.Value

            If Regex.IsMatch(LblTimeStampFeedback.Text, "[0-9]{15,}") Then
                ErrorProvider1.SetError(LblTimeStampFeedback, "number is exceeded" & vbCrLf & "must be 'yyyyMMddHHmmss'")
            Else
                If Regex.IsMatch(LblTimeStampFeedback.Text, "[0-9]{1,13}") Then
                    ErrorProvider1.SetError(LblTimeStampFeedback, "number is insufficient" & vbCrLf & "must be 'yyyyMMddHHmmss'")
                End If
            End If
        End If
        'end

        'If fcodec.Value.Substring(1, fcodec.Value.Length - 2) = "f" Then
        '    LblStationValue.Text = "Calibration"
        'Else
        '    If fcodec.Value.Substring(1, fcodec.Value.Length - 2) = "p" Then
        '        LblStationValue.Text = "FT/UART"
        '    End If
        'End If

        'start - Checking counter
        Dim str As New List(Of String)
        Dim pass, fail As Integer

        Dim path As New DirectoryInfo(TboxPath.Text)

        For Each d In path.GetFiles()
            Dim f As New FileInfo(d.ToString)
            str.Add(f.ToString)
        Next

        strng.Clear()

        If LblCMResultInitial.Text = "✔" And LblMaterialResultInitial.Text = "✔" And LblLotNoResultInitial.Text = "✔" And LblStationIDResultInitial.Text = "✔" And LblLotNoResultInitial.Text = "✔" And LblStationIDResultInitial.Text = "✔" And LblFlowCodeResultInitial.Text = "✔" And LblTimeStampResultInitial.Text = "✔" Then
            'If LblMaterialResultFinal.Text = "✔" And LblLotNoResultFinal.Text = "✔" Then
            For Each f In str
                If LblStationValue.Text = "Calibration" Then
                    Dim p As New FileInfo(path.ToString & "\" & f)
                    'Dim g As New FileInfo(path.ToString & "\" & f)
                    Dim m1, m2 As Match

                    m1 = Regex.Match(f, "(RS9113)_[NBZ0]{3}_[SD01NFW]{3}[_DRG]{0,4}_[A-Z0-9]{12,13}" & p.Extension)
                    m2 = Regex.Match(f, "[A-Za-z]{3}_[A-Za-z]{3}_{1,2}[0-9]{1,2}_[0-9]{2}_[0-9]{2}_[0-9]{2}_[0-9]{4}" & p.Extension)
                    'm2 = Regex.Match(f, "[A-Z][a-z]{2}_[A-Z][a-z]{2}_[0-9]{2}_[0-9]{2}_[0-9]{2}_[0-9]{2}_[0-9]{4}" & p.Extension)

                    If f = m1.Value Then
                        pass += 1
                    End If

                    If f = m2.Value Then
                        fail += 1
                    End If

                    If f <> m1.Value And f <> m2.Value Then
                        strng.Add(p.FullName)
                    End If
                Else
                    If LblStationValue.Text = "FT" Then
                        Dim p As New FileInfo(path.ToString & "\" & f)
                        Dim f1, f2 As Match

                        f1 = Regex.Match(f, "[a-f0-9]{2}_[a-f0-9]{2}_[a-f0-9]{2}_[a-f0-9]{2}_[a-f0-9]{2}_[a-f0-9]{2}_pass" & p.Extension)
                        f2 = Regex.Match(f, "[a-f0-9]{2}_[a-f0-9]{2}_[a-f0-9]{2}_[a-f0-9]{2}_[a-f0-9]{2}_[a-f0-9]{2}_fail" & p.Extension)

                        If f = f1.Value Then
                            pass += 1
                        End If

                        If f = f2.Value Then
                            fail += 1
                        End If

                        If f <> f1.Value And f <> f2.Value Then
                            strng.Add(p.FullName)
                        End If
                    Else
                        If LblStationValue.Text = "UART" Then
                            Dim p As New FileInfo(path.ToString & "\" & f)
                            Dim u1, u2 As Match

                            u1 = Regex.Match(f, "[a-f0-9]{2}\-[a-f0-9]{2}\-[a-f0-9]{2}\-[a-f0-9]{2}\-[a-f0-9]{2}\-[a-f0-9]{2}" & p.Extension)
                            u2 = Regex.Match(f, "[a-f0-9]{2}\-[a-f0-9]{2}\-[a-f0-9]{2}\-[a-f0-9]{2}\-[a-f0-9]{2}\-[a-f0-9]{2}_fail" & p.Extension)

                            If f = u1.Value Then
                                pass += 1
                            End If

                            If f = u2.Value Then
                                fail += 1
                            End If

                            If f <> u1.Value And f <> u2.Value Then
                                strng.Add(p.FullName)
                            End If
                        End If
                    End If
                End If
            Next

            LblStationValue.Visible = True
            LblPassCount.Visible = True
            LblFailedCount.Visible = True
            LblTotalCount.Visible = True

            LblPassCount.Text = pass
            LblFailedCount.Text = fail
            LblTotalCount.Text = path.GetFiles.Count

            passed = pass
            failed = fail
            quantity = pass + fail

            If path.GetFiles.Count <> pass + failed Then
                Dim l = LblTotalCount.Location()
                Dim lw = LblTotalCount.Width
                Dim p = LblTotalFeedback.Location

                LblTotalFeedback.Location = New Point(l.X + lw + 20, p.Y)
                LblTotalFeedback.Text = "Click to view" 'path.GetFiles.Count - (pass + failed) & "Click to view"
                ErrorProvider1.SetError(LblTotalCount, path.GetFiles.Count - (pass + failed) & " Unknown filename")
                LblTotalFeedback.Visible = True
            Else
                LblTotalFeedback.Text = Nothing
                LblTotalFeedback.Visible = False
                ErrorProvider1.SetError(LblTotalCount, "")
            End If

            'If LblCMResultInitial.Text = "✔" And LblMaterialResultInitial.Text = "✔" And LblLotNoResultInitial.Text = "✔" And LblStationIDResultInitial.Text = "✔" And LblLotNoResultInitial.Text = "✔" And LblStationIDResultInitial.Text = "✔" And LblFlowCodeResultInitial.Text = "✔" And LblTimeStampResultInitial.Text = "✔" Then
        End If
        'end 

        'start - Checking OPN if exist on the PPO records
        Dim lotnotexist As Boolean

        If Not LblLotNoResultInitial.Text = "✘" Then
            Try
                Dim lot_number As Match

                lot_number = Regex.Match(TboxFolderName.Text, "71[0-9]{5}\.[1-9]{1,2}")

                conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
                Dim query = "select * from ppo_records where lot_number='" & lot_number.Value & "'"
                Dim matnum As String = ToString()


                conn.Open()
                Using cmd As New SQLiteCommand(query, conn)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader
                        reader.Read()
                        If reader.HasRows Then
                            If reader("lot_number").ToString = lot_number.Value Then
                                LblLotNoResultFinal.Visible = True
                                LblLotNoResultFinal.ForeColor = Color.Green
                                LblLotNoResultFinal.Text = "✔"
                                LblLotNoFeedback.Visible = False
                                LblLotNoFeedback.Text = Nothing
                                'ErrorProvider2.SetError(LblLotNoFeedback, "")
                                LogLot = reader("lot_number")
                                lotnotexist = False
                            End If
                        Else
                            LblLotNoResultFinal.Visible = True
                            LblLotNoResultFinal.ForeColor = Color.Red
                            LblLotNoResultFinal.Text = "✘"
                            LblLotNoFeedback.Visible = True
                            LblLotNoFeedback.Text = lotc.Value.Substring(1)
                            ErrorProvider1.SetError(LblLotNoFeedback, "OPN do not exist")
                            lotnotexist = True
                        End If
                    End Using
                End Using
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        'end

        'start - Checking material if match on PPO Records
        Try
            conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfmissing=True;"
            Dim q = "select * from ppo_records where lot_number='" & Regex.Match(TboxFolderName.Text, "71[0-9]{5}.[1-9]{1,2}").Value & "'"
            Dim material_num As String = ToString()
            Dim exist As Boolean

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        material_num = reader("material").ToString
                        exist = True
                    Else
                        exist = False
                    End If
                End Using
            End Using
            conn.Close()

            If Not LblMaterialResultInitial.Text = "✘" Then
                If exist = True Then
                    If material_num <> Regex.Match(TboxFolderName.Text, "R9113[A-Z0-9]{9}").Value Then
                        LblMaterialResultFinal.Visible = True
                        LblMaterialResultFinal.ForeColor = Color.Red
                        LblMaterialResultFinal.Text = "✘"
                        LblMaterialFeedback.Visible = True
                        LblMaterialFeedback.Text = Regex.Match(TboxFolderName.Text, "R9113[A-Z0-9]{9}").Value
                        ErrorProvider2.SetError(LblMaterialFeedback, "Do not match with the PPO records." & vbCrLf & "It must be " & material_num)
                    Else
                        LblMaterialResultFinal.Visible = True
                        LblMaterialResultFinal.ForeColor = Color.Green
                        LblMaterialResultFinal.Text = "✔"
                        LblMaterialFeedback.Visible = False
                        LblMaterialFeedback.Text = Nothing
                        ErrorProvider2.SetError(LblMaterialFeedback, "")
                    End If
                Else
                    If exist = False Then
                        LblMaterialResultFinal.Visible = True
                        LblMaterialResultFinal.ForeColor = Color.Red
                        LblMaterialResultFinal.Text = "✘"
                        LblMaterialFeedback.Visible = True
                        LblMaterialFeedback.Text = Regex.Match(TboxFolderName.Text, "R9113[A-Z0-9]{9}").Value
                        ErrorProvider2.SetError(LblMaterialFeedback, "No record found")
                    End If
                End If
                'Else
                '    'LblMaterialResultFinal.Visible = True
                '    'LblMaterialResultFinal.ForeColor = Color.Green
                '    LblMaterialResultFinal.Text = Nothing
                '    'LblMaterialFeedback.Visible = True
                '    'LblMaterialFeedback.Text = Nothing
                '    'ErrorProvider1.SetError(LblMaterialFeedback, "")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'end

        'If Not LblLotNoResultInitial.Text = "✘" Then
        If LblCMResultInitial.Text = "✔" And LblMaterialResultInitial.Text = "✔" And LblLotNoResultInitial.Text = "✔" And LblStationIDResultInitial.Text = "✔" And LblLotNoResultInitial.Text = "✔" And LblStationIDResultInitial.Text = "✔" And LblFlowCodeResultInitial.Text = "✔" And LblTimeStampResultInitial.Text = "✔" Then
            If lotnotexist = True Then
                Dim DiagResult As DialogResult = MessageBox.Show("PPO do not exist. Do you want to create new PPO entry?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If DiagResult = DialogResult.Yes Then
                    FrmAddPPORecords.ShowDialog()
                End If
                'Return
            End If
        End If
        'End If

        'start - enabled save button when checked
        If LblMaterialResultFinal.Text = "✔" And LblLotNoResultFinal.Text = "✔" Then
            BtnSave.Visible = True
            LblViewOPN.Visible = True
        Else
            BtnSave.Visible = False
            LblViewOPN.Visible = False
        End If

        If LblTotalFeedback.Visible = True Then
            BtnSave.Enabled = False
            'LblViewOPN.Visible = True
        Else
            If LblTotalFeedback.Visible = False Then
                BtnSave.Enabled = True
                'LblViewOPN.Visible = True
            End If
        End If
        'end
    End Sub

    Private Sub TboxPath_DragEnter(sender As Object, e As DragEventArgs) Handles TboxPath.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub TboxPath_DragDrop(sender As Object, e As DragEventArgs) Handles TboxPath.DragDrop
        Dim folder As String = e.Data.GetData(DataFormats.FileDrop)(0)

        Dim fpath = New DirectoryInfo(folder)

        If Not System.IO.Directory.Exists(folder) Then
            MsgBox("Not a directory", MsgBoxStyle.Critical, "Error")
            Return
        End If

        TboxPath.Text = fpath.FullName
        TboxFolderName.Text = fpath.Name
    End Sub

    Private Sub TboxPath_TextChanged(sender As Object, e As EventArgs) Handles TboxPath.TextChanged
        If Directory.Exists(TboxPath.Text) Then
            Dim f As New System.IO.DirectoryInfo(TboxPath.Text)
            Dim path = f.FullName
            Dim name = f.Name
            'TboxPath.Text = path
            TboxFolderName.Text = name
            Clear()
        Else
            TboxFolderName.Clear()
            Clear()
        End If
    End Sub

    Private Sub TboxPath_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxPath.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnCheck.PerformClick()
        End If
    End Sub

    Private Sub LblTotalFeedback_MouseEnter(sender As Object, e As EventArgs) Handles LblTotalFeedback.MouseEnter
        Dim Underline As New Font("Segoe UI", 9, FontStyle.Underline Or FontStyle.Italic)
        LblTotalFeedback.Font = Underline
    End Sub

    Private Sub LblTotalFeedback_MouseLeave(sender As Object, e As EventArgs) Handles LblTotalFeedback.MouseLeave
        Dim Regular As New Font("Segoe UI", 9, FontStyle.Regular Or FontStyle.Italic)
        LblTotalFeedback.Font = Regular
    End Sub

    Private Sub LblTotalFeedback_Click(sender As Object, e As EventArgs) Handles LblTotalFeedback.Click
        Dim i = strng.Count
        If i = 0 Then
            FrmUnkList.BtnOpen.Enabled = False
            FrmUnkList.BtnRemove.Enabled = False
        Else
            If i <> 0 Then
                FrmUnkList.BtnOpen.Enabled = True
                FrmUnkList.BtnRemove.Enabled = True
            End If
        End If
        FrmUnkList.ShowDialog()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
            Dim q = "select * from ftp_credentials"

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows = False Then
                        MessageBox.Show("No FTP Credentials found. Please check the FTP Credentials", "Error FTP Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        FrmFTPCredentials.ShowDialog()
                        Return
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try


        If Not BWorkerSave.IsBusy Then
            ReferenceToolStripMenuItem.Enabled = False
            TboxPath.Enabled = False
            BtnBrowse.Enabled = False
            BtnCheck.Enabled = False
            ChkBoxFTPUpload.Enabled = False
            'LblSavingPercentage.Visible = True
            'LblFTPPercentage.Visible = True
            BWorkerSave.RunWorkerAsync()
        Else
            If BWorkerSave.IsBusy Then
                MsgBox("Saving OPN is already running", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Saving")
            End If
        End If

        'Dim dirInfo As New DirectoryInfo("C:\Users\inven\Desktop\Screened Result\2021\2112F005A3\IONICS_R9113NG0NP9X00_7103982.2_CALIB-03-F08_f_20201218061744")
        ''ZipFile.CreateFromDirectory("C:\Users\inven\Desktop\Screened Result\2021\2112F005A3\IONICS_R9113NG0NP9X00_7103982.2_CALIB-03-F08_f_20201218061744\IONICS_R9113NG0NP9X00_7103982.2_CALIB-03-F08_f_20201218061744", "C:\Users\inven\Documents\opn_checked\IONICS_R9113NG0NP9X00_7103982.2_CALIB-03-F08_f_20201218061744.zip")
        ''Dim zip As ZipArchive
        ''Dim fstream = New FileStream("C:\Users\inven\Documents\opn_checked\IONICS_R9113NG0NP9X00_7103982.2_CALIB-03-F08_f_20201218061744.zip", FileMode.CreateNew)
        ''zip = New ZipArchive(fstream)
        'ProgressBar1.Maximum = dirInfo.GetFiles.Count


        ''MsgBox(fi.FullName & vbCrLf & fi.Name)
        ''zip.CreateEntryFromFile(fi.FullName.ToString, fi.Name.ToString)

        'For Each f In dirInfo.GetFiles
        '    Dim fi As New FileInfo(f.FullName)
        '    Using zipToOpen As New FileStream("C:\Users\inven\Documents\opn_checked\IONICS_R9113NG0NP9X00_7103982.2_CALIB-03-F08_f_20201218061744.zip", FileMode.Open)

        '        Using archive As New ZipArchive(zipToOpen, ZipArchiveMode.Update)
        '            Dim readmeEntry As ZipArchiveEntry = archive.CreateEntry(fi.Name)
        '            ProgressBar1.Value += 1

        '            'Using writer As StreamWriter = New StreamWriter(readmeEntry.Open())
        '            '    writer.WriteLine("Information about this package.")
        '            '    writer.WriteLine("========================")
        '            'End Using
        '        End Using
        '    End Using
        'Next
    End Sub

    Private Sub PPOListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PPOListToolStripMenuItem.Click
        FrmPPOList.ShowDialog()
    End Sub

    Private Sub ReferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferenceToolStripMenuItem.Click

    End Sub

    Private Sub LogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogsToolStripMenuItem.Click
        FrmLogs.ShowDialog()
    End Sub

    Private Sub BWorkerFTPUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWorkerFTPUpload.DoWork
        ' Upload to FTP Server
        LblFTPPercentage.Visible = True

        Dim host As String = ToString()
        Dim username As String = ToString()
        Dim password As String = ToString()
        Dim path As String = ToString()
        Dim dir As String = ToString()

        ' Fetch ftp credentials from database
        Try
            conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
            Dim q = "select * from ftp_credentials"

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        host = reader("host").ToString
                        username = reader("username").ToString
                        password = reader("password").ToString
                        path = reader("path").ToString
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            If dirTrue = True Then
                conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
                Dim q = "select * from reference"

                conn.Open()
                Using cmd As New SQLiteCommand(q, conn)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader
                        reader.Read()
                        If reader.HasRows Then
                            dir = reader("path").ToString
                        End If
                    End Using
                End Using
                conn.Close()
            End If

            If dirTrue = False Then
                dir = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "opn_checked"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim DirOPN As New System.IO.DirectoryInfo(dir)
        Dim OPN As String = Nothing

        For Each i In DirOPN.GetFiles
            If i.Name = dirPath & i.Extension Then
                OPN = i.Name
            End If
        Next

        Dim FTPOpnPath As String = host & "/" & path & "/" & IO.Path.GetFileName(OPN)

        Try
            Dim request As FtpWebRequest = DirectCast(WebRequest.Create(New Uri(FTPOpnPath)), FtpWebRequest)

            request.Method = WebRequestMethods.Ftp.UploadFile
            request.Credentials = New NetworkCredential(username, password)
            request.UseBinary = True
            request.UsePassive = False

            Dim fileStream() As Byte = System.IO.File.ReadAllBytes(dir & "\" & OPN)
            Dim requestStream As System.IO.Stream = request.GetRequestStream()
            LblFTPPercentage.Visible = True

            For offset As Integer = 0 To fileStream.Length Step 1024
                BWorkerFTPUpload.ReportProgress(CType(offset * PbarFTP.Maximum / fileStream.Length, Integer))
                Dim chSize As Integer = fileStream.Length - offset
                If chSize > 1024 Then chSize = 1024
                requestStream.Write(fileStream, offset, chSize)
            Next

            requestStream.Close()
            requestStream.Dispose()
        Catch ex As Exception
            BWorkerFTPUpload.CancelAsync()
            If ex.Message.Contains("530") Then
                MessageBox.Show("Invalid Username or Password.", "FTP Credential", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FtpFailed = True
            Else
                If ex.Message.Contains("550") Then
                    MessageBox.Show("Invalid FTP directory.", "No FTP Directory Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    FtpFailed = True
                Else
                    MessageBox.Show(ex.Message, "Error FTP Upload", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    FtpFailed = True
                End If
            End If
        End Try

        'PbarSaving.Visible = False
        TboxPath.Clear()
        TboxPath.Enabled = True
        BtnBrowse.Enabled = True
        BtnCheck.Enabled = True
        PbarSaving.Value = 0
        PbarFTP.Value = 0
        LblSavingPercentage.Visible = False
        LblSavingPercentage.Text = Nothing
        LblFTPPercentage.Visible = False
        LblFTPPercentage.Text = Nothing
        refFin = False
        ReferenceToolStripMenuItem.Enabled = True
    End Sub

    Private Sub BWorkerFTPUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BWorkerFTPUpload.ProgressChanged
        PbarFTP.Value = e.ProgressPercentage
        LblFTPPercentage.Text = e.ProgressPercentage & "%"
    End Sub

    Private Sub BWorkerFTPUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWorkerFTPUpload.RunWorkerCompleted
        If FtpFailed = False Then
            ChkBoxFTPUpload.Enabled = True
            MessageBox.Show("OPN successfully uploaded to FTP Server", "FTP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectoryToolStripMenuItem.Click
        FrmDir.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAboutBox.ShowDialog()
    End Sub

    Private Sub FTPCredentialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FTPCredentialsToolStripMenuItem.Click
        FrmFTPCredentials.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ChkBoxFTPUpload_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxFTPUpload.CheckedChanged
        If ChkBoxFTPUpload.Checked = True Then
            LblFTPProgress.Visible = True
            PbarFTP.Visible = True
            'LblFTPPercentage.Visible = True
        Else
            If ChkBoxFTPUpload.Checked = False Then
                LblFTPProgress.Visible = False
                PbarFTP.Visible = False
                'LblFTPPercentage.Visible = False
            End If
        End If
    End Sub

    Private Sub LblViewOPN_Click(sender As Object, e As EventArgs) Handles LblViewOPN.Click
        FrmOPNInformation.ShowDialog()
    End Sub

    Private Sub BWorkerSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWorkerSave.DoWork
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"

        Dim origPath As New DirectoryInfo(TboxPath.Text)

        ' Setting path for directory reference
        Try
            Dim q = "select path from reference"
            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        defSavingPath = reader("path").ToString
                        dirTrue = True
                    Else
                        DefDir = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "opn_checked"
                        dirTrue = False
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try

        ' Default directory base what is saved on database
        If dirTrue = True Then
            If Not Directory.Exists(defSavingPath) Then
                Directory.CreateDirectory(defSavingPath)
            End If

            If File.Exists(defSavingPath & "\" & origPath.Name & ".zip") Then
                BWorkerSave.CancelAsync()
                ReferenceToolStripMenuItem.Enabled = True
                TboxPath.Enabled = True
                BtnBrowse.Enabled = True
                BtnCheck.Enabled = True
                ChkBoxFTPUpload.Enabled = True
                LblSavingPercentage.Visible = False
                LblFTPPercentage.Visible = False
                MessageBox.Show("File already exist!", "File Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim startPath, zipPath As String
            Dim sum, count As Integer
            Dim dev As Double

            startPath = TboxPath.Text
            zipPath = defSavingPath & "\" & origPath.Name & ".zip"

            Directory.CreateDirectory(defSavingPath & "\" & origPath.Name)
            Directory.CreateDirectory(defSavingPath & "\" & origPath.Name & "\" & origPath.Name)

            sum = origPath.GetFiles.Count
            count = 0

            ZipFile.CreateFromDirectory(defSavingPath & "\" & origPath.Name, defSavingPath & "\" & origPath.Name & ".zip")

            LblSavingPercentage.Visible = True

            For Each f In origPath.GetFiles
                Dim fi As New FileInfo(f.FullName)
                Using zipToOpen As New FileStream(defSavingPath & "\" & origPath.Name & ".zip", FileMode.Open)

                    Using archive As New ZipArchive(zipToOpen, ZipArchiveMode.Update)
                        Dim readmeEntry As ZipArchiveEntry = archive.CreateEntryFromFile(fi.FullName, origPath.Name & "\" & fi.Name)
                        count += 1
                        dev = count / sum
                        BWorkerSave.ReportProgress(dev * 100)
                    End Using
                End Using
            Next

            Directory.Delete(defSavingPath & "\" & origPath.Name, True)

            refFin = True
        End If

        ' Default directory if database is empty
        If dirTrue = False Then
            If Not Directory.Exists(DefDir) Then
                Directory.CreateDirectory(DefDir)
            End If

            If File.Exists(DefDir & "\" & origPath.Name & ".zip") Then
                BWorkerSave.CancelAsync()

                ReferenceToolStripMenuItem.Enabled = True
                TboxPath.Enabled = True
                BtnBrowse.Enabled = True
                BtnCheck.Enabled = True
                ChkBoxFTPUpload.Enabled = True
                LblSavingPercentage.Visible = False
                LblFTPPercentage.Visible = False
                MessageBox.Show("File already exist!", "File Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim startPath, zipPath As String
            Dim sum, count As Integer
            Dim dev As Double

            startPath = TboxPath.Text
            zipPath = DefDir & "\" & origPath.Name & ".zip"

            Directory.CreateDirectory(DefDir & "\" & origPath.Name)
            Directory.CreateDirectory(DefDir & "\" & origPath.Name & "\" & origPath.Name)

            sum = origPath.GetFiles.Count
            count = 0

            ZipFile.CreateFromDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "opn_checked" & "\" & origPath.Name, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "opn_checked" & "\" & origPath.Name & ".zip")

            For Each f In origPath.GetFiles
                Dim fi As New FileInfo(f.FullName)
                Using zipToOpen As New FileStream(DefDir & "\" & origPath.Name & ".zip", FileMode.Open)

                    Using archive As New ZipArchive(zipToOpen, ZipArchiveMode.Update)
                        Dim readmeEntry As ZipArchiveEntry = archive.CreateEntryFromFile(fi.FullName, origPath.Name & "\" & fi.Name)
                        count += 1
                        dev = count / sum

                        BWorkerSave.ReportProgress(dev * 100)

                    End Using
                End Using
            Next

            Directory.Delete(DefDir & "\" & origPath.Name, True)

            defFin = True
        End If

        'Get OPN details from database thru lot number
        Dim LMaterial As String = Nothing
        Dim LOPN As String = Nothing
        Dim LFw As String = Nothing
        Dim LLot As String = Nothing
        Dim LTrace As String = Nothing
        Dim LPPOQty As String = Nothing

        Try
            conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
            Dim q = "select * from ppo_records where lot_number='" & LogLot & "'"

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        LMaterial = reader("material").ToString
                        LOPN = reader("new_ordering_part_number").ToString
                        LFw = reader("firmware").ToString
                        LLot = reader("lot_number").ToString
                        LTrace = reader("full_trace_code").ToString
                        LPPOQty = reader("ppo_qty")
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim DateNow As String = Date.Now.ToString("MM-dd-yyyy")
        Dim TimeNow As String = Date.Now.ToString("HH:mm:ss")
        dirPath = TboxFolderName.Text

        Try
            conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
            Dim q1 = "insert into logs (filename,material,new_ordering_part_number,firmware,lot_number,full_trace_code,ppo_qty,station,qty,passed,failed,date,time) values ('" &
                     dirPath & "','" & LMaterial & "','" & LOPN & "','" & LFw & "','" & LLot & "','" & LTrace & "','" & LPPOQty & "','" & LogStation & "','" & quantity & "','" & passed & "','" & failed & "','" & DateNow & "','" & TimeNow & "')"

            conn.Open()
            Using cmd As New SQLiteCommand(q1, conn)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BWorkerSave_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BWorkerSave.ProgressChanged
        LblSavingPercentage.Text = e.ProgressPercentage & "%"
        PbarSaving.Value = e.ProgressPercentage
        'PbarSaving.Visible = True
        PbarSaving.Maximum = 100
    End Sub

    Private Sub BWorkerSave_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWorkerSave.RunWorkerCompleted
        If ChkBoxFTPUpload.Checked = False Then
            dirTrue = False
        Else
            dirTrue = True
        End If

        ' Default reference saving directory (Reference Finished)
        If refFin = True Then
            'dirPath = TboxFolderName.Text

            If ChkBoxFTPUpload.Checked = True Then
                If BWorkerFTPUpload.IsBusy = False Then
                    Directory.Delete(TboxPath.Text, True)
                    BWorkerFTPUpload.RunWorkerAsync()
                Else
                    MessageBox.Show("Already running", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            If ChkBoxFTPUpload.Checked = False Then
                Directory.Delete(TboxPath.Text, True)
                MessageBox.Show("OPN successfully saved to" & vbCrLf & defSavingPath, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'PbarSaving.Visible = False
                PbarSaving.Value = 0
                TboxPath.Clear()
                refFin = False
                ReferenceToolStripMenuItem.Enabled = True
                TboxPath.Enabled = True
                BtnBrowse.Enabled = True
                BtnCheck.Enabled = True
                ChkBoxFTPUpload.Enabled = True
                'LblSavingPercentage.Visible = False
                LblSavingPercentage.Text = Nothing
            End If
        End If

        ' Default saving directory (Default Finished)
        If defFin = True Then
            'dirPath = TboxFolderName.Text

            If ChkBoxFTPUpload.Checked = True Then
                If BWorkerFTPUpload.IsBusy = False Then
                    Directory.Delete(TboxPath.Text, True)
                    BWorkerFTPUpload.RunWorkerAsync()
                Else
                    MessageBox.Show("Already running", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            If ChkBoxFTPUpload.Checked = False Then
                Directory.Delete(TboxPath.Text, True)
                MessageBox.Show("OPN successfully saved to default directory" & vbCrLf & My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "opn_checked", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'PbarSaving.Visible = False
                PbarSaving.Value = 0
                TboxPath.Clear()
                defFin = False
                ReferenceToolStripMenuItem.Enabled = True
                TboxPath.Enabled = True
                BtnBrowse.Enabled = True
                BtnCheck.Enabled = True
                ChkBoxFTPUpload.Enabled = True
                'LblSavingPercentage.Visible = False
                LblSavingPercentage.Text = Nothing
            End If
        End If
    End Sub
End Class
