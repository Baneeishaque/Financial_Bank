Imports System.Data.SqlClient

Public Class Home

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ACCOUNT.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox2.Text.Equals("") Then
            MsgBox("invalid input")
        ElseIf TextBox3.Text.Equals("") Then
            MsgBox("invalid input")
        Else

            Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Projects\Development_Laboratory\Visual_Studio\2008\banking\banking\banking.mdf;Integrated Security=True;User Instance=True")
            Dim mycmd = con.CreateCommand
            Dim reader As SqlDataReader
            Dim dt = New DataTable()
            Dim da = New SqlDataAdapter("select amount from bankdb where account=" + TextBox2.Text + "", con)
            Dim am As Double
            Dim bal As Double
            Dim todaysdate As String = String.Format("dd-MM-yyyy", DateTime.Now)

            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MsgBox("Invalid Account")
            Else

                mycmd.CommandText = "select amount from bankdb where account=" + TextBox2.Text + ""
                con.Open()
                reader = mycmd.ExecuteReader()

                Do While reader.Read()
                    am = Convert.ToDouble(reader.GetString(0))
                Loop

                reader.Close()
                bal = am + Convert.ToDouble(TextBox3.Text)
                Label4.Text = bal
                mycmd.CommandText = "UPDATE    bankdb set amount = " + Label4.Text + " WHERE (account = " + TextBox2.Text + ")"

                mycmd.ExecuteNonQuery()

                mycmd.CommandText = "INSERT INTO transactions (date, particulars)VALUES ('" + todaysdate + "','" + "Deposit By Account No. " + TextBox2.Text + " Amount " + TextBox3.Text + "')"
                mycmd.ExecuteNonQuery()


                Label4.Show()
                Label1.Show()



            End If
        End If

        


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox2.Text.Equals("") Then
            MsgBox("invalid input")
        ElseIf TextBox3.Text.Equals("") Then
            MsgBox("invalid input")
        Else
            Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Projects\Development_Laboratory\Visual_Studio\2008\banking\banking\banking.mdf;Integrated Security=True;User Instance=True")
            Dim mycmd = con.CreateCommand
            Dim reader As SqlDataReader
            Dim dt = New DataTable()
            Dim da = New SqlDataAdapter("select amount from bankdb where account=" + TextBox2.Text + "", con)
            Dim am As Double
            Dim bal As Double
            Dim todaysdate As String = String.Format("dd-MM-yyyy", DateTime.Now)

            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MsgBox("Invalid Account")
            Else

                mycmd.CommandText = "select amount from bankdb where account=" + TextBox2.Text + ""
                con.Open()
                reader = mycmd.ExecuteReader()

                Do While reader.Read()
                    am = Convert.ToDouble(reader.GetString(0))
                Loop

                reader.Close()
                bal = am - Convert.ToDouble(TextBox3.Text)
                Label4.Text = bal
                mycmd.CommandText = "UPDATE    bankdb set amount = " + Label4.Text + " WHERE (account = " + TextBox2.Text + ")"

                mycmd.ExecuteNonQuery()

                mycmd.CommandText = "INSERT INTO transactions (date, particulars)VALUES ('" + todaysdate + "','" + "Withdraw By Account No. " + TextBox2.Text + " Amount " + TextBox3.Text + "')"
                mycmd.ExecuteNonQuery()


                Label4.Show()
                Label1.Show()



            End If
        End If

       




    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        TextBox2.Text = ""
        TextBox3.Text = ""

        Label1.Hide()
        Label4.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox2.Text.Equals("") Then
            MsgBox("invalid input")
        Else
            Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Projects\Development_Laboratory\Visual_Studio\2008\banking\banking\banking.mdf;Integrated Security=True;User Instance=True")
            Dim mycmd = con.CreateCommand
            Dim reader As SqlDataReader
            Dim dt = New DataTable()
            Dim da = New SqlDataAdapter("select amount from bankdb where account=" + TextBox2.Text + "", con)
            Dim am As Double

            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MsgBox("Invalid Account")
            Else

                mycmd.CommandText = "select amount from bankdb where account=" + TextBox2.Text + ""
                con.Open()
                reader = mycmd.ExecuteReader()

                Do While reader.Read()
                    am = Convert.ToDouble(reader.GetString(0))
                Loop
                MsgBox("Balance : " + am.ToString())
                reader.Close()
                


            End If
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox2.Text.Equals("") Then
            MsgBox("invalid input")
        Else
            Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Projects\Development_Laboratory\Visual_Studio\2008\banking\banking\banking.mdf;Integrated Security=True;User Instance=True")
            Dim mycmd = con.CreateCommand

            Dim dt = New DataTable()
            Dim da = New SqlDataAdapter("select amount from bankdb where account=" + TextBox2.Text + "", con)


            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MsgBox("Invalid Account")
            Else

                con.Open()
                mycmd.CommandText = "DELETE FROM bankdb where account='" + TextBox2.Text + "'"
                mycmd.ExecuteNonQuery()

                MsgBox("Successfully Deleted")



            End If
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Transactions.Show()
        Me.Hide()
    End Sub
End Class
