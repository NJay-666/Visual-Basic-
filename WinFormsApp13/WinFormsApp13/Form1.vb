Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rnd As New Random()
        Dim num As Integer = rnd.Next(1, 101)
        Dim asnum As Integer
        Dim i As Integer = 5
        Do
            asnum = Val(InputBox("請輸入一個數字，剩餘" & i & "次"))
            If (asnum > num) Then
                MsgBox("猜小一點")
            ElseIf (asnum < num) Then
                MsgBox("猜大一點")
            Else
                MsgBox("答對了")
            End If
            i = i - 1
        Loop While (num <> asnum) And (i <> 0)
        If i = 0 Then
            MsgBox("沒猜中")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For i As Integer = 1 To 3
            For j As Integer = i - 1 To 1
                TextBox1.Text = TextBox1.Text & "   "
            Next
            For j As Integer = 1 To i * 3 - 2
                TextBox1.Text = TextBox1.Text & "*"
            Next
            For j As Integer = i - 1 To 1
                TextBox1.Text = TextBox1.Text & "     "
            Next
            For j As Integer = 1 To i * 3 - 2
                TextBox1.Text = TextBox1.Text & "*"
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
        For i As Integer = 2 To 1 Step -1
            For j As Integer = i - 1 To 1
                TextBox1.Text = TextBox1.Text & "   "
            Next
            For j As Integer = 1 To i * 3 - 2
                TextBox1.Text = TextBox1.Text & "*"
            Next
            For j As Integer = i - 1 To 1
                TextBox1.Text = TextBox1.Text & "     "
            Next
            For j As Integer = 1 To i * 3 - 2
                TextBox1.Text = TextBox1.Text & "*"
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 1 To 10
            For j As Integer = 1 To 10
                TextBox2.Text = TextBox2.Text & i & "x" & j & "=" & i * j & vbCrLf
            Next
        Next
    End Sub
End Class
