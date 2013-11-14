Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intX As Integer = 1
        Dim intY As Integer
        Do
            intY = 1
            Do
                MsgBox(intY.ToString())
                intY += 2
            Loop Until intY > 5
            MsgBox(intX.ToString())
            intX += 1
        Loop Until intX > 3

    End Sub
End Class
