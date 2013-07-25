<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Changeadminpass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.lblenterpass = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtnewpass = New System.Windows.Forms.TextBox
        Me.lblnewpass = New System.Windows.Forms.Label
        Me.txtconfrmpass = New System.Windows.Forms.TextBox
        Me.lblconfrmpass = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnok = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnok1 = New System.Windows.Forms.Button
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(227, 127)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(151, 22)
        Me.txtpassword.TabIndex = 2
        '
        'lblenterpass
        '
        Me.lblenterpass.AutoSize = True
        Me.lblenterpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenterpass.Location = New System.Drawing.Point(48, 130)
        Me.lblenterpass.Name = "lblenterpass"
        Me.lblenterpass.Size = New System.Drawing.Size(137, 16)
        Me.lblenterpass.TabIndex = 1
        Me.lblenterpass.Text = "Enter your Password :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Box_Office.My.Resources.Resources.Inox_Leisure
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'txtnewpass
        '
        Me.txtnewpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpass.Location = New System.Drawing.Point(227, 211)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpass.Size = New System.Drawing.Size(151, 22)
        Me.txtnewpass.TabIndex = 7
        '
        'lblnewpass
        '
        Me.lblnewpass.AutoSize = True
        Me.lblnewpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewpass.Location = New System.Drawing.Point(81, 214)
        Me.lblnewpass.Name = "lblnewpass"
        Me.lblnewpass.Size = New System.Drawing.Size(104, 16)
        Me.lblnewpass.TabIndex = 6
        Me.lblnewpass.Text = "New Password :"
        '
        'txtconfrmpass
        '
        Me.txtconfrmpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfrmpass.Location = New System.Drawing.Point(227, 253)
        Me.txtconfrmpass.Name = "txtconfrmpass"
        Me.txtconfrmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfrmpass.Size = New System.Drawing.Size(151, 22)
        Me.txtconfrmpass.TabIndex = 9
        '
        'lblconfrmpass
        '
        Me.lblconfrmpass.AutoSize = True
        Me.lblconfrmpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfrmpass.Location = New System.Drawing.Point(63, 256)
        Me.lblconfrmpass.Name = "lblconfrmpass"
        Me.lblconfrmpass.Size = New System.Drawing.Size(122, 16)
        Me.lblconfrmpass.TabIndex = 8
        Me.lblconfrmpass.Text = "Confirm Password :"
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Image = Global.Box_Office.My.Resources.Resources.cancelIcon
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(289, 302)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(95, 33)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "     CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Image = Global.Box_Office.My.Resources.Resources.icon_refresh
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(166, 302)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(95, 33)
        Me.btnclear.TabIndex = 11
        Me.btnclear.Text = "     CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnok
        '
        Me.btnok.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Image = Global.Box_Office.My.Resources.Resources.Symbol_HookOK_18px
        Me.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.Location = New System.Drawing.Point(43, 302)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(95, 33)
        Me.btnok.TabIndex = 10
        Me.btnok.Text = "Done"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "USERNAME & PASSWORD"
        '
        'btnok1
        '
        Me.btnok1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnok1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok1.Image = Global.Box_Office.My.Resources.Resources.Symbol_HookOK_18px
        Me.btnok1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok1.Location = New System.Drawing.Point(84, 302)
        Me.btnok1.Name = "btnok1"
        Me.btnok1.Size = New System.Drawing.Size(95, 33)
        Me.btnok1.TabIndex = 3
        Me.btnok1.Text = "OK"
        Me.btnok1.UseVisualStyleBackColor = True
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(227, 169)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.ReadOnly = True
        Me.txtusername.Size = New System.Drawing.Size(151, 22)
        Me.txtusername.TabIndex = 5
        Me.txtusername.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Admin_ID :"
        '
        'Changeadminpass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(426, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnok1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtconfrmpass)
        Me.Controls.Add(Me.lblconfrmpass)
        Me.Controls.Add(Me.txtnewpass)
        Me.Controls.Add(Me.lblnewpass)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.lblenterpass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Changeadminpass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USERNAME & PASSWORD"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents lblenterpass As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtnewpass As System.Windows.Forms.TextBox
    Friend WithEvents lblnewpass As System.Windows.Forms.Label
    Friend WithEvents txtconfrmpass As System.Windows.Forms.TextBox
    Friend WithEvents lblconfrmpass As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnok1 As System.Windows.Forms.Button
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
