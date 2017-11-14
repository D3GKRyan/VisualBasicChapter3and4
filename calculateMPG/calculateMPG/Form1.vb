Public Class Form1

    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        Dim decMilesPerGallon As Decimal    ' Miles Per Gallon Total

        decMilesPerGallon = CDec(txtMiles.Text) / CDec(txtGallons.Text)

        lblMPG.Text = decMilesPerGallon
    End Sub
End Class
