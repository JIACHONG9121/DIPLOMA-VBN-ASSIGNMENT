<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment_Section
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment_Section))
        Me.btnRm0_10 = New System.Windows.Forms.Button()
        Me.btnRm0_20 = New System.Windows.Forms.Button()
        Me.btnRm0_50 = New System.Windows.Forms.Button()
        Me.btnRm1 = New System.Windows.Forms.Button()
        Me.btnRm5 = New System.Windows.Forms.Button()
        Me.btnRm10 = New System.Windows.Forms.Button()
        Me.btnRm20 = New System.Windows.Forms.Button()
        Me.btnRm50 = New System.Windows.Forms.Button()
        Me.btnRm100 = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.LblTotalAmountPress = New System.Windows.Forms.Label()
        Me.txtTotalAmountPress = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRm0_10
        '
        Me.btnRm0_10.Location = New System.Drawing.Point(43, 56)
        Me.btnRm0_10.Name = "btnRm0_10"
        Me.btnRm0_10.Size = New System.Drawing.Size(107, 60)
        Me.btnRm0_10.TabIndex = 0
        Me.btnRm0_10.Text = "Rm0.10"
        Me.btnRm0_10.UseVisualStyleBackColor = True
        '
        'btnRm0_20
        '
        Me.btnRm0_20.Location = New System.Drawing.Point(43, 151)
        Me.btnRm0_20.Name = "btnRm0_20"
        Me.btnRm0_20.Size = New System.Drawing.Size(107, 60)
        Me.btnRm0_20.TabIndex = 1
        Me.btnRm0_20.Text = "Rm0.20"
        Me.btnRm0_20.UseVisualStyleBackColor = True
        '
        'btnRm0_50
        '
        Me.btnRm0_50.Location = New System.Drawing.Point(43, 245)
        Me.btnRm0_50.Name = "btnRm0_50"
        Me.btnRm0_50.Size = New System.Drawing.Size(107, 60)
        Me.btnRm0_50.TabIndex = 2
        Me.btnRm0_50.Text = "Rm0.50"
        Me.btnRm0_50.UseVisualStyleBackColor = True
        '
        'btnRm1
        '
        Me.btnRm1.Location = New System.Drawing.Point(229, 56)
        Me.btnRm1.Name = "btnRm1"
        Me.btnRm1.Size = New System.Drawing.Size(107, 60)
        Me.btnRm1.TabIndex = 3
        Me.btnRm1.Text = "Rm 1"
        Me.btnRm1.UseVisualStyleBackColor = True
        '
        'btnRm5
        '
        Me.btnRm5.Location = New System.Drawing.Point(229, 151)
        Me.btnRm5.Name = "btnRm5"
        Me.btnRm5.Size = New System.Drawing.Size(107, 60)
        Me.btnRm5.TabIndex = 4
        Me.btnRm5.Text = "Rm 5"
        Me.btnRm5.UseVisualStyleBackColor = True
        '
        'btnRm10
        '
        Me.btnRm10.Location = New System.Drawing.Point(229, 245)
        Me.btnRm10.Name = "btnRm10"
        Me.btnRm10.Size = New System.Drawing.Size(107, 60)
        Me.btnRm10.TabIndex = 5
        Me.btnRm10.Text = "Rm 10"
        Me.btnRm10.UseVisualStyleBackColor = True
        '
        'btnRm20
        '
        Me.btnRm20.Location = New System.Drawing.Point(408, 56)
        Me.btnRm20.Name = "btnRm20"
        Me.btnRm20.Size = New System.Drawing.Size(107, 60)
        Me.btnRm20.TabIndex = 6
        Me.btnRm20.Text = "Rm 20"
        Me.btnRm20.UseVisualStyleBackColor = True
        '
        'btnRm50
        '
        Me.btnRm50.Location = New System.Drawing.Point(408, 151)
        Me.btnRm50.Name = "btnRm50"
        Me.btnRm50.Size = New System.Drawing.Size(107, 60)
        Me.btnRm50.TabIndex = 7
        Me.btnRm50.Text = "Rm 50"
        Me.btnRm50.UseVisualStyleBackColor = True
        '
        'btnRm100
        '
        Me.btnRm100.Location = New System.Drawing.Point(408, 245)
        Me.btnRm100.Name = "btnRm100"
        Me.btnRm100.Size = New System.Drawing.Size(107, 60)
        Me.btnRm100.TabIndex = 8
        Me.btnRm100.Text = "Rm 100"
        Me.btnRm100.UseVisualStyleBackColor = True
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(121, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(329, 37)
        Me.lbltitle.TabIndex = 9
        Me.lbltitle.Text = "Payment Section Page"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(12, 384)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(65, 17)
        Me.lblSubTotal.TabIndex = 10
        Me.lblSubTotal.Text = "SubTotal"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(15, 404)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(504, 22)
        Me.txtSubTotal.TabIndex = 11
        Me.txtSubTotal.Text = "0"
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(11, 527)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(508, 22)
        Me.txtChange.TabIndex = 12
        Me.txtChange.Text = "0"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(12, 507)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(57, 17)
        Me.lblChange.TabIndex = 13
        Me.lblChange.Text = "Change"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(43, 628)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 60)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(229, 628)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(107, 60)
        Me.btnPay.TabIndex = 15
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(408, 628)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 60)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'LblTotalAmountPress
        '
        Me.LblTotalAmountPress.AutoSize = True
        Me.LblTotalAmountPress.Location = New System.Drawing.Point(15, 442)
        Me.LblTotalAmountPress.Name = "LblTotalAmountPress"
        Me.LblTotalAmountPress.Size = New System.Drawing.Size(132, 17)
        Me.LblTotalAmountPress.TabIndex = 17
        Me.LblTotalAmountPress.Text = "Total Amount Press"
        '
        'txtTotalAmountPress
        '
        Me.txtTotalAmountPress.Location = New System.Drawing.Point(15, 463)
        Me.txtTotalAmountPress.Name = "txtTotalAmountPress"
        Me.txtTotalAmountPress.Size = New System.Drawing.Size(504, 22)
        Me.txtTotalAmountPress.TabIndex = 18
        Me.txtTotalAmountPress.Text = "0"
        '
        'Payment_Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1048, 747)
        Me.Controls.Add(Me.txtTotalAmountPress)
        Me.Controls.Add(Me.LblTotalAmountPress)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.btnRm100)
        Me.Controls.Add(Me.btnRm50)
        Me.Controls.Add(Me.btnRm20)
        Me.Controls.Add(Me.btnRm10)
        Me.Controls.Add(Me.btnRm5)
        Me.Controls.Add(Me.btnRm1)
        Me.Controls.Add(Me.btnRm0_50)
        Me.Controls.Add(Me.btnRm0_20)
        Me.Controls.Add(Me.btnRm0_10)
        Me.Name = "Payment_Section"
        Me.Text = "Payment_Section"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRm0_10 As Button
    Friend WithEvents btnRm0_20 As Button
    Friend WithEvents btnRm0_50 As Button
    Friend WithEvents btnRm1 As Button
    Friend WithEvents btnRm5 As Button
    Friend WithEvents btnRm10 As Button
    Friend WithEvents btnRm20 As Button
    Friend WithEvents btnRm50 As Button
    Friend WithEvents btnRm100 As Button
    Friend WithEvents lbltitle As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtChange As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents LblTotalAmountPress As Label
    Friend WithEvents txtTotalAmountPress As TextBox
End Class
