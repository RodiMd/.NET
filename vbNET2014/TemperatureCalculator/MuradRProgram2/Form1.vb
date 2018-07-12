'Rodi Murad, CIT161
'Program2 (Average Temperature Calculator)
'This application will calculate the average temperature by summing the input by each technician as well as counting the # of inputs
'it limits the input between 32 and 80 and outputs the temperature in celsius
'it will warn the user from incorrect inputs, not checing a radio button or leaving the input box blank

Public Class Form1
    Dim dblTemperatureValue As Double = 0
    Dim intCountBrian As Integer = 0 'declare brain's input counter
    Dim intCountMichael As Integer = 0 'declare michael's input counter
    Dim intC1 As Integer 'declare the variables needed for calculating the average after counting #of inputs by Brian and Michael
    Dim intC2 As Integer 'declare the variables needed for calculating the average after counting #of inputs by Brian and Michael

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click

        Try 'catch exception errors such as no input in a txtbox for temperatureValue

            'check if temperature entered between 32 and 80, if not message is displayed and all fields are cleared for new input
            If (CDbl(txtTemperatureValue.Text)) < 32 Or (CDbl(txtTemperatureValue.Text)) > 80 Then
                MessageBox.Show("Please enter a value between 32 and 80")

                'clears the average temperature label after an incorrect input so it would not be used for average caluclations
                lblAverageTemperature.Text = String.Empty

                'clear the temperature input box value
                txtTemperatureValue.Clear()

                'sets focus back to the temperature input box value
                txtTemperatureValue.Focus()

                Exit Sub

            End If

            'utilizing an if statement to ensure that the radio button is checked
            If radBrian.Checked = True Then

                'this converts the input in the txtbox and sums the total inputs to find conversion
                dblTemperatureValue += CDbl(txtTemperatureValue.Text)

                'counting the number of inputs to find the total average sought
                intCountBrian = intCountBrian + 1

                'counter 2 that is used for brian while counting the inputs contributed by michael if any
                intC2 = intCountBrian + intCountMichael

                'display the average temperature from the inputs summed up above
                lblAverageTemperature.Text = CStr((dblTemperatureValue / intC2).ToString("n1"))

                'checking if michael checked in case of brian not being checked
            ElseIf radMichael.Checked = True Then

                dblTemperatureValue += CDbl(txtTemperatureValue.Text)

                intCountMichael = intCountMichael + 1

                intC1 = intCountMichael + intCountBrian

                lblAverageTemperature.Text = CStr((dblTemperatureValue / intC1).ToString("n1"))

                'if both conditions above not met then it directs the user to choose a technician
            Else : MessageBox.Show("Please choose a technician!")

            End If

            'checking if celsius value and kelvin are checked if so then show 
            'conversion of the fehrenheit temperature to celsius
            chkCelsius.Visible = True

            'checks if the check box for 
            If chkCelsius.Checked = True Then

                'calculates the temperature in celsius by converting the displayed average back to double then using 
                'the conversion formula
                lblCelsius.Text = CStr(((5 / 9) * ((CDbl(lblAverageTemperature.Text) - 32))).ToString("n1"))

            End If

            'catch statment used to avoid exception error of an empty input box
        Catch
            MessageBox.Show("Please try again and enter a numeric value!")

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'message box showing to counters during the calculation process
        'counting how many inputs were made by both technicians and showing the average temperature obtained.
        MessageBox.Show(" The Number of inputs by Brian is " & intCountBrian &
                        ", The Number of inputs by Michael is " & intCountMichael &
                        ", The average temperature is " & lblAverageTemperature.Text)

        'closes program
        Me.Close()

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear all fields, check boxes and radio buttons and sets focus on the input text box for the temperature
        txtTemperatureValue.Clear()
        lblCelsius.Text = String.Empty
        chkCelsius.Checked = False
        radBrian.Checked = False
        radMichael.Checked = False
        txtTemperatureValue.Focus()

    End Sub
End Class
