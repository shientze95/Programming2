Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim r, g, b As Integer
        r = txtR.Text
        g = txtG.Text
        b = txtB.Text
        Me.BackColor = Color.FromArgb(r, g, b)
    End Sub
End Class
