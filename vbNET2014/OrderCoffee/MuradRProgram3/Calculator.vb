
Module Calculator

    'declare variables that will be used in forms globally
    Public dblCost As Double = 0, dblTax As Double = 0, dblTotal As Double = 0

    ' declare the onepound, twopound and tenpound strings
    Public strOne_Pound As String, strTwo_Pounds As String, strTen_Pounds As String

    'a taxes procedure to calculate the total taxes on the order
    Sub Taxes()

        Const dblTaxes As Double = 0.07

        dblTax = dblTaxes * dblCost

    End Sub

    ' an empty procedure used in the billform to reset all the values so count would start over as the bill from is closed
    Sub empty()

        dblTax = 0
        dblCost = 0
        dblTotal = 0

    End Sub

End Module



