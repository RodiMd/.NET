Public Class frmDecaf

    'declare counter used for the loop
    Dim intCount As Integer = 0


    Private Sub frmDecaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'do until loop utilized to add items to the cbolist box as the count increases it adds the number for the generic name
        Do Until Me.intCount = 5

            intCount = intCount + 1
            Me.cboDecafBrand.Items.Add("Decaf " + intCount.ToString())

        Loop
        'sets initial brand selection for item 1
        Me.cboDecafBrand.SelectedIndex = 0

        'sets initial size selection for item 1 in list box
        Me.lstDecafSize.SelectedIndex = 0

        'clears the quantity in the text box if any
        Me.txtDecafQuantity.Clear()

    End Sub

    Private Sub btnDecafAdd_Click(sender As Object, e As EventArgs) Handles btnDecafAdd.Click

        Try

            'decalre the sizes constant price to be used to calc total
            Const intOnePound As Integer = 10, intTwoPounds As Integer = 18, intTenPounds As Integer = 85

            'assigns strings to indeces
            strOne_Pound = lstDecafSize.Items(0).ToString()
            strTwo_Pounds = lstDecafSize.Items(1).ToString()
            strTen_Pounds = lstDecafSize.Items(2).ToString()

            'using select case to check what size is selected to account cost
            Select Case lstDecafSize.SelectedItem.ToString

                'case for one pound size price multiplied by quantity to find total for the selection
                Case Is = strOne_Pound
                    dblCost += intOnePound * CInt(txtDecafQuantity.Text)

                    'case for two pound size price multiplied by quantity to find total for the selection
                Case Is = strTwo_Pounds
                    dblCost += intTwoPounds * CInt(txtDecafQuantity.Text)

                    'ten pound case
                Case Is = strTen_Pounds
                    dblCost += intTenPounds * CInt(txtDecafQuantity.Text)

            End Select

            'message shows the subtotal in a popup window
            MessageBox.Show(CStr("Current Subtotal is " & dblCost.ToString("c")))

            'catch exceptions if no entry has been made
        Catch
            'display the message if no selection was made
            MessageBox.Show("Please choose the product, weight and insert the desired quantity and ensure that the quantity is numeric")
        End Try

        'puts focus on clear once add to order has been clicked and computed
        btnDecafExit.Focus()

    End Sub

    Private Sub btnDecafExit_Click(sender As Object, e As EventArgs) Handles btnDecafExit.Click

        'close the decaf form
        Me.Close()

    End Sub

    Private Sub btnDecafClear_Click(sender As Object, e As EventArgs) Handles btnDecafExit.Click

        'return the brand value to index 0 which relates to the first choice on the list
        Me.cboDecafBrand.SelectedIndex = 0

        'return the value to the 1st choice on the list for the size
        Me.lstDecafSize.SelectedIndex = 0

        'clears the content in the txtbox for quantity if any value remained
        txtDecafQuantity.Clear()

        'puts focus on the add button
        btnDecafAdd.Focus()

    End Sub
End Class
