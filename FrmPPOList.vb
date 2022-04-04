Imports System.Data.SQLite

Public Class FrmPPOList
    ReadOnly conn As New SQLiteConnection

    Private Sub FrmPPOList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_PPO_List()

        DGVPPOList.ClearSelection()

        With DGVPPOList.ColumnHeadersDefaultCellStyle
            .Font = New Font("Segoe UI Semibold", 9, FontStyle.Bold)
            '.BackColor = Color.Black
            '.ForeColor = Color.White
        End With
    End Sub

    Public Sub Load_PPO_List()
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim q = "select * from ppo_records"
        'Dim dt As New DataTable
        Dim dt As New PPOList

        Try
            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(dt.Tables("DataTablePPOList"))
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        DGVPPOList.DataSource = dt.Tables("DataTablePPOList")
        DGVPPOList.ClearSelection()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmPPORecords.ShowDialog()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim q = "select * from ppo_records where id like '%\" & TboxSearch.Text.Replace("'", "''") & "%' escape '\' or
                    material_no like '%\" & TboxSearch.Text.Replace("'", "''") & "%' escape '\' or
                    ordering_part_no like '%\" & TboxSearch.Text.Replace("'", "''") & "%' escape '\'"

        Try
            conn.Open()

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class