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

    End Sub


    Private Sub comport_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) '輸入'

        Form.CheckForIllegalCrossThreadCalls = False


        While RAM.Text.Length < 8
            x = comport.ReadExisting
            RAM.Text += x
            x = ""
        End While

        If Mid(RAM.Text, 1, 1) = "?" Then
            If Mid(RAM.Text, 2, 1) = "0" Then
                If T1.Text = Mid(RAM.Text, 3, 4) Then
                    comport.Write("!0")
                Else
                    comport.Write("!1")
                End If
            End If
            If Mid(RAM.Text, 2, 1) = "1" Then
                If T2.Text = Mid(RAM.Text, 3, 4) Then
                    comport.Write("!0")
                Else
                    comport.Write("!1")
                End If
            End If
            If Mid(RAM.Text, 2, 1) = "2" Then
                If T3.Text = Mid(RAM.Text, 3, 4) Then
                    comport.Write("!0")
                Else
                    comport.Write("!1")
                End If
            End If
            If Mid(RAM.Text, 2, 1) = "3" Then
                If T4.Text = Mid(RAM.Text, 3, 4) Then
                    comport.Write("!0")
                Else
                    comport.Write("!1")
                End If
            End If
            If Mid(RAM.Text, 2, 1) = "4" Then
                If T5.Text = Mid(RAM.Text, 3, 4) Then
                    comport.Write("!0")
                Else
                    comport.Write("!1")
                End If
            End If
            If Mid(RAM.Text, 2, 1) = "5" Then
                If T6.Text = Mid(RAM.Text, 3, 4) Then
                    comport.Write("!0")
                Else
                    comport.Write("!1")
                End If
            End If
        End If



        RAM.Text = ""
        x = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        comport.Write("~~")
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