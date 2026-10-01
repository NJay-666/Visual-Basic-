Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        Do Until (num = 6)
            num = Int((6 * Rnd()) + 1)
        Loop
        TextBox1.Text = num
        MsgBox("點數為6")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num As Integer, fin As String, i As Integer = 2, flag As Integer = 1
        num = Val(TextBox2.Text)
        Do While (flag = 1) And (i < num)
            If (num Mod i = 0) Then
                flag = 0
            End If
            i = i + 1
        Loop
        If (flag = 1) Then
            fin = num & "是質數"
        Else
            fin = num & "不是質數"
        End If
        TextBox3.Text = fin
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim j As Integer = 0, sum As Integer = 0
        Do While (sum <= 1000)
            sum = sum + j ^ 2
            j = j + 1
        Loop
        TextBox4.Text = sum & "，n = 14"
    End Sub
End Class
