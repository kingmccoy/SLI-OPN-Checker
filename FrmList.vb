Imports System.Data.SQLite

Public Class FrmList
    ReadOnly conn As New SQLiteConnection
    Dim id As Integer
    Private Sub FrmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Load_OPN()
        dgvList.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9, FontStyle.Bold)
        TBoxSearch.Select()
    End Sub

    Public Sub Load_OPN()
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim dataset As New OPN

        Try
            Dim q = "select * from material"
            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(dataset.Tables("DataTableOPN"))
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        dgvList.DataSource = dataset.Tables("DataTableOPN")
    End Sub

    Private Sub TxtBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TBoxSearch.TextChanged
        TBoxSearch.MaxLength = 20
        TBoxSearch.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim dt As New OPN

        If TBoxSearch.Text = Nothing Then
            Load_OPN()
            TBoxSearch.Select()
        Else
            Try
                Dim q = "select * from material where id like '%\" & TBoxSearch.Text.Replace("'", "''") & "%' escape '\' or
                    material_no like '%\" & TBoxSearch.Text.Replace("'", "''") & "%' escape '\' or
                    ordering_part_no like '%\" & TBoxSearch.Text.Replace("'", "''") & "%' escape '\'"

                conn.Open()
                Using cmd As New SQLiteCommand(q, conn)
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(dt.Tables("DataTableOPN"))
                    End Using
                End Using
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            dgvList.DataSource = dt.Tables("DataTableOPN")
        End If
    End Sub

    Private Sub TBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBoxSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnSearch.PerformClick()
        End If

        'If Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub FrmList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        TBoxSearch.Clear()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmAddOPN.ShowDialog()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim q = "delete from material where id='" & id & "'"

        If dgvList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select row to remove", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Dim DiagResult As DialogResult = MessageBox.Show("Do you want to remove the selected OPN?", "Remove OPN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DiagResult = DialogResult.Yes Then
                Try
                    conn.Open()
                    Using cmd As New SQLiteCommand(q, conn)
                        cmd.ExecuteNonQuery()
                    End Using
                    conn.Close()

                    MessageBox.Show("OPN successfully removed.", "OPN Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_OPN()
                    dgvList.ClearSelection()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub DgvList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellClick
        If e.RowIndex >= 0 Then
            Dim SelectedRowIndex As Integer
            SelectedRowIndex = e.RowIndex

            Dim Row As DataGridViewRow = dgvList.Rows(SelectedRowIndex)
            id = Int(Row.Cells(0).Value)
            'MsgBox(id)
        End If
    End Sub
End Class