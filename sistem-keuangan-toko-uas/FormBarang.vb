
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class FormBarang

    'Public Shared selectedTableBarang

    Public Shared Barang As ClassBarang

    Public Shared id_barang As Integer
    Public Shared id_jenisbarang As Integer
    Public Shared nama_barang As String
    Public Shared stock As Integer
    Public Shared harga As Integer
    Public Shared tanggal_masuk As String
    Public Shared tanggal_kadaluarsa As String

    Dim mycmd As New MySqlCommand
    Dim myconnection As New ClassBarang
    Dim dadapter As MySqlDataAdapter
    Dim dTabel As New DataTable
    Dim stockTable As New DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Barang = New ClassBarang()
        ResultDGV()
        Result_DGVStock()


    End Sub


    Public Sub ResultDGV()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM barang ORDER BY id_barang"
        dadapter = New MySqlDataAdapter(mycmd)
        dTabel.Rows.Clear()
        dadapter.Fill(dTabel)

        If Not dTabel Is Nothing AndAlso dTabel.Rows.Count > 0 Then
            DGV_Barang.DataSource = dTabel
        End If

        With DGV_Barang
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "ID Jenis"
            .Columns(2).HeaderText = "Nama Barang"
            .Columns(3).HeaderText = "Stock Awal"
            .Columns(4).HeaderText = "Harga"
            .Columns(5).HeaderText = "Tanggal Masuk"
            .Columns(6).HeaderText = "Tanggal Kadaluarsa"
        End With

        myconnection.close()
    End Sub

    Public Sub Result_DGVStock()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT a.id_barang, a.nama_barang, (a.stock + SUM(b.jumlah_barang_masuk)) - SUM(c.jumlah_barang) AS stock FROM barang a INNER JOIN barang_masuk b ON a.id_barang = b.id_barang INNER JOIN penjualan c ON a.id_barang = c.id_barang GROUP BY a.id_barang;"
        dadapter = New MySqlDataAdapter(mycmd)
        stockTable.Rows.Clear()
        dadapter.Fill(stockTable)

        If Not stockTable Is Nothing AndAlso stockTable.Rows.Count > 0 Then
            DGV_Stock.DataSource = stockTable
        End If

        With DGV_Stock
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).HeaderText = "Stock"
        End With

        myconnection.close()
    End Sub



    Private Sub Btn_TambahBarang_Click(sender As Object, e As EventArgs) Handles Btn_TambahBarang.Click
        Dim formTambahBarang = New FormTambahBarang()
        formTambahBarang.Show()
    End Sub


    Private Sub Btn_UpdateBarang_Click(sender As Object, e As EventArgs) Handles Btn_UpdateBarang.Click
        Dim formUpdateBarang = New FormUpdateBarang()
        formUpdateBarang.Show()
    End Sub



    Private Sub Btn_HapusBarang_Click(sender As Object, e As EventArgs) Handles Btn_HapusBarang.Click

        Dim resultInput As DialogResult = MessageBox.Show("Yakin akan Menghapus?", "Pemberitahuan", MessageBoxButtons.YesNo)

        If resultInput = DialogResult.No Then
            MessageBox.Show("Hapus dibatalkan")
        ElseIf resultInput = DialogResult.Yes Then
            mycmd.Connection = myconnection.open
            mycmd.CommandText = "DELETE FROM barang WHERE id_barang='" & id_barang & "'"
            mycmd.ExecuteNonQuery()
            myconnection.close()
            ResultDGV()
            MsgBox("Data terhapus!", MsgBoxStyle.Information, "Pemberitahuan")
        End If

    End Sub



    Private Sub DGV_Barang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Barang.CellClick
        Dim DGVIndex As Integer
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DGV_Barang.Rows(DGVIndex)

        'selectedTableBarang = SelectedRow.Cells(0).Value

        With DGV_Barang
            If e.RowIndex >= 0 Then
                DGVIndex = .CurrentRow.Index
                id_barang = .Rows(DGVIndex).Cells(0).Value.ToString
                id_jenisbarang = .Rows(DGVIndex).Cells(1).Value.ToString
                nama_barang = .Rows(DGVIndex).Cells(2).Value.ToString
                stock = .Rows(DGVIndex).Cells(3).Value.ToString
                harga = .Rows(DGVIndex).Cells(4).Value.ToString
                tanggal_masuk = .Rows(DGVIndex).Cells(5).Value.ToString
                tanggal_kadaluarsa = .Rows(DGVIndex).Cells(6).Value.ToString
            End If
        End With


    End Sub

    Private Sub FormBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ResultDGV()
        Result_DGVStock()
    End Sub


    Private Sub ToolStripBrgMasuk_Click(sender As Object, e As EventArgs) Handles ToolStripBrgMasuk.Click
        Dim formBarangMasuk = New FormBarangMasuk()
        formBarangMasuk.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripPenjualan_Click(sender As Object, e As EventArgs) Handles ToolStripPenjualan.Click
        Dim formPenjualan = New FormPenjualan()
        formPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripJenisBrg_Click(sender As Object, e As EventArgs) Handles ToolStripJenisBrg.Click
        Dim formJenis = New FormJenisBarang()
        formJenis.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripSignOut_Click(sender As Object, e As EventArgs) Handles ToolStripSignOut.Click
        Dim resultinput As DialogResult = MessageBox.Show("Apakah anda yakin ingin keluar?", "Pemberitahuan", MessageBoxButtons.YesNo)

        If resultinput = DialogResult.No Then
            MessageBox.Show("Batal Keluar")
        ElseIf resultinput = DialogResult.Yes Then
            Dim formSignIn = New FormSignIn()
            formSignIn.Show()
            Me.Close()
        End If
    End Sub
End Class