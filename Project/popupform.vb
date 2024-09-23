Public Class PopupForm
    Private popup As PopupForm
    Private marketNameLabel As Label

    Public Sub New(marketName As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Size = New Size(200, 200)

        ' Initialize and configure the label
        marketNameLabel = New Label() With {
            .AutoSize = True,
            .Location = New Point(10, 10),
            .Font = New Font("Arial", 10, FontStyle.Regular),
            .Text = $"MARKET NAME: {marketName}"
        }

        ' Add the label to the form's controls
        Me.Controls.Add(marketNameLabel)
    End Sub
End Class