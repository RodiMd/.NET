Public Class Main_Form

    Dim frmBalBeamDesign As New frmBalBeamDesign
    Dim frmYieldBeamDesign As New frmYieldBeamDesign
    Dim frmTensionControlled As New frmTensionControlled
    Dim frmCompressionNTension As New frmCompressionNTension

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfo.Text = ("This form has been created as a connection form to various concrete beam designs that can be chosen from, " &
                        "click the button for the applicable design needed")

        MessageBox.Show("The applications for beam design included here are only to be used for verification and perlimenary design purposes,they shall not be used for final design." &
                        "The author shall not be responsible if the user uses the applications in a manner other than intended." &
                        "The applicatinos for various conditions of beam design shall not be used in legal disputes.")
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

    Private Sub btnTnC_Click(sender As Object, e As EventArgs) Handles btnTnC.Click

        frmCompressionNTension.ShowDialog()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Me.Close()

    End Sub
End Class