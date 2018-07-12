Public Class Form1

    Public Ast() As Double = {0.11, 0.2, 0.31, 0.44, 0.6, 0.79, 1.0, 1.27, 1.56}
    Dim Quantity() As Integer = {1, 2, 3, 4, 5, 6}
    Dim BarType() As Integer = {3, 4, 5, 6, 7, 8, 9, 10, 11}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'routine to add the quantity of bars into a combobox
        For i = 0 To 5
            Me.cboQuantityofBars1.Items.Add(Quantity(i))
            Me.cboQuantityofBars2.Items.Add(Quantity(i))
        Next

        'routine to add the bar type into a combobox
        For i = 0 To 8
            Me.cboBar1Type.Items.Add(BarType(i))
            Me.cboBar2Type.Items.Add(BarType(i))
        Next

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim i As Integer
        Dim q As Integer
        'calculates the area of the concrete column face
        lblAg.Text = CStr(CDbl(txtb.Text) * CDbl(txth.Text))

        'conditions for calculating the steel area in both locations
        If Me.cboBar1Type.SelectedIndex <> -1 Then
            If Me.cboQuantityofBars1.SelectedIndex <> -1 Then
                i = CInt(Me.cboQuantityofBars1.SelectedItem)
                q = CInt(Me.cboBar1Type.SelectedIndex)
                lblAs1.Text = CStr(Ast(q) * i)
                'reinitialize i and q to zero values
                i = 0
                q = 0

                If Me.cboBar2Type.SelectedIndex <> -1 Then
                    If Me.cboQuantityofBars2.SelectedIndex <> -1 Then
                        i = CInt(Me.cboQuantityofBars2.SelectedItem)
                        q = CInt(Me.cboBar2Type.SelectedIndex)
                        lblAs2.Text = CStr(Ast(q) * i)

                    End If
                End If
            End If
        End If

        Astl = (CSng(lblAs1.Text) + CSng(lblAs2.Text)) 'compute the total area of steel
        lblAstl.Text = CStr(Astl)

        lblRho.Text = CStr(Astl / CDbl(lblAg.Text)) 'compute ratio of steel to concrete
        lbley.Text = CStr((CDbl(txtfy.Text) / CDbl(txtEy.Text)).ToString("n5"))

        ey = CDbl(lbley.Text) 'yield strain of steel 
        es1 = -ey 'strain at point 1 of the reinforcement
        fc = CDbl(txtfc.Text)
        Ag = CDbl(lblAg.Text)
        fy = CDbl(txtfy.Text)
        Astl = CDbl(lblAstl.Text)

        'check if spiral or ties were used to figure out the reduction factor to be used
        If radSpiral.Checked = True Then
            ReductionCoeffSpiral()
            MaxLoadSpiral()
            lblPo.Text = CStr(fiPnmx)
            lblP0.Text = CStr(Pnmx.ToString("n0"))
        ElseIf radTied.Checked = True Then
            ReductionCoeffTied()
            MaxLoadTied()
            lblPo.Text = CStr(fiPnmx.ToString("n0"))
            lblP0.Text = CStr(Pnmx.ToString("n0"))
        End If

        lblfi.Text = CStr(fi.ToString)
        'get values from the form
        d1 = CDbl(txtd1.Text)
        d2 = CDbl(txtd2.Text)
        Es = CDbl(txtEy.Text)

        '***********************************************************************
        'Procedure for Balanced condition

        fc = CDbl(txtfc.Text)
        h = CDbl(txth.Text)
        b = CDbl(txtb.Text)
        As2 = CDbl(lblAs2.Text)
        As1 = CDbl(lblAs1.Text)
        'retrieve the balanced condition from the module
        Balanced()

        If fs_2 = -fs_2 Then
            lblLoad.Text = "tension"
        Else
            lblLoad.Text = "compressive"
        End If

        lblct.Text = CStr(c.ToString("n2"))
        lblfs_2.Text = CStr(fs_2.ToString("n"))

        'force in concrete
        lblCc.Text = CStr(Cc.ToString("n0"))

        lblfs_1.Text = CStr(fs_1.ToString("n0"))
        lblFs1.Text = CStr(Fs1.ToString("n0"))
        lblFs2.Text = CStr(Fs2.ToString("n0"))

        'nominal axial capacity
        lblPoB.Text = CStr(PnB.ToString("n0"))
        lblMnB.Text = CStr(MnB.ToString("n0"))

        '************************************************************
        'Between compression and tension controlled

        es1 = -2 * ey

        If radSpiral.Checked = True Then
            ReductionCoeffSpiral()
        ElseIf radTied.Checked = True Then
            ReductionCoeffTied()
        End If

        Balanced()
        lblPoC.Text = CStr(PnB.ToString("n0"))
        lblMnC.Text = CStr(MnB.ToString("n0"))

        '************************************************************
        'Tension controlled point
        es1 = -0.005
        If radSpiral.Checked = True Then
            ReductionCoeffSpiral()
        ElseIf radTied.Checked = True Then
            ReductionCoeffTied()
        End If

        Balanced()
        lblPoD.Text = CStr(PnB.ToString("n0"))
        lblMnD.Text = CStr(MnB.ToString("n0"))

        '************************************************************
        'Four times the strain E' point below tension controlled

        es1 = -4 * ey
        If radSpiral.Checked = True Then
            ReductionCoeffSpiral()
        ElseIf radTied.Checked = True Then
            ReductionCoeffTied()
        End If

        Balanced()
        lblPoE.Text = CStr(PnB.ToString("n0"))
        lblMnE.Text = CStr(MnB.ToString("n0"))

        '*************************************************************
        'Pure axial tension
        Dim pnt As Double, fiPnt As Double

        pnt = -fy * Astl

        If radSpiral.Checked = True Then
            ReductionCoeffSpiral()
        ElseIf radTied.Checked = True Then
            ReductionCoeffTied()
        End If

        fiPnt = fi * Pnt
        lblPnt.text = CStr(fiPnt.ToString("n0"))


    End Sub

   End Class
