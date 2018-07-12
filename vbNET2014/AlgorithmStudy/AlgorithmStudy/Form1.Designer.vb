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
        Me.btnCommonNumber = New System.Windows.Forms.Button()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.LstItems2 = New System.Windows.Forms.ListBox()
        Me.lstitem3 = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstSorted2 = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lstSorted = New System.Windows.Forms.ListBox()
        Me.lstUnsorted = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lstUnsortedList = New System.Windows.Forms.ListBox()
        Me.lstSortedlist = New System.Windows.Forms.ListBox()
        Me.btn_Sort = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCommonNumber
        '
        Me.btnCommonNumber.Location = New System.Drawing.Point(111, 290)
        Me.btnCommonNumber.Name = "btnCommonNumber"
        Me.btnCommonNumber.Size = New System.Drawing.Size(327, 78)
        Me.btnCommonNumber.TabIndex = 0
        Me.btnCommonNumber.Text = "Get Commom Number from List"
        Me.btnCommonNumber.UseVisualStyleBackColor = True
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(8, 6)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(520, 56)
        Me.lstItems.TabIndex = 1
        '
        'LstItems2
        '
        Me.LstItems2.FormattingEnabled = True
        Me.LstItems2.Location = New System.Drawing.Point(8, 68)
        Me.LstItems2.Name = "LstItems2"
        Me.LstItems2.Size = New System.Drawing.Size(520, 82)
        Me.LstItems2.TabIndex = 2
        '
        'lstitem3
        '
        Me.lstitem3.FormattingEnabled = True
        Me.lstitem3.Location = New System.Drawing.Point(8, 156)
        Me.lstitem3.Name = "lstitem3"
        Me.lstitem3.Size = New System.Drawing.Size(520, 108)
        Me.lstitem3.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(545, 521)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstItems)
        Me.TabPage1.Controls.Add(Me.lstitem3)
        Me.TabPage1.Controls.Add(Me.btnCommonNumber)
        Me.TabPage1.Controls.Add(Me.LstItems2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(537, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.lstSorted2)
        Me.TabPage2.Controls.Add(Me.btnSort)
        Me.TabPage2.Controls.Add(Me.lstSorted)
        Me.TabPage2.Controls.Add(Me.lstUnsorted)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(537, 495)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bubble"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Selection"
        '
        'lstSorted2
        '
        Me.lstSorted2.FormattingEnabled = True
        Me.lstSorted2.Location = New System.Drawing.Point(72, 134)
        Me.lstSorted2.Name = "lstSorted2"
        Me.lstSorted2.Size = New System.Drawing.Size(61, 95)
        Me.lstSorted2.TabIndex = 3
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(8, 235)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(523, 134)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "Sort list"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lstSorted
        '
        Me.lstSorted.FormattingEnabled = True
        Me.lstSorted.Location = New System.Drawing.Point(8, 134)
        Me.lstSorted.Name = "lstSorted"
        Me.lstSorted.Size = New System.Drawing.Size(58, 95)
        Me.lstSorted.TabIndex = 1
        '
        'lstUnsorted
        '
        Me.lstUnsorted.FormattingEnabled = True
        Me.lstUnsorted.Location = New System.Drawing.Point(8, 0)
        Me.lstUnsorted.Name = "lstUnsorted"
        Me.lstUnsorted.Size = New System.Drawing.Size(523, 95)
        Me.lstUnsorted.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_Sort)
        Me.TabPage3.Controls.Add(Me.lstSortedlist)
        Me.TabPage3.Controls.Add(Me.lstUnsortedList)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(537, 495)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lstUnsortedList
        '
        Me.lstUnsortedList.FormattingEnabled = True
        Me.lstUnsortedList.Location = New System.Drawing.Point(8, 8)
        Me.lstUnsortedList.Name = "lstUnsortedList"
        Me.lstUnsortedList.Size = New System.Drawing.Size(201, 108)
        Me.lstUnsortedList.TabIndex = 0
        '
        'lstSortedlist
        '
        Me.lstSortedlist.FormattingEnabled = True
        Me.lstSortedlist.Location = New System.Drawing.Point(215, 8)
        Me.lstSortedlist.Name = "lstSortedlist"
        Me.lstSortedlist.Size = New System.Drawing.Size(198, 108)
        Me.lstSortedlist.TabIndex = 1
        '
        'btn_Sort
        '
        Me.btn_Sort.Location = New System.Drawing.Point(8, 122)
        Me.btn_Sort.Name = "btn_Sort"
        Me.btn_Sort.Size = New System.Drawing.Size(405, 95)
        Me.btn_Sort.TabIndex = 2
        Me.btn_Sort.Text = "Sort"
        Me.btn_Sort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 520)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = " "
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCommonNumber As System.Windows.Forms.Button
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents LstItems2 As System.Windows.Forms.ListBox
    Friend WithEvents lstitem3 As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents lstSorted As System.Windows.Forms.ListBox
    Friend WithEvents lstUnsorted As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstSorted2 As System.Windows.Forms.ListBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btn_Sort As System.Windows.Forms.Button
    Friend WithEvents lstSortedlist As System.Windows.Forms.ListBox
    Friend WithEvents lstUnsortedList As System.Windows.Forms.ListBox

End Class
