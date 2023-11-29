<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_page))
        Me.BtnRegisterNewCustomer = New System.Windows.Forms.Button()
        Me.btnCustomerLogin = New System.Windows.Forms.Button()
        Me.Btnlogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRegisterNewCustomer
        '
        Me.BtnRegisterNewCustomer.Location = New System.Drawing.Point(360, 223)
        Me.BtnRegisterNewCustomer.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnRegisterNewCustomer.Name = "BtnRegisterNewCustomer"
        Me.BtnRegisterNewCustomer.Size = New System.Drawing.Size(264, 72)
        Me.BtnRegisterNewCustomer.TabIndex = 1
        Me.BtnRegisterNewCustomer.Text = "Register New Customer"
        Me.BtnRegisterNewCustomer.UseVisualStyleBackColor = True
        '
        'btnCustomerLogin
        '
        Me.btnCustomerLogin.Location = New System.Drawing.Point(360, 352)
        Me.btnCustomerLogin.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnCustomerLogin.Name = "btnCustomerLogin"
        Me.btnCustomerLogin.Size = New System.Drawing.Size(264, 72)
        Me.btnCustomerLogin.TabIndex = 2
        Me.btnCustomerLogin.Text = "CustomerLogin "
        Me.btnCustomerLogin.UseVisualStyleBackColor = True
        '
        'Btnlogout
        '
        Me.Btnlogout.Location = New System.Drawing.Point(403, 480)
        Me.Btnlogout.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Btnlogout.Name = "Btnlogout"
        Me.Btnlogout.Size = New System.Drawing.Size(180, 72)
        Me.Btnlogout.TabIndex = 3
        Me.Btnlogout.Text = "Log out"
        Me.Btnlogout.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(411, -1)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Main Page"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(360, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 71)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(961, 743)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btnlogout)
        Me.Controls.Add(Me.btnCustomerLogin)
        Me.Controls.Add(Me.BtnRegisterNewCustomer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Main_page"
        Me.Text = "-----------------------"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRegisterNewCustomer As Button
    Friend WithEvents btnCustomerLogin As Button
    Friend WithEvents Btnlogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
