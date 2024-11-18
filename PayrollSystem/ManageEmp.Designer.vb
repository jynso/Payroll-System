<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageEmp
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
        Btnback = New Button()
        btnadd = New Button()
        btndel = New Button()
        lbdisplay = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Btnback
        ' 
        Btnback.BackColor = Color.FromArgb(CByte(158), CByte(188), CByte(159))
        Btnback.FlatStyle = FlatStyle.Popup
        Btnback.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnback.Location = New Point(430, 23)
        Btnback.Name = "Btnback"
        Btnback.Size = New Size(83, 48)
        Btnback.TabIndex = 20
        Btnback.Text = "Back"
        Btnback.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.FromArgb(CByte(115), CByte(146), CByte(240))
        btnadd.FlatStyle = FlatStyle.Popup
        btnadd.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnadd.Location = New Point(87, 344)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(138, 48)
        btnadd.TabIndex = 22
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btndel
        ' 
        btndel.BackColor = Color.FromArgb(CByte(207), CByte(105), CByte(119))
        btndel.FlatStyle = FlatStyle.Popup
        btndel.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndel.Location = New Point(294, 344)
        btndel.Name = "btndel"
        btndel.Size = New Size(138, 48)
        btndel.TabIndex = 24
        btndel.Text = "Delete"
        btndel.UseVisualStyleBackColor = False
        ' 
        ' lbdisplay
        ' 
        lbdisplay.FormattingEnabled = True
        lbdisplay.ItemHeight = 25
        lbdisplay.Location = New Point(58, 117)
        lbdisplay.Name = "lbdisplay"
        lbdisplay.Size = New Size(397, 204)
        lbdisplay.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(58, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 27)
        Label1.TabIndex = 26
        Label1.Text = "Id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(96, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 27)
        Label2.TabIndex = 27
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(175, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 27)
        Label3.TabIndex = 28
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(294, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 27)
        Label4.TabIndex = 29
        Label4.Text = "Salary"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(374, 89)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 27)
        Label5.TabIndex = 30
        Label5.Text = "Rate"
        ' 
        ' ManageEmp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(203), CByte(217))
        ClientSize = New Size(536, 435)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbdisplay)
        Controls.Add(btndel)
        Controls.Add(btnadd)
        Controls.Add(Btnback)
        FormBorderStyle = FormBorderStyle.None
        Name = "ManageEmp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageEmp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btnback As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btndel As Button
    Friend WithEvents lbdisplay As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
