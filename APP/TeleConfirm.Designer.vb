<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeleConfirm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txttelestime = New System.Windows.Forms.TextBox
        Me.txttelemovie = New System.Windows.Forms.TextBox
        Me.txtteledate = New System.Windows.Forms.TextBox
        Me.txtteleaudi = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtteleclass = New System.Windows.Forms.TextBox
        Me.txtteleprice = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtteleno_of_seats = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtteleseatname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtamnt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTeleID = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnsubmit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txttelestime)
        Me.GroupBox1.Controls.Add(Me.txttelemovie)
        Me.GroupBox1.Controls.Add(Me.txtteledate)
        Me.GroupBox1.Controls.Add(Me.txtteleaudi)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(42, 70)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(371, 246)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movie Details"
        '
        'txttelestime
        '
        Me.txttelestime.BackColor = System.Drawing.Color.White
        Me.txttelestime.Location = New System.Drawing.Point(156, 133)
        Me.txttelestime.Margin = New System.Windows.Forms.Padding(4)
        Me.txttelestime.Name = "txttelestime"
        Me.txttelestime.ReadOnly = True
        Me.txttelestime.Size = New System.Drawing.Size(169, 22)
        Me.txttelestime.TabIndex = 5
        Me.txttelestime.TabStop = False
        '
        'txttelemovie
        '
        Me.txttelemovie.BackColor = System.Drawing.Color.White
        Me.txttelemovie.Location = New System.Drawing.Point(156, 90)
        Me.txttelemovie.Margin = New System.Windows.Forms.Padding(4)
        Me.txttelemovie.Name = "txttelemovie"
        Me.txttelemovie.ReadOnly = True
        Me.txttelemovie.Size = New System.Drawing.Size(169, 22)
        Me.txttelemovie.TabIndex = 3
        Me.txttelemovie.TabStop = False
        '
        'txtteledate
        '
        Me.txtteledate.BackColor = System.Drawing.Color.White
        Me.txtteledate.Location = New System.Drawing.Point(156, 47)
        Me.txtteledate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtteledate.Name = "txtteledate"
        Me.txtteledate.ReadOnly = True
        Me.txtteledate.Size = New System.Drawing.Size(169, 22)
        Me.txtteledate.TabIndex = 1
        Me.txtteledate.TabStop = False
        '
        'txtteleaudi
        '
        Me.txtteleaudi.BackColor = System.Drawing.Color.White
        Me.txtteleaudi.Location = New System.Drawing.Point(156, 176)
        Me.txtteleaudi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtteleaudi.Name = "txtteleaudi"
        Me.txtteleaudi.ReadOnly = True
        Me.txtteleaudi.Size = New System.Drawing.Size(169, 22)
        Me.txtteleaudi.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Audi :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Show Time :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(59, 93)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Movie :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(68, 50)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Date :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Rockwell", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(285, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(293, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "TELEBOOKING CONFIRM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(91, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class :"
        '
        'txtteleclass
        '
        Me.txtteleclass.BackColor = System.Drawing.Color.White
        Me.txtteleclass.Location = New System.Drawing.Point(183, 23)
        Me.txtteleclass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtteleclass.Name = "txtteleclass"
        Me.txtteleclass.ReadOnly = True
        Me.txtteleclass.Size = New System.Drawing.Size(169, 22)
        Me.txtteleclass.TabIndex = 1
        Me.txtteleclass.TabStop = False
        '
        'txtteleprice
        '
        Me.txtteleprice.BackColor = System.Drawing.Color.White
        Me.txtteleprice.Location = New System.Drawing.Point(183, 68)
        Me.txtteleprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtteleprice.Name = "txtteleprice"
        Me.txtteleprice.ReadOnly = True
        Me.txtteleprice.Size = New System.Drawing.Size(169, 22)
        Me.txtteleprice.TabIndex = 3
        Me.txtteleprice.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(93, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Price :"
        '
        'txtteleno_of_seats
        '
        Me.txtteleno_of_seats.BackColor = System.Drawing.Color.White
        Me.txtteleno_of_seats.Location = New System.Drawing.Point(183, 109)
        Me.txtteleno_of_seats.Margin = New System.Windows.Forms.Padding(4)
        Me.txtteleno_of_seats.Name = "txtteleno_of_seats"
        Me.txtteleno_of_seats.ReadOnly = True
        Me.txtteleno_of_seats.Size = New System.Drawing.Size(169, 22)
        Me.txtteleno_of_seats.TabIndex = 5
        Me.txtteleno_of_seats.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(53, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "No of Seat :"
        '
        'txtteleseatname
        '
        Me.txtteleseatname.BackColor = System.Drawing.Color.White
        Me.txtteleseatname.Location = New System.Drawing.Point(183, 152)
        Me.txtteleseatname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtteleseatname.Multiline = True
        Me.txtteleseatname.Name = "txtteleseatname"
        Me.txtteleseatname.ReadOnly = True
        Me.txtteleseatname.Size = New System.Drawing.Size(169, 70)
        Me.txtteleseatname.TabIndex = 7
        Me.txtteleseatname.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(51, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Seat Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtteleseatname)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtteleno_of_seats)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtteleprice)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtteleclass)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(450, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 246)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seat Details"
        '
        'txtamnt
        '
        Me.txtamnt.BackColor = System.Drawing.Color.White
        Me.txtamnt.Location = New System.Drawing.Point(512, 51)
        Me.txtamnt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtamnt.Name = "txtamnt"
        Me.txtamnt.ReadOnly = True
        Me.txtamnt.Size = New System.Drawing.Size(169, 22)
        Me.txtamnt.TabIndex = 3
        Me.txtamnt.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(404, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Amount :"
        '
        'txtTeleID
        '
        Me.txtTeleID.BackColor = System.Drawing.Color.White
        Me.txtTeleID.Location = New System.Drawing.Point(155, 49)
        Me.txtTeleID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTeleID.Name = "txtTeleID"
        Me.txtTeleID.ReadOnly = True
        Me.txtTeleID.Size = New System.Drawing.Size(169, 22)
        Me.txtTeleID.TabIndex = 1
        Me.txtTeleID.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tele ID :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtTeleID)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtamnt)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(42, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(778, 113)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Details"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.Box_Office.My.Resources.Resources.th_back_icon
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(86, 494)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 28)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "BACK"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Box_Office.My.Resources.Resources.cancelIcon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(671, 494)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 28)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Box_Office.My.Resources.Resources.iconRedX
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(476, 494)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 28)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Image = Global.Box_Office.My.Resources.Resources.icon_save_14
        Me.btnsubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsubmit.Location = New System.Drawing.Point(281, 494)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(105, 28)
        Me.btnsubmit.TabIndex = 5
        Me.btnsubmit.Text = "  SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'TeleConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(862, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TeleConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeleConfirm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttelestime As System.Windows.Forms.TextBox
    Friend WithEvents txttelemovie As System.Windows.Forms.TextBox
    Friend WithEvents txtteledate As System.Windows.Forms.TextBox
    Friend WithEvents txtteleaudi As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtteleclass As System.Windows.Forms.TextBox
    Friend WithEvents txtteleprice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtteleno_of_seats As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtteleseatname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtamnt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTeleID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
End Class
