Imports System.Data.OleDb
Public Class Booknow

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pro As String
        Dim connstring As String
        Dim command As String
        Dim myconn As OleDbConnection = New OleDbConnection
        Try
            pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\Tours&Travels.accdb"
            connstring = pro
            myconn.ConnectionString = connstring
            myconn.Open()
            command = "insert into booking([name],[pid],[travel],[date])values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(command, myconn)
            cmd.Parameters.Add(New OleDbParameter("name", CType(TextBox2.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("pid", CType(TextBox3.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("travel", CType(ComboBox1.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("date", CType(DateTimePicker1.Text, String)))

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Booking Successful")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
    End Sub
End Class