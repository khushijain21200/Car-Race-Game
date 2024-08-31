Public Class Form1
    Dim speed As Integer
    Dim score As Integer = 0
    Dim strip(10) As PictureBox
    Private Sub Game_Over()
        GameEnd.Visible = True
        RoadMove.Stop()
        right.Stop()
        left.Stop()
        Race1.Stop()
        Race2.Stop()
        Race3.Stop()
        Race4.Stop()
        Replay.Visible = True
        Total.Visible = True
        Points.Visible = False
        Total.Text = "TOTAL SCORE : " & score
        Label1.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 4
        strip(0) = P1
        strip(1) = P2
        strip(2) = P3
        strip(3) = P4
        strip(4) = P5
        strip(5) = P6
        strip(6) = P7
        strip(7) = P8
        strip(8) = P9
        strip(9) = P10


    End Sub

    Private Sub RoadMove_Tick(sender As Object, e As EventArgs) Handles RoadMove.Tick
        For i As Integer = 0 To 9
            strip(i).Top += speed
            If (strip(i).Top >= Me.Height) Then
                strip(i).Top = -strip(i).Height
            End If
        Next
        If score > 10 And score < 20 Then
            speed = 5
        End If
        If score > 20 And score < 30 Then
            speed = 6
        End If
        If score > 30 Then
            speed = 8
        End If
        Label1.Text = "SPEED : " & speed

        If (Car1.Bounds.IntersectsWith(Car2.Bounds)) Then
            Game_Over()
        End If

        If (Car1.Bounds.IntersectsWith(Car3.Bounds)) Then
            Game_Over()
        End If

        If (Car1.Bounds.IntersectsWith(Car4.Bounds)) Then
            Game_Over()
        End If

        If (Car1.Bounds.IntersectsWith(Car5.Bounds)) Then
            Game_Over()
        End If

    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            right.Start()
        End If

        If e.KeyCode = Keys.Left Then
            left.Start()
        End If

    End Sub

    Private Sub right_Tick(sender As Object, e As EventArgs) Handles right.Tick

        If Car1.Location.X < 270 Then
            Car1.Left += 5
        End If
    End Sub

    Private Sub left_Tick(sender As Object, e As EventArgs) Handles left.Tick

        If Car1.Location.X > 40 Then
            Car1.Left -= 5
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        right.Stop()
        left.Stop()
    End Sub

    Private Sub Race1_Tick(sender As Object, e As EventArgs) Handles Race1.Tick
        Car2.Top += speed * 0.5
        If Car2.Top >= Me.Height Then
            score += 1
            Points.Text = "SCORE : " & score
            Car2.Top = -(CInt(Math.Ceiling(Rnd() * 80)) + Car2.Height)
            Car2.Left = CInt(Math.Ceiling(Rnd() * 10)) + 50
        End If
    End Sub
    Private Sub Race2_Tick(sender As Object, e As EventArgs) Handles Race2.Tick
        Car3.Top += speed * 0.6
        If Car3.Top >= Me.Height Then
            score += 1
            Points.Text = "SCORE : " & score
            Car3.Top = -(CInt(Math.Ceiling(Rnd() * 90)) + Car3.Height)
            Car3.Left = CInt(Math.Ceiling(Rnd() * 30)) + 175
        End If
    End Sub
    Private Sub Race3_Tick(sender As Object, e As EventArgs) Handles Race3.Tick

        Car4.Top += speed * 0.6
        If Car4.Top >= Me.Height Then
            score += 1
            Points.Text = "SCORE : " & score
            Car4.Top = -(CInt(Math.Ceiling(Rnd() * 80)) + Car4.Height)
            Car4.Left = CInt(Math.Ceiling(Rnd() * 20)) + 112
        End If
    End Sub

    Private Sub Race4_Tick(sender As Object, e As EventArgs) Handles Race4.Tick
        Car5.Top += speed * 0.5
        If Car5.Top >= Me.Height Then
            score += 1
            Points.Text = "SCORE : " & score
            Car5.Top = -(CInt(Math.Ceiling(Rnd() * 80)) + Car5.Height)
            Car5.Left = CInt(Math.Ceiling(Rnd() * 10)) + 260
        End If
    End Sub

    Private Sub Replay_Click(sender As Object, e As EventArgs) Handles Replay.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)


    End Sub


End Class
