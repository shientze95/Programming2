Public Class Main
    Dim a, b, c As Double
    Private Sub getnum(ByRef c As Double, ByRef d As Double)
        Double.TryParse(txt1.Text, c)
        Double.TryParse(txt2.Text, d)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call getnum(a, b)
        c = a + b
        txtResult.Text = c.ToString()
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Call getnum(a, b)
        c = a - b
        txtResult.Text = c.ToString()
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Call getnum(a, b)
        c = a * b
        txtResult.Text = c.ToString()
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Call getnum(a, b)
        c = a / b
        txtResult.Text = c.ToString()
    End Sub
End Class
