Public Class CompanyInfoForm
    Public Sub New(companyName As String, description As String, currentValue As Double, previousValue As Double)
        InitializeComponent()

        ' Set the values to the labels
        lblCompanyName.Text = companyName
        lblDescription.Text = description
        lblCurrentValue.Text = currentValue.ToString("F2")
        lblPreviousValue.Text = previousValue.ToString("F2")
    End Sub

    ' Other existing code...
End Class
