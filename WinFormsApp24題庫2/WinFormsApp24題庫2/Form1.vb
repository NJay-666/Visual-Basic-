Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '15題
        Dim n As Integer = Val(TextBox1.Text)
        Dim m As Integer = Val(TextBox2.Text)
        For i As Integer = 0 To n - 1
            For j As Integer = 0 To m - 1
                If (i + j) Mod 2 = 0 Then
                    TextBox3.Text = TextBox3.Text & "0"
                Else
                    TextBox3.Text = TextBox3.Text & "1"
                End If
            Next
            TextBox3.Text = TextBox3.Text & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As Integer = Val(TextBox4.Text)
        For i As Integer = 1 To n
            TextBox5.Text = TextBox5.Text & "1" & vbTab
        Next
        TextBox5.Text = TextBox5.Text & vbCrLf
        For j As Integer = 1 To n - 2
            For i As Integer = 1 To n
                If i = 1 Or i = n Then
                    TextBox5.Text = TextBox5.Text & "1" & vbTab
                Else
                    TextBox5.Text = TextBox5.Text & vbTab
                End If
            Next
            TextBox5.Text = TextBox5.Text & vbCrLf
        Next
        For i As Integer = 1 To n
            TextBox5.Text = TextBox5.Text & "1" & vbTab
        Next
        TextBox5.Text = TextBox5.Text & vbCrLf
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '18題
        TextBox6.Text = ""
        Dim n As Integer = Val(TextBox7.Text)
        Dim sum As Integer
        Dim g As Integer = 1
        If n > 20 Then
            MsgBox("無法計算")
        Else
            For j As Integer = 1 To n
                g = g * j
                sum = sum + g
            Next
            TextBox6.Text = TextBox6.Text & sum
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i As Integer = 1 To 3
            For j As Integer = 1 To 3
                If i + j = 4 Then
                    TextBox8.Text = TextBox8.Text & i & "+" & j & "=" & i + j & vbCrLf
                End If
            Next
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '20
        Dim rnd As New Random()
        Dim num(7) As Integer
        Dim odd As Integer = 0
        Dim even As Integer = 0
        For i As Integer = 0 To 7
            num(i) = rnd.Next(1, 100)
            TextBox9.Text = TextBox9.Text & num(i) & " ,"
            If num(i) Mod 2 = 0 Then
                even = even + 1
            Else
                odd = odd + 1
            End If
        Next
        TextBox9.Text = TextBox9.Text & "奇數有" & odd & "個" & " , 偶數有" & even & "個"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '21
        Dim rage() As Integer = {35800, 42000, 31060, 55000, 56780}
        For i As Integer = 0 To 4
            rage(i) = rage(i) * 1.1
            TextBox10.Text = TextBox10.Text & rage(i) & "元 ,"
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim grade(9) As Integer
        Dim sum, highest, lowest As Integer
        Dim average As Double
        For i As Integer = 0 To 9
            grade(i) = Val(InputBox("請輸入第" & i + 1 & "位同學的成績"))
            sum = sum + grade(i)
            TextBox11.Text = TextBox11.Text & "第" & i + 1 & "位同學的成績為" & grade(i) & "分" & vbCrLf
        Next
        average = sum / 10
        highest = grade(0)
        lowest = grade(0)
        For i As Integer = 1 To 9
            If grade(i) > grade(i - 1) Then
                highest = grade(i)
            ElseIf grade(i) <= grade(i - 1) Then
                lowest = grade(i)
            End If
        Next
        TextBox11.Text = TextBox11.Text & "總分為" & sum & vbCrLf & "平均為" & average & vbCrLf & "最高分為" & highest & vbCrLf & "最低分為" & lowest
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim inventory(7) As Integer
        Dim low As Integer = 0
        For i As Integer = 0 To 7
            inventory(i) = Val(InputBox("請輸入商品" & i + 1 & "的庫存量"))
            TextBox12.Text = TextBox12.Text & "商品" & i + 1 & "的庫存量為" & inventory(i) & "件" & vbCrLf
            If inventory(i) < 10 Then
                low = low + 1
            End If
        Next
        TextBox12.Text = TextBox12.Text & "庫存低於10件的有" & low & "項"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '24
        Dim tem(6) As Integer
        Dim rnd As New Random()
        Dim average As Double
        Dim sum, aveday As Integer
        For i As Integer = 0 To 6
            tem(i) = rnd.Next(25, 32)
            sum = sum + tem(i)
        Next
        average = sum / 7
        For i As Integer = 0 To 6
            If tem(i) > average Then
                aveday = aveday + 1
            End If
        Next
        TextBox13.Text = TextBox13.Text & "平均氣溫為" & average & "度" & vbCrLf & "高於平均溫度的天數有" & aveday & "天"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '17題
        For i As Integer = 0 To 19
            For j As Integer = 0 To 19
                If (i + 1) * (j + 1) < 50 Then
                    TextBox14.Text = TextBox14.Text & i + 1 & "x" & j + 1 & "=" & (i + 1) * (j + 1) & vbCrLf
                End If
            Next
        Next
    End Sub
End Class
