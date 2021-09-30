Imports System.Data.SQLite

Public Class FrmAddOPN
    ReadOnly conn As New SQLiteConnection

    Private Sub TboxMaterial_TextChanged(sender As Object, e As EventArgs) Handles TboxMaterial.TextChanged
        TboxMaterial.MaxLength = 15
    End Sub

    Private Sub TboxMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxMaterial.KeyPress
        TboxMaterial.CharacterCasing = CharacterCasing.Upper

        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnAdd.PerformClick()
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"

        If TboxMaterial.Text = Nothing Then
            MsgBox("Please enter new material number", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid")
            Return
        End If

        If TboxMaterial.Text.Length < 14 Or TboxMaterial.Text.Length > 15 Then
            MsgBox("You have entered an invalid material.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid")
            Return
        End If

        Dim mat As String = ToString()

        Try
            Dim q = "select material_no from material where material_no = '" & TboxMaterial.Text & "'"

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        mat = reader("material").ToString
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try

        If mat = TboxMaterial.Text Then
            MsgBox("Material already in the list. Please enter a different material.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            Return
        End If

        Try
            Dim q = "insert into material (material_no) values ('" & TboxMaterial.Text & "')"

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try

        MsgBox("Material successfully added", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        TboxMaterial.Clear()
    End Sub

    Private Sub FrmAddOPN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
    End Sub
End Class