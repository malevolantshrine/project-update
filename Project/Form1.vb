Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.Json

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        LoadGameState()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form3 As New Form3(Me)
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub LoadGameState()
        If File.Exists("gamestate.json") Then
            Dim jsonString As String = File.ReadAllText("gamestate.json")
            Dim gameState As GameState = JsonSerializer.Deserialize(Of GameState)(jsonString)

            Dim form2 As New Form2() With {
                .moneyOwned = gameState.MoneyOwned,
                .shareValue = gameState.ShareValue,
                .sharesOwned = gameState.SharesOwned,
                .weekCount = gameState.WeekCount,
                .totalMoneyGained = gameState.TotalMoneyGained
            }

            form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("No saved game found.", "Load Game", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
