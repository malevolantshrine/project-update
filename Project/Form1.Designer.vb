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
        btn1 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        btnOpenFile = New Button()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(81, 35)
        btn1.Name = "btn1"
        btn1.Size = New Size(125, 49)
        btn1.TabIndex = 0
        btn1.Text = "play"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(81, 236)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 39)
        Button1.TabIndex = 1
        Button1.Text = "exit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(81, 104)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 43)
        Button2.TabIndex = 2
        Button2.Text = "options"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnOpenFile
        ' 
        btnOpenFile.Location = New Point(81, 172)
        btnOpenFile.Name = "btnOpenFile"
        btnOpenFile.Size = New Size(125, 42)
        btnOpenFile.TabIndex = 3
        btnOpenFile.Text = "Open file"
        btnOpenFile.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnOpenFile)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btn1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnOpenFile As Button

End Class
