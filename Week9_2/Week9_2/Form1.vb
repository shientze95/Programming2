Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Product(5, 1) As String
        Product(0, 0) = "AA01"
        Product(1, 0) = "BB02"
        Product(2, 0) = "CC03"
        Product(3, 0) = "DD04"
        Product(4, 0) = "EE05"
        Product(5, 0) = "FF06"
        Product(0, 1) = "10.50"
        Product(1, 1) = "12.00"
        Product(2, 1) = "8.40"
        Product(3, 1) = "25.00"
        Product(4, 1) = "9.00"
        Product(5, 1) = "7.50"
        Dim Code As String
        Dim Match As Boolean
        Code = txtCode.Text.ToLower()
        For CountX = 0 To Product.GetUpperBound(0)
            If Code = Product(CountX, 0).ToLower() Then
                lblShow.Text = Product(CountX, 1)
                Match = True
            End If
        Next
        Select Case Match
            Case True
                'Do nothing
            Case False
                MsgBox("No match found!")
        End Select
    End Sub
End Class
