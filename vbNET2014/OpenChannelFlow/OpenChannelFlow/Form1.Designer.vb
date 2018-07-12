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
        Dim gbxInput As System.Windows.Forms.GroupBox
        Dim gbxOutput As System.Windows.Forms.GroupBox
        Me.txtChannelSlope = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChannelDepth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChannelWidth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSideSlope2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSideSlope1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMannings = New System.Windows.Forms.TextBox()
        Me.txtFlowDepth = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblFlowArea = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFreeboard = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblHyadRad = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFroude = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblWettedPerimeter = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblFlowVelocity = New System.Windows.Forms.Label()
        Me.lblFlow = New System.Windows.Forms.Label()
        Me.btnClearField = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        gbxInput = New System.Windows.Forms.GroupBox()
        gbxOutput = New System.Windows.Forms.GroupBox()
        gbxInput.SuspendLayout()
        gbxOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInput
        '
        gbxInput.Controls.Add(Me.txtChannelSlope)
        gbxInput.Controls.Add(Me.Label13)
        gbxInput.Controls.Add(Me.Label1)
        gbxInput.Controls.Add(Me.Label2)
        gbxInput.Controls.Add(Me.txtChannelDepth)
        gbxInput.Controls.Add(Me.Label3)
        gbxInput.Controls.Add(Me.txtChannelWidth)
        gbxInput.Controls.Add(Me.Label4)
        gbxInput.Controls.Add(Me.txtSideSlope2)
        gbxInput.Controls.Add(Me.Label5)
        gbxInput.Controls.Add(Me.txtSideSlope1)
        gbxInput.Controls.Add(Me.Label6)
        gbxInput.Controls.Add(Me.txtMannings)
        gbxInput.Controls.Add(Me.txtFlowDepth)
        gbxInput.ForeColor = System.Drawing.Color.Black
        gbxInput.Location = New System.Drawing.Point(25, 41)
        gbxInput.Name = "gbxInput"
        gbxInput.Size = New System.Drawing.Size(207, 235)
        gbxInput.TabIndex = 3
        gbxInput.TabStop = False
        gbxInput.Text = "Input"
        '
        'txtChannelSlope
        '
        Me.txtChannelSlope.Location = New System.Drawing.Point(137, 206)
        Me.txtChannelSlope.Name = "txtChannelSlope"
        Me.txtChannelSlope.Size = New System.Drawing.Size(50, 20)
        Me.txtChannelSlope.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Channel Slope:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Flow Depth:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Manning's #:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtChannelDepth
        '
        Me.txtChannelDepth.Location = New System.Drawing.Point(137, 175)
        Me.txtChannelDepth.Name = "txtChannelDepth"
        Me.txtChannelDepth.Size = New System.Drawing.Size(50, 20)
        Me.txtChannelDepth.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Z1:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtChannelWidth
        '
        Me.txtChannelWidth.Location = New System.Drawing.Point(137, 145)
        Me.txtChannelWidth.Name = "txtChannelWidth"
        Me.txtChannelWidth.Size = New System.Drawing.Size(50, 20)
        Me.txtChannelWidth.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Z2:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSideSlope2
        '
        Me.txtSideSlope2.Location = New System.Drawing.Point(137, 116)
        Me.txtSideSlope2.Name = "txtSideSlope2"
        Me.txtSideSlope2.Size = New System.Drawing.Size(50, 20)
        Me.txtSideSlope2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Channel Height:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSideSlope1
        '
        Me.txtSideSlope1.Location = New System.Drawing.Point(137, 85)
        Me.txtSideSlope1.Name = "txtSideSlope1"
        Me.txtSideSlope1.Size = New System.Drawing.Size(50, 20)
        Me.txtSideSlope1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Channel Width:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMannings
        '
        Me.txtMannings.Location = New System.Drawing.Point(137, 55)
        Me.txtMannings.Name = "txtMannings"
        Me.txtMannings.Size = New System.Drawing.Size(50, 20)
        Me.txtMannings.TabIndex = 1
        '
        'txtFlowDepth
        '
        Me.txtFlowDepth.Location = New System.Drawing.Point(137, 25)
        Me.txtFlowDepth.Name = "txtFlowDepth"
        Me.txtFlowDepth.Size = New System.Drawing.Size(50, 20)
        Me.txtFlowDepth.TabIndex = 0
        '
        'gbxOutput
        '
        gbxOutput.Controls.Add(Me.Label14)
        gbxOutput.Controls.Add(Me.lblFlowArea)
        gbxOutput.Controls.Add(Me.Label7)
        gbxOutput.Controls.Add(Me.Label8)
        gbxOutput.Controls.Add(Me.lblFreeboard)
        gbxOutput.Controls.Add(Me.Label9)
        gbxOutput.Controls.Add(Me.lblHyadRad)
        gbxOutput.Controls.Add(Me.Label10)
        gbxOutput.Controls.Add(Me.lblFroude)
        gbxOutput.Controls.Add(Me.Label11)
        gbxOutput.Controls.Add(Me.lblWettedPerimeter)
        gbxOutput.Controls.Add(Me.Label12)
        gbxOutput.Controls.Add(Me.lblFlowVelocity)
        gbxOutput.Controls.Add(Me.lblFlow)
        gbxOutput.ForeColor = System.Drawing.Color.Black
        gbxOutput.Location = New System.Drawing.Point(258, 41)
        gbxOutput.Name = "gbxOutput"
        gbxOutput.Size = New System.Drawing.Size(207, 235)
        gbxOutput.TabIndex = 4
        gbxOutput.TabStop = False
        gbxOutput.Text = "Output"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(34, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 16)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Flow Area sq.ft:"
        '
        'lblFlowArea
        '
        Me.lblFlowArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFlowArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowArea.Location = New System.Drawing.Point(138, 82)
        Me.lblFlowArea.Name = "lblFlowArea"
        Me.lblFlowArea.Size = New System.Drawing.Size(50, 20)
        Me.lblFlowArea.TabIndex = 2
        Me.lblFlowArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(73, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Flow cfs:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Flow Velocity fps:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFreeboard
        '
        Me.lblFreeboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFreeboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreeboard.Location = New System.Drawing.Point(138, 203)
        Me.lblFreeboard.Name = "lblFreeboard"
        Me.lblFreeboard.Size = New System.Drawing.Size(50, 20)
        Me.lblFreeboard.TabIndex = 6
        Me.lblFreeboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Wetted Perimeter ft:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHyadRad
        '
        Me.lblHyadRad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHyadRad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHyadRad.Location = New System.Drawing.Point(138, 142)
        Me.lblHyadRad.Name = "lblHyadRad"
        Me.lblHyadRad.Size = New System.Drawing.Size(50, 20)
        Me.lblHyadRad.TabIndex = 4
        Me.lblHyadRad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(68, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Froude #:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFroude
        '
        Me.lblFroude.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFroude.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFroude.Location = New System.Drawing.Point(138, 172)
        Me.lblFroude.Name = "lblFroude"
        Me.lblFroude.Size = New System.Drawing.Size(50, 20)
        Me.lblFroude.TabIndex = 5
        Me.lblFroude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Hydraulic Radius:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWettedPerimeter
        '
        Me.lblWettedPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWettedPerimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWettedPerimeter.Location = New System.Drawing.Point(138, 113)
        Me.lblWettedPerimeter.Name = "lblWettedPerimeter"
        Me.lblWettedPerimeter.Size = New System.Drawing.Size(50, 20)
        Me.lblWettedPerimeter.TabIndex = 3
        Me.lblWettedPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(48, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Freeboard ft:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFlowVelocity
        '
        Me.lblFlowVelocity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFlowVelocity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowVelocity.Location = New System.Drawing.Point(138, 55)
        Me.lblFlowVelocity.Name = "lblFlowVelocity"
        Me.lblFlowVelocity.Size = New System.Drawing.Size(50, 20)
        Me.lblFlowVelocity.TabIndex = 1
        Me.lblFlowVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFlow
        '
        Me.lblFlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlow.Location = New System.Drawing.Point(138, 27)
        Me.lblFlow.Name = "lblFlow"
        Me.lblFlow.Size = New System.Drawing.Size(50, 20)
        Me.lblFlow.TabIndex = 0
        Me.lblFlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClearField
        '
        Me.btnClearField.Location = New System.Drawing.Point(196, 302)
        Me.btnClearField.Name = "btnClearField"
        Me.btnClearField.Size = New System.Drawing.Size(100, 30)
        Me.btnClearField.TabIndex = 1
        Me.btnClearField.Text = "Clea&r Fields"
        Me.btnClearField.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(62, 302)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 30)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(329, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 382)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClearField)
        Me.Controls.Add(gbxOutput)
        Me.Controls.Add(gbxInput)
        Me.Name = "Form1"
        Me.Text = "OpenChannel"
        gbxInput.ResumeLayout(False)
        gbxInput.PerformLayout()
        gbxOutput.ResumeLayout(False)
        gbxOutput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFlowDepth As System.Windows.Forms.TextBox
    Friend WithEvents txtMannings As System.Windows.Forms.TextBox
    Friend WithEvents txtSideSlope1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSideSlope2 As System.Windows.Forms.TextBox
    Friend WithEvents txtChannelWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtChannelDepth As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblFlow As System.Windows.Forms.Label
    Friend WithEvents lblFlowVelocity As System.Windows.Forms.Label
    Friend WithEvents lblWettedPerimeter As System.Windows.Forms.Label
    Friend WithEvents lblFroude As System.Windows.Forms.Label
    Friend WithEvents lblHyadRad As System.Windows.Forms.Label
    Friend WithEvents lblFreeboard As System.Windows.Forms.Label
    Friend WithEvents btnClearField As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtChannelSlope As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblFlowArea As System.Windows.Forms.Label

End Class
