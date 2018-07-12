Module ComputeOpenChannelFlow


    Public dblMannings As Double, dblSideSlope1 As Double, dblSideSlope2 As Double, dblChannelWidth As Double
    Public dblFlowDepth As Double, dblChannelDepth As Double, dblChannelSlope As Double

    'declare all the variables that will be used to fill in the output lables
    Public dblFlow As Double, dblFVelocity As Double, dblWPerimeter As Double, dblFroude As Double
    Public dblHydRad As Double, dblFreeboard As Double, dblFlowArea As Double
    Const g As Double = 32.2

    Sub flowArea()

        'get the flow area in sq.ft
        dblFlowArea = dblChannelWidth * dblFlowDepth + 1 / 2 * dblFlowDepth ^ 2 * (dblSideSlope1 + dblSideSlope2)
    End Sub

    Sub WettedPerimeter()

        'get the wetted perimeter and display in the lblwettedperimeter window
        dblWPerimeter = dblChannelWidth + dblFlowDepth * ((1 + dblSideSlope1 ^ 2) ^ 0.5 + (1 + dblSideSlope2 ^ 2) ^ 0.5)

    End Sub

    Sub HydRad()

        'get the hydraulic radius A/P
        dblHydRad = dblFlowArea / dblWPerimeter

    End Sub

    Sub Flow()

        'get the flow in the channel in cfs
        dblFlow = 1.486 / dblMannings * (dblFlowArea) * (dblHydRad) ^ (2 / 3) * dblChannelSlope ^ 0.5

    End Sub

    Sub Velocity()

        'get the flow velocity
        dblFVelocity = dblFlow / dblFlowArea

    End Sub

    Sub Froude()

        'get the Froude#
        dblFroude = dblFVelocity / (g * dblFlowDepth) ^ 0.5

    End Sub

    Sub FreeBoard()

        'get the channel freeboard
        dblFreeboard = 1 + 0.025 * dblFVelocity * dblFlowDepth ^ (1 / 3)

    End Sub

End Module
