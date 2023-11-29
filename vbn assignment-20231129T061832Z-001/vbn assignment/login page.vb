Public Class login_page
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String

        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet

        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source = Vbn database.mdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()


        sql = "select * from LoginStaff where StaffID = '" & txtstaffID.Text & "' and Password = '" & txtPassword.Text & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "LoginStaff")

        If ds.Tables("LoginStaff").Rows.Count > 0 Then
            txtstaffID.Text = ds.Tables("LoginStaff").Rows(0).Item(0)
            txtPassword.Text = ds.Tables("LoginStaff").Rows(0).Item(1)
            MessageBox.Show("Welcome " + txtstaffID.Text)
            Main_page.Show()
            Main_page.Label1.Text = txtstaffID.Text
            txtstaffID.Clear()
            txtPassword.Clear()
            Me.Hide()
        Else MessageBox.Show("Please enter correct Staff ID,Password")
            txtstaffID.Clear()
            txtPassword.Clear()
            Me.Show()

        End If
        con.Close()


    End Sub

    Private Sub CheckBoxPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = True
        If CheckBoxPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            CheckBoxPassword.Checked = False
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub


End Class