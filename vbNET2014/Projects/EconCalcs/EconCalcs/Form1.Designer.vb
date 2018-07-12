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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.lblFuture = New System.Windows.Forms.Label()
        Me.txtn = New System.Windows.Forms.TextBox()
        Me.txti = New System.Windows.Forms.TextBox()
        Me.txtP = New System.Windows.Forms.TextBox()
        Me.lblF = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.radSngPaymentF = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.radSngPaymentP = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.radIntCompQuart = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radUSCompIntF = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radUSCompIntA = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.radUSCompIntAP = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Term (yrs):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Annual Rate (%):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincipal.Location = New System.Drawing.Point(397, 78)
        Me.lblPrincipal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(84, 16)
        Me.lblPrincipal.TabIndex = 2
        Me.lblPrincipal.Text = "Prinicipal ($):"
        Me.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFuture
        '
        Me.lblFuture.AutoSize = True
        Me.lblFuture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuture.Location = New System.Drawing.Point(382, 168)
        Me.lblFuture.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFuture.Name = "lblFuture"
        Me.lblFuture.Size = New System.Drawing.Size(96, 16)
        Me.lblFuture.TabIndex = 3
        Me.lblFuture.Text = "Futur Value ($):"
        Me.lblFuture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtn
        '
        Me.txtn.Location = New System.Drawing.Point(529, 14)
        Me.txtn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(52, 22)
        Me.txtn.TabIndex = 4
        '
        'txti
        '
        Me.txti.Location = New System.Drawing.Point(529, 45)
        Me.txti.Margin = New System.Windows.Forms.Padding(4)
        Me.txti.Name = "txti"
        Me.txti.Size = New System.Drawing.Size(52, 22)
        Me.txti.TabIndex = 5
        '
        'txtP
        '
        Me.txtP.Location = New System.Drawing.Point(529, 75)
        Me.txtP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(52, 22)
        Me.txtP.TabIndex = 6
        '
        'lblF
        '
        Me.lblF.BackColor = System.Drawing.Color.White
        Me.lblF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblF.Location = New System.Drawing.Point(529, 167)
        Me.lblF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(95, 22)
        Me.lblF.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(444, 102)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(180, 50)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'radSngPaymentF
        '
        Me.radSngPaymentF.AutoSize = True
        Me.radSngPaymentF.Location = New System.Drawing.Point(12, 12)
        Me.radSngPaymentF.Name = "radSngPaymentF"
        Me.radSngPaymentF.Size = New System.Drawing.Size(198, 20)
        Me.radSngPaymentF.TabIndex = 23
        Me.radSngPaymentF.TabStop = True
        Me.radSngPaymentF.Text = "Single Payment Future Worth"
        Me.radSngPaymentF.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(238, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "(F/P, i, n)"
        '
        'radSngPaymentP
        '
        Me.radSngPaymentP.AutoSize = True
        Me.radSngPaymentP.Location = New System.Drawing.Point(12, 33)
        Me.radSngPaymentP.Name = "radSngPaymentP"
        Me.radSngPaymentP.Size = New System.Drawing.Size(207, 20)
        Me.radSngPaymentP.TabIndex = 25
        Me.radSngPaymentP.TabStop = True
        Me.radSngPaymentP.Text = "Single Payment Present Worth"
        Me.radSngPaymentP.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(238, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 16)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "(P/F, i, n)"
        '
        'radIntCompQuart
        '
        Me.radIntCompQuart.AutoSize = True
        Me.radIntCompQuart.Location = New System.Drawing.Point(12, 55)
        Me.radIntCompQuart.Name = "radIntCompQuart"
        Me.radIntCompQuart.Size = New System.Drawing.Size(203, 20)
        Me.radIntCompQuart.TabIndex = 28
        Me.radIntCompQuart.TabStop = True
        Me.radIntCompQuart.Text = "Interest Compunded Quarterly"
        Me.radIntCompQuart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "(F/P, i, n)"
        '
        'radUSCompIntF
        '
        Me.radUSCompIntF.AutoSize = True
        Me.radUSCompIntF.Location = New System.Drawing.Point(12, 77)
        Me.radUSCompIntF.Name = "radUSCompIntF"
        Me.radUSCompIntF.Size = New System.Drawing.Size(229, 20)
        Me.radUSCompIntF.TabIndex = 30
        Me.radUSCompIntF.TabStop = True
        Me.radUSCompIntF.Text = "Uniform Series Compound Interest"
        Me.radUSCompIntF.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "(F/A, i , n)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "(A/F, i , n)"
        '
        'radUSCompIntA
        '
        Me.radUSCompIntA.AutoSize = True
        Me.radUSCompIntA.Location = New System.Drawing.Point(12, 98)
        Me.radUSCompIntA.Name = "radUSCompIntA"
        Me.radUSCompIntA.Size = New System.Drawing.Size(229, 20)
        Me.radUSCompIntA.TabIndex = 32
        Me.radUSCompIntA.TabStop = True
        Me.radUSCompIntA.Text = "Uniform Series Compound Interest"
        Me.radUSCompIntA.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "(A/P, i , n)"
        '
        'radUSCompIntAP
        '
        Me.radUSCompIntAP.AutoSize = True
        Me.radUSCompIntAP.Location = New System.Drawing.Point(12, 119)
        Me.radUSCompIntAP.Name = "radUSCompIntAP"
        Me.radUSCompIntAP.Size = New System.Drawing.Size(229, 20)
        Me.radUSCompIntAP.TabIndex = 34
        Me.radUSCompIntAP.TabStop = True
        Me.radUSCompIntAP.Text = "Uniform Series Compound Interest"
        Me.radUSCompIntAP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 470)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.radUSCompIntAP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.radUSCompIntA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.radUSCompIntF)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.radIntCompQuart)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.radSngPaymentP)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.radSngPaymentF)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.txti)
        Me.Controls.Add(Me.txtn)
        Me.Controls.Add(Me.lblFuture)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPrincipal As System.Windows.Forms.Label
    Friend WithEvents lblFuture As System.Windows.Forms.Label
    Friend WithEvents txtn As System.Windows.Forms.TextBox
    Friend WithEvents txti As System.Windows.Forms.TextBox
    Friend WithEvents txtP As System.Windows.Forms.TextBox
    Friend WithEvents lblF As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents radSngPaymentF As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents radSngPaymentP As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents radIntCompQuart As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radUSCompIntF As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents radUSCompIntA As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents radUSCompIntAP As System.Windows.Forms.RadioButton

End Class
