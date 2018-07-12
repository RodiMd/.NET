<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTensionControlled
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTensionControlled))
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.grpShearReinforcement = New System.Windows.Forms.GroupBox()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.radSpiral = New System.Windows.Forms.RadioButton()
        Me.radStirrups = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdt = New System.Windows.Forms.TextBox()
        Me.txth = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboBarType = New System.Windows.Forms.ComboBox()
        Me.cboQuantityOfBars = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFy = New System.Windows.Forms.TextBox()
        Me.txtd = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtfcomp = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblYield = New System.Windows.Forms.Label()
        Me.lblAst = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblMn = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblc = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAc = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblAsteel = New System.Windows.Forms.Label()
        Me.lblfi = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtb = New System.Windows.Forms.TextBox()
        Me.grpInput.SuspendLayout()
        Me.grpShearReinforcement.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.txtb)
        Me.grpInput.Controls.Add(Me.grpShearReinforcement)
        Me.grpInput.Controls.Add(Me.Label4)
        Me.grpInput.Controls.Add(Me.txtdt)
        Me.grpInput.Controls.Add(Me.txth)
        Me.grpInput.Controls.Add(Me.Label1)
        Me.grpInput.Controls.Add(Me.Label2)
        Me.grpInput.Controls.Add(Me.Label3)
        Me.grpInput.Controls.Add(Me.cboBarType)
        Me.grpInput.Controls.Add(Me.cboQuantityOfBars)
        Me.grpInput.Controls.Add(Me.Label7)
        Me.grpInput.Controls.Add(Me.txtEy)
        Me.grpInput.Controls.Add(Me.Label6)
        Me.grpInput.Controls.Add(Me.Label12)
        Me.grpInput.Controls.Add(Me.Label8)
        Me.grpInput.Controls.Add(Me.txtFy)
        Me.grpInput.Controls.Add(Me.txtd)
        Me.grpInput.Controls.Add(Me.Label10)
        Me.grpInput.Controls.Add(Me.txtfcomp)
        Me.grpInput.Location = New System.Drawing.Point(12, 12)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(330, 280)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input"
        '
        'grpShearReinforcement
        '
        Me.grpShearReinforcement.Controls.Add(Me.radNone)
        Me.grpShearReinforcement.Controls.Add(Me.radSpiral)
        Me.grpShearReinforcement.Controls.Add(Me.radStirrups)
        Me.grpShearReinforcement.Location = New System.Drawing.Point(6, 19)
        Me.grpShearReinforcement.Name = "grpShearReinforcement"
        Me.grpShearReinforcement.Size = New System.Drawing.Size(123, 109)
        Me.grpShearReinforcement.TabIndex = 9
        Me.grpShearReinforcement.TabStop = False
        Me.grpShearReinforcement.Text = "Shear Reinforcement"
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(16, 19)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(51, 17)
        Me.radNone.TabIndex = 0
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
        Me.radSpiral.TabIndex = 2
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
        Me.radStirrups.TabIndex = 1
        Me.radStirrups.TabStop = True
        Me.radStirrups.Text = "Stirrups"
        Me.radStirrups.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(183, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Depth - dt (in):"
        '
        'txtdt
        '
        Me.txtdt.Location = New System.Drawing.Point(278, 71)
        Me.txtdt.Name = "txtdt"
        Me.txtdt.Size = New System.Drawing.Size(44, 20)
        Me.txtdt.TabIndex = 2
        Me.txtdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txth
        '
        Me.txth.Location = New System.Drawing.Point(278, 20)
        Me.txth.Name = "txth"
        Me.txth.Size = New System.Drawing.Size(44, 20)
        Me.txth.TabIndex = 0
        Me.txth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Height - h (in):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Depth centroid - d (in):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Width - b (in):"
        '
        'cboBarType
        '
        Me.cboBarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBarType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBarType.FormattingEnabled = True
        Me.cboBarType.Location = New System.Drawing.Point(278, 126)
        Me.cboBarType.Name = "cboBarType"
        Me.cboBarType.Size = New System.Drawing.Size(44, 24)
        Me.cboBarType.TabIndex = 4
        '
        'cboQuantityOfBars
        '
        Me.cboQuantityOfBars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuantityOfBars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuantityOfBars.FormattingEnabled = True
        Me.cboQuantityOfBars.Location = New System.Drawing.Point(278, 156)
        Me.cboQuantityOfBars.Name = "cboQuantityOfBars"
        Me.cboQuantityOfBars.Size = New System.Drawing.Size(44, 24)
        Me.cboQuantityOfBars.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(233, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "#Bar:"
        '
        'txtEy
        '
        Me.txtEy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEy.Location = New System.Drawing.Point(278, 186)
        Me.txtEy.Name = "txtEy"
        Me.txtEy.Size = New System.Drawing.Size(44, 22)
        Me.txtEy.TabIndex = 6
        Me.txtEy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(168, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Quantity of Bars:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(89, 189)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(183, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Modulus of Elasiticy - Ey (ksi):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(82, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Yield Strength of Steel - fy (ksi):"
        '
        'txtFy
        '
        Me.txtFy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFy.Location = New System.Drawing.Point(278, 214)
        Me.txtFy.Name = "txtFy"
        Me.txtFy.Size = New System.Drawing.Size(44, 22)
        Me.txtFy.TabIndex = 7
        Me.txtFy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtd
        '
        Me.txtd.Location = New System.Drawing.Point(278, 45)
        Me.txtd.Name = "txtd"
        Me.txtd.Size = New System.Drawing.Size(44, 20)
        Me.txtd.TabIndex = 1
        Me.txtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(107, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Concrete Strength - fc'(ksi):"
        '
        'txtfcomp
        '
        Me.txtfcomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfcomp.Location = New System.Drawing.Point(278, 242)
        Me.txtfcomp.Name = "txtfcomp"
        Me.txtfcomp.Size = New System.Drawing.Size(44, 22)
        Me.txtfcomp.TabIndex = 8
        Me.txtfcomp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(348, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 241)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 298)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(330, 234)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(590, 163)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(590, 119)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(590, 72)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(60, 30)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblYield
        '
        Me.lblYield.BackColor = System.Drawing.Color.White
        Me.lblYield.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYield.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYield.Location = New System.Drawing.Point(590, 413)
        Me.lblYield.Name = "lblYield"
        Me.lblYield.Size = New System.Drawing.Size(90, 22)
        Me.lblYield.TabIndex = 7
        Me.lblYield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAst
        '
        Me.lblAst.BackColor = System.Drawing.Color.White
        Me.lblAst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAst.Location = New System.Drawing.Point(590, 505)
        Me.lblAst.Name = "lblAst"
        Me.lblAst.Size = New System.Drawing.Size(44, 20)
        Me.lblAst.TabIndex = 10
        Me.lblAst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(393, 506)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(191, 16)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Minimum Asteel - Asmin (sq.in):"
        '
        'lblMn
        '
        Me.lblMn.BackColor = System.Drawing.Color.White
        Me.lblMn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMn.Location = New System.Drawing.Point(590, 476)
        Me.lblMn.Name = "lblMn"
        Me.lblMn.Size = New System.Drawing.Size(44, 20)
        Me.lblMn.TabIndex = 9
        Me.lblMn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(376, 477)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Nominal Moment Cap- Mn (kip-in):"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(391, 419)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 16)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Does the Reinforcement Yield?"
        '
        'lblc
        '
        Me.lblc.BackColor = System.Drawing.Color.White
        Me.lblc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc.Location = New System.Drawing.Point(590, 383)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(44, 22)
        Me.lblc.TabIndex = 6
        Me.lblc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(545, 386)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "c (in):"
        '
        'lblT
        '
        Me.lblT.BackColor = System.Drawing.Color.White
        Me.lblT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.Location = New System.Drawing.Point(590, 352)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(44, 22)
        Me.lblT.TabIndex = 5
        Me.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(384, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tensile Force in Rebar - T(kips):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(408, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Area of Concrete - Ac (sq.in):"
        '
        'lblAc
        '
        Me.lblAc.BackColor = System.Drawing.Color.White
        Me.lblAc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAc.Location = New System.Drawing.Point(590, 292)
        Me.lblAc.Name = "lblAc"
        Me.lblAc.Size = New System.Drawing.Size(44, 22)
        Me.lblAc.TabIndex = 3
        Me.lblAc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(431, 322)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 16)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Area of Steel - As (sq.in):"
        '
        'lblAsteel
        '
        Me.lblAsteel.BackColor = System.Drawing.Color.White
        Me.lblAsteel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAsteel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsteel.Location = New System.Drawing.Point(590, 321)
        Me.lblAsteel.Name = "lblAsteel"
        Me.lblAsteel.Size = New System.Drawing.Size(44, 22)
        Me.lblAsteel.TabIndex = 4
        Me.lblAsteel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfi
        '
        Me.lblfi.BackColor = System.Drawing.Color.White
        Me.lblfi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfi.Location = New System.Drawing.Point(590, 445)
        Me.lblfi.Name = "lblfi"
        Me.lblfi.Size = New System.Drawing.Size(44, 22)
        Me.lblfi.TabIndex = 8
        Me.lblfi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(401, 448)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(183, 16)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Strength Reduction Factor - ø:"
        '
        'txtb
        '
        Me.txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb.Location = New System.Drawing.Point(278, 97)
        Me.txtb.Name = "txtb"
        Me.txtb.Size = New System.Drawing.Size(44, 20)
        Me.txtb.TabIndex = 3
        Me.txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmTensionControlled
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(692, 544)
        Me.Controls.Add(Me.lblfi)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblYield)
        Me.Controls.Add(Me.lblAst)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblMn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblAc)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblAsteel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpInput)
        Me.Name = "frmTensionControlled"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tension Controlled"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpShearReinforcement.ResumeLayout(False)
        Me.grpShearReinforcement.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdt As System.Windows.Forms.TextBox
    Friend WithEvents txth As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboBarType As System.Windows.Forms.ComboBox
    Friend WithEvents cboQuantityOfBars As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEy As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFy As System.Windows.Forms.TextBox
    Friend WithEvents txtd As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtfcomp As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblYield As System.Windows.Forms.Label
    Friend WithEvents lblAst As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblMn As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblc As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblAc As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblAsteel As System.Windows.Forms.Label
    Friend WithEvents grpShearReinforcement As System.Windows.Forms.GroupBox
    Friend WithEvents radNone As System.Windows.Forms.RadioButton
    Friend WithEvents radSpiral As System.Windows.Forms.RadioButton
    Friend WithEvents radStirrups As System.Windows.Forms.RadioButton
    Friend WithEvents lblfi As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtb As System.Windows.Forms.TextBox
End Class
