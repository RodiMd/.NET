'Rodi Murad
'CIT 161
'Bonus Program that writes to a txt document the employee information

Imports System.IO

Public Class Form1
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'declaring the department array and the counter used for the loop
        Dim intCount As Integer = 0

        'declare an array of the departments included in the combobox control
        Dim strDepartments() As String = {"Accounting ", "Administration", "Marketing", "MIS", "Sales"}

        'loop to add array items to the cboDepartment box
        Do Until intCount = 5

            Me.cboDepartment.Items.Add(strDepartments(intCount))
            intCount += 1
        Loop

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'close application
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear the txtbox and cbobox upon the clear button click event
        txtFirstName.Clear()
        txtLastName.Clear()

        'return the cbo value to empty
        Me.cboDepartment.SelectedIndex = -1

        'returning focus to the save button once all fields are cleared
        btnSaveRecord.Focus()

    End Sub

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click

        'condition to ensure that no fields are empty when clicking to save the data
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or Me.cboDepartment.Text = "" Then
            MessageBox.Show("Please fill in the fields before saving data")
            Exit Sub
        End If

        'declare a streamwriter
        Dim EmployeeList As StreamWriter

        'using the append command to add data to the existing file
        EmployeeList = File.AppendText("EmpData.txt")
        EmployeeList.WriteLine("First Name: " & txtFirstName.Text)
        EmployeeList.WriteLine("Last Name: " & txtLastName.Text)

        'used the write command instead of the writeline due to strict on option
        'disallowing to use the & with me.cbo... 
        EmployeeList.Write("Department: ")
        EmployeeList.Write(Me.cboDepartment.SelectedItem)
        EmployeeList.WriteLine() ' I am not sure why it needs two lines of the writeline() code
        EmployeeList.WriteLine() 'to show me one space but if i removed one then it doesn't show me the space. 
        EmployeeList.Close()

        'puts focus on the clear button after the save event
        btnClear.Focus()

    End Sub
End Class
