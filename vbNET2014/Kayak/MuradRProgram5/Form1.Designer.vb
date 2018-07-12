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
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.lstKayakTypes = New System.Windows.Forms.ListBox()
        Me.KayaksDataSet = New MuradRProgram5.KayaksDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KayakTypesTableAdapter = New MuradRProgram5.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.TableAdapterManager = New MuradRProgram5.KayaksDataSetTableAdapters.TableAdapterManager()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionLabel1 = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstKayakTypes
        '
        Me.lstKayakTypes.DataSource = Me.KayakTypesBindingSource
        Me.lstKayakTypes.DisplayMember = "Name"
        Me.lstKayakTypes.FormattingEnabled = True
        Me.lstKayakTypes.Location = New System.Drawing.Point(42, 55)
        Me.lstKayakTypes.Name = "lstKayakTypes"
        Me.lstKayakTypes.Size = New System.Drawing.Size(157, 108)
        Me.lstKayakTypes.TabIndex = 0
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select a kayak type to view a description"
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KayakTypesTableAdapter = Me.KayakTypesTableAdapter
        Me.TableAdapterManager.UpdateOrder = MuradRProgram5.KayaksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(205, 55)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(0, 13)
        DescriptionLabel.TabIndex = 2
        '
        'DescriptionLabel1
        '
        Me.DescriptionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescriptionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KayakTypesBindingSource, "Description", True))
        Me.DescriptionLabel1.Location = New System.Drawing.Point(234, 55)
        Me.DescriptionLabel1.Name = "DescriptionLabel1"
        Me.DescriptionLabel1.Size = New System.Drawing.Size(311, 107)
        Me.DescriptionLabel1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 231)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstKayakTypes)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kayak Browser"
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstKayakTypes As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KayaksDataSet As MuradRProgram5.KayaksDataSet
    Friend WithEvents KayakTypesTableAdapter As MuradRProgram5.KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents TableAdapterManager As MuradRProgram5.KayaksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KayakTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescriptionLabel1 As System.Windows.Forms.Label

End Class
