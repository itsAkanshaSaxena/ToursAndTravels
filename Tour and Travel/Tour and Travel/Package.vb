Public Class Package
   
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

       Dim conn As New OleDb.OleDbConnection
        Try
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\Tours&Travels.accdb"
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("select stayamount,foodamount,busamount,trainamount,airlinesamount,noofdays,noofnights from package where place=@p", conn)
            cmd.Parameters.AddWithValue("@p", TextBox1.Text)
            Dim datareader As OleDb.OleDbDataReader
            datareader = cmd.ExecuteReader()
            If datareader.Read Then
                TextBox2.Text = datareader(0)
                TextBox3.Text = datareader(1)
                TextBox4.Text = datareader(2)
                TextBox5.Text = datareader(3)
                TextBox6.Text = datareader(4)
                TextBox7.Text = datareader(5)
                TextBox8.Text = datareader(6)
            End If
            conn.Close()
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        End Try
    End Sub

    
   
    Private Sub PackageBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackageBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PackageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Tours_TravelsDataSet)

    End Sub

    Private Sub Package_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Tours_TravelsDataSet.Package' table. You can move, or remove it, as needed.
        Me.PackageTableAdapter.Fill(Me._Tours_TravelsDataSet.Package)

    End Sub

    
    
   
End Class