Imports System.Data.SQLite
Imports System.Text.RegularExpressions

Public Class FrmAddOPN
    ReadOnly conn As New SQLiteConnection

    Private Sub TboxMaterial_TextChanged(sender As Object, e As EventArgs) Handles TboxMaterial.TextChanged
        TboxMaterial.MaxLength = 14
        TboxMaterial.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TboxMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxMaterial.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnAdd.PerformClick()
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim matnum = "^R9113[A-Z0-9]{9}$"
        Dim opn = "^RS9113-[NB0Z]{3}-[SD10NWCX]{3}-[X0-9]{3}$"

        If Not Regex.IsMatch(TboxMaterial.Text, matnum) Then
            MessageBox.Show("Please provide the correct OPN.", "Invalid OPN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Regex.IsMatch(TboxOPN.Text, opn) Then
            MessageBox.Show("Please provide the correct OPN.", "Invalid OPN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'If TboxMaterial.Text = Nothing Then
        '    MsgBox("Please enter new material number", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid")
        '    Return
        'End If

        'If TboxMaterial.Text.Length < 14 Or TboxMaterial.Text.Length > 15 Then
        '    MsgBox("You have entered an invalid material.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid")
        '    Return
        'End If

        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim q = "insert into material (material_no,ordering_part_no) values ('" & TboxMaterial.Text & "','" & TboxOPN.Text & "')"
        Dim d = "select * from material where material_no='" & TboxMaterial.Text & "' or ordering_part_no='" & TboxOPN.Text & "'"

        Dim exist As Boolean

        Try
            conn.Open()
            Using cmd As New SQLiteCommand(d, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        If (TboxMaterial.Text = reader("material_no").ToString Or TboxOPN.Text = reader("ordering_part_no").ToString) Then
                            MessageBox.Show("OPN already exist", "OPN Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            exist = True
                        End If
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If exist = True Then
            Return
        End If

        Try
            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MessageBox.Show("OPN successfully added.", "New OPN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TboxMaterial.Clear()
        TboxOPN.Clear()
        Me.Close()

        FrmList.Load_OPN()
        FrmList.dgvList.ClearSelection()

        'Try
        '    Dim q = "insert into material (material_no) values ('" & TboxMaterial.Text & "')"

        '    conn.Open()
        '    Using cmd As New SQLiteCommand(q, conn)
        '        cmd.ExecuteNonQuery()
        '    End Using
        '    conn.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        'End Try

        'MsgBox("Material successfully added", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        'TboxMaterial.Clear()
    End Sub

    Private Sub FrmAddOPN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
    End Sub

    Private Sub TboxOPN_TextChanged(sender As Object, e As EventArgs) Handles TboxOPN.TextChanged
        TboxOPN.MaxLength = 18
        TboxOPN.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TboxOPN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxOPN.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnAdd.PerformClick()
        End If
    End Sub
End Class