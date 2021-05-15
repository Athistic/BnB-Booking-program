<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileColorBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileColorBackBlack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileColorBackRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileColorBackWhite = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileColorBackBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileColorFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileColorFontBlack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileColorFontWhite = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileColorFontRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpBooking = New System.Windows.Forms.GroupBox()
        Me.mskCell = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.rdSingle = New System.Windows.Forms.RadioButton()
        Me.grpBedroomType = New System.Windows.Forms.GroupBox()
        Me.chkBed = New System.Windows.Forms.CheckBox()
        Me.rdSuite = New System.Windows.Forms.RadioButton()
        Me.rdDouble = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotexcVat = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtTotDue = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.bnbLogoPic = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.grpBooking.SuspendLayout()
        Me.grpBedroomType.SuspendLayout()
        CType(Me.bnbLogoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.BackgroundColorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileColor})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileColor
        '
        Me.mnuFileColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileColorBack, Me.mnuFileColorFont})
        Me.mnuFileColor.Name = "mnuFileColor"
        Me.mnuFileColor.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuFileColor.Size = New System.Drawing.Size(145, 22)
        Me.mnuFileColor.Text = "Color"
        '
        'mnuFileColorBack
        '
        Me.mnuFileColorBack.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileColorBackBlack, Me.mnuFileColorBackRed, Me.mnuFileColorBackWhite, Me.mnuFileColorBackBlue})
        Me.mnuFileColorBack.Name = "mnuFileColorBack"
        Me.mnuFileColorBack.Size = New System.Drawing.Size(168, 22)
        Me.mnuFileColorBack.Text = "Background color"
        '
        'mnuFileColorBackBlack
        '
        Me.mnuFileColorBackBlack.Name = "mnuFileColorBackBlack"
        Me.mnuFileColorBackBlack.Size = New System.Drawing.Size(105, 22)
        Me.mnuFileColorBackBlack.Text = "Black"
        '
        'mnuFileColorBackRed
        '
        Me.mnuFileColorBackRed.Name = "mnuFileColorBackRed"
        Me.mnuFileColorBackRed.Size = New System.Drawing.Size(105, 22)
        Me.mnuFileColorBackRed.Text = "Red"
        '
        'mnuFileColorBackWhite
        '
        Me.mnuFileColorBackWhite.Name = "mnuFileColorBackWhite"
        Me.mnuFileColorBackWhite.Size = New System.Drawing.Size(105, 22)
        Me.mnuFileColorBackWhite.Text = "White"
        '
        'mnuFileColorBackBlue
        '
        Me.mnuFileColorBackBlue.Name = "mnuFileColorBackBlue"
        Me.mnuFileColorBackBlue.Size = New System.Drawing.Size(105, 22)
        Me.mnuFileColorBackBlue.Text = "Blue"
        '
        'mnuFileColorFont
        '
        Me.mnuFileColorFont.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileColorFontBlack, Me.mnuFileColorFontWhite, Me.mnuFileColorFontRed})
        Me.mnuFileColorFont.Name = "mnuFileColorFont"
        Me.mnuFileColorFont.Size = New System.Drawing.Size(168, 22)
        Me.mnuFileColorFont.Text = "Font Color"
        '
        'mnuFileColorFontBlack
        '
        Me.mnuFileColorFontBlack.Name = "mnuFileColorFontBlack"
        Me.mnuFileColorFontBlack.Size = New System.Drawing.Size(105, 22)
        Me.mnuFileColorFontBlack.Text = "Black"
        '
        'mnuFileColorFontWhite
        '
        Me.mnuFileColorFontWhite.Name = "mnuFileColorFontWhite"
        Me.mnuFileColorFontWhite.Size = New System.Drawing.Size(105, 22)
        Me.mnuFileColorFontWhite.Text = "White"
        '
        'mnuFileColorFontRed
        '
        Me.mnuFileColorFontRed.Name = "mnuFileColorFontRed"
        Me.mnuFileColorFontRed.Size = New System.Drawing.Size(105, 22)
        Me.mnuFileColorFontRed.Text = "Red"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontColorToolStripMenuItem})
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.BackgroundColorToolStripMenuItem.Text = "Close"
        '
        'FontColorToolStripMenuItem
        '
        Me.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem"
        Me.FontColorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.FontColorToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.FontColorToolStripMenuItem.Text = "Exit"
        '
        'grpBooking
        '
        Me.grpBooking.Controls.Add(Me.mskCell)
        Me.grpBooking.Controls.Add(Me.Label4)
        Me.grpBooking.Controls.Add(Me.Label3)
        Me.grpBooking.Controls.Add(Me.Label2)
        Me.grpBooking.Controls.Add(Me.Label1)
        Me.grpBooking.Controls.Add(Me.txtDays)
        Me.grpBooking.Controls.Add(Me.txtSurname)
        Me.grpBooking.Controls.Add(Me.txtName)
        Me.grpBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBooking.ForeColor = System.Drawing.Color.Maroon
        Me.grpBooking.Location = New System.Drawing.Point(0, 123)
        Me.grpBooking.Name = "grpBooking"
        Me.grpBooking.Size = New System.Drawing.Size(289, 200)
        Me.grpBooking.TabIndex = 1
        Me.grpBooking.TabStop = False
        Me.grpBooking.Text = "Booking Details"
        '
        'mskCell
        '
        Me.mskCell.Location = New System.Drawing.Point(101, 128)
        Me.mskCell.Mask = "(999) 000-0000"
        Me.mskCell.Name = "mskCell"
        Me.mskCell.Size = New System.Drawing.Size(188, 20)
        Me.mskCell.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(6, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Days staying"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(6, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Customer cell"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(6, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Customer surname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer name"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(214, 174)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(75, 20)
        Me.txtDays.TabIndex = 7
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(101, 78)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(188, 20)
        Me.txtSurname.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(101, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(188, 20)
        Me.txtName.TabIndex = 4
        '
        'rdSingle
        '
        Me.rdSingle.AutoSize = True
        Me.rdSingle.Checked = True
        Me.rdSingle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSingle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdSingle.Location = New System.Drawing.Point(6, 28)
        Me.rdSingle.Name = "rdSingle"
        Me.rdSingle.Size = New System.Drawing.Size(89, 17)
        Me.rdSingle.TabIndex = 2
        Me.rdSingle.TabStop = True
        Me.rdSingle.Text = "Single (R500)"
        Me.rdSingle.UseVisualStyleBackColor = True
        '
        'grpBedroomType
        '
        Me.grpBedroomType.Controls.Add(Me.chkBed)
        Me.grpBedroomType.Controls.Add(Me.rdSuite)
        Me.grpBedroomType.Controls.Add(Me.rdDouble)
        Me.grpBedroomType.Controls.Add(Me.rdSingle)
        Me.grpBedroomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBedroomType.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpBedroomType.Location = New System.Drawing.Point(546, 123)
        Me.grpBedroomType.Name = "grpBedroomType"
        Me.grpBedroomType.Size = New System.Drawing.Size(200, 200)
        Me.grpBedroomType.TabIndex = 3
        Me.grpBedroomType.TabStop = False
        Me.grpBedroomType.Text = "Bedroom types"
        '
        'chkBed
        '
        Me.chkBed.AutoSize = True
        Me.chkBed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkBed.Location = New System.Drawing.Point(6, 170)
        Me.chkBed.Name = "chkBed"
        Me.chkBed.Size = New System.Drawing.Size(118, 17)
        Me.chkBed.TabIndex = 5
        Me.chkBed.Text = "Extra bed? (+R250)"
        Me.chkBed.UseVisualStyleBackColor = True
        '
        'rdSuite
        '
        Me.rdSuite.AutoSize = True
        Me.rdSuite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSuite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdSuite.Location = New System.Drawing.Point(6, 127)
        Me.rdSuite.Name = "rdSuite"
        Me.rdSuite.Size = New System.Drawing.Size(90, 17)
        Me.rdSuite.TabIndex = 4
        Me.rdSuite.Text = "Suite (R1000)"
        Me.rdSuite.UseVisualStyleBackColor = True
        '
        'rdDouble
        '
        Me.rdDouble.AutoSize = True
        Me.rdDouble.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDouble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdDouble.Location = New System.Drawing.Point(6, 74)
        Me.rdDouble.Name = "rdDouble"
        Me.rdDouble.Size = New System.Drawing.Size(94, 17)
        Me.rdDouble.TabIndex = 3
        Me.rdDouble.Text = "Double (R800)"
        Me.rdDouble.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total exc Vat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Due"
        '
        'txtTotexcVat
        '
        Me.txtTotexcVat.Location = New System.Drawing.Point(371, 193)
        Me.txtTotexcVat.Name = "txtTotexcVat"
        Me.txtTotexcVat.Size = New System.Drawing.Size(128, 20)
        Me.txtTotexcVat.TabIndex = 12
        '
        'txtVat
        '
        Me.txtVat.Location = New System.Drawing.Point(371, 236)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(128, 20)
        Me.txtVat.TabIndex = 13
        '
        'txtTotDue
        '
        Me.txtTotDue.Location = New System.Drawing.Point(371, 288)
        Me.txtTotDue.Name = "txtTotDue"
        Me.txtTotDue.Size = New System.Drawing.Size(127, 20)
        Me.txtTotDue.TabIndex = 14
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(371, 326)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(61, 37)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Calculates totals")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(685, 326)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(61, 37)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(438, 327)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(61, 36)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clears all user input")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'bnbLogoPic
        '
        Me.bnbLogoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bnbLogoPic.Image = Global.BnB_Booking.My.Resources.Resources.images__4_
        Me.bnbLogoPic.Location = New System.Drawing.Point(329, 27)
        Me.bnbLogoPic.Name = "bnbLogoPic"
        Me.bnbLogoPic.Size = New System.Drawing.Size(189, 112)
        Me.bnbLogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bnbLogoPic.TabIndex = 18
        Me.bnbLogoPic.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bnbLogoPic)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTotDue)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.txtTotexcVat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grpBedroomType)
        Me.Controls.Add(Me.grpBooking)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "ATHI'S B&B"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpBooking.ResumeLayout(False)
        Me.grpBooking.PerformLayout()
        Me.grpBedroomType.ResumeLayout(False)
        Me.grpBedroomType.PerformLayout()
        CType(Me.bnbLogoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileColor As ToolStripMenuItem
    Friend WithEvents mnuFileColorBack As ToolStripMenuItem
    Friend WithEvents mnuFileColorBackBlack As ToolStripMenuItem
    Friend WithEvents mnuFileColorBackRed As ToolStripMenuItem
    Friend WithEvents mnuFileColorBackWhite As ToolStripMenuItem
    Friend WithEvents mnuFileColorBackBlue As ToolStripMenuItem
    Friend WithEvents mnuFileColorFont As ToolStripMenuItem
    Friend WithEvents mnuFileColorFontBlack As ToolStripMenuItem
    Friend WithEvents mnuFileColorFontWhite As ToolStripMenuItem
    Friend WithEvents mnuFileColorFontRed As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpBooking As GroupBox
    Friend WithEvents rdSingle As RadioButton
    Friend WithEvents grpBedroomType As GroupBox
    Friend WithEvents rdSuite As RadioButton
    Friend WithEvents rdDouble As RadioButton
    Friend WithEvents txtName As TextBox
    Friend WithEvents chkBed As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents mskCell As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotexcVat As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtTotDue As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents bnbLogoPic As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
