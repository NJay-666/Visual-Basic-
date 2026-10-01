Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, fin As Integer, f As String
        num1 = Val(TextBox1.Text) : num2 = Val(TextBox3.Text) : f = TextBox2.Text
        Select Case f
            Case = "+"
                fin = (num1 + num2)
            Case = "-"
                fin = (num1 - num2)
            Case = "*"
                fin = (num1 * num2)
            Case = "/"
                fin = (num1 / num2)
        End Select
        TextBox4.Text = fin
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num As Integer = Val(TextBox5.Text)
        For i = 1 To 9
            TextBox6.Text = TextBox6.Text & num & "x" & i & "=" & num * i & vbCrLf
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num As Integer = Val(TextBox7.Text), bool As Boolean = True, i As Integer = 2
        Do While (bool = True) And (i < num)
            If num Mod i = 0 Then
                bool = False
            End If
            i = i + 1
        Loop
        If bool = True Then
            MsgBox("是質數")
        Else
            MsgBox("不是質數")
        End If
    End Sub
End Class
