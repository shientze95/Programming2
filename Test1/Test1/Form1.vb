Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count, value As Double
        Double.TryParse(txtUserInput.Text, value)
        For count = 1 To value
            OutputLbl.Text += "****" & vbNewLine
        Next
        
    End Sub
End Class
