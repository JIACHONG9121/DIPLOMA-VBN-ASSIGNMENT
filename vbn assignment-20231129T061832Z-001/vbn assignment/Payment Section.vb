Public Class Payment_Section
    Private Sub txtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged
        txtSubTotal.ReadOnly = True
    End Sub

    Private Sub txtTotalAmountPress_TextChanged(sender As Object, e As EventArgs) Handles txtTotalAmountPress.TextChanged
        txtTotalAmountPress.ReadOnly = True

    End Sub

    Private Sub txtChange_TextChanged(sender As Object, e As EventArgs) Handles txtChange.TextChanged
        txtChange.ReadOnly = True
    End Sub

    Private Sub btnRm0_10_Click(sender As Object, e As EventArgs) Handles btnRm0_10.Click
        txtTotalAmountPress.Text += 0.1
    End Sub

    Private Sub btnRm0_20_Click(sender As Object, e As EventArgs) Handles btnRm0_20.Click
        txtTotalAmountPress.Text += 0.2
    End Sub

    Private Sub btnRm0_50_Click(sender As Object, e As EventArgs) Handles btnRm0_50.Click
        txtTotalAmountPress.Text += 0.5
    End Sub

    Private Sub btnRm1_Click(sender As Object, e As EventArgs) Handles btnRm1.Click
        txtTotalAmountPress.Text += 1
    End Sub

    Private Sub btnRm5_Click(sender As Object, e As EventArgs) Handles btnRm5.Click
        txtTotalAmountPress.Text += 5
    End Sub

    Private Sub btnRm10_Click(sender As Object, e As EventArgs) Handles btnRm10.Click
        txtTotalAmountPress.Text += 10
    End Sub

    Private Sub btnRm20_Click(sender As Object, e As EventArgs) Handles btnRm20.Click
        txtTotalAmountPress.Text += 20
    End Sub

    Private Sub btnRm50_Click(sender As Object, e As EventArgs) Handles btnRm50.Click
        txtTotalAmountPress.Text += 50
    End Sub

    Private Sub btnRm100_Click(sender As Object, e As EventArgs) Handles btnRm100.Click
        txtTotalAmountPress.Text += 100
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTotalAmountPress.Text = 0
        txtChange.Text = 0
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        Dim minus As Decimal
        minus = txtTotalAmountPress.Text - txtSubTotal.Text
        txtChange.Text = Math.Round(Val(txtChange.Text), 2)
        txtChange.Text = minus

        If txtSubTotal.Text <= txtTotalAmountPress.Text Then
            MessageBox.Show("Thank you purchase")
        ElseIf txtSubTotal.Text > txtTotalAmountPress.Text Then
            txtChange.Text = 0
            MessageBox.Show("Wrong amount")
        End If



    End Sub
End Class