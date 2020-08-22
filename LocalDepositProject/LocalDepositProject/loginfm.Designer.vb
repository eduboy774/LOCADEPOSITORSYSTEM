<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginfm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginfm))
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.linklblpassword = New System.Windows.Forms.LinkLabel()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpasswd = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.pnlinside = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnltop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlinside.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pnltop.Controls.Add(Me.PictureBox2)
        Me.pnltop.Controls.Add(Me.PictureBox1)
        Me.pnltop.Controls.Add(Me.linklblpassword)
        Me.pnltop.Controls.Add(Me.btnlogin)
        Me.pnltop.Controls.Add(Me.Label3)
        Me.pnltop.Controls.Add(Me.Label2)
        Me.pnltop.Controls.Add(Me.txtpasswd)
        Me.pnltop.Controls.Add(Me.txtusername)
        Me.pnltop.Controls.Add(Me.pnlinside)
        Me.pnltop.Location = New System.Drawing.Point(80, 1)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(301, 235)
        Me.pnltop.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'linklblpassword
        '
        Me.linklblpassword.AutoSize = True
        Me.linklblpassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.linklblpassword.LinkColor = System.Drawing.SystemColors.Highlight
        Me.linklblpassword.Location = New System.Drawing.Point(146, 198)
        Me.linklblpassword.Name = "linklblpassword"
        Me.linklblpassword.Size = New System.Drawing.Size(122, 19)
        Me.linklblpassword.TabIndex = 7
        Me.linklblpassword.TabStop = True
        Me.linklblpassword.Text = "I forgot password"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnlogin.Location = New System.Drawing.Point(87, 169)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(181, 26)
        Me.btnlogin.TabIndex = 6
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(74, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 1)
        Me.Label3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(73, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 1)
        Me.Label2.TabIndex = 4
        '
        'txtpasswd
        '
        Me.txtpasswd.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtpasswd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpasswd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpasswd.Location = New System.Drawing.Point(77, 127)
        Me.txtpasswd.Multiline = True
        Me.txtpasswd.Name = "txtpasswd"
        Me.txtpasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpasswd.Size = New System.Drawing.Size(173, 26)
        Me.txtpasswd.TabIndex = 2
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(77, 80)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(177, 26)
        Me.txtusername.TabIndex = 1
        '
        'pnlinside
        '
        Me.pnlinside.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlinside.Controls.Add(Me.lbltitle)
        Me.pnlinside.Location = New System.Drawing.Point(3, 3)
        Me.pnlinside.Name = "pnlinside"
        Me.pnlinside.Size = New System.Drawing.Size(295, 41)
        Me.pnlinside.TabIndex = 0
        '
        'lbltitle
        '
        Me.lbltitle.Font = New System.Drawing.Font("Mistral", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(39, 10)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(208, 22)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "   LOCAL DEPOSIT SYSTEM"
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(387, 1)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(91, 73)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'loginfm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(481, 243)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.pnltop)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loginfm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnltop.ResumeLayout(False)
        Me.pnltop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlinside.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnltop As Panel
    Friend WithEvents pnlinside As Panel
    Friend WithEvents txtpasswd As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents linklblpassword As LinkLabel
    Friend WithEvents lbltitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
