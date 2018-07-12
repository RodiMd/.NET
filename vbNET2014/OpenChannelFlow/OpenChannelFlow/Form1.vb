Public Class Form1

    Dim gbxOutput As New GroupBox
    Dim gbxInput As New GroupBox

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'converting all of the input txtboxes to a double value so they can be used in calculations
        dblFlowDepth = CDbl(txtFlowDepth.Text)
        dblMannings = CDbl(txtMannings.Text)
        dblSideSlope1 = CDbl(txtSideSlope1.Text)
        dblSideSlope2 = CDbl(txtSideSlope2.Text)
        dblChannelWidth = CDbl(txtChannelWidth.Text)
        dblChannelDepth = CDbl(txtChannelDepth.Text)
        dblChannelSlope = CDbl(txtChannelSlope.Text)

        'if statement to check if the flow depth entered is larger than the channel depth a warning message is displayed
        If dblFlowDepth > dblChannelDepth Then
            MessageBox.Show("Error: the value of the flow depth is greater than the depth of the channel," & ControlChars.CrLf &
                             "Please enter a value for the flow depth less than the channel's depth")
            Exit Sub
        End If

        ' calling all the functions from the module and then placing in appropriate lable control
        'converting the value displayed to a strin with 2 decimal point
        flowArea()
        lblFlowArea.Text = CStr(dblFlowArea.ToString("n2"))

        WettedPerimeter()
        lblWettedPerimeter.Text = CStr(dblWPerimeter.ToString("n2"))

        HydRad()
        lblHyadRad.Text = CStr(dblHydRad.ToString("n2"))

        Flow()
        lblFlow.Text = CStr(dblFlow.ToString("n2"))

        Velocity()
        lblFlowVelocity.Text = CStr(dblFVelocity.ToString("n2"))

        Froude()
        lblFroude.Text = CStr(dblFroude.ToString("n2"))

        FreeBoard()
        lblFreeboard.Text = CStr(dblFreeboard.ToString("n2"))

        'condition checking if not enough freeboard is available
        If dblFreeboard > (dblChannelDepth - dblFlowDepth) Then
            MessageBox.Show("The channel depth is smaller than the required freeboard = flow depth")
            Exit Sub
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnClearField_Click(sender As Object, e As EventArgs) Handles btnClearField.Click

        ClearData()
        
    End Sub
    Public Sub ClearData()

        For Each ctrl As Control In gbxOutput.Controls

            If TypeOf ctrl Is Label Then

                ctrl.Text = String.Empty

            End If
        Next
        For Each ctrl As Control In gbxInput.Controls

            If TypeOf ctrl Is TextBox Then

                ctrl.Text = ""

            End If
        Next
    End Sub

End Class
