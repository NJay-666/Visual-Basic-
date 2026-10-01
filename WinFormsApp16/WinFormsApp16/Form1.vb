Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim money As Double = 10000
        Dim lisi As Double
        Dim lili As Double = Val(TextBox1.Text) / 100
        Dim year As Integer = 0
        Do
            If money > 20000 Then
                TextBox2.Text = TextBox2.Text & "需要花" & year & "年時間本利和會超過本金的2倍"
                Exit Do
            End If
            lisi = money * lili
            money = money + lisi
            year = year + 1
        Loop While True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sum As Integer
        Dim num As Integer = 1
        Do While num <= 1000
            If (num Mod 7 = 0) And (num Mod 21 <> 0) Then
                TextBox3.Text = TextBox3.Text & num & ","
                sum = sum + num
            End If
            num = num + 1
        Loop
        TextBox3.Text = TextBox3.Text & "總和是" & sum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 1 To 19
            For j As Integer = 1 To 19
                TextBox4.Text = TextBox4.Text & i & "x" & j & "=" & i * j & " " & vbCrLf
            Next
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n As Integer = Val(TextBox6.Text)
        For i As Integer = 1 To n
            For j As Integer = i - 1 To n
                TextBox5.Text = TextBox5.Text & "   "
            Next
            For j As Integer = 1 To i
                TextBox5.Text = TextBox5.Text & j & " "
            Next
            TextBox5.Text = TextBox5.Text & vbCrLf
        Next
    End Sub
End Class
