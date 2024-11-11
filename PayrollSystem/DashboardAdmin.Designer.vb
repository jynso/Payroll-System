<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAdmin
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
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Labelhello = New Label()
        Labelname = New Label()
        Btnpayslip = New Button()
        Btnlogout = New Button()
        Btnmanage = New Button()
        SuspendLayout()
        ' 
        ' Labelhello
        ' 
        Labelhello.AutoSize = True
        Labelhello.BackColor = Color.Transparent
        Labelhello.Font = New Font("Montserrat", 25.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelhello.ForeColor = Color.FromArgb(CByte(101), CByte(98), CByte(86))
        Labelhello.Location = New Point(50, 92)
        Labelhello.Name = "Labelhello"
        Labelhello.Size = New Size(200, 72)
        Labelhello.TabIndex = 14
        Labelhello.Text = "Hello, "
        ' 
        ' Labelname
        ' 
        Labelname.AutoSize = True
        Labelname.BackColor = Color.Transparent
        Labelname.Font = New Font("Montserrat", 25.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelname.ForeColor = Color.FromArgb(CByte(35), CByte(9), CByte(3))
        Labelname.Location = New Point(221, 92)
        Labelname.Name = "Labelname"
        Labelname.Size = New Size(213, 72)
        Labelname.TabIndex = 15
        Labelname.Text = "Admin"
        ' 
        ' Btnpayslip
        ' 
        Btnpayslip.BackColor = Color.FromArgb(CByte(211), CByte(184), CByte(140))
        Btnpayslip.FlatStyle = FlatStyle.Popup
        Btnpayslip.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnpayslip.ForeColor = Color.FromArgb(CByte(35), CByte(9), CByte(3))
        Btnpayslip.Location = New Point(397, 255)
        Btnpayslip.Name = "Btnpayslip"
        Btnpayslip.Size = New Size(285, 233)
        Btnpayslip.TabIndex = 17
        Btnpayslip.Text = "Generate Payslip"
        Btnpayslip.UseVisualStyleBackColor = False
        ' 
        ' Btnlogout
        ' 
        Btnlogout.BackColor = Color.FromArgb(CByte(158), CByte(188), CByte(159))
        Btnlogout.FlatStyle = FlatStyle.Popup
        Btnlogout.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnlogout.Location = New Point(561, 92)
        Btnlogout.Name = "Btnlogout"
        Btnlogout.Size = New Size(121, 58)
        Btnlogout.TabIndex = 19
        Btnlogout.Text = "Log out"
        Btnlogout.UseVisualStyleBackColor = False
        ' 
        ' Btnmanage
        ' 
        Btnmanage.BackColor = Color.FromArgb(CByte(211), CByte(184), CByte(140))
        Btnmanage.FlatStyle = FlatStyle.Popup
        Btnmanage.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnmanage.ForeColor = Color.FromArgb(CByte(35), CByte(9), CByte(3))
        Btnmanage.Location = New Point(51, 255)
        Btnmanage.Name = "Btnmanage"
        Btnmanage.Size = New Size(285, 233)
        Btnmanage.TabIndex = 18
        Btnmanage.Text = "Manage Employees"
        Btnmanage.UseVisualStyleBackColor = False
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(243))
        ClientSize = New Size(743, 618)
        Controls.Add(Btnlogout)
        Controls.Add(Btnmanage)
        Controls.Add(Btnpayslip)
        Controls.Add(Labelname)
        Controls.Add(Labelhello)
        Name = "DashboardAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardAdmin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Labelhello As Label
    Friend WithEvents Labelname As Label
    Friend WithEvents Labelmanage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnpayslip As Button
    Friend WithEvents Btnlogout As Button
    Friend WithEvents Btnmanage As Button
End Class
