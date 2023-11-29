Public Class Main_page

    Private Sub BtnRegisterNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnRegisterNewCustomer.Click
        Registration_form.Show()
        Me.Hide()
    End Sub

    Private Sub Btnlogout_Click(sender As Object, e As EventArgs) Handles Btnlogout.Click
        login_page.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomerLogin_Click(sender As Object, e As EventArgs) Handles btnCustomerLogin.Click
        Customer_login_page.Show()
        Me.Hide()
    End Sub

End Class