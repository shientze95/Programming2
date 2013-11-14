Public Class frmMain

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lbDisplay.Items.Clear()
        Dim value, endval, startval, stepval As Double
        Double.TryParse(txtStart.Text, startval)
        Double.TryParse(txtEnd.Text, endval)
        Double.TryParse(txtStep.Text, stepval)
        value = startval
        Select Case rdPre.Checked
            Case True
                If startval > endval Then
                    Do While value >= endval
                        lbDisplay.Items.Add(value)
                        value -= stepval
                    Loop
                Else
                    Do While value <= endval
                        lbDisplay.Items.Add(value)
                        value += stepval
                    Loop
                End If
            Case Else
                If startval > endval Then
                    Do
                        lbDisplay.Items.Add(value)
                        value -= stepval
                    Loop While value >= endval
                Else
                    Do
                        lbDisplay.Items.Add(value)
                        value += stepval
                    Loop While value <= endval
                End If
        End Select

    End Sub

    Private Sub btnValue2_Click(sender As Object, e As EventArgs) Handles btnValue2.Click
        lbDisplay.Items.Clear()
        Dim value, endval, startval, stepval As Double
        Double.TryParse(txtStart.Text, startval)
        Double.TryParse(txtEnd.Text, endval)
        Double.TryParse(txtStep.Text, stepval)
        value = startval
        Select Case rdPre.Checked
            Case True
                If startval > endval Then
                    Do Until value < endval
                        lbDisplay.Items.Add(value)
                        value -= stepval
                    Loop
                Else
                    Do Until value > endval
                        lbDisplay.Items.Add(value)
                        value += stepval

                    Loop
                End If
            Case Else
                If startval > endval Then
                    Do
                        lbDisplay.Items.Add(value)
                        value -= stepval
                    Loop Until value < endval
                Else
                    Do
                        lbDisplay.Items.Add(value)
                        value += stepval
                    Loop Until value > endval
                End If
        End Select
    End Sub
End Class
