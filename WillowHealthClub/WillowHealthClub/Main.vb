Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim weight, calories As Double
        Double.TryParse(txtWeight.Text, weight)
        If radF.Checked AndAlso radA.Checked Then
            calories = weight * 12
        ElseIf radF.Checked AndAlso radI.Checked Then
            calories = weight * 10
        ElseIf radM.Checked AndAlso radA.Checked Then
            calories = weight * 15
        ElseIf radM.Checked AndAlso radI.Checked Then
            calories = weight * 13
        End If
        lblDisplay.Text = calories.ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
