Imports System.Data.OleDb
Public Class Registration

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pro As String
        Dim connstring As String
        Dim command As String
        Dim myconn As OleDbConnection = New OleDbConnection
        Try
            pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\Tours&Travels.accdb"
            connstring = pro
            myconn.ConnectionString = connstring
            myconn.Open()
            command = "insert into client([name],[phoneno],[email],[password])values('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(command, myconn)
            cmd.Parameters.Add(New OleDbParameter("name", CType(TextBox1.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("phoneno", CType(TextBox3.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("email", CType(TextBox4.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("password", CType(TextBox2.Text, String)))

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Registered")
                User.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class