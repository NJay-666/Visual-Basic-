<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        TextBox3 = New TextBox()
        Button3 = New Button()
        TextBox4 = New TextBox()
        Button4 = New Button()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 0
        Label1.Text = "年利率%"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(85, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(50, 56)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "複利計算"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 3
        Label2.Text = "結果"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(85, 90)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ScrollBars = ScrollBars.Both
        TextBox2.Size = New Size(241, 262)
        TextBox2.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(336, 30)
        Button2.Name = "Button2"
        Button2.Size = New Size(237, 23)
        Button2.TabIndex = 5
        Button2.Text = "整除7且不整除21"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(336, 59)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ScrollBars = ScrollBars.Both
        TextBox3.Size = New Size(237, 293)
        TextBox3.TabIndex = 6
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(579, 30)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 23)
        Button3.TabIndex = 7
        Button3.Text = "19x19乘法表"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(579, 59)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.ScrollBars = ScrollBars.Both
        TextBox4.Size = New Size(112, 293)
        TextBox4.TabIndex = 8
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(732, 30)
        Button4.Name = "Button4"
        Button4.Size = New Size(125, 23)
        Button4.TabIndex = 9
        Button4.Text = "數字金字塔"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(697, 93)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.ScrollBars = ScrollBars.Both
        TextBox5.Size = New Size(179, 259)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(795, 67)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(81, 23)
        TextBox6.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(697, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 15)
        Label3.TabIndex = 12
        Label3.Text = "輸入n(最大為10)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1065, 450)
        Controls.Add(Label3)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Button4)
        Controls.Add(TextBox4)
        Controls.Add(Button3)
        Controls.Add(TextBox3)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label

End Class
