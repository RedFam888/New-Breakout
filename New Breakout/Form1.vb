Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        game.Show()
        Me.Hide()
    End Sub

    Private Sub btnShowScores_Click(sender As Object, e As EventArgs) Handles btnShowScores.Click

        Dim infile As IO.StreamReader

        If IO.File.Exists("highscores.txt") Then
            infile = IO.File.OpenText("highscores.txt")
            Do Until infile.Peek = -1
                lstHighScores.Items.Add(infile.ReadLine)
            Loop
            infile.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim infile As IO.StreamReader

        If IO.File.Exists("highscores.txt") Then
            infile = IO.File.OpenText("highscores.txt")
            Do Until infile.Peek = -1
                lstHighScores.Items.Add(infile.ReadLine)
            Loop
            infile.Close()
        End If
    End Sub
End Class
