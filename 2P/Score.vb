Public Class Score
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.AllowTransparency = True
        Me.TransparencyKey = Color.DimGray

    End Sub

    Private Sub LinkLabel_reset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Scene.Show()
        Scene.B_Score = 0
        Scene.R_Score = 0
        BlueScoreLbl.Text = 0
        RedScoreLbl.Text = 0
        Scene.startgame()
    End Sub
End Class