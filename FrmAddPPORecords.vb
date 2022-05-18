Imports System.Data.SQLite
Imports System.Text.RegularExpressions

Public Class FrmAddPPORecords
    ReadOnly conn As New SQLiteConnection
    Dim mat, fw, lot, ftc As Boolean

    Private Sub FrmPPORecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TboxNOPN.ReadOnly = True
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TboxMat.Text = Nothing Or TboxNOPN.Text = Nothing Or TboxFw.Text = Nothing Or TboxLotNum.Text = Nothing Or TboxFTC.Text = Nothing Or TboxPPOQty.Text = Nothing Then
            MessageBox.Show("Please fill up the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If mat = True Then
            MessageBox.Show("Invalid material number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If fw = True Then
            MessageBox.Show("Invalid firmware.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If lot = True Then
            MessageBox.Show("Invalid lot number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            If lot = False Then
                conn.ConnectionString = "Data Source = " & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
                Dim query = "select * from ppo_records where lot_number='" & TboxLotNum.Text & "'"
                Dim lotnum As String = ToString()

                Try
                    conn.Open()
                    Using cmd As New SQLiteCommand(query, conn)
                        Using reader As SQLiteDataReader = cmd.ExecuteReader
                            reader.Read()
                            If reader.HasRows Then
                                lotnum = reader("lot_number").ToString
                            End If
                        End Using
                    End Using
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                If lotnum = TboxLotNum.Text Then
                    MessageBox.Show("PPO already recorded. Please check your PPO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If
        End If

        If ftc = True Then
            MessageBox.Show("Invalid full trace code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Version=3;FailIfMissing=True;"
        Dim q = "insert into ppo_records (new_ordering_part_number,firmware,material,lot_number,full_trace_code,ppo_qty) values ('" &
                TboxNOPN.Text & "','" & TboxFw.Text & "','" & TboxMat.Text & "','" & TboxLotNum.Text & "','" & TboxFTC.Text & "','" & TboxPPOQty.Text & "')"

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

        Me.Close()

        FrmPPOList.Load_PPO_List()
    End Sub

    Private Sub TboxNOPN_TextChanged(sender As Object, e As EventArgs) Handles TboxNOPN.TextChanged
        TboxNOPN.MaxLength = 18
        TboxMat.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TboxFw_TextChanged(sender As Object, e As EventArgs) Handles TboxFw.TextChanged
        TboxFw.MaxLength = 6
        TboxFw.CharacterCasing = CharacterCasing.Upper

        Dim wfw = "^[0-9].[0-9].[0-9]{1,2}$"
        Dim nfw = "N/A"

        If Not TboxFw.Text = Nothing Then
            If (Regex.IsMatch(TboxFw.Text, wfw) Or Regex.IsMatch(TboxFw.Text, nfw)) = False Then
                ErrorProvider1.SetError(TboxFw, "Invalid firmware")
                fw = True
            Else
                ErrorProvider1.SetError(TboxFw, Nothing)
                fw = False
            End If
        Else
            ErrorProvider1.SetError(TboxFw, Nothing)
        End If
    End Sub

    Private Sub TboxFw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxFw.KeyPress
        'If (Char.IsNumber(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = vbBack) = False Then
        '    e.Handled = True
        'End If

        If TboxFw.Text = Nothing Then
            If e.KeyChar = "." Then
                e.Handled = True
            End If
        End If

        If TboxFw.Text.EndsWith(".") Then
            If e.KeyChar = "." Then
                e.Handled = True
            End If
        End If

        If TboxFw.Text.Length = 5 Then
            If e.KeyChar = "." Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnAdd.PerformClick()
        End If
    End Sub

    Private Sub TboxMat_TextChanged(sender As Object, e As EventArgs) Handles TboxMat.TextChanged
        TboxMat.MaxLength = 14
        TboxMat.CharacterCasing = CharacterCasing.Upper

        conn.ConnectionString = "Data Source = " & System.Windows.Forms.Application.StartupPath & "\opn.db;Verion=3;FailIfMissing=True;"
        Dim q = "select * from material where material_no='" & TboxMat.Text & "'"
        Dim material As String = ToString()

        Try
            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        TboxNOPN.Text = reader("ordering_part_no")
                        material = reader("material_no")
                    Else
                        TboxNOPN.Clear()
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If Not TboxMat.Text = Nothing Then
            If TboxMat.Text <> material Then
                ErrorProvider1.SetError(TboxMat, "Invalid material")
                mat = True
            Else
                ErrorProvider1.SetError(TboxMat, Nothing)
                mat = False
            End If
        Else
            ErrorProvider1.SetError(TboxMat, Nothing)
        End If
    End Sub

    Private Sub TboxMat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxMat.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnAdd.PerformClick()
        End If
    End Sub

    Private Sub TboxLotNum_TextChanged(sender As Object, e As EventArgs) Handles TboxLotNum.TextChanged
        TboxLotNum.MaxLength = 10
        TboxLotNum.CharacterCasing = CharacterCasing.Upper

        Dim lotn = "71[0-9]{5}.[1-9]{1,2}"

        If Not TboxLotNum.Text = Nothing Then
            If Regex.IsMatch(TboxLotNum.Text, lotn) = False Then
                ErrorProvider1.SetError(TboxLotNum, "Invalid lot number")
                lot = True
            Else
                ErrorProvider1.SetError(TboxLotNum, Nothing)
                lot = False
            End If
        Else
            ErrorProvider1.SetError(TboxLotNum, Nothing)
        End If
    End Sub

    Private Sub TboxLotNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxLotNum.KeyPress
        'If (Char.IsNumber(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = vbBack) = False Then
        '    e.Handled = True
        'End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnAdd.PerformClick()
        End If
    End Sub

    Private Sub TboxFTC_TextChanged(sender As Object, e As EventArgs) Handles TboxFTC.TextChanged
        TboxFTC.MaxLength = 10
        TboxFTC.CharacterCasing = CharacterCasing.Upper

        Dim tracecode = "[0-9]{4}[A-Z0-9]{6}"

        If Not TboxFTC.Text = Nothing Then
            If Regex.IsMatch(TboxFTC.Text, tracecode) = False Then
                ErrorProvider1.SetError(TboxFTC, "Invalid full trace code")
                ftc = True
            Else
                ErrorProvider1.SetError(TboxFTC, Nothing)
                ftc = False
            End If
        Else
            ErrorProvider1.SetError(TboxFTC, Nothing)
        End If
    End Sub

    Private Sub TboxFTC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxFTC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnAdd.PerformClick()
        End If
    End Sub

    Private Sub TboxPPOQty_TextChanged(sender As Object, e As EventArgs) Handles TboxPPOQty.TextChanged
        TboxPPOQty.MaxLength = 5
        TboxPPOQty.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TboxPPOQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TboxPPOQty.KeyPress
        If TboxPPOQty.Text = Nothing Then
            If e.KeyChar = "0" Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnAdd.PerformClick()
        End If

        If e.KeyChar = ChrW(Keys.Space) Or Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrmPPORecords_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        TboxMat.Clear()
        TboxNOPN.Clear()
        TboxFw.Clear()
        TboxLotNum.Clear()
        TboxFTC.Clear()
        TboxPPOQty.Clear()
    End Sub
End Class