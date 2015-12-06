Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2 As Integer
        n1 = num1.Text
        n2 = num2.Text

        Res.Text = Val(n1 + n2)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n1, n2 As Integer
        n1 = num1.Text
        n2 = num2.Text

        Res.Text = Val(n1 - n2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n1, n2 As Integer
        n1 = num1.Text
        n2 = num2.Text

        Res.Text = Val(n1 * n2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim n1, n2 As Integer
        n1 = num1.Text
        n2 = num2.Text

        Res.Text = Val(n1 / n2)
    End Sub
End Class
