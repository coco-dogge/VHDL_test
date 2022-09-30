<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RAM = New System.Windows.Forms.TextBox()
        Me.c1 = New System.Windows.Forms.Button()
        Me.c2 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b1 = New System.Windows.Forms.Button()
        Me.b6 = New System.Windows.Forms.Button()
        Me.b5 = New System.Windows.Forms.Button()
        Me.b8 = New System.Windows.Forms.Button()
        Me.b7 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b12 = New System.Windows.Forms.Button()
        Me.b11 = New System.Windows.Forms.Button()
        Me.b10 = New System.Windows.Forms.Button()
        Me.b9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.see1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'RAM
        '
        Me.RAM.Location = New System.Drawing.Point(787, 575)
        Me.RAM.Name = "RAM"
        Me.RAM.Size = New System.Drawing.Size(123, 29)
        Me.RAM.TabIndex = 26
        Me.RAM.Visible = False
        '
        'c1
        '
        Me.c1.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.c1.Location = New System.Drawing.Point(59, 234)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(108, 65)
        Me.c1.TabIndex = 27
        Me.c1.Text = "外帶"
        Me.c1.UseVisualStyleBackColor = True
        '
        'c2
        '
        Me.c2.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.c2.Location = New System.Drawing.Point(210, 231)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(118, 68)
        Me.c2.TabIndex = 28
        Me.c2.Text = "內用"
        Me.c2.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b2.Location = New System.Drawing.Point(557, 110)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(118, 68)
        Me.b2.TabIndex = 30
        Me.b2.Text = "B"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b1
        '
        Me.b1.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b1.Location = New System.Drawing.Point(403, 110)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(108, 65)
        Me.b1.TabIndex = 29
        Me.b1.Text = "A"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b6.Location = New System.Drawing.Point(557, 215)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(118, 68)
        Me.b6.TabIndex = 32
        Me.b6.Text = "F"
        Me.b6.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b5.Location = New System.Drawing.Point(403, 218)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(108, 65)
        Me.b5.TabIndex = 31
        Me.b5.Text = "E"
        Me.b5.UseVisualStyleBackColor = True
        '
        'b8
        '
        Me.b8.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b8.Location = New System.Drawing.Point(866, 212)
        Me.b8.Name = "b8"
        Me.b8.Size = New System.Drawing.Size(118, 68)
        Me.b8.TabIndex = 36
        Me.b8.Text = "H"
        Me.b8.UseVisualStyleBackColor = True
        '
        'b7
        '
        Me.b7.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b7.Location = New System.Drawing.Point(712, 215)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(108, 65)
        Me.b7.TabIndex = 35
        Me.b7.Text = "G"
        Me.b7.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b4.Location = New System.Drawing.Point(866, 107)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(118, 68)
        Me.b4.TabIndex = 34
        Me.b4.Text = "D"
        Me.b4.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b3.Location = New System.Drawing.Point(712, 107)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(108, 65)
        Me.b3.TabIndex = 33
        Me.b3.Text = "C"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b12
        '
        Me.b12.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b12.Location = New System.Drawing.Point(866, 313)
        Me.b12.Name = "b12"
        Me.b12.Size = New System.Drawing.Size(118, 68)
        Me.b12.TabIndex = 40
        Me.b12.Text = "L"
        Me.b12.UseVisualStyleBackColor = True
        '
        'b11
        '
        Me.b11.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b11.Location = New System.Drawing.Point(712, 315)
        Me.b11.Name = "b11"
        Me.b11.Size = New System.Drawing.Size(108, 65)
        Me.b11.TabIndex = 39
        Me.b11.Text = "K"
        Me.b11.UseVisualStyleBackColor = True
        '
        'b10
        '
        Me.b10.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b10.Location = New System.Drawing.Point(557, 316)
        Me.b10.Name = "b10"
        Me.b10.Size = New System.Drawing.Size(118, 68)
        Me.b10.TabIndex = 38
        Me.b10.Text = "J"
        Me.b10.UseVisualStyleBackColor = True
        '
        'b9
        '
        Me.b9.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.b9.Location = New System.Drawing.Point(403, 319)
        Me.b9.Name = "b9"
        Me.b9.Size = New System.Drawing.Size(108, 65)
        Me.b9.TabIndex = 37
        Me.b9.Text = "I"
        Me.b9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(781, 467)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 36)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "內用座位選擇"
        '
        'see1
        '
        Me.see1.Location = New System.Drawing.Point(472, 575)
        Me.see1.Name = "see1"
        Me.see1.Size = New System.Drawing.Size(123, 29)
        Me.see1.TabIndex = 42
        Me.see1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1019, 667)
        Me.Controls.Add(Me.see1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b12)
        Me.Controls.Add(Me.b11)
        Me.Controls.Add(Me.b10)
        Me.Controls.Add(Me.b9)
        Me.Controls.Add(Me.b8)
        Me.Controls.Add(Me.b7)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b6)
        Me.Controls.Add(Me.b5)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.c2)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.RAM)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "COM port"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents a2 As TextBox
    Friend WithEvents a3 As TextBox
    Friend WithEvents RAM As TextBox
    Friend WithEvents c1 As Button
    Friend WithEvents c2 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents b6 As Button
    Friend WithEvents b5 As Button
    Friend WithEvents b8 As Button
    Friend WithEvents b7 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b12 As Button
    Friend WithEvents b11 As Button
    Friend WithEvents b10 As Button
    Friend WithEvents b9 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents see1 As TextBox
End Class
