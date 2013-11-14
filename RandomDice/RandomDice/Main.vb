Public Class frmMain

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim d1, d2, v1, v2, result As Double
        d1 = tb1.Value
        d2 = tb2.Value
        v1 = CInt(Int((d1 * Rnd()) + 1))
        v2 = CInt(Int((d2 * Rnd()) + 1))
        result = v1 + v2
        If result = 6 Then
            MsgBox("You win! :D")
        Else
            MsgBox("You fail! :P You got: " & result.ToString())
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim passin As Integer
        passin = LoginForm()
        If passin = 1 Then
            MsgBox("Welcome to Random Dice!")
        Else
            MsgBox("WRONG USERNAME/PASSWORD COMBINATION!")
            frmMain_Load(sender, e)
        End If
    End Sub

    Private Function LoginForm()
        Dim username, password As String
        username = InputBox("Username:")
        password = InputBox("Password:")
        If username = "Timothy" AndAlso password = "ACOMPLEXPASSWORD" Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class
