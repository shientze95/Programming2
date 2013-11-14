Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Dim int1, int2, total As Integer
        'Integer.TryParse(txt1.Text, int1)
        'Integer.TryParse(txt2.Text, int2)
        'total = int1 + int2
        'txtVal.Text = total.ToString()
        Dim a, b, c As Integer
        a = txt1.Text
        b = txt2.Text
        c = a + b
        txtVal.Text = a + b
    End Sub
End Class
