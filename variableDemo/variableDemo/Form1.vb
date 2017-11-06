Public Class Form1

    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        Dim strFullName As String

        strFullName = txtFirst.Text & " " & txtLast.Text

        lblFullName.Text = strFullName
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirst.Clear()
        txtLast.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
