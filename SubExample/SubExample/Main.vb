Public Class frmMain

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        addsub(10, 20)
        minsub(22, 34)
    End Sub

    Private Sub addsub(ByVal a As Integer, ByVal b As Integer)
        MsgBox("a + b = " & a + b)
    End Sub

    Private Sub minsub(ByVal a As Integer, ByVal b As Integer)
        MsgBox("a - b = " & a - b)
    End Sub

End Class
