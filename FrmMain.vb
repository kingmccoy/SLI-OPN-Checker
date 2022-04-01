Imports System.Data.SQLite
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.IO.Compression
Imports System.ComponentModel

Public Class FrmMain
    ReadOnly conn As New SQLiteConnection
    Public ReadOnly strng As New List(Of String)
    Public defSavingPath As String = ToString()
    Public DefDir As String = ToString()
    Dim dirTrue, defFin, refFin, correct, stp As Boolean
    Public zip As ZipArchive

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPNListToolStripMenuItem.Click
        FrmList.ShowDialog()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SendToBack()
        TboxFolderName.ReadOnly = True
        ProgressBar1.Visible = False
        LblPercent.Visible = False
        LblPercent.Text = Nothing
        Clear()
    End Sub

    Sub Clear()
        LblCMResult.Visible = False
        LblMaterialResult.Visible = False
        LblLotNoResult.Visible = False
        LblStationIDResult.Visible = False
        LblFlowCodeResult.Visible = False
        LblTimeStampResult.Visible = False

        LblCMResult.Text = Nothing
        LblMaterialResult.Text = Nothing
        LblLotNoResult.Text = Nothing
        LblStationIDResult.Text = Nothing
        LblFlowCodeResult.Text = Nothing
        LblTimeStampResult.Text = Nothing

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
        If TboxPath.Text = Nothing Then
            MessageBox.Show("Please browse the directory to proceed!", "No Direcotry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Directory.Exists(TboxPath.Text) Then
            MessageBox.Show("Directory do not exist!", "Direcotry Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Clear()
            Return
        End If

        Dim rg As String = "^([a-zA-Z]+)_([a-zA-Z0-9]+)_([0-9\.0-9]+)_([a-zA-Z]+\-[0-9]+\-[a-zA-Z][0-9]*)_([a-zA-Z])_([a-zA-Z0-9]+)$"
        '"[IONICS]+_([A-Z0-9]+)_([0-9\.0-9]+)_((CALIB|FT|UART)\-[0-9]{2}\-[FR][0-9]{2})_(.*)_([0-9]+)"

        If Not Regex.IsMatch(TboxFolderName.Text, rg) Then
            MessageBox.Show("Filename invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim cm = "^(IONICS)_"
        Dim material = "_([A-Z0-9]{14,15})"
        Dim lot = "_([0-9]{7}\.[0-9]{1,2})_"
        Dim stationid = "_((CALIB|FT|UART)\-[0-9]{2}\-[FR][0-9]{2})_"
        Dim fcode = "_([fp])"
        Dim tstamp = "_([0-9]{14}$)"

        Dim cmc, materialc, lotc, stationidc, fcodec, tstampc As Match
        'Dim cmr, materialr, lotr, stationidr, fcoder, tstampr As Regex

        cmc = Regex.Match(TboxFolderName.Text, "^[a-zA-Z]+")
        materialc = Regex.Match(TboxFolderName.Text, "_[a-zA-Z0-9]+")
        lotc = Regex.Match(TboxFolderName.Text, "_[0-9\.0-9]+")
        stationidc = Regex.Match(TboxFolderName.Text, "_[a-zA-Z]+\-[0-9]+\-[a-zA-Z][0-9]+")
        fcodec = Regex.Match(TboxFolderName.Text, "_[a-zA-Z]_")
        tstampc = Regex.Match(TboxFolderName.Text, "[0-9]+$")

        'cmr = New Regex("^[IONICS]+")
        'materialr = New Regex("_[A-Z0-9]*")
        'lotr = New Regex("[0-9\.0-9]+")
        'stationidr = New Regex("[A-Z]+\-[0-9]{2}\-[FR][0-9]{2}")
        'fcoder = New Regex("[a-z]")
        'tstampr = New Regex("[0-9]+$")

        Dim MatList As New List(Of String)
        'Dim CountMat As Integer

        Dim table As New DataTable

        Dim r As String = Regex.IsMatch(TboxFolderName.Text, material)

        'cmc = cmr.Match(TboxFolderName.Text)
        If Regex.IsMatch(TboxFolderName.Text, cm) Then
            LblCMResult.Visible = True
            LblCMResult.ForeColor = Color.Green
            LblCMResult.Text = "OK"
            LblCMFeedback.Visible = False
            LblCMFeedback.Text = Nothing
            ErrorProvider1.SetError(LblCMFeedback, "")
        Else
            LblCMResult.Visible = True
            LblCMResult.ForeColor = Color.Red
            LblCMResult.Text = "Do not match"
            LblCMFeedback.Visible = True
            LblCMFeedback.Text = cmc.Value

            Dim chk As Match
            chk = Regex.Match(LblCMFeedback.Text, "^(IONICS)")

            If Regex.IsMatch(LblCMFeedback.Text, "[a-z]+") Then
                ErrorProvider1.SetError(LblCMFeedback, "must be uppercase")
            Else
                If Not Regex.IsMatch(LblCMFeedback.Text, "^(IONICS)") Then
                    ErrorProvider1.SetError(LblCMFeedback, "must be IONICS")
                End If
            End If
        End If

        If Regex.IsMatch(TboxFolderName.Text, material) Then
            conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"

            Try
                Dim q = "select material_no from material"

                conn.Open()
                Using cmd As New SQLiteCommand(q, conn)
                    Dim adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
                conn.Close()

            Catch ex As Exception
                MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            For Each row As DataRow In table.Rows
                MatList.Add(row.Item("material_no"))
            Next

            Dim y As Boolean
            Dim n As Boolean

            For Each dt In MatList
                Dim reg As Match
                reg = Regex.Match(TboxFolderName.Text, "_[A-Z0-9]{14,15}")
                If dt = reg.Value.Substring(1) Then
                    y = True
                Else
                    n = True
                End If
            Next

            'materialc = materialr.Match(TboxFolderName.Text, 1)

            If y = True Then
                LblMaterialResult.Visible = True
                LblMaterialResult.ForeColor = Color.Green
                LblMaterialResult.Text = "OK"
                LblMaterialFeedback.Visible = False
                LblMaterialFeedback.Text = Nothing
                ErrorProvider1.SetError(LblMaterialFeedback, "")
            Else
                If n = True Then
                    LblMaterialResult.Visible = True
                    LblMaterialResult.ForeColor = Color.Red
                    LblMaterialResult.Text = "Do not match"
                    LblMaterialFeedback.Visible = True
                    LblMaterialFeedback.Text = materialc.Value.Substring(1)

                    If Regex.IsMatch(LblMaterialFeedback.Text, "[a-z]") Then
                        ErrorProvider1.SetError(LblMaterialFeedback, "must be uppercase")
                    Else
                        If Regex.IsMatch(LblMaterialFeedback.Text, "[A-Z0-9]+") Then
                            ErrorProvider1.SetError(LblMaterialFeedback, "no match in the database")
                        End If
                    End If
                End If
            End If
        End If

        If Regex.IsMatch(TboxFolderName.Text, lot) Then
            LblLotNoResult.Visible = True
            LblLotNoResult.ForeColor = Color.Green
            LblLotNoResult.Text = "OK"
            LblLotNoFeedback.Visible = False
            LblLotNoFeedback.Text = Nothing
            ErrorProvider1.SetError(LblLotNoFeedback, "")
        Else
            LblLotNoResult.Visible = True
            LblLotNoResult.ForeColor = Color.Red
            LblLotNoResult.Text = "Do not match"
            LblLotNoFeedback.Visible = True
            LblLotNoFeedback.Text = lotc.Value.Substring(1)

            'If Regex.IsMatch(LblLotNoFeedback.Text, "^[0-9]{7,}\.[0-9]{3,}") Then
            '    ErrorProvider1.SetError(LblLotNoFeedback, "format is invalid")
            'Else
            '    If Regex.IsMatch(LblLotNoFeedback.Text, "^[0-9]{1,6}\.[0-9]{1,2}") Then
            '        ErrorProvider1.SetError(LblLotNoFeedback, "format is invalid")
            '    Else
            '        If Regex.IsMatch(LblLotNoFeedback.Text, "^[0-9]{7}\.[0-9]{3,}") Then
            '            ErrorProvider1.SetError(LblLotNoFeedback, "format is invalid")
            '        Else
            '            If Regex.IsMatch(LblLotNoFeedback.Text, "^[0-9]{7,}\.[0-9]{1,2}") Then
            '                ErrorProvider1.SetError(LblLotNoFeedback, "format is invalid")
            '            End If
            '        End If
            '    End If
            'End If

            If Not Regex.IsMatch(LblLotNoFeedback.Text, "^[0-9]{7}\.[0-9]{1,2}$") Then
                ErrorProvider1.SetError(LblLotNoFeedback, "format is invalid")
            End If
        End If

        If Regex.IsMatch(TboxFolderName.Text, stationid) Then
            LblStationIDResult.Visible = True
            LblStationIDResult.ForeColor = Color.Green
            LblStationIDResult.Text = "OK"
            LblStationIDFeedback.Visible = False
            LblStationIDFeedback.Text = Nothing
            ErrorProvider1.SetError(LblStationIDFeedback, "")
        Else
            LblStationIDResult.Visible = True
            LblStationIDResult.ForeColor = Color.Red
            LblStationIDResult.Text = "Do not match"
            LblStationIDFeedback.Visible = True
            LblStationIDFeedback.Text = stationidc.Value.Substring(1)

            If Regex.IsMatch(LblStationIDFeedback.Text, "[a-z]+\-[0-9]+\-[a-z][0-9]+") Or Regex.IsMatch(LblStationIDFeedback.Text, "[A-Z]+\-[0-9]+\-[a-z][0-9]+") Or Regex.IsMatch(LblStationIDFeedback.Text, "[a-z]+\-[0-9]+\-[A-Z][0-9]+") Then
                ErrorProvider1.SetError(LblStationIDFeedback, "must be uppercase")
            Else
                If Not Regex.IsMatch(LblStationIDFeedback.Text, "^(CALIB|FT|UART)\-") Then
                    ErrorProvider1.SetError(LblStationIDFeedback, "station is invalid")
                Else
                    If Not Regex.IsMatch(LblStationIDFeedback.Text, "\-[0-9]{2}\-") Or Regex.IsMatch(LblStationIDFeedback.Text, "(CALIB|FT|UART)\-[0-9]{3,}") Then
                        ErrorProvider1.SetError(LblStationIDFeedback, "station ID is invalid")
                    Else
                        If Not Regex.IsMatch(LblStationIDFeedback.Text, "\-[FR][0-9]{2}$") Then
                            ErrorProvider1.SetError(LblStationIDFeedback, "socket is invalid")
                            'Else
                            '    If Not Regex.IsMatch(LblStationIDFeedback.Text, "^(CALIB|FT|UART)\-[0-9]{2}\-[FR][0-9]{2}$") Then
                            '        ErrorProvider1.SetError(LblStationIDFeedback, "format is invalid")
                            '    End If
                        End If
                    End If
                End If
            End If

        End If

        Dim cal, ft, uart, flowcal, flowftuart As Match

        'cal = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((CALIB)\-[0-9]{2}\-[FR][0-9]{2})_([fp])_([0-9]{14}$)")
        'ft = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((FT)\-[0-9]{2}\-[FR][0-9]{2})_([fp])_([0-9]{14}$)")
        'uart = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((UART)\-[0-9]{2}\-[FR][0-9]{2})_([fp])_([0-9]{14}$)")
        'flowcal = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((CALIB)\-[0-9]{2}\-[FR][0-9]{2})_[f]_([0-9]{14})$")
        'flowftuart = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((FT|UART)\-[0-9]{2}\-[FR][0-9]{2})_([p])_([0-9]{14}$)")

        cal = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((CALIB)\-[0-9]{2}\-[FR][0-9]{2})_([f])_([0-9]{14}$)")
        ft = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((FT)\-[0-9]{2}\-[FR][0-9]{2})_([p])_([0-9]{14}$)")
        uart = Regex.Match(TboxFolderName.Text, "^(IONICS)_([A-Z0-9]{14,15})_([0-9]{7}\.[0-9]{1,2})_((UART)\-[0-9]{2}\-[FR][0-9]{2})_([p])_([0-9]{14}$)")
        flowcal = Regex.Match(TboxFolderName.Text, "_((CALIB)\-[0-9]{2}\-[FR][0-9]{2})_[f]_")
        flowftuart = Regex.Match(TboxFolderName.Text, "_((FT|UART)\-[0-9]{2}\-[FR][0-9]{2})_([p])_")
        Dim station As String = ToString()

        If Regex.IsMatch(TboxFolderName.Text, fcode) Then
            If Regex.IsMatch(TboxPath.Text, "(CALIB)") Then
                station = "CALIB"
            Else
                If Regex.IsMatch(TboxPath.Text, "(FT)") Then
                    station = "FT"
                Else
                    If Regex.IsMatch(TboxPath.Text, "(UART)") Then
                        station = "UART"
                    End If
                End If
            End If

            If TboxFolderName.Text = cal.Value Then
                LblStationValue.Text = "Calibration"
                LblFlowCodeResult.Visible = True
                LblFlowCodeResult.ForeColor = Color.Green
                LblFlowCodeResult.Text = "OK"
                LblFlowCodeFeedback.Visible = False
                LblFlowCodeFeedback.Text = Nothing
                ErrorProvider1.SetError(LblFlowCodeFeedback, "")
                correct = True
            Else
                If TboxFolderName.Text = ft.Value Then
                    LblStationValue.Text = "FT"
                    LblFlowCodeResult.Visible = True
                    LblFlowCodeResult.ForeColor = Color.Green
                    LblFlowCodeResult.Text = "OK"
                    LblFlowCodeFeedback.Visible = False
                    LblFlowCodeFeedback.Text = Nothing
                    ErrorProvider1.SetError(LblFlowCodeFeedback, "")
                    correct = True
                Else
                    If TboxFolderName.Text = uart.Value Then
                        LblStationValue.Text = "UART"
                        LblFlowCodeResult.Visible = True
                        LblFlowCodeResult.ForeColor = Color.Green
                        LblFlowCodeResult.Text = "OK"
                        LblFlowCodeFeedback.Visible = False
                        LblFlowCodeFeedback.Text = Nothing
                        ErrorProvider1.SetError(LblFlowCodeFeedback, "")
                        correct = True
                    Else
                        correct = False
                    End If
                End If
            End If

            If station = "CALIB" Then
                If correct = False Then
                    If flowcal.Value <> Nothing Then
                        LblFlowCodeResult.Visible = True
                        LblFlowCodeResult.ForeColor = Color.Green
                        LblFlowCodeResult.Text = "OK"
                        LblFlowCodeFeedback.Visible = False
                        LblFlowCodeFeedback.Text = Nothing
                        ErrorProvider1.SetError(LblFlowCodeFeedback, "")
                    Else
                        LblFlowCodeResult.Visible = True
                        LblFlowCodeResult.ForeColor = Color.Red
                        LblFlowCodeResult.Text = "Do not match"
                        LblFlowCodeFeedback.Visible = True
                        LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

                        ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'f' for calibration station")
                    End If
                End If

                If flowcal.Value <> flowcal.ToString Then
                    'MsgBox(TboxFolderName.Text & " " & flowcal.Value)
                    LblFlowCodeResult.Visible = True
                    LblFlowCodeResult.ForeColor = Color.Red
                    LblFlowCodeResult.Text = "Do not match"
                    LblFlowCodeFeedback.Visible = True
                    LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

                    ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'f' for calibration station")
                End If
            End If

            If station = "FT" Then
                If correct = False Then
                    If flowftuart.Value <> Nothing Then
                        LblFlowCodeResult.Visible = True
                        LblFlowCodeResult.ForeColor = Color.Green
                        LblFlowCodeResult.Text = "OK"
                        LblFlowCodeFeedback.Visible = False
                        LblFlowCodeFeedback.Text = Nothing
                        ErrorProvider1.SetError(LblFlowCodeFeedback, "")
                    Else
                        LblFlowCodeResult.Visible = True
                        LblFlowCodeResult.ForeColor = Color.Red
                        LblFlowCodeResult.Text = "Do not match"
                        LblFlowCodeFeedback.Visible = True
                        LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

                        ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'p' for final test station")
                    End If
                End If

                If flowftuart.Value <> flowftuart.ToString Then
                    LblFlowCodeResult.Visible = True
                    LblFlowCodeResult.ForeColor = Color.Red
                    LblFlowCodeResult.Text = "Do not match"
                    LblFlowCodeFeedback.Visible = True
                    LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

                    ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'p' for final test station")
                End If
            End If

            If station = "UART" Then
                If correct = False Then
                    If flowftuart.Value <> Nothing Then
                        LblFlowCodeResult.Visible = True
                        LblFlowCodeResult.ForeColor = Color.Green
                        LblFlowCodeResult.Text = "OK"
                        LblFlowCodeFeedback.Visible = False
                        LblFlowCodeFeedback.Text = Nothing
                        ErrorProvider1.SetError(LblFlowCodeFeedback, "")
                    Else
                        LblFlowCodeResult.Visible = True
                        LblFlowCodeResult.ForeColor = Color.Red
                        LblFlowCodeResult.Text = "Do not match"
                        LblFlowCodeFeedback.Visible = True
                        LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

                        ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'p' for uart station")
                    End If
                End If

                If flowftuart.Value <> flowftuart.ToString Then
                    LblFlowCodeResult.Visible = True
                    LblFlowCodeResult.ForeColor = Color.Red
                    LblFlowCodeResult.Text = "Do not match"
                    LblFlowCodeFeedback.Visible = True
                    LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

                    ErrorProvider1.SetError(LblFlowCodeFeedback, "flow code must be 'p' for uart station")
                End If
            End If
        Else
            LblFlowCodeResult.Visible = True
            LblFlowCodeResult.ForeColor = Color.Red
            LblFlowCodeResult.Text = "Do not match"
            LblFlowCodeFeedback.Visible = True
            LblFlowCodeFeedback.Text = fcodec.Value.Substring(1, fcodec.Value.Length - 2)

            If Not Regex.IsMatch(LblFlowCodeFeedback.Text, "[fp]") Then
                ErrorProvider1.SetError(LblFlowCodeFeedback, "invalid flow code")
            End If
        End If

        If Regex.IsMatch(TboxFolderName.Text, tstamp) Then
            LblTimeStampResult.Visible = True
            LblTimeStampResult.ForeColor = Color.Green
            LblTimeStampResult.Text = "OK"
            LblTimeStampFeedback.Visible = False
            LblTimeStampFeedback.Text = Nothing
            ErrorProvider1.SetError(LblTimeStampFeedback, "")
        Else
            LblTimeStampResult.Visible = True
            LblTimeStampResult.ForeColor = Color.Red
            LblTimeStampResult.Text = "Do not match"
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

        'If fcodec.Value.Substring(1, fcodec.Value.Length - 2) = "f" Then
        '    LblStationValue.Text = "Calibration"
        'Else
        '    If fcodec.Value.Substring(1, fcodec.Value.Length - 2) = "p" Then
        '        LblStationValue.Text = "FT/UART"
        '    End If
        'End If

        Dim str As New List(Of String)
        Dim pass, failed As Integer

        Dim path As New DirectoryInfo(TboxPath.Text)

        For Each d In path.GetFiles()
            Dim f As New FileInfo(d.ToString)
            str.Add(f.ToString)
        Next

        strng.Clear()

        If LblCMResult.Text = "OK" And LblMaterialResult.Text = "OK" And LblLotNoResult.Text = "OK" And LblStationIDResult.Text = "OK" And LblLotNoResult.Text = "OK" And LblStationIDResult.Text = "OK" And LblFlowCodeResult.Text = "OK" And LblTimeStampResult.Text = "OK" Then
            For Each f In str
                If LblStationValue.Text = "Calibration" Then
                    Dim p As New FileInfo(path.ToString & "\" & f)
                    'Dim g As New FileInfo(path.ToString & "\" & f)
                    Dim m1, m2 As Match

                    m1 = Regex.Match(f, "(RS9113)_[NBZ0]{3}_[SD01NFW]{3}[_DRG]{0,4}_[A-Z0-9]{12}" & p.Extension)
                    m2 = Regex.Match(f, "[A-Za-z]{3}_[A-Za-z]{3}_{1,2}[0-9]{1,2}_[0-9]{2}_[0-9]{2}_[0-9]{2}_[0-9]{4}" & p.Extension)
                    'm2 = Regex.Match(f, "[A-Z][a-z]{2}_[A-Z][a-z]{2}_[0-9]{2}_[0-9]{2}_[0-9]{2}_[0-9]{2}_[0-9]{4}" & p.Extension)

                    If f = m1.Value Then
                        pass += 1
                    End If

                    If f = m2.Value Then
                        failed += 1
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
                            failed += 1
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
                                failed += 1
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
            LblFailedCount.Text = failed
            LblTotalCount.Text = path.GetFiles.Count

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

            If LblCMResult.Text = "OK" And LblMaterialResult.Text = "OK" And LblLotNoResult.Text = "OK" And LblStationIDResult.Text = "OK" And LblLotNoResult.Text = "OK" And LblStationIDResult.Text = "OK" And LblFlowCodeResult.Text = "OK" And LblTimeStampResult.Text = "OK" Then
                BtnSave.Visible = True
            Else
                BtnSave.Visible = False
            End If

            If LblTotalFeedback.Visible = True Then
                BtnSave.Enabled = False
            Else
                If LblTotalFeedback.Visible = False Then
                    BtnSave.Enabled = True
                End If
            End If
        End If
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
        If Not BackgroundWorker1.IsBusy Then
            ReferenceToolStripMenuItem.Enabled = False
            TboxPath.Enabled = False
            BtnBrowse.Enabled = False
            BtnCheck.Enabled = False
            LblPercent.Visible = True
            BackgroundWorker1.RunWorkerAsync()
        Else
            If BackgroundWorker1.IsBusy Then
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
        FrmDir.ShowDialog()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"

        Dim origPath As New DirectoryInfo(TboxPath.Text)
        'Dim defSavingPath As String = ToString()
        'Dim dir_true As Boolean

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
                        DefDir = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "f_checked"
                        dirTrue = False
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try

        If dirTrue = True Then
            If Not Directory.Exists(defSavingPath) Then
                Directory.CreateDirectory(defSavingPath)
            End If

            If File.Exists(defSavingPath & "\" & origPath.Name & ".zip") Then
                'If BackgroundWorker1.IsBusy Then
                MsgBox("File already exist!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "File Exist")
                BackgroundWorker1.CancelAsync()
                stp = True
                'End If
            End If

            Dim startPath, zipPath As String
            Dim sum, count As Integer
            Dim dev As Double

            startPath = TboxPath.Text
            zipPath = defSavingPath & "\" & origPath.Name & ".zip"

            'origPath.CreateSubdirectory(origPath.Name)
            'File.Create(origPath.FullName & "\" & origPath.Name & "\" & "tmp.txt")

            Directory.CreateDirectory(defSavingPath & "\" & origPath.Name)
            Directory.CreateDirectory(defSavingPath & "\" & origPath.Name & "\" & origPath.Name)

            sum = origPath.GetFiles.Count
            'bar = sum * 0.01
            count = 0
            'progress = 1

            'For Each f In origPath.GetFiles
            'count += 1
            'File.Move(f.FullName, origPath.FullName & "\" & origPath.Name & "\" & f.Name)
            'If count = bar Then
            '    BackgroundWorker1.ReportProgress(progress)
            '    progress += 1
            '    bar += sum * 0.01
            'End If
            'Next

            'ZipFile.CreateFromDirectory(startPath & "\" & origPath.Name, zipPath)
            ZipFile.CreateFromDirectory(defSavingPath & "\" & origPath.Name, defSavingPath & "\" & origPath.Name & ".zip")

            For Each f In origPath.GetFiles
                Dim fi As New FileInfo(f.FullName)
                Using zipToOpen As New FileStream(defSavingPath & "\" & origPath.Name & ".zip", FileMode.Open)

                    Using archive As New ZipArchive(zipToOpen, ZipArchiveMode.Update)
                        Dim readmeEntry As ZipArchiveEntry = archive.CreateEntryFromFile(fi.FullName, origPath.Name & "\" & fi.Name)
                        count += 1
                        dev = count / sum

                        'If dev = 1 Then
                        '    'BackgroundWorker1.ReportProgress(100)
                        '    'MsgBox("100")
                        'Else
                        BackgroundWorker1.ReportProgress(dev * 100)
                        'End If
                    End Using
                End Using
            Next

            Directory.Delete(defSavingPath & "\" & origPath.Name, True)

            'MsgBox("OPN successfully saved to" & vbCrLf & defSavingPath, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Saved")

            'dir_true = False

            'origPath.Delete(True)
            'RmDir(origPath.FullName)
            'Directory.Delete(origPath.FullName)
            refFin = True
        Else
            If dirTrue = False Then
                If Not Directory.Exists(DefDir) Then
                    Directory.CreateDirectory(DefDir)
                End If

                If File.Exists(DefDir & "\" & origPath.Name & ".zip") Then
                    MsgBox("File already exist!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "File Exist")
                    BackgroundWorker1.CancelAsync()
                End If

                Dim startPath, zipPath As String
                Dim sum, count As Integer
                Dim dev As Double

                startPath = TboxPath.Text
                zipPath = DefDir & "\" & origPath.Name & ".zip"

                'origPath.CreateSubdirectory(origPath.Name)

                Directory.CreateDirectory(DefDir & "\" & origPath.Name)
                Directory.CreateDirectory(DefDir & "\" & origPath.Name & "\" & origPath.Name)

                sum = origPath.GetFiles.Count
                count = 0

                'For Each f In origPath.GetFiles
                '    count += 1
                '    File.Move(f.FullName, origPath.FullName & "\" & origPath.Name & "\" & f.Name)
                '    If count = bar Then
                '        BackgroundWorker1.ReportProgress(Progress)
                '        Progress += 1
                '        bar += sum * 0.01
                '    End If
                'Next

                ZipFile.CreateFromDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "opn_checked" & "\" & origPath.Name, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "opn_checked" & "\" & origPath.Name & ".zip")

                For Each f In origPath.GetFiles
                    Dim fi As New FileInfo(f.FullName)
                    Using zipToOpen As New FileStream(DefDir & "\" & origPath.Name & ".zip", FileMode.Open)

                        Using archive As New ZipArchive(zipToOpen, ZipArchiveMode.Update)
                            Dim readmeEntry As ZipArchiveEntry = archive.CreateEntryFromFile(fi.FullName, origPath.Name & "\" & fi.Name)
                            count += 1
                            dev = count / sum

                            BackgroundWorker1.ReportProgress(dev * 100)

                        End Using
                    End Using
                Next

                'ZipFile.CreateFromDirectory(startPath, zipPath)
                Directory.Delete(DefDir & "\" & origPath.Name, True)

                defFin = True
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        LblPercent.Text = "Saving " & e.ProgressPercentage & "% complete"
        ProgressBar1.Value = e.ProgressPercentage
        ProgressBar1.Visible = True
        ProgressBar1.Maximum = 100
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        dirTrue = False

        If refFin = True Then
            Directory.Delete(TboxPath.Text, True)
            MsgBox("OPN successfully saved to" & vbCrLf & defSavingPath, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Saved")
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0
            TboxPath.Clear()
            refFin = False
            ReferenceToolStripMenuItem.Enabled = True
            TboxPath.Enabled = True
            BtnBrowse.Enabled = True
            BtnCheck.Enabled = True
            LblPercent.Visible = False
            LblPercent.Text = Nothing
        End If

        If defFin = True Then
            Directory.Delete(TboxPath.Text, True)
            MsgBox("OPN successfully saved to default directory" & vbCrLf & My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "opn_checked", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Saved")
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0
            TboxPath.Clear()
            defFin = False
            ReferenceToolStripMenuItem.Enabled = True
            TboxPath.Enabled = True
            BtnBrowse.Enabled = True
            BtnCheck.Enabled = True
            LblPercent.Visible = False
            LblPercent.Text = Nothing
        End If


    End Sub
End Class
