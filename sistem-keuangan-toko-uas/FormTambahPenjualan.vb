Imports MySql.Data.MySqlClient

Public Class FormTambahPenjualan

    Dim mycmd As New MySqlCommand
    Dim myconnection As New ClassPenjualan
    Dim dadapter As MySqlDataAdapter
    Dim dTabel As New DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub FormTambahPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT id_barang, nama_barang FROM barang ORDER BY id_barang"
        dadapter = New MySqlDataAdapter(mycmd)

        dadapter.Fill(dTabel)
        CB_namabarang.DataSource = dTabel
        CB_namabarang.DisplayMember = "nama_barang"
        CB_namabarang.ValueMember = "id_barang"
        If CB_namabarang.Items.Count > 0 Then
            CB_namabarang.Text = "Pilih Barang"
        End If

    End Sub


    Private Sub Btn_Tambah_Click(sender As Object, e As EventArgs) Handles Btn_Tambah.Click
        mycmd.CommandText = "INSERT INTO penjualan(id_barang, jumlah_barang, tanggal_jual)
                             VALUES('" _
                             & CB_namabarang.SelectedValue.ToString & "', '" _
                             & Txt_JumlahBarang.Text.ToString & "', '" _
                             & Date_Jual.Value.ToString("yyyy/MM/dd") & "')"

        mycmd.ExecuteNonQuery()
        myconnection.close()
        FormPenjualan.ResultDGV()
        MsgBox("Data tersimpan!", MsgBoxStyle.Information, "Pemberitahuan")

        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class