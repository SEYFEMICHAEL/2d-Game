Public Class Scene

    Public P1HaveMoved As Boolean = False
    Public P2HaveMoved As Boolean = False
    Public P2Cup = 0
    Public P1Cup = 0
    Public B_Score, R_Score
    Public P1_cup1_flag, P1_cup2_flag, P1_cup3_flag, P1_cup4_flag, P1_cup5_flag, P1_cup6_flag, P1_cup7_flag, P1_cup8_flag, P1_cup9_flag
    Public P2_cup1_flag, P2_cup2_flag, P2_cup3_flag, P2_cup4_flag, P2_cup5_flag, P2_cup6_flag, P2_cup7_flag, P2_cup8_flag, P2_cup9_flag

    Private Sub P2C2_Click(sender As Object, e As EventArgs) Handles P2C2.Click
        reset_cup()
        P2_cup2_flag = 1
        P2Cup = 2
        If P2HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P2C1_Click(sender As Object, e As EventArgs) Handles P2C1.Click
        reset_cup()
        P2_cup1_flag = 1
        P2Cup = 1
        If P2HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P2C4_Click(sender As Object, e As EventArgs) Handles P2C4.Click
        reset_cup()
        P2_cup4_flag = 1
        P2Cup = 4
        If P2HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P2C5_Click(sender As Object, e As EventArgs) Handles P2C5.Click
        reset_cup()
        P2_cup5_flag = 1
        P2Cup = 5
        If P2HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P2C6_Click(sender As Object, e As EventArgs) Handles P2C6.Click
        reset_cup()
        P2_cup6_flag = 1
        P2Cup = 6
        If P2HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P2C7_Click(sender As Object, e As EventArgs) Handles P2C7.Click
        reset_cup()
        P2_cup7_flag = 1

        P2Cup = 7
        If P2HaveMoved = False Then
            moveTo()
        End If

    End Sub

    Private Sub P2C8_Click(sender As Object, e As EventArgs) Handles P2C8.Click
        reset_cup()
        P2_cup8_flag = 1
        P2Cup = 8
        If P2HaveMoved = False Then
            moveTo()
        End If



    End Sub

    Private Sub P2C9_Click(sender As Object, e As EventArgs) Handles P2C9.Click
        reset_cup()
        P2_cup9_flag = 1
        P2Cup = 9
        If P2HaveMoved = False Then
            moveTo()
        End If

    End Sub

    Private Sub P2C3_Click(sender As Object, e As EventArgs) Handles P2C3.Click
        reset_cup()
        P2_cup3_flag = 1
        P2Cup = 3
        If P2HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P1C3_Click(sender As Object, e As EventArgs) Handles P1C3.Click
        Button3.PerformClick()
        reset_cup()
        P1_cup3_flag = 1
        P1Cup = 3
        If P1HaveMoved = False Then

            moveTo()
        End If


    End Sub

    Private Sub P5_Click(sender As Object, e As EventArgs) Handles P5.Click


        Select Case P2Cup
            Case 1
                P2C1.Visible = False
                P2C5.Visible = True
                P2C5.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 2
                P2C2.Visible = False
                P2C5.Visible = True
                P2C5.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 3
                P2C3.Visible = False
                P2C5.Visible = True
                P2C5.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 4
                P2C4.Visible = False
                P2C5.Visible = True
                P2C5.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 5
                P2C5.Visible = False
                P2C5.Visible = True
                P2C5.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()


            Case 6
                P2C6.Visible = False
                P2C5.Visible = True
                P2C5.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 7
                P2C7.Visible = False
                P2C5.Visible = True
                P2C5.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 8
                P2C8.Visible = False
                P2C5.Visible = True
                P2C5.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 9
                P2C9.Visible = False
                P2C5.Visible = True
                P2C5.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 0
                Exit Select
        End Select

            Select Case P1Cup
                Case 0
                Exit Select
            Case 1
                    P1C1.Visible = False
                    P1C5.Visible = True
                    P1C5.BringToFront()
                    reset_P()
                    P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()

            Case 2
                    P1C2.Visible = False
                    P1C5.Visible = True
                    P1C5.BringToFront()
                    reset_P()
                    P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 3
                    P1C3.Visible = False
                    P1C5.Visible = True
                    P1C5.BringToFront()
                    reset_P()
                    P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 4
                P1C4.Visible = False
                P1C5.Visible = True
                P1C5.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 5
                P1C5.Visible = False
                P1C5.Visible = True
                P1C5.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 6
                    P1C6.Visible = False
                    P1C5.Visible = True
                    P1C5.BringToFront()
                    reset_P()
                    P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 7
                    P1C7.Visible = False
                    P1C5.Visible = True
                    P1C5.BringToFront()
                    reset_P()
                    P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 8
                    P1C8.Visible = False
                    P1C5.Visible = True
                    P1C5.BringToFront()
                    reset_P()
                    P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 9
                    P1C9.Visible = False
                    P1C5.Visible = True
                    P1C5.BringToFront()
                    reset_P()
                    P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
        End Select




    End Sub

    Private Sub P6_Click(sender As Object, e As EventArgs) Handles P6.Click
        Select Case P1Cup
            Case 1
                P1C1.Visible = False
                P1C6.Visible = True
                P1C6.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 2
                P1C2.Visible = False
                P1C6.Visible = True
                P1C6.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 3
                P1C3.Visible = False
                P1C6.Visible = True
                P1C6.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 4
                P1C4.Visible = False
                P1C6.Visible = True
                P1C6.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 5
                P1C5.Visible = False
                P1C6.Visible = True
                P1C6.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 6
                P1C6.Visible = False
                P1C6.Visible = True
                P1C6.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 7
                P1C7.Visible = False
                P1C6.Visible = True
                P1C6.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 8
                P1C8.Visible = False
                P1C6.Visible = True
                P1C6.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 9
                P1C9.Visible = False
                P1C6.Visible = True
                P1C6.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
        End Select

        Select Case P2Cup
            Case 1
                P2C1.Visible = False
                P2C6.Visible = True
                P2C6.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 2
                P2C2.Visible = False
                P2C6.Visible = True
                P2C6.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 3
                P2C3.Visible = False
                P2C6.Visible = True
                P2C6.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 4
                P2C4.Visible = False
                P2C6.Visible = True
                P2C6.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 5
                P2C5.Visible = False
                P2C6.Visible = True
                P2C6.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 6
                P2C6.Visible = False
                P2C6.Visible = True
                P2C6.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 7
                P2C7.Visible = False
                P2C6.Visible = True
                P2C6.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 8
                P2C8.Visible = False
                P2C6.Visible = True
                P2C6.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 9
                P2C9.Visible = False
                P2C6.Visible = True
                P2C6.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
        End Select
    End Sub

    Private Sub P4_Click(sender As Object, e As EventArgs) Handles P4.Click
        Select Case P1Cup
            Case 1
                P1C1.Visible = False
                P1C4.Visible = True
                P1C4.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 2
                P1C2.Visible = False
                P1C4.Visible = True
                P1C4.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 3
                P1C3.Visible = False
                P1C4.Visible = True
                P1C4.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 4
                P1C4.Visible = False
                P1C4.Visible = True
                P1C4.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 5
                P1C5.Visible = False
                P1C4.Visible = True
                P1C4.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 6
                P1C6.Visible = False
                P1C4.Visible = True
                P1C4.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 7
                P1C7.Visible = False
                P1C4.Visible = True
                P1C4.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 8
                P1C8.Visible = False
                P1C4.Visible = True
                P1C4.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 9
                P1C9.Visible = False
                P1C4.Visible = True
                P1C4.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
        End Select

        Select Case P2Cup
            Case 1
                P2C1.Visible = False
                P2C4.Visible = True
                P2C4.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 2
                P2C2.Visible = False
                P2C4.Visible = True
                P2C4.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 3
                P2C3.Visible = False
                P2C4.Visible = True
                P2C4.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 4
                P2C4.Visible = False
                P2C4.Visible = True
                P2C4.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 5
                P2C5.Visible = False
                P2C4.Visible = True
                P2C4.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 6
                P2C6.Visible = False
                P2C4.Visible = True
                P2C4.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 7
                P2C7.Visible = False
                P2C4.Visible = True
                P2C4.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 8
                P2C8.Visible = False
                P2C4.Visible = True
                P2C4.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 9
                P2C9.Visible = False
                P2C4.Visible = True
                P2C4.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
        End Select
    End Sub

    Private Sub P1_Click_1(sender As Object, e As EventArgs) Handles P1.Click
        Select Case P1Cup
            Case 1
                P1C1.Visible = False
                P1C1.Visible = True
                P1C1.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 2
                P1C2.Visible = False
                P1C1.Visible = True
                P1C1.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 3
                P1C3.Visible = False
                P1C1.Visible = True
                P1C1.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 4
                P1C4.Visible = False
                P1C1.Visible = True
                P1C1.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 5
                P1C5.Visible = False
                P1C1.Visible = True
                P1C1.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 6
                P1C6.Visible = False
                P1C1.Visible = True
                P1C1.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 7
                P1C7.Visible = False
                P1C1.Visible = True
                P1C1.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 8
                P1C8.Visible = False
                P1C1.Visible = True
                P1C1.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 9
                P1C9.Visible = False
                P1C1.Visible = True
                P1C1.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
        End Select

        Select Case P2Cup
            Case 1
                P2C1.Visible = False
                P2C1.Visible = True
                P2C1.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 2
                P2C2.Visible = False
                P2C1.Visible = True
                P2C1.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 3
                P2C3.Visible = False
                P2C1.Visible = True
                P2C1.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 4
                P2C4.Visible = False
                P2C1.Visible = True
                P2C1.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 5
                P2C5.Visible = False
                P2C1.Visible = True
                P2C1.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 6
                P2C6.Visible = False
                P2C1.Visible = True
                P2C1.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 7
                P2C7.Visible = False
                P2C1.Visible = True
                P2C1.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 8
                P2C8.Visible = False
                P2C1.Visible = True
                P2C1.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 9
                P2C9.Visible = False
                P2C1.Visible = True
                P2C1.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
        End Select
    End Sub

    Private Sub P2_Click(sender As Object, e As EventArgs) Handles P2.Click
        Select Case P1Cup
            Case 1
                P1C1.Visible = False
                P1C2.Visible = True
                P1C2.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 2
                P1C2.Visible = False
                P1C2.Visible = True
                P1C2.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 3
                P1C3.Visible = False
                P1C2.Visible = True
                P1C2.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 4
                P1C4.Visible = False
                P1C2.Visible = True
                P1C2.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 5
                P1C5.Visible = False
                P1C2.Visible = True
                P1C2.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 6
                P1C6.Visible = False
                P1C2.Visible = True
                P1C2.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 7
                P1C7.Visible = False
                P1C2.Visible = True
                P1C2.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 8
                P1C8.Visible = False
                P1C2.Visible = True
                P1C2.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 9
                P1C9.Visible = False
                P1C2.Visible = True
                P1C2.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
        End Select

        Select Case P2Cup
            Case 1
                P2C1.Visible = False
                P2C2.Visible = True
                P2C2.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 2
                P2C2.Visible = False
                P2C2.Visible = True
                P2C2.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 3
                P2C3.Visible = False
                P2C2.Visible = True
                P2C2.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 4
                P2C4.Visible = False
                P2C2.Visible = True
                P2C2.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 5
                P2C5.Visible = False
                P2C2.Visible = True
                P2C2.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 6
                P2C6.Visible = False
                P2C2.Visible = True
                P2C2.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 7
                P2C7.Visible = False
                P2C2.Visible = True
                P2C2.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 8
                P2C8.Visible = False
                P2C2.Visible = True
                P2C2.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 9
                P2C9.Visible = False
                P2C2.Visible = True
                P2C2.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
        End Select
    End Sub

    Private Sub P3_Click(sender As Object, e As EventArgs) Handles P3.Click
        Select Case P1Cup
            Case 1
                P1C1.Visible = False
                P1C3.Visible = True
                P1C3.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 2
                P1C2.Visible = False
                P1C3.Visible = True
                P1C3.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 3
                P1C3.Visible = False
                P1C3.Visible = True
                P1C3.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 4
                P1C4.Visible = False
                P1C3.Visible = True
                P1C3.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 5
                P1C5.Visible = False
                P1C3.Visible = True
                P1C3.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 6
                P1C6.Visible = False
                P1C3.Visible = True
                P1C3.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 7
                P1C7.Visible = False
                P1C3.Visible = True
                P1C3.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 8
                P1C8.Visible = False
                P1C3.Visible = True
                P1C3.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 9
                P1C9.Visible = False
                P1C3.Visible = True
                P1C3.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
        End Select

        Select Case P2Cup
            Case 1
                P2C1.Visible = False
                P2C3.Visible = True
                P2C3.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 2
                P2C2.Visible = False
                P2C3.Visible = True
                P2C3.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 3
                P2C3.Visible = False
                P2C3.Visible = True
                P2C3.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 4
                P2C4.Visible = False
                P2C3.Visible = True
                P2C3.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 5
                P2C5.Visible = False
                P2C3.Visible = True
                P2C3.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 6
                P2C6.Visible = False
                P2C3.Visible = True
                P2C3.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 7
                P2C7.Visible = False
                P2C3.Visible = True
                P2C3.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 8
                P2C8.Visible = False
                P2C3.Visible = True
                P2C3.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 9
                P2C9.Visible = False
                P2C3.Visible = True
                P2C3.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
        End Select
    End Sub

    Private Sub P7_Click(sender As Object, e As EventArgs) Handles P7.Click
        Select Case P1Cup
            Case 1
                P1C1.Visible = False
                P1C7.Visible = True
                P1C7.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 2
                P1C2.Visible = False
                P1C7.Visible = True
                P1C7.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 3
                P1C3.Visible = False
                P1C7.Visible = True
                P1C7.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 4
                P1C4.Visible = False
                P1C7.Visible = True
                P1C7.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 5
                P1C5.Visible = False
                P1C7.Visible = True
                P1C7.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 6
                P1C6.Visible = False
                P1C7.Visible = True
                P1C7.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 7
                P1C7.Visible = False
                P1C7.Visible = True
                P1C7.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 8
                P1C8.Visible = False
                P1C7.Visible = True
                P1C7.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 9
                P1C9.Visible = False
                P1C7.Visible = True
                P1C7.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
        End Select

        Select Case P2Cup
            Case 1
                P2C1.Visible = False
                P2C7.Visible = True
                P2C7.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 2
                P2C2.Visible = False
                P2C7.Visible = True
                P2C7.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 3
                P2C3.Visible = False
                P2C7.Visible = True
                P2C7.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 4
                P2C4.Visible = False
                P2C7.Visible = True
                P2C7.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 5
                P2C5.Visible = False
                P2C7.Visible = True
                P2C7.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 6
                P2C6.Visible = False
                P2C7.Visible = True
                P2C7.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 7
                P2C7.Visible = False
                P2C7.Visible = True
                P2C7.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 8
                P2C8.Visible = False
                P2C7.Visible = True
                P2C7.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 9
                P2C9.Visible = False
                P2C7.Visible = True
                P2C7.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
        End Select
    End Sub

    Private Sub P8_Click(sender As Object, e As EventArgs) Handles P8.Click
        Select Case P1Cup
            Case 1
                P1C1.Visible = False
                P1C8.Visible = True
                P1C8.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 2
                P1C2.Visible = False
                P1C8.Visible = True
                P1C8.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 3
                P1C3.Visible = False
                P1C8.Visible = True
                P1C8.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 4
                P1C4.Visible = False
                P1C8.Visible = True
                P1C8.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 5
                P1C5.Visible = False
                P1C8.Visible = True
                P1C8.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 6
                P1C6.Visible = False
                P1C8.Visible = True
                P1C8.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 7
                P1C7.Visible = False
                P1C8.Visible = True
                P1C8.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 8
                P1C8.Visible = False
                P1C8.Visible = True
                P1C8.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 9
                P1C9.Visible = False
                P1C8.Visible = True
                P1C8.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
        End Select

        Select Case P2Cup
            Case 1
                P2C1.Visible = False
                P2C8.Visible = True
                P2C8.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 2
                P2C2.Visible = False
                P2C8.Visible = True
                P2C8.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 3
                P2C3.Visible = False
                P2C8.Visible = True
                P2C8.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 4
                P2C4.Visible = False
                P2C8.Visible = True
                P2C8.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 5
                P2C5.Visible = False
                P2C8.Visible = True
                P2C8.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 6
                P2C6.Visible = False
                P2C8.Visible = True
                P2C8.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 7
                P2C7.Visible = False
                P2C8.Visible = True
                P2C8.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()

            Case 8
                P2C8.Visible = False
                P2C8.Visible = True
                P2C8.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 9
                P2C9.Visible = False
                P2C8.Visible = True
                P2C8.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("state1 Movement Avaliable")
        AddHandler P1C1.Click, AddressOf P1C1_Click


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("state2 Movement Avaliable")
        AddHandler P1C2.Click, AddressOf P1C2_Click
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("state3 Movement Avaliable")
        AddHandler P1C3.Click, AddressOf P1C3_Click
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddHandler P1C4.Click, AddressOf P1C4_Click
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AddHandler P1C5.Click, AddressOf P1C5_Click
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AddHandler P1C6.Click, AddressOf P1C6_Click
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AddHandler P1C7.Click, AddressOf P1C7_Click
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AddHandler P1C8.Click, AddressOf P1C8_Click
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AddHandler P1C9.Click, AddressOf P1C9_Click
    End Sub

    Private Sub P9_Click(sender As Object, e As EventArgs) Handles P9.Click
        Select Case P1Cup
            Case 1
                P1C1.Visible = False
                P1C9.Visible = True
                P1C9.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 2
                P1C2.Visible = False
                P1C9.Visible = True
                P1C9.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 3
                P1C3.Visible = False
                P1C9.Visible = True
                P1C9.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 4
                P1C4.Visible = False
                P1C9.Visible = True
                P1C9.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 5
                P1C5.Visible = False
                P1C9.Visible = True
                P1C9.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 6
                P1C6.Visible = False
                P1C9.Visible = True
                P1C9.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 7
                P1C7.Visible = False
                P1C9.Visible = True
                P1C9.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 8
                P1C8.Visible = False
                P1C9.Visible = True
                P1C9.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
            Case 9
                P1C9.Visible = False
                P1C9.Visible = True
                P1C9.BringToFront()
                reset_P()
                P1HaveMoved = True
                P2HaveMoved = False
                HaveWon()
        End Select

        Select Case P2Cup
            Case 1
                P2C1.Visible = False
                P2C9.Visible = True
                P2C9.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 2
                P2C2.Visible = False
                P2C9.Visible = True
                P2C9.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 3
                P2C3.Visible = False
                P2C9.Visible = True
                P2C9.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 4
                P2C4.Visible = False
                P2C9.Visible = True
                P2C9.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 5
                P2C5.Visible = False
                P2C9.Visible = True
                P2C9.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 6
                P2C6.Visible = False
                P2C9.Visible = True
                P2C9.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 7
                P2C7.Visible = False
                P2C9.Visible = True
                P2C9.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 8
                P2C8.Visible = False
                P2C9.Visible = True
                P2C9.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
            Case 9
                P2C9.Visible = False
                P2C9.Visible = True
                P2C9.BringToFront()
                reset_P()
                P1HaveMoved = False
                P2HaveMoved = True
                HaveWon()
        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub P1C4_Click(sender As Object, e As EventArgs) Handles P1C4.Click
        reset_cup()
        P1_cup4_flag = 1
        P1Cup = 4
        If P1HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P1C5_Click(sender As Object, e As EventArgs) Handles P1C5.Click
        reset_cup()
        P1_cup5_flag = 1
        P1Cup = 5
        If P1HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P1C6_Click(sender As Object, e As EventArgs) Handles P1C6.Click
        reset_cup()
        P1_cup6_flag = 1
        P1Cup = 6
        If P1HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P1C7_Click(sender As Object, e As EventArgs) Handles P1C7.Click
        reset_cup()
        P1_cup7_flag = 1
        P1Cup = 7
        If P1HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P1C8_Click(sender As Object, e As EventArgs) Handles P1C8.Click
        reset_cup()
        P1_cup8_flag = 1
        P1Cup = 8
        If P1HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P1C9_Click(sender As Object, e As EventArgs) Handles P1C9.Click
        reset_cup()
        P1_cup9_flag = 1
        P1Cup = 9
        If P1HaveMoved = False Then
            moveTo()
        End If
    End Sub

    Private Sub P1C2_Click(sender As Object, e As EventArgs) Handles P1C2.Click
        Button2.PerformClick()
        reset_cup()
        P1_cup2_flag = 1
        P1Cup = 2
        If P1HaveMoved = False Then

            moveTo()
        End If
    End Sub
    Public Sub myai()
        MsgBox("Movement Avaliable")

    End Sub

    Private Sub P1C1_Click(sender As Object, e As EventArgs) Handles P1C1.Click
        Button1.PerformClick()
        reset_cup()
        P1_cup1_flag = 1
        P1Cup = 1
        If P1HaveMoved = False Then

            moveTo()
        End If


    End Sub

    Public p1_flag, p2_flag, p3_flag, p4_flag, p5_flag, p6_flag, p7_flag, p8_flag, p9_flag
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowTransparency = True
        Me.TransparencyKey = Color.SaddleBrown
        B_Score = 0
        R_Score = 0
        startgame()



    End Sub


    Private Sub reset_P()
        P1.Visible = False
        P2.Visible = False
        P3.Visible = False
        P4.Visible = False
        P5.Visible = False
        P6.Visible = False
        P7.Visible = False
        P8.Visible = False
        P9.Visible = False
    End Sub






    Private Sub reset_cup()
        P1Cup = 0
        P2Cup = 0


        P1_cup1_flag = 0
        P1_cup2_flag = 0
        P1_cup3_flag = 0
        P1_cup4_flag = 0
        P1_cup5_flag = 0
        P1_cup6_flag = 0
        P1_cup7_flag = 0
        P1_cup8_flag = 0
        P1_cup9_flag = 0

        P2_cup1_flag = 0
        P2_cup2_flag = 0
        P2_cup3_flag = 0
        P2_cup4_flag = 0
        P2_cup5_flag = 0
        P2_cup6_flag = 0
        P2_cup7_flag = 0
        P2_cup8_flag = 0
        P2_cup9_flag = 0


    End Sub
    Public Sub startgame()

        reset_cup()
        reset_P()
        P1C1.Visible = True
        P1C1.BringToFront()
        P1C2.Visible = True
        P1C2.BringToFront()
        P1C3.Visible = True
        P1C3.BringToFront()

        P2C7.Visible = True
        P2C7.BringToFront()
        P2C8.Visible = True
        P2C8.BringToFront()
        P2C9.Visible = True
        P2C9.BringToFront()

        P1C4.Visible = False
        P1C5.Visible = False
        P1C6.Visible = False
        P1C7.Visible = False
        P1C8.Visible = False
        P1C9.Visible = False
        P2C1.Visible = False
        P2C2.Visible = False
        P2C3.Visible = False
        P2C4.Visible = False
        P2C5.Visible = False
        P2C6.Visible = False


    End Sub
    Private Sub moveTo()
        '  If P1HaveMoved Then

        Select Case P2Cup
            Case 1
                P1.Visible = False
                P7.Visible = False
                P3.Visible = False
                P9.Visible = False
                P6.Visible = False
                P8.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P4.BackgroundImage = AI_Game.My.Resources.POINTER
                P4.BackgroundImageLayout = ImageLayout.Stretch
                P4.Visible = True
                P2.BackgroundImage = AI_Game.My.Resources.POINTER
                P2.BackgroundImageLayout = ImageLayout.Stretch
                P2.Visible = True
            Case 2
                P9.Visible = False
                P2.Visible = False
                P7.Visible = False
                P4.Visible = False
                P6.Visible = False
                P8.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P1.BackgroundImage = AI_Game.My.Resources.POINTER
                P1.BackgroundImageLayout = ImageLayout.Stretch
                P1.Visible = True
                P3.BackgroundImage = AI_Game.My.Resources.POINTER
                P3.BackgroundImageLayout = ImageLayout.Stretch
                P3.Visible = True
            Case 3
                P1.Visible = False
                P7.Visible = False
                P3.Visible = False
                P4.Visible = False
                P9.Visible = False
                P8.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P2.BackgroundImage = AI_Game.My.Resources.POINTER
                P2.BackgroundImageLayout = ImageLayout.Stretch
                P2.Visible = True
                P6.BackgroundImage = AI_Game.My.Resources.POINTER
                P6.BackgroundImageLayout = ImageLayout.Stretch
                P6.Visible = True
            Case 4
                P9.Visible = False
                P2.Visible = False
                P3.Visible = False
                P4.Visible = False
                P6.Visible = False
                P8.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P7.BackgroundImage = AI_Game.My.Resources.POINTER
                P7.BackgroundImageLayout = ImageLayout.Stretch
                P7.Visible = True
                P1.BackgroundImage = AI_Game.My.Resources.POINTER
                P1.BackgroundImageLayout = ImageLayout.Stretch
                P1.Visible = True
            Case 5
                P1.BackgroundImage = AI_Game.My.Resources.POINTER
                P1.BackgroundImageLayout = ImageLayout.Stretch
                P1.Visible = True
                P2.BackgroundImage = AI_Game.My.Resources.POINTER
                P2.BackgroundImageLayout = ImageLayout.Stretch
                P2.Visible = True
                P3.BackgroundImage = AI_Game.My.Resources.POINTER
                P3.BackgroundImageLayout = ImageLayout.Stretch
                P3.Visible = True
                P4.BackgroundImage = AI_Game.My.Resources.POINTER
                P4.BackgroundImageLayout = ImageLayout.Stretch
                P4.Visible = True
                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P6.BackgroundImage = AI_Game.My.Resources.POINTER
                P6.BackgroundImageLayout = ImageLayout.Stretch
                P6.Visible = True
                P7.BackgroundImage = AI_Game.My.Resources.POINTER
                P7.BackgroundImageLayout = ImageLayout.Stretch
                P7.Visible = True
                P8.BackgroundImage = AI_Game.My.Resources.POINTER
                P8.BackgroundImageLayout = ImageLayout.Stretch
                P8.Visible = True
                P9.BackgroundImage = AI_Game.My.Resources.POINTER
                P9.BackgroundImageLayout = ImageLayout.Stretch
                P9.Visible = True
            Case 6
                P1.Visible = False
                P2.Visible = False
                P7.Visible = False
                P4.Visible = False
                P6.Visible = False
                P8.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P3.BackgroundImage = AI_Game.My.Resources.POINTER
                P3.BackgroundImageLayout = ImageLayout.Stretch
                P3.Visible = True
                P9.BackgroundImage = AI_Game.My.Resources.POINTER
                P9.BackgroundImageLayout = ImageLayout.Stretch
                P9.Visible = True
            Case 7
                P1.Visible = False
                P2.Visible = False
                P3.Visible = False
                P9.Visible = False
                P6.Visible = False
                P7.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P4.BackgroundImage = AI_Game.My.Resources.POINTER
                P4.BackgroundImageLayout = ImageLayout.Stretch
                P4.Visible = True
                P8.BackgroundImage = AI_Game.My.Resources.POINTER
                P8.BackgroundImageLayout = ImageLayout.Stretch
                P8.Visible = True
            Case 8
                P1.Visible = False
                P2.Visible = False
                P3.Visible = False
                P4.Visible = False
                P6.Visible = False
                P8.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P7.BackgroundImage = AI_Game.My.Resources.POINTER
                P7.BackgroundImageLayout = ImageLayout.Stretch
                P7.Visible = True
                P9.BackgroundImage = AI_Game.My.Resources.POINTER
                P9.BackgroundImageLayout = ImageLayout.Stretch
                P9.Visible = True
            Case 9
                P1.Visible = False
                P2.Visible = False
                P3.Visible = False
                P4.Visible = False
                P5.Visible = True
                P6.Visible = True
                P7.Visible = False
                P8.Visible = True
                P9.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P6.BackgroundImage = AI_Game.My.Resources.POINTER
                P6.BackgroundImageLayout = ImageLayout.Stretch
                P8.BackgroundImage = AI_Game.My.Resources.POINTER
                P8.BackgroundImageLayout = ImageLayout.Stretch



        End Select
        '    P1HaveMoved = False
        'P2HaveMoved = True
        'ElseIf P2HaveMoved Then
        Select Case P1Cup
            Case 1
                P1.Visible = False
                P3.Visible = False
                P6.Visible = False
                P7.Visible = False
                P8.Visible = False
                P9.Visible = False

                P2.BackgroundImage = AI_Game.My.Resources.POINTER
                P2.BackgroundImageLayout = ImageLayout.Stretch
                P2.Visible = True
                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P4.BackgroundImage = AI_Game.My.Resources.POINTER
                P4.BackgroundImageLayout = ImageLayout.Stretch
                P4.Visible = True
            Case 2
                P2.Visible = False
                P4.Visible = False
                P6.Visible = False
                P7.Visible = False
                P8.Visible = False
                P9.Visible = False

                P1.BackgroundImage = AI_Game.My.Resources.POINTER
                P1.BackgroundImageLayout = ImageLayout.Stretch
                P1.Visible = True
                P3.BackgroundImage = AI_Game.My.Resources.POINTER
                P3.BackgroundImageLayout = ImageLayout.Stretch
                P3.Visible = True
                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
            Case 3
                P1.Visible = False
                P3.Visible = False
                P4.Visible = False
                P7.Visible = False
                P8.Visible = False
                P9.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P6.BackgroundImage = AI_Game.My.Resources.POINTER
                P6.BackgroundImageLayout = ImageLayout.Stretch
                P6.Visible = True
                P2.BackgroundImage = AI_Game.My.Resources.POINTER
                P2.BackgroundImageLayout = ImageLayout.Stretch
                P2.Visible = True
            Case 4
                P9.Visible = False
                P2.Visible = False
                P3.Visible = False
                P4.Visible = False
                P6.Visible = False
                P8.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P7.BackgroundImage = AI_Game.My.Resources.POINTER
                P7.BackgroundImageLayout = ImageLayout.Stretch
                P7.Visible = True
                P1.BackgroundImage = AI_Game.My.Resources.POINTER
                P1.BackgroundImageLayout = ImageLayout.Stretch
                P1.Visible = True
            Case 5
                P1.BackgroundImage = AI_Game.My.Resources.POINTER
                P1.BackgroundImageLayout = ImageLayout.Stretch
                P1.Visible = True
                P2.BackgroundImage = AI_Game.My.Resources.POINTER
                P2.BackgroundImageLayout = ImageLayout.Stretch
                P2.Visible = True
                P3.BackgroundImage = AI_Game.My.Resources.POINTER
                P3.BackgroundImageLayout = ImageLayout.Stretch
                P3.Visible = True
                P4.BackgroundImage = AI_Game.My.Resources.POINTER
                P4.BackgroundImageLayout = ImageLayout.Stretch
                P4.Visible = True
                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P6.BackgroundImage = AI_Game.My.Resources.POINTER
                P6.BackgroundImageLayout = ImageLayout.Stretch
                P6.Visible = True
                P7.BackgroundImage = AI_Game.My.Resources.POINTER
                P7.BackgroundImageLayout = ImageLayout.Stretch
                P7.Visible = True
                P8.BackgroundImage = AI_Game.My.Resources.POINTER
                P8.BackgroundImageLayout = ImageLayout.Stretch
                P8.Visible = True
                P9.BackgroundImage = AI_Game.My.Resources.POINTER
                P9.BackgroundImageLayout = ImageLayout.Stretch
                P9.Visible = True
            Case 6
                P1.Visible = False
                P2.Visible = False
                P7.Visible = False
                P4.Visible = False
                P6.Visible = False
                P8.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P3.BackgroundImage = AI_Game.My.Resources.POINTER
                P3.BackgroundImageLayout = ImageLayout.Stretch
                P3.Visible = True
                P9.BackgroundImage = AI_Game.My.Resources.POINTER
                P9.BackgroundImageLayout = ImageLayout.Stretch
                P9.Visible = True
            Case 7
                P1.Visible = False
                P2.Visible = False
                P3.Visible = False
                P9.Visible = False
                P6.Visible = False
                P7.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P4.BackgroundImage = AI_Game.My.Resources.POINTER
                P4.BackgroundImageLayout = ImageLayout.Stretch
                P4.Visible = True
                P8.BackgroundImage = AI_Game.My.Resources.POINTER
                P8.BackgroundImageLayout = ImageLayout.Stretch
                P8.Visible = True
            Case 8
                P1.Visible = False
                P2.Visible = False
                P3.Visible = False
                P4.Visible = False
                P6.Visible = False
                P8.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P5.Visible = True
                P7.BackgroundImage = AI_Game.My.Resources.POINTER
                P7.BackgroundImageLayout = ImageLayout.Stretch
                P7.Visible = True
                P9.BackgroundImage = AI_Game.My.Resources.POINTER
                P9.BackgroundImageLayout = ImageLayout.Stretch
                P9.Visible = True
            Case 9
                P1.Visible = False
                P2.Visible = False
                P3.Visible = False
                P4.Visible = False
                P5.Visible = True
                P6.Visible = True
                P7.Visible = False
                P8.Visible = True
                P9.Visible = False

                P5.BackgroundImage = AI_Game.My.Resources.POINTER
                P5.BackgroundImageLayout = ImageLayout.Stretch
                P6.BackgroundImage = AI_Game.My.Resources.POINTER
                P6.BackgroundImageLayout = ImageLayout.Stretch
                P8.BackgroundImage = AI_Game.My.Resources.POINTER
                P8.BackgroundImageLayout = ImageLayout.Stretch



        End Select
        '    P1HaveMoved = True
        'P2HaveMoved = False


        'End If



    End Sub
    Private Sub HaveWon()
        If P1HaveMoved Then
            'Player 1 winning Probablity

            If P1C7.Visible And P1C8.Visible And P1C9.Visible Then
                MsgBox("Blue Wins!")
                B_Score += 1
                Score.BlueScoreLbl.Text = B_Score
                startgame()
            ElseIf P1C1.Visible And P1C5.Visible And P1C9.Visible Then
                MsgBox("Blue Wins!")
                B_Score += 1
                Score.BlueScoreLbl.Text = B_Score
                startgame()
            ElseIf P1C4.Visible And P1C5.Visible And P1C6.Visible Then
                MsgBox("Blue Wins!")
                B_Score += 1
                Score.BlueScoreLbl.Text = B_Score
                startgame()
            ElseIf P1C7.Visible And P1C5.Visible And P1C3.Visible Then
                MsgBox("Blue Wins!")
                B_Score += 1
                Score.BlueScoreLbl.Text = B_Score
                startgame()
            ElseIf P1C2.Visible And P1C5.Visible And P1C8.Visible Then
                MsgBox("Blue Wins!")
                B_Score += 1
                Score.BlueScoreLbl.Text = B_Score
                startgame()
            ElseIf P1C1.Visible And P1C4.Visible And P1C7.Visible Then
                MsgBox("Blue Wins!")
                B_Score += 1
                Score.BlueScoreLbl.Text = B_Score
                startgame()
            ElseIf P1C3.Visible And P1C6.Visible And P1C9.Visible Then
                MsgBox("Blue Wins!")
                B_Score += 1
                Score.BlueScoreLbl.Text = B_Score
                startgame()
            End If
        Else
            'Player 2 Winning Probablity

            If P2C1.Visible And P2C5.Visible And P2C9.Visible Then
                MsgBox("Red Wins!")
                R_Score += 1
                Score.RedScoreLbl.Text = R_Score
                startgame()
            ElseIf P2C1.Visible And P2C2.Visible And P2C3.Visible Then
                MsgBox("Red Wins!")
                R_Score += 1
                Score.RedScoreLbl.Text = R_Score
                startgame()
            ElseIf P2C4.Visible And P2C5.Visible And P2C6.Visible Then
                MsgBox("Red Wins!")
                R_Score += 1
                Score.RedScoreLbl.Text = R_Score
                startgame()
            ElseIf P2C7.Visible And P2C5.Visible And P2C3.Visible Then
                MsgBox("Red Wins!")
                R_Score += 1
                Score.RedScoreLbl.Text = R_Score
                startgame()
            ElseIf P2C2.Visible And P2C5.Visible And P2C8.Visible Then
                MsgBox("Red Wins!")
                R_Score += 1
                Score.RedScoreLbl.Text = R_Score
                startgame()
            ElseIf P2C1.Visible And P2C4.Visible And P2C7.Visible Then
                MsgBox("Red Wins!")
                R_Score += 1
                Score.RedScoreLbl.Text = R_Score
                startgame()
            ElseIf P2C3.Visible And P2C6.Visible And P2C9.Visible Then
                MsgBox("Red Wins!")
                R_Score += 1
                Score.RedScoreLbl.Text = R_Score
                startgame()
            End If

        End If




    End Sub
End Class
