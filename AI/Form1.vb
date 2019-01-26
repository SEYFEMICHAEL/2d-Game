Imports AI_Simulation.My
Imports System
Imports Microsoft.VisualBasic.Devices
Imports WMPLib
Public Class Form1
    Dim visiblecup As New List(Of Integer)
    Dim AI, P As Boolean
    Dim AIS, PS
    Dim ps1, ps2, ps3, ps4, ps5, ps6, ps7, ps8, ps9
    Dim as1, as2, as3, as4, as5, as6, as7, as8, as9

    Private Sub AIC1_Click(sender As Object, e As EventArgs) Handles AIC1.Click
        reset_state()
        as1 = 1
        AIS = 1
        move_to()
    End Sub

    Private Sub P2_Click(sender As Object, e As EventArgs) Handles P2.Click

        transit()
        hide_pointer()
        reset_state()
        AIC2.Visible = True
        AIC2.BringToFront()
        visiblecup.Add(2)
    End Sub

    Private Sub P3_Click(sender As Object, e As EventArgs) Handles P3.Click
        transit()
        hide_pointer()
        reset_state()
        AIC3.Visible = True
        AIC3.BringToFront()
        visiblecup.Add(3)
    End Sub

    Private Sub P4_Click(sender As Object, e As EventArgs) Handles P4.Click
        transit()
        hide_pointer()
        reset_state()
        visiblecup.Add(4)
        AIC4.Visible = True
        AIC4.BringToFront()

    End Sub
    Private Sub transit()
        If as1 = 1 Then
            AIC1.Visible = False
            Dim i = visiblecup.IndexOf(1)
            visiblecup.Remove(1)

        ElseIf as2 = 1 Then
            AIC2.Visible = False
            Dim i = visiblecup.IndexOf(2)
            visiblecup.Remove(2)
        ElseIf as3 = 1 Then
            AIC3.Visible = False
            Dim i = visiblecup.IndexOf(3)
            visiblecup.Remove(3)
        ElseIf as4 = 1 Then
            AIC4.Visible = False
            Dim i = visiblecup.IndexOf(4)
            visiblecup.Remove(4)
        ElseIf as5 = 1 Then
            AIC5.Visible = False
            Dim i = visiblecup.IndexOf(5)
            visiblecup.Remove(5)
        ElseIf as6 = 1 Then
            AIC6.Visible = False
            Dim i = visiblecup.IndexOf(6)
            visiblecup.Remove(6)
        ElseIf as7 = 1 Then
            AIC7.Visible = False
            Dim i = visiblecup.IndexOf(7)
            visiblecup.Remove(7)
        ElseIf as8 = 1 Then
            AIC8.Visible = False
            Dim i = visiblecup.IndexOf(8)
            visiblecup.Remove(8)
        ElseIf as9 = 1 Then
            AIC9.Visible = False
            Dim i = visiblecup.IndexOf(9)
            visiblecup.Remove(9)
        End If
    End Sub

    Private Sub P5_Click(sender As Object, e As EventArgs) Handles P5.Click
        transit()
        hide_pointer()
        reset_state()
        AIC5.Visible = True
        AIC5.BringToFront()
        visiblecup.Add(5)
    End Sub

    Private Sub P6_Click(sender As Object, e As EventArgs) Handles P6.Click
        transit()
        hide_pointer()
        reset_state()
        AIC6.Visible = True
        AIC6.BringToFront()
        visiblecup.Add(6)
    End Sub

    Private Sub P7_Click(sender As Object, e As EventArgs) Handles P7.Click
        transit()
        hide_pointer()
        reset_state()
        AIC7.Visible = True
        AIC7.BringToFront()
        visiblecup.Add(7)
    End Sub

    Private Sub P8_Click(sender As Object, e As EventArgs) Handles P8.Click
        transit()
        hide_pointer()
        reset_state()
        AIC8.Visible = True
        AIC8.BringToFront()
        visiblecup.Add(8)
    End Sub

    Private Sub P9_Click(sender As Object, e As EventArgs) Handles P9.Click
        transit()
        hide_pointer()
        reset_state()
        AIC9.Visible = True
        AIC9.BringToFront()
        visiblecup.Add(9)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Do
        AI_Play()
        Dim mystr
        TextBox1.Text = Nothing
        TextBox1.AppendText("[ ")
        For i = 0 To visiblecup.Count - 1
            mystr = visiblecup.Item(i)
            TextBox1.AppendText(mystr)

            If i < 2 Then
                TextBox1.AppendText(" , ")
            End If

        Next
        TextBox1.AppendText(" ]")
        '    If visiblecup.Contains(1) And visiblecup.Contains(4) And visiblecup.Contains(7) Then
        '        Exit Do
        '    ElseIf visiblecup.Contains(2) And visiblecup.Contains(5) And visiblecup.Contains(8) Then
        '        Exit Do
        '    ElseIf visiblecup.Contains(3) And visiblecup.Contains(6) And visiblecup.Contains(9) Then
        '        Exit Do
        '    ElseIf visiblecup.Contains(4) And visiblecup.Contains(5) And visiblecup.Contains(6) Then
        '        Exit Do
        '    ElseIf visiblecup.Contains(7) And visiblecup.Contains(8) And visiblecup.Contains(9) Then
        '        Exit Do
        '    ElseIf visiblecup.Contains(3) And visiblecup.Contains(5) And visiblecup.Contains(7) Then
        '        Exit Do
        '    ElseIf visiblecup.Contains(1) And visiblecup.Contains(5) And visiblecup.Contains(9) Then
        '        Exit Do
        '    End If
        '    MsgBox(":):")
        'Loop


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visiblecup.Add(1)
        visiblecup.Add(2)
        visiblecup.Add(3)
        start()
        'Dim uri = My.Resources.BackMusic
        'Dim Player As WindowsMediaPlayer
        'Player.URL("../Resources/")
        'Player.controls.play()
        My.Computer.Audio.Play("C:\Users\KMTM\Documents\Visual Studio 2015\Projects\AI_Simulation\AI_Simulation\Resources\Recording.wav")
        Dim pm As New AudioPlayMode

    End Sub
    Private Sub AI_Play()
        Dim cup = Initiate_AI()
        Select Case cup
            Case 1
                AIC1.PerformClick()
            Case 2
                AIC2.PerformClick()
            Case 3
                AIC3.PerformClick()
            Case 4
                AIC4.PerformClick()
            Case 5
                AIC5.PerformClick()
            Case 6
                AIC6.PerformClick()
            Case 7
                AIC7.PerformClick()
            Case 8
                AIC8.PerformClick()
            Case 9
                AIC9.PerformClick()
        End Select
    End Sub
    Private Function Initiate_AI()
        'Dim r As New Random
        'Dim choice = r.Next(1, 4)
        'Return choice
        Dim state() = {0, 0, 0}
        For i = 0 To 2
            state(i) = visiblecup.Item(i)
        Next

        Dim r As New Random
