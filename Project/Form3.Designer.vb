<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form3
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        buttonweek = New Button()
        playbutton = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button1.Location = New Point(75, 348)
        Button1.Name = "Button1"
        Button1.Size = New Size(42, 25)
        Button1.TabIndex = 0
        Button1.Text = "back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button2.Location = New Point(473, 95)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 25)
        Button2.TabIndex = 1
        Button2.Text = "original res"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(280, 90)
        Button3.Name = "Button3"
        Button3.Size = New Size(187, 34)
        Button3.TabIndex = 2
        Button3.Text = "resolution change"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' buttonweek
        ' 
        buttonweek.Location = New Point(280, 130)
        buttonweek.Name = "buttonweek"
        buttonweek.Size = New Size(187, 39)
        buttonweek.TabIndex = 3
        buttonweek.Text = "week interval"
        buttonweek.UseVisualStyleBackColor = True
        ' 
        ' playbutton
        ' 
        playbutton.Location = New Point(261, 197)
        playbutton.Name = "playbutton"
        playbutton.Size = New Size(75, 23)
        playbutton.TabIndex = 4
        playbutton.Text = "Music"
        playbutton.UseVisualStyleBackColor = True
        ' 
        ' form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(playbutton)
        Controls.Add(buttonweek)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents buttonweek As Button
    Friend WithEvents playbutton As Button
End Class
