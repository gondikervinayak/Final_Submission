Imports System.Data.OleDb


Partial Class RegistrationForm
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("Student.accdb"))

        Try
            Dim cmd As New OleDbCommand("insert into Registration(Fname, Lname) values(@p1, @p2)", conn)
            cmd.Parameters.AddWithValue("p1", TextBox1.Text)
            cmd.Parameters.AddWithValue("p2", TextBox2.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            Button1.Text = "Successfully Registered!"
            TextBox1.Text = ""
            TextBox2.Text = ""
            GridView1.DataBind()

        Catch ex As Exception
            conn.Close()
            MsgBox("Error During Registration")
        End Try
    End Sub
End Class
