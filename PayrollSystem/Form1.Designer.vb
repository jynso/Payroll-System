<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        dolphin = New PictureBox()
        Labelpassword = New Label()
        txtboxpassword = New TextBox()
        Labelusername = New Label()
        txtboxusername = New TextBox()
        Labelwelcome = New Label()
        btnlogin = New Button()
        CType(dolphin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dolphin
        ' 
        dolphin.BackColor = Color.FloralWhite
        dolphin.Image = CType(resources.GetObject("dolphin.Image"), Image)
        dolphin.Location = New Point(-316, -1)
        dolphin.Name = "dolphin"
        dolphin.Size = New Size(1421, 556)
        dolphin.SizeMode = PictureBoxSizeMode.Zoom
        dolphin.TabIndex = 0
        dolphin.TabStop = False
        ' 
        ' Labelpassword
        ' 
        Labelpassword.AutoSize = True
        Labelpassword.BackColor = Color.Transparent
        Labelpassword.Font = New Font("Montserrat Medium", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelpassword.ForeColor = Color.Black
        Labelpassword.Location = New Point(305, 337)
        Labelpassword.Name = "Labelpassword"
        Labelpassword.Size = New Size(130, 30)
        Labelpassword.TabIndex = 17
        Labelpassword.Text = "Password"
        ' 
        ' txtboxpassword
        ' 
        txtboxpassword.Location = New Point(276, 405)
        txtboxpassword.Name = "txtboxpassword"
        txtboxpassword.Size = New Size(229, 31)
        txtboxpassword.TabIndex = 16
        ' 
        ' Labelusername
        ' 
        Labelusername.AutoSize = True
        Labelusername.BackColor = Color.Transparent
        Labelusername.Font = New Font("Montserrat Medium", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelusername.ForeColor = Color.Black
        Labelusername.Location = New Point(305, 209)
        Labelusername.Name = "Labelusername"
        Labelusername.Size = New Size(135, 30)
        Labelusername.TabIndex = 15
        Labelusername.Text = "Username"
        ' 
        ' txtboxusername
        ' 
        txtboxusername.Location = New Point(264, 277)
        txtboxusername.Name = "txtboxusername"
        txtboxusername.Size = New Size(241, 31)
        txtboxusername.TabIndex = 14
        ' 
        ' Labelwelcome
        ' 
        Labelwelcome.AutoSize = True
        Labelwelcome.BackColor = Color.Transparent
        Labelwelcome.Font = New Font("Montserrat", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelwelcome.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Labelwelcome.Location = New Point(172, 85)
        Labelwelcome.Name = "Labelwelcome"
        Labelwelcome.Size = New Size(399, 99)
        Labelwelcome.TabIndex = 13
        Labelwelcome.Text = "Welcome"
        ' 
        ' btnlogin
        ' 
        btnlogin.Font = New Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.Location = New Point(314, 481)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(112, 53)
        btnlogin.TabIndex = 12
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FloralWhite
        ClientSize = New Size(743, 618)
        Controls.Add(Labelpassword)
        Controls.Add(txtboxpassword)
        Controls.Add(Labelusername)
        Controls.Add(txtboxusername)
        Controls.Add(Labelwelcome)
        Controls.Add(btnlogin)
        Controls.Add(dolphin)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(dolphin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dolphin As PictureBox
    Friend WithEvents Labelpassword As Label
    Friend WithEvents txtboxpassword As TextBox
    Friend WithEvents Labelusername As Label
    Friend WithEvents txtboxusername As TextBox
    Friend WithEvents Labelwelcome As Label
    Friend WithEvents btnlogin As Button

End Class
