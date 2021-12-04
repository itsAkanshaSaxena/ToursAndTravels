Public Class Admin
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = 1234 Then
                Me.Hide()
                TourPackage.Show()
            Else
                MessageBox.Show("Incorrect Password")
            End If
        Catch exp As Exception
            MessageBox.Show("Enter a Password")
        End Try
    End Sub
End Class