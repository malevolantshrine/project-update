Imports System.IO
Imports System.Text.Json

Public Class Form2

    Public moneyOwned As Decimal = 500
    Public shareValue As Decimal = 100
    Public sharesOwned As Integer = 0
    Public rand As New Random()
    Public weekCount As Integer = 1
    Public totalMoneyGained As Double = 0
    Public sellcount As Integer = 0
    Public buycount As Integer = 0
    Private predictedMultiplier As Double = 1.0
    Private predictionMade As Boolean = False
    Public Interval As Integer = 1

    Private Sub SaveGame()
        Dim gameState As New GameState With {
            .MoneyOwned = moneyOwned,
            .ShareValue = shareValue,
            .SharesOwned = sharesOwned,
            .WeekCount = weekCount,
            .TotalMoneyGained = totalMoneyGained
        }
        Dim jsonString As String = JsonSerializer.Serialize(gameState)
        File.WriteAllText("gamestate.json", jsonString)

        MessageBox.Show("Game saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = moneyOwned.ToString("F2")
        TextBox2.Text = shareValue.ToString("F2")
        TextBox3.Text = sharesOwned.ToString()
        UpdateWeatherForecast()
        AddHandler PictureBox1.Click, AddressOf PictureBox1_Click
    End Sub

    Private Sub ButtonTime_Click(sender As Object, e As EventArgs) Handles buttontime.Click
        Dim oldShareValue As Double = shareValue
        If Not predictionMade Then
            predictedMultiplier = rand.NextDouble() * (1.006 - 0.995) + 0.995
        End If
        shareValue *= predictedMultiplier
        TextBox2.Text = shareValue.ToString("F2")
        weekCount += 0
        Dim shareValueChange As Double = shareValue - oldShareValue
        TextBox4.Text = "Week: " & weekCount.ToString() & " | Share Value Change: " & shareValueChange.ToString("F2")
        UpdateWeatherForecast()
        predictionMade = False
        IncrementWeeks()
    End Sub

    Private Sub ButtonBuyShare_Click(sender As Object, e As EventArgs) Handles ButtonBuyShare.Click
        If moneyOwned >= shareValue Then
            moneyOwned -= shareValue
            sharesOwned += 1
            TextBox1.Text = moneyOwned.ToString("F2")
            TextBox3.Text = sharesOwned.ToString()
            buycount += 1
        Else
            MessageBox.Show("Not enough money to buy a share.")
        End If
    End Sub

    Private Sub ButtonSellShare_Click(sender As Object, e As EventArgs) Handles ButtonSellShare.Click
        If sharesOwned > 0 Then
            moneyOwned += shareValue
            sharesOwned -= 1
            TextBox1.Text = moneyOwned.ToString("F2")
            TextBox3.Text = sharesOwned.ToString()
            totalMoneyGained += shareValue
            sellcount += 1
        Else
            MessageBox.Show("No shares to sell.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form3 As New Form3(Me)
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to save your game before quitting?", "Quit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        Select Case result
            Case DialogResult.Yes
                SaveGame()
                Me.Close()
            Case DialogResult.No
                Me.Close()
            Case DialogResult.Cancel
        End Select
    End Sub

    Private Sub UpdateWeatherForecast()
        Dim temperature As Integer = rand.Next(-10, 35)
        Dim weatherConditions As String() = {"Sunny", "Windy", "Rainy", "Cloudy", "Stormy", "Heatwave"}
        Dim condition As String = weatherConditions(rand.Next(weatherConditions.Length))
        TextBox5.Text = $"Temperature: {temperature}°C, Condition: {condition}"
    End Sub

    Public Sub IncrementWeeks()
        weekCount += Interval
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form4.Show()
        Form4.UpdateStatMoney(totalMoneyGained)
        Form4.UpdateSellcount(sellcount)
        Form4.Updatebuycount(buycount)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If moneyOwned >= 25 Then
            moneyOwned -= 25
            TextBox1.Text = moneyOwned.ToString("F2")
            PredictShareValueChange()
        Else
            MessageBox.Show("Not enough money to get a prediction.")
        End If
    End Sub

    Private Sub PredictShareValueChange()
        predictedMultiplier = rand.NextDouble() * (1.006 - 0.995) + 0.995
        If predictedMultiplier > 1 Then
            TextBoxPrediction.Text = "The share value will increase."
        Else
            TextBoxPrediction.Text = "The share value will decrease."
        End If
        predictionMade = True
    End Sub

End Class

<Serializable>
Public Class GameState
    Public Property MoneyOwned As Decimal
    Public Property ShareValue As Decimal
    Public Property SharesOwned As Integer
    Public Property WeekCount As Integer
    Public Property TotalMoneyGained As Double
End Class

Public Class UserPerformance
    Private weeks As Integer
    Private totalEarnings As Double
    Private sharesBought As Integer
    Private sharesSold As Integer

    Public Sub New()
        weeks = 0
        totalEarnings = 0
        sharesBought = 0
        sharesSold = 0
    End Sub
    Public Sub userperformance()
        Dim userPerformance As New UserPerformance()
        userPerformance.AddWeek(150, 10, 5)
        userPerformance.AddWeek(200, 15, 10)
        userPerformance.AddWeek(100, 5, 2)
        userPerformance.AddWeek(75, 8, 4)
    End Sub
    Public Sub AddWeek(earnings As Double, bought As Integer, sold As Integer)
        weeks += 1
        totalEarnings += earnings
        sharesBought += bought
        sharesSold += sold

        If weeks = 4 Then
            ShowOverlay()
        End If
    End Sub

    Private Sub ShowOverlay()
        Dim performance As String = DeterminePerformance(totalEarnings)
        Console.WriteLine("Monthly Summary:")
        Console.WriteLine($"Total Earnings: ${totalEarnings}")
        Console.WriteLine($"Shares Bought: {sharesBought}")
        Console.WriteLine($"Shares Sold: {sharesSold}")
        Console.WriteLine($"Performance: {performance}")
    End Sub
    Private Function DeterminePerformance(earnings As Double) As String
        If earnings > 500 Then
            Return "Great"
        ElseIf earnings > 250 Then
            Return "Good"
        ElseIf earnings < 100 Then
            Return "Okay"
        Else
            Return "Average"
        End If
    End Function
End Class