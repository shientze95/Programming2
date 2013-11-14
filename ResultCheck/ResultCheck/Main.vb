Public Class frmMain

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim result As Double
        result = InputBox("Enter your result:", "Result", 0)
        If result > 49 Then
            lblResult.Text = "PASS"
        ElseIf result < 20 Then
            lblResult.Text = "FAIL TAHAP DEWA"
        Else
            lblResult.Text = "FAIL"
        End If
    End Sub
End Class
