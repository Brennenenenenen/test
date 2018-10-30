<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class chartform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chartform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnchartprint = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnforward = New System.Windows.Forms.Button()
        Me.dtpchart = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnchartprint)
        Me.Panel1.Controls.Add(Me.btnback)
        Me.Panel1.Controls.Add(Me.btnforward)
        Me.Panel1.Controls.Add(Me.dtpchart)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 691)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1295, 79)
        Me.Panel1.TabIndex = 0
        '
        'btnchartprint
        '
        Me.btnchartprint.BackColor = System.Drawing.Color.Transparent
        Me.btnchartprint.BackgroundImage = CType(resources.GetObject("btnchartprint.BackgroundImage"), System.Drawing.Image)
        Me.btnchartprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnchartprint.Location = New System.Drawing.Point(43, 11)
        Me.btnchartprint.Name = "btnchartprint"
        Me.btnchartprint.Size = New System.Drawing.Size(55, 55)
        Me.btnchartprint.TabIndex = 4
        Me.btnchartprint.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(359, 30)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 3
        Me.btnback.Text = "Button2"
        Me.btnback.UseVisualStyleBackColor = True
        Me.btnback.Visible = False
        '
        'btnforward
        '
        Me.btnforward.Location = New System.Drawing.Point(786, 27)
        Me.btnforward.Name = "btnforward"
        Me.btnforward.Size = New System.Drawing.Size(75, 23)
        Me.btnforward.TabIndex = 2
        Me.btnforward.Text = "Button1"
        Me.btnforward.UseVisualStyleBackColor = True
        Me.btnforward.Visible = False
        '
        'dtpchart
        '
        Me.dtpchart.Location = New System.Drawing.Point(527, 27)
        Me.dtpchart.Name = "dtpchart"
        Me.dtpchart.Size = New System.Drawing.Size(200, 22)
        Me.dtpchart.TabIndex = 1
        Me.dtpchart.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1295, 691)
        Me.Panel2.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1295, 691)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1287, 662)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Weekly DPU"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1287, 662)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Annual DPU"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1287, 662)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Daily DPU"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1061, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 44)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Descending"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(919, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 44)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Acending"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chartform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 770)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "chartform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "chartform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnback As Button
    Friend WithEvents btnforward As Button
    Friend WithEvents dtpchart As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnchartprint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
