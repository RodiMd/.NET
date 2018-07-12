Module Formulas

    Public n As Double, i As Double, p As Double, c As Double

    Sub SinglePaymentCompF()
        c = p * (1 + i) ^ n ' future given present
    End Sub

    Sub SinglePaymentCompP()
        c = p / (1 + i) ^ n ' present given future
    End Sub

    Sub USCompIntF()
        c = p * ((1 + i) ^ n - 1) / i ' future given uniform series, c = F and P = A
    End Sub

    Sub USCompIntA()
        c = p * i / ((1 + i) ^ n - 1) ' uniform series given future, c = A and p = F
    End Sub

    Sub USCompIntAP()
        c = p * ((1 + i) ^ n * i) / ((1 + i) ^ n - 1) 'uniform series using present to find annuity
    End Sub

End Module