ran:
        Dim choice = r.Next(0, 3)
        Select Case state(choice)
            Case 1
                If AIC1.Visible = False Then
                    GoTo ran
                End If
            Case 2
                If AIC2.Visible = False Then
                    GoTo ran
                End If
            Case 3
                If AIC3.Visible = False Then
                    GoTo ran
                End If
            Case 4
                If AIC4.Visible = False Then
                    GoTo ran
                End If
            Case 5
                If AIC5.Visible = False Then
                    GoTo ran
                End If
            Case 6
                If AIC6.Visible = False Then
                    GoTo ran
                End If
            Case 7
                If AIC7.Visible = False Then
                    GoTo ran
                End If
            Case 8
                If AIC8.Visible = False Then
                    GoTo ran
                End If
            Case 9
                If AIC9.Visible = False Then
                    GoTo ran
                End If
        End Select

        Return state(choice)

    End Function

    Private Function Initiate_AIC1()
        '[2,4,5]
        Dim state() = {2, 4, 5}
        Dim r As New Random
        Dim c = r.Next(0, 3)
        Return state(c)
    End Function
    Private Function Initiate_AIC2()
        '[1,3,5]
        Dim state() = {1, 3, 5}
        Dim r As New Random
        Dim c = r.Next(0, 3)
        Return state(c)
    End Function
    Private Function Initiate_AIC3()
        '[2,5,6]
        Dim state() = {2, 5, 6}
        Dim r As New Random
        Dim c = r.Next(0, 3)
        Return state(c)
    End Function
    Private Function Initiate_AIC4()
        '[1,5,7]

        'Dim r As New 
        Dim state() = {1, 5, 7}
        Dim r As New Random
        Dim c = r.Next(0, 3)
        Return state(c)
    End Function
    Private Function Initiate_AIC5()
        '[1,2,3,4,6,7,8,9]

        'Dim r As New 
        Dim state() = {1, 2, 3, 4, 6, 7, 8, 9}
        Dim r As New Random
        Dim c = r.Next(0, 8)
        Return state(c)
    End Function
    Private Function Initiate_AIC6()
        '[3,5,9]

        'Dim r As New 
        Dim state() = {3, 5, 9}
        Dim r As New Random
        Dim c = r.Next(0, 3)
        Return state(c)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub

    Private Function Initiate_AIC7()
        '[4,5,8]

        'Dim r As New 
        Dim state() = {4, 5, 8}
        Dim r As New Random
        Dim c = r.Next(0, 3)
        Return state(c)
    End Function
    Private Function Initiate_AIC8()
        '[7,5,9]

        'Dim r As New 
        Dim state() = {7, 5, 9}
        Dim r As New Random
        Dim c = r.Next(0, 3)
        Return state(c)
    End Function
    Private Function Initiate_AIC9()
        '[6,5,8]

        'Dim r As New 
        Dim state() = {6, 5, 8}
        Dim r As New Random
        Dim c = r.Next(0, 3)
        Return state(c)
    End Function
    Private Sub start()
        AIS = 0
        PS = 0
        P = True
        AI = False
        reset_state()
        as1 = 1
        as2 = 1
        as3 = 1

        ps7 = 1
        ps8 = 1
        ps9 = 1
        hide_pointer()
        hide_cup()
        AIC1.Visible = True
        AIC2.Visible = True
        AIC3.Visible = True
    End Sub
    Private Sub reset_state()
        as1 = 0
        as2 = 0
        as3 = 0
        as4 = 0
        as5 = 0
        as6 = 0
        as7 = 0
        as8 = 0
        as9 = 0

        ps1 = 0
        ps2 = 0
        ps3 = 0
        ps4 = 0
        ps5 = 0
        ps6 = 0
        ps7 = 0
        ps8 = 0
        ps9 = 0
    End Sub
    Private Sub hide_pointer()
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
    Private Sub hide_cup()

        AIC1.Visible = False
        AIC2.Visible = False
        AIC3.Visible = False
        AIC4.Visible = False
        AIC5.Visible = False
        AIC6.Visible = False
        AIC7.Visible = False
        AIC8.Visible = False
        AIC9.Visible = False

    End Sub

    Private Sub P1_Click(sender As Object, e As EventArgs) Handles P1.Click
        transit()
        hide_pointer()
        reset_state()
        AIC1.Visible = True
        AIC1.BringToFront()
        visiblecup.Add(1)
    End Sub

    Private Sub AIC2_Click(sender As Object, e As EventArgs) Handles AIC2.Click
        reset_state()
        as2 = 1
        AIS = 2
        move_to()
    End Sub

    Private Sub AIC3_Click(sender As Object, e As EventArgs) Handles AIC3.Click
        reset_state()
        as3 = 1
        AIS = 3
        move_to()
    End Sub

    Private Sub AIC4_Click(sender As Object, e As EventArgs) Handles AIC4.Click
        reset_state()
        as4 = 1
        AIS = 4
        move_to()
    End Sub

    Private Sub AIC5_Click(sender As Object, e As EventArgs) Handles AIC5.Click
        reset_state()
        as5 = 1
        AIS = 5
        move_to()
    End Sub

    Private Sub AIC6_Click(sender As Object, e As EventArgs) Handles AIC6.Click
        reset_state()
        as6 = 1
        AIS = 6
        move_to()
    End Sub

    Private Sub AIC7_Click(sender As Object, e As EventArgs) Handles AIC7.Click
        reset_state()
        as7 = 1
        AIS = 7
        move_to()
    End Sub

    Private Sub AIC8_Click(sender As Object, e As EventArgs) Handles AIC8.Click
        reset_state()
        as8 = 1
        AIS = 8
        move_to()
    End Sub

    Private Sub AIC9_Click(sender As Object, e As EventArgs) Handles AIC9.Click
        reset_state()
        as9 = 1
        AIS = 9
        move_to()
    End Sub
    Private Sub move_to()

        If AI = False Then
            Select Case AIS
                Case 1
                    ' MsgBox("state1 clicked")
                    hide_pointer()
                    P2.Visible = True
                    P4.Visible = True
                    P5.Visible = True
                    'Timer1.Enabled = True
                    'For i = 1 To 10
                    '    Timer1.Start()
                    'Next
                    'Timer1.Stop()
                    'Timer1.Enabled = False
                    'If AIC2.Visible = False And AIC4.Visible = False And AIC5.Visible = False Then
