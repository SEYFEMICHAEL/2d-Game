Public Class AI
    Dim stage As New Scene
    Dim choice As Integer
    ' Dim a As New AIS
    Dim p As PictureBox

    Public Sub AI_Move(s As Integer)
        If s = 1 Then
            stage.Button1.PerformClick()
        ElseIf s = 2 Then
            stage.Button2.PerformClick()
        ElseIf s = 3 Then
            stage.Button3.PerformClick()

        End If

    End Sub
    Public Function AI_Choose()
        Dim r As Random = New Random()
        choice = r.Next(1, 4)
        AI_Move(choice)
        Return choice

    End Function

End Class
