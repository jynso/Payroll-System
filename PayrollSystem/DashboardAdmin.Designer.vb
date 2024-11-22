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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardAdmin))
        Labelhello = New Label()
        Labelname = New Label()
        Btnlogout = New Button()
        lbdisplay = New ListBox()
        btnadd = New Button()
        btndel = New Button()
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
        ' lbdisplay
        ' 
        lbdisplay.Font = New Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbdisplay.FormattingEnabled = True
        lbdisplay.ItemHeight = 30
        lbdisplay.Location = New Point(63, 200)
        lbdisplay.Name = "lbdisplay"
        lbdisplay.Size = New Size(619, 214)
        lbdisplay.TabIndex = 26
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.FromArgb(CByte(115), CByte(146), CByte(240))
        btnadd.FlatStyle = FlatStyle.Popup
        btnadd.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnadd.Location = New Point(166, 462)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(138, 48)
        btnadd.TabIndex = 27
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btndel
        ' 
        btndel.BackColor = Color.FromArgb(CByte(207), CByte(105), CByte(119))
        btndel.FlatStyle = FlatStyle.Popup
        btndel.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndel.Location = New Point(431, 462)
        btndel.Name = "btndel"
        btndel.Size = New Size(138, 48)
        btndel.TabIndex = 28
        btndel.Text = "Delete"
        btndel.UseVisualStyleBackColor = False
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(243))
        ClientSize = New Size(743, 618)
        Controls.Add(btndel)
        Controls.Add(btnadd)
        Controls.Add(lbdisplay)
        Controls.Add(Btnlogout)
        Controls.Add(Labelname)
        Controls.Add(Labelhello)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
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
    Friend WithEvents Btnlogout As Button
    Friend WithEvents lbdisplay As ListBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btndel As Button
End Class
