Imports MySql.Data.MySqlClient
Public Class FormUpdatePenjualan
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
        mycmd.CommandText = "SELECT id_barang FROM barang ORDER BY id_barang"
        dadapter = New MySqlDataAdapter(mycmd)

        dadapter.Fill(dTabel)
        CB_namabarang.DataSource = dTabel
        CB_namabarang.DisplayMember = "id_barang"
        CB_namabarang.ValueMember = "id_barang"
        If CB_namabarang.Items.Count > 0 Then
            CB_namabarang.Text = "Pilih ID Barang"
        End If

        CB_namabarang.SelectedValue = FormPenjualan.id_barang_jual
        Txt_JumlahBarang.Text = FormPenjualan.jml_barang
        Date_Jual.Text = FormPenjualan.tgl_jual

    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        If Txt_JumlahBarang.Text = "" Then
            MessageBox.Show("Pastikan semua Box terisi Datanya")
        Else
            Dim resultInput As DialogResult = MessageBox.Show("Apakah Input sudah benar?", "Pemberitahuan", MessageBoxButtons.YesNo)

            If resultInput = DialogResult.No Then
                MessageBox.Show("Update dibatalkan")
            ElseIf resultInput = DialogResult.Yes Then

                mycmd.CommandText = "UPDATE penjualan SET " &
                    "id_barang='" & CB_namabarang.SelectedValue & "', " &
                    "jumlah_barang='" & Txt_JumlahBarang.Text & "', " &
                    "tanggal_jual='" & Date_Jual.Value.ToString("yyyy/MM/dd") & "' " &
                    "WHERE id_penjualan ='" & FormPenjualan.id_penjualan & "' "
                mycmd.ExecuteNonQuery()
                myconnection.close()
                FormBarang.ResultDGV()
                MsgBox("Data terupdate !", MsgBoxStyle.Information, "Pemberitahuan")

                Me.Close()
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class