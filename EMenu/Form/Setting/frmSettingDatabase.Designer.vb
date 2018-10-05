<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingDatabase
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
        Me.txtBackup = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtRestore = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnBackup = New DevComponents.DotNetBar.ButtonX()
        Me.btnRestore = New DevComponents.DotNetBar.ButtonX()
        Me.btnChooseBackup = New DevComponents.DotNetBar.ButtonX()
        Me.btnChooseRestore = New DevComponents.DotNetBar.ButtonX()
        Me.btnBack = New DevComponents.DotNetBar.ButtonX()
        Me.ChooseRestore = New System.Windows.Forms.OpenFileDialog()
        Me.ChooseBackup = New System.Windows.Forms.FolderBrowserDialog()
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
        Me.LabelX1.Text = "Setting Database"
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
        Me.LabelX2.Location = New System.Drawing.Point(509, 231)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(220, 33)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Choose Folder Backup"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(509, 309)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(220, 33)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "Choose File Restore"
        '
        'txtBackup
        '
        '
        '
        '
        Me.txtBackup.Border.Class = "TextBoxBorder"
        Me.txtBackup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBackup.Enabled = False
        Me.txtBackup.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackup.Location = New System.Drawing.Point(509, 270)
        Me.txtBackup.MaxLength = 16
        Me.txtBackup.Name = "txtBackup"
        Me.txtBackup.Size = New System.Drawing.Size(334, 33)
        Me.txtBackup.TabIndex = 8
        '
        'txtRestore
        '
        '
        '
        '
        Me.txtRestore.Border.Class = "TextBoxBorder"
        Me.txtRestore.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRestore.Enabled = False
        Me.txtRestore.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestore.Location = New System.Drawing.Point(509, 348)
        Me.txtRestore.MaxLength = 16
        Me.txtRestore.Name = "txtRestore"
        Me.txtRestore.Size = New System.Drawing.Size(334, 33)
        Me.txtRestore.TabIndex = 9
        '
        'btnBackup
        '
        Me.btnBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Location = New System.Drawing.Point(731, 231)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(112, 33)
        Me.btnBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBackup.TabIndex = 2
        Me.btnBackup.Text = "&Backup"
        '
        'btnRestore
        '
        Me.btnRestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRestore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestore.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.Location = New System.Drawing.Point(731, 309)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(112, 33)
        Me.btnRestore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRestore.TabIndex = 4
        Me.btnRestore.Text = "&Restore"
        '
        'btnChooseBackup
        '
        Me.btnChooseBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChooseBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChooseBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseBackup.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseBackup.Location = New System.Drawing.Point(786, 270)
        Me.btnChooseBackup.Name = "btnChooseBackup"
        Me.btnChooseBackup.Size = New System.Drawing.Size(57, 33)
        Me.btnChooseBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnChooseBackup.TabIndex = 1
        Me.btnChooseBackup.Text = "..."
        '
        'btnChooseRestore
        '
        Me.btnChooseRestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChooseRestore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChooseRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseRestore.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseRestore.Location = New System.Drawing.Point(786, 348)
        Me.btnChooseRestore.Name = "btnChooseRestore"
        Me.btnChooseRestore.Size = New System.Drawing.Size(57, 33)
        Me.btnChooseRestore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnChooseRestore.TabIndex = 3
        Me.btnChooseRestore.Text = "..."
        '
        'btnBack
        '
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(509, 387)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(334, 33)
        Me.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "&Back"
        '
        'ChooseRestore
        '
        Me.ChooseRestore.DefaultExt = "sql"
        Me.ChooseRestore.Filter = "SQL Files (SQL)|*.SQL"
        '
        'frmSettingDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnChooseRestore)
        Me.Controls.Add(Me.btnChooseBackup)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.txtRestore)
        Me.Controls.Add(Me.txtBackup)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettingDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Database"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBackup As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRestore As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnBackup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRestore As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnChooseBackup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnChooseRestore As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBack As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ChooseRestore As OpenFileDialog
    Friend WithEvents ChooseBackup As FolderBrowserDialog
End Class
