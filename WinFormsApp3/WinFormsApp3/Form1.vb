Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '簡單乘法計算機
        Dim a As Integer, b As Integer
        a = Val(InputBox("請輸入一個數字", "簡單乘法計算機"))
        b = Val(InputBox("請輸入一個數字", "簡單乘法計算機"))
        MsgBox("相乘結果為" & a * b)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim b As Integer, c As Integer, d As Integer, f As Integer, g As Integer
        b = Val(TextBox3.Text) : c = Val(TextBox4.Text) : d = Val(TextBox5.Text)
        f = Val(TextBox6.Text) : g = Val(TextBox7.Text)
        TextBox8.Text = b - c - d + f - g
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox9.Text = NumericUpDown1.Value * 250 + NumericUpDown2.Value * 300 + NumericUpDown3.Value * 200
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Const pi As Double = 3.1415926
        TextBox11.Text = (Val(TextBox10.Text)) * 2 * pi
        TextBox12.Text = Val(TextBox10.Text) * Val(TextBox10.Text) * pi
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim s As Integer
        s = Val(TextBox13.Text)
        TextBox14.Text = s * 1.8 + 32
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim w As Integer
        w = Val(TextBox14.Text)
        TextBox13.Text = (w - 32) * 5 / 9
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim x As Double, y As Double, z As Double
        x = Val(TextBox15.Text) - Val(TextBox16.Text)
        y = Val(TextBox17.Text) - Val(TextBox18.Text)
        z = Val(TextBox19.Text) - Val(TextBox20.Text)
        TextBox21.Text = (x ^ 2 + y ^ 2 + z ^ 2) ^ (1 / 2)
    End Sub
End Class
