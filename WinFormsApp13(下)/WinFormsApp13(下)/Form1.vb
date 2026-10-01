Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, sum As Integer
        n = Val(TextBox1.Text)
        For i As Integer = 1 To n
            sum = sum + i
        Next
        MsgBox(sum)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim inpa As String = TextBox2.Text
        Const ripa As String = "1234"
        Dim flag As Integer = 0
        If inpa = ripa Then
            flag = 1
        End If
        If flag = 0 Then
            MsgBox("密碼錯誤")
        Else
            MsgBox("密碼正確")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim goodsm As Integer = Val(NumericUpDown1.Value)
        Dim remoney As Integer = 1000 - goodsm

        Dim m500 As Integer = 0
        Do While remoney >= 500 And remoney < 1000
            remoney = remoney - 500
            m500 = m500 + 1
        Loop
        TextBox3.Text = m500

        Dim m100 As Integer = 0
        Do While remoney >= 100 And remoney < 500
            remoney = remoney - 100
            m100 = m100 + 1
        Loop
        TextBox4.Text = m100

        Dim m50 As Integer = 0
        Do While remoney >= 50 And remoney < 100
            remoney = remoney - 50
            m50 = m50 + 1
        Loop
        TextBox5.Text = m50

        Dim m10 As Integer = 0
        Do While remoney >= 10 And remoney < 50
            remoney = remoney - 10
            m10 = m10 + 1
        Loop
        TextBox6.Text = m10

        Dim m5 As Integer = 0
        Do While remoney >= 5 And remoney < 10
            remoney = remoney - 5
            m5 = m5 + 1
        Loop
        TextBox7.Text = m5

        Dim m1 As Integer = 0
        Do While remoney >= 1 And remoney < 5
            remoney = remoney - 1
            m1 = m1 + 1
        Loop
        TextBox8.Text = m1
    End Sub
End Class
