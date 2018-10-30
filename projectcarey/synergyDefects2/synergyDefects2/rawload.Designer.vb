<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rawload
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpRawdata = New System.Windows.Forms.DateTimePicker()
        Me.btnrawForward = New System.Windows.Forms.Button()
        Me.btnrawback = New System.Windows.Forms.Button()
        Me.dgvcarey = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvcarey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpRawdata)
        Me.Panel1.Controls.Add(Me.btnrawForward)
        Me.Panel1.Controls.Add(Me.btnrawback)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 448)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1179, 100)
        Me.Panel1.TabIndex = 0
        '
        'dtpRawdata
        '
        Me.dtpRawdata.Location = New System.Drawing.Point(499, 34)
        Me.dtpRawdata.Name = "dtpRawdata"
        Me.dtpRawdata.Size = New System.Drawing.Size(200, 22)
        Me.dtpRawdata.TabIndex = 2
        '
        'btnrawForward
        '
        Me.btnrawForward.Location = New System.Drawing.Point(733, 33)
        Me.btnrawForward.Name = "btnrawForward"
        Me.btnrawForward.Size = New System.Drawing.Size(75, 23)
        Me.btnrawForward.TabIndex = 1
        Me.btnrawForward.Text = ">>"
        Me.btnrawForward.UseVisualStyleBackColor = True
        '
        'btnrawback
        '
        Me.btnrawback.Location = New System.Drawing.Point(371, 33)
        Me.btnrawback.Name = "btnrawback"
        Me.btnrawback.Size = New System.Drawing.Size(75, 23)
        Me.btnrawback.TabIndex = 0
        Me.btnrawback.Text = "<<"
        Me.btnrawback.UseVisualStyleBackColor = True
        '
        'dgvcarey
        '
        Me.dgvcarey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcarey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcarey.Location = New System.Drawing.Point(0, 0)
        Me.dgvcarey.Name = "dgvcarey"
        Me.dgvcarey.RowTemplate.Height = 24
        Me.dgvcarey.Size = New System.Drawing.Size(1179, 448)
        Me.dgvcarey.TabIndex = 1
        '
        'rawload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 548)
        Me.Controls.Add(Me.dgvcarey)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "rawload"
        Me.Text = "rawload"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvcarey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpRawdata As DateTimePicker
    Friend WithEvents btnrawForward As Button
    Friend WithEvents btnrawback As Button
    Friend WithEvents dgvcarey As DataGridView
End Class
