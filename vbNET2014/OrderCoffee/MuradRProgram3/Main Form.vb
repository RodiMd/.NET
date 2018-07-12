Public Class MainForm

    'declare the three other forms the load beside the main form
    Dim frmRegularCoffee As New frmRegularCoffee
    Dim frmDecaf As New frmDecaf
    Dim frmDisplayBill As New frmDisplayBill


    Private Sub btnRegular_Click(sender As Object, e As EventArgs) Handles btnRegular.Click

        'activate/show the RegularCoffee form
        frmRegularCoffee.ShowDialog()

    End Sub


    Private Sub btnDecaf_Click(sender As Object, e As EventArgs) Handles btnDecaf.Click

        'activate/show decaf form
        frmDecaf.ShowDialog()

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'closes mainform window
        Me.Close()

    End Sub

    Private Sub btnDisplayBill_Click(sender As Object, e As EventArgs) Handles btnDisplayBill.Click

        'activate/show the displaybill form
        frmDisplayBill.ShowDialog()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

