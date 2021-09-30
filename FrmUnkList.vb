Imports System.IO

Public Class FrmUnkList
    ReadOnly Unknown As New List(Of String)

    Private Sub FrmUnkList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        LstBoxUnk.Items.Clear()

        For Each list In FrmMain.strng
            Dim l As New DirectoryInfo(list)
            Unknown.Add(l.FullName)
            LstBoxUnk.Items.Add(l.Name)
        Next
    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        If LstBoxUnk.SelectedItem = Nothing Then
            MsgBox("Please select to open", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "No Selection")
            Return
        End If

        Process.Start(Unknown.Item(LstBoxUnk.SelectedIndex))
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        If LstBoxUnk.SelectedItem = Nothing Then
            MsgBox("Please select to remove", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "No Selection")
            Return
        End If

        'MsgBox(Unkown.Item(LstBoxUnk.SelectedIndex).ToString)
        If File.Exists(Unknown.Item(LstBoxUnk.SelectedIndex).ToString) Then
            System.IO.File.Delete(Unknown.Item(LstBoxUnk.SelectedIndex).ToString)
        End If

        FrmMain.strng.RemoveAt(LstBoxUnk.SelectedIndex)
        Unknown.RemoveAt(LstBoxUnk.SelectedIndex)
        LstBoxUnk.Items.Remove(LstBoxUnk.SelectedItem)

        FrmMain.LblTotalCount.Text -= 1

        'FrmMain.BtnCheck.PerformClick()

        Dim str As New List(Of String)

        Dim path As New DirectoryInfo(FrmMain.TboxPath.Text)

        For Each d In path.GetFiles()
            Dim f As New FileInfo(d.ToString)
            str.Add(f.ToString)
        Next

        If path.GetFiles.Count <> Int(FrmMain.LblPassCount.Text) + Int(FrmMain.LblFailedCount.Text) Then
            Dim l = FrmMain.LblTotalCount.Location()
            Dim lw = FrmMain.LblTotalCount.Width
            Dim p = FrmMain.LblTotalFeedback.Location

            FrmMain.LblTotalFeedback.Location = New Point(l.X + lw + 20, p.Y)
            FrmMain.LblTotalFeedback.Text = "Click to view" 'path.GetFiles.Count - (pass + failed) & "Click to view"
            FrmMain.ErrorProvider1.SetError(FrmMain.LblTotalCount, path.GetFiles.Count - (Int(FrmMain.LblPassCount.Text) + Int(FrmMain.LblFailedCount.Text)) & " Unknown filename")
            FrmMain.LblTotalFeedback.Visible = True
        Else
            FrmMain.LblTotalFeedback.Text = Nothing
            FrmMain.LblTotalFeedback.Visible = False
            FrmMain.ErrorProvider1.SetError(FrmMain.LblTotalCount, "")
            FrmMain.LblTotalFeedback.Visible = False
            FrmMain.BtnSave.Enabled = True
        End If

        If LstBoxUnk.Items.Count = 0 Then
            BtnOpen.Enabled = False
            BtnRemove.Enabled = False
        End If
    End Sub
End Class