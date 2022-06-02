Imports System.Data.SQLite

Public Class FrmLogs
    ReadOnly conn As New SQLiteConnection
    Dim id As Integer

    Private Sub FrmPPOList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Logs()
        TboxSearch.Clear()

        'DGVPPOList.ClearSelection()

        With DGVLogs.ColumnHeadersDefaultCellStyle
            .Font = New Font("Segoe UI Semibold", 9, FontStyle.Bold)
            '.BackColor = Color.Black
            '.ForeColor = Color.White
        End With
    End Sub

    Public Sub Load_Logs()
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim q = "select * from logs"
        'Dim dt As New DataTable
        Dim dt As New Logs

        Try
            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(dt.Tables("DataTableLogs"))
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        DGVLogs.DataSource = dt.Tables("DataTableLogs")
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim q = "select * from logs where id like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or filename like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") &
                "%' escape '\' or material like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or new_ordering_part_number like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") &
                "%' escape '\' or firmware like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or lot_number like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") &
                "%' escape '\' or full_trace_code like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or ppo_qty like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") &
                "%' escape '\' or station like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or qty like'%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") &
                "%' escape '\' or passed like'%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or failed like'%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") &
                "%' escape '\' or date like'%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or time like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\'"
        Dim dataset As New Logs

        Try
            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(dataset.Tables("DataTableLogs"))
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        DGVLogs.DataSource = dataset.Tables("DataTableLogs")
    End Sub

    Private Sub DGVPPOList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLogs.CellClick
        If e.RowIndex >= 0 Then
            Dim SelectedRowIndex As Integer
            SelectedRowIndex = e.RowIndex

            Dim Row As DataGridViewRow = DGVLogs.Rows(SelectedRowIndex)
            id = Int(Row.Cells(0).Value)
        End If
    End Sub

    Private Sub FrmPPOList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DGVLogs.ClearSelection()
    End Sub

    Private Sub TboxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnSearch.PerformClick()
        End If
    End Sub

    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        Try
            conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
            Dim q = "select * from logs where date between '" & DtpFrom.Value.ToString("MM-dd-yyyy") & "' and '" & DtpTo.Value.ToString("MM-dd-yyyy") & "'"
            Dim dt As New Logs

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(dt.Tables("DataTableLogs"))
                End Using
            End Using
            conn.Close()

            DGVLogs.DataSource = dt.Tables("DataTableLogs")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class