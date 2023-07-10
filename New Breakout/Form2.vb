Option Explicit On
Option Strict On
Option Infer Off
Imports System.Globalization
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar


Public Class game

    'Glabal Speed Variables
    Private xSpeed As Integer = 3
    Private ySpeed As Integer = 3
    Private pSpeed As Integer = 3
    'variables for bricks
    Private bricks(7, 14) As Integer
    Dim topRow As Single = 0.05
    Dim rowHeight As Single = 0.05
    Private lives As Integer = 3
    Private score As Integer
    'hit
    Private pHit As Boolean = False
    Private Sub tmrBall_Tick(sender As Object, e As EventArgs) Handles tmrBall.Tick

        'set speed of ball
        ball.Left += xSpeed
        ball.Top += ySpeed

        'Check top of screen
        If ball.Top < 0 Then
            ySpeed = -ySpeed
        End If

        'check left side of screen
        If ball.Left < 0 Then
            xSpeed = -xSpeed
        End If

        'check bottom of screen
        If ball.Bottom > Me.ClientRectangle.Height Then
            tmrBall.Enabled = False
            tmrRefresh.Enabled = True
            lives -= 1
            lblLives.Text = "Lives: " & lives.ToString
            If lives = 0 Then
                pnlNewGame.Visible = True
            End If
        End If

        'check right of screen
        If ball.Right > Me.ClientRectangle.Width Then
            xSpeed = -xSpeed
        End If

        'Center of Ball 
        Dim center As Integer = CInt(ball.Left + ball.Width / 2)

        'Check for bat hit
        If center > paddle.Left And center < paddle.Right And ySpeed > 0 And ball.Bottom > paddle.Top And ball.Top < paddle.Top Then
            ySpeed = -ySpeed
            'Curve the bat
            Dim offSet As Integer = CInt((ball.Left + ball.Width / 2) - (paddle.Left + paddle.Width / 2))
            Dim ratio As Integer = CInt(offSet / (paddle.Width / 2))
            xSpeed += CInt(1.25 * ratio)
        End If

        'Call to checkbrick procedure
        For Each Cnt As Control In Me.Controls
            If Cnt.Name = "Brick" Then
                CheckBrick(CType(Cnt, Button), ball)
            End If
        Next

        Select Case score
            Case = 1
                tmrPowerUpFall.Enabled = True
            Case = 10
                tmrPowerUpFall.Enabled = True
            Case = 20
                tmrPowerUpFall.Enabled = True
            Case = 30
                tmrPowerUpFall.Enabled = True
            Case = 40
                tmrPowerUpFall.Enabled = True
            Case = 50
                tmrPowerUpFall.Enabled = True
            Case = 60
                tmrPowerUpFall.Enabled = True
            Case = 70
                tmrPowerUpFall.Enabled = True
            Case = 80
                tmrPowerUpFall.Enabled = True
        End Select

        'check power up
        Dim pcenter As Integer = CInt(powerup.Left + powerup.Width / 2)
        If pcenter > paddle.Left And pcenter < paddle.Right And pSpeed > 0 And powerup.Bottom > paddle.Top And powerup.Top < paddle.Top Then
            powerup.Visible = False
            pHit = True
            tmrPower.Enabled = True
            tmrPowerUpFall.Enabled = False
        ElseIf powerup.Top > ClientRectangle.Height Then
            powerup.Visible = False
            tmrPowerUpFall.Enabled = False
        End If

        If tmrPower.Enabled = True Then
            paddle.Width = CInt(0.25 * Me.ClientRectangle.Width)
        ElseIf tmrPower.Enabled = False Then
            paddle.Width = CInt(0.15 * Me.ClientRectangle.Width)
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'loading game variables
        MakeBricks()
        lblLives.Text = "Lives: " & lives.ToString
        lblScore.Text = "Score: " & score.ToString
        'loads ball to starting location
        With ball
            .Left = CInt(Me.ClientRectangle.Width / 2)
            .Top = CInt(Me.ClientRectangle.Height * 0.92)
        End With
        'paddle
        paddle.Width = CInt(0.15 * Me.ClientRectangle.Width)
        paddle.Height = CInt(0.02 * Me.ClientRectangle.Height)
        paddle.Top = CInt(0.95 * Me.ClientRectangle.Height)
    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        'apperance of paddle and follow mouse cursor
        'paddle.Width = CInt(0.15 * Me.ClientRectangle.Width)
        'paddle.Height = CInt(0.02 * Me.ClientRectangle.Height)
        'paddle.Top = CInt(0.95 * Me.ClientRectangle.Height)
        paddle.Left = e.X - CInt(0.15 * Me.ClientRectangle.Width)

    End Sub
    Private Sub CheckBrick(ByVal brick As Button, ByVal ball As Button)

        'See if brick visible
        If brick.Visible Then

            'hit true/false
            Dim hit As Boolean = False

            'hortizontal center of ball
            Dim hCenter As Integer = CInt(ball.Left + ball.Width / 2)

            'check bottom of brick
            If ySpeed < 0 And hCenter > brick.Left And hCenter < brick.Right And ball.Top < brick.Bottom And ball.Bottom > brick.Bottom Then
                ySpeed = -ySpeed
                hit = True
            End If

            'check top of brick
            If ySpeed > 0 And hCenter > brick.Left And hCenter < brick.Right And ball.Bottom > brick.Top And ball.Top < brick.Top Then
                ySpeed = -ySpeed
                hit = True
            End If

            'vertical center of ball
            Dim vCenter As Integer = CInt(ball.Top + ball.Height / 2)

            'check left side of brick
            If xSpeed > 0 And vCenter > brick.Top And vCenter < brick.Bottom And ball.Right > brick.Left And ball.Left < brick.Left Then
                xSpeed = -xSpeed
                hit = True
            End If

            'check right side of brick
            If xSpeed < 0 And vCenter > brick.Top And vCenter < brick.Bottom And ball.Left < brick.Right And ball.Right > brick.Right Then
                xSpeed = -xSpeed
                hit = True
            End If

            'procedures when brick is hit
            If hit Then
                brick.Visible = False
                score += CInt(brick.Tag)
                lblScore.Text = "Score: " & score.ToString
            End If
        End If

    End Sub
    Private Sub MakeBricks()

        'clear old bricks
        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            If Me.Controls(i).Name = "Brick" Then
                Me.Controls.RemoveAt(i)
            End If
        Next
        'Building bricks
        'rows
        For intRow As Integer = 0 To bricks.GetUpperBound(0)
            'columns
            For intCol As Integer = 0 To bricks.GetUpperBound(1)
                'each new button is delacred as a brick
                Dim brick As New Button
                'adds brick to list of controls
                Me.Controls.Add(brick)
                'each brick is named brick in the control
                brick.Name = "Brick"
                'tags brick control with a number pertaining to row it is in for scoring purposes
                brick.Tag = (bricks.GetUpperBound(0) + 1) - intRow
                'styling
                brick.FlatStyle = FlatStyle.Flat
                brick.Visible = True
                brick.Width = CInt(Me.ClientRectangle.Width / (bricks.GetUpperBound(1) + 1))
                brick.Height = CInt(Me.ClientRectangle.Height * rowHeight)
                'location
                brick.Left = CInt(intCol * brick.Width)
                brick.Top = CInt(Me.ClientRectangle.Height * (topRow + intRow * rowHeight))
                'coloring
                If (intRow + intCol) Mod 2 = 0 Then
                    brick.BackColor = Color.DarkSeaGreen
                Else
                    brick.BackColor = Color.MistyRose
                End If
            Next
        Next
    End Sub
    Private Sub Form2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        'Start ball movement
        If Asc(e.KeyChar) = 32 Then
            'moves ball
            tmrBall.Enabled = True
            'ends ball refresh
            tmrRefresh.Enabled = False
        End If

    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick

        'resets ball to starting location
        With ball
            .Left = CInt(Me.ClientRectangle.Width / 2)
            .Top = CInt(Me.ClientRectangle.Height * 0.92)
        End With
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click

        'makes new game
        'hides game over panel
        pnlNewGame.Visible = False
        'resets lives
        lives = 3
        'resets score
        score = 0
        'restes labels
        lblLives.Text = "Lives: " & lives.ToString
        lblScore.Text = "Score: " & score.ToString
        'makes new bricks
        MakeBricks()
        'restarts timers
        tmrRefresh.Enabled = True
        tmrRefresh.Enabled = False

    End Sub

    Private Sub btnEnterScore_Click(sender As Object, e As EventArgs) Handles btnEnterScore.Click

        Dim outfile As IO.StreamWriter

        outfile = IO.File.AppendText("highscores.txt")

        outfile.WriteLine(txtName.Text & " " & score.ToString)

        outfile.Close()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub tmrPowerUpFall_Tick(sender As Object, e As EventArgs) Handles tmrPowerUpFall.Tick

        powerup.Top += pSpeed
        powerup.Visible = True

    End Sub

    Private Sub tmrPower_Tick(sender As Object, e As EventArgs) Handles tmrPower.Tick
        pHit = False
        powerup.Visible = False
        With powerup
            .Left = CInt(Me.ClientRectangle.Width / 2)
            .Top = CInt(Me.ClientRectangle.Height * 0.05)
        End With
        tmrPower.Enabled = False
    End Sub
End Class
