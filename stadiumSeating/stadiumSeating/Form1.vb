Public Class na

    Private Sub btnCalcRev_Click(sender As Object, e As EventArgs) Handles btnCalcRev.Click
        Dim decClassARev As Decimal
        Dim decClassBRev As Decimal
        Dim decClassCRev As Decimal
        Dim decTotalRev As Decimal

        decClassARev = CDec(txtClassA.Text) * 15
        decClassBRev = CDec(txtClassB.Text) * 12
        decClassCRev = CDec(txtClassC.Text) * 9
        decTotalRev = decClassARev + decClassBRev + decClassCRev

        lblClassARev.Text = decClassARev
        lblClassBRev.Text = decClassBRev
        lblClassCRev.Text = decClassCRev
        lblTotal.Text = decTotalRev

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()
        lblClassARev.Text = String.Empty
        lblClassBRev.Text = String.Empty
        lblClassCRev.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
