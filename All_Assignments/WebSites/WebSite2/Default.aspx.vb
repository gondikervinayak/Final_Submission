
Partial Class _Default
    Inherits System.Web.UI.Page

    Dim sex As String
    Dim color As String
    Dim date11 As String


    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        sex = "Man"
    End Sub
    Protected Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        sex = "Woman"
    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        color = color + ", Brown"
    End Sub
    Protected Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        color = color + ", Black"
    End Sub
    Protected Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        color = color + ", Green"
    End Sub

    Protected Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        color = color + ", Blue"
    End Sub

    Protected Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        color = color + ", Pink"
    End Sub
    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        date11 = Calendar1.SelectedDate.Date
        TextBox2.Text = date11
    End Sub
    

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MsgBox("My Name is " + TextBox1.Text + " My age is " + DropDownList1.Text + " I am " + sex + " My Age is " + TextBox2.Text + " My Favorite Color is " + color)
        Catch ex As Exception

        End Try

        Response.Redirect(HttpContext.Current.Request.Url.ToString())
    End Sub

    
    
    
    
    
    
    
End Class
