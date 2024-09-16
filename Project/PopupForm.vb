Public Class PopupForm
    Public WithEvents BuyButton As New Button()
    Public WithEvents SellButton As New Button()
    Private messageLabel As New Label()
    Private sharesOwnedLabel As New Label()

    Public Sub New()
        Me.Text = "Stock Information"
        messageLabel.AutoSize = True
        messageLabel.Location = New Point(10, 10)
        Me.Controls.Add(messageLabel)
        sharesOwnedLabel.AutoSize = True
        sharesOwnedLabel.Location = New Point(10, 50)
        Me.Controls.Add(sharesOwnedLabel)
        BuyButton.Text = "Buy"
        BuyButton.Location = New Point(200, 150)
        Me.Controls.Add(BuyButton)
        SellButton.Text = "Sell"
        SellButton.Location = New Point(100, 150)
        Me.Controls.Add(SellButton)
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub

    Public Sub SetMessage(message As String)
        messageLabel.Text = message
    End Sub

    Public Sub UpdateSharesOwned(sharesOwned As Integer)
        sharesOwnedLabel.Text = $"Shares Owned: {sharesOwned}"
    End Sub

    Protected Overrides Sub OnDeactivate(e As EventArgs)
        MyBase.OnDeactivate(e)
        Me.Close()
    End Sub

    Private Sub PopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class