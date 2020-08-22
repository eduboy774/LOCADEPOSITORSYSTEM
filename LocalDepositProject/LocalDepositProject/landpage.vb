Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class landpage
    Private Sub Lbllogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        loginfm.Show()
        'Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        'Me.Hide()
        'loginfm.Show()


    End Sub

    Private Sub Landpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.Hide()
        'homefm.Show()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        withdrawfm.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
        homefm.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Me.Close()
        AccountManagementfm.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Me.Close()
        depositfm.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Me.Close()
        historyfm.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PanelSwitch_Paint(sender As Object, e As PaintEventArgs) Handles PanelSwitch.Paint

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)
        swicthpanel(New homefm)
        'homefm.Show()
    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click
        swicthpanel(New depositfm)
        'depositfm.Show()

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        swicthpanel(New withdrawfm)
        ' withdrawfm.Show()

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        swicthpanel(New historyfm)
        'historyfm.Show()

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        swicthpanel(New AccountManagementfm)
        'AccountManagementfm.Show()

    End Sub

    Private Sub lbllogout_Click_1(sender As Object, e As EventArgs) Handles lbllogout.Click

        Dim var As String
        var = MsgBox("ARE YOU SURE YOU WANT TO LOGOUT", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Alert Message !")
        If var = vbYes Then
            Me.Hide()
            loginfm.Show()

        End If

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        loginfm.Show()
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If PanelMenu.Width <= 60 Then
            Me.timer1.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20

        End If
    End Sub

    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        If PanelMenu.Width >= 220 Then
            Me.timer2.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PanelMenu.Width = 220 Then
            timer1.Enabled = True
        Else PanelMenu.Width = 60
            timer2.Enabled = True

        End If
    End Sub
    Private Sub swicthpanel(ByVal formnew As Object)
        If Me.PaneSwitching.Controls.Count > 0 Then
            Me.PaneSwitching.Controls.RemoveAt(0)
        End If
        Dim fn As Form = TryCast(formnew, Form)
        fn.TopLevel = False
        fn.FormBorderStyle = FormBorderStyle.None
        fn.Dock = DockStyle.Fill
        Me.PaneSwitching.Controls.Add(fn)
        Me.PaneSwitching.Tag = fn
        fn.Show()

    End Sub


End Class