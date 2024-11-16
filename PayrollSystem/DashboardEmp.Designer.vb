<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardEmp
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
        Labelname = New Label()
        Labelhello = New Label()
        Panel1 = New Panel()
        Btnlogout = New Button()
        ListBox1 = New ListBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Labelname
        ' 
        Labelname.AutoSize = True
        Labelname.BackColor = Color.Transparent
        Labelname.Font = New Font("Montserrat", 25.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelname.ForeColor = Color.FromArgb(CByte(219), CByte(90), CByte(66))
        Labelname.Location = New Point(206, 56)
        Labelname.Name = "Labelname"
        Labelname.Size = New Size(305, 72)
        Labelname.TabIndex = 18
        Labelname.Text = "username"
        ' 
        ' Labelhello
        ' 
        Labelhello.AutoSize = True
        Labelhello.BackColor = Color.Transparent
        Labelhello.Font = New Font("Montserrat", 25.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelhello.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Labelhello.Location = New Point(35, 56)
        Labelhello.Name = "Labelhello"
        Labelhello.Size = New Size(200, 72)
        Labelhello.TabIndex = 17
        Labelhello.Text = "Hello, "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(227), CByte(165), CByte(135))
        Panel1.Controls.Add(ListBox1)
        Panel1.Location = New Point(47, 195)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(658, 306)
        Panel1.TabIndex = 16
        ' 
        ' Btnlogout
        ' 
        Btnlogout.BackColor = Color.FromArgb(CByte(158), CByte(188), CByte(159))
        Btnlogout.FlatStyle = FlatStyle.Popup
        Btnlogout.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnlogout.ForeColor = Color.Black
        Btnlogout.Location = New Point(584, 56)
        Btnlogout.Name = "Btnlogout"
        Btnlogout.Size = New Size(121, 58)
        Btnlogout.TabIndex = 20
        Btnlogout.Text = "Log out"
        Btnlogout.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(0, 0)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(379, 204)
        ListBox1.TabIndex = 0
        ' 
        ' DashboardEmp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FloralWhite
        ClientSize = New Size(743, 618)
        Controls.Add(Btnlogout)
        Controls.Add(Labelname)
        Controls.Add(Labelhello)
        Controls.Add(Panel1)
        ForeColor = SystemColors.Control
        Name = "DashboardEmp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardEmp"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Labelname As Label
    Friend WithEvents Labelhello As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnlogout As Button
    Friend WithEvents ListBox1 As ListBox
End Class
