<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDecaf
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
        Me.btnDecafAdd = New System.Windows.Forms.Button()
        Me.btnDecafClear = New System.Windows.Forms.Button()
        Me.btnDecafExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDecafBrand = New System.Windows.Forms.ComboBox()
        Me.lstDecafSize = New System.Windows.Forms.ListBox()
        Me.txtDecafQuantity = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDecafAdd
        '
        Me.btnDecafAdd.Location = New System.Drawing.Point(42, 193)
        Me.btnDecafAdd.Name = "btnDecafAdd"
        Me.btnDecafAdd.Size = New System.Drawing.Size(90, 30)
        Me.btnDecafAdd.TabIndex = 0
        Me.btnDecafAdd.Text = "Add To Order"
        Me.btnDecafAdd.UseVisualStyleBackColor = True
        '
        'btnDecafClear
        '
        Me.btnDecafClear.Location = New System.Drawing.Point(138, 193)
        Me.btnDecafClear.Name = "btnDecafClear"
        Me.btnDecafClear.Size = New System.Drawing.Size(90, 30)
        Me.btnDecafClear.TabIndex = 1
        Me.btnDecafClear.Text = "Clear"
        Me.btnDecafClear.UseVisualStyleBackColor = True
        '
        'btnDecafExit
        '
        Me.btnDecafExit.Location = New System.Drawing.Point(234, 193)
        Me.btnDecafExit.Name = "btnDecafExit"
        Me.btnDecafExit.Size = New System.Drawing.Size(90, 30)
        Me.btnDecafExit.TabIndex = 2
        Me.btnDecafExit.Text = "Close"
        Me.btnDecafExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Brand:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Size:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Select Quantity:"
        '
        'cboDecafBrand
        '
        Me.cboDecafBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDecafBrand.FormattingEnabled = True
        Me.cboDecafBrand.Location = New System.Drawing.Point(171, 22)
        Me.cboDecafBrand.Name = "cboDecafBrand"
        Me.cboDecafBrand.Size = New System.Drawing.Size(121, 21)
        Me.cboDecafBrand.TabIndex = 6
        '
        'lstDecafSize
        '
        Me.lstDecafSize.FormattingEnabled = True
        Me.lstDecafSize.Items.AddRange(New Object() {"One Pound", "Two Pounds", "Ten Pounds"})
        Me.lstDecafSize.Location = New System.Drawing.Point(172, 67)
        Me.lstDecafSize.Name = "lstDecafSize"
        Me.lstDecafSize.Size = New System.Drawing.Size(120, 43)
        Me.lstDecafSize.TabIndex = 7
        '
        'txtDecafQuantity
        '
        Me.txtDecafQuantity.Location = New System.Drawing.Point(173, 137)
        Me.txtDecafQuantity.Name = "txtDecafQuantity"
        Me.txtDecafQuantity.Size = New System.Drawing.Size(65, 20)
        Me.txtDecafQuantity.TabIndex = 8
        '
        'frmDecaf
        '
        Me.AcceptButton = Me.btnDecafAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.CancelButton = Me.btnDecafExit
        Me.ClientSize = New System.Drawing.Size(363, 243)
        Me.Controls.Add(Me.txtDecafQuantity)
        Me.Controls.Add(Me.lstDecafSize)
        Me.Controls.Add(Me.cboDecafBrand)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDecafExit)
        Me.Controls.Add(Me.btnDecafClear)
        Me.Controls.Add(Me.btnDecafAdd)
        Me.Name = "frmDecaf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Decaf Coffee Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDecafAdd As System.Windows.Forms.Button
    Friend WithEvents btnDecafClear As System.Windows.Forms.Button
    Friend WithEvents btnDecafExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDecafBrand As System.Windows.Forms.ComboBox
    Friend WithEvents lstDecafSize As System.Windows.Forms.ListBox
    Friend WithEvents txtDecafQuantity As System.Windows.Forms.TextBox
End Class
