Imports MySql.Data.MySqlClient

Public Class FormTambahBarangMasuk

        Dim mycmd As New MySqlCommand
        Dim myconnection As New ClassBarangMasuk
        Dim dadapter As MySqlDataAdapter
        Dim dTabel As New DataTable

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Private Sub FormTambahBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Private Sub BtnTambahBarangMasuk_Click(sender As Object, e As EventArgs) Handles BtnTambahBarangMasuk.Click

            mycmd.CommandText = "INSERT INTO barang_masuk(id_barang, jumlah_barang_masuk, tanggal_barang_masuk)
                             VALUES('" _
                             & CB_namabarang.SelectedValue.ToString & "', '" _
                             & Txt_JmlBrg.Text.ToString & "', '" _
                             & Date_Masuk.Value.ToString("yyyy/MM/dd") & "')"

            mycmd.ExecuteNonQuery()
            myconnection.close()
            FormBarangMasuk.ResultDGV()
            MsgBox("Data tersimpan!", MsgBoxStyle.Information, "Pemberitahuan")
            Me.Close()
        End Sub

        Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
            Me.Close()
        End Sub


    End Class