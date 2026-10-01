Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rnd As New Random()
        Dim a(5, 30), i, j As Double
        Dim listbox() As ListBox = New ListBox() {ListBox1, ListBox2, ListBox3, ListBox4, ListBox5}
        For i = 1 To 30
            a(1, i) = i
            ListBox1.Items.Add(a(1, i))
        Next
        For j = 2 To 5
            For i = 1 To 30
                a(j, i) = rnd.Next(1, 101)
                listbox(j).Items.Add(a(j, i))
            Next
        Next
        '總分
        For i = 1 To 30
            a(4, i) = a(2, i) + a(3, i)
            ListBox4.Items.Add(a(4, i))
        Next
        '平均
        For i = 1 To 30
            a(5, i) = a(4, i) / 2
            ListBox5.Items.Add(a(5, i))
        Next
    End Sub
End Class
