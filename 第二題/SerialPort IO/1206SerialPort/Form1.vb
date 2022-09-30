Imports System.IO.Ports
Public Class Form1
    Private comport As SerialPort
    Dim x As String = ""


    Dim a As String = ""
    Dim colored As Color

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comport = New SerialPort(start.ComboBox1.Text, 38400, Parity.None, 8, StopBits.One)
        AddHandler comport.DataReceived, AddressOf comport_DataReceived
        comport.Open()
        Timer1.Start()
        colored = c1.BackColor
    End Sub


    Private Sub comport_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) '輸入'

        Form.CheckForIllegalCrossThreadCalls = False


        While RAM.Text.Length < 8
            x = comport.ReadExisting
            RAM.Text += x
            x = ""
        End While

        If Mid(RAM.Text, 1, 1) = "?" Then
            a = Mid(RAM.Text, 2, 1)


        End If
        If a = "3" Then
            b1.BackColor = colored
            b2.BackColor = colored
            b3.BackColor = colored
            b4.BackColor = colored
            b5.BackColor = colored
            b6.BackColor = colored
            b7.BackColor = colored
            b8.BackColor = colored
            b9.BackColor = colored
            b10.BackColor = colored
            b11.BackColor = colored
            b12.BackColor = colored
        End If


        see1.Text = RAM.Text
        RAM.Text = ""
        x = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        'comport.Write("~~")
    End Sub

    Private Sub c1_Click(sender As Object, e As EventArgs) Handles c1.Click
        If a = "1" Then
            a = "0"
            comport.Write("?1000000")
        End If
    End Sub

    Private Sub c2_Click(sender As Object, e As EventArgs) Handles c2.Click
        If a = "1" Then
            a = "0"
            comport.Write("?1100000")
        End If
    End Sub
    '=======================================================================

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        If a = "2" Then
            b1.BackColor = Color.Yellow
            comport.Write("?2000001")
        End If
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        If a = "2" Then
            b2.BackColor = Color.Yellow
            comport.Write("?200000b")
        End If

    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If a = "2" Then
            b3.BackColor = Color.Yellow
            comport.Write("?200000x")
        End If

    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        If a = "2" Then
            b4.BackColor = Color.Yellow
            comport.Write("?200000A")
        End If

    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        If a = "2" Then
            b5.BackColor = Color.Yellow
            comport.Write("?2000005")
        End If

    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        If a = "2" Then
            b6.BackColor = Color.Yellow
            comport.Write("?200000I")
        End If

    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        If a = "2" Then
            b7.BackColor = Color.Yellow
            comport.Write("?200000\")
        End If

    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        If a = "2" Then
            b8.BackColor = Color.Yellow
            comport.Write("?200000Z")
        End If

    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        If a = "2" Then
            b9.BackColor = Color.Yellow
            comport.Write("?2000009")
        End If

    End Sub

    Private Sub b10_Click(sender As Object, e As EventArgs) Handles b10.Click
        If a = "2" Then
            b10.BackColor = Color.Yellow
            comport.Write("?200000:")
        End If

    End Sub

    Private Sub b11_Click(sender As Object, e As EventArgs) Handles b11.Click
        If a = "2" Then
            b11.BackColor = Color.Yellow
            comport.Write("?200000;")
        End If

    End Sub

    Private Sub b12_Click(sender As Object, e As EventArgs) Handles b12.Click
        If a = "2" Then
            b12.BackColor = Color.Yellow
            comport.Write("?200000<")
        End If

    End Sub


    'Private Sub B1_Click(sender As Object, e As EventArgs)

    '    If comport.ReadExisting = "1" Then

    '    End If

    '    'x = (q + w + a + a1.Text)
    '    'comport.Write(x)
    '    ''MsgBox(x)
    '    'a1.Text = ""
    '    'q = "0"
    '    'w = "0"
    '    'a = "0"


    'End Sub

End Class