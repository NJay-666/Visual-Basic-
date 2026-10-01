Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As UInteger, nfin As UInteger = 1
        n = Val(TextBox1.Text)
        For i As Integer = 1 To n Step 1
            nfin = nfin * i
        Next
        TextBox2.Text = nfin
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As Integer, nfin As Integer
        n = Val(TextBox3.Text)
        For i = 1 To n Step 1
            nfin = nfin + i ^ 2
        Next
        TextBox4.Text = nfin
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n As Integer, nfin As Double
        n = Val(TextBox5.Text)
        For i = 1 To n Step 1
            nfin = nfin + (1 / (i ^ 2))
        Next
        TextBox6.Text = nfin
    End Sub
End Class
