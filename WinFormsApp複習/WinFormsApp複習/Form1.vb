Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 6
            For j = 1 To i
                TextBox1.Text &= j
            Next
            TextBox1.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 1 To 5
            For j = i - 1 To 3
                TextBox2.Text &= "  "
            Next
            For j = 1 To i
                TextBox2.Text &= "*"
            Next
            TextBox2.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = ""
        Dim x As Integer = Val(InputBox("輸入"))
        Dim t(x, x) As Integer
        For i As Integer = 0 To x
            t(i, 0) = 1
            t(i, i) = 1
        Next
        For i As Integer = 2 To x
            For j = 1 To i - 1
                t(i, j) = t(i - 1, j - 1) + t(i - 1, j)
            Next
        Next
        For i As Integer = 0 To x
            For j As Integer = 0 To i
                TextBox3.Text &= t(i, j) & vbTab
            Next
            TextBox3.Text &= vbCrLf
        Next
    End Sub
End Class
