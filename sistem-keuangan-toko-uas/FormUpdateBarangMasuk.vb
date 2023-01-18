Imports System.Data
Imports MySql.Data.MySqlClient

Public Class FormUpdateBarangMasuk
    Dim mycmd As New MySqlCommand
    Dim myconnection As New ClassBarangMasuk
    Dim dadapter As MySqlDataAdapter
    Dim dTabel As New DataTable



    Public id As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub FormUpdateBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT id_barang FROM barang ORDER BY id_barang"
        dadapter = New MySqlDataAdapter(mycmd)

        dadapter.Fill(dTabel)
        CB_namabarang.DataSource = dTabel
        CB_namabarang.DisplayMember = "id_barang"
        CB_namabarang.ValueMember = "id_barang"

        CB_namabarang.SelectedValue = FormBarangMasuk.id_barang_bm
        Txt_JmlBrg.Text = FormBarangMasuk.jml_brg
        Date_Masuk.Text = FormBarangMasuk.tgl_masuk
    End Sub



    Private Sub BtnUpdateBarangMasuk_Click(sender As Object, e As EventArgs) Handles BtnUpdateBarangMasuk.Click
        If Txt_JmlBrg.Text = "" Then
            MessageBox.Show("Pastikan semua Box terisi Datanya")
        Else
            Dim resultInput As DialogResult = MessageBox.Show("Apakah Input sudah benar?", "Pemberitahuan", MessageBoxButtons.YesNo)

            If resultInput = DialogResult.No Then
                MessageBox.Show("Update dibatalkan")
            ElseIf resultInput = DialogResult.Yes Then

                Try
                    mycmd.CommandText = "UPDATE barang_masuk SET " &
                           "id_barang='" & CB_namabarang.SelectedValue & "', " &
                           "jumlah_barang_masuk='" & Txt_JmlBrg.Text & "', " &
                           "tanggal_barang_masuk='" & Date_Masuk.Value.ToString("yyyy/MM/dd") & "' " &
                           "WHERE id_barang_masuk='" & FormBarangMasuk.id_barang_masuk & "' "
                    mycmd.ExecuteNonQuery()
                    myconnection.close()
                    FormBarangMasuk.ResultDGV()
                    MsgBox("Data terupdate!", MsgBoxStyle.Information, "Pemberitahuan")
                Catch ex As Exception
                    MessageBox.Show("Error")
                End Try

                Me.Close()

            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class