<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateBarang
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BtnUpdateBarang = New System.Windows.Forms.Button()
        Me.CB_jenisbarang = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_harga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Date_Masuk = New System.Windows.Forms.DateTimePicker()
        Me.Date_Kadaluarsa = New System.Windows.Forms.DateTimePicker()
        Me.Txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Txt_stock = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'BtnUpdateBarang
        '
        Me.BtnUpdateBarang.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnUpdateBarang.FlatAppearance.BorderSize = 0
        Me.BtnUpdateBarang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnUpdateBarang.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdateBarang.Location = New System.Drawing.Point(275, 481)
        Me.BtnUpdateBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnUpdateBarang.Name = "BtnUpdateBarang"
        Me.BtnUpdateBarang.Size = New System.Drawing.Size(176, 50)
        Me.BtnUpdateBarang.TabIndex = 80
        Me.BtnUpdateBarang.Text = "Update"
        Me.BtnUpdateBarang.UseVisualStyleBackColor = False
        '
        'CB_jenisbarang
        '
        Me.CB_jenisbarang.FormattingEnabled = True
        Me.CB_jenisbarang.Location = New System.Drawing.Point(210, 18)
        Me.CB_jenisbarang.Name = "CB_jenisbarang"
        Me.CB_jenisbarang.Size = New System.Drawing.Size(311, 29)
        Me.CB_jenisbarang.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 22)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "ID Jenis Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(17, 61)
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
        Me.Label4.Location = New System.Drawing.Point(17, 159)
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
        Me.Label5.Location = New System.Drawing.Point(17, 207)
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
        Me.Label6.Location = New System.Drawing.Point(17, 252)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tanggal Kadaluarsa"
        '
        'Txt_harga
        '
        Me.Txt_harga.Location = New System.Drawing.Point(210, 156)
        Me.Txt_harga.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_harga.Name = "Txt_harga"
        Me.Txt_harga.Size = New System.Drawing.Size(311, 30)
        Me.Txt_harga.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(17, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Stock"
        '
        'Date_Masuk
        '
        Me.Date_Masuk.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Date_Masuk.Location = New System.Drawing.Point(210, 207)
        Me.Date_Masuk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Date_Masuk.Name = "Date_Masuk"
        Me.Date_Masuk.Size = New System.Drawing.Size(311, 30)
        Me.Date_Masuk.TabIndex = 14
        '
        'Date_Kadaluarsa
        '
        Me.Date_Kadaluarsa.Location = New System.Drawing.Point(210, 252)
        Me.Date_Kadaluarsa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Date_Kadaluarsa.Name = "Date_Kadaluarsa"
        Me.Date_Kadaluarsa.Size = New System.Drawing.Size(311, 30)
        Me.Date_Kadaluarsa.TabIndex = 15
        '
        'Txt_NamaBarang
        '
        Me.Txt_NamaBarang.Location = New System.Drawing.Point(210, 60)
        Me.Txt_NamaBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_NamaBarang.Name = "Txt_NamaBarang"
        Me.Txt_NamaBarang.Size = New System.Drawing.Size(311, 30)
        Me.Txt_NamaBarang.TabIndex = 7
        '
        'Txt_stock
        '
        Me.Txt_stock.Location = New System.Drawing.Point(210, 106)
        Me.Txt_stock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_stock.Name = "Txt_stock"
        Me.Txt_stock.Size = New System.Drawing.Size(311, 30)
        Me.Txt_stock.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(25, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(127, 31)
        Me.ToolStrip1.TabIndex = 81
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(250, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 34)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Update Barang"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CB_jenisbarang)
        Me.Panel1.Controls.Add(Me.Label1)
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
        Me.Panel1.Location = New System.Drawing.Point(85, 141)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 313)
        Me.Panel1.TabIndex = 79
        '
        'FormUpdateBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(728, 558)
        Me.Controls.Add(Me.BtnUpdateBarang)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormUpdateBarang"
        Me.Text = "FormUpdateBarang"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BtnUpdateBarang As Button
    Friend WithEvents CB_jenisbarang As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_harga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Date_Masuk As DateTimePicker
    Friend WithEvents Date_Kadaluarsa As DateTimePicker
    Friend WithEvents Txt_NamaBarang As TextBox
    Friend WithEvents Txt_stock As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class
