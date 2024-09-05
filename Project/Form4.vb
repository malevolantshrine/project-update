Public Class Form4
    Public Sub UpdateStatMoney(totalMoneyGained As Double)
        StatMoney.Text = totalMoneyGained.ToString("F2")
    End Sub


    Private Sub StatMoney_TextChanged(sender As Object, e As EventArgs) Handles StatMoney.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Public Sub UpdateSellcount(sellcount As Integer)
        TextBox1.Text = sellcount.ToString()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Public Sub Updatebuycount(buycount As Integer)
        TextBox2.Text = buycount.ToString()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    End Sub
End Class