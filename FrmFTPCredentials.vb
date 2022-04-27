﻿Imports System.Data.SQLite

Public Class FrmFTPCredentials
    Dim conn As New SQLiteConnection

    Private Sub FrmFTPCredentials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Credentials()
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
    End Sub
End Class