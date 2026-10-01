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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        TextBox5 = New TextBox()
        Button2 = New Button()
        TextBox6 = New TextBox()
        Label1 = New Label()
        Label5 = New Label()
        Button3 = New Button()
        TextBox7 = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(58, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(37, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(101, 37)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(37, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(144, 37)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(37, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(268, 37)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(78, 23)
        TextBox4.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 5
        Label2.Text = "數字"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(95, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 6
        Label3.Text = "運算符號"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(156, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 7
        Label4.Text = "數字"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(187, 37)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "計算結果="
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(71, 118)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(37, 23)
        TextBox5.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(86, 147)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 10
        Button2.Text = "計算乘法表"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(71, 176)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.ScrollBars = ScrollBars.Both
        TextBox6.Size = New Size(100, 209)
        TextBox6.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(126, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 12
        Label1.Text = "輸入一個數字"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(311, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 15)
        Label5.TabIndex = 15
        Label5.Text = "輸入一個數字"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(271, 150)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 23)
        Button3.TabIndex = 14
        Button3.Text = "判斷是否為質數"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(256, 121)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(37, 23)
        TextBox7.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(TextBox7)
        Controls.Add(Label1)
        Controls.Add(TextBox6)
        Controls.Add(Button2)
        Controls.Add(TextBox5)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox7 As TextBox

End Class
