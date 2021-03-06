﻿Public Class frmMain
    Private Structure Student
        Dim Name As String
        Dim Marks As Double()
    End Structure
    Dim StudentList(-1) As Student

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Select Case ValidateInput() 'We want to check for errors
            Case 0
                MsgBox("Invalid input!")
                Exit Sub
            Case 1
                MsgBox("Test mark is invalid!")
                Exit Sub
            Case 2
                MsgBox("Student already exists!")
                Exit Sub
            Case 3
                Console.WriteLine("Data is valid.")
        End Select
        ReDim Preserve StudentList(StudentList.GetUpperBound(0) + 1) 'We add one more place in the structure list
        ReDim StudentList(StudentList.GetUpperBound(0)).Marks(2) 'We redim so we can add 3 marks
        'We can now add all the information to the newest "slot" in the structure array
        StudentList(StudentList.GetUpperBound(0)).Name = txtName.Text
        StudentList(StudentList.GetUpperBound(0)).Marks(0) = CDbl(txtT1.Text)
        StudentList(StudentList.GetUpperBound(0)).Marks(1) = CDbl(txtT2.Text)
        StudentList(StudentList.GetUpperBound(0)).Marks(2) = CDbl(txtT3.Text)
        txtName.Focus()
        txtName.SelectAll()
    End Sub

    Private Function ValidateInput()
        If txtName.Text = vbNullString OrElse IsNumeric(txtT1.Text) = False OrElse IsNumeric(txtT2.Text) = False OrElse IsNumeric(txtT3.Text) = False Then
            Return 0 'Return 0 is any textbox is empty
        Else
            If CInt(txtT1.Text) > 100 OrElse CInt(txtT2.Text) > 100 OrElse CInt(txtT3.Text) > 100 OrElse CInt(txtT1.Text) < 0 OrElse CInt(txtT2.Text) < 0 OrElse CInt(txtT3.Text) < 0 Then
                Return 1 'Return 1 if the marks are invalid
            Else
                For LoopCount = 0 To StudentList.GetUpperBound(0)
                    If StudentList(LoopCount).Name = txtName.Text Then
                        Return 2 'Return 2 if the name already exists
                        Exit Function
                    End If
                Next
                Return 3 'Return 3 if all is valid
            End If
        End If
    End Function

    Private Sub cbName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbName.Enter
        'Remove all items to avoid duplicates
        cbName.Items.Clear()
        'We create a loop that goes from all indexes in the StudentList array
        For LoopCount = 0 To StudentList.GetUpperBound(0)
            'We add each name to the combobox
            cbName.Items.Add(StudentList(LoopCount).Name)
        Next
    End Sub

    Private Sub btnResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResults.Click
        Dim Name As String
        Name = cbName.SelectedItem
        'We create an integer and use a function to get the name of the index
        Dim NameCount As Integer = GetNameIndex(Name)
        ShowT1.Text = StudentList(NameCount).Marks(0)
        ShowT2.Text = StudentList(NameCount).Marks(1)
        ShowT3.Text = StudentList(NameCount).Marks(2)
    End Sub

    Private Function GetNameIndex(ByVal Name As String)
        Dim CatchVal As Integer
        'Loop through all items
        For LoopCount = 0 To StudentList.GetUpperBound(0)
            If Name = StudentList(LoopCount).Name Then
                'If the name given to the function is same as that in the list, we get the index
                CatchVal = LoopCount
                Exit For
            End If
        Next
        Return CatchVal
    End Function

    Private Sub btnSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSummary.Click
        'We recall the results to be sure
        btnResults_Click(sender, e)
        Dim Total, Average, StudentCount As Double
        Dim FormatString As String
        Total = CInt(ShowT1.Text) + CInt(ShowT2.Text) + CInt(ShowT3.Text)
        Average = Total / 3
        StudentCount = StudentList.GetUpperBound(0)
        FormatString = cbName.SelectedItem & "'s results are:" & vbNewLine & "Total marks: " & Total.ToString() & vbNewLine & "Average marks: " & Average.ToString() & vbNewLine & "Out of " & StudentCount.ToString() & " students."
        txtSummary.Text = FormatString

    End Sub

    Private Sub cbName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbName.SelectedIndexChanged
        'We clear all the labels that start with "Show"
        For Each X As Control In GDisplay.Controls
            If TypeOf X Is Label AndAlso X.Name.Substring(0, 4) = "Show" Then
                X.Text = String.Empty
            End If
        Next
    End Sub

#Region "SelectAll"
    Private Sub txtT1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtT1.Enter
        txtT1.SelectAll()
    End Sub

    Private Sub txtT2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtT2.Enter
        txtT2.SelectAll()
    End Sub

    Private Sub txtT3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtT3.Enter
        txtT3.SelectAll()
    End Sub

    Private Sub txtName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub
#End Region
End Class
