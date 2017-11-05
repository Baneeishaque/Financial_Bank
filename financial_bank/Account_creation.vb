
Imports System.Data.SqlClient
Public Class ACCOUNT

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text.Equals("") Then
            MsgBox("invalid input")
        ElseIf TextBox3.Text.Equals("") Then
            MsgBox("invalid input")
        ElseIf TextBox4.Text.Equals("") Then
            MsgBox("invalid input")

        ElseIf TextBox5.Text.Equals("") Then
            MsgBox("invalid input")
        ElseIf TextBox6.Text.Equals("") Then
            MsgBox("invalid input")

        ElseIf TextBox6.Text.Equals("") Then
            MsgBox("invalid input")

        ElseIf TextBox7.Text.Equals("") Then
            MsgBox("invalid input")
        ElseIf TextBox8.Text.Equals("") Then
            MsgBox("invalid input")
        ElseIf TextBox9.Text.Equals("") Then
            MsgBox("invalid input")

        Else


            Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Projects\Development_Laboratory\Visual_Studio\2008\banking\banking\banking.mdf;Integrated Security=True;User Instance=True")
            Dim mycmd = con.CreateCommand

            mycmd.CommandText = "insert into bankdb(name,gender,address,age,fathername,email,mobno,aadharid,account,amount) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "'," + TextBox9.Text + ",0)"
            con.Open()
            mycmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("inserted")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
        End If
    End Sub
End Class