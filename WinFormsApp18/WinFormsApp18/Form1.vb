Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f(15) As Integer
        f(0) = 1
        f(1) = 1
        For i = 2 To 15
            f(i) = f(i - 1) + f(i - 2)
        Next
        For i = 0 To 15
            TextBox1.Text = TextBox1.Text & f(i) & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rnd As New Random()
        Dim pz As Integer
        Dim count As Integer = 1
        Dim repeat(48) As Integer
        TextBox2.Text = ""
        Do While count <= 6
            pz = rnd.Next(1, 50)
            If repeat(pz) = 0 Then
                repeat(pz) = 1
                count += 1
                TextBox2.Text = TextBox2.Text & pz & " "
            End If
        Loop
    End Sub
End Class
