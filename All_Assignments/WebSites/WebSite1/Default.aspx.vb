
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Integer
        num1 = number1.Text
        num2 = number2.Text

        sum.Text = Val(num1 + num2)
    End Sub
End Class
