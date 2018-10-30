<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adminform))
        Me.combNames = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSaveChange = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCurrentDefect = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.lblRemove = New System.Windows.Forms.Label()
        Me.combRemovename = New System.Windows.Forms.ComboBox()
        Me.btnsaveremove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'combNames
        '
        Me.combNames.FormattingEnabled = True
        Me.combNames.Location = New System.Drawing.Point(259, 139)
        Me.combNames.Name = "combNames"
        Me.combNames.Size = New System.Drawing.Size(121, 24)
        Me.combNames.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(259, 185)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 22)
        Me.TextBox1.TabIndex = 5
        '
        'btnSaveChange
        '
        Me.btnSaveChange.Location = New System.Drawing.Point(270, 242)
        Me.btnSaveChange.Name = "btnSaveChange"
        Me.btnSaveChange.Size = New System.Drawing.Size(100, 50)
        Me.btnSaveChange.TabIndex = 7
        Me.btnSaveChange.Text = "Save"
        Me.btnSaveChange.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(111, 185)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(121, 17)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "New Defect Name"
        '
        'lblCurrentDefect
        '
        Me.lblCurrentDefect.AutoSize = True
        Me.lblCurrentDefect.Location = New System.Drawing.Point(111, 139)
        Me.lblCurrentDefect.Name = "lblCurrentDefect"
        Me.lblCurrentDefect.Size = New System.Drawing.Size(141, 17)
        Me.lblCurrentDefect.TabIndex = 9
        Me.lblCurrentDefect.Text = "Current Defect Name"
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.Location = New System.Drawing.Point(256, 75)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(102, 17)
        Me.lblchange.TabIndex = 10
        Me.lblchange.Text = "Change Defect"
        '
        'lblRemove
        '
        Me.lblRemove.AutoSize = True
        Me.lblRemove.Location = New System.Drawing.Point(448, 75)
        Me.lblRemove.Name = "lblRemove"
        Me.lblRemove.Size = New System.Drawing.Size(105, 17)
        Me.lblRemove.TabIndex = 11
        Me.lblRemove.Text = "Remove Defect"
        '
        'combRemovename
        '
        Me.combRemovename.FormattingEnabled = True
        Me.combRemovename.Location = New System.Drawing.Point(440, 139)
        Me.combRemovename.Name = "combRemovename"
        Me.combRemovename.Size = New System.Drawing.Size(121, 24)
        Me.combRemovename.TabIndex = 12
        '
        'btnsaveremove
        '
        Me.btnsaveremove.Location = New System.Drawing.Point(450, 242)
        Me.btnsaveremove.Name = "btnsaveremove"
        Me.btnsaveremove.Size = New System.Drawing.Size(100, 50)
        Me.btnsaveremove.TabIndex = 13
        Me.btnsaveremove.Text = "Save"
        Me.btnsaveremove.UseVisualStyleBackColor = True
        '
        'Adminform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 610)
        Me.Controls.Add(Me.btnsaveremove)
        Me.Controls.Add(Me.combRemovename)
        Me.Controls.Add(Me.lblRemove)
        Me.Controls.Add(Me.lblchange)
        Me.Controls.Add(Me.lblCurrentDefect)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSaveChange)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.combNames)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Adminform"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents combNames As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSaveChange As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblCurrentDefect As Label
    Friend WithEvents lblchange As Label
    Friend WithEvents lblRemove As Label
    Friend WithEvents combRemovename As ComboBox
    Friend WithEvents btnsaveremove As Button
End Class
