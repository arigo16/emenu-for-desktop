<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingPassword
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtOldPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNewPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtRetype = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbShowPassword = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnChange = New DevComponents.DotNetBar.ButtonX()
        Me.btnBack = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(1336, 54)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Setting Password"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(386, 238)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(220, 33)
        Me.LabelX2.TabIndex = 5
        Me.LabelX2.Text = "Old Password"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(386, 277)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(220, 33)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "New Password"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(386, 316)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(220, 33)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Re-Type New Password"
        '
        'txtOldPassword
        '
        '
        '
        '
        Me.txtOldPassword.Border.Class = "TextBoxBorder"
        Me.txtOldPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtOldPassword.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPassword.Location = New System.Drawing.Point(612, 238)
        Me.txtOldPassword.MaxLength = 16
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Size = New System.Drawing.Size(334, 33)
        Me.txtOldPassword.TabIndex = 1
        Me.txtOldPassword.UseSystemPasswordChar = True
        '
        'txtNewPassword
        '
        '
        '
        '
        Me.txtNewPassword.Border.Class = "TextBoxBorder"
        Me.txtNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNewPassword.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(612, 277)
        Me.txtNewPassword.MaxLength = 16
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(334, 33)
        Me.txtNewPassword.TabIndex = 2
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'txtRetype
        '
        '
        '
        '
        Me.txtRetype.Border.Class = "TextBoxBorder"
        Me.txtRetype.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRetype.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetype.Location = New System.Drawing.Point(612, 316)
        Me.txtRetype.MaxLength = 16
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.Size = New System.Drawing.Size(334, 33)
        Me.txtRetype.TabIndex = 3
        Me.txtRetype.UseSystemPasswordChar = True
        '
        'cbShowPassword
        '
        '
        '
        '
        Me.cbShowPassword.BackgroundStyle.Class = ""
        Me.cbShowPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbShowPassword.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShowPassword.Location = New System.Drawing.Point(803, 355)
        Me.cbShowPassword.Name = "cbShowPassword"
        Me.cbShowPassword.Size = New System.Drawing.Size(143, 23)
        Me.cbShowPassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbShowPassword.TabIndex = 4
        Me.cbShowPassword.Text = "Show Password"
        '
        'btnChange
        '
        Me.btnChange.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChange.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChange.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(612, 384)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(99, 33)
        Me.btnChange.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnChange.TabIndex = 5
        Me.btnChange.Text = "&Change"
        '
        'btnBack
        '
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(847, 384)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 33)
        Me.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "&Back"
        '
        'frmSettingPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.cbShowPassword)
        Me.Controls.Add(Me.txtRetype)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtOldPassword)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettingPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Password"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtOldPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNewPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRetype As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbShowPassword As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnChange As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBack As DevComponents.DotNetBar.ButtonX
End Class
