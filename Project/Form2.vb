Public Class Form2
    Private WithEvents richTextBox1 As RichTextBox
    Private WithEvents richTextBox2 As RichTextBox
    Private WithEvents richTextBox3 As RichTextBox
    Private WithEvents richTextBox4 As RichTextBox
    Private WithEvents richTextBox5 As RichTextBox
    Private WithEvents richTextBox6 As RichTextBox
    Private WithEvents richTextBox7 As RichTextBox
    Private WithEvents richTextBox8 As RichTextBox
    Private WithEvents richTextBox9 As RichTextBox
    Public Shared GALCVAL As Double = 100.0
    Private random As New Random()
    Private previousGALCVAL As Double = GALCVAL
    Private contextMenuVisible As Boolean = False
    Private contextMenustrip1Visible As Boolean = False
    Private contextMenustrip2Visible As Boolean = False
    Public Shared SANDVAL As Double = 200.0
    Private previousSANDVAL As Double = SANDVAL
    Public Shared GPUVAL As Double = 300.0
    Private previousGPUVAL As Double = GPUVAL
    Public Shared HIGHVAL As Double = 400.0
    Private previousHIGHVAL As Double = HIGHVAL
    Public Shared OSCARVAL As Double = 500.0
    Private previousOSCARVAL As Double = OSCARVAL
    Public Shared OILVAL As Double = 600.0
    Private previousOILVAL As Double = OILVAL
    Public Shared BLEYVAL As Double = 700.0
    Private previousBLEYVAL As Double = BLEYVAL
    Public Shared COLAVAL As Double = 800.0
    Private previousCOLAVAL As Double = COLAVAL
    Public Shared CLRKVAL As Double = 900.0
    Private previousCLRKVAL As Double = CLRKVAL
    Private userMoney As Integer = 1000
    Private weekCount As Integer = 0
    Public Sub gojo()
        InitializeComponent()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        upgrades.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Hide()
        shop.Show()
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Hide()
        Dim form3 As New form3(Me)
        form3.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        previousGALCVAL = GALCVAL
        Dim multipliers As Double() = Enumerable.Range(0, 9).Select(Function(i) 0.995 + (1.006 - 0.995) * random.NextDouble()).ToArray()

        GALCVAL *= multipliers(0)
        UpdateRichTextBox(richTextBox1, "GALC", "GALACTIC INC", GALCVAL, previousGALCVAL)

        previousSANDVAL = SANDVAL
        SANDVAL *= multipliers(1)
        UpdateRichTextBox(richTextBox2, "SAND", "SANDPARTICLE", SANDVAL, previousSANDVAL)

        previousGPUVAL = GPUVAL
        GPUVAL *= multipliers(2)
        UpdateRichTextBox(richTextBox3, "GPU", "NVIDEA", GPUVAL, previousGPUVAL)

        previousHIGHVAL = HIGHVAL
        HIGHVAL *= multipliers(3)
        UpdateRichTextBox(richTextBox4, "HIGH", "HIGHTOWER ENERGY", HIGHVAL, previousHIGHVAL)

        previousOSCARVAL = OSCARVAL
        OSCARVAL *= multipliers(4)
        UpdateRichTextBox(richTextBox5, "OSCAR", "OSCAR AIR", OSCARVAL, previousOSCARVAL)

        previousOILVAL = OILVAL
        OILVAL *= multipliers(5)
        UpdateRichTextBox(richTextBox6, "OIL", "OIL DRILLING", OILVAL, previousOILVAL)

        previousBLEYVAL = BLEYVAL
        BLEYVAL *= multipliers(6)
        UpdateRichTextBox(richTextBox7, "BLEY", "BULLSEYE", BLEYVAL, previousBLEYVAL)

        previousCOLAVAL = COLAVAL
        COLAVAL *= multipliers(7)
        UpdateRichTextBox(richTextBox8, "COLA", "MOCOLA DRINKS", COLAVAL, previousCOLAVAL)

        previousCLRKVAL = CLRKVAL
        CLRKVAL *= multipliers(8)
        UpdateRichTextBox(richTextBox9, "CLRK", "SARAH CLARK INC", CLRKVAL, previousCLRKVAL)
        weekCount += 1
        weekcnt.Text = $"Week: {weekCount}"
    End Sub

    Private Sub UpdateRichTextBox(richTextBox As RichTextBox, abbreviation As String, fullName As String, newValue As Double, previousValue As Double)
        Dim percentageChange As Double = ((newValue - previousValue) / previousValue) * 100
        Dim sign As String = If(percentageChange >= 0, "+", "-")
        Dim changeText As String = $"{sign}{Math.Abs(percentageChange):F4}%"
        Dim formattedText As String = $"{abbreviation}{Environment.NewLine}{fullName}{Environment.NewLine}{newValue:F4}"

        richTextBox.Clear()
        richTextBox.SelectionFont = New Font(richTextBox.Font, FontStyle.Bold)
        richTextBox.SelectionColor = Color.LightBlue
        richTextBox.AppendText(abbreviation & Environment.NewLine)

        richTextBox.SelectionFont = New Font(richTextBox.Font, FontStyle.Regular)
        richTextBox.SelectionColor = Color.Black
        richTextBox.AppendText(fullName & Environment.NewLine)

        richTextBox.AppendText($"{newValue:F4}")
        richTextBox.AppendText(Environment.NewLine & changeText)
        richTextBox.SelectionStart = richTextBox.Text.IndexOf(changeText)
        richTextBox.SelectionLength = changeText.Length
        richTextBox.SelectionColor = If(percentageChange >= 0, Color.Green, Color.Red)
    End Sub
    Private Sub RichTextBox_Click(sender As Object, e As EventArgs)
        Dim popupForm As New PopupForm()
        popupForm.Show()
    End Sub

    Public Sub context()
        contextmenu = New ContextMenuStrip()
        richTextBox1 = New RichTextBox() With {
        .Width = 200,
        .Height = 40,
        .Multiline = True,
        .Text = $"GALC:{Environment.NewLine}GALACTIC INC{Environment.NewLine}{GALCVAL} (+0.0)"
    }
        richTextBox1.Select(0, 5)
        richTextBox1.SelectionFont = New Font(richTextBox1.Font, FontStyle.Bold)
        richTextBox1.SelectionColor = Color.SteelBlue

        richTextBox2 = New RichTextBox() With {
        .Width = 200,
        .Height = 40,
        .Multiline = True,
        .Text = $"SAND:{Environment.NewLine}SANDPARTICLE{Environment.NewLine}{SANDVAL} (+0.0)"
    }
        richTextBox2.Select(0, 5)
        richTextBox2.SelectionFont = New Font(richTextBox2.Font, FontStyle.Bold)
        richTextBox2.SelectionColor = Color.SteelBlue

        richTextBox3 = New RichTextBox() With {
        .Width = 200,
        .Height = 40,
        .Multiline = True,
        .Text = $"GPU:{Environment.NewLine}NVIDEAGPU{Environment.NewLine}{GPUVAL} (+0.0)"
    }
        richTextBox3.Select(0, 4)
        richTextBox3.SelectionFont = New Font(richTextBox3.Font, FontStyle.Bold)
        richTextBox3.SelectionColor = Color.SteelBlue

        Dim host1 As New ToolStripControlHost(richTextBox1) With {.Size = richTextBox1.Size}
        Dim host2 As New ToolStripControlHost(richTextBox2) With {.Size = richTextBox2.Size}
        Dim host3 As New ToolStripControlHost(richTextBox3) With {.Size = richTextBox3.Size}
        contextmenu.Items.Add(host1)
        contextmenu.Items.Add(host2)
        contextmenu.Items.Add(host3)

        Label1.Font = New Font("Arial", 14, FontStyle.Bold)
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.Padding = New Padding(5)

        ContextMenuStrip1 = New ContextMenuStrip()

        richTextBox4 = New RichTextBox() With {
        .Width = 200,
        .Height = 40,
        .Multiline = True,
        .Text = $"HIGH:{Environment.NewLine}HIGHTOWERENERGY{Environment.NewLine}{HIGHVAL} (+0.0)"
    }
        richTextBox4.Select(0, 5)
        richTextBox4.SelectionFont = New Font(richTextBox4.Font, FontStyle.Bold)
        richTextBox4.SelectionColor = Color.SteelBlue

        richTextBox5 = New RichTextBox() With {
        .Width = 200,
        .Height = 40,
        .Multiline = True,
        .Text = $"OSCAR:{Environment.NewLine}OSCAR AIR{Environment.NewLine}{OSCARVAL} (+0.0)"
    }
        richTextBox5.Select(0, 6)
        richTextBox5.SelectionFont = New Font(richTextBox5.Font, FontStyle.Bold)
        richTextBox5.SelectionColor = Color.SteelBlue

        richTextBox6 = New RichTextBox() With {
        .Width = 200,
        .Height = 40,
        .Multiline = True,
        .Text = $"OIL:{Environment.NewLine}OIL DRILLING{Environment.NewLine}{OILVAL} (+0.0)"
    }
        richTextBox6.Select(0, 4)
        richTextBox6.SelectionFont = New Font(richTextBox6.Font, FontStyle.Bold)
        richTextBox6.SelectionColor = Color.SteelBlue

        Dim host4 As New ToolStripControlHost(richTextBox4) With {.Size = richTextBox4.Size}
        Dim host5 As New ToolStripControlHost(richTextBox5) With {.Size = richTextBox5.Size}
        Dim host6 As New ToolStripControlHost(richTextBox6) With {.Size = richTextBox6.Size}
        ContextMenuStrip1.Items.Add(host4)
        ContextMenuStrip1.Items.Add(host5)
        ContextMenuStrip1.Items.Add(host6)

        Label2.Font = New Font("Arial", 14, FontStyle.Bold)
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label2.TextAlign = ContentAlignment.MiddleCenter
        Label2.Padding = New Padding(5)

        ContextMenuStrip2 = New ContextMenuStrip()

        richTextBox7 = New RichTextBox() With {
        .Width = 200,
        .Height = 40,
        .Multiline = True,
        .Text = $"BLEY:{Environment.NewLine}BULLSEYE{Environment.NewLine}{BLEYVAL} (+0.0)"
    }
        richTextBox7.Select(0, 5)
        richTextBox7.SelectionFont = New Font(richTextBox7.Font, FontStyle.Bold)
        richTextBox7.SelectionColor = Color.SteelBlue

        richTextBox8 = New RichTextBox() With {
        .Width = 200,
        .Height = 40,
        .Multiline = True,
        .Text = $"COLA:{Environment.NewLine}MOCOLA DRINKS{Environment.NewLine}{COLAVAL} (+0.0)"
    }
        richTextBox8.Select(0, 5)
        richTextBox8.SelectionFont = New Font(richTextBox8.Font, FontStyle.Bold)
        richTextBox8.SelectionColor = Color.SteelBlue

        richTextBox9 = New RichTextBox() With {
        .Width = 200,
        .Height = 40,
        .Multiline = True,
        .Text = $"CLRK:{Environment.NewLine}SARAH CLARK INC{Environment.NewLine}{CLRKVAL} (+0.0)"
    }
        richTextBox9.Select(0, 5)
        richTextBox9.SelectionFont = New Font(richTextBox9.Font, FontStyle.Bold)
        richTextBox9.SelectionColor = Color.SteelBlue

        Dim host7 As New ToolStripControlHost(richTextBox7) With {.Size = richTextBox7.Size}
        Dim host8 As New ToolStripControlHost(richTextBox8) With {.Size = richTextBox8.Size}
        Dim host9 As New ToolStripControlHost(richTextBox9) With {.Size = richTextBox9.Size}
        ContextMenuStrip2.Items.Add(host7)
        ContextMenuStrip2.Items.Add(host8)
        ContextMenuStrip2.Items.Add(host9)

        Label3.Font = New Font("Arial", 14, FontStyle.Bold)
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.TextAlign = ContentAlignment.MiddleCenter
        Label3.Padding = New Padding(5)
        AddHandler richTextBox1.Click, AddressOf RichTextBox_Click
        AddHandler richTextBox2.Click, AddressOf RichTextBox_Click
        AddHandler richTextBox3.Click, AddressOf RichTextBox_Click
        AddHandler richTextBox4.Click, AddressOf RichTextBox_Click
        AddHandler richTextBox5.Click, AddressOf RichTextBox_Click
        AddHandler richTextBox6.Click, AddressOf RichTextBox_Click
        AddHandler richTextBox7.Click, AddressOf RichTextBox_Click
        AddHandler richTextBox8.Click, AddressOf RichTextBox_Click
        AddHandler richTextBox9.Click, AddressOf RichTextBox_Click
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If contextMenuVisible Then
            contextmenu.Hide()
        Else
            contextmenu.Show(Label1, 0, Label1.Height)
        End If
        contextMenuVisible = Not contextMenuVisible
    End Sub

    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
        Me.Hide()
        shop.Show()
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        If contextMenustrip1Visible Then
            ContextMenuStrip1.Hide()
        Else
            ContextMenuStrip1.Show(Label2, 0, Label2.Height)
        End If
        contextMenustrip1Visible = Not contextMenustrip1Visible
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If contextMenustrip2Visible Then
            ContextMenuStrip2.Hide()
        Else
            ContextMenuStrip2.Show(Label3, 0, Label3.Height)
        End If
        contextMenustrip2Visible = Not contextMenustrip2Visible
    End Sub

    Private Sub InitializeMoneyStrip()
        moneypanel.Dock = DockStyle.Top
        moneypanel.Height = 30
        moneypanel.BackColor = Color.Transparent
        Dim tableLayoutPanel As New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 3,
            .RowCount = 1
        }
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))


        moneylabel.Text = $"Money: ${userMoney}"
        moneylabel.ForeColor = Color.Transparent
        moneylabel.Font = New Font("Arial", 16, FontStyle.Bold)
        moneylabel.Dock = DockStyle.Fill
        moneylabel.TextAlign = ContentAlignment.MiddleCenter
        tableLayoutPanel.Controls.Add(moneylabel, 1, 0)
        moneypanel.Controls.Add(tableLayoutPanel)
    End Sub
    Public Sub UpdateMoney(amount As Integer)
        userMoney += amount
        moneylabel.Text = $"Money: ${userMoney}"
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Image = Image.FromFile("D:\Hefty boy\original_83093ea34391d9a149e767b741d746b2.gif")
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        context()
        InitializeMoneyStrip()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        form4.Show()
    End Sub
End Class
