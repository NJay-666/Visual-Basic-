Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer = 0, a, b, c As Integer
        a = Val(TextBox1.Text) : b = Val(TextBox2.Text) : c = Val(TextBox3.Text)
        For i As Integer = a To b Step c
            sum = sum + i
        Next
        TextBox4.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim start, finish, except, sum As Integer
        start = Val(TextBox5.Text) : finish = Val(TextBox6.Text) : except = Val(TextBox7.Text)
        For i As Integer = start To finish
            If i Mod except = 0 Then
                sum = sum + i
            End If
        Next
        TextBox8.Text = sum
    End Sub
End Class
