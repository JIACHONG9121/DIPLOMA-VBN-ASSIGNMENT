Public Class Customer_login_page
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String

        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet

        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source =vbn database.mdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()


        sql = "select * from CustomerInformation where CustomerID = '" & txtCustomerID.Text & "' and Name = '" & txtName.Text & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "CustomerInformation")
        If ds.Tables("CustomerInformation").Rows.Count > 0 Then
            txtCustomerID.Text = ds.Tables("CustomerInformation").Rows(0).Item(0)
            txtName.Text = ds.Tables("CustomerInformation").Rows(0).Item(1)
            MessageBox.Show("Welcome " + txtName.Text)
            Menu_page.Show()
            txtCustomerID.Clear()
            txtName.Clear()
            Me.Hide()
        Else MessageBox.Show("Please enter correct CustomerID,Name")
            txtCustomerID.Clear()
            txtName.Clear()
            Me.Show()

        End If
        con.Close()

    End Sub

    Private Sub btnmodifyaccount_Click(sender As Object, e As EventArgs) Handles btnmodifyaccount.Click
        Modify_Page.Show()
        Me.Hide()

    End Sub
End Class