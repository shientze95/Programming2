Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ab, c As Double
        For ab = 1 To 10
            c = (2 * (ab ^ 2)) ^ 0.5
            xNumberLabel.Text += vbNewLine & c.ToString()
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ab, c As Double
        ab = 1
        Do While ab <= 10
            c = (2 * (ab ^ 2)) ^ 0.5
            xNumberLabel.Text += vbNewLine & c.ToString()
            ab += 1
        Loop
    End Sub
End Class
