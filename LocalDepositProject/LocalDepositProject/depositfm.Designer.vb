<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class depositfm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(depositfm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblloginId = New System.Windows.Forms.Label()
        Me.lblclientfirstName = New System.Windows.Forms.Label()
        Me.lblsecondName = New System.Windows.Forms.Label()
        Me.lblamountDeposit = New System.Windows.Forms.Label()
        Me.txtclientfirstname = New System.Windows.Forms.TextBox()
        Me.txtloginId = New System.Windows.Forms.TextBox()
        Me.txtclientsecondname = New System.Windows.Forms.TextBox()
        Me.txtamountdeposit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnprocess = New System.Windows.Forms.Button()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.txtemailaddress = New System.Windows.Forms.TextBox()
        Me.lblemailaddress = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.lblresult2 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.lblcomission = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtexchangerate = New System.Windows.Forms.TextBox()
        Me.lbltitleexchagerate = New System.Windows.Forms.Label()
        Me.lblexchangerate = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.txtphoneNumber = New System.Windows.Forms.TextBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "     DEPOSIT SERVICES"
        '
        'lblloginId
        '
        Me.lblloginId.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloginId.Location = New System.Drawing.Point(63, 86)
        Me.lblloginId.Name = "lblloginId"
        Me.lblloginId.Size = New System.Drawing.Size(90, 23)
        Me.lblloginId.TabIndex = 1
        Me.lblloginId.Text = " LOGIN ID"
        '
        'lblclientfirstName
        '
        Me.lblclientfirstName.AutoSize = True
        Me.lblclientfirstName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientfirstName.Location = New System.Drawing.Point(175, 86)
        Me.lblclientfirstName.Name = "lblclientfirstName"
        Me.lblclientfirstName.Size = New System.Drawing.Size(115, 15)
        Me.lblclientfirstName.TabIndex = 2
        Me.lblclientfirstName.Text = " CLIENT FIRST NAME"
        '
        'lblsecondName
        '
        Me.lblsecondName.AutoSize = True
        Me.lblsecondName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondName.Location = New System.Drawing.Point(332, 86)
        Me.lblsecondName.Name = "lblsecondName"
        Me.lblsecondName.Size = New System.Drawing.Size(129, 15)
        Me.lblsecondName.TabIndex = 3
        Me.lblsecondName.Text = "CLIENT SECOND NAME"
        '
        'lblamountDeposit
        '
        Me.lblamountDeposit.AutoSize = True
        Me.lblamountDeposit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamountDeposit.Location = New System.Drawing.Point(551, 86)
        Me.lblamountDeposit.Name = "lblamountDeposit"
        Me.lblamountDeposit.Size = New System.Drawing.Size(130, 15)
        Me.lblamountDeposit.TabIndex = 4
        Me.lblamountDeposit.Text = "  AMOUNT TO DEPOSIT"
        '
        'txtclientfirstname
        '
        Me.txtclientfirstname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtclientfirstname.Location = New System.Drawing.Point(178, 104)
        Me.txtclientfirstname.Name = "txtclientfirstname"
        Me.txtclientfirstname.Size = New System.Drawing.Size(107, 13)
        Me.txtclientfirstname.TabIndex = 5
        '
        'txtloginId
        '
        Me.txtloginId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtloginId.Location = New System.Drawing.Point(46, 106)
        Me.txtloginId.Name = "txtloginId"
        Me.txtloginId.Size = New System.Drawing.Size(107, 13)
        Me.txtloginId.TabIndex = 6
        '
        'txtclientsecondname
        '
        Me.txtclientsecondname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtclientsecondname.Location = New System.Drawing.Point(335, 104)
        Me.txtclientsecondname.Name = "txtclientsecondname"
        Me.txtclientsecondname.Size = New System.Drawing.Size(107, 13)
        Me.txtclientsecondname.TabIndex = 7
        '
        'txtamountdeposit
        '
        Me.txtamountdeposit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtamountdeposit.Location = New System.Drawing.Point(560, 104)
        Me.txtamountdeposit.Name = "txtamountdeposit"
        Me.txtamountdeposit.Size = New System.Drawing.Size(121, 13)
        Me.txtamountdeposit.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = " PHONE NUMBER"
        '
        'btnprocess
        '
        Me.btnprocess.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnprocess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprocess.Location = New System.Drawing.Point(751, 101)
        Me.btnprocess.Name = "btnprocess"
        Me.btnprocess.Size = New System.Drawing.Size(92, 23)
        Me.btnprocess.TabIndex = 11
        Me.btnprocess.Text = " PROCESS"
        Me.btnprocess.UseVisualStyleBackColor = False
        '
        'lblresult
        '
        Me.lblresult.Location = New System.Drawing.Point(570, 195)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(92, 23)
        Me.lblresult.TabIndex = 12
        Me.lblresult.Text = "            "
        '
        'txtemailaddress
        '
        Me.txtemailaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemailaddress.Location = New System.Drawing.Point(183, 182)
        Me.txtemailaddress.Name = "txtemailaddress"
        Me.txtemailaddress.Size = New System.Drawing.Size(107, 13)
        Me.txtemailaddress.TabIndex = 14
        '
        'lblemailaddress
        '
        Me.lblemailaddress.AutoSize = True
        Me.lblemailaddress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemailaddress.Location = New System.Drawing.Point(192, 164)
        Me.lblemailaddress.Name = "lblemailaddress"
        Me.lblemailaddress.Size = New System.Drawing.Size(83, 15)
        Me.lblemailaddress.TabIndex = 15
        Me.lblemailaddress.Text = "Email Address"
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.AliceBlue
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Location = New System.Drawing.Point(751, 208)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(92, 23)
        Me.btnback.TabIndex = 16
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'lblresult2
        '
        Me.lblresult2.Location = New System.Drawing.Point(570, 243)
        Me.lblresult2.Name = "lblresult2"
        Me.lblresult2.Size = New System.Drawing.Size(64, 23)
        Me.lblresult2.TabIndex = 17
        Me.lblresult2.Text = "         "
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(751, 156)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(92, 23)
        Me.btnclear.TabIndex = 18
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'lblcomission
        '
        Me.lblcomission.Location = New System.Drawing.Point(570, 280)
        Me.lblcomission.Name = "lblcomission"
        Me.lblcomission.Size = New System.Drawing.Size(64, 23)
        Me.lblcomission.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(313, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Amount to deposit in  USD :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(258, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "  Amount To Deposit after commsion in TZS:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(377, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 23)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Comission is in TZS:"
        '
        'txtexchangerate
        '
        Me.txtexchangerate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtexchangerate.Location = New System.Drawing.Point(621, 45)
        Me.txtexchangerate.Multiline = True
        Me.txtexchangerate.Name = "txtexchangerate"
        Me.txtexchangerate.Size = New System.Drawing.Size(87, 16)
        Me.txtexchangerate.TabIndex = 23
        '
        'lbltitleexchagerate
        '
        Me.lbltitleexchagerate.AutoSize = True
        Me.lbltitleexchagerate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitleexchagerate.Location = New System.Drawing.Point(457, 44)
        Me.lbltitleexchagerate.Name = "lbltitleexchagerate"
        Me.lbltitleexchagerate.Size = New System.Drawing.Size(126, 15)
        Me.lbltitleexchagerate.TabIndex = 24
        Me.lbltitleexchagerate.Text = "1USD IN TZS(BUYING):"
        '
        'lblexchangerate
        '
        Me.lblexchangerate.AutoSize = True
        Me.lblexchangerate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexchangerate.Location = New System.Drawing.Point(580, 45)
        Me.lblexchangerate.Name = "lblexchangerate"
        Me.lblexchangerate.Size = New System.Drawing.Size(35, 15)
        Me.lblexchangerate.TabIndex = 25
        Me.lblexchangerate.Text = "2409"
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Location = New System.Drawing.Point(751, 41)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(92, 23)
        Me.btnupdate.TabIndex = 26
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'txtphoneNumber
        '
        Me.txtphoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtphoneNumber.Location = New System.Drawing.Point(46, 182)
        Me.txtphoneNumber.Name = "txtphoneNumber"
        Me.txtphoneNumber.Size = New System.Drawing.Size(107, 13)
        Me.txtphoneNumber.TabIndex = 27
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(-57, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(67, 64)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 28
        Me.PictureBox8.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(668, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "$"
        '
        'depositfm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(820, 606)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.txtphoneNumber)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.lblexchangerate)
        Me.Controls.Add(Me.lbltitleexchagerate)
        Me.Controls.Add(Me.txtexchangerate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblcomission)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.lblresult2)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.lblemailaddress)
        Me.Controls.Add(Me.txtemailaddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.btnprocess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtamountdeposit)
        Me.Controls.Add(Me.txtclientsecondname)
        Me.Controls.Add(Me.txtloginId)
        Me.Controls.Add(Me.txtclientfirstname)
        Me.Controls.Add(Me.lblamountDeposit)
        Me.Controls.Add(Me.lblsecondName)
        Me.Controls.Add(Me.lblclientfirstName)
        Me.Controls.Add(Me.lblloginId)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "depositfm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "depositfm"
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblloginId As Label
    Friend WithEvents lblclientfirstName As Label
    Friend WithEvents lblsecondName As Label
    Friend WithEvents lblamountDeposit As Label
    Friend WithEvents txtclientfirstname As TextBox
    Friend WithEvents txtloginId As TextBox
    Friend WithEvents txtclientsecondname As TextBox
    Friend WithEvents txtamountdeposit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnprocess As Button
    Friend WithEvents lblresult As Label
    Friend WithEvents txtemailaddress As TextBox
    Friend WithEvents lblemailaddress As Label
    Friend WithEvents btnback As Button
    Friend WithEvents lblresult2 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents lblcomission As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtexchangerate As TextBox
    Friend WithEvents lbltitleexchagerate As Label
    Friend WithEvents lblexchangerate As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents txtphoneNumber As TextBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label3 As Label
End Class
