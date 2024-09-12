<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        button1 = New Button()
        button4 = New Button()
        button2 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' button1
        ' 
        button1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        button1.FlatStyle = FlatStyle.Flat
        button1.Font = New Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        button1.Location = New Point(38, 30)
        button1.Name = "button1"
        button1.Size = New Size(101, 34)
        button1.TabIndex = 0
        button1.Text = "Play!"
        button1.UseVisualStyleBackColor = True
        ' 
        ' button4
        ' 
        button4.FlatStyle = FlatStyle.Flat
        button4.Font = New Font("Cooper Black", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        button4.Location = New Point(38, 150)
        button4.Name = "button4"
        button4.Size = New Size(101, 34)
        button4.TabIndex = 1
        button4.Text = "exit"
        button4.UseVisualStyleBackColor = True
        ' 
        ' button2
        ' 
        button2.FlatStyle = FlatStyle.Flat
        button2.Font = New Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        button2.Location = New Point(38, 90)
        button2.Name = "button2"
        button2.Size = New Size(101, 34)
        button2.TabIndex = 2
        button2.Text = "options"
        button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button2)
        Controls.Add(button4)
        Controls.Add(button1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents button1 As Button
    Friend WithEvents button4 As Button
    Friend WithEvents button2 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
