Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim a As Double = 1
        Dim b As Double = 1
        Dim c As Double
        Dim display As String
        For count As Integer = 1 To 10
            c = a + b
            display = CStr(a) & "+" & CStr(b) & "=" & CStr(c)
            lbDisplay.Items.Add(display)
            a = b
            b = c
        Next
    End Sub
End Class
