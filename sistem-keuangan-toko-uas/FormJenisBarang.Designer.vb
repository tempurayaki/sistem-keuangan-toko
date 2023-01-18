<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenisBarang
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
        Me.DataGridJenisBarang = New System.Windows.Forms.DataGridView()
        Me.BtnHapusJenisBarang = New System.Windows.Forms.Button()
        Me.BtnUpdateJenisBarang = New System.Windows.Forms.Button()
        Me.BtnTambahJenisBarang = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PilihMenuLainnyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormBarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilihMenuLainnyaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTambahJenisBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridJenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridJenisBarang
        '
        Me.DataGridJenisBarang.BackgroundColor = System.Drawing.Color.MistyRose
        Me.DataGridJenisBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridJenisBarang.Location = New System.Drawing.Point(476, 139)
        Me.DataGridJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridJenisBarang.Name = "DataGridJenisBarang"
        Me.DataGridJenisBarang.RowHeadersWidth = 62
        Me.DataGridJenisBarang.RowTemplate.Height = 25
        Me.DataGridJenisBarang.Size = New System.Drawing.Size(430, 267)
        Me.DataGridJenisBarang.TabIndex = 25
        '
        'BtnHapusJenisBarang
        '
        Me.BtnHapusJenisBarang.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnHapusJenisBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapusJenisBarang.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusJenisBarang.Location = New System.Drawing.Point(297, 371)
        Me.BtnHapusJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnHapusJenisBarang.Name = "BtnHapusJenisBarang"
        Me.BtnHapusJenisBarang.Size = New System.Drawing.Size(115, 38)
        Me.BtnHapusJenisBarang.TabIndex = 24
        Me.BtnHapusJenisBarang.Text = "Hapus"
        Me.BtnHapusJenisBarang.UseVisualStyleBackColor = False
        '
        'BtnUpdateJenisBarang
        '
        Me.BtnUpdateJenisBarang.BackColor = System.Drawing.Color.MistyRose
        Me.BtnUpdateJenisBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateJenisBarang.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdateJenisBarang.Location = New System.Drawing.Point(174, 371)
        Me.BtnUpdateJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUpdateJenisBarang.Name = "BtnUpdateJenisBarang"
        Me.BtnUpdateJenisBarang.Size = New System.Drawing.Size(115, 38)
        Me.BtnUpdateJenisBarang.TabIndex = 23
        Me.BtnUpdateJenisBarang.Text = "Update"
        Me.BtnUpdateJenisBarang.UseVisualStyleBackColor = False
        '
        'BtnTambahJenisBarang
        '
        Me.BtnTambahJenisBarang.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnTambahJenisBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahJenisBarang.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahJenisBarang.Location = New System.Drawing.Point(51, 371)
        Me.BtnTambahJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnTambahJenisBarang.Name = "BtnTambahJenisBarang"
        Me.BtnTambahJenisBarang.Size = New System.Drawing.Size(115, 38)
        Me.BtnTambahJenisBarang.TabIndex = 22
        Me.BtnTambahJenisBarang.Text = "Tambah"
        Me.BtnTambahJenisBarang.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihMenuLainnyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(962, 33)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PilihMenuLainnyaToolStripMenuItem
        '
        Me.PilihMenuLainnyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormPenjualanToolStripMenuItem, Me.FormBarangToolStripMenuItem, Me.FormBarangMasukToolStripMenuItem, Me.SignOutToolStripMenuItem, Me.PilihMenuLainnyaToolStripMenuItem1})
        Me.PilihMenuLainnyaToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PilihMenuLainnyaToolStripMenuItem.Name = "PilihMenuLainnyaToolStripMenuItem"
        Me.PilihMenuLainnyaToolStripMenuItem.Size = New System.Drawing.Size(207, 27)
        Me.PilihMenuLainnyaToolStripMenuItem.Text = "Pilih Menu Lainnya"
        '
        'FormPenjualanToolStripMenuItem
        '
        Me.FormPenjualanToolStripMenuItem.Name = "FormPenjualanToolStripMenuItem"
        Me.FormPenjualanToolStripMenuItem.Size = New System.Drawing.Size(303, 34)
        Me.FormPenjualanToolStripMenuItem.Text = "Form Penjualan"
        '
        'FormBarangToolStripMenuItem
        '
        Me.FormBarangToolStripMenuItem.Name = "FormBarangToolStripMenuItem"
        Me.FormBarangToolStripMenuItem.Size = New System.Drawing.Size(303, 34)
        Me.FormBarangToolStripMenuItem.Text = "Form Barang"
        '
        'FormBarangMasukToolStripMenuItem
        '
        Me.FormBarangMasukToolStripMenuItem.Name = "FormBarangMasukToolStripMenuItem"
        Me.FormBarangMasukToolStripMenuItem.Size = New System.Drawing.Size(303, 34)
        Me.FormBarangMasukToolStripMenuItem.Text = "Form Barang Masuk"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(303, 34)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'PilihMenuLainnyaToolStripMenuItem1
        '
        Me.PilihMenuLainnyaToolStripMenuItem1.Name = "PilihMenuLainnyaToolStripMenuItem1"
        Me.PilihMenuLainnyaToolStripMenuItem1.Size = New System.Drawing.Size(303, 34)
        Me.PilihMenuLainnyaToolStripMenuItem1.Text = "Pilih Menu Lainnya"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.sistem_keuangan_toko_uas.My.Resources.Resources.WhatsApp_Image_2022_12_25_at_22_50_27
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(99, 73)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 203)
        Me.Panel1.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(591, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 34)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Jenis Barang"
        '
        'TxtTambahJenisBarang
        '
        Me.TxtTambahJenisBarang.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTambahJenisBarang.Location = New System.Drawing.Point(51, 331)
        Me.TxtTambahJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtTambahJenisBarang.Name = "TxtTambahJenisBarang"
        Me.TxtTambahJenisBarang.Size = New System.Drawing.Size(361, 30)
        Me.TxtTambahJenisBarang.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(143, 298)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 23)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Nama Jenis Barang"
        '
        'FormJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 448)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTambahJenisBarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridJenisBarang)
        Me.Controls.Add(Me.BtnHapusJenisBarang)
        Me.Controls.Add(Me.BtnUpdateJenisBarang)
        Me.Controls.Add(Me.BtnTambahJenisBarang)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormJenisBarang"
        Me.Text = "FormJenisBarang"
        CType(Me.DataGridJenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridJenisBarang As DataGridView
    Friend WithEvents BtnHapusJenisBarang As Button
    Friend WithEvents BtnUpdateJenisBarang As Button
    Friend WithEvents BtnTambahJenisBarang As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PilihMenuLainnyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormBarangMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PilihMenuLainnyaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TxtTambahJenisBarang As TextBox
    Friend WithEvents Label2 As Label
End Class
