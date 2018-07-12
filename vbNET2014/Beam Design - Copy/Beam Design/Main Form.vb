Public Class Main_Form

    Dim frmBalBeamDesign As New frmBalBeamDesign
    Dim frmYieldBeamDesign As New frmYieldBeamDesign
    Dim frmTensionControlled As New frmTensionControlled

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfo.Text = ("This form has been created as a connection form to various concrete beam designs that can be chosen from, " &
                        "click the button for the applicable design needed")
    End Sub

    Private Sub btnSngTRBeam_Click(sender As Object, e As EventArgs) Handles btnSngTRBeam.Click

        frmYieldBeamDesign.ShowDialog()

    End Sub

    Private Sub btnBalSngRBeam_Click(sender As Object, e As EventArgs) Handles btnBalSngRBeam.Click

        frmBalBeamDesign.ShowDialog()

    End Sub

    Private Sub btnTensionControlled_Click(sender As Object, e As EventArgs) Handles btnTensionControlled.Click

        frmTensionControlled.ShowDialog()

    End Sub
End Class