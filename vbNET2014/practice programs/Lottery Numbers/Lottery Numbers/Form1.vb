Public Class Form1

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'Create an array to hold five lottery numbers.
        Const intMax_SUBSCRIPT As Integer = 4         'The maximum subscript
        Dim intNumbers(intMax_SUBSCRIPT) As Integer   'Array declaration
        Dim intCount As Integer                       'Loop counter

        ' Create a random object
        Dim rand As New Random

        'Fill the array with random numbers
        'Each number will be in the range 0-99
        For intCount = 0 To intMax_SUBSCRIPT

            ' get a random integer number and assign it to intNumbers
            'the value assigned to intNumbers i s between 0 and 99
            intNumbers(intCount) = rand.Next(100)

        Next

        'display the array elements in a label
        lblFirst.Text = intNumbers(0).ToString()
        lblSecond.Text = intNumbers(1).ToString()
        lblThird.Text = intNumbers(2).ToString()
        lblFourth.Text = intNumbers(3).ToString()
        lblFifth.Text = intNumbers(4).ToString()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
