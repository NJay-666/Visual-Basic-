Public Class Form1
    Dim rnd As New Random()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '26
        Dim score(9) As Integer
        Dim level As Char
        Dim a, b, c, d, f As Integer
        For i As Integer = 0 To 9
            score(i) = rnd.Next(1, 100)
            Select Case score(i)
                Case < 60
                    level = "F"
                    f = f + 1
                Case < 70
                    level = "D"
                    d = d + 1
                Case < 80
                    level = "C"
                    c = c + 1
                Case < 90
                    level = "B"
                    b = b + 1
                Case <= 100
                    level = "A"
                    a = a + 1
            End Select
            TextBox1.Text = TextBox1.Text & "第" & i + 1 & "同學的成績為" & score(i) & ", 等第為" & level & vbCrLf
        Next
        TextBox1.Text = TextBox1.Text & "A的有" & a & "人" & vbCrLf & "B的有" & b & "人" & vbCrLf & "C的有" & c & "人" & vbCrLf & "D的有" & d & "人" & vbCrLf & "F的有" & f & "人"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '27(這題用迴圈比較符合老師的要求，我寫的比較直接)
        TextBox2.Text = ""
        Dim price() As Integer = {25, 35, 17, 49, 39, 79}
        Dim num As Integer = Val(InputBox("請輸入要查詢的商品編號(範圍為1~6)"))
        For i As Integer = 0 To 5
            If i + 1 = num Then
                TextBox2.Text = TextBox2.Text & price(i)
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = ""
        Dim name() As String = {"艾德加", "莫提斯", "娜吉雅", "史派克", "達米安"}
        Dim search As String = InputBox("請輸入要搜尋的姓名")
        For i As Integer = 0 To 4
            If search = name(i) Then
                TextBox3.Text = TextBox3.Text & "找到，在第" & i + 1 & "個位置"
                Exit For
            End If
        Next
        If TextBox3.Text = "" Then
            TextBox3.Text = "查無資料"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '29
        Dim num(14) As Integer
        Dim show(8) As Integer
        For i As Integer = 0 To 14
            num(i) = rnd.Next(1, 9)
            TextBox4.Text = TextBox4.Text & num(i) & " "
            For j As Integer = 0 To 8
                If num(i) = j + 1 Then
                    show(j) = show(j) + 1
                End If
            Next
        Next
        TextBox4.Text = TextBox4.Text & vbCrLf
        For i As Integer = 0 To 8
            TextBox4.Text = TextBox4.Text & i + 1 & "總共出現" & show(i) & "次" & vbCrLf
        Next
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '30
        TextBox5.Text = ""
        Dim num(4) As Integer
        For i As Integer = 0 To 4
            num(i) = rnd.Next(1, 10)
            TextBox5.Text = TextBox5.Text & num(i) & "  "
        Next
        TextBox5.Text = TextBox5.Text & vbCrLf
        For i As Integer = 0 To 3
            If num(i) = num(i + 1) Then
                TextBox5.Text = TextBox5.Text & "第" & i + 1 & "位和第" & i + 2 & "位相鄰數字一樣" & vbCrLf
            End If
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '31
        Dim score(9) As Integer
        Dim big As Integer = 0
        Dim sbig As Integer = 0
        For i As Integer = 0 To 9
            score(i) = rnd.Next(0, 100)
            TextBox6.Text = TextBox6.Text & score(i) & " ,"
            If score(i) > big Then
                big = score(i)
            End If
        Next
        TextBox6.Text = TextBox6.Text & vbCrLf & "最高分為" & big
        For i As Integer = 0 To 9
            If score(i) = big Then
                score(i) = 0
            ElseIf score(i) > sbig Then
                sbig = score(i)
            End If
        Next
        TextBox6.Text = TextBox6.Text & vbCrLf & "第二高分為" & sbig
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '32
        Dim money(,) As Integer = {{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}, {50, 100, 55, 75, 100, 60, 120, 55, 60, 70, 150, 200}}
        Dim sum As Integer
        Dim ave As Double
        For i As Integer = 0 To 11
            sum = sum + money(1, i)
        Next
        ave = sum / 12
        Dim highest As Integer = money(1, 0)
        For i As Integer = 0 To 11
            If money(1, i) > highest Then
                highest = money(1, i)
            End If
        Next
        Dim highmonth As Integer
        For i As Integer = 0 To 11
            If money(1, i) = highest Then
                highmonth = money(0, i)
            End If
        Next
        TextBox7.Text = TextBox7.Text & "總存款" & sum & ",平均月存款" & ave & " ,最高月份" & highmonth

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim a() As Integer = {10, 20, 30, 40, 50}
        Dim ltem As Integer = a(0)
        For i As Integer = 1 To 4
            a(i - 1) = a(i)
        Next
        a(4) = ltem
        For i As Integer = 0 To 4
            TextBox8.Text = TextBox8.Text & a(i) & ","
        Next
        TextBox8.Text = TextBox8.Text & vbCrLf
        Dim a1() As Integer = {10, 20, 30, 40, 50}
        Dim rtem As Integer = a1(4)
        For i As Integer = 1 To 4
            a1(i) = a1(i) - 10
        Next
        a1(0) = rtem
        For i As Integer = 0 To 4
            TextBox8.Text = TextBox8.Text & a1(i) & ","
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '36
        TextBox9.Text = ""
        Dim origin(6) As Integer
        Dim repeat(4) As Integer
        For i As Integer = 0 To 6
            origin(i) = rnd.Next(1, 6)
            TextBox9.Text = TextBox9.Text & origin(i) & ""
        Next
        TextBox9.Text = TextBox9.Text & vbCrLf
        For i As Integer = 0 To 6
            For j As Integer = 0 To 4
                If j + 1 = origin(i) Then
                    repeat(j) = repeat(j) + 1
                End If
            Next
        Next
        For j As Integer = 0 To 4
            If repeat(j) > 0 Then
                TextBox9.Text = TextBox9.Text & j + 1
            Else
                TextBox9.Text = TextBox9.Text & ""
            End If
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim show(9) As Integer
        Dim attend, noattend, attendp As Integer
        For i As Integer = 0 To 9
            show(i) = rnd.Next(0, 2)
            TextBox10.Text = TextBox10.Text & "第" & i + 1 & "次的出席率為" & show(i) & vbCrLf
            If show(i) = 1 Then
                attend = attend + 1
            Else
                noattend = noattend + 1
            End If
        Next
        attendp = attend * 10
        TextBox10.Text = TextBox10.Text & "出席次數" & attend & " 缺席次數" & noattend & " 出席率" & attendp & "%"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '39
        Dim num(4, 3) As Integer
        Dim odd, even As Integer
        For i As Integer = 0 To 4
            For j As Integer = 0 To 3
                num(i, j) = rnd.Next(1, 21)
                TextBox11.Text = TextBox11.Text & num(i, j) & ","
                If num(i, j) Mod 2 = 0 Then
                    even = even + 1
                Else
                    odd = odd + 1
                End If
            Next
            TextBox11.Text = TextBox11.Text & vbCrLf
        Next
        TextBox11.Text = TextBox11.Text & "奇數有" & odd & "個" & vbCrLf & "偶數有" & even & "個"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '40
        Dim num(3, 4) As Integer
        Dim highest, lowest As Integer
        For i As Integer = 0 To 3
            For j As Integer = 0 To 4
                num(i, j) = rnd.Next(1, 51)
                TextBox12.Text = TextBox12.Text & num(i, j) & vbTab
            Next
            TextBox12.Text = TextBox12.Text & vbCrLf
        Next
        For j As Integer = 0 To 4
            highest = num(0, j)
            For i As Integer = 1 To 3
                If num(i, j) > highest Then
                    highest = num(i, j)
                End If
            Next
            TextBox12.Text = TextBox12.Text & "第" & j + 1 & "直行的最大值" & highest & vbCrLf
        Next
        For j As Integer = 0 To 4
            lowest = num(0, j)
            For i As Integer = 1 To 3
                If num(i, j) < lowest Then
                    lowest = num(i, j)
                End If
            Next
            TextBox12.Text = TextBox12.Text & "第" & j + 1 & "直行的最小值" & lowest & vbCrLf
        Next
    End Sub
End Class
