Public Class TourPackage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New OleDb.OleDbConnection
        Try
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\Tours&Travels.accdb"
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Insert Into Package (place,stayamount,foodamount,busamount,trainamount,airlinesamount,noofdays,noofnights)values(@p,@s,@f,@b,@t,@a,@d,@n)", conn)
            cmd.Parameters.AddWithValue("@p", TextBox2.Text)
            cmd.Parameters.AddWithValue("@s", TextBox5.Text)
            cmd.Parameters.AddWithValue("@f", TextBox6.Text)
            cmd.Parameters.AddWithValue("@b", TextBox7.Text)
            cmd.Parameters.AddWithValue("@t", TextBox8.Text)
            cmd.Parameters.AddWithValue("@a", TextBox9.Text)
            cmd.Parameters.AddWithValue("@d", TextBox3.Text)
            cmd.Parameters.AddWithValue("@n", TextBox4.Text)
            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Record Inserted")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Booking.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Userdetail.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    Private Sub PackageBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackageBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PackageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Tours_TravelsDataSet)

    End Sub

    Private Sub TourPackage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Tours_TravelsDataSet.Package' table. You can move, or remove it, as needed.
        Me.PackageTableAdapter.Fill(Me._Tours_TravelsDataSet.Package)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class