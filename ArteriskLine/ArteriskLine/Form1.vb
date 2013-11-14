Public Class Form1
    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim Count As Integer
        Dim DisStr As String = ""
        lblShow.Text = String.Empty
        Integer.TryParse(txtCount.Text, Count)
        For X = 1 To Count
            DisStr += "*"
        Next
        For Y = 1 To Count
            lblShow.Text += vbNewLine & DisStr
        Next
    End Sub
End Class
