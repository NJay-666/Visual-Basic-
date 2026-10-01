Imports System.Net.Security

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((TextBox1.Text = "Jay@990111") And (TextBox2.Text = "Jay@aj7bn6pj990111")) Then
            MsgBox("登入成功")
        Else
            MsgBox("登入失敗")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(TextBox3.Text) And Val(TextBox4.Text) And Val(TextBox5.Text) Then
            MsgBox("正三角形")
        Else
            MsgBox("不是正三角形")
        End If
        MsgBox((1 + 4) * 2 - 9 / 3 ^ 2)
    End Sub
End Class
