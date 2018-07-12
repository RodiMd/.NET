<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYieldBeamDesign
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboBarType = New System.Windows.Forms.ComboBox()
        Me.cboQuantityOfBars = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAsteel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFy = New System.Windows.Forms.TextBox()
        Me.txth = New System.Windows.Forms.TextBox()
        Me.txtd = New System.Windows.Forms.TextBox()
        Me.txtb = New System.Windows.Forms.TextBox()
        Me.lblAc = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.txtfcomp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbla = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEy = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblMn = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblAst = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpShearReinforcement = New System.Windows.Forms.GroupBox()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.radSpiral = New System.Windows.Forms.RadioButton()
        Me.radStirrups = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblYield = New System.Windows.Forms.Label()
        Me.lblfi = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpShearReinforcement.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Height - h (in):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(151, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Depth - d (in):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Width - b (in):"
        '
        'cboBarType
        '
        Me.cboBarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBarType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBarType.FormattingEnabled = True
        Me.cboBarType.Location = New System.Drawing.Point(243, 96)
        Me.cboBarType.Name = "cboBarType"
        Me.cboBarType.Size = New System.Drawing.Size(44, 24)
        Me.cboBarType.TabIndex = 4
        '
        'cboQuantityOfBars
        '
        Me.cboQuantityOfBars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuantityOfBars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuantityOfBars.FormattingEnabled = True
        Me.cboQuantityOfBars.Location = New System.Drawing.Point(243, 126)
        Me.cboQuantityOfBars.Name = "cboQuantityOfBars"
        Me.cboQuantityOfBars.Size = New System.Drawing.Size(44, 24)
        Me.cboQuantityOfBars.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(133, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Quantity of Bars:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(198, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "#Bar:"
        '
        'lblAsteel
        '
        Me.lblAsteel.BackColor = System.Drawing.Color.White
        Me.lblAsteel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAsteel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsteel.Location = New System.Drawing.Point(586, 293)
        Me.lblAsteel.Name = "lblAsteel"
        Me.lblAsteel.Size = New System.Drawing.Size(44, 22)
        Me.lblAsteel.TabIndex = 6
        Me.lblAsteel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(427, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Area of Steel - As (sq.in):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Yield Strength of Steel - fy (ksi):"
        '
        'txtFy
        '
        Me.txtFy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFy.Location = New System.Drawing.Point(243, 184)
        Me.txtFy.Name = "txtFy"
        Me.txtFy.Size = New System.Drawing.Size(44, 22)
        Me.txtFy.TabIndex = 8
        Me.txtFy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txth
        '
        Me.txth.Location = New System.Drawing.Point(243, 18)
        Me.txth.Name = "txth"
        Me.txth.Size = New System.Drawing.Size(44, 20)
        Me.txth.TabIndex = 0
        Me.txth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtd
        '
        Me.txtd.Location = New System.Drawing.Point(243, 44)
        Me.txtd.Name = "txtd"
        Me.txtd.Size = New System.Drawing.Size(44, 20)
        Me.txtd.TabIndex = 1
        Me.txtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtb
        '
        Me.txtb.Location = New System.Drawing.Point(243, 70)
        Me.txtb.Name = "txtb"
        Me.txtb.Size = New System.Drawing.Size(44, 20)
        Me.txtb.TabIndex = 2
        Me.txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAc
        '
        Me.lblAc.BackColor = System.Drawing.Color.White
        Me.lblAc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAc.Location = New System.Drawing.Point(586, 264)
        Me.lblAc.Name = "lblAc"
        Me.lblAc.Size = New System.Drawing.Size(44, 22)
        Me.lblAc.TabIndex = 3
        Me.lblAc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(404, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Area of Concrete - Ac (sq.in):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(380, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Tensile Force in Rebar - T(kips):"
        '
        'lblT
        '
        Me.lblT.BackColor = System.Drawing.Color.White
        Me.lblT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.Location = New System.Drawing.Point(586, 323)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(44, 22)
        Me.lblT.TabIndex = 9
        Me.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtfcomp
        '
        Me.txtfcomp.Location = New System.Drawing.Point(243, 212)
        Me.txtfcomp.Name = "txtfcomp"
        Me.txtfcomp.Size = New System.Drawing.Size(44, 20)
        Me.txtfcomp.TabIndex = 10
        Me.txtfcomp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Concrete Strength - fc'(ksi):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(564, 354)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "a:"
        '
        'lbla
        '
        Me.lbla.BackColor = System.Drawing.Color.White
        Me.lbla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbla.Location = New System.Drawing.Point(586, 349)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(44, 22)
        Me.lbla.TabIndex = 11
        Me.lbla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(387, 385)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 16)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Does the Reinforcement Yield?"
        '
        'txtEy
        '
        Me.txtEy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEy.Location = New System.Drawing.Point(243, 156)
        Me.txtEy.Name = "txtEy"
        Me.txtEy.Size = New System.Drawing.Size(44, 22)
        Me.txtEy.TabIndex = 7
        Me.txtEy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(183, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Modulus of Elasiticy - Ey (ksi):"
        '
        'lblMn
        '
        Me.lblMn.BackColor = System.Drawing.Color.White
        Me.lblMn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMn.Location = New System.Drawing.Point(586, 437)
        Me.lblMn.Name = "lblMn"
        Me.lblMn.Size = New System.Drawing.Size(44, 20)
        Me.lblMn.TabIndex = 32
        Me.lblMn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(372, 438)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 16)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Nominal Moment Cap- Mn (kip-in):"
        '
        'lblAst
        '
        Me.lblAst.BackColor = System.Drawing.Color.White
        Me.lblAst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAst.Location = New System.Drawing.Point(586, 466)
        Me.lblAst.Name = "lblAst"
        Me.lblAst.Size = New System.Drawing.Size(44, 20)
        Me.lblAst.TabIndex = 34
        Me.lblAst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(389, 467)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(191, 16)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Minimum Asteel - Asmin (sq.in):"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Beam_Design.My.Resources.Resources.SideView
        Me.PictureBox1.Location = New System.Drawing.Point(11, 264)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(342, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Beam_Design.My.Resources.Resources.Beam
        Me.PictureBox2.Location = New System.Drawing.Point(351, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(229, 232)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpShearReinforcement)
        Me.GroupBox1.Controls.Add(Me.txth)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboBarType)
        Me.GroupBox1.Controls.Add(Me.cboQuantityOfBars)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtFy)
        Me.GroupBox1.Controls.Add(Me.txtd)
        Me.GroupBox1.Controls.Add(Me.txtb)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtfcomp)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 242)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'grpShearReinforcement
        '
        Me.grpShearReinforcement.Controls.Add(Me.radNone)
        Me.grpShearReinforcement.Controls.Add(Me.radSpiral)
        Me.grpShearReinforcement.Controls.Add(Me.radStirrups)
        Me.grpShearReinforcement.Location = New System.Drawing.Point(6, 11)
        Me.grpShearReinforcement.Name = "grpShearReinforcement"
        Me.grpShearReinforcement.Size = New System.Drawing.Size(123, 109)
        Me.grpShearReinforcement.TabIndex = 47
        Me.grpShearReinforcement.TabStop = False
        Me.grpShearReinforcement.Text = "Shear Reinforcement"
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(16, 19)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(51, 17)
        Me.radNone.TabIndex = 42
        Me.radNone.TabStop = True
        Me.radNone.Text = "None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'radSpiral
        '
        Me.radSpiral.AutoSize = True
        Me.radSpiral.Location = New System.Drawing.Point(16, 80)
        Me.radSpiral.Name = "radSpiral"
        Me.radSpiral.Size = New System.Drawing.Size(51, 17)
        Me.radSpiral.TabIndex = 44
        Me.radSpiral.TabStop = True
        Me.radSpiral.Text = "Spiral"
        Me.radSpiral.UseVisualStyleBackColor = True
        '
        'radStirrups
        '
        Me.radStirrups.AutoSize = True
        Me.radStirrups.Location = New System.Drawing.Point(16, 48)
        Me.radStirrups.Name = "radStirrups"
        Me.radStirrups.Size = New System.Drawing.Size(60, 17)
        Me.radStirrups.TabIndex = 43
        Me.radStirrups.TabStop = True
        Me.radStirrups.Text = "Stirrups"
        Me.radStirrups.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(589, 50)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(60, 30)
        Me.btnCalculate.TabIndex = 39
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(589, 97)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 30)
        Me.btnClear.TabIndex = 40
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(589, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 30)
        Me.btnExit.TabIndex = 41
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblYield
        '
        Me.lblYield.BackColor = System.Drawing.Color.White
        Me.lblYield.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYield.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYield.Location = New System.Drawing.Point(586, 379)
        Me.lblYield.Name = "lblYield"
        Me.lblYield.Size = New System.Drawing.Size(44, 22)
        Me.lblYield.TabIndex = 42
        Me.lblYield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfi
        '
        Me.lblfi.BackColor = System.Drawing.Color.White
        Me.lblfi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfi.Location = New System.Drawing.Point(586, 409)
        Me.lblfi.Name = "lblfi"
        Me.lblfi.Size = New System.Drawing.Size(44, 22)
        Me.lblfi.TabIndex = 44
        Me.lblfi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(397, 412)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(183, 16)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Strength Reduction Factor - ø:"
        '
        'frmYieldBeamDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.ClientSize = New System.Drawing.Size(661, 496)
        Me.Controls.Add(Me.lblfi)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblYield)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAst)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblMn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblAc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAsteel)
        Me.Name = "frmYieldBeamDesign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assumed_Yield_Design"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpShearReinforcement.ResumeLayout(False)
        Me.grpShearReinforcement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboBarType As System.Windows.Forms.ComboBox
    Friend WithEvents cboQuantityOfBars As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblAsteel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFy As System.Windows.Forms.TextBox
    Friend WithEvents txth As System.Windows.Forms.TextBox
    Friend WithEvents txtd As System.Windows.Forms.TextBox
    Friend WithEvents txtb As System.Windows.Forms.TextBox
    Friend WithEvents lblAc As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents txtfcomp As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbla As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEy As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMn As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblAst As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblYield As System.Windows.Forms.Label
    Friend WithEvents grpShearReinforcement As System.Windows.Forms.GroupBox
    Friend WithEvents radNone As System.Windows.Forms.RadioButton
    Friend WithEvents radSpiral As System.Windows.Forms.RadioButton
    Friend WithEvents radStirrups As System.Windows.Forms.RadioButton
    Friend WithEvents lblfi As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
