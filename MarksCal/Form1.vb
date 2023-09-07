Public Class Form1
    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click


        Dim Score As Integer

        If IsNumeric(txtMarks.Text) = True Then
            Score = txtMarks.Text
        Else
            MsgBox("Not a Number")
            Exit Sub
        End If

        If Score < 0 Or Score > 100 Then
            MsgBox("Invalid Score")


        ElseIf Score < 50 Then
            MsgBox("Failed")


        ElseIf Score >= 50 And Score < 75 Then
            MsgBox("Pass")

        ElseIf Score >= 75 Then
            MsgBox("pass Distiction!")

        End If


    End Sub
End Class
