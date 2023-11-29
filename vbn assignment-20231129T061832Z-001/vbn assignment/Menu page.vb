Public Class Menu_page
    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Customer_login_page.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBoxSetA_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSetA.CheckedChanged
        If CheckBoxSetA.Checked = True Then
            txtSetA.Enabled = True

        Else
            CheckBoxSetA.Checked = False
            txtSetA.Enabled = False
        End If

        If CheckBoxSetA.Checked = True Then
            btnQtyPlusSetA.Enabled = True
        Else
            CheckBoxSetA.Checked = False
            btnQtyPlusSetA.Enabled = False
        End If

        If CheckBoxSetA.Checked = True Then
            btnQtyMinusSetA.Enabled = True
        Else
            CheckBoxSetA.Checked = False
            btnQtyMinusSetA.Enabled = False
        End If
        txtSetA.Text = 0
    End Sub

    Private Sub CheckBoxSetB_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSetB.CheckedChanged
        If CheckBoxSetB.Checked = True Then
            txtSetB.Enabled = True

        Else
            CheckBoxSetB.Checked = False
            txtSetB.Enabled = False
        End If

        If CheckBoxSetB.Checked = True Then
            btnQtyPlusSetB.Enabled = True
        Else
            CheckBoxSetB.Checked = False
            btnQtyPlusSetB.Enabled = False
        End If

        If CheckBoxSetB.Checked = True Then
            btnQtyMinusSetB.Enabled = True
        Else
            CheckBoxSetB.Checked = False
            btnQtyMinusSetB.Enabled = False
        End If
        txtSetB.Text = 0
    End Sub

    Private Sub CheckBoxSetC_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSetC.CheckedChanged
        If CheckBoxSetC.Checked = True Then
            TxtSetC.Enabled = True

        Else
            CheckBoxSetA.Checked = False
            TxtSetC.Enabled = False
        End If

        If CheckBoxSetC.Checked = True Then
            btnQtyPlusSetC.Enabled = True
        Else
            CheckBoxSetC.Checked = False
            btnQtyPlusSetC.Enabled = False
        End If

        If CheckBoxSetC.Checked = True Then
            btnQtyMinusSetC.Enabled = True
        Else
            CheckBoxSetC.Checked = False
            btnQtyMinusSetC.Enabled = False
        End If
        TxtSetC.Text = 0

    End Sub

    Private Sub CheckBoxSetD_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSetD.CheckedChanged
        If CheckBoxSetD.Checked = True Then
            txtSetD.Enabled = True

        Else
            CheckBoxSetD.Checked = False
            txtSetD.Enabled = False
        End If

        If CheckBoxSetD.Checked = True Then
            btnQtyPlusSetD.Enabled = True
        Else
            CheckBoxSetD.Checked = False
            btnQtyPlusSetD.Enabled = False
        End If

        If CheckBoxSetD.Checked = True Then
            btnQtyMinusSetD.Enabled = True
        Else
            CheckBoxSetD.Checked = False
            btnQtyMinusSetD.Enabled = False
        End If
        txtSetD.Text = 0

    End Sub

    Private Sub btnQtyPlusSetA_Click(sender As Object, e As EventArgs) Handles btnQtyPlusSetA.Click
        txtSetA.Text += 1
    End Sub

    Private Sub btnQtyMinusSetA_Click(sender As Object, e As EventArgs) Handles btnQtyMinusSetA.Click
        txtSetA.Text -= 1
        If txtSetA.Text < 0 Then
            txtSetA.Text = 0
        End If
    End Sub

    Private Sub btnQtyPlusSetB_Click(sender As Object, e As EventArgs) Handles btnQtyPlusSetB.Click
        txtSetB.Text += 1
    End Sub

    Private Sub btnQtyMinusSetB_Click(sender As Object, e As EventArgs) Handles btnQtyMinusSetB.Click
        txtSetB.Text -= 1
        If txtSetB.Text < 0 Then
            txtSetB.Text = 0
        End If
    End Sub

    Private Sub btnQtyPlusSetC_Click(sender As Object, e As EventArgs) Handles btnQtyPlusSetC.Click
        TxtSetC.Text += 1
    End Sub

    Private Sub btnQtyMinusSetC_Click(sender As Object, e As EventArgs) Handles btnQtyMinusSetC.Click
        TxtSetC.Text -= 1
        If TxtSetC.Text < 0 Then
            TxtSetC.Text = 0
        End If
    End Sub

    Private Sub btnQtyPlusSetD_Click(sender As Object, e As EventArgs) Handles btnQtyPlusSetD.Click
        txtSetD.Text += 1
    End Sub

    Private Sub btnQtyMinusSetD_Click(sender As Object, e As EventArgs) Handles btnQtyMinusSetD.Click
        txtSetD.Text -= 1
        If txtSetD.Text < 0 Then
            txtSetD.Text = 0
        End If
    End Sub

    Private Sub txtSetA_TextChanged(sender As Object, e As EventArgs) Handles txtSetA.TextChanged
        txtSetA.ReadOnly = True
    End Sub

    Private Sub txtSetB_TextChanged(sender As Object, e As EventArgs) Handles txtSetB.TextChanged
        txtSetB.ReadOnly = True
    End Sub

    Private Sub TxtSetC_TextChanged(sender As Object, e As EventArgs) Handles TxtSetC.TextChanged
        TxtSetC.ReadOnly = True
    End Sub

    Private Sub txtSetD_TextChanged(sender As Object, e As EventArgs) Handles txtSetD.TextChanged
        txtSetD.ReadOnly = True
    End Sub

    Private Sub btncontinue_Click(sender As Object, e As EventArgs) Handles btncontinue.Click
        Dim SetA As Decimal
        Dim SetB As Decimal
        Dim SetC As Decimal
        Dim SetD As Decimal
        Dim Total As Decimal
        Dim Tax As Decimal
        Dim Subtotal As Decimal

        SetA = txtSetA.Text * 10.0
        SetB = txtSetB.Text * 8.0
        SetC = TxtSetC.Text * 12.0
        SetD = txtSetD.Text * 8.0
        Total = SetA + SetB + SetC + SetD
        Tax = Total * 0.06
        Subtotal = Total + Tax

        If CheckBoxSetA.Checked Then
            Check_Out_page.lstOrder.Items.Add("Set A" & vbTab & txtSetA.Text & vbTab & "RM" & SetA)
        End If

        If CheckBoxSetB.Checked Then
            Check_Out_page.lstOrder.Items.Add("Set B" & vbTab & txtSetB.Text & vbTab & "RM" & SetB)
        End If

        If CheckBoxSetC.Checked Then
            Check_Out_page.lstOrder.Items.Add("Set C" & vbTab & TxtSetC.Text & vbTab & "RM" & SetC)
        End If

        If CheckBoxSetD.Checked Then
            Check_Out_page.lstOrder.Items.Add("Set D" & vbTab & txtSetD.Text & vbTab & "RM" & SetD)
        End If

        Check_Out_page.txtTotalAmount.Text = Total
        Check_Out_page.txtTax.Text = Tax
        Check_Out_page.txtSubTotal.Text = Subtotal

        Check_Out_page.Show()
        Me.Hide()

        txtSetA.Text = 0
        txtSetB.Text = 0
        TxtSetC.Text = 0
        txtSetD.Text = 0
        CheckBoxSetA.Checked = False
        CheckBoxSetB.Checked = False
        CheckBoxSetC.Checked = False
        CheckBoxSetD.Checked = False
    End Sub
End Class