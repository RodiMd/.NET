﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnSngTRBeam = New System.Windows.Forms.Button()
        Me.btnBalSngRBeam = New System.Windows.Forms.Button()
        Me.btnTensionControlled = New System.Windows.Forms.Button()
        Me.btnTnC = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.White
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInfo.Location = New System.Drawing.Point(65, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(310, 75)
        Me.lblInfo.TabIndex = 5
        '
        'btnSngTRBeam
        '
        Me.btnSngTRBeam.Location = New System.Drawing.Point(65, 212)
        Me.btnSngTRBeam.Name = "btnSngTRBeam"
        Me.btnSngTRBeam.Size = New System.Drawing.Size(119, 37)
        Me.btnSngTRBeam.TabIndex = 0
        Me.btnSngTRBeam.Text = "Assumed Yield Singly Tension Reinforced Beam"
        Me.btnSngTRBeam.UseVisualStyleBackColor = True
        '
        'btnBalSngRBeam
        '
        Me.btnBalSngRBeam.Location = New System.Drawing.Point(65, 373)
        Me.btnBalSngRBeam.Name = "btnBalSngRBeam"
        Me.btnBalSngRBeam.Size = New System.Drawing.Size(119, 40)
        Me.btnBalSngRBeam.TabIndex = 2
        Me.btnBalSngRBeam.Text = "Balanced Singly Reinforced Beam"
        Me.btnBalSngRBeam.UseVisualStyleBackColor = True
        '
        'btnTensionControlled
        '
        Me.btnTensionControlled.Location = New System.Drawing.Point(256, 212)
        Me.btnTensionControlled.Name = "btnTensionControlled"
        Me.btnTensionControlled.Size = New System.Drawing.Size(119, 37)
        Me.btnTensionControlled.TabIndex = 1
        Me.btnTensionControlled.Text = "Tension Controlled Beam Section"
        Me.btnTensionControlled.UseVisualStyleBackColor = True
        '
        'btnTnC
        '
        Me.btnTnC.Location = New System.Drawing.Point(256, 373)
        Me.btnTnC.Name = "btnTnC"
        Me.btnTnC.Size = New System.Drawing.Size(119, 40)
        Me.btnTnC.TabIndex = 3
        Me.btnTnC.Text = "Tension & Compression Reinforced Beam"
        Me.btnTnC.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(256, 257)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(119, 110)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(256, 96)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(119, 110)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Beam_Design.My.Resources.Resources.BalBeam
        Me.PictureBox2.Location = New System.Drawing.Point(65, 257)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 110)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Beam_Design.My.Resources.Resources.Beam
        Me.PictureBox1.Location = New System.Drawing.Point(65, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(163, 419)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(112, 43)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Main_Form
        '
        Me.AcceptButton = Me.btnQuit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(445, 474)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btnTnC)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnTensionControlled)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBalSngRBeam)
        Me.Controls.Add(Me.btnSngTRBeam)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_Form"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnSngTRBeam As System.Windows.Forms.Button
    Friend WithEvents btnBalSngRBeam As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnTensionControlled As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnTnC As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
End Class
