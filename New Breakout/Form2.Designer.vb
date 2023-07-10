<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ball = New Button()
        lblScore = New Label()
        lblLives = New Label()
        pnlNewGame = New Panel()
        btnMainMenu = New Button()
        btnEnterScore = New Button()
        txtName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnNewGame = New Button()
        paddle = New Button()
        tmrBall = New Timer(components)
        tmrRefresh = New Timer(components)
        powerup = New Button()
        tmrPowerUpFall = New Timer(components)
        tmrPower = New Timer(components)
        pnlNewGame.SuspendLayout()
        SuspendLayout()
        ' 
        ' ball
        ' 
        ball.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ball.FlatAppearance.BorderColor = Color.Red
        ball.FlatAppearance.BorderSize = 0
        ball.FlatStyle = FlatStyle.Popup
        ball.ForeColor = Color.Orange
        ball.Location = New Point(372, 682)
        ball.Margin = New Padding(0)
        ball.Name = "ball"
        ball.Size = New Size(24, 24)
        ball.TabIndex = 9
        ball.UseVisualStyleBackColor = False
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.BackColor = Color.White
        lblScore.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblScore.ForeColor = SystemColors.ActiveCaptionText
        lblScore.Location = New Point(619, 9)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(63, 25)
        lblScore.TabIndex = 8
        lblScore.Text = "Score:"
        ' 
        ' lblLives
        ' 
        lblLives.AutoSize = True
        lblLives.BackColor = Color.White
        lblLives.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblLives.ForeColor = SystemColors.ActiveCaptionText
        lblLives.Location = New Point(12, 9)
        lblLives.Name = "lblLives"
        lblLives.Size = New Size(57, 25)
        lblLives.TabIndex = 7
        lblLives.Text = "Lives:"
        ' 
        ' pnlNewGame
        ' 
        pnlNewGame.BackColor = SystemColors.ActiveCaption
        pnlNewGame.Controls.Add(btnMainMenu)
        pnlNewGame.Controls.Add(btnEnterScore)
        pnlNewGame.Controls.Add(txtName)
        pnlNewGame.Controls.Add(Label2)
        pnlNewGame.Controls.Add(Label1)
        pnlNewGame.Controls.Add(btnNewGame)
        pnlNewGame.Location = New Point(286, 272)
        pnlNewGame.Name = "pnlNewGame"
        pnlNewGame.Size = New Size(194, 128)
        pnlNewGame.TabIndex = 6
        pnlNewGame.Visible = False
        ' 
        ' btnMainMenu
        ' 
        btnMainMenu.Location = New Point(47, 102)
        btnMainMenu.Name = "btnMainMenu"
        btnMainMenu.Size = New Size(104, 23)
        btnMainMenu.TabIndex = 8
        btnMainMenu.Text = "Main Menu"
        btnMainMenu.UseVisualStyleBackColor = True
        ' 
        ' btnEnterScore
        ' 
        btnEnterScore.Location = New Point(22, 78)
        btnEnterScore.Name = "btnEnterScore"
        btnEnterScore.Size = New Size(75, 23)
        btnEnterScore.TabIndex = 7
        btnEnterScore.Text = "Enter Score"
        btnEnterScore.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(22, 49)
        txtName.Name = "txtName"
        txtName.Size = New Size(152, 23)
        txtName.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 15)
        Label2.TabIndex = 2
        Label2.Text = "Enter Name for Highscores:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Snap ITC", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(7, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 31)
        Label1.TabIndex = 1
        Label1.Text = "Game Over"
        ' 
        ' btnNewGame
        ' 
        btnNewGame.Location = New Point(103, 78)
        btnNewGame.Name = "btnNewGame"
        btnNewGame.Size = New Size(75, 23)
        btnNewGame.TabIndex = 0
        btnNewGame.Text = "New Game"
        btnNewGame.UseVisualStyleBackColor = True
        ' 
        ' paddle
        ' 
        paddle.BackColor = Color.Cyan
        paddle.FlatAppearance.BorderColor = Color.Cyan
        paddle.FlatAppearance.BorderSize = 0
        paddle.FlatStyle = FlatStyle.Popup
        paddle.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        paddle.Location = New Point(319, 706)
        paddle.Margin = New Padding(0)
        paddle.Name = "paddle"
        paddle.Size = New Size(130, 23)
        paddle.TabIndex = 10
        paddle.UseVisualStyleBackColor = False
        ' 
        ' tmrBall
        ' 
        tmrBall.Interval = 10
        ' 
        ' tmrRefresh
        ' 
        ' 
        ' powerup
        ' 
        powerup.BackColor = Color.Lime
        powerup.FlatAppearance.BorderColor = Color.Red
        powerup.FlatAppearance.BorderSize = 0
        powerup.FlatStyle = FlatStyle.Popup
        powerup.ForeColor = Color.Lime
        powerup.Location = New Point(376, 9)
        powerup.Margin = New Padding(0)
        powerup.Name = "powerup"
        powerup.Size = New Size(20, 20)
        powerup.TabIndex = 11
        powerup.UseVisualStyleBackColor = False
        powerup.Visible = False
        ' 
        ' tmrPowerUpFall
        ' 
        tmrPowerUpFall.Interval = 10
        ' 
        ' tmrPower
        ' 
        tmrPower.Interval = 10000
        ' 
        ' game
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources.bg2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(754, 735)
        Controls.Add(powerup)
        Controls.Add(paddle)
        Controls.Add(ball)
        Controls.Add(lblScore)
        Controls.Add(lblLives)
        Controls.Add(pnlNewGame)
        DoubleBuffered = True
        KeyPreview = True
        Name = "game"
        Text = "Form2"
        pnlNewGame.ResumeLayout(False)
        pnlNewGame.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ball As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents pnlNewGame As Panel
    Friend WithEvents btnEnterScore As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNewGame As Button
    Friend WithEvents paddle As Button
    Friend WithEvents tmrBall As Timer
    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents powerup As Button
    Friend WithEvents tmrPowerUpFall As Timer
    Friend WithEvents tmrPower As Timer
End Class
