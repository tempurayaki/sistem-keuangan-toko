<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateJenisBarang
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BtnUpdateJenisBarang = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUpdateJenisBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(28, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(127, 31)
        Me.ToolStrip1.TabIndex = 83
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripButton1.Image = Global.sistem_keuangan_toko_uas.My.Resources.Resources.previous
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(109, 26)
        Me.ToolStripButton1.Text = "  Kembali"
        '
        'BtnUpdateJenisBarang
        '
        Me.BtnUpdateJenisBarang.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnUpdateJenisBarang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnUpdateJenisBarang.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdateJenisBarang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnUpdateJenisBarang.Location = New System.Drawing.Point(229, 227)
        Me.BtnUpdateJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUpdateJenisBarang.Name = "BtnUpdateJenisBarang"
        Me.BtnUpdateJenisBarang.Size = New System.Drawing.Size(123, 38)
        Me.BtnUpdateJenisBarang.TabIndex = 82
        Me.BtnUpdateJenisBarang.Text = "Update"
        Me.BtnUpdateJenisBarang.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(50, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Nama"
        '
        'TxtUpdateJenisBarang
        '
        Me.TxtUpdateJenisBarang.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtUpdateJenisBarang.Location = New System.Drawing.Point(126, 164)
        Me.TxtUpdateJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUpdateJenisBarang.Name = "TxtUpdateJenisBarang"
        Me.TxtUpdateJenisBarang.Size = New System.Drawing.Size(390, 32)
        Me.TxtUpdateJenisBarang.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(119, 99)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 38)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Update Jenis Barang"
        '
        'FormUpdateJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(595, 303)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BtnUpdateJenisBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtUpdateJenisBarang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUpdateJenisBarang"
        Me.Text = "FormUpdateJenisBarang"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BtnUpdateJenisBarang As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtUpdateJenisBarang As TextBox
    Friend WithEvents Label1 As Label
End Class