state_1:
                    Select Case Initiate_AIC1()
                        Case 2
                            If AIC2.Visible = False Then
                                delay()
                                P2.PerformClick()
                            Else
                                GoTo state_1
                            End If


                        Case 4

                            If AIC4.Visible = False Then
                                delay()
                                P4.PerformClick()
                            Else
                                GoTo state_1
                            End If
                        Case 5
                            If AIC5.Visible = False Then
                                delay()
                                P5.PerformClick()
                            Else
                                GoTo state_1
                            End If
                    End Select

                   ' End If


                Case 2
                    ' MsgBox("state2 clicked")
                    hide_pointer()
                    P1.Visible = True
                    P5.Visible = True
                    P3.Visible = True
                    'P5.PerformClick()
state_2:
                    Select Case Initiate_AIC2()
                        Case 1
                            If AIC1.Visible = False Then
                                delay()
                                P1.PerformClick()
                            Else
                                GoTo state_2
                            End If


                        Case 3

                            If AIC3.Visible = False Then
                                delay()
                                P3.PerformClick()
                            Else
                                GoTo state_2
                            End If
                        Case 5
                            If AIC5.Visible = False Then
                                delay()
                                P5.PerformClick()
                            Else
                                GoTo state_2
                            End If
                    End Select

                Case 3
                    'MsgBox("state3 clicked")
                    hide_pointer()
                    P2.Visible = True
                    P5.Visible = True
                    P6.Visible = True
                    'P6.PerformClick()
