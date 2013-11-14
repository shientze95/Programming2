Public Class frmMain
    Dim UName, UMail, Uno As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim First, Last, Full, No, FormatVal As String
        
        If txtFirst.Text.Trim() = vbNullString OrElse txtLast.Text.Trim() = vbNullString OrElse txtNo.Text.Trim() = vbNullString Then
            MsgBox("Please fill in all the fields!")
            Exit Sub
        Else
            First = txtFirst.Text.Trim().Replace(" ", "")
            Last = txtLast.Text.Trim().Replace(" ", "")
            Full = First & " " & Last.Trim().Replace(" ", "")
            No = "082-" & txtNo.Text
            FormatVal = Full & vbTab & No
            If CheckExists(First, Last) = True Then
                MsgBox("Already in list!")
                ClearItems()
                Exit Sub
            End If
        End If
        lbNames.Items.Add(Full & vbTab & No)
        ClearItems()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim FindQuery As String
        FindQuery = InputBox("Please input the name of the person to find:")
        If CheckExists(FindQuery, vbNullString, True) = True Then
            Dim CountList As New List(Of Integer)
            Dim CountString As New List(Of String)
            Call TestMultiple(FindQuery, CountString, CountList)
            MsgBox(CountList.Count & " matches found!")
            For Each DisplayString As String In CountString
                MsgBox(DisplayString)
            Next
        Else
            MsgBox("No match found.")
        End If

    End Sub

    Private Function CheckExists(ByVal NameQuery As String, Optional ByVal NameQuery2 As String = vbNullString, Optional ByVal Complex As Boolean = False)
        Dim ValueExists As Boolean = False
        Dim Query As String
        Dim QueryList, LQuery As String()
        Select Case Complex
            Case True
                For LoopCount As Integer = 0 To (lbNames.Items.Count - 1)
                    Query = lbNames.Items(LoopCount)
                    LQuery = Query.Split()
                    Query = Query.ToLower()
                    QueryList = Query.Split()
                    If QueryList(0).Contains(NameQuery.ToLower()) OrElse QueryList(1).Contains(NameQuery.ToLower()) Then
                        ValueExists = True
                        UName = LQuery(0) & " " & LQuery(1)
                        UMail = UName.ToLower().Trim().Replace(" ", "") & "@gmail.com"
                        Uno = LQuery(2)
                        Exit For
                    Else
                        ValueExists = False
                    End If
                Next
            Case False
                For LoopCount As Integer = 0 To (lbNames.Items.Count - 1)
                    Query = lbNames.Items(LoopCount)
                    Query = Query.ToLower()
                    QueryList = Query.Split()
                    If QueryList(0) = NameQuery.ToLower() AndAlso QueryList(1) = NameQuery2.ToLower() Then
                        ValueExists = True
                        Exit For
                    Else
                        ValueExists = False
                    End If
                Next
        End Select
        Return ValueExists
    End Function

    Private Sub ClearItems()
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next
        txtFirst.Focus()
    End Sub

    Private Sub TestMultiple(ByVal FindQuery As String, ByRef MatchedString As List(Of String), ByRef MatchedCount As List(Of Integer))
        Dim Query, FullString As String
        Dim QueryList, LQuery As String()
        For LoopCount As Integer = 0 To (lbNames.Items.Count - 1)
            Query = lbNames.Items(LoopCount)
            LQuery = Query.Split()
            Query = Query.ToLower()
            QueryList = Query.Split()
            If QueryList(0).Contains(FindQuery.ToLower()) OrElse QueryList(1).Contains(FindQuery.ToLower()) Then
                MatchedCount.Add(LoopCount)
            End If
        Next
        
        For Each LoopCount As Integer In MatchedCount
            Query = lbNames.Items(LoopCount)
            LQuery = Query.Split()
            Query = Query.ToLower()
            QueryList = Query.Split()
            UName = LQuery(0) & " " & LQuery(1)
            UMail = UName.ToLower().Trim().Replace(" ", "") & "@gmail.com"
            Uno = LQuery(2)
            FullString = UName & vbNewLine & Uno & vbNewLine & UMail
            MatchedString.Add(FullString)
        Next
    End Sub
End Class
