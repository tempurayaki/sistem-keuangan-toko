<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahPenjualan
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CB_namabarang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Date_Jual = New System.Windows.Forms.DateTimePicker()
        Me.Txt_JumlahBarang = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Tambah = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(192, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(267, 34)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Tambah Penjualan"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CB_namabarang)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Date_Jual)
        Me.Panel1.Controls.Add(Me.Txt_JumlahBarang)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.Location = New System.Drawing.Point(36, 127)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 182)
        Me.Panel1.TabIndex = 78
        '
        'CB_namabarang
        '
        Me.CB_namabarang.FormattingEnabled = True
        Me.CB_namabarang.Location = New System.Drawing.Point(210, 15)
        Me.CB_namabarang.Name = "CB_namabarang"
        Me.CB_namabarang.Size = New System.Drawing.Size(311, 29)
        Me.CB_namabarang.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 21)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tanggal Jual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Jumlah Barang"
        '
        'Date_Jual
        '
        Me.Date_Jual.Location = New System.Drawing.Point(210, 124)
        Me.Date_Jual.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Date_Jual.Name = "Date_Jual"
        Me.Date_Jual.Size = New System.Drawing.Size(311, 30)
        Me.Date_Jual.TabIndex = 14
        '
        'Txt_JumlahBarang
        '
        Me.Txt_JumlahBarang.Location = New System.Drawing.Point(210, 72)
        Me.Txt_JumlahBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_JumlahBarang.Name = "Txt_JumlahBarang"
        Me.Txt_JumlahBarang.Size = New System.Drawing.Size(311, 30)
        Me.Txt_JumlahBarang.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 23)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(127, 31)
        Me.ToolStrip1.TabIndex = 80
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
        'Btn_Tambah
        '
        Me.Btn_Tambah.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Tambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Tambah.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Tambah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Tambah.Location = New System.Drawing.Point(226, 338)
        Me.Btn_Tambah.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Tambah.Name = "Btn_Tambah"
        Me.Btn_Tambah.Size = New System.Drawing.Size(176, 50)
        Me.Btn_Tambah.TabIndex = 79
        Me.Btn_Tambah.Text = "Tambah"
        Me.Btn_Tambah.UseVisualStyleBackColor = False
        '
        'FormTambahPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(635, 417)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Btn_Tambah)
        Me.Name = "FormTambahPenjualan"
        Me.Text = "FormTambahPenjualan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CB_namabarang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Date_Jual As DateTimePicker
    Friend WithEvents Txt_JumlahBarang As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Btn_Tambah As Button
End Class
