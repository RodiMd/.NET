Public Class Form1

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim strInput As String ' Holds selected month and year

        If lstMonths.SelectedIndex = -1 Then
            ' No month is selected
            MessageBox.Show("Select a month.")
        ElseIf lstYears.SelectedIndex = -1 Then
            ' No year is selected
            MessageBox.Show("Select a year.")
        Else
            ' Get the selected month and year
            strInput = lstMonths.SelectedItem.ToString() &
            " " & lstYears.SelectedItem.ToString()
            MessageBox.Show("You selected " & strInput)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' Reset the list boxes.
        lstMonths.SelectedIndex = -1
        lstYears.SelectedIndex = -1

    End Sub
End Class
