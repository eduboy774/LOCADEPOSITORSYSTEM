Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class AccountManagementfm
    Private Sub btnsendmenewpasswd_Click(sender As Object, e As EventArgs) Handles btnsendmenewpasswd.Click
        Dim connectionString As String
        connectionString = "Data Source=DESKTOP-OE7KSS5\SQLEXPRESS;Initial Catalog=LOCALDEPOSITSYSTEM;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()
            Dim sqlRetrieve As String
            sqlRetrieve = "select * from ibtable where loginId='admin'"
            Dim sqlUpdate As String
            sqlUpdate = "UPDATE ibtable set password='" & txtnewpassword.Text & "' where id ='1'"
            Dim cmd1 As New SqlCommand(sqlRetrieve, connection)
            Dim cmd2 As New SqlCommand(sqlUpdate, connection)
            Dim dr As SqlDataReader
            dr = cmd1.ExecuteReader
            Dim mayUpdate As Boolean = False
            While dr.Read()
                If txtoldpassword.Text = dr.Item("password").ToString Then
                    mayUpdate = True
                Else
                    MessageBox.Show("Passwords do not match!")
                End If
            End While
            dr.Close()

            If mayUpdate Then
                cmd2.ExecuteNonQuery()
                MessageBox.Show("Updated successfully!")
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("FAIL" & ex.Message)
        End Try
    End Sub

    Private Sub saveChanges_Click(sender As Object, e As EventArgs) Handles saveChanges.Click
        Dim connectionString As String
        connectionString = "Data Source=DESKTOP-OE7KSS5\SQLEXPRESS;Initial Catalog=LOCALDEPOSITSYSTEM;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()
            Dim sql As String
            sql = "UPDATE ibtable SET secQNONE='" & txtfirstQN.Text & "', secANSONE='" & txtFANS.Text & "' ,secQNTwo='" & txtsecondQN.Text & "' , secANSTwo ='" & txtSANS.Text & "', secQNThree ='" & txtthirdQN.Text & "' ,  secANSThree ='" & txtTANS.Text & "' "

            Dim cmd As New SqlCommand(sql, connection)
            cmd.ExecuteNonQuery()
            MessageBox.Show("SUCCESSFULL SAVE CHANGES!")
            txtfirstQN.Text = ""
            txtthirdQN.Text = ""
            txtsecondQN.Text = ""
            txtFANS.Text = ""
            txtSANS.Text = ""
            txtTANS.Text = ""

            'Me.Hide()
            'loginfm.Show()

            connection.Close()
        Catch ex As Exception

            MessageBox.Show("FAIL" & ex.Message)
        End Try
    End Sub
End Class