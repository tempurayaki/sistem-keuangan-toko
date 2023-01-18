Imports MySql.Data.MySqlClient

Public Class FormTambahBarang

    Dim mycmd As New MySqlCommand
    Dim myconnection As New ClassBarang
    Dim dadapter As MySqlDataAdapter
    Dim dTabel As New DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub FormTambahBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT id_jenis_barang, jenis_barang FROM jenis_barang ORDER BY id_jenis_barang"
        dadapter = New MySqlDataAdapter(mycmd)
        dadapter.Fill(dTabel)

        CB_jenisbarang.DataSource = dTabel
        CB_jenisbarang.DisplayMember = "jenis_barang"
        CB_jenisbarang.ValueMember = "id_jenis_barang"
        If CB_jenisbarang.Items.Count > 0 Then
            CB_jenisbarang.Text = "Pilih Jenis Barang"
        End If

    End Sub


    Private Sub BtnTambahBarang_Click(sender As Object, e As EventArgs) Handles BtnTambahBarang.Click
        mycmd.CommandText = "INSERT INTO barang(id_jenis_barang, nama_barang, stock, harga,
                                tanggal_masuk, tanggal_kadaluarsa)
                                VALUES('" _
                                & CB_jenisbarang.SelectedValue.ToString & "', '" _
                                & Txt_NamaBarang.Text & "', '" _
                                & Txt_stock.Text & "', '" _
                                & Txt_harga.Text.ToString & "', '" _
                                & Date_Masuk.Value.ToString("yyyy/MM/dd") & "', '" _
                                & Date_Kadaluarsa.Value.ToString("yyyy/MM/dd") & "')"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        FormBarang.ResultDGV()
        FormBarang.Result_DGVStock()
        MsgBox("Data tersimpan!", MsgBoxStyle.Information, "Pemberitahuan")
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class