Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim age As Integer
        Dim price As String
        Integer.TryParse(txtAge.Text, age)
        'If age < 5 OrElse age >= 55 Then
        'price = "FREE"
        'ElseIf age >= 5 And age <= 12 Then
        'price = "HALF PRICE"
        'ElseIf age >= 13 And age <= 54 Then
        'price = "FULL PRICE"
        'Else
        'price = "NO IDEA, MAN"
        'End If
        If age < 5 Then
            price = "free"
        ElseIf age <= 12 Then
            price = "half price"
        ElseIf age <= 54 Then
            price = "full price"
        Else
            price = "free"
        End If
        lblResult.Text = price
    End Sub
End Class
