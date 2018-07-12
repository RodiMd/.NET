Public Class Form1

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        p = CDbl(txtP.Text)
        n = CDbl(txtn.Text)
        i = CDbl(txti.Text)
        i = i / 100

        'condition if single payment future is checked then access single formula in module
        If radSngPaymentF.Checked Then
            SinglePaymentCompF()
        End If

        'condition if single payment present is checked then access present module
        If radSngPaymentP.Checked Then
            SinglePaymentCompP()
        End If

        'condition for interest compunded quartarly
        If radIntCompQuart.Checked Then
            i = i / 4
            n = n * 4
            SinglePaymentCompF()
        End If

        'uniform series compund interest future
        If radUSCompIntF.Checked Then
            USCompIntF()
        End If

        'uniform series compound interest annuity given future value
        If radUSCompIntA.Checked Then
            USCompIntA()
        End If

        'uniform series compound interest annuity given present value
        If radUSCompIntAP.Checked Then
            USCompIntAP()
        End If

        lblF.Text = CStr(c.ToString("n0"))

    End Sub

    Private Sub radSngPaymentF_CheckedChanged(sender As Object, e As EventArgs) Handles radSngPaymentF.CheckedChanged
        lblPrincipal.Text = "Principal ($):"
        lblFuture.Text = "Future ($):"
    End Sub

    Private Sub radSngPaymentP_CheckedChanged(sender As Object, e As EventArgs) Handles radSngPaymentP.CheckedChanged
        lblPrincipal.Text = "Future ($):"
        lblFuture.Text = "Principal ($):"
    End Sub

    Private Sub radUSCompInt_CheckedChanged(sender As Object, e As EventArgs) Handles radUSCompIntF.CheckedChanged
        lblPrincipal.Text = "Uniform Payment ($):"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radUSCompIntA.CheckedChanged
        lblPrincipal.Text = "Future($):"
        lblFuture.Text = "Uniform Payment ($):"
    End Sub

    Private Sub radUSCompIntAP_CheckedChanged(sender As Object, e As EventArgs) Handles radUSCompIntAP.CheckedChanged

    End Sub
End Class
