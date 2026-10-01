Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = Val(TextBox2.Text), sum As UInteger, i As Integer = 1
        Do Until (sum >= num)
            sum = sum + i * i * i
            i = i + 1
        Loop
        TextBox1.Text = sum
    End Sub
End Class
