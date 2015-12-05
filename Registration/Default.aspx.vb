Imports System.Data.OleDb
Imports System.Data.Sql


Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("Database/Student.accdb"))


        Try
            Dim cmd As New OleDbCommand("insert into Registration(FNAME, LNAME) values(@a1, @a2)", con)
            cmd.Parameters.AddWithValue("a1", Fname.Text)
            cmd.Parameters.AddWithValue("a2", Lname.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Registration Request of " + Fname.Text + " " + Lname.Text + " has been received.")
            Fname.Text = ""
            Lname.Text = ""
            GridView1.DataBind()

        Catch ex As Exception
            con.Close()
            MsgBox("Error during Registration.")
        End Try
    End Sub


    Protected Sub SqlDataSource1_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting

    End Sub
End Class
