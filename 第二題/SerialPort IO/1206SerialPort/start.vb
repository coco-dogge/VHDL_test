Imports System.IO.Ports
Public Class start
    Private comport As SerialPort
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("devmgmt.msc")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        comport = New SerialPort(ComboBox1.Text, 38400, Parity.None, 8, StopBits.One)
        Try
            comport.Open()
            comport.Close()
            Form1.Show()
            Me.Hide()
        Catch
            MessageBox.Show("通訊埠'" + ComboBox1.Text + "'開啟失敗", "錯誤", 0, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Process.Start("http://www.prolific.com.tw/UserFiles/files/PL2303_Prolific_DriverInstaller_v1190.zip")
    End Sub

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "COM6"
    End Sub
End Class