Public Class Form1

    Private Sub btnEnterNames_Click(sender As Object, e As EventArgs) Handles btnEnterNames.Click
        Const intMax_SUBSCRIPT As Integer = 4         'the max subscript
        Dim strNames(intMax_SUBSCRIPT) As String      'array to hold names
        Dim intCount As Integer                       ' loop counter

        'tell the user what we are about to do
        MessageBox.Show("I'm going to ask you to enter the names " &
                        "of five friends.")

        'Get the names and store them in the array.
        For intCount = 0 To intMax_SUBSCRIPT
            strNames(intCount) = InputBox("Enter a friend's name.")
        Next

        'clear the list box of its current contents.
        lstFriends.Items.Clear()

        'display the contents of the array in the list box.
        For intCount = 0 To intMax_SUBSCRIPT
            lstFriends.Items.Add(strNames(intCount))
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
