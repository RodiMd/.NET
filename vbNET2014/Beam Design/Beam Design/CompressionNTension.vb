Public Class frmCompressionNTension

    Dim i As Integer
    Dim NumberOfBars As Integer 'declare the number of bars integer used to find area of steel used

    Private Sub frmCompressionNTension_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim icount As Integer = 0
        Do Until icount = 9

            Me.cboBarTypeC.Items.Add(BarType(icount))
            Me.cboBarTypeT.Items.Add(BarType(icount))
            Me.cboBarQuantityC.Items.Add(QuantityOfBars(icount))
            Me.cboBarQuantityT.Items.Add(QuantityOfBars(icount))
            icount += 1
        Loop

    End Sub

    Private Sub cboBarQuantityC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBarQuantityC.SelectedIndexChanged

        'condition that checks if selected bartype and quantity of bars to find the area of steel
        If Me.cboBarTypeC.SelectedIndex <> -1 Then
            i = Me.cboBarTypeC.SelectedIndex
            If Me.cboBarQuantityC.SelectedIndex <> -1 Then
                NumberOfBars = CInt(Me.cboBarQuantityC.SelectedItem)
                lblAsc.Text = CStr(Asteel(i) * NumberOfBars)
            End If
        End If

    End Sub

    Private Sub cboBarQuantityT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBarQuantityT.SelectedIndexChanged

        'condition that checks if selected bartype and quantity of bars to find the area of steel
        If Me.cboBarTypeT.SelectedIndex <> -1 Then
            i = Me.cboBarTypeT.SelectedIndex
            If Me.cboBarQuantityT.SelectedIndex <> -1 Then
                NumberOfBars = CInt(Me.cboBarQuantityT.SelectedItem)
                lblAs.Text = CStr(Asteel(i) * NumberOfBars)
            End If
        End If

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        dc = CDbl(txtdc.Text)
        c = CDbl(txtc.Text)
        Ey = CDbl(txtEy.Text)
        Fy = CDbl(txtFy.Text)
        Asc = CDbl(lblAsc.Text)
        fc = CDbl(txtfcomp.Text)
        b = CDbl(txtb.Text)
        d = CDbl(txtd.Text)
        Ast = CDbl(lblAs.Text)

        StrainC() 'calling the strain for compression from module
        lblesc.Text = CStr(es.ToString("n5"))

        fcomp()
        lblfcomp.Text = CStr(fs)

        Ccmp()
        lblCs.Text = CStr(Cs)
        lblCc.Text = CStr(Cc)

        lblT.Text = CStr(CDbl(lblAs.Text) * CDbl(txtFy.Text))

        lblCsCc.Text = CStr(Cs + Cc)

        If CDbl(lblT.Text) > Cs + Cc Then
            lblEquality.Text = "No, Increase C"
        ElseIf CDbl(lblT.Text) < Cs + Cc Then
            lblEquality.Text = "No, Decrease C"
        Else
            lblEquality.Text = "Yes"
        End If

        strain()
        lbles.Text = CStr(es.ToString("n5"))

        If radNone.Checked = True Then
            fi = 1
        ElseIf radStirrups.Checked = True Then
            fiStirrups()
        ElseIf radSpiral.Checked = True Then
            fiSpiral()
        End If

        Mnominal()
        lbla.Text = CStr(a)
        lblMn.Text = CStr(Mn)

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
            CollectionClear.Add(txtdc)
            CollectionClear.Add(txtc)
            CollectionClear.Add(txtEy)
            CollectionClear.Add(txtFy)
            CollectionClear.Add(txtfcomp)
            CollectionClear.Add(lblAsc)
            CollectionClear.Add(lblAs)
            CollectionClear.Add(lbla)
            CollectionClear.Add(lblT)
            CollectionClear.Add(lblesc)
            CollectionClear.Add(lblMn)
            CollectionClear.Add(lblCs)
            CollectionClear.Add(lblCc)
            CollectionClear.Add(lblCsCc)
            CollectionClear.Add(lblT)
            CollectionClear.Add(lblEquality)
            CollectionClear.Add(lbles)

            'retrieve and display values from collection
            Dim x As Control
            For Each x In CollectionClear
                x.Text = String.Empty
            Next
        Catch ex As Exception
            MsgBox("Error")
        End Try

        cboBarTypeC.SelectedIndex = -1
        cboBarTypeT.SelectedIndex = -1
        cboBarQuantityT.SelectedIndex = -1
        cboBarQuantityC.SelectedIndex = -1
    End Sub

    
End Class