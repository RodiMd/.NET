Public Class Form1

    Dim number() As Single = {2, 5, 5}
    Dim number2() As Single = {2, 2, 3, 5, 5, 7}
    Dim number3(10) As Single
    Dim unsorted() As Single = {60, 35, 81, 98, 14, 47}
    Dim sorted(10) As Single
    Dim unsorted2() As String = {"Apple", "Organge", "Banana", "Kiwi", "Peach", "Avocado", "Strawbery"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 0 To 2
            lstItems.Items.Add(number(i))
        Next
        For i = 0 To 5
            LstItems2.Items.Add(number2(i))
        Next
        For i = 0 To 5
            lstUnsorted.Items.Add(unsorted(i))
        Next
        For i = 0 To 6
            lstUnsortedList.Items.Add(unsorted2(i))
        Next
    End Sub

    Private Sub btnCommonNumber_Click(sender As Object, e As EventArgs) Handles btnCommonNumber.Click

        Dim count As Integer

        For i = 0 To 2
            If i = 2 Then
                Exit For
            End If
            If number(i) = number(i + 1) Then
                For j = 0 To 5
                    number3(j) = number(i)
                    lstitem3.Items.Add(number3(j))
                    Exit For
                Next
            End If
        Next
        For i = 0 To 5
            If i = 5 Then
                Exit For
            End If
            If number2(i) = number2(i + 1) Then
                For j = 1 To 10
                    number3(j) = number2(i)
                    lstitem3.Items.Add(number3(j))
                    Exit For
                Next
            End If
        Next
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

        'This sorting method works its an option within visual studio
        'Array.Sort(unsorted)
        'For i = 0 To 5
        '    lstSorted.Items.Add(unsorted(i))
        'Next

        'unsorted{60, 35, 81, 98, 14, 47}
        Dim i As Integer, p As Integer

        i = unsorted.Length
        ' MessageBox.Show(i)

        p = 0
        'Selectin Sort
        For j = 0 To i - 1
            For k = j To i - 2

                If unsorted(k + 1) < unsorted(j) Then
                    p = unsorted(j)
                    unsorted(j) = unsorted(k + 1)
                    unsorted(k + 1) = p
                End If
            Next
            lstSorted.Items.Add(unsorted(j))
        Next

        p = 0
        'selection sort routine
        For j = 0 To i - 1
            For k = j + 1 To i - 1

                If unsorted(k) < unsorted(j) Then
                    p = unsorted(j)
                    unsorted(j) = unsorted(k)
                    unsorted(k) = p
                End If
            Next
            lstSorted.Items.Add(unsorted(j))
        Next

        p = 0
        'BubbleSort routine
        For j = 0 To i - 2
            For l = 0 To i - 1 - j
                If l = 5 Then
                    Exit For
                End If

                If unsorted(l + 1) < unsorted(l) Then
                    p = unsorted(l)
                    unsorted(l) = unsorted(l + 1)
                    unsorted(l + 1) = p
                End If
            Next
        Next

        For m = 0 To i - 1
            lstSorted2.Items.Add(unsorted(m))
        Next


    End Sub

    Private Sub btn_Sort_Click(sender As Object, e As EventArgs) Handles btn_Sort.Click

        Dim k As Integer
        k = unsorted2.Length

        For i = 0 To k - 1

        Next


    End Sub
End Class
