Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        For i As Integer = 2 To 10000
            sum = 0
            For j As Integer = 1 To i - 1
                If i Mod j = 0 Then
                    sum = sum + j
                End If
            Next
            If sum - i = 0 Then
                TextBox1.Text = TextBox1.Text & i & vbCrLf
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 1 To 4
            For j As Integer = 1 To 4
                If i + j = 5 Then
                    TextBox2.Text = TextBox2.Text & 1
                Else
                    TextBox2.Text = TextBox2.Text & 0
                End If
            Next
            TextBox2.Text = TextBox2.Text & vbCrLf
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rnd As New Random()
        Do
            Dim rnum1 As Integer = rnd.Next(1, 7)
            Dim rnum2 As Integer = rnd.Next(1, 7)
            TextBox4.Text = rnum1
            TextBox5.Text = rnum2
            If rnum1 - rnum2 = 0 Then
                MsgBox("點數相同")
                Exit Do
            End If
        Loop While True

    End Sub
End Class
