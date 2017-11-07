Public Class Form1


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'This even handler performs addition
        'Declare a variable to hold the result
        Dim dblResult As Double

        lblOperation.Text = " + "

        dblResult = CDbl(txtNumberOne.Text) + CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        'This event handler performs subtraction
        'Declare a varible to hold the result
        Dim dblResult As Double

        lblOperation.Text = " - "

        dblResult = CDbl(txtNumberOne.Text) - CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        'This even handler performs multiplication
        'Declare a variable to hold the result
        Dim dblResult As Double

        lblOperation.Text = " x "

        dblResult = CDbl(txtNumberOne.Text) * CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnExponent_Click(sender As Object, e As EventArgs) Handles btnExponent.Click
        'This even handler performs exponents
        'Declare a variable to hold the result
        Dim dblResult As Double

        lblOperation.Text = " ^ "

        dblResult = CDbl(txtNumberOne.Text) ^ CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        'This even handler performs division
        'Declare a variable to hold the result
        Dim dblResult As Double

        lblOperation.Text = " / "

        dblResult = CDbl(txtNumberOne.Text) / CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        'This even handler performs modulus
        'Declare a variable to hold the result
        Dim dblResult As Double

        lblOperation.Text = " + "

        dblResult = CDbl(txtNumberOne.Text) \ CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberOne.Clear()
        txtNumberTwo.Clear()
        lblResult.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
