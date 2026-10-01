Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("相加結果為" & Val(InputBox("請輸入一個數字", "簡單加法計算器")) + Val(InputBox("請輸入一個數字", "簡單加法計算器")), 0)
        'MsgBox("Hello," & InputBox("請輸入名字?", "打招呼程式"), 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim piece, fin As Integer
        piece = Val(TextBox1.Text)
        Select Case piece
            Case = 1
                fin = 100
            Case <= 5
                fin = 100 * 0.9 * piece
            Case <= 10
                fin = 100 * 0.8 * piece
            Case <= 20
                fin = 100 * 0.7 * piece
            Case > 21
                fin = 100 * 0.6 * piece
        End Select
        TextBox2.Text = fin
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sum As Integer, num As Integer = Val(InputBox("請輸入一個數字"))
        sum = num
        Do While (num <> 0)
            num = Val(InputBox("請輸入一個數字"))
            sum = sum + num
        Loop
        TextBox3.Text = sum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sum As Integer, i As Integer = 1
        Do While (sum <= 1000)
            sum = sum + i ^ 3
            i = i + 1
        Loop
        TextBox4.Text = sum
    End Sub
End Class