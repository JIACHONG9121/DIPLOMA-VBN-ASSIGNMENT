<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration_form))
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblcustomerID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.TxtCustomerID = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.CboGender = New System.Windows.Forms.ComboBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBackToCustomerLogin = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(236, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(268, 36)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Registration Form"
        '
        'lblcustomerID
        '
        Me.lblcustomerID.AutoSize = True
        Me.lblcustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomerID.ForeColor = System.Drawing.Color.Blue
        Me.lblcustomerID.Location = New System.Drawing.Point(133, 104)
        Me.lblcustomerID.Name = "lblcustomerID"
        Me.lblcustomerID.Size = New System.Drawing.Size(91, 17)
        Me.lblcustomerID.TabIndex = 1
        Me.lblcustomerID.Text = "CustomerID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Blue
        Me.lblName.Location = New System.Drawing.Point(132, 170)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 17)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Blue
        Me.lblGender.Location = New System.Drawing.Point(131, 233)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(62, 17)
        Me.lblGender.TabIndex = 3
        Me.lblGender.Text = "Gender"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Blue
        Me.lblAddress.Location = New System.Drawing.Point(130, 299)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 17)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.Blue
        Me.lblContactNumber.Location = New System.Drawing.Point(133, 426)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(124, 17)
        Me.lblContactNumber.TabIndex = 5
        Me.lblContactNumber.Text = "Contact Number"
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.Location = New System.Drawing.Point(269, 104)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.Size = New System.Drawing.Size(296, 22)
        Me.TxtCustomerID.TabIndex = 6
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(269, 164)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(296, 22)
        Me.TxtName.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(269, 299)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(296, 107)
        Me.txtAddress.TabIndex = 9
        Me.txtAddress.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CboGender
        '
        Me.CboGender.FormattingEnabled = True
        Me.CboGender.Items.AddRange(New Object() {"male", "female"})
        Me.CboGender.Location = New System.Drawing.Point(269, 233)
        Me.CboGender.Name = "CboGender"
        Me.CboGender.Size = New System.Drawing.Size(296, 24)
        Me.CboGender.TabIndex = 10
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(269, 426)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(296, 22)
        Me.txtContactNumber.TabIndex = 11
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSubmit.Location = New System.Drawing.Point(133, 499)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(432, 23)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnBackToCustomerLogin
        '
        Me.btnBackToCustomerLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToCustomerLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBackToCustomerLogin.Location = New System.Drawing.Point(133, 576)
        Me.btnBackToCustomerLogin.Name = "btnBackToCustomerLogin"
        Me.btnBackToCustomerLogin.Size = New System.Drawing.Size(208, 45)
        Me.btnBackToCustomerLogin.TabIndex = 13
        Me.btnBackToCustomerLogin.Text = "Back to Customer Login"
        Me.btnBackToCustomerLogin.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnQuit.Location = New System.Drawing.Point(490, 576)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 45)
        Me.btnQuit.TabIndex = 14
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Registration_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(993, 744)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnBackToCustomerLogin)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.CboGender)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtCustomerID)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblcustomerID)
        Me.Controls.Add(Me.lbltitle)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "Registration_form"
        Me.Text = "Registration_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents lblcustomerID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents TxtCustomerID As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents CboGender As ComboBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnBackToCustomerLogin As Button
    Friend WithEvents btnQuit As Button
End Class
