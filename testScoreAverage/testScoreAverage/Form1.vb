Public Class Form1

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decAverage As Decimal

        decAverage = CDec((txtScoreOne.Text) + CDec(txtScore2.Text) +
            CDec(txtScore3.Text) + CDec(txtScore4.Text) + CDec(txtScore5.Text)) / 5

        lblAverage.Text = decAverage

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore2.Clear()
        txtScore3.Clear()
        txtScore4.Clear()
        txtScore5.Clear()
        txtScoreOne.Clear()
        lblAverage.Text = String.Empty

    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub
End Class
