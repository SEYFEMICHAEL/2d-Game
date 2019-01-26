Public Class Menu

    Dim startH As Hover = New Hover

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'startH.initial_P()
        Scene.Show()
        Score.Show()
        Me.Hide()






    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        'Me.BackColor = Color.Transparent
        'Me.TransparencyKey = Color.White
        Me.TransparencyKey = Color.Green
    End Sub
End Class