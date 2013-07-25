<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeleBooking
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbophnmname = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbophnstime = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtphnnoseat = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtphnseatnam = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtphnusrnm = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtphnusrmobl = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtphnaudi = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbophndate = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtPriceExecutive = New System.Windows.Forms.TextBox
        Me.txtAvailableExecutive = New System.Windows.Forms.TextBox
        Me.txtPriceClub = New System.Windows.Forms.TextBox
        Me.txtAvailableClub = New System.Windows.Forms.TextBox
        Me.txtPricePremium = New System.Windows.Forms.TextBox
        Me.txtAvailablePremium = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.rdoExecutive = New System.Windows.Forms.RadioButton
        Me.rdoClub = New System.Windows.Forms.RadioButton
        Me.rdoPremium = New System.Windows.Forms.RadioButton
        Me.btnseatselection = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtbookid = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnsubmit = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnphnexit = New System.Windows.Forms.Button
        Me.btnphnreset = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(68, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(58, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Movie :"
        '
        'cbophnmname
        '
        Me.cbophnmname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbophnmname.FormattingEnabled = True
        Me.cbophnmname.Location = New System.Drawing.Point(156, 74)
        Me.cbophnmname.Margin = New System.Windows.Forms.Padding(4)
        Me.cbophnmname.Name = "cbophnmname"
        Me.cbophnmname.Size = New System.Drawing.Size(169, 24)
        Me.cbophnmname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Show Time :"
        '
        'cbophnstime
        '
        Me.cbophnstime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbophnstime.FormattingEnabled = True
        Me.cbophnstime.Location = New System.Drawing.Point(156, 117)
        Me.cbophnstime.Margin = New System.Windows.Forms.Padding(4)
        Me.cbophnstime.Name = "cbophnstime"
        Me.cbophnstime.Size = New System.Drawing.Size(169, 24)
        Me.cbophnstime.TabIndex = 5
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
        'txtphnnoseat
        '
        Me.txtphnnoseat.Location = New System.Drawing.Point(164, 202)
        Me.txtphnnoseat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphnnoseat.MaxLength = 3
        Me.txtphnnoseat.Name = "txtphnnoseat"
        Me.txtphnnoseat.Size = New System.Drawing.Size(216, 22)
        Me.txtphnnoseat.TabIndex = 13
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
        'txtphnseatnam
        '
        Me.txtphnseatnam.BackColor = System.Drawing.Color.White
        Me.txtphnseatnam.Location = New System.Drawing.Point(164, 312)
        Me.txtphnseatnam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphnseatnam.Multiline = True
        Me.txtphnseatnam.Name = "txtphnseatnam"
        Me.txtphnseatnam.ReadOnly = True
        Me.txtphnseatnam.Size = New System.Drawing.Size(216, 82)
        Me.txtphnseatnam.TabIndex = 16
        Me.txtphnseatnam.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(56, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Name :"
        '
        'txtphnusrnm
        '
        Me.txtphnusrnm.Location = New System.Drawing.Point(156, 23)
        Me.txtphnusrnm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphnusrnm.Name = "txtphnusrnm"
        Me.txtphnusrnm.Size = New System.Drawing.Size(169, 22)
        Me.txtphnusrnm.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(25, 73)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Tag = ""
        Me.Label9.Text = "Mobile No :"
        '
        'txtphnusrmobl
        '
        Me.txtphnusrmobl.Location = New System.Drawing.Point(156, 70)
        Me.txtphnusrmobl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphnusrmobl.MaxLength = 10
        Me.txtphnusrmobl.Name = "txtphnusrmobl"
        Me.txtphnusrmobl.Size = New System.Drawing.Size(169, 22)
        Me.txtphnusrmobl.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtphnaudi)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbophndate)
        Me.GroupBox1.Controls.Add(Me.cbophnstime)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbophnmname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(42, 64)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(371, 219)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movie Details"
        '
        'txtphnaudi
        '
        Me.txtphnaudi.BackColor = System.Drawing.Color.White
        Me.txtphnaudi.Location = New System.Drawing.Point(156, 159)
        Me.txtphnaudi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphnaudi.Name = "txtphnaudi"
        Me.txtphnaudi.ReadOnly = True
        Me.txtphnaudi.Size = New System.Drawing.Size(169, 22)
        Me.txtphnaudi.TabIndex = 7
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
        'cbophndate
        '
        Me.cbophndate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbophndate.FormattingEnabled = True
        Me.cbophndate.Location = New System.Drawing.Point(156, 31)
        Me.cbophndate.Margin = New System.Windows.Forms.Padding(4)
        Me.cbophndate.Name = "cbophndate"
        Me.cbophndate.Size = New System.Drawing.Size(169, 24)
        Me.cbophndate.TabIndex = 1
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
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.rdoExecutive)
        Me.GroupBox2.Controls.Add(Me.rdoClub)
        Me.GroupBox2.Controls.Add(Me.rdoPremium)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtphnseatnam)
        Me.GroupBox2.Controls.Add(Me.btnseatselection)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtphnnoseat)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(442, 64)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(159, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Availability"
        '
        'rdoExecutive
        '
        Me.rdoExecutive.AutoSize = True
        Me.rdoExecutive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoExecutive.Location = New System.Drawing.Point(40, 147)
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
        Me.rdoClub.Location = New System.Drawing.Point(40, 109)
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
        Me.rdoPremium.Location = New System.Drawing.Point(40, 71)
        Me.rdoPremium.Name = "rdoPremium"
        Me.rdoPremium.Size = New System.Drawing.Size(86, 20)
        Me.rdoPremium.TabIndex = 3
        Me.rdoPremium.TabStop = True
        Me.rdoPremium.Text = "Premium"
        Me.rdoPremium.UseVisualStyleBackColor = True
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtbookid)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtphnusrmobl)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtphnusrnm)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(42, 319)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(371, 151)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Booking Details"
        '
        'txtbookid
        '
        Me.txtbookid.BackColor = System.Drawing.Color.White
        Me.txtbookid.Location = New System.Drawing.Point(156, 117)
        Me.txtbookid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbookid.MaxLength = 10
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.ReadOnly = True
        Me.txtbookid.Size = New System.Drawing.Size(169, 22)
        Me.txtbookid.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(49, 120)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Tag = ""
        Me.Label7.Text = "TeleID :"
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Image = Global.Box_Office.My.Resources.Resources.icon_save_14
        Me.btnsubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsubmit.Location = New System.Drawing.Point(174, 512)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(105, 28)
        Me.btnsubmit.TabIndex = 4
        Me.btnsubmit.Text = "    SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Rockwell", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(353, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "TELEBOOKING"
        '
        'btnphnexit
        '
        Me.btnphnexit.BackColor = System.Drawing.Color.Transparent
        Me.btnphnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnphnexit.Image = Global.Box_Office.My.Resources.Resources.cancelIcon
        Me.btnphnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnphnexit.Location = New System.Drawing.Point(606, 512)
        Me.btnphnexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnphnexit.Name = "btnphnexit"
        Me.btnphnexit.Size = New System.Drawing.Size(105, 28)
        Me.btnphnexit.TabIndex = 6
        Me.btnphnexit.Text = "EXIT"
        Me.btnphnexit.UseVisualStyleBackColor = False
        '
        'btnphnreset
        '
        Me.btnphnreset.BackColor = System.Drawing.Color.Transparent
        Me.btnphnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnphnreset.Image = Global.Box_Office.My.Resources.Resources.icon_refresh
        Me.btnphnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnphnreset.Location = New System.Drawing.Point(390, 512)
        Me.btnphnreset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnphnreset.Name = "btnphnreset"
        Me.btnphnreset.Size = New System.Drawing.Size(105, 28)
        Me.btnphnreset.TabIndex = 5
        Me.btnphnreset.Text = "RESET"
        Me.btnphnreset.UseVisualStyleBackColor = False
        '
        'TeleBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 595)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnphnexit)
        Me.Controls.Add(Me.btnphnreset)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TeleBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TELEBOOKING"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbophnmname As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbophnstime As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtphnnoseat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtphnseatnam As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtphnusrnm As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtphnusrmobl As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnseatselection As System.Windows.Forms.Button
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents btnphnreset As System.Windows.Forms.Button
    Friend WithEvents btnphnexit As System.Windows.Forms.Button
    Friend WithEvents cbophndate As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rdoExecutive As System.Windows.Forms.RadioButton
    Friend WithEvents rdoClub As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPremium As System.Windows.Forms.RadioButton
    Friend WithEvents txtPriceExecutive As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableExecutive As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceClub As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableClub As System.Windows.Forms.TextBox
    Friend WithEvents txtPricePremium As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailablePremium As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtphnaudi As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtbookid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
