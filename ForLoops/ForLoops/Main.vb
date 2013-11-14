Public Class frmMain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double
        For x = 0 To 5
            ListBox1.Items.Add(x.ToString())
        Next
        MsgBox(x.ToString())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Double
        For x = 0 To 5
            ListBox1.Items.Add(x.ToString())
        Next x
        MsgBox(x.ToString())
    End Sub
End Class
