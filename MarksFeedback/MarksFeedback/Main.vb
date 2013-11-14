Public Class frmMain

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim mark As Integer
        Dim feedback As String
        mark = InputBox("What are your marks?")
        Select Case mark
            Case 0 To 49
                feedback = "NEED TO WORK HARD"
            Case 50 To 59
                feedback = "AVERAGE"
            Case 60 To 69
                feedback = "ABOVE AVERAGE"
            Case 70 To 84
                feedback = "GOOD"
            Case 85 To 100
                feedback = "EXCELLENCE"
            Case Else
                feedback = "WRONG ENTRY"
        End Select
        txtFeedback.Text = feedback
    End Sub
End Class
