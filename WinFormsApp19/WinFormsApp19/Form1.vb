Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num() As Integer = {48, 60, 301, 600, 234}
        Dim numrange(4) As Double
        For i = 0 To 4
            numrange(i) = num(i) / 30
            numrange(i) = Math.Ceiling(numrange(i))
            If (numrange(i) * 20) > 200 Then
                numrange(i) = 200
            Else
                numrange(i) = numrange(i) * 20
            End If
            TextBox1.Text = TextBox1.Text & "第" & i + 1 & "臺車的停車費為" & numrange(i) & "元" & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        Dim num(9) As Integer
        Dim rnd As New Random()
        Dim n As Integer = Val(InputBox("請輸入範圍"))
        num(0) = rnd.Next(1, n + 1)
        TextBox2.Text = TextBox2.Text & num(0) & " ,"
        Dim finum As Integer = num(0)
        For i = 1 To 9
            num(i) = rnd.Next(1, n + 1)
            If num(i) < finum Then
                finum = num(i)
            End If
            TextBox2.Text = TextBox2.Text & num(i) & " ,"
        Next
        TextBox2.Text = TextBox2.Text & "最小數字為" & finum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rnd As New Random()
        Dim score(9) As Integer
        For i As Integer = 0 To 9
            score(i) = rnd.Next(0, 100)
        Next
        Dim bigscore As Integer = score(0)
        For i As Integer = 0 To 9
            TextBox3.Text = TextBox3.Text & score(i) & " ,"
            If score(i) > bigscore Then
                bigscore = score(i)
            End If
        Next
        TextBox3.Text = TextBox3.Text & "max=" & bigscore
    End Sub
End Class
