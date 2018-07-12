Public Class frmTensionControlled

    Dim i As Integer = 0 'declare an integer used for indeces of the arrys
    Dim intCount As Integer = 0 'declare a counter used for the bartype
    Dim intCounter As Integer = 0 'declare a counter used for the quantity of bars

    Private Sub frmTensionControlled_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'loop that adds the bartype items array
        Do Until intCount = 9
            Me.cboBarType.Items.Add(BarType(intCount))
            intCount += 1
        Loop

        'loop that adds the quantity items array
        Do Until intCounter = 9
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

    Private Sub txtb_TextChanged(sender As Object, e As EventArgs)
        dt = CInt(txtdt.Text)
        b = CInt(txtb.Text)

        'calculate the area of concrete in the tension section
        If txtb.Text <> "" And txtdt.Text <> "" Then
            'calling the concrete area formula from the module
            Aconcrete1()
            lblAc.Text = CStr(Ac)

        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Ast = CDbl(lblAsteel.Text)
        fc = CDbl(txtfcomp.Text)
        Fy = CDbl(txtFy.Text)
        b = CDbl(txtb.Text)
        Ey = CDbl(txtEy.Text)
        d = CDbl(txtd.Text)


        Dim T As Integer

        If lblAsteel.Text <> "" And txtFy.Text <> "" Then

            T = CInt(txtFy.Text) * CInt(lblAsteel.Text)
            lblT.Text = CStr(T.ToString(""))
        End If

        StrsBlckDpth1()
        Ccomp()

        c = a / beta

        lblc.Text = CStr(c)

        strain()

        If es > 0.005 Then
            lblYield.Text = "Yes"
        ElseIf es > esy And es < 0.005 Then
            lblYield.Text = "transition"
        Else
            lblYield.Text = "No"
        End If

        If radNone.Checked = True Then
            fi = 1
        ElseIf radStirrups.Checked = True Then
            fiStirrups()
        ElseIf radSpiral.Checked = True Then
            fiSpiral()
        End If

        lblfi.Text = CStr(fi)

        'calling for moment and area of steel from module
        Mnominal()
        MinAsteel()

        lblMn.Text = CStr(Mn)
        lblAst.Text = CStr(Asmin)

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
            CollectionClear.Add(txtd)
            CollectionClear.Add(txtdt)
            CollectionClear.Add(txtb)
            CollectionClear.Add(txtEy)
            CollectionClear.Add(txtFy)
            CollectionClear.Add(txtfcomp)
            CollectionClear.Add(lblAc)
            CollectionClear.Add(lblAsteel)
            CollectionClear.Add(lblT)
            CollectionClear.Add(lblc)
            CollectionClear.Add(lblYield)
            CollectionClear.Add(lblfi)
            CollectionClear.Add(lblMn)
            CollectionClear.Add(lblAst)

            'retrieve and display values from collection
            Dim x As Control
            For Each x In CollectionClear
                x.Text = String.Empty
            Next
        Catch ex As Exception
            MsgBox("Error")
        End Try

        cboBarType.SelectedIndex = -1
        cboQuantityOfBars.SelectedIndex = -1

    End Sub
End Class