<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarangMasuk
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Date_BarangMasuk = New System.Windows.Forms.DateTimePicker()
        Me.Txt_IdBarang = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_JmlBarangMasuk = New System.Windows.Forms.TextBox()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormPenjualanBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormJenisBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilihFormLainnyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_TambahBarangMasuk = New System.Windows.Forms.Button()
        Me.Btn_HapusBarangMasuk = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_UpdateBarangMasuk = New System.Windows.Forms.Button()
        Me.DGV_BarangMasuk = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_BarangMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.sistem_keuangan_toko_uas.My.Resources.Resources.WhatsApp_Image_2022_12_25_at_22_50_26_removebg_preview
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel2.Location = New System.Drawing.Point(789, 82)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 96)
        Me.Panel2.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(17, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ID Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(17, 145)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 21)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tanggal Barang Masuk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(17, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Jumlah Barang Masuk"
        '
        'Date_BarangMasuk
        '
        Me.Date_BarangMasuk.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Date_BarangMasuk.Location = New System.Drawing.Point(229, 142)
        Me.Date_BarangMasuk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Date_BarangMasuk.Name = "Date_BarangMasuk"
        Me.Date_BarangMasuk.Size = New System.Drawing.Size(311, 30)
        Me.Date_BarangMasuk.TabIndex = 14
        '
        'Txt_IdBarang
        '
        Me.Txt_IdBarang.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_IdBarang.Location = New System.Drawing.Point(229, 37)
        Me.Txt_IdBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_IdBarang.Name = "Txt_IdBarang"
        Me.Txt_IdBarang.Size = New System.Drawing.Size(311, 30)
        Me.Txt_IdBarang.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Date_BarangMasuk)
        Me.Panel1.Controls.Add(Me.Txt_IdBarang)
        Me.Panel1.Controls.Add(Me.Txt_JmlBarangMasuk)
        Me.Panel1.Location = New System.Drawing.Point(30, 227)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 192)
        Me.Panel1.TabIndex = 75
        '
        'Txt_JmlBarangMasuk
        '
        Me.Txt_JmlBarangMasuk.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_JmlBarangMasuk.Location = New System.Drawing.Point(229, 93)
        Me.Txt_JmlBarangMasuk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_JmlBarangMasuk.Name = "Txt_JmlBarangMasuk"
        Me.Txt_JmlBarangMasuk.Size = New System.Drawing.Size(311, 30)
        Me.Txt_JmlBarangMasuk.TabIndex = 8
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(288, 34)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'TSMenu_FormPenjualanBarang
        '
        Me.TSMenu_FormPenjualanBarang.Name = "TSMenu_FormPenjualanBarang"
        Me.TSMenu_FormPenjualanBarang.Size = New System.Drawing.Size(288, 34)
        Me.TSMenu_FormPenjualanBarang.Text = "Form  Penjualan"
        '
        'TSMenu_FormJenisBarang
        '
        Me.TSMenu_FormJenisBarang.Name = "TSMenu_FormJenisBarang"
        Me.TSMenu_FormJenisBarang.Size = New System.Drawing.Size(288, 34)
        Me.TSMenu_FormJenisBarang.Text = "Form Jenis Barang"
        '
        'PilihFormLainnyaToolStripMenuItem
        '
        Me.PilihFormLainnyaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PilihFormLainnyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMenu_FormBarang, Me.TSMenu_FormJenisBarang, Me.TSMenu_FormPenjualanBarang, Me.SignOutToolStripMenuItem})
        Me.PilihFormLainnyaToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PilihFormLainnyaToolStripMenuItem.Name = "PilihFormLainnyaToolStripMenuItem"
        Me.PilihFormLainnyaToolStripMenuItem.Size = New System.Drawing.Size(207, 28)
        Me.PilihFormLainnyaToolStripMenuItem.Text = "Pilih Menu Lainnya"
        '
        'TSMenu_FormBarang
        '
        Me.TSMenu_FormBarang.Name = "TSMenu_FormBarang"
        Me.TSMenu_FormBarang.Size = New System.Drawing.Size(288, 34)
        Me.TSMenu_FormBarang.Text = "Form Barang"
        '
        'Btn_TambahBarangMasuk
        '
        Me.Btn_TambahBarangMasuk.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_TambahBarangMasuk.FlatAppearance.BorderSize = 0
        Me.Btn_TambahBarangMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_TambahBarangMasuk.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_TambahBarangMasuk.Location = New System.Drawing.Point(39, 483)
        Me.Btn_TambahBarangMasuk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_TambahBarangMasuk.Name = "Btn_TambahBarangMasuk"
        Me.Btn_TambahBarangMasuk.Size = New System.Drawing.Size(176, 50)
        Me.Btn_TambahBarangMasuk.TabIndex = 69
        Me.Btn_TambahBarangMasuk.Text = "Tambah"
        Me.Btn_TambahBarangMasuk.UseVisualStyleBackColor = False
        '
        'Btn_HapusBarangMasuk
        '
        Me.Btn_HapusBarangMasuk.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_HapusBarangMasuk.FlatAppearance.BorderSize = 0
        Me.Btn_HapusBarangMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_HapusBarangMasuk.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_HapusBarangMasuk.Location = New System.Drawing.Point(407, 483)
        Me.Btn_HapusBarangMasuk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_HapusBarangMasuk.Name = "Btn_HapusBarangMasuk"
        Me.Btn_HapusBarangMasuk.Size = New System.Drawing.Size(176, 50)
        Me.Btn_HapusBarangMasuk.TabIndex = 71
        Me.Btn_HapusBarangMasuk.Text = "Hapus"
        Me.Btn_HapusBarangMasuk.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(46, 434)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 21)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "ID Barang yang terpilih :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(969, 111)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(313, 36)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Informasi Barang Masuk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(171, 197)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(282, 38)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Form Barang Masuk"
        '
        'Btn_UpdateBarangMasuk
        '
        Me.Btn_UpdateBarangMasuk.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_UpdateBarangMasuk.FlatAppearance.BorderSize = 0
        Me.Btn_UpdateBarangMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_UpdateBarangMasuk.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_UpdateBarangMasuk.Location = New System.Drawing.Point(223, 483)
        Me.Btn_UpdateBarangMasuk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_UpdateBarangMasuk.Name = "Btn_UpdateBarangMasuk"
        Me.Btn_UpdateBarangMasuk.Size = New System.Drawing.Size(176, 50)
        Me.Btn_UpdateBarangMasuk.TabIndex = 70
        Me.Btn_UpdateBarangMasuk.Text = "Update"
        Me.Btn_UpdateBarangMasuk.UseVisualStyleBackColor = False
        '
        'DGV_BarangMasuk
        '
        Me.DGV_BarangMasuk.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_BarangMasuk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_BarangMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_BarangMasuk.Location = New System.Drawing.Point(622, 183)
        Me.DGV_BarangMasuk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGV_BarangMasuk.Name = "DGV_BarangMasuk"
        Me.DGV_BarangMasuk.RowHeadersWidth = 51
        Me.DGV_BarangMasuk.RowTemplate.Height = 29
        Me.DGV_BarangMasuk.Size = New System.Drawing.Size(994, 408)
        Me.DGV_BarangMasuk.TabIndex = 68
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihFormLainnyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1659, 33)
        Me.MenuStrip1.TabIndex = 74
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(262, 434)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Label 1"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.sistem_keuangan_toko_uas.My.Resources.Resources.WhatsApp_Image_2022_12_25_at_22_50_26_removebg_preview
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel3.Location = New System.Drawing.Point(1197, 81)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 96)
        Me.Panel3.TabIndex = 79
        '
        'FormBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1659, 633)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_TambahBarangMasuk)
        Me.Controls.Add(Me.Btn_HapusBarangMasuk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_UpdateBarangMasuk)
        Me.Controls.Add(Me.DGV_BarangMasuk)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormBarangMasuk"
        Me.Text = "Barang Masuk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_BarangMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Date_BarangMasuk As DateTimePicker
    Friend WithEvents Txt_IdBarang As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_JmlBarangMasuk As TextBox
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMenu_FormPenjualanBarang As ToolStripMenuItem
    Friend WithEvents TSMenu_FormJenisBarang As ToolStripMenuItem
    Friend WithEvents PilihFormLainnyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMenu_FormBarang As ToolStripMenuItem
    Friend WithEvents Btn_TambahBarangMasuk As Button
    Friend WithEvents Btn_HapusBarangMasuk As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_UpdateBarangMasuk As Button
    Friend WithEvents DGV_BarangMasuk As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
End Class
