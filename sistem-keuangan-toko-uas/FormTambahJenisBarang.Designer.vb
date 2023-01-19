<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahJenisBarang
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
        Me.TxtTambahJenisBarang = New System.Windows.Forms.TextBox()
        Me.BtnTambahJenisBarang = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.ToolStrip1.Location = New System.Drawing.Point(24, 21)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(127, 31)
        Me.ToolStrip1.TabIndex = 82
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
        'TxtTambahJenisBarang
        '
        Me.TxtTambahJenisBarang.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTambahJenisBarang.Location = New System.Drawing.Point(130, 166)
        Me.TxtTambahJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtTambahJenisBarang.Name = "TxtTambahJenisBarang"
        Me.TxtTambahJenisBarang.Size = New System.Drawing.Size(354, 32)
        Me.TxtTambahJenisBarang.TabIndex = 81
        '
        'BtnTambahJenisBarang
        '
        Me.BtnTambahJenisBarang.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnTambahJenisBarang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTambahJenisBarang.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahJenisBarang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTambahJenisBarang.Location = New System.Drawing.Point(202, 237)
        Me.BtnTambahJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnTambahJenisBarang.Name = "BtnTambahJenisBarang"
        Me.BtnTambahJenisBarang.Size = New System.Drawing.Size(123, 38)
        Me.BtnTambahJenisBarang.TabIndex = 80
        Me.BtnTambahJenisBarang.Text = "Tambah"
        Me.BtnTambahJenisBarang.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(50, 169)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(104, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 38)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Tambah Jenis Barang"
        '
        'FormTambahJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(563, 309)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TxtTambahJenisBarang)
        Me.Controls.Add(Me.BtnTambahJenisBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTambahJenisBarang"
        Me.Text = "FormTambahJenisBarang"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TxtTambahJenisBarang As TextBox
    Friend WithEvents BtnTambahJenisBarang As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
