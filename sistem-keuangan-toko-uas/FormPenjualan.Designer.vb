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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripJenisBrg = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripPenjualan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripBrgMasuk = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripBarang = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSignOut = New System.Windows.Forms.ToolStripButton()
        Me.Btn_TambahPenjualan = New System.Windows.Forms.Button()
        Me.DGV_Penjualan = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_UpdatePenjualan = New System.Windows.Forms.Button()
        Me.Btn_HapusPenjualan = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGV_Penjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(352, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 34)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "_________________________"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(62, 29)
        Me.ToolStripLabel2.Text = "          "
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 34)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(32, 29)
        Me.ToolStripLabel1.Text = "    "
        '
        'ToolStripJenisBrg
        '
        Me.ToolStripJenisBrg.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripJenisBrg.Image = Global.sistem_keuangan_toko_uas.My.Resources.Resources.product
        Me.ToolStripJenisBrg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripJenisBrg.Name = "ToolStripJenisBrg"
        Me.ToolStripJenisBrg.Size = New System.Drawing.Size(163, 29)
        Me.ToolStripJenisBrg.Text = "Jenis Barang"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripPenjualan
        '
        Me.ToolStripPenjualan.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripPenjualan.Image = Global.sistem_keuangan_toko_uas.My.Resources.Resources.shopping_cart__2_
        Me.ToolStripPenjualan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripPenjualan.Name = "ToolStripPenjualan"
        Me.ToolStripPenjualan.Size = New System.Drawing.Size(135, 29)
        Me.ToolStripPenjualan.Text = "Penjualan"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripBrgMasuk
        '
        Me.ToolStripBrgMasuk.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripBrgMasuk.Image = Global.sistem_keuangan_toko_uas.My.Resources.Resources.new_product
        Me.ToolStripBrgMasuk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBrgMasuk.Name = "ToolStripBrgMasuk"
        Me.ToolStripBrgMasuk.Size = New System.Drawing.Size(178, 29)
        Me.ToolStripBrgMasuk.Text = "Barang Masuk"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripBarang
        '
        Me.ToolStripBarang.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripBarang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBarang.Name = "ToolStripBarang"
        Me.ToolStripBarang.Size = New System.Drawing.Size(164, 29)
        Me.ToolStripBarang.Text = "Katalog Barang"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBarang, Me.ToolStripSeparator1, Me.ToolStripBrgMasuk, Me.ToolStripSeparator2, Me.ToolStripPenjualan, Me.ToolStripSeparator3, Me.ToolStripJenisBrg, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripLabel2, Me.ToolStripSignOut})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(960, 34)
        Me.ToolStrip1.TabIndex = 80
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSignOut
        '
        Me.ToolStripSignOut.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripSignOut.Image = Global.sistem_keuangan_toko_uas.My.Resources.Resources.log_out
        Me.ToolStripSignOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSignOut.Name = "ToolStripSignOut"
        Me.ToolStripSignOut.Size = New System.Drawing.Size(57, 29)
        Me.ToolStripSignOut.Text = "   "
        Me.ToolStripSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Btn_TambahPenjualan
        '
        Me.Btn_TambahPenjualan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_TambahPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_TambahPenjualan.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_TambahPenjualan.Location = New System.Drawing.Point(757, 177)
        Me.Btn_TambahPenjualan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_TambahPenjualan.Name = "Btn_TambahPenjualan"
        Me.Btn_TambahPenjualan.Size = New System.Drawing.Size(176, 50)
        Me.Btn_TambahPenjualan.TabIndex = 76
        Me.Btn_TambahPenjualan.Text = "Tambah"
        Me.Btn_TambahPenjualan.UseVisualStyleBackColor = False
        '
        'DGV_Penjualan
        '
        Me.DGV_Penjualan.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_Penjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Penjualan.Location = New System.Drawing.Point(60, 149)
        Me.DGV_Penjualan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGV_Penjualan.Name = "DGV_Penjualan"
        Me.DGV_Penjualan.RowHeadersWidth = 51
        Me.DGV_Penjualan.RowTemplate.Height = 29
        Me.DGV_Penjualan.Size = New System.Drawing.Size(664, 251)
        Me.DGV_Penjualan.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(60, 92)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(288, 34)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Database Penjualan"
        '
        'Btn_UpdatePenjualan
        '
        Me.Btn_UpdatePenjualan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_UpdatePenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_UpdatePenjualan.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_UpdatePenjualan.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_UpdatePenjualan.Location = New System.Drawing.Point(757, 247)
        Me.Btn_UpdatePenjualan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_UpdatePenjualan.Name = "Btn_UpdatePenjualan"
        Me.Btn_UpdatePenjualan.Size = New System.Drawing.Size(176, 50)
        Me.Btn_UpdatePenjualan.TabIndex = 77
        Me.Btn_UpdatePenjualan.Text = "Update"
        Me.Btn_UpdatePenjualan.UseVisualStyleBackColor = False
        '
        'Btn_HapusPenjualan
        '
        Me.Btn_HapusPenjualan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_HapusPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_HapusPenjualan.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_HapusPenjualan.ForeColor = System.Drawing.Color.IndianRed
        Me.Btn_HapusPenjualan.Location = New System.Drawing.Point(757, 320)
        Me.Btn_HapusPenjualan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_HapusPenjualan.Name = "Btn_HapusPenjualan"
        Me.Btn_HapusPenjualan.Size = New System.Drawing.Size(176, 50)
        Me.Btn_HapusPenjualan.TabIndex = 78
        Me.Btn_HapusPenjualan.Text = "Hapus"
        Me.Btn_HapusPenjualan.UseVisualStyleBackColor = False
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(960, 438)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Btn_TambahPenjualan)
        Me.Controls.Add(Me.DGV_Penjualan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_UpdatePenjualan)
        Me.Controls.Add(Me.Btn_HapusPenjualan)
        Me.Name = "FormPenjualan"
        Me.Text = "FormPenjualan"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGV_Penjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripJenisBrg As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripPenjualan As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripBrgMasuk As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripBarang As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSignOut As ToolStripButton
    Friend WithEvents Btn_TambahPenjualan As Button
    Friend WithEvents DGV_Penjualan As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_UpdatePenjualan As Button
    Friend WithEvents Btn_HapusPenjualan As Button
End Class
