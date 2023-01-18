Public Class FormUpdateJenisBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtUpdateJenisBarang.Text = FormJenisBarang.jenisbarang.namaJenisBarangProperty

    End Sub

    Private Sub BtnUpdateJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnUpdateJenisBarang.Click

        FormJenisBarang.jenisbarang.namaJenisBarangProperty = TxtUpdateJenisBarang.Text.ToString()

        FormJenisBarang.jenisbarang.UpdateDataJenisBarangByIDDatabase(FormJenisBarang.selectedTableJenisBarang,
                                                                      FormJenisBarang.jenisbarang.namaJenisBarangProperty)

        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdateJenisBarang_Click_1(sender As Object, e As EventArgs) Handles BtnUpdateJenisBarang.Click

    End Sub
End Class