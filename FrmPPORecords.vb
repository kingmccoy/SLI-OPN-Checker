Imports System.Data.SQLite

Public Class FrmPPORecords
    ReadOnly conn As New SQLiteConnection

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim q = "insert into ppo_records (new_ordering_part_number,firmware,material,lot_number,full_trace_code,ppo_qty,sap_gr_qty,gr_date) 
                values ('" & TboxNOPN.Text & "','" & TboxFw.Text & "','" & TboxMat.Text & "','" & TboxLotNum.Text & "','" & TboxFTC.Text &
                "','" & TboxPPOQty.Text & "','" & TboxGRQty.Text & "','" & TboxGRDate.Text & "')"

        Try
            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MessageBox.Show("PPO List successfully added.", "New PPO Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class