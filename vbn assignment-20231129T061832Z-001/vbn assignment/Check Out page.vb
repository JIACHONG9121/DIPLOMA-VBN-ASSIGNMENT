Public Class Check_Out_page
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        lstOrder.ClearSelected()
        Menu_page.Show()
        Me.Hide()
    End Sub

    Private Sub btnproceed_Click(sender As Object, e As EventArgs) Handles btnproceed.Click
        Dim STT As Decimal
        STT = txtSubTotal.Text
        Payment_Section.txtSubTotal.Text = STT

        Payment_Section.Show()
        Me.Hide()
    End Sub


End Class