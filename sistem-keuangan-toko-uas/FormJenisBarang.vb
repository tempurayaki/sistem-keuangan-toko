Public Class FormJenisBarang

    Public Shared jenisbarang As ClassJenisBarang
    Public Shared selectedTableJenisBarang
    Public Shared selectedTableJenisBarangNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        jenisbarang = New ClassJenisBarang()
        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridJenisBarang.DataSource = jenisbarang.GetDataJenisBarangDatabase()
    End Sub

    Private Sub FormJenisBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambahJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnTambahJenisBarang.Click

        Dim open_formtambah = New FormTambahJenisBarang()
        open_formtambah.Show()

    End Sub

    Private Sub BtnUpdateJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnUpdateJenisBarang.Click
        If selectedTableJenisBarang IsNot Nothing Then
            Dim selectedJenisBarang As List(Of String) = jenisbarang.GetdataJenisBarangByIDDatabase(selectedTableJenisBarang)

            jenisbarang.namaJenisBarangProperty = selectedJenisBarang(1)

            Dim open_formupdate = New FormUpdateJenisBarang()
            open_formupdate.Show()

        End If
    End Sub

    Private Sub BtnHapusJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnHapusJenisBarang.Click

        Dim resultInput As DialogResult = MessageBox.Show("Yakin akan Menghapus?", "Pemberitahuan", MessageBoxButtons.YesNo)

        If resultInput = DialogResult.No Then
            MessageBox.Show("Hapus dibatalkan")
        ElseIf resultInput = DialogResult.Yes Then
            jenisbarang.DeleteDataJenisBarangByIDDatabase(selectedTableJenisBarang)
            MsgBox("Data terhapus!", MsgBoxStyle.Information, "Pemberitahuan")
        End If

    End Sub

    Private Sub DataGridJenisBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJenisBarang.CellClick

        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridJenisBarang.Rows(index)

        selectedTableJenisBarang = selectedRow.Cells(0).Value
        selectedTableJenisBarangNama = selectedRow.Cells(1).Value

    End Sub

    Private Sub ToolStripBrgMasuk_Click(sender As Object, e As EventArgs) Handles ToolStripBrgMasuk.Click
        Dim formBarangMasuk = New FormBarangMasuk()
        formBarangMasuk.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripBarang_Click(sender As Object, e As EventArgs) Handles ToolStripBarang.Click
        Dim formbarang = New FormBarang()
        formbarang.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripPenjualan_Click(sender As Object, e As EventArgs) Handles ToolStripPenjualan.Click
        Dim formpenjualan = New FormPenjualan()
        formpenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripSignOut_Click(sender As Object, e As EventArgs) Handles ToolStripSignOut.Click
        Dim resultinput As DialogResult = MessageBox.Show("Apakah anda yakin ingin keluar?", "Pemberitahuan", MessageBoxButtons.YesNo)

        If resultinput = DialogResult.No Then
            MessageBox.Show("Sign Out Dibatalkan")
        ElseIf resultinput = DialogResult.Yes Then
            Dim formSignIn = New FormSignIn()
            formSignIn.Show()
            Me.Close()
        End If
    End Sub


End Class