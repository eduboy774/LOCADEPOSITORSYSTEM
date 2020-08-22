Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class historyfm
    Private Sub btnhistoryback_Click(sender As Object, e As EventArgs)
        Me.Hide()
        landpage.Show()
    End Sub

    Private Sub btnhistoryview_Click(sender As Object, e As EventArgs) Handles btnhistoryview.Click
        Try
            Dim connectionString As String
            connectionString = "Data Source=DESKTOP-OE7KSS5\SQLEXPRESS;Initial Catalog=LOCALDEPOSITSYSTEM;Integrated Security=True"
            Dim connection As New SqlConnection(connectionString)


            connection.Open()
            Dim sql As String
            sql = "SELECT *FROM DEPOSIT"

            Dim da As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            da.Fill(ds, "DEPOSIT")
            da.Fill(ds, "WITHDRAW")
            'MessageBox.Show("THE HISTORY OF INFORMATION IN DEPOSIT TRANSACTION ")
            DataGridView1.DataSource = ds.Tables("DEPOSIT")
            'DataGridView1.DataSource = ds.Tables("WITHDRAW")


            connection.Close()
        Catch ex As Exception
            MessageBox.Show("faided")
        End Try
    End Sub

    Private Sub historyfm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnhistorywithdraw_Click(sender As Object, e As EventArgs) Handles btnhistorywithdraw.Click
        Try
            Dim connectionString As String
            connectionString = "Data Source=DESKTOP-OE7KSS5\SQLEXPRESS;Initial Catalog=LOCALDEPOSITSYSTEM;Integrated Security=True"
            Dim connection As New SqlConnection(connectionString)


            connection.Open()
            Dim sql As String
            sql = "SELECT *FROM WITHDRAW"

            Dim da As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            ' da.Fill(ds, "DEPOSIT")
            da.Fill(ds, "WITHDRAW")
            'MessageBox.Show("THE HISTORY OF INFORMATION IN DEPOSIT TRANSACTION ")
            ' DataGridView1.DataSource = ds.Tables("DEPOSIT")
            DataGridView1.DataSource = ds.Tables("WITHDRAW")


            connection.Close()
        Catch ex As Exception
            MessageBox.Show("faided")
        End Try
    End Sub
End Class