<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        TextBox1 = New TextBox()
        ButtonBuyShare = New Button()
        ButtonSellShare = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        buttontime = New Button()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        TextBox5 = New TextBox()
        PictureBox1 = New PictureBox()
        btnQuit = New Button()
        Button2 = New Button()
        Label5 = New Label()
        TextBoxPrediction = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(139, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 15)
        Label1.TabIndex = 0
        Label1.Text = "Money owned"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(139, 112)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' ButtonBuyShare
        ' 
        ButtonBuyShare.Location = New Point(139, 166)
        ButtonBuyShare.Name = "ButtonBuyShare"
        ButtonBuyShare.Size = New Size(75, 23)
        ButtonBuyShare.TabIndex = 2
        ButtonBuyShare.Text = "Buy share"
        ButtonBuyShare.UseVisualStyleBackColor = True
        ' 
        ' ButtonSellShare
        ' 
        ButtonSellShare.Location = New Point(293, 166)
        ButtonSellShare.Name = "ButtonSellShare"
        ButtonSellShare.Size = New Size(75, 23)
        ButtonSellShare.TabIndex = 3
        ButtonSellShare.Text = "sell share"
        ButtonSellShare.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(284, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 4
        Label2.Text = "Share value"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(284, 112)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        ' 
        ' buttontime
        ' 
        buttontime.Location = New Point(445, 166)
        buttontime.Name = "buttontime"
        buttontime.Size = New Size(75, 23)
        buttontime.TabIndex = 6
        buttontime.Text = "Time"
        buttontime.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(445, 112)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(445, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 8
        Label3.Text = "shares owned"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(337, 279)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(271, 23)
        TextBox4.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(337, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 10
        Label4.Text = "weeks progressed"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(8, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(70, 23)
        Button1.TabIndex = 11
        Button1.Text = "options"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(341, 308)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(267, 23)
        TextBox5.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(689, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(99, 64)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' btnQuit
        ' 
        btnQuit.Location = New Point(673, 379)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(75, 23)
        btnQuit.TabIndex = 14
        btnQuit.Text = "Exit game"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(50, 308)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 23)
        Button2.TabIndex = 15
        Button2.Text = "Prediction"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(89, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 15)
        Label5.TabIndex = 16
        Label5.Text = "Price = 25"
        ' 
        ' TextBoxPrediction
        ' 
        TextBoxPrediction.Location = New Point(47, 337)
        TextBoxPrediction.Name = "TextBoxPrediction"
        TextBoxPrediction.Size = New Size(175, 23)
        TextBoxPrediction.TabIndex = 17
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBoxPrediction)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(btnQuit)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox5)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(buttontime)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(ButtonSellShare)
        Controls.Add(ButtonBuyShare)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonBuyShare As Button
    Friend WithEvents ButtonSellShare As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Friend WithEvents buttontime As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPrediction As TextBox
End Class
