Public Class FormJenisBarang
    Private Sub BtnHapusJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnHapusJenisBarang.Click
        FormBarangMasuk.Show()
        Me.Close()
    End Sub
End Class