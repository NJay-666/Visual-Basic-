Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim range(9, 9) As Integer, num As Integer = 1
        For i As Integer = 0 To 9
            For j As Integer = 0 To 9
                range(i, j) = num
                num = num + 1
                TextBox3.Text = TextBox3.Text & range(i, j)
            Next
        Next

    End Sub
End Class
