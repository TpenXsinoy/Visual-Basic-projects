<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignupform
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
        Me.lblFav = New System.Windows.Forms.Label()
        Me.NumUpdowndays = New System.Windows.Forms.NumericUpDown()
        Me.numUpdownage = New System.Windows.Forms.NumericUpDown()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbFavourites = New System.Windows.Forms.ComboBox()
        Me.lblEntercode = New System.Windows.Forms.Label()
        Me.txtVerCode = New System.Windows.Forms.TextBox()
        Me.lblVercode = New System.Windows.Forms.Label()
        Me.picboxVercode = New System.Windows.Forms.PictureBox()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.Label()
        Me.radioFemale = New System.Windows.Forms.RadioButton()
        Me.radioMale = New System.Windows.Forms.RadioButton()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblSingup = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFavourites = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCAncel = New System.Windows.Forms.Button()
        CType(Me.NumUpdowndays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpdownage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxVercode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFav
        '
        Me.lblFav.AutoSize = True
        Me.lblFav.BackColor = System.Drawing.Color.Black
        Me.lblFav.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFav.ForeColor = System.Drawing.Color.White
        Me.lblFav.Location = New System.Drawing.Point(155, 313)
        Me.lblFav.Name = "lblFav"
        Me.lblFav.Size = New System.Drawing.Size(0, 17)
        Me.lblFav.TabIndex = 135
        '
        'NumUpdowndays
        '
        Me.NumUpdowndays.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumUpdowndays.Location = New System.Drawing.Point(284, 207)
        Me.NumUpdowndays.Name = "NumUpdowndays"
        Me.NumUpdowndays.Size = New System.Drawing.Size(52, 28)
        Me.NumUpdowndays.TabIndex = 4
        '
        'numUpdownage
        '
        Me.numUpdownage.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpdownage.Location = New System.Drawing.Point(158, 150)
        Me.numUpdownage.Name = "numUpdownage"
        Me.numUpdownage.Size = New System.Drawing.Size(81, 28)
        Me.numUpdownage.TabIndex = 2
        '
        'lblRace
        '
        Me.lblRace.AutoSize = True
        Me.lblRace.BackColor = System.Drawing.Color.Transparent
        Me.lblRace.Font = New System.Drawing.Font("Berlin Sans FB Demi", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRace.ForeColor = System.Drawing.SystemColors.Menu
        Me.lblRace.Location = New System.Drawing.Point(5, 9)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(514, 43)
        Me.lblRace.TabIndex = 0
        Me.lblRace.Text = "Do you want to join the race? "
        '
        'cmbYear
        '
        Me.cmbYear.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000"})
        Me.cmbYear.Location = New System.Drawing.Point(342, 206)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(78, 29)
        Me.cmbYear.TabIndex = 5
        '
        'cmbMonth
        '
        Me.cmbMonth.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"JANUARY", "FEBUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.cmbMonth.Location = New System.Drawing.Point(158, 204)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(115, 29)
        Me.cmbMonth.TabIndex = 3
        '
        'cmbFavourites
        '
        Me.cmbFavourites.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFavourites.FormattingEnabled = True
        Me.cmbFavourites.Items.AddRange(New Object() {"Foods", "Sports", "Movies", "Cars", "Games"})
        Me.cmbFavourites.Location = New System.Drawing.Point(158, 281)
        Me.cmbFavourites.Name = "cmbFavourites"
        Me.cmbFavourites.Size = New System.Drawing.Size(262, 29)
        Me.cmbFavourites.TabIndex = 7
        '
        'lblEntercode
        '
        Me.lblEntercode.BackColor = System.Drawing.Color.Transparent
        Me.lblEntercode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntercode.ForeColor = System.Drawing.Color.Blue
        Me.lblEntercode.Location = New System.Drawing.Point(245, 499)
        Me.lblEntercode.Name = "lblEntercode"
        Me.lblEntercode.Size = New System.Drawing.Size(152, 21)
        Me.lblEntercode.TabIndex = 0
        Me.lblEntercode.Text = "Enter Verification code"
        '
        'txtVerCode
        '
        Me.txtVerCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerCode.Location = New System.Drawing.Point(248, 523)
        Me.txtVerCode.Multiline = True
        Me.txtVerCode.Name = "txtVerCode"
        Me.txtVerCode.Size = New System.Drawing.Size(149, 31)
        Me.txtVerCode.TabIndex = 12
        '
        'lblVercode
        '
        Me.lblVercode.BackColor = System.Drawing.Color.Transparent
        Me.lblVercode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVercode.ForeColor = System.Drawing.Color.Red
        Me.lblVercode.Location = New System.Drawing.Point(39, 490)
        Me.lblVercode.Name = "lblVercode"
        Me.lblVercode.Size = New System.Drawing.Size(186, 13)
        Me.lblVercode.TabIndex = 0
        Me.lblVercode.Text = "Verification code"
        '
        'picboxVercode
        '
        Me.picboxVercode.Image = Global.finalproject.My.Resources.Resources.aa
        Me.picboxVercode.Location = New System.Drawing.Point(42, 506)
        Me.picboxVercode.Name = "picboxVercode"
        Me.picboxVercode.Size = New System.Drawing.Size(188, 57)
        Me.picboxVercode.TabIndex = 123
        Me.picboxVercode.TabStop = False
        '
        'txtDisplay
        '
        Me.txtDisplay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDisplay.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(453, 77)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(396, 498)
        Me.txtDisplay.TabIndex = 15
        '
        'txtGender
        '
        Me.txtGender.AutoSize = True
        Me.txtGender.BackColor = System.Drawing.Color.Black
        Me.txtGender.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.ForeColor = System.Drawing.Color.White
        Me.txtGender.Location = New System.Drawing.Point(50, 326)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(91, 24)
        Me.txtGender.TabIndex = 0
        Me.txtGender.Text = "GENDER"
        '
        'radioFemale
        '
        Me.radioFemale.AutoSize = True
        Me.radioFemale.BackColor = System.Drawing.Color.Black
        Me.radioFemale.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFemale.ForeColor = System.Drawing.Color.White
        Me.radioFemale.Location = New System.Drawing.Point(299, 337)
        Me.radioFemale.Name = "radioFemale"
        Me.radioFemale.Size = New System.Drawing.Size(108, 25)
        Me.radioFemale.TabIndex = 9
        Me.radioFemale.TabStop = True
        Me.radioFemale.Text = "FEMALE"
        Me.radioFemale.UseVisualStyleBackColor = False
        '
        'radioMale
        '
        Me.radioMale.AutoSize = True
        Me.radioMale.BackColor = System.Drawing.Color.Black
        Me.radioMale.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioMale.ForeColor = System.Drawing.Color.White
        Me.radioMale.Location = New System.Drawing.Point(147, 337)
        Me.radioMale.Name = "radioMale"
        Me.radioMale.Size = New System.Drawing.Size(83, 25)
        Me.radioMale.TabIndex = 8
        Me.radioMale.TabStop = True
        Me.radioMale.Text = "MALE"
        Me.radioMale.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPassword.Location = New System.Drawing.Point(158, 434)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(256, 28)
        Me.txtPassword.TabIndex = 11
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Black
        Me.lblAge.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.White
        Me.lblAge.Location = New System.Drawing.Point(91, 154)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(50, 24)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "AGE"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(158, 388)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(256, 28)
        Me.txtUsername.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(158, 240)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(262, 31)
        Me.txtEmail.TabIndex = 6
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.BackColor = System.Drawing.Color.Black
        Me.lblBirthdate.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdate.ForeColor = System.Drawing.Color.White
        Me.lblBirthdate.Location = New System.Drawing.Point(16, 206)
        Me.lblBirthdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(125, 24)
        Me.lblBirthdate.TabIndex = 0
        Me.lblBirthdate.Text = "BIRTHDATE"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Black
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.MistyRose
        Me.btnStart.Location = New System.Drawing.Point(249, 563)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(148, 44)
        Me.btnStart.TabIndex = 13
        Me.btnStart.Text = "GET STARTED!"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.BackColor = System.Drawing.Color.Black
        Me.lblDays.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.ForeColor = System.Drawing.Color.White
        Me.lblDays.Location = New System.Drawing.Point(280, 182)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(42, 19)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "DAY"
        '
        'lblSingup
        '
        Me.lblSingup.AutoSize = True
        Me.lblSingup.BackColor = System.Drawing.Color.Transparent
        Me.lblSingup.Font = New System.Drawing.Font("Berlin Sans FB Demi", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSingup.ForeColor = System.Drawing.SystemColors.Menu
        Me.lblSingup.Location = New System.Drawing.Point(6, 52)
        Me.lblSingup.Name = "lblSingup"
        Me.lblSingup.Size = New System.Drawing.Size(189, 37)
        Me.lblSingup.TabIndex = 0
        Me.lblSingup.Text = "Just sign up!"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Black
        Me.lblName.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(74, 115)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(67, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "NAME"
        '
        'lblFavourites
        '
        Me.lblFavourites.AutoSize = True
        Me.lblFavourites.BackColor = System.Drawing.Color.Black
        Me.lblFavourites.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavourites.ForeColor = System.Drawing.Color.White
        Me.lblFavourites.Location = New System.Drawing.Point(9, 284)
        Me.lblFavourites.Name = "lblFavourites"
        Me.lblFavourites.Size = New System.Drawing.Size(132, 22)
        Me.lblFavourites.TabIndex = 0
        Me.lblFavourites.Text = "FAVOURITES"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Black
        Me.lblEmail.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(69, 240)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(72, 24)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "EMAIL"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Black
        Me.lblUsername.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(25, 390)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(116, 24)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "USERNAME"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Black
        Me.lblPassword.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(23, 439)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(118, 24)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "PASSWORD"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.BackColor = System.Drawing.Color.Black
        Me.lblMonth.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ForeColor = System.Drawing.Color.White
        Me.lblMonth.Location = New System.Drawing.Point(182, 182)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(69, 19)
        Me.lblMonth.TabIndex = 0
        Me.lblMonth.Text = "MONTH"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Black
        Me.lblYear.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.White
        Me.lblYear.Location = New System.Drawing.Point(357, 184)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(50, 19)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "YEAR"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(158, 108)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(262, 31)
        Me.txtName.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(602, 523)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(79, 40)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        Me.btnOK.Visible = False
        '
        'btnCAncel
        '
        Me.btnCAncel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCAncel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCAncel.Location = New System.Drawing.Point(774, 9)
        Me.btnCAncel.Name = "btnCAncel"
        Me.btnCAncel.Size = New System.Drawing.Size(75, 27)
        Me.btnCAncel.TabIndex = 16
        Me.btnCAncel.Text = "Cancel"
        Me.btnCAncel.UseVisualStyleBackColor = False
        '
        'frmSignupform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.finalproject.My.Resources.Resources._2013_09_F1_Car_Motion_Wallpaper_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(867, 622)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCAncel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblFavourites)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblSingup)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblFav)
        Me.Controls.Add(Me.NumUpdowndays)
        Me.Controls.Add(Me.numUpdownage)
        Me.Controls.Add(Me.lblRace)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.cmbFavourites)
        Me.Controls.Add(Me.lblEntercode)
        Me.Controls.Add(Me.txtVerCode)
        Me.Controls.Add(Me.lblVercode)
        Me.Controls.Add(Me.picboxVercode)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.radioFemale)
        Me.Controls.Add(Me.radioMale)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblBirthdate)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSignupform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "signupform"
        CType(Me.NumUpdowndays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpdownage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxVercode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFav As System.Windows.Forms.Label
    Friend WithEvents NumUpdowndays As System.Windows.Forms.NumericUpDown
    Friend WithEvents numUpdownage As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRace As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFavourites As System.Windows.Forms.ComboBox
    Friend WithEvents lblEntercode As System.Windows.Forms.Label
    Friend WithEvents txtVerCode As System.Windows.Forms.TextBox
    Friend WithEvents lblVercode As System.Windows.Forms.Label
    Friend WithEvents picboxVercode As System.Windows.Forms.PictureBox
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.Label
    Friend WithEvents radioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radioMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblBirthdate As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents lblSingup As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblFavourites As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCAncel As System.Windows.Forms.Button
End Class
