Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Public Class rekapabsensi

    Private Sub rekapabsensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        TampilkanData()
        With DataGridView1
            ' Biar kolom otomatis rapi
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Warna header
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 116, 166) ' biru elegan
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Baris selang-seling warna biar gak monoton
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 250)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(72, 149, 239)
            .DefaultCellStyle.SelectionForeColor = Color.White
            .GridColor = Color.FromArgb(200, 200, 200)
        End With

    End Sub

    ' --- tampilkan semua data ---
    Private Sub TampilkanData()
        Try
            Dim query As String = "SELECT nama, waktu, nim, kelas, prodi, jam_masuk, jam_keluar, tanggal, matakuliah FROM tb_absensi"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            da.Fill(ds, "rekap")
            DataGridView1.DataSource = ds.Tables("rekap")
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        End Try
    End Sub

    ' --- cari data berdasarkan NIM ---
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            bukaKoneksi()
            Dim nimCari As String = txtCariNIM.Text.Trim()

            If nimCari = "" Then
                MessageBox.Show("Masukkan NIM terlebih dahulu untuk mencari data.")
                Return
            End If

            Dim query As String = "SELECT nama, waktu, nim, kelas, prodi, jam_masuk, jam_keluar, tanggal, matakuliah FROM tb_absensi WHERE nim LIKE @nim"
            Dim da As New MySqlDataAdapter(query, conn)
            da.SelectCommand.Parameters.AddWithValue("@nim", "%" & nimCari & "%")

            Dim ds As New DataSet()
            da.Fill(ds, "hasil")

            If ds.Tables("hasil").Rows.Count > 0 Then
                DataGridView1.DataSource = ds.Tables("hasil")
            Else
                MessageBox.Show("Data dengan NIM tersebut tidak ditemukan.")
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mencari data: " & ex.Message)
        End Try
    End Sub

    ' --- clear filter (reset ke semua data) ---
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Kosongkan kotak pencarian
        txtCariNIM.Text = ""

        ' Pastikan ada baris yang dipilih
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih dulu data yang mau dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Konfirmasi sebelum hapus
        If MessageBox.Show("Yakin mau hapus data yang dipilih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bukaKoneksi()

                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    ' Ambil nilai NIM dari kolom ke-3 (index 2)
                    Dim nim = row.Cells(2).Value.ToString

                    ' Hapus dari database
                    Dim query = "DELETE FROM tb_absensi WHERE nim = @nim"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nim", nim)
                    cmd.ExecuteNonQuery()

                    ' Hapus juga dari DataGridView
                    DataGridView1.Rows.Remove(row)
                Next

                MessageBox.Show("Data yang dipilih berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exportExcel.Click
        Try
            ' Bikin instance Excel
            Dim xlApp As New Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add()
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = CType(xlWorkBook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

            ' Header kolom
            For col As Integer = 0 To DataGridView1.Columns.Count - 1
                xlWorkSheet.Cells(1, col + 1) = DataGridView1.Columns(col).HeaderText
            Next

            ' Data dari DataGridView
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                For j As Integer = 0 To DataGridView1.Columns.Count - 1
                    Dim value = DataGridView1.Rows(i).Cells(j).Value

                    ' Cegah error kalau ada nilai kosong atau tipe data aneh
                    If value Is Nothing OrElse IsDBNull(value) Then
                        xlWorkSheet.Cells(i + 2, j + 1) = ""
                    Else
                        xlWorkSheet.Cells(i + 2, j + 1) = value.ToString()
                    End If
                Next
            Next

            ' Simpan file Excel
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel Files|*.xlsx"
            saveDialog.Title = "Simpan Rekap Absensi"
            saveDialog.FileName = "Rekap_Absensi.xlsx"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                xlWorkBook.SaveAs(saveDialog.FileName)
                MessageBox.Show("Data berhasil diekspor ke Excel!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Tutup Excel
            xlWorkBook.Close()
            xlApp.Quit()

            ' Bersihkan object COM
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)

        Catch ex As Exception
            MessageBox.Show("Gagal mengekspor data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles buttonBack.Click
        ' Buka Form1
        Dim formUtama As New Form1()
        formUtama.Show()

        ' Tutup form rekapabsensi
        Me.Close()
    End Sub
End Class
