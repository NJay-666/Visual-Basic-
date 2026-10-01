Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rnd As New Random()
        Dim fin As Integer = rnd.Next(1, 101)
        Dim guess As Integer
        Do
            guess = Val(InputBox("請輸入一個數字"))
            If guess > 100 Then
                MsgBox("這個數字不在範圍內")
            ElseIf guess > fin Then
                MsgBox("猜小點")
            ElseIf guess < fin Then
                MsgBox("猜大點")
            ElseIf guess = fin Then
                MsgBox("猜中了")
            End If
        Loop Until fin = guess
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        Dim money As Integer = CInt(NumericUpDown1.Value)
        Dim rm As Integer = (1000 - money)
        '500
        Dim m500 As Integer = 0
        Do While rm >= 500
            rm = rm - 500
            m500 = m500 + 1
        Loop
        If m500 > 0 Then
            TextBox1.Text = m500
        End If
        '100
        Dim m100 As Integer = 0
        Do While rm >= 100
            rm = rm - 100
            m100 = m100 + 1
        Loop
        If m100 > 0 Then
            TextBox2.Text = m100
        End If
        '50
        Dim m50 As Integer = 0
        Do While rm >= 50
            rm = rm - 50
            m50 = m50 + 1
        Loop
        If m50 > 0 Then
            TextBox3.Text = m50
        End If
        '10
        Dim m10 As Integer = 0
        Do While rm >= 10
            rm = rm - 10
            m10 = m10 + 1
        Loop
        If m10 > 0 Then
            TextBox4.Text = m10
        End If
        '5
        Dim m5 As Integer = 0
        Do While rm >= 5
            rm = rm - 5
            m5 = m5 + 1
        Loop
        If m5 > 0 Then
            TextBox5.Text = m5
        End If
        '1
        Dim m1 As Integer = 0
        Do While rm >= 1
            rm = rm - 1
            m1 = m1 + 1
        Loop
        If m1 > 0 Then
            TextBox6.Text = m1
        End If
    End Sub
End Class
