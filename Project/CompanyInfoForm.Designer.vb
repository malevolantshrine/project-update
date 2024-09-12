<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyInfoForm
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
        lblcompanyname = New Label()
        lblcurrentvalue = New Label()
        lblpreviousvalue = New Label()
        lbldescription = New Label()
        SuspendLayout()
        ' 
        ' lblcompanyname
        ' 
        lblcompanyname.AutoSize = True
        lblcompanyname.Location = New Point(319, 31)
        lblcompanyname.Name = "lblcompanyname"
        lblcompanyname.Size = New Size(41, 15)
        lblcompanyname.TabIndex = 0
        lblcompanyname.Text = "Label1"
        ' 
        ' lblcurrentvalue
        ' 
        lblcurrentvalue.AutoSize = True
        lblcurrentvalue.Location = New Point(319, 95)
        lblcurrentvalue.Name = "lblcurrentvalue"
        lblcurrentvalue.Size = New Size(41, 15)
        lblcurrentvalue.TabIndex = 2
        lblcurrentvalue.Text = "Label2"
        ' 
        ' lblpreviousvalue
        ' 
        lblpreviousvalue.AutoSize = True
        lblpreviousvalue.Location = New Point(319, 130)
        lblpreviousvalue.Name = "lblpreviousvalue"
        lblpreviousvalue.Size = New Size(41, 15)
        lblpreviousvalue.TabIndex = 3
        lblpreviousvalue.Text = "Label3"
        ' 
        ' lbldescription
        ' 
        lbldescription.AutoSize = True
        lbldescription.Location = New Point(319, 60)
        lbldescription.Name = "lbldescription"
        lbldescription.Size = New Size(41, 15)
        lbldescription.TabIndex = 4
        lbldescription.Text = "Label1"
        ' 
        ' CompanyInfoForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbldescription)
        Controls.Add(lblpreviousvalue)
        Controls.Add(lblcurrentvalue)
        Controls.Add(lblcompanyname)
        Name = "CompanyInfoForm"
        Text = "CompanyInfoForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblcompanyname As Label
    Friend WithEvents lblcurrentvalue As Label
    Friend WithEvents lblpreviousvalue As Label
    Friend WithEvents lbldescription As Label
End Class
