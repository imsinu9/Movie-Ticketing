<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrentBooking
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtcrtbookid = New System.Windows.Forms.TextBox
        Me.btnamount = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtamnt = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtPriceExecutive = New System.Windows.Forms.TextBox
        Me.txtAvailableExecutive = New System.Windows.Forms.TextBox
        Me.txtPriceClub = New System.Windows.Forms.TextBox
        Me.txtAvailableClub = New System.Windows.Forms.TextBox
        Me.txtPricePremium = New System.Windows.Forms.TextBox
        Me.txtAvailablePremium = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rdoExecutive = New System.Windows.Forms.RadioButton
        Me.rdoClub = New System.Windows.Forms.RadioButton
        Me.rdoPremium = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcrtSeatname = New System.Windows.Forms.TextBox
        Me.btnseatselection = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtcrtNo_of_Seats = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtcrtshowtime = New System.Windows.Forms.TextBox
        Me.txtcrtMoviename = New System.Windows.Forms.TextBox
        Me.txtcrtdate = New System.Windows.Forms.TextBox
        Me.txtcrtAudi = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnsubmit = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtcrtbookid)
        Me.GroupBox3.Controls.Add(Me.btnamount)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtamnt)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(45, 322)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(371, 151)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment"
        '
        'txtcrtbookid
        '
        Me.txtcrtbookid.BackColor = System.Drawing.Color.White
        Me.txtcrtbookid.Location = New System.Drawing.Point(155, 94)
        Me.txtcrtbookid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcrtbookid.Name = "txtcrtbookid"
        Me.txtcrtbookid.ReadOnly = True
        Me.txtcrtbookid.Size = New System.Drawing.Size(169, 22)
        Me.txtcrtbookid.TabIndex = 3
        '
        'btnamount
        '
        Me.btnamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamount.Location = New System.Drawing.Point(31, 38)
        Me.btnamount.Name = "btnamount"
        Me.btnamount.Size = New System.Drawing.Size(89, 33)
        Me.btnamount.TabIndex = 0
        Me.btnamount.Text = "Amount"
        Me.btnamount.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Booking ID :"
        '
        'txtamnt
        '
        Me.txtamnt.BackColor = System.Drawing.Color.White
        Me.txtamnt.Location = New System.Drawing.Point(155, 43)
        Me.txtamnt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtamnt.Name = "txtamnt"
        Me.txtamnt.ReadOnly = True
        Me.txtamnt.Size = New System.Drawing.Size(169, 22)
        Me.txtamnt.TabIndex = 1
        Me.txtamnt.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtPriceExecutive)
        Me.GroupBox2.Controls.Add(Me.txtAvailableExecutive)
        Me.GroupBox2.Controls.Add(Me.txtPriceClub)
        Me.GroupBox2.Controls.Add(Me.txtAvailableClub)
        Me.GroupBox2.Controls.Add(Me.txtPricePremium)
        Me.GroupBox2.Controls.Add(Me.txtAvailablePremium)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.rdoExecutive)
        Me.GroupBox2.Controls.Add(Me.rdoClub)
        Me.GroupBox2.Controls.Add(Me.rdoPremium)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtcrtSeatname)
        Me.GroupBox2.Controls.Add(Me.btnseatselection)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtcrtNo_of_Seats)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(445, 67)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(404, 406)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seat Details"
        '
        'txtPriceExecutive
        '
        Me.txtPriceExecutive.BackColor = System.Drawing.Color.White
        Me.txtPriceExecutive.Location = New System.Drawing.Point(302, 145)
        Me.txtPriceExecutive.Name = "txtPriceExecutive"
        Me.txtPriceExecutive.ReadOnly = True
        Me.txtPriceExecutive.Size = New System.Drawing.Size(78, 22)
        Me.txtPriceExecutive.TabIndex = 11
        Me.txtPriceExecutive.TabStop = False
        '
        'txtAvailableExecutive
        '
        Me.txtAvailableExecutive.BackColor = System.Drawing.Color.White
        Me.txtAvailableExecutive.Location = New System.Drawing.Point(164, 145)
        Me.txtAvailableExecutive.Name = "txtAvailableExecutive"
        Me.txtAvailableExecutive.ReadOnly = True
        Me.txtAvailableExecutive.Size = New System.Drawing.Size(78, 22)
        Me.txtAvailableExecutive.TabIndex = 10
        Me.txtAvailableExecutive.TabStop = False
        '
        'txtPriceClub
        '
        Me.txtPriceClub.BackColor = System.Drawing.Color.White
        Me.txtPriceClub.Location = New System.Drawing.Point(302, 107)
        Me.txtPriceClub.Name = "txtPriceClub"
        Me.txtPriceClub.ReadOnly = True
        Me.txtPriceClub.Size = New System.Drawing.Size(78, 22)
        Me.txtPriceClub.TabIndex = 8
        Me.txtPriceClub.TabStop = False
        '
        'txtAvailableClub
        '
        Me.txtAvailableClub.BackColor = System.Drawing.Color.White
        Me.txtAvailableClub.Location = New System.Drawing.Point(164, 107)
        Me.txtAvailableClub.Name = "txtAvailableClub"
        Me.txtAvailableClub.ReadOnly = True
        Me.txtAvailableClub.Size = New System.Drawing.Size(78, 22)
        Me.txtAvailableClub.TabIndex = 7
        Me.txtAvailableClub.TabStop = False
        '
        'txtPricePremium
        '
        Me.txtPricePremium.BackColor = System.Drawing.Color.White
        Me.txtPricePremium.Location = New System.Drawing.Point(302, 69)
        Me.txtPricePremium.Name = "txtPricePremium"
        Me.txtPricePremium.ReadOnly = True
        Me.txtPricePremium.Size = New System.Drawing.Size(78, 22)
        Me.txtPricePremium.TabIndex = 5
        Me.txtPricePremium.TabStop = False
        '
        'txtAvailablePremium
        '
        Me.txtAvailablePremium.BackColor = System.Drawing.Color.White
        Me.txtAvailablePremium.Location = New System.Drawing.Point(164, 69)
        Me.txtAvailablePremium.Name = "txtAvailablePremium"
        Me.txtAvailablePremium.ReadOnly = True
        Me.txtAvailablePremium.Size = New System.Drawing.Size(78, 22)
        Me.txtAvailablePremium.TabIndex = 4
        Me.txtAvailablePremium.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(299, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Availability"
        '
        'rdoExecutive
        '
        Me.rdoExecutive.AutoSize = True
        Me.rdoExecutive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoExecutive.Location = New System.Drawing.Point(41, 147)
        Me.rdoExecutive.Name = "rdoExecutive"
        Me.rdoExecutive.Size = New System.Drawing.Size(93, 20)
        Me.rdoExecutive.TabIndex = 9
        Me.rdoExecutive.Text = "Executive"
        Me.rdoExecutive.UseVisualStyleBackColor = True
        '
        'rdoClub
        '
        Me.rdoClub.AutoSize = True
        Me.rdoClub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoClub.Location = New System.Drawing.Point(41, 109)
        Me.rdoClub.Name = "rdoClub"
        Me.rdoClub.Size = New System.Drawing.Size(57, 20)
        Me.rdoClub.TabIndex = 6
        Me.rdoClub.Text = "Club"
        Me.rdoClub.UseVisualStyleBackColor = True
        '
        'rdoPremium
        '
        Me.rdoPremium.AutoSize = True
        Me.rdoPremium.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPremium.Location = New System.Drawing.Point(41, 71)
        Me.rdoPremium.Name = "rdoPremium"
        Me.rdoPremium.Size = New System.Drawing.Size(86, 20)
        Me.rdoPremium.TabIndex = 3
        Me.rdoPremium.Text = "Premium"
        Me.rdoPremium.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(35, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Class :"
        '
        'txtcrtSeatname
        '
        Me.txtcrtSeatname.BackColor = System.Drawing.Color.White
        Me.txtcrtSeatname.Location = New System.Drawing.Point(164, 312)
        Me.txtcrtSeatname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcrtSeatname.Multiline = True
        Me.txtcrtSeatname.Name = "txtcrtSeatname"
        Me.txtcrtSeatname.ReadOnly = True
        Me.txtcrtSeatname.Size = New System.Drawing.Size(216, 86)
        Me.txtcrtSeatname.TabIndex = 16
        Me.txtcrtSeatname.TabStop = False
        '
        'btnseatselection
        '
        Me.btnseatselection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnseatselection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnseatselection.Location = New System.Drawing.Point(164, 255)
        Me.btnseatselection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnseatselection.Name = "btnseatselection"
        Me.btnseatselection.Size = New System.Drawing.Size(216, 37)
        Me.btnseatselection.TabIndex = 14
        Me.btnseatselection.Text = "Go To Seat Selection..."
        Me.btnseatselection.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(38, 336)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Seat No :"
        '
        'txtcrtNo_of_Seats
        '
        Me.txtcrtNo_of_Seats.BackColor = System.Drawing.Color.White
        Me.txtcrtNo_of_Seats.Location = New System.Drawing.Point(164, 202)
        Me.txtcrtNo_of_Seats.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcrtNo_of_Seats.MaxLength = 3
        Me.txtcrtNo_of_Seats.Name = "txtcrtNo_of_Seats"
        Me.txtcrtNo_of_Seats.Size = New System.Drawing.Size(216, 22)
        Me.txtcrtNo_of_Seats.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(35, 202)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "No. of Seats :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtcrtshowtime)
        Me.GroupBox1.Controls.Add(Me.txtcrtMoviename)
        Me.GroupBox1.Controls.Add(Me.txtcrtdate)
        Me.GroupBox1.Controls.Add(Me.txtcrtAudi)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(45, 67)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(371, 219)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movie Details"
        '
        'txtcrtshowtime
        '
        Me.txtcrtshowtime.BackColor = System.Drawing.Color.White
        Me.txtcrtshowtime.Location = New System.Drawing.Point(156, 116)
        Me.txtcrtshowtime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcrtshowtime.Name = "txtcrtshowtime"
        Me.txtcrtshowtime.ReadOnly = True
        Me.txtcrtshowtime.Size = New System.Drawing.Size(169, 22)
        Me.txtcrtshowtime.TabIndex = 5
        Me.txtcrtshowtime.TabStop = False
        '
        'txtcrtMoviename
        '
        Me.txtcrtMoviename.BackColor = System.Drawing.Color.White
        Me.txtcrtMoviename.Location = New System.Drawing.Point(156, 73)
        Me.txtcrtMoviename.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcrtMoviename.Name = "txtcrtMoviename"
        Me.txtcrtMoviename.ReadOnly = True
        Me.txtcrtMoviename.Size = New System.Drawing.Size(169, 22)
        Me.txtcrtMoviename.TabIndex = 3
        Me.txtcrtMoviename.TabStop = False
        '
        'txtcrtdate
        '
        Me.txtcrtdate.BackColor = System.Drawing.Color.White
        Me.txtcrtdate.Location = New System.Drawing.Point(156, 30)
        Me.txtcrtdate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcrtdate.Name = "txtcrtdate"
        Me.txtcrtdate.ReadOnly = True
        Me.txtcrtdate.Size = New System.Drawing.Size(169, 22)
        Me.txtcrtdate.TabIndex = 1
        Me.txtcrtdate.TabStop = False
        '
        'txtcrtAudi
        '
        Me.txtcrtAudi.BackColor = System.Drawing.Color.White
        Me.txtcrtAudi.Location = New System.Drawing.Point(156, 159)
        Me.txtcrtAudi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcrtAudi.Name = "txtcrtAudi"
        Me.txtcrtAudi.ReadOnly = True
        Me.txtcrtAudi.Size = New System.Drawing.Size(169, 22)
        Me.txtcrtAudi.TabIndex = 7
        Me.txtcrtAudi.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 161)
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
        Me.Label3.Location = New System.Drawing.Point(23, 119)
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
        Me.Label7.Location = New System.Drawing.Point(59, 76)
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
        Me.Label9.Location = New System.Drawing.Point(68, 33)
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
        Me.Label13.Location = New System.Drawing.Point(301, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(232, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "CURRENT BOOKING"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Box_Office.My.Resources.Resources.icon_refresh
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(488, 517)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 28)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "RESET"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Image = Global.Box_Office.My.Resources.Resources.icon_save_14
        Me.btnsubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsubmit.Location = New System.Drawing.Point(293, 517)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(105, 28)
        Me.btnsubmit.TabIndex = 5
        Me.btnsubmit.Text = "  SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Box_Office.My.Resources.Resources.cancelIcon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(683, 517)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 28)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.Box_Office.My.Resources.Resources.th_back_icon
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(98, 517)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 28)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "BACK"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'CurrentBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(887, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimizeBox = False
        Me.Name = "CurrentBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CURRENT BOOKING"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtamnt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPriceExecutive As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableExecutive As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceClub As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableClub As System.Windows.Forms.TextBox
    Friend WithEvents txtPricePremium As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailablePremium As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdoExecutive As System.Windows.Forms.RadioButton
    Friend WithEvents rdoClub As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPremium As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcrtSeatname As System.Windows.Forms.TextBox
    Friend WithEvents btnseatselection As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcrtNo_of_Seats As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcrtAudi As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcrtshowtime As System.Windows.Forms.TextBox
    Friend WithEvents txtcrtMoviename As System.Windows.Forms.TextBox
    Friend WithEvents txtcrtdate As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnamount As System.Windows.Forms.Button
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtcrtbookid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
