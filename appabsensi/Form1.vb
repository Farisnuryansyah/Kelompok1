Public Class Form1

    Private Sub btnAbsensi_Click(sender As Object, e As EventArgs) Handles btnAbsensi.Click
        Dim frmInput As New inputabsensi()
        frmInput.ShowDialog() ' Menampilkan form inputabsensi sebagai dialog
    End Sub

    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
        Dim frmRekap As New rekapabsensi()
        frmRekap.ShowDialog() ' Menampilkan form rekapabsensi sebagai dialog
    End Sub
End Class
