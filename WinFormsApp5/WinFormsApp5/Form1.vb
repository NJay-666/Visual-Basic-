Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Double, z As String
        x = Val(TextBox1.Text) : y = Val(TextBox2.Text)
        If x > 0 Then
            If y > 0 Then
                z = "第一象限"
            ElseIf y < 0 Then
                z = "第四象限"
            Else
                z = "在x軸上"
            End If
        ElseIf x < 0 Then
            If y > 0 Then
                z = "第二象限"
            ElseIf y < 0 Then
                z = "第三象限"
            Else
                z = "在x軸上"
            End If
        ElseIf x = 0 Then
            If y > 0 Or y < 0 Then
                z = "在y軸上"
            Else
                z = "原點"
            End If
        End If
        TextBox3.Text = z
    End Sub
End Class
