<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Date_Jual = New System.Windows.Forms.DateTimePicker()
        Me.Txt_ID_Barang = New System.Windows.Forms.TextBox()
        Me.Txt_JumlahBarang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_HapusPenjualan = New System.Windows.Forms.Button()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_TambahPenjualan = New System.Windows.Forms.Button()
        Me.DGV_Penjualan = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TSMenu_FormBarangMasuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormJenisBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilihFormLainnyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_UpdatePenjualan = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.DGV_Penjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ID Barang"
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
        'Txt_ID_Barang
        '
        Me.Txt_ID_Barang.Location = New System.Drawing.Point(210, 16)
        Me.Txt_ID_Barang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_ID_Barang.Name = "Txt_ID_Barang"
        Me.Txt_ID_Barang.Size = New System.Drawing.Size(311, 30)
        Me.Txt_ID_Barang.TabIndex = 7
        '
        'Txt_JumlahBarang
        '
        Me.Txt_JumlahBarang.Location = New System.Drawing.Point(210, 72)
        Me.Txt_JumlahBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_JumlahBarang.Name = "Txt_JumlahBarang"
        Me.Txt_JumlahBarang.Size = New System.Drawing.Size(311, 30)
        Me.Txt_JumlahBarang.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(475, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 34)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Form Penjualan"
        '
        'Btn_HapusPenjualan
        '
        Me.Btn_HapusPenjualan.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Btn_HapusPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_HapusPenjualan.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_HapusPenjualan.Location = New System.Drawing.Point(757, 221)
        Me.Btn_HapusPenjualan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_HapusPenjualan.Name = "Btn_HapusPenjualan"
        Me.Btn_HapusPenjualan.Size = New System.Drawing.Size(176, 50)
        Me.Btn_HapusPenjualan.TabIndex = 68
        Me.Btn_HapusPenjualan.Text = "Hapus"
        Me.Btn_HapusPenjualan.UseVisualStyleBackColor = False
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(303, 34)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'Btn_TambahPenjualan
        '
        Me.Btn_TambahPenjualan.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Btn_TambahPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_TambahPenjualan.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_TambahPenjualan.Location = New System.Drawing.Point(757, 113)
        Me.Btn_TambahPenjualan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_TambahPenjualan.Name = "Btn_TambahPenjualan"
        Me.Btn_TambahPenjualan.Size = New System.Drawing.Size(176, 50)
        Me.Btn_TambahPenjualan.TabIndex = 66
        Me.Btn_TambahPenjualan.Text = "Tambah"
        Me.Btn_TambahPenjualan.UseVisualStyleBackColor = False
        '
        'DGV_Penjualan
        '
        Me.DGV_Penjualan.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.DGV_Penjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Penjualan.Location = New System.Drawing.Point(64, 394)
        Me.DGV_Penjualan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGV_Penjualan.Name = "DGV_Penjualan"
        Me.DGV_Penjualan.RowHeadersWidth = 51
        Me.DGV_Penjualan.RowTemplate.Height = 29
        Me.DGV_Penjualan.Size = New System.Drawing.Size(1033, 379)
        Me.DGV_Penjualan.TabIndex = 65
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Date_Jual)
        Me.Panel1.Controls.Add(Me.Txt_ID_Barang)
        Me.Panel1.Controls.Add(Me.Txt_JumlahBarang)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.Location = New System.Drawing.Point(178, 106)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 182)
        Me.Panel1.TabIndex = 71
        '
        'TSMenu_FormBarangMasuk
        '
        Me.TSMenu_FormBarangMasuk.Name = "TSMenu_FormBarangMasuk"
        Me.TSMenu_FormBarangMasuk.Size = New System.Drawing.Size(303, 34)
        Me.TSMenu_FormBarangMasuk.Text = "Form Barang Masuk"
        '
        'TSMenu_FormBarang
        '
        Me.TSMenu_FormBarang.Name = "TSMenu_FormBarang"
        Me.TSMenu_FormBarang.Size = New System.Drawing.Size(303, 34)
        Me.TSMenu_FormBarang.Text = "Form Barang"
        '
        'TSMenu_FormJenisBarang
        '
        Me.TSMenu_FormJenisBarang.Name = "TSMenu_FormJenisBarang"
        Me.TSMenu_FormJenisBarang.Size = New System.Drawing.Size(303, 34)
        Me.TSMenu_FormJenisBarang.Text = "Form Jenis Barang"
        '
        'PilihFormLainnyaToolStripMenuItem
        '
        Me.PilihFormLainnyaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PilihFormLainnyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMenu_FormJenisBarang, Me.TSMenu_FormBarang, Me.TSMenu_FormBarangMasuk, Me.SignOutToolStripMenuItem})
        Me.PilihFormLainnyaToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PilihFormLainnyaToolStripMenuItem.Name = "PilihFormLainnyaToolStripMenuItem"
        Me.PilihFormLainnyaToolStripMenuItem.Size = New System.Drawing.Size(200, 27)
        Me.PilihFormLainnyaToolStripMenuItem.Text = "Pilih Form Lainnya"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihFormLainnyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1169, 33)
        Me.MenuStrip1.TabIndex = 72
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(66, 356)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(288, 34)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Database Penjualan"
        '
        'Btn_UpdatePenjualan
        '
        Me.Btn_UpdatePenjualan.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Btn_UpdatePenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_UpdatePenjualan.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_UpdatePenjualan.Location = New System.Drawing.Point(757, 168)
        Me.Btn_UpdatePenjualan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_UpdatePenjualan.Name = "Btn_UpdatePenjualan"
        Me.Btn_UpdatePenjualan.Size = New System.Drawing.Size(176, 50)
        Me.Btn_UpdatePenjualan.TabIndex = 67
        Me.Btn_UpdatePenjualan.Text = "Update"
        Me.Btn_UpdatePenjualan.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.sistem_keuangan_toko_uas.My.Resources.Resources.shopping_bags
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(593, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(538, 513)
        Me.Panel3.TabIndex = 74
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1169, 814)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btn_HapusPenjualan)
        Me.Controls.Add(Me.Btn_TambahPenjualan)
        Me.Controls.Add(Me.DGV_Penjualan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_UpdatePenjualan)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormPenjualan"
        Me.Text = "Penjualan"
        CType(Me.DGV_Penjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Date_Jual As DateTimePicker
    Friend WithEvents Txt_ID_Barang As TextBox
    Friend WithEvents Txt_JumlahBarang As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_HapusPenjualan As Button
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_TambahPenjualan As Button
    Friend WithEvents DGV_Penjualan As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TSMenu_FormBarangMasuk As ToolStripMenuItem
    Friend WithEvents TSMenu_FormBarang As ToolStripMenuItem
    Friend WithEvents TSMenu_FormJenisBarang As ToolStripMenuItem
    Friend WithEvents PilihFormLainnyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_UpdatePenjualan As Button
    Friend WithEvents Panel3 As Panel
End Class
