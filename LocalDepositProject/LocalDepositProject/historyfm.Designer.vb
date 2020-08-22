<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class historyfm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnhistoryview = New System.Windows.Forms.Button()
        Me.btnhistorywithdraw = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(971, 612)
        Me.DataGridView1.TabIndex = 0
        '
        'btnhistoryview
        '
        Me.btnhistoryview.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnhistoryview.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhistoryview.Location = New System.Drawing.Point(50, 22)
        Me.btnhistoryview.Name = "btnhistoryview"
        Me.btnhistoryview.Size = New System.Drawing.Size(177, 35)
        Me.btnhistoryview.TabIndex = 2
        Me.btnhistoryview.Text = "VIEW DEPOSIT HISTORY"
        Me.btnhistoryview.UseVisualStyleBackColor = False
        '
        'btnhistorywithdraw
        '
        Me.btnhistorywithdraw.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnhistorywithdraw.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhistorywithdraw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnhistorywithdraw.Location = New System.Drawing.Point(265, 22)
        Me.btnhistorywithdraw.Name = "btnhistorywithdraw"
        Me.btnhistorywithdraw.Size = New System.Drawing.Size(213, 35)
        Me.btnhistorywithdraw.TabIndex = 3
        Me.btnhistorywithdraw.Text = "VIEW WITHDRAW HISTORY"
        Me.btnhistorywithdraw.UseVisualStyleBackColor = False
        '
        'historyfm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1052, 699)
        Me.Controls.Add(Me.btnhistorywithdraw)
        Me.Controls.Add(Me.btnhistoryview)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "historyfm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "historyfm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnhistoryview As Button
    Friend WithEvents btnhistorywithdraw As Button
End Class