state_3:
                    Select Case Initiate_AIC3()
                        Case 2
                            If AIC2.Visible = False Then
                                delay()
                                P2.PerformClick()
                            Else
                                GoTo state_3
                            End If


                        Case 5

                            If AIC5.Visible = False Then
                                delay()
                                P5.PerformClick()
                            Else
                                GoTo state_3
                            End If
                        Case 6
                            If AIC6.Visible = False Then
                                delay()
                                P6.PerformClick()
                            Else
                                GoTo state_3
                            End If
                    End Select



                Case 4
                    'MsgBox("state3 clicked")
                    hide_pointer()
                    P1.Visible = True
                    P5.Visible = True
                    P7.Visible = True
                    'P6.PerformClick()
state_4:
                    Select Case Initiate_AIC4()
                        Case 1
                            If AIC1.Visible = False Then
                                delay()
                                P1.PerformClick()
                            Else
                                GoTo state_4
                            End If


                        Case 5

                            If AIC5.Visible = False Then
                                delay()
                                P5.PerformClick()
                            Else
                                GoTo state_4
                            End If
                        Case 7
                            If AIC7.Visible = False Then
                                delay()
                                P7.PerformClick()
                            Else
                                GoTo state_4
                            End If
                    End Select


                Case 5
                    'MsgBox("state3 clicked")
                    hide_pointer()
                    P1.Visible = True
                    P2.Visible = True
                    P3.Visible = True
                    P4.Visible = True
                    P6.Visible = True
                    P7.Visible = True
                    P8.Visible = True
                    P9.Visible = True

                    'P6.PerformClick()
