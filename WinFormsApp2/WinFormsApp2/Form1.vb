Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim as1, as2, as3 As String, flag As Integer = 0
        MsgBox("有三次機會可以輸入密碼", vbOKOnly, "測試密碼是否正確")
        For i As Integer = 1 To 3
            If i = 1 Then
                as1 = InputBox("請輸入密碼(剩餘三次)")
            ElseIf i = 2 Then
                as2 = InputBox("請輸入密碼(剩餘二次)")
            ElseIf i = 3 Then
                as3 = InputBox("請輸入密碼(剩餘一次)")
            End If
        Next
        If as1 = "vb2026" Then
            flag = 1
        ElseIf as2 = "vb2026" Then
            flag = 1
        ElseIf as3 = "vb2026" Then
            flag = 1
        End If
        Select Case flag
            Case = 0
                MsgBox("密碼錯誤")
            Case = 1
                MsgBox("密碼正確")
        End Select
        Dim gg As New Random()
        Dim num As Integer = gg.Next(1, 101)
        MsgBox(num)
    End Sub
End Class
