Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = Val(InputBox("請輸入矩陣長"))
        Dim y As Integer = Val(InputBox("請輸入矩陣寬"))
        Dim z As Integer = Val(InputBox("請輸入矩陣相加數"))
        Dim a(y, x) As Integer
        Dim b(y, x) As Integer
        Dim c(y, x) As Integer
        For i As Integer = 0 To y
            For j As Integer = 0 To x
                a(i, j) = z
                b(i, j) = z
                c(i, j) = a(i, j) + b(i, j)
                TextBox1.Text = TextBox1.Text & c(i, j) & " ,"
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 1 To 4
            For j As Integer = 1 To 4
                If i = j Then
                    TextBox2.Text = TextBox2.Text & "*"
                Else
                    TextBox2.Text = TextBox2.Text & " "
                End If
            Next
            For j As Integer = 1 To 4
                TextBox2.Text = TextBox2.Text & " "
            Next
            For j As Integer = 1 To 4
                If i = j Then
                    TextBox2.Text = TextBox2.Text & "*"
                Else
                    TextBox2.Text = TextBox2.Text & " "
                End If
            Next
            TextBox2.Text = TextBox2.Text & vbCrLf
        Next
        For i As Integer = 3 To -1 Step -1
            For j As Integer = 3 To -1 Step -1
                If i + j = 4 Then
                    TextBox2.Text = TextBox2.Text & "*"
                Else
                    TextBox2.Text = TextBox2.Text & "  "
                End If
            Next
            For j As Integer = 3 To -1
                TextBox2.Text = TextBox2.Text & " "
            Next
            For j As Integer = 3 To -1 Step -1
                If i + j = 4 Then
                    TextBox2.Text = TextBox2.Text & "*"
                Else
                    TextBox2.Text = TextBox2.Text & "  "
                End If
            Next
            TextBox2.Text = TextBox2.Text & vbCrLf
        Next
    End Sub
End Class
