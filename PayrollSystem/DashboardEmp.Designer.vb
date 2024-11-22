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
        labelname = New Label()
        Labelhello = New Label()
        Panel1 = New Panel()
        netpaytxt = New Label()
        Label11 = New Label()
        grosspaytxt = New Label()
        Label10 = New Label()
        regularpaytxt = New Label()
        incometaxtxt = New Label()
        bonusdepends = New Label()
        otdepends = New Label()
        ratedepends = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        namedepends = New Label()
        Label2 = New Label()
        Btnlogout = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' labelname
        ' 
        labelname.AutoSize = True
        labelname.BackColor = Color.Transparent
        labelname.Font = New Font("Montserrat", 25.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelname.ForeColor = Color.FromArgb(CByte(219), CByte(90), CByte(66))
        labelname.Location = New Point(47, 84)
        labelname.Name = "labelname"
        labelname.Size = New Size(305, 72)
        labelname.TabIndex = 18
        labelname.Text = "username"
        ' 
        ' Labelhello
        ' 
        Labelhello.AutoSize = True
        Labelhello.BackColor = Color.Transparent
        Labelhello.Font = New Font("Montserrat", 25.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelhello.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Labelhello.Location = New Point(47, 24)
        Labelhello.Name = "Labelhello"
        Labelhello.Size = New Size(200, 72)
        Labelhello.TabIndex = 17
        Labelhello.Text = "Hello, "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(227), CByte(165), CByte(135))
        Panel1.Controls.Add(netpaytxt)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(grosspaytxt)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(regularpaytxt)
        Panel1.Controls.Add(incometaxtxt)
        Panel1.Controls.Add(bonusdepends)
        Panel1.Controls.Add(otdepends)
        Panel1.Controls.Add(ratedepends)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(namedepends)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(47, 195)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(658, 306)
        Panel1.TabIndex = 16
        ' 
        ' netpaytxt
        ' 
        netpaytxt.AutoSize = True
        netpaytxt.BackColor = Color.Transparent
        netpaytxt.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        netpaytxt.ForeColor = Color.Black
        netpaytxt.Location = New Point(467, 216)
        netpaytxt.Name = "netpaytxt"
        netpaytxt.Size = New Size(77, 30)
        netpaytxt.TabIndex = 39
        netpaytxt.Text = "Total:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(365, 216)
        Label11.Name = "Label11"
        Label11.Size = New Size(110, 30)
        Label11.TabIndex = 38
        Label11.Text = "Net Pay:"
        ' 
        ' grosspaytxt
        ' 
        grosspaytxt.AutoSize = True
        grosspaytxt.BackColor = Color.Transparent
        grosspaytxt.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grosspaytxt.ForeColor = Color.Black
        grosspaytxt.Location = New Point(187, 258)
        grosspaytxt.Name = "grosspaytxt"
        grosspaytxt.Size = New Size(77, 30)
        grosspaytxt.TabIndex = 37
        grosspaytxt.Text = "Total:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(61, 258)
        Label10.Name = "Label10"
        Label10.Size = New Size(132, 30)
        Label10.TabIndex = 36
        Label10.Text = "Gross Pay:"
        ' 
        ' regularpaytxt
        ' 
        regularpaytxt.AutoSize = True
        regularpaytxt.BackColor = Color.Transparent
        regularpaytxt.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        regularpaytxt.ForeColor = Color.Black
        regularpaytxt.Location = New Point(214, 216)
        regularpaytxt.Name = "regularpaytxt"
        regularpaytxt.Size = New Size(77, 30)
        regularpaytxt.TabIndex = 35
        regularpaytxt.Text = "Total:"
        ' 
        ' incometaxtxt
        ' 
        incometaxtxt.AutoSize = True
        incometaxtxt.BackColor = Color.Transparent
        incometaxtxt.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        incometaxtxt.ForeColor = Color.Black
        incometaxtxt.Location = New Point(497, 111)
        incometaxtxt.Name = "incometaxtxt"
        incometaxtxt.Size = New Size(88, 30)
        incometaxtxt.TabIndex = 34
        incometaxtxt.Text = "Name:"
        ' 
        ' bonusdepends
        ' 
        bonusdepends.AutoSize = True
        bonusdepends.BackColor = Color.Transparent
        bonusdepends.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bonusdepends.ForeColor = Color.Black
        bonusdepends.Location = New Point(117, 171)
        bonusdepends.Name = "bonusdepends"
        bonusdepends.Size = New Size(88, 30)
        bonusdepends.TabIndex = 33
        bonusdepends.Text = "Name:"
        ' 
        ' otdepends
        ' 
        otdepends.AutoSize = True
        otdepends.BackColor = Color.Transparent
        otdepends.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        otdepends.ForeColor = Color.Black
        otdepends.Location = New Point(202, 132)
        otdepends.Name = "otdepends"
        otdepends.Size = New Size(88, 30)
        otdepends.TabIndex = 32
        otdepends.Text = "Name:"
        ' 
        ' ratedepends
        ' 
        ratedepends.AutoSize = True
        ratedepends.BackColor = Color.Transparent
        ratedepends.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ratedepends.ForeColor = Color.Black
        ratedepends.Location = New Point(167, 91)
        ratedepends.Name = "ratedepends"
        ratedepends.Size = New Size(88, 30)
        ratedepends.TabIndex = 31
        ratedepends.Text = "Name:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(61, 216)
        Label9.Name = "Label9"
        Label9.Size = New Size(158, 30)
        Label9.TabIndex = 30
        Label9.Text = "Regular Pay:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(351, 111)
        Label8.Name = "Label8"
        Label8.Size = New Size(151, 30)
        Label8.TabIndex = 29
        Label8.Text = "Income Tax:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(19, 171)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 30)
        Label7.TabIndex = 28
        Label7.Text = "Bonus:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(19, 132)
        Label6.Name = "Label6"
        Label6.Size = New Size(177, 30)
        Label6.TabIndex = 27
        Label6.Text = "Overtime Pay:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(19, 91)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 30)
        Label5.TabIndex = 26
        Label5.Text = "Basic Rate:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(351, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(146, 30)
        Label4.TabIndex = 25
        Label4.Text = "Deductions"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(19, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 30)
        Label3.TabIndex = 24
        Label3.Text = "Earnings"
        ' 
        ' namedepends
        ' 
        namedepends.AutoSize = True
        namedepends.BackColor = Color.Transparent
        namedepends.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        namedepends.ForeColor = Color.Black
        namedepends.Location = New Point(112, 13)
        namedepends.Name = "namedepends"
        namedepends.Size = New Size(88, 30)
        namedepends.TabIndex = 23
        namedepends.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(19, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 30)
        Label2.TabIndex = 22
        Label2.Text = "Name:"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Montserrat", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(57, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 30)
        Label1.TabIndex = 21
        Label1.Text = "Here is your payslip" & vbCrLf
        ' 
        ' DashboardEmp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FloralWhite
        ClientSize = New Size(743, 618)
        Controls.Add(Label1)
        Controls.Add(Btnlogout)
        Controls.Add(labelname)
        Controls.Add(Labelhello)
        Controls.Add(Panel1)
        ForeColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "DashboardEmp"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardEmp"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelname As Label
    Friend WithEvents Labelhello As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnlogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents namedepends As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents regularpaytxt As Label
    Friend WithEvents incometaxtxt As Label
    Friend WithEvents bonusdepends As Label
    Friend WithEvents otdepends As Label
    Friend WithEvents ratedepends As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents netpaytxt As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents grosspaytxt As Label
End Class
