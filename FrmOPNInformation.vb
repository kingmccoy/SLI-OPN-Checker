Imports System.Data.SQLite

Public Class FrmOPNInformation
    ReadOnly conn As New SQLiteConnection
    Dim Lotnumber As String = Nothing

    Public Sub Lot(ByVal i As String)
        Lotnumber = i
    End Sub

    Private Sub FrmOPNInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim material As String = Nothing
        Dim opn As String = Nothing
        Dim fw As String = Nothing
        Dim lotnum As String = Nothing
        Dim fulltracecode As String = Nothing
        Dim ppoqty As String = Nothing

        Try
            Dim q = "select * from ppo_records where lot_number='" & Lotnumber & "'"
            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        material = reader("material").ToString
                        opn = reader("new_ordering_part_number").ToString
                        fw = reader("firmware").ToString
                        lotnum = reader("lot_number").ToString
                        fulltracecode = reader("full_trace_code").ToString
                        ppoqty = reader("ppo_qty").ToString
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        TboxMaterial.Text = material
        TboxOPN.Text = opn
        TboxFirmware.Text = fw
        TboxLotNum.Text = lotnum
        TboxFullTraccode.Text = fulltracecode
        TboxPPOQty.Text = ppoqty
        BtnOK.Select()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub
End Class