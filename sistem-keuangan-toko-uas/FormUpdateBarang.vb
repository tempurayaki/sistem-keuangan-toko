Imports MySql.Data.MySqlClient

Public Class FormUpdateBarang
    Dim mycmd As New MySqlCommand
    Dim myconnection As New ClassBarang
    Dim dadapter As MySqlDataAdapter
    Dim dTabel As New DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormUpdateBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT id_jenis_barang FROM jenis_barang ORDER BY id_jenis_barang"
        dadapter = New MySqlDataAdapter(mycmd)

        dadapter.Fill(dTabel)
        CB_jenisbarang.DataSource = dTabel
        CB_jenisbarang.DisplayMember = "id_jenis_barang"
        CB_jenisbarang.ValueMember = "id_jenis_barang"


        CB_jenisbarang.SelectedValue = FormBarang.id_jenisbarang
        Txt_NamaBarang.Text = FormBarang.nama_barang
        Txt_stock.Text = FormBarang.stock
        Txt_harga.Text = FormBarang.harga
        Date_Masuk.Text = FormBarang.tanggal_masuk
        Date_Kadaluarsa.Text = FormBarang.tanggal_kadaluarsa
    End Sub

    Private Sub BtnUpdateBarang_Click(sender As Object, e As EventArgs) Handles BtnUpdateBarang.Click
        If Txt_NamaBarang.Text = "" Or Txt_stock.Text = "" Or Txt_harga.Text = "" Then
            MessageBox.Show("Pastikan semua Box terisi Datanya")
        Else
            Txt_harga.Text = FormatNumber(Txt_harga.Text, 2, TriState.True)
            Dim resultInput As DialogResult = MessageBox.Show("Apakah Input sudah benar?", "Pemberitahuan", MessageBoxButtons.YesNo)

            If resultInput = DialogResult.No Then
                Txt_harga.Text = Txt_harga.Text.Replace(".", String.Empty)
                MessageBox.Show("Update dibatalkan")
            ElseIf resultInput = DialogResult.Yes Then
                Txt_harga.Text = Txt_harga.Text.Replace(".", String.Empty)

                mycmd.CommandText = "UPDATE barang SET " &
                    "id_jenis_barang='" & CB_jenisbarang.SelectedValue & "', " &
                    "nama_barang='" & Txt_NamaBarang.Text & "', " &
                    "stock= '" & Txt_stock.Text & "', " &
                    "harga= IFNULL('" & Txt_harga.Text & "',0), " &
                    "tanggal_masuk='" & Date_Masuk.Value.ToString("yyyy/MM/dd") & "', " &
                    "tanggal_kadaluarsa='" & Date_Kadaluarsa.Value.ToString("yyyy/MM/dd") & "' " &
                    "WHERE id_barang ='" & FormBarang.id_barang & "' "
                mycmd.ExecuteNonQuery()
                myconnection.close()
                FormBarang.ResultDGV()
                FormBarang.Result_DGVStock()
                MsgBox("Data terupdate!", MsgBoxStyle.Information, "Pemberitahuan")

                Me.Close()
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class