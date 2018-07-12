Public Class frmRegularCoffee

    'declare a counter integer that is used for the loop
    Dim intCount As Integer = 1

    Private Sub frmRegularCoffee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'using the with ... end with statement to add the brands into the combobox list
        For Me.intCount = 1 To 5

            'as the counter increases from 1 to 5 another item is added to the combolist box
            Me.cboBrand.Items.Add("Regular" + intCount.ToString)
        Next

        'makes first item in the select brand visible/selected
        Me.cboBrand.SelectedIndex = 0

        'makes the first item in teh size selected
        Me.lstSize.SelectedIndex = 0

        'clears the txtbox if there are any values if were not cleared.
        Me.txtQuantity.Clear()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'close program
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try

            'declares the price per pound as constant integers
            Const intOne_Pound As Integer = 8, intTwo_Pounds As Integer = 15, intTen_Pounds As Integer = 70

            'assigns the one, two and ten pounds strings to indeces
            strOne_Pound = lstSize.Items(0).ToString()
            strTwo_Pounds = lstSize.Items(1).ToString()
            strTen_Pounds = lstSize.Items(2).ToString()


            'using select case to check what size is selected to account cost
            Select Case lstSize.SelectedItem.ToString

                'case for one pound size price multiplied by quantity to find total for the selection
                Case Is = strOne_Pound
                    dblCost += intOne_Pound * CInt(txtQuantity.Text)

                    'case for two pound size price multiplied by quantity to find total for the selection
                Case Is = strTwo_Pounds
                    dblCost += intTwo_Pounds * CInt(txtQuantity.Text)

                    'ten pound case
                Case Is = strTen_Pounds
                    dblCost += intTen_Pounds * CInt(txtQuantity.Text)

            End Select

            MessageBox.Show(CStr("Current Subtotal is " & dblCost.ToString("c")))
            'catch exceptions if no entry has been made
        Catch
            'display the message if no selection was made
            MessageBox.Show("Please choose the product, weight and insert the desired quantity and ensure that the quantity is numeric")
        End Try

        btnClear.Focus()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear the text quantity
        txtQuantity.Clear()

        'clear the combobox list by returning it to the default value on the list regular1
        Me.cboBrand.SelectedIndex = 0

        'clear the listbox
        Me.lstSize.SelectedIndex = 0

        btnAdd.Focus()

    End Sub

End Class