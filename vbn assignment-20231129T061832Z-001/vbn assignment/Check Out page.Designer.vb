<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Check_Out_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Check_Out_page))
        Me.lstOrder = New System.Windows.Forms.ListBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnproceed = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblTotalamount = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstOrder
        '
        Me.lstOrder.Enabled = False
        Me.lstOrder.FormattingEnabled = True
        Me.lstOrder.ItemHeight = 16
        Me.lstOrder.Location = New System.Drawing.Point(277, 109)
        Me.lstOrder.Name = "lstOrder"
        Me.lstOrder.Size = New System.Drawing.Size(351, 84)
        Me.lstOrder.TabIndex = 0
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(214, 481)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 1
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnproceed
        '
        Me.btnproceed.Location = New System.Drawing.Point(523, 481)
        Me.btnproceed.Name = "btnproceed"
        Me.btnproceed.Size = New System.Drawing.Size(75, 23)
        Me.btnproceed.TabIndex = 2
        Me.btnproceed.Text = "Proceed"
        Me.btnproceed.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(103, 109)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(45, 17)
        Me.lblOrder.TabIndex = 3
        Me.lblOrder.Text = "Order"
        '
        'lblTotalamount
        '
        Me.lblTotalamount.AutoSize = True
        Me.lblTotalamount.Location = New System.Drawing.Point(103, 230)
        Me.lblTotalamount.Name = "lblTotalamount"
        Me.lblTotalamount.Size = New System.Drawing.Size(99, 17)
        Me.lblTotalamount.TabIndex = 4
        Me.lblTotalamount.Text = "Total amount$"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(103, 320)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(61, 17)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "Tax(6%)"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(103, 404)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(60, 17)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.Text = "Subtotal"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Location = New System.Drawing.Point(277, 230)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(351, 22)
        Me.txtTotalAmount.TabIndex = 7
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Location = New System.Drawing.Point(277, 320)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(351, 22)
        Me.txtTax.TabIndex = 8
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(277, 404)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(351, 22)
        Me.txtSubTotal.TabIndex = 9
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(271, 22)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(220, 32)
        Me.lbltitle.TabIndex = 10
        Me.lbltitle.Text = "CheckOutPage"
        '
        'Check_Out_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(957, 651)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotalamount)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnproceed)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.lstOrder)
        Me.Name = "Check_Out_page"
        Me.Text = "Check_Out_page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOrder As ListBox
    Friend WithEvents btnback As Button
    Friend WithEvents btnproceed As Button
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblTotalamount As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents lbltitle As Label
End Class
