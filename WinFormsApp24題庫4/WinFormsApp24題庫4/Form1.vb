Public Class Form1
    Dim rnd As New Random()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '47
        Dim ss(3, 2) As Integer
        Dim sum As Integer
        Dim average As Double
        Dim highest As Integer = 0
        For i As Integer = 0 To 3
            For j As Integer = 0 To 2
                ss(i, j) = rnd.Next(0, 101)
                TextBox1.Text = TextBox1.Text & ss(i, j) & vbTab
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
        For j As Integer = 0 To 2
            sum = 0
            average = 0
            For i As Integer = 0 To 3
                sum = sum + ss(i, j)
            Next
            If sum > highest Then
                highest = sum
            End If
            average = sum / 4
            TextBox1.Text = TextBox1.Text & "第" & j + 1 & "位同學的總分為" & sum & vbCrLf
            TextBox1.Text = TextBox1.Text & "第" & j + 1 & "位同學的平均為" & average & vbCrLf
        Next
        TextBox1.Text = TextBox1.Text & "成績最高分為" & highest
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '49 & 50
        Dim seat(9, 7) As Integer
        Dim blank As Integer
        Dim vip, normal, sale As Integer
        For i As Integer = 0 To 9
            For j As Integer = 0 To 7
                seat(i, j) = rnd.Next(0, 2)
                TextBox2.Text = TextBox2.Text & seat(i, j) & " ,"
                If seat(i, j) = 0 Then
                    blank = blank + 1
                Else
                    Select Case i
                        Case < 3
                            vip += 1
                        Case < 6
                            normal += 1
                        Case < 10
                            sale += 1
                    End Select
                End If
            Next
            TextBox2.Text = TextBox2.Text & vbCrLf
        Next
        vip = vip * 400 : normal = normal * 300 : sale = sale * 200
        TextBox2.Text = TextBox2.Text & "有" & blank & "個位置沒被預訂" & vbCrLf
        TextBox2.Text = TextBox2.Text & "總收入為" & vip + normal + sale & "元"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '51
        Dim hour(,) As Integer = {{8, 10, 8, 9, 8, 0, 0}, {12, 8, 8, 8, 11, 0, 0}, {8, 8, 8, 8, 8, 0, 0}, {10, 10, 10, 10, 10, 4, 0}, {8, 9, 8, 10, 8, 8, 8}}
        Dim sum As Integer
        For i As Integer = 0 To 4
            sum = 0
            For j As Integer = 0 To 6
                If hour(i, j) > 8 Then
                    sum += (hour(i, j) - 8)
                End If
            Next
            TextBox3.Text = TextBox3.Text & "第" & i + 1 & "位員工這周總加班時數為" & sum & vbCrLf
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '52
        Dim array(2, 3) As Integer
        Dim num As Integer = 1
        For i As Integer = 0 To 2
            For j As Integer = 0 To 3
                array(i, j) = num
                num += 1
                If i Mod 2 <> 0 Then
                    Select Case j
                        Case = 0
                            array(i, j) = array(i, j) + 3
                        Case = 1
                            array(i, j) = array(i, j) + 1
                        Case = 2
                            array(i, j) = array(i, j) - 1
                        Case = 3
                            array(i, j) = array(i, j) - 3
                    End Select
                End If
                TextBox4.Text = TextBox4.Text & array(i, j) & vbTab
            Next
            TextBox4.Text = TextBox4.Text & vbCrLf
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '53
        Dim a(2, 2) As Integer
        Dim b(2, 2) As Integer
        Dim c(2, 2) As Integer
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                a(i, j) = rnd.Next(1, 11)
                b(i, j) = rnd.Next(1, 11)
                c(i, j) = a(i, j) + b(i, j)
                TextBox5.Text = TextBox5.Text & c(i, j) & " "
            Next
            TextBox5.Text = TextBox5.Text & vbCrLf
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '第4題
        Dim money As Double = Val(InputBox("請輸入本金"))
        Dim year As Double = Val(InputBox("請輸入年利率")) / 100
        For i As Integer = 1 To 5
            money = money * (1 + year)
            TextBox6.Text = TextBox6.Text & Math.Floor(money) & vbCrLf
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '42
        Dim num(4, 998) As Integer
        Dim money = {500, 100, 10, 5, 1}
        Dim temoney As Integer
        Dim coin(998) As Integer
        For i = 0 To 998
            temoney = i + 1
            For j = 0 To 4
                num(j, i) = temoney \ money(j)
                temoney = temoney - money(j) * num(j, i)
            Next
        Next
        For i = 0 To 998
            For j = 0 To 4
                coin(i) = coin(i) + num(j, i)
            Next
            TextBox7.Text = TextBox7.Text & coin(i) & vbCrLf
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '43
        Dim user As Integer = Val(InputBox("請輸入金額"))
        Dim money = {500, 100, 10, 5, 1}
        Dim temoney As Integer
        Dim coin(4) As Integer
        Dim sum As Integer
        temoney = user
        For i As Integer = 0 To 4
            coin(i) = temoney \ money(i)
            temoney = temoney - coin(i) * money(i)
            sum = sum + coin(i)
        Next
        TextBox8.Text = TextBox8.Text & sum
    End Sub
End Class
