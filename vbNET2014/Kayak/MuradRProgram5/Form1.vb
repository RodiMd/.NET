'Rodi Murad
'CIT 161
'program5 - kayak browser, which displays the description of various kayak types

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KayaksDataSet.KayakTypes' table. You can move, or remove it, as needed.
        Me.KayakTypesTableAdapter.Fill(Me.KayaksDataSet.KayakTypes)

    End Sub
End Class
