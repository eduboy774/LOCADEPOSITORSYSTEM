Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class loginfm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim connectionString As String
        connectionString = "Data Source=DESKTOP-OE7KSS5\SQLEXPRESS;Initial Catalog=LOCALDEPOSITSYSTEM;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()



            If isFilled() Then

                Dim sql As String
                sql = "SELECT * FROM ibtable WHERE loginId='" & txtusername.Text & "' and password = '" & txtpasswd.Text & "'"
                Dim cmd As New SqlCommand(sql, connection)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    txtusername.Text = ""
                    txtpasswd.Text = ""

                    landpage.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("WRONG  USERNAME OR PASSWORD TRY AGAIN ")
                    txtusername.Text = ""
                    txtpasswd.Text = ""
                End If


            End If
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("ERROR")
        End Try

    End Sub

    Private Function isFilled() As Boolean
        If txtusername.Text = "" And txtpasswd.Text = "" Then
            MessageBox.Show(" Login Id and Password cant be empty !")
            Return False
        ElseIf txtusername.Text = "" Then
            MessageBox.Show(" Login Id  cant be empty !")
            Return False
        ElseIf txtpasswd.Text = "" Then
            MessageBox.Show(" Password  cant be empty !")
            Return False
        Else
            Return True

        End If


    End Function



    Private Sub Linklblpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblpassword.LinkClicked
        Me.Hide()
        forgotpass.Show()
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub txtusername_MouseEnter(sender As Object, e As EventArgs) Handles txtusername.MouseEnter
        'If txtusername.Text = "LoginId" Then
        'txtusername.Text = ""
        'txtusername.ForeColor = Color.Black()
        'End If
    End Sub

    Private Sub txtusername_MouseLeave(sender As Object, e As EventArgs) Handles txtusername.MouseLeave
        ' If txtusername.Text = "" Then
        'txtusername.Text = "LoginId"
        'txtusername.BackColor = Color.White()
        'End If
    End Sub

    Private Sub txtpasswd_MouseEnter(sender As Object, e As EventArgs) Handles txtpasswd.MouseEnter
        ' If txtpasswd.Text = "Password" Then
        'txtpasswd.Text = ""
        'txtpasswd.ForeColor = Color.Black()
        'End If
    End Sub

    Private Sub txtpasswd_MouseLeave(sender As Object, e As EventArgs) Handles txtpasswd.MouseLeave
        ' If txtpasswd.Text = "" Then
        'txtpasswd.Text = "Password"
        'txtpasswd.BackColor = Color.White
        'End If
    End Sub
End Class
