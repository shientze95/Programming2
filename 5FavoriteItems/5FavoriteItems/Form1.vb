Public Class Form1

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim fav As String
        Dim a As Single
        For a = 1 To 5
            fav = InputBox("What's your no. " & a & " favorite item?")
            lbDisplay.Items.Add(fav)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim unfav As String
        unfav = InputBox("What do you want to clear?")
        lbDisplay.Items.Remove(unfav)
    End Sub

    Private Sub btnCA_Click(sender As Object, e As EventArgs) Handles btnCA.Click
        lbDisplay.Items.Clear()
    End Sub
End Class