state_5:
                    Select Case Initiate_AIC5()
                        Case 1
                            If AIC1.Visible = False Then
                                delay()
                                P1.PerformClick()
                            Else
                                GoTo state_5
                            End If
                        Case 2
                            If AIC2.Visible = False Then
                                delay()
                                P2.PerformClick()
                            Else
                                GoTo state_5
                            End If
                        Case 3
                            If AIC3.Visible = False Then
                                delay()
                                P3.PerformClick()
                            Else
                                GoTo state_5
                            End If
                        Case 4
                            If AIC3.Visible = False Then
                                delay()
                                P3.PerformClick()
                            Else
                                GoTo state_5
                            End If
                        Case 6
                            If AIC6.Visible = False Then
                                delay()
                                P6.PerformClick()
                            Else
                                GoTo state_5
                            End If
                        Case 7
                            If AIC7.Visible = False Then
                                delay()
                                P7.PerformClick()
                            Else
                                GoTo state_5
                            End If
                        Case 8
                            If AIC8.Visible = False Then
                                delay()
                                P8.PerformClick()
                            Else
                                GoTo state_5
                            End If
                        Case 9
                            If AIC9.Visible = False Then
                                delay()
                                P9.PerformClick()
                            Else
                                GoTo state_5
                            End If
                    End Select


                Case 6
                    'MsgBox("state3 clicked")
                    hide_pointer()
                    P3.Visible = True
                    P5.Visible = True
                    P9.Visible = True
                    'P6.PerformClick()
state_6:
                    Select Case Initiate_AIC6()
                        Case 3
                            If AIC3.Visible = False Then
                                delay()
                                P3.PerformClick()
                            Else
                                GoTo state_6
                            End If


                        Case 5

                            If AIC5.Visible = False Then
                                delay()
                                P5.PerformClick()
                            Else
                                GoTo state_6
                            End If
                        Case 9
                            If AIC9.Visible = False Then
                                delay()
                                P9.PerformClick()
                            Else
                                GoTo state_6
                            End If
                    End Select

                Case 7
                    'MsgBox("state3 clicked")
                    hide_pointer()
                    P4.Visible = True
                    P5.Visible = True
                    P8.Visible = True
                    'P6.PerformClick()
state_7:
                    Select Case Initiate_AIC7()
                        Case 4
                            If AIC4.Visible = False Then
                                delay()
                                P4.PerformClick()
                            Else
                                GoTo state_7
                            End If


                        Case 5

                            If AIC5.Visible = False Then
                                delay()
                                P5.PerformClick()
                            Else
                                GoTo state_7
                            End If
                        Case 8
                            If AIC8.Visible = False Then
                                delay()
                                P8.PerformClick()
                            Else
                                GoTo state_7
                            End If
                    End Select

                Case 8
                    'MsgBox("state3 clicked")
                    hide_pointer()
                    P7.Visible = True
                    P5.Visible = True
                    P9.Visible = True
                    'P6.PerformClick()
state_8:
                    Select Case Initiate_AIC8()
                        Case 7
                            If AIC7.Visible = False Then
                                delay()
                                P7.PerformClick()
                            Else
                                GoTo state_8
                            End If


                        Case 5

                            If AIC5.Visible = False Then
                                delay()
                                P5.PerformClick()
                            Else
                                GoTo state_8
                            End If
                        Case 9
                            If AIC9.Visible = False Then
                                delay()
                                P9.PerformClick()
                            Else
                                GoTo state_8
                            End If
                    End Select
                Case 9
                    'MsgBox("state3 clicked")
                    hide_pointer()
                    P6.Visible = True
                    P5.Visible = True
                    P8.Visible = True
                    'P6.PerformClick()
state_9:
                    Select Case Initiate_AIC9()
                        Case 6
                            If AIC6.Visible = False Then
                                delay()
                                P6.PerformClick()
                            Else
                                GoTo state_9
                            End If


                        Case 5

                            If AIC5.Visible = False Then
                                delay()
                                P5.PerformClick()
                            Else
                                GoTo state_9
                            End If
                        Case 8
                            If AIC8.Visible = False Then
                                delay()
                                P8.PerformClick()
                            Else
                                GoTo state_9
                            End If
                    End Select
            End Select
        Else

        End If
    End Sub
    Private Sub delay()
        For i = 0 To 200000
            i += 1
        Next

        'Timer1.Interval = 100000 'ms
        'Timer1.Start()
    End Sub
End Class
