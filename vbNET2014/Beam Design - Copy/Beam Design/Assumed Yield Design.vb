Public Class frmYieldBeamDesign

    Dim i As Integer = 0 'declare an integer used for indeces of the arrys
    Dim intCount As Integer = 0 'declare a counter used for the bartype
    Dim intCounter As Integer = 0 'declare a counter used for the quantity of bars

    Private Sub frmYieldBeamDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'loop that adds the bartype items array
        Do Until intCount = 9
            Me.cboBarType.Items.Add(BarType(intCount))
            intCount += 1
        Loop

        'loop that adds the quantity items array
        Do Until intCounter = 10
            Me.cboQuantityOfBars.Items.Add(QuantityOfBars(intCounter))
            intCounter += 1
        Loop

    End Sub

    Private Sub cboQuantityOfBars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboQuantityOfBars.SelectedIndexChanged
        Dim NumberOfBars As Integer 'declare the number of bars integer used to find area of steel used

        'condition that checks if selected bartype and quantity of bars to find the area of steel
        If Me.cboBarType.SelectedIndex <> -1 Then
            i = Me.cboBarType.SelectedIndex
            If Me.cboQuantityOfBars.SelectedIndex <> -1 Then
                NumberOfBars = CInt(Me.cboQuantityOfBars.SelectedItem)
                lblAsteel.Text = CStr(Asteel(i) * NumberOfBars)
            End If
        End If

    End Sub

    Private Sub cboBarType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBarType.SelectedIndexChanged

        'conditional property if textboxes are not empty then find the area of the concrete block
        If txtd.Text <> "" And txtb.Text <> "" Then
            lblAc.Text = CStr(Aconcrete(CDbl(txtb.Text), CDbl(txtd.Text)))
        End If
    End Sub

    Private Sub txtFy_TextChanged(sender As Object, e As EventArgs) Handles txtFy.TextChanged

        Dim T As Integer

        If lblAsteel.Text <> "" And txtFy.Text <> "" Then

            T = CInt(txtFy.Text) * CInt(lblAsteel.Text)
            lblT.Text = CStr(T.ToString(""))
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'declare a collection object variable
        Dim CollectionClear As Collection

        Try
            'instantiate the collection
            CollectionClear = New Collection

            'add the Labels to be cleared to CollectionClear
            CollectionClear.Add(txth)
            CollectionClear.Add(txtb)
            CollectionClear.Add(txtd)
            CollectionClear.Add(cboBarType)
            CollectionClear.Add(cboQuantityOfBars)
            CollectionClear.Add(txtEy)
            CollectionClear.Add(txtFy)
            CollectionClear.Add(txtfcomp)
            CollectionClear.Add(lblAc)
            CollectionClear.Add(lblAsteel)
            CollectionClear.Add(lbla)
            CollectionClear.Add(lblT)
            CollectionClear.Add(lblAst)
            CollectionClear.Add(lblMn)

            'retrieve and display values from collection
            Dim x As Control
            For Each x In CollectionClear
                x.Text = String.Empty
            Next
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Ast = CDbl(lblAsteel.Text)
        fc = CDbl(txtfcomp.Text)
        Fy = CDbl(txtFy.Text)
        b = CDbl(txtb.Text)
        Ey = CDbl(txtEy.Text)
        d = CDbl(txtd.Text)

        'access the formula to find a in the module
        StrsBlckDpth1()

        'addign the value of a to lbla
        lbla.Text = CStr(a)
        'access formula for the compression from the module
        Ccomp()
        'compute value of c which is the distance to the neutral axis
        c = a / beta
        'access the strain formula in module
        strain()

        'condition if section is yielding then design is good and should continue
        If es > esy Then
            MessageBox.Show("The reinforcement yields, Continue design")
            lblYield.Text = "Yes"
        Else
            MessageBox.Show("The reinforcement does not yield, change the #Bar and or Quantity of bars until section yields")
            lblYield.Text = "No"
            Exit Sub
        End If

        'calling for moment and area of steel from module
        NomMoment()
        MinAsteel()

        lblMn.Text = CStr(Mn)
        lblAst.Text = CStr(Asmin)

    End Sub
End Class