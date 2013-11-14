Public Class Form1

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim a As Double
        For a = 99 To 0 Step -11
            lbDisplay.Items.Add(a)
        Next a
        'While a < 101
        'lbDisplay.Items.Add(a)
        'a += 1
        'End While
    End Sub
End Class
