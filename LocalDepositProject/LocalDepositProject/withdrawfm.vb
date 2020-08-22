Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class withdrawfm
    Private Sub txtclientsecondname_TextChanged(sender As Object, e As EventArgs) Handles txtclientsecondname1.TextChanged

    End Sub

    Private Sub btnwithdrawback_Click(sender As Object, e As EventArgs) Handles btnwithdrawback.Click
        Me.Hide()
        landpage.Show()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        lblexchangerate.Text = txtexchangerate.Text

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        txtloginId1.Text = ""
        txtexchangerate.Text = ""
        txtamountWithdraw1.Text = ""
        txtclientfirstname1.Text = ""
        txtclientsecondname1.Text = ""
        lblresutWithdraw1.Text = ""

        lblresult2Withdraw1.Text = ""
        lblcomissionWithdraw.Text = ""
    End Sub

    Private Sub btnprocess_Click(sender As Object, e As EventArgs) Handles btnprocess.Click


        Dim value As Double
            value = txtamountWithdraw1.Text / lblexchangerate.Text
            lblresutWithdraw1.Text = value

            Dim commision As Double
            If (lblresutWithdraw1.Text < 10) Then
                commision = (txtamountWithdraw1.Text - txtexchangerate.Text)
                lblresult2Withdraw1.Text = txtamountWithdraw1.Text - commision
                lblcomissionWithdraw.Text = commision
            ElseIf (lblresutWithdraw1.Text >= 10) Then
                commision = (txtamountWithdraw1.Text * 0.07)
                lblresult2Withdraw1.Text = txtamountWithdraw1.Text - commision
                lblcomissionWithdraw.Text = commision
            End If
           
            Dim connectionString As String
            connectionString = "Data Source=DESKTOP-OE7KSS5\SQLEXPRESS;Initial Catalog=LOCALDEPOSITSYSTEM;Integrated Security=True"
            Dim conn As New SqlConnection(connectionString)
            Dim sql As String
        Try

            conn.Open()
            sql = " INSERT INTO WITHDRAW VALUES('" & txtloginId1.Text & "','" & txtclientfirstname1.Text & "','" & txtclientsecondname1.Text & "','" & txtamountWithdraw1.Text & "','" & txtphoneNumber1.Text & "','" & txtemailaddress1.Text & "','" & lblresutWithdraw1.Text & "','" & lblcomissionWithdraw.Text & "')"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            conn.Close()

        Catch ex As Exception

            MsgBox("ERROR! ", MsgBoxStyle.Information, "MESSAGE INFORMATION")

        End Try


    End Sub

End Class