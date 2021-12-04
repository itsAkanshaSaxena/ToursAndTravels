Public Class Userdetail

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        TourPackage.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New OleDb.OleDbConnection
        Try
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\Tours&Travels.accdb"
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("select cid,phoneno,email from client where name=@na", conn)
            cmd.Parameters.AddWithValue("@na", TextBox1.Text)
            Dim datareader As OleDb.OleDbDataReader
            datareader = cmd.ExecuteReader()
            If datareader.Read Then
                TextBox2.Text = datareader(0)
                TextBox3.Text = datareader(1)
                TextBox4.Text = datareader(2)
                
            End If
            conn.Close()
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        End Try
    End Sub
End Class