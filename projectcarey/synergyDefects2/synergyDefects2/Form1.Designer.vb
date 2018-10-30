<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersForm))
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCrystal = New System.Windows.Forms.Button()
        Me.btnNB = New System.Windows.Forms.Button()
        Me.btnCarrie = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCustomers
        '
        Me.lblCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Arial Narrow", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(428, 122)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(209, 52)
        Me.lblCustomers.TabIndex = 4
        Me.lblCustomers.Text = "Customers"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1064, 57)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "History"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Admin"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "Hotmap"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.synergyDefects2.My.Resources.Resources.csp_logo1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Image = Global.synergyDefects2.My.Resources.Resources.csp_logo1
        Me.Button1.Location = New System.Drawing.Point(499, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(448, 198)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.synergyDefects2.My.Resources.Resources.synergy
        Me.PictureBox1.Location = New System.Drawing.Point(416, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnCrystal
        '
        Me.btnCrystal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCrystal.BackgroundImage = Global.synergyDefects2.My.Resources.Resources.crystal
        Me.btnCrystal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrystal.Enabled = False
        Me.btnCrystal.Location = New System.Drawing.Point(27, 214)
        Me.btnCrystal.Name = "btnCrystal"
        Me.btnCrystal.Size = New System.Drawing.Size(448, 198)
        Me.btnCrystal.TabIndex = 9
        Me.btnCrystal.UseVisualStyleBackColor = True
        Me.btnCrystal.Visible = False
        '
        'btnNB
        '
        Me.btnNB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNB.BackgroundImage = Global.synergyDefects2.My.Resources.Resources.cspnb
        Me.btnNB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNB.Enabled = False
        Me.btnNB.Location = New System.Drawing.Point(518, 438)
        Me.btnNB.Name = "btnNB"
        Me.btnNB.Size = New System.Drawing.Size(448, 198)
        Me.btnNB.TabIndex = 6
        Me.btnNB.Text = " "
        Me.btnNB.UseVisualStyleBackColor = True
        Me.btnNB.Visible = False
        '
        'btnCarrie
        '
        Me.btnCarrie.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCarrie.BackgroundImage = Global.synergyDefects2.My.Resources.Resources.cspcarey
        Me.btnCarrie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCarrie.Location = New System.Drawing.Point(27, 438)
        Me.btnCarrie.Name = "btnCarrie"
        Me.btnCarrie.Size = New System.Drawing.Size(448, 198)
        Me.btnCarrie.TabIndex = 5
        Me.btnCarrie.UseVisualStyleBackColor = True
        '
        'CustomersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1064, 648)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnCrystal)
        Me.Controls.Add(Me.btnNB)
        Me.Controls.Add(Me.btnCarrie)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "CustomersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNB As Button
    Friend WithEvents lblCustomers As Label
    Friend WithEvents btnCrystal As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCarrie As Button
End Class
