Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        Dim score(39) As Integer
        Dim rnd As New Random()
        Dim notpass As Integer = 0
        For i = 0 To 39
            score(i) = rnd.Next(0, 100)
            TextBox1.Text = TextBox1.Text & score(i) & " ,"
            If score(i) < 60 Then
                notpass += 1
            End If
        Next
        TextBox1.Text = TextBox1.Text & "不及格人數為" & notpass
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 1 To 3
            For j As Integer = i - 1 To 1
                TextBox2.Text = TextBox2.Text & " "
            Next
            For j As Integer = 1 To i
                TextBox2.Text = TextBox2.Text & "*"
            Next
            TextBox2.Text = TextBox2.Text & vbCrLf
        Next
        For i As Integer = 2 To 1 Step -1
            For j As Integer = i - 1 To 1
                TextBox2.Text = TextBox2.Text & " "
            Next
            For j As Integer = 1 To i
                TextBox2.Text = TextBox2.Text & "*"
            Next
            TextBox2.Text = TextBox2.Text & vbCrLf
        Next
        For d = 1 To 3
            For i As Integer = 2 To 3
                For j As Integer = i - 1 To 1
                    TextBox2.Text = TextBox2.Text & " "
                Next
                For j As Integer = 1 To i
                    TextBox2.Text = TextBox2.Text & "*"
                Next
                TextBox2.Text = TextBox2.Text & vbCrLf
            Next
            For i As Integer = 2 To 1 Step -1
                For j As Integer = i - 1 To 1
                    TextBox2.Text = TextBox2.Text & " "
                Next
                For j As Integer = 1 To i
                    TextBox2.Text = TextBox2.Text & "*"
                Next
                TextBox2.Text = TextBox2.Text & vbCrLf
            Next
        Next


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim score(9, 2) As Integer
        Dim sumscore(9) As Double
        Dim rnd As New Random()
        For i As Integer = 0 To 9
            TextBox3.Text = TextBox3.Text & "第" & i + 1 & "位同學的成績為"
            For j As Integer = 0 To 2
                score(i, j) = rnd.Next(0, 100)
                TextBox3.Text = TextBox3.Text & score(i, j) & " ,"
            Next
            TextBox3.Text = TextBox3.Text & vbCrLf
        Next
        For i As Integer = 0 To 9
            sumscore(i) = (score(i, 0) + score(i, 1)) * 0.3 + score(i, 2) * 0.4
            TextBox3.Text = TextBox3.Text & "第" & i + 1 & "位同學的總成績為" & sumscore(i) & vbCrLf
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i As Integer = 1 To 5
            For j As Integer = i - 1 To 5
                TextBox4.Text = TextBox4.Text & "   "
            Next
            For j As Integer = 1 To i
                TextBox4.Text = TextBox4.Text & " *"
            Next
            TextBox4.Text = TextBox4.Text & vbCrLf
        Next
    End Sub
End Class
