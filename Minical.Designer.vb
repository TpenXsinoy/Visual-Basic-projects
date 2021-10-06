<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMinical
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txbY = New System.Windows.Forms.TextBox()
        Me.txbX = New System.Windows.Forms.TextBox()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMul = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Silver
        Me.btnExit.Location = New System.Drawing.Point(16, 26)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txbY
        '
        Me.txbY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbY.Location = New System.Drawing.Point(207, 77)
        Me.txbY.Multiline = True
        Me.txbY.Name = "txbY"
        Me.txbY.Size = New System.Drawing.Size(111, 45)
        Me.txbY.TabIndex = 2
        '
        'txbX
        '
        Me.txbX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbX.Location = New System.Drawing.Point(40, 77)
        Me.txbX.Multiline = True
        Me.txbX.Name = "txbX"
        Me.txbX.Size = New System.Drawing.Size(111, 45)
        Me.txbX.TabIndex = 1
        '
        'btnDiv
        '
        Me.btnDiv.BackColor = System.Drawing.Color.Gray
        Me.btnDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.Location = New System.Drawing.Point(284, 202)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(67, 60)
        Me.btnDiv.TabIndex = 7
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = False
        '
        'btnMul
        '
        Me.btnMul.BackColor = System.Drawing.Color.Gray
        Me.btnMul.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMul.Location = New System.Drawing.Point(195, 202)
        Me.btnMul.Name = "btnMul"
        Me.btnMul.Size = New System.Drawing.Size(67, 60)
        Me.btnMul.TabIndex = 6
        Me.btnMul.Text = "*"
        Me.btnMul.UseVisualStyleBackColor = False
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.Gray
        Me.btnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.Location = New System.Drawing.Point(106, 202)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(67, 60)
        Me.btnSub.TabIndex = 5
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gray
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(24, 202)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(67, 60)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblAns
        '
        Me.lblAns.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblAns.Location = New System.Drawing.Point(131, 139)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(101, 31)
        Me.lblAns.TabIndex = 3
        Me.lblAns.Text = "GOOOO"
        '
        'frmMinical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.finalproject.My.Resources.Resources.images__1_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(378, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txbY)
        Me.Controls.Add(Me.txbX)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMul)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblAns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMinical"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minical"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txbY As System.Windows.Forms.TextBox
    Friend WithEvents txbX As System.Windows.Forms.TextBox
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnMul As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblAns As System.Windows.Forms.Label
End Class
