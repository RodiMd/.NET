﻿Public Class Form1

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblDateString.Click

    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        'Concatenate the input and build the date string
        lblDateString.Text = txtDayOfWeek.Text & ", " &
        txtMonth.Text & " " &
        txtDayOfMonth.Text & ", " &
        txtYear.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the Text Boxes and lblDateString.
        txtDayOfWeek.Clear()
        txtMonth.Clear()
        txtDayOfMonth.Clear()
        txtYear.Clear()
        lblDateString.Text = String.Empty

        ' Give the focus to txtDayOfWeek.
        txtDayOfWeek.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
