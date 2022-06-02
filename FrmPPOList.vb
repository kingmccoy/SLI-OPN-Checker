﻿Imports System.Data.SQLite

Public Class FrmPPOList
    ReadOnly conn As New SQLiteConnection
    Dim id As Integer

    Private Sub FrmPPOList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_PPO_List()
        TboxSearch.Clear()

        'DGVPPOList.ClearSelection()

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
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmAddPPORecords.ShowDialog()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim q = "select * from ppo_records where id like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or material like '%" &
                TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or new_ordering_part_number like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") &
                "%' escape '\' or firmware like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or lot_number like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") &
                "%' escape '\' or full_trace_code like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\' or ppo_qty like '%" & TboxSearch.Text.Replace("'", "''").Replace("\", "\\") & "%' escape '\'"
        Dim dataset As New PPOList

        Try
            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(dataset.Tables("DataTablePPOList"))
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        DGVPPOList.DataSource = dataset.Tables("DataTablePPOList")
    End Sub

    Private Sub DGVPPOList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPPOList.CellClick
        If e.RowIndex >= 0 Then
            Dim SelectedRowIndex As Integer
            SelectedRowIndex = e.RowIndex

            Dim Row As DataGridViewRow = DGVPPOList.Rows(SelectedRowIndex)
            id = Int(Row.Cells(0).Value)
        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim q = "delete from ppo_records where id='" & id & "'"

        If DGVPPOList.SelectedRows.Count = 0 Then
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

                    Load_PPO_List()
                    DGVPPOList.ClearSelection()
                    MessageBox.Show("OPN successfully removed.", "OPN Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub FrmPPOList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DGVPPOList.ClearSelection()
    End Sub

    Private Sub TboxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnSearch.PerformClick()
        End If
    End Sub
End Class