Module ConcreteColumnDesignFormulas

    Public c As Double, es2 As Double, es1 As Double, Fs1 As Double, fs_1 As Double, Fs2 As Double, As2 As Double, As1 As Double
    Public fs_2 As Double, Es As Double, d1 As Double, d2 As Double, beta As Double, a As Double, h As Double, b As Double
    Public MnB As Double, PnB As Double
    Public Cc As Double
    Public ecu As Double = 0.003, ey As Double 'maximum compressive strain in concrete, tensile strain
    Dim fiTied As Double, fiSpiral As Double 'strength reduction factor
    Public fiPnmx As Double, fi As Double, fc As Double, Ag As Double, Astl As Double, fy As Double ' declare concrete and reinforcement parameters
    Public Pnmx As Double


    Sub ReductionCoeffTied()
        If Math.Abs(es1) <= 0.00207 Then

            fiTied = 0.65

        ElseIf Math.Abs(es1) > 0.00207 And Math.Abs(es1) < 0.005 Then

            fiTied = 0.65 + (-es1 - 0.002) * (250 / 3)

        ElseIf Math.Abs(es1) >= 0.005 Then
            fiTied = 0.9

        End If
        fi = fiTied

    End Sub
    Sub ReductionCoeffSpiral()

        If ey <= 0.00207 Then

            fiSpiral = 0.75

        ElseIf ey > 0.00207 And ey < 0.005 Then

            fiSpiral = 0.75 + (es1 - 0.002) * 50

        ElseIf ey >= 0.005 Then

            fiSpiral = 0.9

        End If

        fi = fiSpiral

    End Sub

    Sub MaxLoadSpiral()

        fiPnmx = fi * (0.85 * fc * (Ag - Astl) + fy * Astl)
        Pnmx = 0.85 * fiPnmx

    End Sub

    Sub MaxLoadTied()

        fiPnmx = fi * (0.85 * fc * (Ag - Astl) + fy * Astl)
        Pnmx = 0.8 * fiPnmx

    End Sub

    Sub Balanced()

        c = 0.003 / (0.003 - (es1)) * d1
        es2 = ((c - d2) / c) * 0.003 ' strain in the reinforcement layer
        fs_2 = es2 * Es 'stress in the reinforcement layer2

        beta = 0.85 - 0.05 * ((fc - 4) / 1)
        a = beta * c
        If a > h Then a = h

        'force in concrete
        Cc = 0.85 * fc * a * b

        'force in steel
        If Math.Abs(es1) > Math.Abs(ey) Then
            fs_1 = -ey * Es
        Else
            fs_1 = es1 * Es
        End If

        Fs1 = fs_1 * As1
        Fs2 = (fs_2 - 0.85 * fc) * As2

        'nominal axial capacity
        PnB = fi * (Fs2 + Fs1 + Cc)
        MnB = fi * (Cc * (h / 2 - a / 2) + Fs1 * (h / 2 - d1) + Fs2 * (h / 2 - d2)) / 12

    End Sub

End Module
