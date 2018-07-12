Module ConcreteEquations

    'FY-YIELD strength, Ey-modulus of elasticity, fc-concrete compression strength, cb-balanced distance to neutral axis, b-width of beam
    'Cc-compression force at the block face, esy-elastic yield strain of rebar, a - height of compression face, Mn-nominal moment capacity

    Public beta As Double, Fy As Double, Ey As Double, fc As Double, Cc As Double 'concrete and steel parameters
    Public d As Double, cb As Double, b As Double, a As Double, c As Double 'section parameters
    Public Ast As Double, Asmin1 As Double, Asmin2 As Double, Asmin As Double 'reinforcement parameters
    Public Ac As Double, dt As Double 'concrete block parameters
    Public esy As Double, Mn As Double, es As Double 'yield strain and nominal moment capacity
    Public fi As Double 'declare the strength reduction factor LRFD
    Const ecu As Double = 0.003

    'declare an array for the Area of steel bars
    Public Asteel() As Double = {0.11, 0.2, 0.31, 0.44, 0.6, 0.79, 1.0, 1.27, 1.56}

    'declare the bar type array
    Public BarType() As Integer = {3, 4, 5, 6, 7, 8, 9, 10, 11}

    'declare the quantity of bars used in beam
    Public QuantityOfBars() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

    'function that returns the value of the concrete block area
    Public Function Aconcrete(ByVal txtd As Double, ByVal txtb As Double) As Double
        Return txtb * txtd
    End Function

    Sub Aconcrete1()

        Ac = b * dt

    End Sub


    Sub Ccomp()

        'yield strain of steel
        esy = Fy / Ey
        cb = ecu / (ecu + esy) * d

        'conditions to choose beta value
        If fc <= 4 Then beta = 0.85
        If fc >= 4 And fc <= 8 Then beta = 0.85 - 0.05 * (fc - 4)
        If fc > 8 Then beta = 0.65

        'compression force of concrete in kips
        Cc = 0.85 * fc * b * beta * cb

    End Sub

    'Nominal momnet strength of the reinforced section
    'd is the depth from the outer fiber at the compression face down to the centroid of the outer layer of tension reinforcement
    Sub NomMoment()

        a = beta * cb
        Mn = fi * Ast * Fy * (d - a / 2)

    End Sub

    Sub Mnominal()
        a = beta * c
        Mn = fi * Ast * Fy * (d - a / 2) / 12
    End Sub

    'this sub is used to find the minimum area of steel required
    Sub MinAsteel()

        'dividing by one thousand because we are using ksi value for fy
        Asmin1 = 3 * (fc) ^ 0.5 * b * d / (Fy * 1000)
        Asmin2 = 200 * b * d / (Fy * 1000)

        If Asmin1 > Asmin2 Then
            Asmin = Asmin1
        Else
            Asmin = Asmin2
        End If

    End Sub


    'another relationship to find the compression depth of the concrete block
    'fc is the compression force that is called fcomp in the form
    'Ast is the area of steel from the quantity of rebar used for reinforcement
    Sub StrsBlckDpth1()

        a = Ast * Fy / (0.85 * fc * b)

    End Sub

    'compute the elastic strain
    Sub strain()

        es = ((d - c) / c) * ecu

    End Sub

    Sub fiStirrups()

        If es > 0.005 Then
            fi = 0.9
        ElseIf es < 0.005 And es > esy Then
            fi = 0.65 + (es - 0.002) * (250 / 3)
        Else
            fi = 0.65
        End If

    End Sub

    Sub fiSpiral()

        If es > 0.005 Then
            fi = 0.9
        ElseIf es < 0.005 And es > esy Then
            fi = 0.75 + (es - 0.002) * 50
        Else
            fi = 0.75
        End If

    End Sub


    'eyld - yield strain, fy yield strength, elst modulus of elasticity
    '    Sub eyield()

    ' eyld = fy / elst

    '    End Sub

    '    Sub ConfirmTensionArea()

    '       Amin = 200 / fy * CDbl(txtb) * CDbl(txtd)
    '        Amin2 = 3 * (fcomp) / fy * CDbl(txtb) * CDbl(txtd)

    'End Sub

    'another way of finding the compression force using the value a where a = beta * c
    '    Sub ConcreteCompression1()

    'Ccomp = 0.85 * fcomp * CDbl(txtb) * a

    'End Sub

    'the compression depth of the concrete block
    ' Sub StrsBlckDpth()

    'a = beta * c

    'End Sub

End Module
