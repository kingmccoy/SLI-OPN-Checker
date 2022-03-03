Imports System.Data.SQLite

Public Class FrmList
    ReadOnly conn As New SQLiteConnection

    Private Sub FrmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Load_OPN()
        dgvList.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9, FontStyle.Bold)
        TBoxSearch.Select()
    End Sub

    Private Sub Load_OPN()
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
            End Iff
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
End Class