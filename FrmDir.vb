Imports System.Data.SQLite
Imports System.IO

Public Class FrmDir
    ReadOnly conn As New SQLiteConnection

    Private Sub FrmRef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Path()
        If TboxPath.Text = Nothing Then
            TboxPath.Select()
        Else
            LblInfo.Select()
        End If
    End Sub

    Sub Load_Path()
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"

        Try
            Dim q = "select path from reference"

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        TboxPath.Text = reader("path").ToString
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim DResult As DialogResult = FolderBrowserDialog1.ShowDialog
        FolderBrowserDialog1.Description = "Select path for the default saving location."

        If DResult = DialogResult.OK Then
            Dim path As New DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            Dim fname = path.FullName

            TboxPath.Text = fname
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"

        If TboxPath.Text = Nothing Then
            Try
                Dim del = "delete from reference"
                conn.Open()
                Using cmd As New SQLiteCommand(del, conn)
                    cmd.ExecuteNonQuery()
                End Using
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
            MsgBox("Default directory retored", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Default Directory")
            Me.Close()
            Return
        End If

        If Not Directory.Exists(TboxPath.Text) Then
            MsgBox("Directory do not exist.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Directory")
            Return
        End If

        Try
            Dim del = "delete from reference"

            conn.Open()
            Using cmd As New SQLiteCommand(del, conn)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()

            Dim q = "insert into reference (path) values ('" & TboxPath.Text & "')"

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()

            MsgBox("Directory succesfully saved.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Saved")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TboxPath_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxPath.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnSave.PerformClick()
        End If
    End Sub
End Class