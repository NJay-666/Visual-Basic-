Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim plus(8, 8) As Integer
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                plus(i, j) = (i + 1) * (j + 1)
                TextBox1.Text = TextBox1.Text & i + 1 & "x" & j + 1 & "=" & plus(i, j) & vbCrLf
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num(5, 998) As Integer
        Dim money() As Integer = {500, 100, 50, 10, 5, 1}
        Dim temnum As Integer = 0
        Dim coin(998) As Integer
        For i As Integer = 0 To 998
            temnum = i + 1
            For j As Integer = 0 To 5
                If temnum < money(j) Then
                    num(j, i) = 0
                    'TextBox2.Text = TextBox2.Text & num(j, i) & ","
                End If
                If temnum >= money(j) Then
                    num(j, i) = temnum \ money(j)
                    temnum = temnum - money(j) * num(j, i)
                    'TextBox2.Text = TextBox2.Text & num(j, i) & ","
                End If
            Next
            'TextBox2.Text = TextBox2.Text & vbCrLf
        Next
        For i As Integer = 0 To 998
            coin(i) = num(0, i) + num(1, i) + num(2, i) + num(3, i) + num(4, i)
            TextBox2.Text = TextBox2.Text & "兌換為" & i + 1 & "元的最少硬幣數為" & coin(i) & "個" & vbCrLf
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rnd As New Random()
        Dim a(2, 2) As Integer
        Dim b(2, 2) As Integer
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                a(i, j) = rnd.Next(1, 9)
                TextBox3.Text = TextBox3.Text & a(i, j) & " ,"
            Next
            TextBox3.Text = TextBox3.Text & vbCrLf
        Next
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                b(i, j) = a(j, i)
                TextBox3.Text = TextBox3.Text & b(i, j) & " ,"
            Next
            TextBox3.Text = TextBox3.Text & vbCrLf
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim seat(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim rnd As New Random()
        Dim rndnum(2) As Integer
        TextBox4.Text = ""
        For i As Integer = 0 To 2
            rndnum(i) = rnd.Next(1, 9)
        Next
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                If seat(i, j) - rndnum(0) = 0 Then
                    seat(i, j) = 0
                    TextBox4.Text = TextBox4.Text & seat(i, j) & " ,"
                ElseIf seat(i, j) - rndnum(1) = 0 Then
                    seat(i, j) = 0
                    TextBox4.Text = TextBox4.Text & seat(i, j) & " ,"
                ElseIf seat(i, j) - rndnum(2) = 0 Then
                    seat(i, j) = 0
                    TextBox4.Text = TextBox4.Text & seat(i, j) & " ,"
                Else
                    TextBox4.Text = TextBox4.Text & seat(i, j) & " ,"
                End If
            Next
            TextBox4.Text = TextBox4.Text & vbCrLf
        Next
        Dim column As Integer = Val(InputBox("請輸入第幾排"))
        Dim row As Integer = Val(InputBox("請輸入第幾個"))
        If seat(row - 1, column - 1) = 0 Then
            MsgBox("有人坐了")
        ElseIf seat(row - 1, column - 1) <> 0 Then
            MsgBox("可以坐")
        End If
    End Sub
End Class
