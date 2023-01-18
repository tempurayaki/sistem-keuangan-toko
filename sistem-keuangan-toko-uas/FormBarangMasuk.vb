Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports Mysqlx.XDevAPI.Common
Imports System.Reflection.Emit
Imports System.Windows

Public Class FormBarangMasuk
    Public Shared selectedTableBarangMasuk

    Public Shared BarangMasuk As ClassBarangMasuk

    Public Shared id_barang_masuk As Integer
    Public Shared id_barang_bm As Integer
    Public Shared jml_brg As Integer
    Public Shared tgl_masuk As String

    Dim mycmd As New MySqlCommand
    Dim myconnection As New ClassBarangMasuk
    Dim dadapter As MySqlDataAdapter
    Dim dTabel As New DataTable

    'Public BindingSource1 As New BindingSource()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        BarangMasuk = New ClassBarangMasuk()
        ResultDGV()

    End Sub



    Public Sub ResultDGV()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM barang_masuk ORDER BY id_barang_masuk"
        dadapter = New MySqlDataAdapter(mycmd)
        dTabel.Rows.Clear()
        dadapter.Fill(dTabel)

        If Not dTabel Is Nothing AndAlso dTabel.Rows.Count > 0 Then
            DGV_BarangMasuk.DataSource = dTabel

            With DGV_BarangMasuk
                .Columns(0).HeaderText = "ID Barang Masuk"
                .Columns(1).HeaderText = "ID Barang"
                .Columns(2).HeaderText = "Jumlah Barang"
                .Columns(3).HeaderText = "Tanggal Barang Masuk"
            End With
        End If

        myconnection.close()
    End Sub

    Private Sub Btn_TambahBarangMasuk_Click(sender As Object, e As EventArgs) Handles Btn_TambahBarangMasuk.Click
        Dim formTambahBarangMasuk = New FormTambahBarangMasuk()
        formTambahBarangMasuk.Show()
    End Sub

    Private Sub Btn_UpdatePenjualan_Click(sender As Object, e As EventArgs) Handles Btn_UpdateBarangMasuk.Click
        Dim formUpdateBarangMasuk = New FormUpdateBarangMasuk()
        formUpdateBarangMasuk.Show()
    End Sub

    Private Sub Btn_HapusPenjualan_Click(sender As Object, e As EventArgs) Handles Btn_HapusBarangMasuk.Click
        Dim resultInput As DialogResult = MessageBox.Show("Yakin akan Menghapus?", "Pemberitahuan", MessageBoxButtons.YesNo)

        If resultInput = DialogResult.No Then
            MessageBox.Show("Hapus dibatalkan")
        ElseIf resultInput = DialogResult.Yes Then
            mycmd.Connection = myconnection.open
            mycmd.CommandText = "DELETE FROM barang_masuk WHERE id_barang_masuk='" & id_barang_masuk & "'"
            mycmd.ExecuteNonQuery()
            myconnection.close()
            ResultDGV()
            MsgBox("Data terhapus!", MsgBoxStyle.Information, "Pemberitahuan")
        End If

    End Sub

    Private Sub DGV_BarangMasuk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BarangMasuk.CellClick
        Dim DGVIndex As Integer
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DGV_BarangMasuk.Rows(DGVIndex)

        'selectedTableBarang = SelectedRow.Cells(0).Value

        With DGV_BarangMasuk
            If e.RowIndex >= 0 Then
                DGVIndex = .CurrentRow.Index
                id_barang_masuk = .Rows(DGVIndex).Cells(0).Value.ToString
                id_barang_bm = .Rows(DGVIndex).Cells(1).Value.ToString
                jml_brg = .Rows(DGVIndex).Cells(2).Value.ToString
                tgl_masuk = .Rows(DGVIndex).Cells(3).Value.ToString
            End If
        End With
    End Sub

    Private Sub FormBarangMasuk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ResultDGV()
    End Sub

    Private Sub ToolStripBarang_Click(sender As Object, e As EventArgs) Handles ToolStripBarang.Click
        Dim formBarang = New FormBarang()
        formBarang.Show()
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