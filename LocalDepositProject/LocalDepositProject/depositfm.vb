Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class depositfm


    Private Sub Btnprocess_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        Dim connectionString As String
        connectionString = "Data Source=DESKTOP-OE7KSS5\SQLEXPRESS;Initial Catalog=LOCALDEPOSITSYSTEM;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()


            lblresult.Text = (txtamountdeposit.Text / txtexchangerate.Text)
            Dim commision As Double
            If (lblresult.Text < 10) Then
                commision = (txtamountdeposit.Text - txtexchangerate.Text)
                lblresult2.Text = txtamountdeposit.Text - commision
                lblcomission.Text = commision
            ElseIf (lblresult.Text >= 10) Then
                commision = (txtamountdeposit.Text * 0.07)
                lblresult2.Text = txtamountdeposit.Text - commision
                lblcomission.Text = commision
            End If
            lblresult.Text = (txtamountdeposit.Text / txtexchangerate.Text)
            Dim sql As String
            sql = " INSERT INTO DEPOSIT VALUES('" & txtloginId.Text & "','" & txtclientfirstname.Text & "','" & txtclientsecondname.Text & "','" & txtamountdeposit.Text & "','" & txtphoneNumber.Text & "','" & txtemailaddress.Text & "','" & lblresult.Text & "','" & lblcomission.Text & "')"
            Dim cmd As New SqlCommand(sql, connection)
            cmd.ExecuteNonQuery()
            '    MessageBox.Show("SUCCESSFUll")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("You have to fill the required filled")
        End Try

    End Sub

    Private Sub Depositfm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        landpage.Show()
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        lblresult.Text = ""
        lblresult2.Text = ""
        txtamountdeposit.Text = ""
        txtemailaddress.Text = ""
        txtloginId.Text = ""
        txtphoneNumber.Text = ""
        txtclientsecondname.Text = ""
        txtclientfirstname.Text = ""
        lblcomission.Text = ""
        txtexchangerate.Text = ""
    End Sub

    Private Sub Lbltitleexchagerate_Click(sender As Object, e As EventArgs) Handles lbltitleexchagerate.Click

    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        lblexchangerate.Text = txtexchangerate.Text


    End Sub

    Private Sub lblclientfirstName_Click(sender As Object, e As EventArgs) Handles lblclientfirstName.Click

    End Sub

    Private Sub lblamountDeposit_Click(sender As Object, e As EventArgs) Handles lblamountDeposit.Click

    End Sub

    Private Sub lblsecondName_Click(sender As Object, e As EventArgs) Handles lblsecondName.Click

    End Sub

    Private Sub lblloginId_Click(sender As Object, e As EventArgs) Handles lblloginId.Click

    End Sub
End Class