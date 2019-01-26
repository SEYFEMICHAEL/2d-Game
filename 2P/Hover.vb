Public Class Hover
    Dim p As PictureBox

    Public Sub initial_P()
        Dim b = AI_Game.Scene
        Dim size = b.Controls.Count - 1


        For i As Integer = 0 To size
            p = b.Controls.Item(i)
            p.BackgroundImage = AI_Game.My.Resources.PO
            p.BackgroundImageLayout = ImageLayout.Stretch
        Next

    End Sub

    Public Sub selected_cup(sender As Object)
        Dim b = AI_Game.Scene
        Dim size = b.Controls.Count - 1

    End Sub

    Public Sub p1_possiblity()

    End Sub
    Public Sub p2_possiblity()

    End Sub
    Public Sub p3_possiblity()

    End Sub
    Public Sub p4_possiblity()

    End Sub
    Public Sub p5_possiblity()

    End Sub
    Public Sub p6_possiblity()

    End Sub
    Public Sub p7_possiblity()

    End Sub
    Public Sub p8_possiblity()

    End Sub
    Public Sub p9_possiblity()

    End Sub




End Class
