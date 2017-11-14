Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decCelsius As Decimal

        decCelsius = CDec((txtFarhenheit.Text) - 32) / 1.8

        lblCelsius.Text = decCelsius
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtFarhenheit.Clear()
        lblCelsius.Text = String.Empty
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
