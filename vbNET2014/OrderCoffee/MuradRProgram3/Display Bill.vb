Public Class frmDisplayBill


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'closes the bill form
        Me.Close()

        'calls for the empty procedure in the calculator module to empty all values stored during the run
        empty()

    End Sub

    Private Sub frmDisplayBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'delcaring double total value and the date to be displayed
        Dim dblTotal As Double
        Dim dtmDate As Date

        'utilizing the today's date command for todays date ot be displayed
        dtmDate = Today.Date()

        'convert date to string to be displayed in lblDate
        lblDate.Text = CStr(dtmDate)

        'allighns the text in the lbl bounding box
        lblDate.TextAlign = ContentAlignment.MiddleCenter

        'converting the cost to a string and places it in the subtotal label window
        lblSubTotal.Text = CStr(dblCost.ToString("c"))

        'aligns the subtotal text to the middlecenter
        lblSubTotal.TextAlign = ContentAlignment.MiddleCenter

        'calls for the taxes procedure declared in the calculator module
        Taxes()

        'places the tax calculated into the lbltax in billform and converts it to a string
        lblTax.Text = CStr(dblTax.ToString("c"))

        'aligns the txt in the lbltxt to the middlecenter position
        lblTax.TextAlign = ContentAlignment.MiddleCenter

        'calculates the dblcost and dbltax
        dblTotal = dblCost + dblTax

        'converts total to a string and places it into a lable for the total on the billform
        lblTotal.Text = CStr(dblTotal.ToString("c"))

        'aligns text in the totalbox on billform to the middlecenter position
        lblTotal.TextAlign = ContentAlignment.MiddleCenter

        'puts focus on the close button
        btnClose.Focus()
    End Sub

End Class