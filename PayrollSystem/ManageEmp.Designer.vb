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
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Btnback
        ' 
        Btnback.BackColor = Color.FromArgb(CByte(158), CByte(188), CByte(159))
        Btnback.FlatStyle = FlatStyle.Popup
        Btnback.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnback.Location = New Point(394, 25)
        Btnback.Name = "Btnback"
        Btnback.Size = New Size(83, 48)
        Btnback.TabIndex = 20
        Btnback.Text = "Back"
        Btnback.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(22, 87)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(455, 292)
        Panel1.TabIndex = 21
        ' 
        ' ManageEmp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(203), CByte(217))
        ClientSize = New Size(500, 407)
        Controls.Add(Panel1)
        Controls.Add(Btnback)
        FormBorderStyle = FormBorderStyle.None
        Name = "ManageEmp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageEmp"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btnback As Button
    Friend WithEvents Panel1 As Panel
End Class
