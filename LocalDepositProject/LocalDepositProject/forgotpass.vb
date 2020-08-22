Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class forgotpass
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    'Private Sub txtforgotpasswd1_MouseEnter(sender As Object, e As EventArgs) Handles txtforgotpasswd1.MouseEnter
    'If txtforgotpasswd1.Text = "What is your  First Name" Then
    '       txtforgotpasswd1.Text = ""
    '      txtforgotpasswd1.ForeColor = Color.Black()
    'End If
    'End Sub

    'Private Sub txtforgotpasswd1_MouseLeave(sender As Object, e As EventArgs) Handles txtforgotpasswd1.MouseLeave
    'If txtforgotpasswd1.Text = "" Then
    '       txtforgotpasswd1.Text = "What is your  First Name"
    '      txtforgotpasswd1.ForeColor = Color.Blue()
    'End If
    'End Sub

    'Private Sub txtforgotpasswd2_MouseEnter(sender As Object, e As EventArgs) Handles txtforgotpasswd2.MouseEnter
    'If txtforgotpasswd2.Text = "What is your  Second Name" Then
    '     txtforgotpasswd2.Text = ""
    '      txtforgotpasswd2.ForeColor = Color.Black()
    '   End If
    'End Sub

    'Private Sub() txtforgotpasswd2_MouseLeave(sender As Object, e As EventArgs) Handles txtforgotpasswd2.MouseLeave
    'If txtforgotpasswd2.Text = "" Then
    '       txtforgotpasswd2.Text = "What is your  Second Name"
    '       txtforgotpasswd2.ForeColor = Color.Blue()
    'End If
    'End Sub

    ' Private Sub txtforgotpasswd3_MouseEnter(sender As Object, e As EventArgs) Handles txtforgotpasswd3.MouseEnter
    'If txtforgotpasswd3.Text = "What is your  Last Name" Then
    '       txtforgotpasswd3.Text = ""
    '       txtforgotpasswd3.ForeColor = Color.Black()
    'End If
    ' End Sub

    ' Private Sub txtforgotpasswd3_MouseLeave(sender As Object, e As EventArgs) Handles txtforgotpasswd3.MouseLeave
    'If txtforgotpasswd3.Text = "" Then
    '       txtforgotpasswd3.Text = "What is your  Last Name"
    '       txtforgotpasswd3.ForeColor = Color.Blue()
    'End If
    ' End Sub


    Private Sub Lnklblloginagain_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnklblloginagain.LinkClicked
        Me.Hide()
        loginfm.Show()
    End Sub

    Private Sub forgotpass_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String
        connectionString = "Data Source=DESKTOP-OE7KSS5\SQLEXPRESS;Initial Catalog=LOCALDEPOSITSYSTEM;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()

            Dim sql As String
                sql = "select *from ibtable where id='1'"
                Dim cmd As New SqlCommand(sql, connection)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
            While dr.Read()
                qn1.Text = dr.Item("secQNONE").ToString
                qn2.Text = dr.Item("secQNTwo").ToString
                qn3.Text = dr.Item("secQNThree").ToString
            End While
            dr.Close()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("FAILED" & ex.Message)
        End Try
    End Sub



    Private Sub btnsendmenewpasswd_Click(sender As Object, e As EventArgs) Handles btnsendmenewpasswd.Click
        Dim connectionString As String
        connectionString = "Data Source=DESKTOP-OE7KSS5\SQLEXPRESS;Initial Catalog=LOCALDEPOSITSYSTEM;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()
            If txtforgotpasswd1.Text = "" Or txtforgotpasswd2.Text = "" Or txtforgotpasswd3.Text = "" Then
                MsgBox("Please fill all required fields!", MsgBoxStyle.Information, "MESSAGE INFORMATION !")
            Else
                Dim sql As String
                sql = "select *from ibtable where id='1'"
                Dim cmd As New SqlCommand(sql, connection)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read()
                    If txtforgotpasswd1.Text = dr.Item("secANSONE").ToString And txtforgotpasswd2.Text = dr.Item("secANSTwo").ToString And txtforgotpasswd3.Text = dr.Item("secANSThree").ToString Then
                        MessageBox.Show("Your password is " & dr.Item("password"))
                        txtforgotpasswd1.Text = ""
                        txtforgotpasswd2.Text = ""
                        txtforgotpasswd3.Text = ""
                    Else
                        MessageBox.Show("Incorrect answer(s)!")
                    End If
                End While
                dr.Close()
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("FAILED" & ex.Message)
        End Try
    End Sub


End Class