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
        whale = New PictureBox()
        CType(dolphin, ComponentModel.ISupportInitialize).BeginInit()
        CType(whale, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dolphin
        ' 
        dolphin.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(243))
        dolphin.Image = CType(resources.GetObject("dolphin.Image"), Image)
        dolphin.Location = New Point(245, 370)
        dolphin.Name = "dolphin"
        dolphin.Size = New Size(699, 324)
        dolphin.SizeMode = PictureBoxSizeMode.StretchImage
        dolphin.TabIndex = 0
        dolphin.TabStop = False
        ' 
        ' Labelpassword
        ' 
        Labelpassword.AutoSize = True
        Labelpassword.BackColor = Color.Transparent
        Labelpassword.Font = New Font("Montserrat Medium", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelpassword.ForeColor = Color.FromArgb(CByte(101), CByte(98), CByte(86))
        Labelpassword.Location = New Point(305, 337)
        Labelpassword.Name = "Labelpassword"
        Labelpassword.Size = New Size(130, 30)
        Labelpassword.TabIndex = 17
        Labelpassword.Text = "Password"
        ' 
        ' txtboxpassword
        ' 
        txtboxpassword.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtboxpassword.Location = New Point(276, 405)
        txtboxpassword.Name = "txtboxpassword"
        txtboxpassword.Size = New Size(217, 32)
        txtboxpassword.TabIndex = 16
        ' 
        ' Labelusername
        ' 
        Labelusername.AutoSize = True
        Labelusername.BackColor = Color.Transparent
        Labelusername.Font = New Font("Montserrat Medium", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelusername.ForeColor = Color.FromArgb(CByte(101), CByte(98), CByte(86))
        Labelusername.Location = New Point(305, 209)
        Labelusername.Name = "Labelusername"
        Labelusername.Size = New Size(135, 30)
        Labelusername.TabIndex = 15
        Labelusername.Text = "Username"
        ' 
        ' txtboxusername
        ' 
        txtboxusername.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtboxusername.Location = New Point(264, 277)
        txtboxusername.Name = "txtboxusername"
        txtboxusername.Size = New Size(229, 32)
        txtboxusername.TabIndex = 14
        ' 
        ' Labelwelcome
        ' 
        Labelwelcome.AutoSize = True
        Labelwelcome.BackColor = Color.Transparent
        Labelwelcome.Font = New Font("Montserrat", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelwelcome.ForeColor = Color.FromArgb(CByte(35), CByte(9), CByte(3))
        Labelwelcome.Location = New Point(172, 85)
        Labelwelcome.Name = "Labelwelcome"
        Labelwelcome.Size = New Size(399, 99)
        Labelwelcome.TabIndex = 13
        Labelwelcome.Text = "Welcome"
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.White
        btnlogin.FlatStyle = FlatStyle.Popup
        btnlogin.Font = New Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.ForeColor = Color.FromArgb(CByte(35), CByte(9), CByte(3))
        btnlogin.Location = New Point(314, 481)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(112, 53)
        btnlogin.TabIndex = 12
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' whale
        ' 
        whale.Image = CType(resources.GetObject("whale.Image"), Image)
        whale.Location = New Point(-391, -114)
        whale.Name = "whale"
        whale.Size = New Size(942, 423)
        whale.SizeMode = PictureBoxSizeMode.Zoom
        whale.TabIndex = 18
        whale.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(243))
        ClientSize = New Size(743, 618)
        Controls.Add(whale)
        Controls.Add(Labelpassword)
        Controls.Add(txtboxpassword)
        Controls.Add(Labelusername)
        Controls.Add(txtboxusername)
        Controls.Add(Labelwelcome)
        Controls.Add(btnlogin)
        Controls.Add(dolphin)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(dolphin, ComponentModel.ISupportInitialize).EndInit()
        CType(whale, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents whale As PictureBox

End Class
