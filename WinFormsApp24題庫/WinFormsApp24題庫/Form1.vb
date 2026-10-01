Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '第一題
        TextBox1.Text = ""
        Dim num1, num2, sum1, sum2, sum1p2, sum1m2 As Integer
        num1 = Val(InputBox("請輸入一個數字", "第一個數字"))
        For i As Integer = 1 To num1
            If num1 Mod i = 0 Then
                sum1 = sum1 + 1
            End If
        Next
        If sum1 - 2 = 0 Then
            TextBox1.Text = TextBox1.Text & num1 & "是質數" & vbCrLf
        Else
            TextBox1.Text = TextBox1.Text & num1 & "不是質數" & vbCrLf
        End If
        num2 = Val(InputBox("請輸入一個數字", "第二個數字"))
        For i As Integer = 1 To num2
            If num2 Mod i = 0 Then
                sum2 = sum2 + 1
            End If
        Next
        If sum2 - 2 = 0 Then
            TextBox1.Text = TextBox1.Text & num2 & "是質數" & vbCrLf
        Else
            TextBox1.Text = TextBox1.Text & num2 & "不是質數" & vbCrLf
        End If
        '相加
        For i As Integer = 1 To (num1 + num2)
            If (num1 + num2) Mod i = 0 Then
                sum1p2 = sum1p2 + 1
            End If
        Next
        If sum1p2 - 2 = 0 Then
            TextBox1.Text = TextBox1.Text & "2數相加是質數" & vbCrLf
        Else
            TextBox1.Text = TextBox1.Text & "2數相加不是質數" & vbCrLf
        End If
        '相乘
        For i As Integer = 1 To (num1 * num2 - 2)
            If (num1 * num2 - 2) Mod i = 0 Then
                sum1m2 = sum1m2 + 1
            End If
        Next
        If sum1m2 - 2 = 0 Then
            TextBox1.Text = TextBox1.Text & "2 數相乘後再減 2是質數" & vbCrLf
        Else
            TextBox1.Text = TextBox1.Text & "2 數相乘後再減 2不是質數" & vbCrLf
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '第二題
        Dim waterv As Double = Val(TextBox2.Text)
        Dim waterm As Double
        Select Case waterv
            Case <= 10
                waterm = waterv * 7.35
            Case <= 30
                waterm = waterv * 9.45 - 21
            Case <= 50
                waterm = waterv * 11.55 - 84
            Case >= 51
                waterm = waterv * 12.075 - 110.25
        End Select
        TextBox3.Text = "水費為" & waterm & "元"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Text = ""
        Dim rnd As New Random()
        Dim num1 As Integer = 0
        Dim num2 As Integer = 0
        Do While num1 + num2 <> 7
            num1 = rnd.Next(1, 6)
            num2 = rnd.Next(1, 6)
            TextBox4.Text = TextBox4.Text & num1 & "和" & num2 & vbCrLf
        Loop
        TextBox4.Text = TextBox4.Text & "等於7了"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '正直角三角形
        For i As Integer = 1 To 5
            For j As Integer = 1 To i
                TextBox5.Text = TextBox5.Text & "*"
            Next
            TextBox5.Text = TextBox5.Text & vbCrLf
        Next
        '倒直角三角形
        For i As Integer = 5 To 1 Step -1
            For j As Integer = 1 To i
                TextBox5.Text = TextBox5.Text & "*"
            Next
            TextBox5.Text = TextBox5.Text & vbCrLf
        Next
        '正三角形
        For i As Integer = 1 To 5
            For j As Integer = i - 1 To 5
                TextBox5.Text = TextBox5.Text & " "
            Next
            For j As Integer = 1 To i
                TextBox5.Text = TextBox5.Text & "*"
            Next
            TextBox5.Text = TextBox5.Text & vbCrLf
        Next
        '倒正三角形
        For i As Integer = 5 To 1 Step -1
            For j As Integer = i - 1 To 5
                TextBox5.Text = TextBox5.Text & " "
            Next
            For j As Integer = 1 To i
                TextBox5.Text = TextBox5.Text & "*"
            Next
            TextBox5.Text = TextBox5.Text & vbCrLf
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '第九題
        TextBox6.Text = ""
        Dim n As Integer = Val(TextBox7.Text)
        Dim m As Integer = Val(TextBox8.Text)
        Dim nm(n, m) As Integer
        Dim nxm As Integer = 1
        For i As Integer = 1 To n
            For j As Integer = 1 To m
                nm(i, j) = nxm
                TextBox6.Text = TextBox6.Text & nm(i, j) & vbTab
                nxm = nxm + 1
            Next
            TextBox6.Text = TextBox6.Text & vbCrLf
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For i As Integer = 1 To 5
            For j As Integer = 1 To 5
                If i Mod 2 <> 0 Then
                    TextBox9.Text = TextBox9.Text & "十"
                Else
                    TextBox9.Text = TextBox9.Text & "一"
                End If
            Next
            TextBox9.Text = TextBox9.Text & vbCrLf
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '11題
        For i As Integer = 1 To 5
            For j As Integer = 1 To 5
                If i - j = 0 Then
                    TextBox10.Text = TextBox10.Text & "x"
                Else
                    TextBox10.Text = TextBox10.Text & "0"
                End If
            Next
            TextBox10.Text = TextBox10.Text & vbCrLf
        Next
        '12題
        For i As Integer = 1 To 5
            For j As Integer = 1 To 5
                If i = 3 And j = 3 Then
                    TextBox10.Text = TextBox10.Text & "#"
                Else
                    TextBox10.Text = TextBox10.Text & "0"
                End If
            Next
            TextBox10.Text = TextBox10.Text & vbCrLf
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '13題
        Dim seat(2, 4) As String
        For i As Integer = 0 To 2
            For j As Integer = 0 To 4
                seat(i, j) = i + 1 & "-" & j + 1
                TextBox11.Text = TextBox11.Text & seat(i, j) & "    "
            Next
            TextBox11.Text = TextBox11.Text & vbCrLf
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '14題(飲料和加料的品項是我自己假設的)
        Dim drink() As String = {"紅茶", "奶茶", "鮮奶茶", "綠茶", "烏龍茶"}
        Dim Toppings() As String = {"珍珠", "仙草凍", "布丁"}
        For i As Integer = 0 To 2
            For j As Integer = 0 To 4
                TextBox12.Text = TextBox12.Text & Toppings(i) & drink(j) & vbCrLf
            Next
        Next
    End Sub
End Class
