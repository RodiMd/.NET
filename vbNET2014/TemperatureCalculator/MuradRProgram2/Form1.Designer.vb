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
        Me.radBrian = New System.Windows.Forms.RadioButton()
        Me.radMichael = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTemperatureValue = New System.Windows.Forms.TextBox()
        Me.btnCalculateAverage = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkCelsius = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAverageTemperature = New System.Windows.Forms.Label()
        Me.lblCelsius = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radBrian
        '
        Me.radBrian.AutoSize = True
        Me.radBrian.Location = New System.Drawing.Point(6, 19)
        Me.radBrian.Name = "radBrian"
        Me.radBrian.Size = New System.Drawing.Size(49, 17)
        Me.radBrian.TabIndex = 0
        Me.radBrian.TabStop = True
        Me.radBrian.Text = "Brian"
        Me.radBrian.UseVisualStyleBackColor = True
        '
        'radMichael
        '
        Me.radMichael.AutoSize = True
        Me.radMichael.Location = New System.Drawing.Point(6, 42)
        Me.radMichael.Name = "radMichael"
        Me.radMichael.Size = New System.Drawing.Size(62, 17)
        Me.radMichael.TabIndex = 1
        Me.radMichael.TabStop = True
        Me.radMichael.Text = "Michael"
        Me.radMichael.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBrian)
        Me.GroupBox1.Controls.Add(Me.radMichael)
        Me.GroupBox1.Location = New System.Drawing.Point(285, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technicians"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter a Temperature Value"
        '
        'txtTemperatureValue
        '
        Me.txtTemperatureValue.Location = New System.Drawing.Point(172, 53)
        Me.txtTemperatureValue.Name = "txtTemperatureValue"
        Me.txtTemperatureValue.Size = New System.Drawing.Size(80, 20)
        Me.txtTemperatureValue.TabIndex = 0
        '
        'btnCalculateAverage
        '
        Me.btnCalculateAverage.Location = New System.Drawing.Point(44, 196)
        Me.btnCalculateAverage.Name = "btnCalculateAverage"
        Me.btnCalculateAverage.Size = New System.Drawing.Size(131, 65)
        Me.btnCalculateAverage.TabIndex = 2
        Me.btnCalculateAverage.Text = "Convert Temperature/Calculate Average"
        Me.btnCalculateAverage.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(207, 182)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 37)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear Content"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(207, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 36)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MuradRProgram2.My.Resources.Resources.TempGage
        Me.PictureBox1.Location = New System.Drawing.Point(326, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'chkCelsius
        '
        Me.chkCelsius.AutoSize = True
        Me.chkCelsius.Location = New System.Drawing.Point(22, 123)
        Me.chkCelsius.Name = "chkCelsius"
        Me.chkCelsius.Size = New System.Drawing.Size(133, 17)
        Me.chkCelsius.TabIndex = 5
        Me.chkCelsius.Text = "Temperature in Celsius"
        Me.chkCelsius.UseVisualStyleBackColor = True
        Me.chkCelsius.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Average Temperature"
        '
        'lblAverageTemperature
        '
        Me.lblAverageTemperature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageTemperature.Location = New System.Drawing.Point(172, 86)
        Me.lblAverageTemperature.Name = "lblAverageTemperature"
        Me.lblAverageTemperature.Size = New System.Drawing.Size(80, 20)
        Me.lblAverageTemperature.TabIndex = 6
        '
        'lblCelsius
        '
        Me.lblCelsius.Location = New System.Drawing.Point(172, 117)
        Me.lblCelsius.Name = "lblCelsius"
        Me.lblCelsius.Size = New System.Drawing.Size(80, 20)
        Me.lblCelsius.TabIndex = 7
        Me.lblCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculateAverage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(430, 340)
        Me.Controls.Add(Me.lblCelsius)
        Me.Controls.Add(Me.chkCelsius)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateAverage)
        Me.Controls.Add(Me.lblAverageTemperature)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTemperatureValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Temperature Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radBrian As System.Windows.Forms.RadioButton
    Friend WithEvents radMichael As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTemperatureValue As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateAverage As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkCelsius As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAverageTemperature As System.Windows.Forms.Label
    Friend WithEvents lblCelsius As System.Windows.Forms.Label

End Class
