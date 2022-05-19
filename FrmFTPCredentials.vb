Imports System.Data.SQLite
Imports System.Net

Public Class FrmFTPCredentials
    ReadOnly conn As New SQLiteConnection
    Dim status As Boolean = False

    Private Sub FrmFTPCredentials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Credentials()
        TBoxPassword.UseSystemPasswordChar = True
        status = False
    End Sub

    Private Sub Load_Credentials()
        conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Verion=3;FailIfMissing=True;"

        Try
            Dim q = "select * from ftp_credentials"

            conn.Open()
            Using cmd As New SQLiteCommand(q, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        TBoxHost.Text = reader("host").ToString
                        TBoxUsername.Text = reader("username").ToString
                        TBoxPassword.Text = reader("password").ToString
                        TBoxPath.Text = reader("path").ToString
                    Else
                        TBoxHost.Text = Nothing
                        TBoxUsername.Text = Nothing
                        TBoxPassword.Text = Nothing
                        TBoxPath.Text = Nothing
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        LblHost.Select()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TBoxHost.Text = Nothing Or TBoxUsername.Text = Nothing Or TBoxPassword.Text = Nothing Or TBoxPath.Text = Nothing Then
            MessageBox.Show("FTP credentials cannot be empty." & vbCrLf & "Please enter the FTP credentials.", "Error FTP Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If status = True Then
            Dim DiagResult As DialogResult = MessageBox.Show("Do you want to save this credentials?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If DiagResult = DialogResult.Yes Then
                conn.ConnectionString = "Data Source=" & System.Windows.Forms.Application.StartupPath & "\opn.db;Verion=3;FailIfMissing=True;"

                'delete existing database record
                Try
                    Dim q = "delete from ftp_credentials"
                    conn.Open()
                    Using cmd As New SQLiteCommand(q, conn)
                        cmd.ExecuteNonQuery()
                    End Using
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                'add database record
                Try
                    Dim q = "insert into ftp_credentials (host,username,password,path) values ('" & TBoxHost.Text & "','" & TBoxUsername.Text & "','" & TBoxPassword.Text & "','" & TBoxPath.Text & "')"

                    conn.Open()
                    Using cmd As New SQLiteCommand(q, conn)
                        cmd.ExecuteNonQuery()
                    End Using
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                MessageBox.Show("Credentials successfully saved.", "FTP Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            MessageBox.Show("Please check connection status of the FTP credentials to proceed.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        If TBoxHost.Text = Nothing Or TBoxUsername.Text = Nothing Or TBoxPassword.Text = Nothing Or TBoxPath.Text = Nothing Then
            MessageBox.Show("Invalid FTP Credentials. Please check the FTP credentials.", "Error FTP Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim request = DirectCast(WebRequest.Create(TBoxHost.Text & "/" & TBoxPath.Text), FtpWebRequest)

        request.Credentials = New NetworkCredential(TBoxUsername.Text, TBoxPassword.Text)
        request.Method = WebRequestMethods.Ftp.ListDirectory

        Try
            Using response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
                ' Folder exists
                status = True
                MessageBox.Show("Successfully connected.", "FTP Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As WebException
            ' Folder doesn't exist
            status = False
            MessageBox.Show("Connection error. Please check your credentials.", "FTP Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TBoxPath_TextChanged(sender As Object, e As EventArgs) Handles TBoxPath.TextChanged
        status = False
    End Sub

    Private Sub TBoxHost_TextChanged(sender As Object, e As EventArgs) Handles TBoxHost.TextChanged
        status = False
    End Sub

    Private Sub TBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TBoxUsername.TextChanged
        status = False
    End Sub

    Private Sub TBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TBoxPassword.TextChanged
        status = False
    End Sub
End Class