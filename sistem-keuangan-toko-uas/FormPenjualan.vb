Imports System.Reflection.Emit
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class FormPenjualan
        Public CheckIDKasir As Boolean 'Cek ID Kasir valid?
        Public CheckIDBarang As Boolean 'Cek ID Kasir valid?
        Public CheckJumlahBarang As Boolean 'Cek ID Kasir valid?
        Public CheckTanggalMasuk As Boolean 'Cek ID Kasir valid?

        Public id_penjualan As Integer
        Public id_barang As Integer

        'Entah kenapa gak konek dari class barang
        Public Function strconnection() As MySqlConnection
            Return New MySqlConnection("server=localhost;username=root;password='';database='sistem-keuangan-toko';Convert Zero Datetime=True")
        End Function
        Public strcon As MySqlConnection

        Dim mycmd As New MySqlCommand
        Dim myconnection As New ClassBarang
        Dim dadapter As MySqlDataAdapter
        Dim dTabel As New DataTable

        Sub New()

            ' This call is required by the designer.
            InitializeComponent()
            ResultDGV()
            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Sub CheckID()

            'Mengecek Apabila ID Barang sudah benar formatnya
            If Not Regex.Match(Txt_ID_Barang.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only Numbers

                MessageBox.Show("Isi ID_Barang dengan Angka Saja!") 'Inform User

                Txt_ID_Barang.Focus() 'Return Focus
                Txt_ID_Barang.Clear() 'Clear TextBox

                CheckIDBarang = False 'Boolean = False
            Else

                CheckIDBarang = True 'Everything Fine

            End If


        End Sub

        'Public Sub reloadtext(ByVal sql As String)
        '    Try
        '        strcon.Open()
        '        With mycmd
        '            .Connection = strcon
        '            .CommandText = sql
        '        End With
        '        dTabel = New DataTable
        '        dadapter = New MySqlDataAdapter
        '        dadapter.Fill(dTabel)
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message & "reloadText")
        '    Finally
        '        If strcon.State = ConnectionState.Open Then
        '            strcon.Close()
        '            dTabel.Dispose()
        '        End If
        '    End Try
        'End Sub

        Sub ResultDGV()
            mycmd.Connection = myconnection.open
            mycmd.CommandText = "SELECT * FROM penjualan ORDER BY tanggal_jual"
            dadapter = New MySqlDataAdapter(mycmd)
            dTabel.Rows.Clear()
            dadapter.Fill(dTabel)
            If Not dTabel Is Nothing AndAlso dTabel.Rows.Count > 0 Then
                DGV_Penjualan.DataSource = dTabel

                With DGV_Penjualan
                    .Columns(0).HeaderText = "ID_Penjualan"
                    .Columns(1).HeaderText = "ID Barang"
                    .Columns(2).HeaderText = "Jumlah Barang"
                    .Columns(3).HeaderText = "Tanggal Penjualan"
                End With
            End If

            myconnection.close()
        End Sub

        Private Sub Btn_TambahPenjualan_Click(sender As Object, e As EventArgs) Handles Btn_TambahPenjualan.Click
            'Mengecek Sudah keisi atau belum
            Try
                If Txt_ID_Barang.Text = "" Then
                    MessageBox.Show("ID Kosong! Mohon diisi sesuai yang ada dalam database", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    CheckID() 'Ngecek formatnya dulu
                    'reloadtext("SELECT * FROM penjualan WHERE id_penjualan='" & Txt_ID_Barang.Text & "'")
                    mycmd.Connection = myconnection.open
                    mycmd.CommandText = "INSERT INTO penjualan(id_barang, jumlah_barang, tanggal_jual)
                                            VALUES('" _
                                            & Txt_ID_Barang.Text & "', '" _
                                            & Txt_JumlahBarang.Text & "', '" _
                                            & Date_Jual.Value.ToString("yyyy/MM/dd") & "')"
                    mycmd.ExecuteNonQuery()
                    myconnection.close()
                    ResultDGV()
                    MsgBox("Data Penjualan tersimpan!", MsgBoxStyle.Information, "Pemberitahuan Tambah Penjualan")
                    'Else
                    '    MessageBox.Show("ID tidak tersedia dalam database", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            Catch ex As Exception

            End Try


        End Sub

        Private Sub Btn_UpdatePenjualan_Click(sender As Object, e As EventArgs) Handles Btn_UpdatePenjualan.Click

            '    'Jangan dibuka
            '    'Dim selectedBarang As List(Of String) = Barang.GetDataKoleksiByIDDatabase(selectedTableBarang)

            '    ''Dim ID As Integer = selectedBarang(0)
            '    'Barang.GSNamaBarangProperty = selectedBarang(1)
            '    'Barang.GSStockProperty = selectedBarang(2)
            '    'Barang.GShargaBarangProperty = selectedBarang(3)
            '    'Barang.GStanggalMasukBarangProperty = selectedBarang(4)
            '    'Barang.GStanggalkadaluarsaBarangProperty = selectedBarang(5)

            CheckID()

            mycmd.Connection = myconnection.open
            mycmd.CommandText = "UPDATE penjualan SET " &
                            “id_barang='" & Txt_ID_Barang.Text & "', " &
                            “jumlah_barang='" & Txt_JumlahBarang.Text & "', " &
                            “tanggal_jual='" & Date_Jual.Value.ToString("yyyy/MM/dd") & "' " &
                            "WHERE id_penjualan='" & id_penjualan & "' "
            mycmd.ExecuteNonQuery()
            myconnection.close()

            'Barang.UpdateDataBarangByIODatabase(id_barang, Txt_NamaBarang.Text, Txt_stock.Text, Txt_harga.Text, Date_Masuk.Value.ToString("yyyy/MM/dd"), Date_Kadaluarsa.Value.ToString("yyyy/MM/dd"))
            ResultDGV()
            MsgBox("Data terupdate !", MsgBoxStyle.Information, "Pemberitahuan")
        End Sub


        '     Update barang_masuk
        'SET barang_masuk.jumlah_barang_masuk = Txt_ID_Barang.Text + barang.stock

        'From barang_masuk  INNER Join barang On barang_masuk.id_barang_masuk = barang.id_barang

        Private Sub Btn_HapusPenjualan_Click(sender As Object, e As EventArgs) Handles Btn_HapusPenjualan.Click
            'Dim ID As Integer
            CheckID()

            mycmd.Connection = myconnection.open
            mycmd.CommandText = “DELETE FROM penjualan “ &
                           “WHERE id_penjualan='" & id_penjualan & "'"
            mycmd.ExecuteNonQuery()
            myconnection.close()
            ResultDGV()
            MsgBox("Data terhapus !", MsgBoxStyle.Information, "Pemberitahuan")
        End Sub

        Private Sub DGV_Barang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Penjualan.CellClick
            Dim DGVIndex As Integer
            Dim SelectedRow As DataGridViewRow
            SelectedRow = DGV_Penjualan.Rows(DGVIndex)

            With DGV_Penjualan
                If e.RowIndex >= 0 Then
                    DGVIndex = .CurrentRow.Index
                    Label1.Text = .Rows(DGVIndex).Cells(0).Value.ToString
                    id_penjualan = .Rows(DGVIndex).Cells(0).Value.ToString
                    Txt_ID_Barang.Text = .Rows(DGVIndex).Cells(1).Value.ToString
                    Txt_JumlahBarang.Text = .Rows(DGVIndex).Cells(2).Value.ToString
                    Date_Jual.Value = .Rows(DGVIndex).Cells(3).Value.ToString
                End If
            End With
        End Sub

        Private Sub TSMenu_FormJenisBarang_Click(sender As Object, e As EventArgs)
            Dim formJenis = New FormJenisBarang()
            formJenis.Show()
            Me.Close()
        End Sub




        Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
            MsgBox("Apakah anda yakin ingin keluar?", MessageBoxButtons.YesNo)
            Me.Close()
        End Sub

        Private Sub TSMenu_FormBarangMasuk_Click(sender As Object, e As EventArgs) Handles TSMenu_FormBarangMasuk.Click
            Dim formbarangmasuk = New FormBarangMasuk()
            formbarangmasuk.Show()
            Me.Close()
        End Sub


End Class