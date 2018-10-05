<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.SMLogin = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.btnLogin = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUsername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.errorUsername = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorPassword = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SMLogin
        '
        Me.SMLogin.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.SMLogin.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'btnLogin
        '
        Me.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(155, 119)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 30)
        Me.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "&Login"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(252, 119)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 30)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPassword.Location = New System.Drawing.Point(155, 85)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(172, 26)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "160297"
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.WatermarkText = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtUsername.Border.Class = "TextBoxBorder"
        Me.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsername.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsername.Location = New System.Drawing.Point(155, 53)
        Me.txtUsername.MaxLength = 8
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(172, 26)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Text = "fitri"
        Me.txtUsername.WatermarkText = "Username"
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.Class = ""
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(155, 12)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(172, 35)
        Me.ReflectionLabel1.TabIndex = 5
        Me.ReflectionLabel1.Text = "<b><font color=""red"" size=""12"">Login</font> </b><b><font color=""black"" size=""12"">" &
    "Your Account</font></b>"
        '
        'errorUsername
        '
        Me.errorUsername.ContainerControl = Me
        '
        'errorPassword
        '
        Me.errorPassword.ContainerControl = Me
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(352, 162)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SMLogin As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btnLogin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUsername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents errorUsername As ErrorProvider
    Friend WithEvents errorPassword As ErrorProvider
End Class
