<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_harga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Date_Masuk = New System.Windows.Forms.DateTimePicker()
        Me.Date_Kadaluarsa = New System.Windows.Forms.DateTimePicker()
        Me.Txt_stock = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormJenisBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilihFormLainnyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormBarangMasuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_HapusBarang = New System.Windows.Forms.Button()
        Me.Btn_UpdateBarang = New System.Windows.Forms.Button()
        Me.Btn_TambahBarang = New System.Windows.Forms.Button()
        Me.DGV_Barang = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(17, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(17, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tanggal Masuk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(17, 217)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tanggal Kadaluarsa"
        '
        'Txt_harga
        '
        Me.Txt_harga.Location = New System.Drawing.Point(210, 121)
        Me.Txt_harga.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_harga.Name = "Txt_harga"
        Me.Txt_harga.Size = New System.Drawing.Size(311, 30)
        Me.Txt_harga.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(17, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Stock"
        '
        'Date_Masuk
        '
        Me.Date_Masuk.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Date_Masuk.Location = New System.Drawing.Point(210, 172)
        Me.Date_Masuk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Date_Masuk.Name = "Date_Masuk"
        Me.Date_Masuk.Size = New System.Drawing.Size(311, 30)
        Me.Date_Masuk.TabIndex = 14
        '
        'Date_Kadaluarsa
        '
        Me.Date_Kadaluarsa.Location = New System.Drawing.Point(210, 217)
        Me.Date_Kadaluarsa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Date_Kadaluarsa.Name = "Date_Kadaluarsa"
        Me.Date_Kadaluarsa.Size = New System.Drawing.Size(311, 30)
        Me.Date_Kadaluarsa.TabIndex = 15
        '
        'Txt_stock
        '
        Me.Txt_stock.Location = New System.Drawing.Point(210, 68)
        Me.Txt_stock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_stock.Name = "Txt_stock"
        Me.Txt_stock.Size = New System.Drawing.Size(311, 30)
        Me.Txt_stock.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Txt_harga)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Date_Masuk)
        Me.Panel1.Controls.Add(Me.Date_Kadaluarsa)
        Me.Panel1.Controls.Add(Me.Txt_NamaBarang)
        Me.Panel1.Controls.Add(Me.Txt_stock)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.Location = New System.Drawing.Point(45, 192)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 279)
        Me.Panel1.TabIndex = 40
        '
        'Txt_NamaBarang
        '
        Me.Txt_NamaBarang.Location = New System.Drawing.Point(210, 23)
        Me.Txt_NamaBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_NamaBarang.Name = "Txt_NamaBarang"
        Me.Txt_NamaBarang.Size = New System.Drawing.Size(311, 30)
        Me.Txt_NamaBarang.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(214, 160)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 34)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Form Barang"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(338, 40)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'TSMenu_FormPenjualan
        '
        Me.TSMenu_FormPenjualan.Name = "TSMenu_FormPenjualan"
        Me.TSMenu_FormPenjualan.Size = New System.Drawing.Size(338, 40)
        Me.TSMenu_FormPenjualan.Text = "Form Penjualan"
        '
        'TSMenu_FormJenisBarang
        '
        Me.TSMenu_FormJenisBarang.Name = "TSMenu_FormJenisBarang"
        Me.TSMenu_FormJenisBarang.Size = New System.Drawing.Size(338, 40)
        Me.TSMenu_FormJenisBarang.Text = "Form Jenis Barang"
        '
        'PilihFormLainnyaToolStripMenuItem
        '
        Me.PilihFormLainnyaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PilihFormLainnyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMenu_FormJenisBarang, Me.TSMenu_FormPenjualan, Me.TSMenu_FormBarangMasuk, Me.SignOutToolStripMenuItem})
        Me.PilihFormLainnyaToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PilihFormLainnyaToolStripMenuItem.Name = "PilihFormLainnyaToolStripMenuItem"
        Me.PilihFormLainnyaToolStripMenuItem.Size = New System.Drawing.Size(207, 28)
        Me.PilihFormLainnyaToolStripMenuItem.Text = "Pilih Menu Lainnya"
        '
        'TSMenu_FormBarangMasuk
        '
        Me.TSMenu_FormBarangMasuk.Name = "TSMenu_FormBarangMasuk"
        Me.TSMenu_FormBarangMasuk.Size = New System.Drawing.Size(338, 40)
        Me.TSMenu_FormBarangMasuk.Text = "Form Barang Masuk"
        '
        'Btn_HapusBarang
        '
        Me.Btn_HapusBarang.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_HapusBarang.FlatAppearance.BorderSize = 0
        Me.Btn_HapusBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_HapusBarang.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_HapusBarang.Location = New System.Drawing.Point(416, 486)
        Me.Btn_HapusBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_HapusBarang.Name = "Btn_HapusBarang"
        Me.Btn_HapusBarang.Size = New System.Drawing.Size(176, 50)
        Me.Btn_HapusBarang.TabIndex = 37
        Me.Btn_HapusBarang.Text = "Hapus"
        Me.Btn_HapusBarang.UseVisualStyleBackColor = False
        '
        'Btn_UpdateBarang
        '
        Me.Btn_UpdateBarang.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_UpdateBarang.FlatAppearance.BorderSize = 0
        Me.Btn_UpdateBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_UpdateBarang.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_UpdateBarang.Location = New System.Drawing.Point(232, 486)
        Me.Btn_UpdateBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_UpdateBarang.Name = "Btn_UpdateBarang"
        Me.Btn_UpdateBarang.Size = New System.Drawing.Size(176, 50)
        Me.Btn_UpdateBarang.TabIndex = 36
        Me.Btn_UpdateBarang.Text = "Update"
        Me.Btn_UpdateBarang.UseVisualStyleBackColor = False
        '
        'Btn_TambahBarang
        '
        Me.Btn_TambahBarang.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_TambahBarang.FlatAppearance.BorderSize = 0
        Me.Btn_TambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_TambahBarang.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_TambahBarang.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Btn_TambahBarang.Location = New System.Drawing.Point(48, 486)
        Me.Btn_TambahBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_TambahBarang.Name = "Btn_TambahBarang"
        Me.Btn_TambahBarang.Size = New System.Drawing.Size(176, 50)
        Me.Btn_TambahBarang.TabIndex = 35
        Me.Btn_TambahBarang.Text = "Tambah"
        Me.Btn_TambahBarang.UseVisualStyleBackColor = False
        '
        'DGV_Barang
        '
        Me.DGV_Barang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_Barang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Barang.Location = New System.Drawing.Point(665, 136)
        Me.DGV_Barang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGV_Barang.Name = "DGV_Barang"
        Me.DGV_Barang.RowHeadersWidth = 51
        Me.DGV_Barang.RowTemplate.Height = 29
        Me.DGV_Barang.Size = New System.Drawing.Size(997, 457)
        Me.DGV_Barang.TabIndex = 34
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihFormLainnyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1708, 33)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(1064, 81)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(223, 30)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Informasi Barang"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.sistem_keuangan_toko_uas.My.Resources.Resources._02june22_basket_icon_04_removebg_preview
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(867, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(273, 116)
        Me.Panel2.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.sistem_keuangan_toko_uas.My.Resources.Resources._02june22_basket_icon_04_removebg_preview
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(1212, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(273, 116)
        Me.Panel3.TabIndex = 42
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1708, 623)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btn_HapusBarang)
        Me.Controls.Add(Me.Btn_UpdateBarang)
        Me.Controls.Add(Me.Btn_TambahBarang)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV_Barang)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormBarang"
        Me.Text = "Barang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_harga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Date_Masuk As DateTimePicker
    Friend WithEvents Date_Kadaluarsa As DateTimePicker
    Friend WithEvents Txt_stock As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_NamaBarang As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMenu_FormPenjualan As ToolStripMenuItem
    Friend WithEvents TSMenu_FormJenisBarang As ToolStripMenuItem
    Friend WithEvents PilihFormLainnyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMenu_FormBarangMasuk As ToolStripMenuItem
    Friend WithEvents Btn_HapusBarang As Button
    Friend WithEvents Btn_UpdateBarang As Button
    Friend WithEvents Btn_TambahBarang As Button
    Friend WithEvents DGV_Barang As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
