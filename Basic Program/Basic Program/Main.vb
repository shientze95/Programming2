Public Class frmMain

    Private Sub btnWelcome_Click(sender As Object, e As EventArgs) Handles btnWelcome.Click
        MessageBox.Show("Welcome to LFSE015 Programming 2", "Welcome Window")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Goodbye")
    End Sub
End Class
