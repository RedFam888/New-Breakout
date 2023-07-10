<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lstHighScores = New ListBox()
        btnShowScores = New Button()
        btnStart = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lstHighScores
        ' 
        lstHighScores.BackColor = SystemColors.HotTrack
        lstHighScores.BorderStyle = BorderStyle.None
        lstHighScores.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lstHighScores.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lstHighScores.FormattingEnabled = True
        lstHighScores.ItemHeight = 30
        lstHighScores.Location = New Point(317, 180)
        lstHighScores.Name = "lstHighScores"
        lstHighScores.Size = New Size(164, 180)
        lstHighScores.TabIndex = 7
        ' 
        ' btnShowScores
        ' 
        btnShowScores.BackColor = SystemColors.HotTrack
        btnShowScores.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnShowScores.FlatAppearance.BorderSize = 0
        btnShowScores.FlatStyle = FlatStyle.Popup
        btnShowScores.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnShowScores.Location = New Point(398, 151)
        btnShowScores.Name = "btnShowScores"
        btnShowScores.Size = New Size(83, 23)
        btnShowScores.TabIndex = 6
        btnShowScores.Text = "High Scores"
        btnShowScores.UseVisualStyleBackColor = False
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.HotTrack
        btnStart.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnStart.FlatAppearance.BorderSize = 0
        btnStart.FlatStyle = FlatStyle.Popup
        btnStart.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnStart.Location = New Point(317, 151)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(75, 23)
        btnStart.TabIndex = 5
        btnStart.Text = "Start Game"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.HotTrack
        Label1.Font = New Font("Harlow Solid Italic", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(254, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 61)
        Label1.TabIndex = 4
        Label1.Text = "Brick Smash"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 526)
        Controls.Add(lstHighScores)
        Controls.Add(btnShowScores)
        Controls.Add(btnStart)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstHighScores As ListBox
    Friend WithEvents btnShowScores As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents Label1 As Label
End Class
