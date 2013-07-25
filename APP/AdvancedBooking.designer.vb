<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedBooking
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtPriceExecutive = New System.Windows.Forms.TextBox
        Me.txtAvailableExecutive = New System.Windows.Forms.TextBox
        Me.txtPriceClub = New System.Windows.Forms.TextBox
        Me.txtAvailableClub = New System.Windows.Forms.TextBox
        Me.txtPricePremium = New System.Windows.Forms.TextBox
        Me.txtAvailablePremium = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.rdoExecutive = New System.Windows.Forms.RadioButton
        Me.rdoClub = New System.Windows.Forms.RadioButton
        Me.rdoPremium = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSeatname = New System.Windows.Forms.TextBox
        Me.btnseatselection = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNo_of_Seats = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtAudi = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboDate = New System.Windows.Forms.ComboBox
        Me.cboShowTime = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboMovieName = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtbookid = New System.Windows.Forms.TextBox
        Me.btnamount = New System.Windows.Forms.Button
        Me.lblbkid = New System.Windows.Forms.Label
        Me.txtamnt = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnsubmit = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.rdoExecutive)
        Me.GroupBox2.Controls.Add(Me.rdoClub)
        Me.GroupBox2.Controls.Add(Me.rdoPremium)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtSeatname)
        Me.GroupBox2.Controls.Add(Me.btnseatselection)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNo_of_Seats)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(443, 65)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Availability"
        '
        'rdoExecutive
        '
        Me.rdoExecutive.AutoSize = True
        Me.rdoExecutive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoExecutive.Location = New System.Drawing.Point(41, 147)
        Me.rdoExecutive.Name = "rdoExecutive"
        Me.rdoExecutive.Size = New System.Drawing.Size(93, 20)
        Me.rdoExecutive.TabIndex = 9
        Me.rdoExecutive.TabStop = True
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
        Me.rdoClub.TabStop = True
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
        Me.rdoPremium.TabStop = True
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
        'txtSeatname
        '
        Me.txtSeatname.BackColor = System.Drawing.Color.White
        Me.txtSeatname.Location = New System.Drawing.Point(164, 312)
        Me.txtSeatname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSeatname.Multiline = True
        Me.txtSeatname.Name = "txtSeatname"
        Me.txtSeatname.ReadOnly = True
        Me.txtSeatname.Size = New System.Drawing.Size(216, 86)
        Me.txtSeatname.TabIndex = 16
        Me.txtSeatname.TabStop = False
        '
        'btnseatselection
        '
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
        'txtNo_of_Seats
        '
        Me.txtNo_of_Seats.BackColor = System.Drawing.Color.White
        Me.txtNo_of_Seats.Location = New System.Drawing.Point(164, 202)
        Me.txtNo_of_Seats.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNo_of_Seats.MaxLength = 3
        Me.txtNo_of_Seats.Name = "txtNo_of_Seats"
        Me.txtNo_of_Seats.Size = New System.Drawing.Size(216, 22)
        Me.txtNo_of_Seats.TabIndex = 13
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
        Me.GroupBox1.Controls.Add(Me.txtAudi)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cboDate)
        Me.GroupBox1.Controls.Add(Me.cboShowTime)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboMovieName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(43, 65)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(371, 219)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movie Details"
        '
        'txtAudi
        '
        Me.txtAudi.BackColor = System.Drawing.Color.White
        Me.txtAudi.Location = New System.Drawing.Point(156, 159)
        Me.txtAudi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAudi.Name = "txtAudi"
        Me.txtAudi.ReadOnly = True
        Me.txtAudi.Size = New System.Drawing.Size(169, 22)
        Me.txtAudi.TabIndex = 7
        Me.txtAudi.TabStop = False
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
        'cboDate
        '
        Me.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDate.FormattingEnabled = True
        Me.cboDate.Location = New System.Drawing.Point(156, 31)
        Me.cboDate.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDate.Name = "cboDate"
        Me.cboDate.Size = New System.Drawing.Size(169, 24)
        Me.cboDate.TabIndex = 1
        '
        'cboShowTime
        '
        Me.cboShowTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShowTime.FormattingEnabled = True
        Me.cboShowTime.Location = New System.Drawing.Point(156, 117)
        Me.cboShowTime.Margin = New System.Windows.Forms.Padding(4)
        Me.cboShowTime.Name = "cboShowTime"
        Me.cboShowTime.Size = New System.Drawing.Size(169, 24)
        Me.cboShowTime.TabIndex = 5
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
        'cboMovieName
        '
        Me.cboMovieName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMovieName.FormattingEnabled = True
        Me.cboMovieName.Location = New System.Drawing.Point(156, 74)
        Me.cboMovieName.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMovieName.Name = "cboMovieName"
        Me.cboMovieName.Size = New System.Drawing.Size(169, 24)
        Me.cboMovieName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(59, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Movie :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(68, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Date :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtbookid)
        Me.GroupBox3.Controls.Add(Me.btnamount)
        Me.GroupBox3.Controls.Add(Me.lblbkid)
        Me.GroupBox3.Controls.Add(Me.txtamnt)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(43, 320)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(371, 151)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment"
        '
        'txtbookid
        '
        Me.txtbookid.BackColor = System.Drawing.Color.White
        Me.txtbookid.Location = New System.Drawing.Point(151, 96)
        Me.txtbookid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.ReadOnly = True
        Me.txtbookid.Size = New System.Drawing.Size(169, 22)
        Me.txtbookid.TabIndex = 3
        Me.txtbookid.TabStop = False
        '
        'btnamount
        '
        Me.btnamount.Location = New System.Drawing.Point(45, 44)
        Me.btnamount.Name = "btnamount"
        Me.btnamount.Size = New System.Drawing.Size(75, 23)
        Me.btnamount.TabIndex = 0
        Me.btnamount.Text = "Amount"
        Me.btnamount.UseVisualStyleBackColor = True
        '
        'lblbkid
        '
        Me.lblbkid.AutoSize = True
        Me.lblbkid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbkid.Location = New System.Drawing.Point(23, 99)
        Me.lblbkid.Name = "lblbkid"
        Me.lblbkid.Size = New System.Drawing.Size(92, 16)
        Me.lblbkid.TabIndex = 2
        Me.lblbkid.Text = "Booking ID :"
        '
        'txtamnt
        '
        Me.txtamnt.BackColor = System.Drawing.Color.White
        Me.txtamnt.Location = New System.Drawing.Point(151, 45)
        Me.txtamnt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtamnt.Name = "txtamnt"
        Me.txtamnt.ReadOnly = True
        Me.txtamnt.Size = New System.Drawing.Size(169, 22)
        Me.txtamnt.TabIndex = 1
        Me.txtamnt.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Rockwell", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(325, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(236, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ADVANCE BOOKING"
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Transparent
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Image = Global.Box_Office.My.Resources.Resources.cancelIcon
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexit.Location = New System.Drawing.Point(607, 515)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(105, 28)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Transparent
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Image = Global.Box_Office.My.Resources.Resources.icon_refresh
        Me.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreset.Location = New System.Drawing.Point(391, 515)
        Me.btnreset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(105, 28)
        Me.btnreset.TabIndex = 5
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Image = Global.Box_Office.My.Resources.Resources.icon_save_14
        Me.btnsubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsubmit.Location = New System.Drawing.Point(175, 515)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(105, 28)
        Me.btnsubmit.TabIndex = 4
        Me.btnsubmit.Text = "   SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'AdvancedBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 595)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "AdvancedBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADVANCE BOOKING"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPriceExecutive As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableExecutive As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceClub As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableClub As System.Windows.Forms.TextBox
    Friend WithEvents txtPricePremium As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailablePremium As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoExecutive As System.Windows.Forms.RadioButton
    Friend WithEvents rdoClub As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPremium As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSeatname As System.Windows.Forms.TextBox
    Friend WithEvents btnseatselection As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNo_of_Seats As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAudi As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboDate As System.Windows.Forms.ComboBox
    Friend WithEvents cboShowTime As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboMovieName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtamnt As System.Windows.Forms.TextBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnamount As System.Windows.Forms.Button
    Friend WithEvents txtbookid As System.Windows.Forms.TextBox
    Friend WithEvents lblbkid As System.Windows.Forms.Label
End Class
