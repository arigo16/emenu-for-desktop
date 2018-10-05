<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingWallpaper
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
        Me.SampleWallpaper = New System.Windows.Forms.PictureBox()
        Me.txtWallpaper = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ChooseWallpaper = New System.Windows.Forms.OpenFileDialog()
        Me.btnChooseWallpaper = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.btnBack = New DevComponents.DotNetBar.ButtonX()
        CType(Me.SampleWallpaper, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelX1.Text = "Setting Wallpaper"
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
        Me.LabelX2.Location = New System.Drawing.Point(175, 80)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(124, 33)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Pilih Gambar"
        '
        'SampleWallpaper
        '
        Me.SampleWallpaper.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.SampleWallpaper.Location = New System.Drawing.Point(175, 134)
        Me.SampleWallpaper.Name = "SampleWallpaper"
        Me.SampleWallpaper.Size = New System.Drawing.Size(1024, 439)
        Me.SampleWallpaper.TabIndex = 5
        Me.SampleWallpaper.TabStop = False
        '
        'txtWallpaper
        '
        '
        '
        '
        Me.txtWallpaper.Border.Class = "TextBoxBorder"
        Me.txtWallpaper.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtWallpaper.Enabled = False
        Me.txtWallpaper.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWallpaper.Location = New System.Drawing.Point(305, 80)
        Me.txtWallpaper.Name = "txtWallpaper"
        Me.txtWallpaper.Size = New System.Drawing.Size(556, 33)
        Me.txtWallpaper.TabIndex = 6
        '
        'ChooseWallpaper
        '
        Me.ChooseWallpaper.DefaultExt = "jpg,jpeg"
        Me.ChooseWallpaper.Filter = "Image Files (JPG,JPEG)|*.JPG;*.JPEG"
        '
        'btnChooseWallpaper
        '
        Me.btnChooseWallpaper.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChooseWallpaper.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChooseWallpaper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseWallpaper.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseWallpaper.Location = New System.Drawing.Point(804, 80)
        Me.btnChooseWallpaper.Name = "btnChooseWallpaper"
        Me.btnChooseWallpaper.Size = New System.Drawing.Size(57, 33)
        Me.btnChooseWallpaper.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnChooseWallpaper.TabIndex = 1
        Me.btnChooseWallpaper.Text = "..."
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(867, 80)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 33)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(1043, 80)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(156, 33)
        Me.LabelX3.TabIndex = 9
        Me.LabelX3.Text = "Ratio 1366 * 585"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnBack
        '
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(951, 80)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(78, 33)
        Me.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "&Back"
        '
        'frmSettingWallpaper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnChooseWallpaper)
        Me.Controls.Add(Me.txtWallpaper)
        Me.Controls.Add(Me.SampleWallpaper)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettingWallpaper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Wallpaper"
        CType(Me.SampleWallpaper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SampleWallpaper As PictureBox
    Friend WithEvents txtWallpaper As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ChooseWallpaper As OpenFileDialog
    Friend WithEvents btnChooseWallpaper As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnBack As DevComponents.DotNetBar.ButtonX
End Class
