Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text.Json
Imports System.Drawing

Public Module ShapeHelper
    Public Function GetParallelogramPath(rect As Rectangle, skew As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddLine(rect.Left + skew, rect.Top, rect.Right, rect.Top)
        path.AddLine(rect.Right - skew, rect.Bottom, rect.Left, rect.Bottom)
        path.CloseFigure()
        Return path
    End Function
End Module
Public Class form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile("D:\Hefty boy\original_83093ea34391d9a149e767b741d746b2.gif")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        button1.Size = New Size(240, 50)
        button2.Size = New Size(240, 50)
        button4.Size = New Size(240, 50)
        ApplyParallelogramShape(button1, 20)
        ApplyParallelogramShape(button2, 20)
        ApplyParallelogramShape(button4, 20)
        AddHandler button1.Paint, AddressOf DrawButtonBorder
        AddHandler button2.Paint, AddressOf DrawButtonBorder
        AddHandler button4.Paint, AddressOf DrawButtonBorder
    End Sub
    Private Sub ApplyParallelogramShape(control As Control, skew As Integer)
        Dim rect As New Rectangle(0, 0, control.Width, control.Height)
        control.Region = New Region(ShapeHelper.GetParallelogramPath(rect, skew))
    End Sub

    Private Sub DrawButtonBorder(sender As Object, e As PaintEventArgs)
        Dim button As Button = CType(sender, Button)
        Dim rect As New Rectangle(0, 0, button.Width, button.Height)
        Dim path As GraphicsPath = ShapeHelper.GetParallelogramPath(rect, 20)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Using pen As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim form3 As New form3(Me)
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles button1.MouseEnter, button2.MouseEnter, button4.MouseEnter
        Dim btn = CType(sender, Button)
        btn.BackColor = Color.LightBlue
        btn.Size = New Size(btn.Width + 10, btn.Height + 10)
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles button1.MouseLeave, button2.MouseLeave, button4.MouseLeave
        Dim btn = CType(sender, Button)
        btn.BackColor = SystemColors.Control
        btn.Size = New Size(btn.Width - 10, btn.Height - 10)
    End Sub
    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class

