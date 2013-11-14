Public Class frmMain

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        Dim user, passwd As String
        user = txtUser.Text
        passwd = txtPasswd.Text
        If user = "Timur" And passwd = "password" Then
            txtResult.Text = "YAY U IS IN"
        Else
            txtResult.Text = "Go away"
        End If
    End Sub
End Class
