Imports System.Data.OleDb
Imports System.Data
Public Class User

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Registration.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New OleDbConnection(My.Settings.Tours_TravelsConnectionString)
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Enter credentials", MsgBoxStyle.Exclamation)
        Else
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*)from client where name=?and password=?", conn)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBox2.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If (count > 0) Then
                destination.Show()
                MsgBox("Login successful", MsgBoxStyle.Information)
                Me.Hide()
            Else
                MsgBox("Account not found; Check Credentials", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class