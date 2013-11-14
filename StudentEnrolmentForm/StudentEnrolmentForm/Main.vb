Public Class frmMain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name, id, format As String
        name = txtName.Text
        id = txtID.Text
        format = name & vbTab & "(" + id + ")"
        If cb1.Checked And cb2.Checked And cb3.Checked Then
            StudentList.Items.Add(format)
        Else
            MsgBox("You have not met the requirements!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim count As Single
        count = StudentList.Items.Count()
        MsgBox("There is a total of " & count.ToString() & " students.")
    End Sub
End Class
