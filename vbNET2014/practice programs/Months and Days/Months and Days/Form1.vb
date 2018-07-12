Public Class Form1

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim strMonths() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        'Array with the days of each month
        Dim intDays() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

        'Display a list of the months and days
        Dim i As Integer

        For i = 0 To strMonths.Length - 1
            lstOutput.Items.Add(strMonths(i) & " has " &
                                intDays(i).ToString() & " days. ")
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
