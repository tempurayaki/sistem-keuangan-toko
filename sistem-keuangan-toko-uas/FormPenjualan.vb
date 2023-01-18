Imports MySql.Data.MySqlClient
Imports System.Reflection.Emit
Imports System.Windows

Public Class FormPenjualan

    Public Shared Penjualan As ClassPenjualan

    Public Shared id_penjualan As Integer
    Public Shared id_barang_jual As Integer
    Public Shared jml_barang As Integer
    Public Shared tgl_jual As String

    Dim mycmd As New MySqlCommand
    Dim myconnection As New ClassPenjualan
    Dim dadapter As MySqlDataAdapter
    Dim dTabel As New DataTable

    Public BindingSource1 As New BindingSource()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Penjualan = New ClassPenjualan()

        ResultDGV()


    End Sub

    Public Sub ResultDGV()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM penjualan ORDER BY id_penjualan"
        dadapter = New MySqlDataAdapter(mycmd)
        dTabel.Rows.Clear()
        dadapter.Fill(dTabel)
        If Not dTabel Is Nothing AndAlso dTabel.Rows.Count > 0 Then
            DGV_Penjualan.DataSource = dTabel

            With DGV_Penjualan
                .Columns(0).HeaderText = "ID Penjualan"
                .Columns(1).HeaderText = "ID Barang"
                .Columns(2).HeaderText = "Jumlah Barang"
                .Columns(3).HeaderText = "Tanggal Penjualan"
            End With


        End If

        myconnection.close()
    End Sub

    Private Sub DGV_Penjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Penjualan.CellClick
        Dim DGVIndex As Integer
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DGV_Penjualan.Rows(DGVIndex)

        'selectedTableBarang = SelectedRow.Cells(0).Value

        With DGV_Penjualan
            If e.RowIndex >= 0 Then
                DGVIndex = .CurrentRow.Index
                id_penjualan = .Rows(DGVIndex).Cells(0).Value.ToString
                id_barang_jual = .Rows(DGVIndex).Cells(1).Value.ToString
                jml_barang = .Rows(DGVIndex).Cells(2).Value.ToString
                tgl_jual = .Rows(DGVIndex).Cells(3).Value.ToString
            End If
        End With
    End Sub

    Private Sub Btn_TambahPenjualan_Click(sender As Object, e As EventArgs) Handles Btn_TambahPenjualan.Click
        Dim formTambahPenjualan = New FormTambahPenjualan()
        formTambahPenjualan.Show()
    End Sub

    Private Sub Btn_HapusPenjualan_Click(sender As Object, e As EventArgs) Handles Btn_HapusPenjualan.Click
        Dim resultInput As DialogResult = MessageBox.Show("Yakin akan Menghapus?", "Pemberitahuan", MessageBoxButtons.YesNo)

        If resultInput = DialogResult.No Then
            MessageBox.Show("Hapus dibatalkan")
        ElseIf resultInput = DialogResult.Yes Then
            mycmd.Connection = myconnection.open
            mycmd.CommandText = "DELETE FROM penjualan WHERE id_penjualan='" & id_penjualan & "'"
            mycmd.ExecuteNonQuery()
            myconnection.close()
            ResultDGV()
            MsgBox("Data terhapus!", MsgBoxStyle.Information, "Pemberitahuan")
        End If
    End Sub

    Private Sub Btn_UpdatePenjualan_Click(sender As Object, e As EventArgs) Handles Btn_UpdatePenjualan.Click
        Dim formUpdatePenjualan = New FormUpdatePenjualan()
        formUpdatePenjualan.Show()
    End Sub

    Private Sub FormPenjualan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ResultDGV()
    End Sub

    Private Sub ToolStripBarang_Click(sender As Object, e As EventArgs) Handles ToolStripBarang.Click
        Dim formBarang = New FormBarang()
        formBarang.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripBrgMasuk_Click(sender As Object, e As EventArgs) Handles ToolStripBrgMasuk.Click
        Dim formBarangMasuk = New FormBarangMasuk()
        formBarangMasuk.Show()
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

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class