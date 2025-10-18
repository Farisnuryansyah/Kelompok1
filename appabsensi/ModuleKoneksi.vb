Imports MySql.Data.MySqlClient
Module ModuleKoneksi

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    ' Fungsi untuk membuka koneksi ke MySQL
    Public Sub bukaKoneksi()
        Try
            Dim str As String = "server=localhost;user id=root;password=;database=db_absensi"
            conn = New MySqlConnection(str)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi ke database gagal: " & ex.Message)
        End Try
    End Sub

End Module
