Public Class Form1
    Dim a As New AI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = a.AI_Choose()
    End Sub
End Class