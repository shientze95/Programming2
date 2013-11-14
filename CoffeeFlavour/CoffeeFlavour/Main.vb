Public Class frmMain
#Region "Declaration"
    Dim Flavour, SelectedFlavour As String
#End Region
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Flavour = InputBox("Please input coffee flavour:")
        If CheckFlavour(Flavour) = True Then
            MsgBox("The flavour is already in the list!")

        Else
            lbFlavour.Items.Add(Flavour)
        End If

    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        SelectedFlavour = lbFlavour.SelectedItem
        If lbFlavour.SelectedItem Is Nothing Then
            MsgBox("Please select a flavour!")
        Else
            lbFlavour.Items.Remove(SelectedFlavour)
        End If
    End Sub

    Private Function CheckFlavour(ByVal FlavourName As String)
        Dim ANS As Boolean
        For LoopCount As Integer = 0 To (lbFlavour.Items.Count - 1)
            If lbFlavour.Items(LoopCount) = FlavourName Then
                ANS = True
                Exit For
            Else
                ANS = False
            End If
        Next
        Return ANS
    End Function
End Class
