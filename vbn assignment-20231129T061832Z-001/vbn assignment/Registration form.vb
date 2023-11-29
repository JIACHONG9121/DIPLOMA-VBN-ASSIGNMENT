Public Class Registration_form
    Dim con As New OleDb.OleDbConnection

    Dim dbprovider As String
    Dim dbsource As String

    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet

    Dim index As Integer
    Dim totalrecords As Integer

    Sub navigateRecords()

        If ds.Tables("CustomerInformation").Rows.Count > 0 Then
            TxtCustomerID.Text = ds.Tables("CustomerInformation").Rows(index).Item(0)
            TxtName.Text = ds.Tables("CustomerInformation").Rows(index).Item(1)
            'CboGender.Text = ds.Tables("CustomerInformation").Rows(index).Item(2)
            'txtAddress.Text = ds.Tables("CustomerInformation").Rows(index).Item(3)
            'txtContactNumber.Text = ds.Tables("CustomerInformation").Rows(index).Item(4)

        Else
            MessageBox.Show("record not found")
        End If
    End Sub
    Private Sub Registration_form(sender As Object, e As EventArgs) Handles MyBase.Load
        dbprovider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbsource = "Data source = Vbn database.mdb"

        con.ConnectionString = dbprovider & dbsource

        con.Open()
        MessageBox.Show("connection opened.")

        sql = "select * from CustomerInformation"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "CustomerInformation")

        con.Close()

        index = 0
        totalrecords = ds.Tables("CustomerInformation").Rows.Count
        navigaterecords()
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Main_page.Show()
        Me.Hide()
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables("CustomerInformation").NewRow()
        dsNewRow.Item(0) = TxtCustomerID.Text
        dsNewRow.Item(1) = TxtName.Text
        dsNewRow.Item(2) = CboGender.Text
        dsNewRow.Item(3) = txtAddress.Text
        dsNewRow.Item(4) = txtContactNumber.Text
        ds.Tables("CustomerInformation").Rows.Add(dsNewRow)

        da.Update(ds, "CustomerInformation")
        totalrecords = totalrecords + 1
        MsgBox("new record added to the database")

    End Sub

    Private Sub btnBackToCustomerLogin_Click(sender As Object, e As EventArgs) Handles btnBackToCustomerLogin.Click
        Customer_login_page.Show()
        Me.Hide()
    End Sub


End Class