Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim num1 As Integer = 15
        Dim num2 As Integer = 10
        Dim swap As Integer
        MsgBox("num1 = " & num1.ToString() & vbNewLine & "num2 = " & num2.ToString())
        swap = num1
        num1 = num2
        num2 = swap
        MessageBox.Show("num1 = " & num1.ToString() & vbNewLine & "num2 = " & num2.ToString(), "Newvalues")
        Me.Close()
    End Sub
End Class
