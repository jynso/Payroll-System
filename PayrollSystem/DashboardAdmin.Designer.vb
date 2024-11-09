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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Labeladd = New Label()
        Labelhello = New Label()
        Labelname = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Labeladd)
        Panel1.Location = New Point(51, 133)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(621, 422)
        Panel1.TabIndex = 0
        ' 
        ' Labeladd
        ' 
        Labeladd.AutoSize = True
        Labeladd.BackColor = Color.FromArgb(CByte(127), CByte(200), CByte(248))
        Labeladd.Font = New Font("Montserrat", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labeladd.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Labeladd.Location = New Point(43, 48)
        Labeladd.Margin = New Padding(5)
        Labeladd.Name = "Labeladd"
        Labeladd.Padding = New Padding(5)
        Labeladd.Size = New Size(209, 43)
        Labeladd.TabIndex = 16
        Labeladd.Text = "Add Employee"
        ' 
        ' Labelhello
        ' 
        Labelhello.AutoSize = True
        Labelhello.BackColor = Color.Transparent
        Labelhello.Font = New Font("Montserrat", 25.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelhello.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Labelhello.Location = New Point(51, 43)
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
        Labelname.ForeColor = Color.FromArgb(CByte(255), CByte(228), CByte(94))
        Labelname.Location = New Point(222, 43)
        Labelname.Name = "Labelname"
        Labelname.Size = New Size(305, 72)
        Labelname.TabIndex = 15
        Labelname.Text = "username"
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FloralWhite
        ClientSize = New Size(743, 618)
        Controls.Add(Labelname)
        Controls.Add(Labelhello)
        Controls.Add(Panel1)
        Name = "DashboardAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardAdmin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Labelhello As Label
    Friend WithEvents Labelname As Label
    Friend WithEvents Labeladd As Label
End Class
