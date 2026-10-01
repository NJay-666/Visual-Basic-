Imports System.CodeDom.Compiler
Imports System.Net.Security

Public Class Form1
    Dim rnd As New Random()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '55
        Dim a, b As Integer
        For i As Integer = 1 To 3
            a = Val(InputBox("請輸入第一個數"))
            b = Val(InputBox("請輸入第二個數"))
            TextBox1.Text = TextBox1.Text & sum(a, b) & vbCrLf
        Next
    End Sub
    Function sum(ByVal a As Integer, ByVal b As Integer) As Integer
        sum = a + b
        Return sum
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '56
        Dim a, b, h As Double
        a = Val(InputBox("請輸入梯形的上底"))
        b = Val(InputBox("請輸入梯形的下底"))
        h = Val(InputBox("請輸入梯形的高"))
        TextBox2.Text = "面積為" & area(a, b, h)
    End Sub
    Function area(ByVal a As Double, ByVal b As Double, ByVal h As Double) As Double
        area = (a + b) * h / 2
        Return area
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '57
        For i As Integer = 1 To 10
            TextBox3.Text = TextBox3.Text & i & "是" & check(i) & vbCrLf
        Next
    End Sub
    Function check(ByVal n As Integer) As String
        If n Mod 2 = 0 Then
            check = "偶數"
        Else
            check = "奇數"
        End If
        Return check
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '58
        Dim hours As Double = Val(InputBox("請輸入工作時數"))
        Dim rate As Integer = Val(InputBox("請輸入時薪"))
        TextBox4.Text = calculatepay(hours, rate)
    End Sub
    Function calculatepay(ByVal hours As Double, ByVal rate As Integer) As Double
        If hours > 40 Then
            calculatepay = 40 * rate + (hours - 40) * rate * 1.5
        Else
            calculatepay = hours * rate
        End If
        Return calculatepay
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '59
        Dim a As Integer = Val(InputBox("第一數"))
        Dim b As Integer = Val(InputBox("第二數"))
        TextBox5.Text = TextBox5.Text & Math.Abs(getabsolutedufference(a, b))
    End Sub
    Function getabsolutedufference(ByVal a As Integer, ByVal b As Integer) As Integer
        getabsolutedufference = a - b
        Return getabsolutedufference
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '60
        Dim a As Double = Val(InputBox("第一數"))
        Dim b As Double = Val(InputBox("第二數"))
        Dim c As Double = Val(InputBox("第三數"))
        TextBox6.Text = TextBox6.Text & getaverage(a, b, c)
    End Sub
    Function getaverage(ByVal a As Double, ByVal b As Double, ByVal c As Double) As Double
        getaverage = (a + b + c) / 3
        Return getaverage
    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '62
        Dim total As Integer = Val(InputBox("請輸入金額"))
        TextBox7.Text = TextBox7.Text & getdiscountedprice(total)
    End Sub
    Function getdiscountedprice(ByVal total As Integer) As Double
        Select Case total
            Case >= 1000
                getdiscountedprice = total * 0.9
            Case >= 3000
                getdiscountedprice = total * 0.8
            Case >= 5000
                getdiscountedprice = total * 0.75
            Case Else
                getdiscountedprice = total
        End Select
        Return getdiscountedprice
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '63
        Dim distance As Double = Val(InputBox("請輸入計程車里程(公里)"))
        TextBox8.Text = TextBox8.Text & caculatetaxifare(distance)
    End Sub
    Function caculatetaxifare(ByVal distance As Double) As Double
        If distance <= 1.2 Then
            caculatetaxifare = 85
        Else
            caculatetaxifare = Math.Round(((distance - 1.2) / 0.2), 0) * 5 + 85
        End If
        Return caculatetaxifare
    End Function

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '65(題目後面說的保留1位小數好像是題目出錯所以不用)
        For i As Integer = 0 To 100 Step 10
            TextBox9.Text = TextBox9.Text & temp(i) & vbCrLf
        Next
    End Sub
    Function temp(ByVal i As Double) As Double
        temp = i * 9 / 5 + 32
        Return temp
    End Function

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '68
        Dim pos, neg, zero As Integer
        count(pos, neg, zero)
        TextBox10.Text = TextBox10.Text & "正數有" & pos & "個,負數有" & neg & "個,等於零的有" & zero & "個"
    End Sub
    Function count(ByRef pos As Integer, ByRef neg As Integer, ByRef zero As Integer) As Integer
        Dim arr(5) As Integer
        For i As Integer = 0 To 5
            arr(i) = rnd.Next(-10, 11)
            If arr(i) > 0 Then
                pos += 1
            ElseIf arr(i) < 0 Then
                neg += 1
            Else
                zero += 1
            End If
        Next
    End Function

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '69
        Dim arr() As Integer = {3, 7, 2, 9, 4}
        TextBox11.Text = TextBox11.Text & "陣列{3,7,2,9,4}總和為" & sum(arr) & ",平均為" & avg(arr).ToString("f2")
    End Sub
    Function sum(ByVal arr() As Integer) As Integer
        For i As Integer = 0 To 4
            sum += arr(i)
        Next
        Return sum
    End Function
    Function avg(ByVal arr() As Integer) As Double
        avg = sum(arr) / 5
        Return avg
    End Function

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '70
        Dim con As Integer = 0
        Dim opp As Double
        For i As Integer = 1 To 6
            For j As Integer = 1 To 6
                If ismatchcondition(i, j) Then
                    con += 1
                    TextBox12.Text = TextBox12.Text & "紅:" & i & "藍:" & j & "," & i & "x" & j & "=" & i * j & "," & i & "+" & j & "=" & i + j & vbCrLf
                End If
            Next
        Next
        opp = con / 36 * 100
        TextBox12.Text = TextBox12.Text & "總數為" & con & ",機率百分比為" & opp.ToString("F2")
    End Sub
    Function ismatchcondition(ByVal i As Integer, ByVal j As Integer) As Boolean
        Dim con1 As Boolean = (i * j > 15)
        Dim con2 As Boolean = ((i + j) Mod 2 = 0)
        If con1 And con2 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
