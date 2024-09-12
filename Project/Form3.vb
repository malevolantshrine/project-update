Imports System.Media
Public Class form3
    Private originalWidth As Integer
    Private originalHeight As Integer
    Private previousForm As Form
    Private isPlaying As Boolean = False

    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playbutton.Click
        Dim player As New SoundPlayer("D:\Hefty boy\AdVenture Capitalist OST _ Main Theme (Earth) [ ezmp3.cc ].wav")

        If isPlaying Then
            player.Stop()
            isPlaying = False
        Else
            player.Play()
            isPlaying = True
        End If
    End Sub
    Public Sub New(previousForm As Form)
        InitializeComponent()
        Me.previousForm = previousForm
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        originalWidth = Me.Width
        originalHeight = Me.Height
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        previousForm.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Width = 1024
        Me.Height = 768
        For Each frm As Form In Application.OpenForms
            frm.Width = Width
            frm.Height = Height
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Width = originalWidth
        Me.Height = originalHeight
        For Each frm As Form In Application.OpenForms
            frm.Width = originalWidth
            frm.Height = originalHeight
        Next
    End Sub
    Private Sub playbutton_Click_1(sender As Object, e As EventArgs) Handles playbutton.Click
    End Sub
End Class