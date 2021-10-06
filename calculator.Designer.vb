<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblCal = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnCE = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.Btnpoint = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btndivide = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnmultiply = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.White
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(12, 84)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(349, 26)
        Me.lblDisplay.TabIndex = 2
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCal
        '
        Me.lblCal.AutoSize = True
        Me.lblCal.BackColor = System.Drawing.Color.Transparent
        Me.lblCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCal.Location = New System.Drawing.Point(12, 9)
        Me.lblCal.Name = "lblCal"
        Me.lblCal.Size = New System.Drawing.Size(344, 50)
        Me.lblCal.TabIndex = 1
        Me.lblCal.Text = "Use this calculator to calculate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your speed"
        '
        'lblExit
        '
        Me.lblExit.BackColor = System.Drawing.SystemColors.GrayText
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblExit.Location = New System.Drawing.Point(265, 321)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(99, 47)
        Me.lblExit.TabIndex = 23
        Me.lblExit.Text = "EXIT"
        Me.lblExit.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDel.Location = New System.Drawing.Point(265, 266)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(96, 49)
        Me.btnDel.TabIndex = 18
        Me.btnDel.Text = "←"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnCE
        '
        Me.btnCE.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCE.Location = New System.Drawing.Point(265, 211)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(99, 49)
        Me.btnCE.TabIndex = 13
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnadd.Location = New System.Drawing.Point(198, 321)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(61, 49)
        Me.btnadd.TabIndex = 22
        Me.btnadd.Text = "+"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnsub
        '
        Me.btnsub.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnsub.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsub.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsub.Location = New System.Drawing.Point(198, 266)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(61, 49)
        Me.btnsub.TabIndex = 17
        Me.btnsub.Text = "-"
        Me.btnsub.UseVisualStyleBackColor = False
        '
        'btnEquals
        '
        Me.btnEquals.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEquals.Location = New System.Drawing.Point(134, 321)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(58, 47)
        Me.btnEquals.TabIndex = 21
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = False
        '
        'Btnpoint
        '
        Me.Btnpoint.BackColor = System.Drawing.SystemColors.GrayText
        Me.Btnpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnpoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnpoint.Location = New System.Drawing.Point(12, 321)
        Me.Btnpoint.Name = "Btnpoint"
        Me.Btnpoint.Size = New System.Drawing.Size(54, 49)
        Me.Btnpoint.TabIndex = 19
        Me.Btnpoint.Text = "."
        Me.Btnpoint.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn0.Location = New System.Drawing.Point(74, 321)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(54, 48)
        Me.btn0.TabIndex = 20
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btndivide
        '
        Me.btndivide.BackColor = System.Drawing.SystemColors.GrayText
        Me.btndivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndivide.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndivide.Location = New System.Drawing.Point(201, 156)
        Me.btndivide.Name = "btndivide"
        Me.btndivide.Size = New System.Drawing.Size(58, 49)
        Me.btndivide.TabIndex = 7
        Me.btndivide.Text = "÷"
        Me.btndivide.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnC.Location = New System.Drawing.Point(265, 156)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(99, 49)
        Me.btnC.TabIndex = 8
        Me.btnC.Text = "c"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnmultiply
        '
        Me.btnmultiply.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnmultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmultiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmultiply.Location = New System.Drawing.Point(199, 211)
        Me.btnmultiply.Name = "btnmultiply"
        Me.btnmultiply.Size = New System.Drawing.Size(60, 49)
        Me.btnmultiply.TabIndex = 12
        Me.btnmultiply.Text = "x"
        Me.btnmultiply.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.SystemColors.GrayText
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button3.Location = New System.Drawing.Point(134, 266)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(58, 49)
        Me.button3.TabIndex = 16
        Me.button3.Text = "3"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.SystemColors.GrayText
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button2.Location = New System.Drawing.Point(72, 266)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(56, 49)
        Me.button2.TabIndex = 15
        Me.button2.Text = "2"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.SystemColors.GrayText
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button1.Location = New System.Drawing.Point(12, 266)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(54, 49)
        Me.button1.TabIndex = 14
        Me.button1.Text = "1"
        Me.button1.UseVisualStyleBackColor = False
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.SystemColors.GrayText
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button6.Location = New System.Drawing.Point(134, 211)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(58, 49)
        Me.button6.TabIndex = 11
        Me.button6.Text = "6"
        Me.button6.UseVisualStyleBackColor = False
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.SystemColors.GrayText
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button5.Location = New System.Drawing.Point(72, 211)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(56, 49)
        Me.button5.TabIndex = 10
        Me.button5.Text = "5"
        Me.button5.UseVisualStyleBackColor = False
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.SystemColors.GrayText
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button4.Location = New System.Drawing.Point(12, 211)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(54, 49)
        Me.button4.TabIndex = 9
        Me.button4.Text = "4"
        Me.button4.UseVisualStyleBackColor = False
        '
        'button9
        '
        Me.button9.BackColor = System.Drawing.SystemColors.GrayText
        Me.button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button9.Location = New System.Drawing.Point(134, 156)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(58, 49)
        Me.button9.TabIndex = 6
        Me.button9.Text = "9"
        Me.button9.UseVisualStyleBackColor = False
        '
        'button8
        '
        Me.button8.BackColor = System.Drawing.SystemColors.GrayText
        Me.button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button8.Location = New System.Drawing.Point(72, 156)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(56, 49)
        Me.button8.TabIndex = 5
        Me.button8.Text = "8"
        Me.button8.UseVisualStyleBackColor = False
        '
        'button7
        '
        Me.button7.BackColor = System.Drawing.SystemColors.GrayText
        Me.button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.button7.Location = New System.Drawing.Point(12, 156)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(54, 49)
        Me.button7.TabIndex = 4
        Me.button7.Text = "7"
        Me.button7.UseVisualStyleBackColor = False
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(12, 103)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(349, 47)
        Me.txtDisplay.TabIndex = 3
        Me.txtDisplay.Text = "0"
        Me.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.finalproject.My.Resources.Resources.images__1_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(377, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblCal)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnCE)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.Btnpoint)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btndivide)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnmultiply)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button9)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.txtDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CALCULATOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents lblCal As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnCE As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnsub As System.Windows.Forms.Button
    Friend WithEvents btnEquals As System.Windows.Forms.Button
    Friend WithEvents Btnpoint As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btndivide As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnmultiply As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents button6 As System.Windows.Forms.Button
    Friend WithEvents button5 As System.Windows.Forms.Button
    Friend WithEvents button4 As System.Windows.Forms.Button
    Friend WithEvents button9 As System.Windows.Forms.Button
    Friend WithEvents button8 As System.Windows.Forms.Button
    Friend WithEvents button7 As System.Windows.Forms.Button
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
End Class
