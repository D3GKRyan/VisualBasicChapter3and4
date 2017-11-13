Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get today's date from the system and display it.
        lblDate.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblTime.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculateCharges_Click(sender As Object, e As EventArgs) Handles btnCalculateCharges.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal   ' Room charges total
        Dim decAddCharges As Decimal   ' Additional charges
        Dim decSubtotal As Decimal   ' Subtotal
        Dim decTax As Decimal   ' Tax
        Dim decTotal As Decimal   ' Total of all charges
        Const decTAX_RATE As Decimal = 0.08D ' Tax Rate

        Try
            ' Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) *
                CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            'Calculate and display the adiitional charges.
            decAddCharges = CDec(txtRoomService.Text) +
                CDec(txtTelephone.Text) +
                CDec(txtMiscellaneous.Text)
            lblAdditionalCharges.Text = decAddCharges.ToString("c")

            'Calculate and display the subtotal
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            ' Calculate and display the tax.
            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            ' Calculate and display the total charges.
            decTotal = decSubtotal + decTax
            lblTotalCharges.Text = decTotal.ToString("c")

            ' Change the colors for the total charges.
            lblTotalCharges.BackColor = Color.Blue
            lblTotalCharges.ForeColor = Color.White

        Catch
            ' Error Message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the room info fields.
        txtNights.Clear()
        txtNightlyCharge.Clear()

        ' Clear the additional charges fields.
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMiscellaneous.Clear()

        ' Clear the decTotal fields.
        lblRoomCharges.Text = String.Empty
        lblAdditionalCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotalCharges.Text = String.Empty

        ' Get today's date from the operating system and display it.
        lblDate.Text = Now.ToString("D")

        ' Get the current time from the operating system and display it.
        lblTime.Text = Now.ToString("T")

        ' Reset the lblTotal control's colors.
        lblTotalCharges.BackColor = SystemColors.Control
        lblTotalCharges.ForeColor = SystemColors.ControlText


        ' Reset the focus to the first field.
        txtNights.Focus()



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub lblSubtotal_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click

    End Sub

    Private Sub lblTax_Click(sender As Object, e As EventArgs) Handles lblTax.Click

    End Sub

End Class
