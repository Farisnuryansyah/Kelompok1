Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class inputabsensi
    Private videoSource As VideoCaptureDevice

    Private Sub inputabsensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtwaktu.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        Dim pilihan As DialogResult = MessageBox.Show(
            "Pilih sumber foto:" & vbCrLf & "Ya = Kamera" & vbCrLf & "No = Galeri",
            "Upload Foto",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
        )

        If pilihan = DialogResult.Yes Then
            Dim videoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
            If videoDevices.Count = 0 Then
                MessageBox.Show("Kamera tidak ditemukan.")
                Return
            End If

            videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
            AddHandler videoSource.NewFrame, AddressOf video_NewFrame
            videoSource.Start()
        ElseIf pilihan = DialogResult.No Then
            Dim ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(ofd.FileName)
                MessageBox.Show("Foto berhasil diupload.")
            End If
        End If
    End Sub

    Private Sub video_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        Dim bmp As Bitmap = CType(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = bmp
        videoSource.SignalToStop()
        videoSource = Nothing
        MessageBox.Show("Foto berhasil diupload.")
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Try
            bukaKoneksi()

            ' --- Konversi foto ke byte array ---
            Dim fotoBytes As Byte() = Nothing
            If PictureBox1.Image IsNot Nothing Then
                Using ms As New IO.MemoryStream()
                    PictureBox1.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                    fotoBytes = ms.ToArray()
                End Using
            End If

            ' --- Ambil nilai input ---
            Dim nama As String = txtnama.Text
            Dim nim As String = txtnim.Text
            Dim kelas As String = cbkelas.Text
            Dim prodi As String = cbprodi.Text
            Dim tanggal As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim waktu As String = DateTime.Now.ToString("HH:mm:ss")
            Dim matakuliah As String = cb_matakuliah.Text

            ' --- Cek apakah sudah absen masuk hari ini dan belum keluar ---
            Dim checkQuery As String = "SELECT * FROM tb_absensi WHERE nim=@nim AND tanggal=@tanggal AND jam_keluar IS NULL"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@nim", nim)
            checkCmd.Parameters.AddWithValue("@tanggal", tanggal)
            Dim dr As MySqlDataReader = checkCmd.ExecuteReader()

            If dr.HasRows Then
                ' --- Absen keluar (sudah ada record aktif) ---
                dr.Close()

                Dim updateQuery As String = "UPDATE tb_absensi SET jam_keluar=@jam_keluar WHERE nim=@nim AND tanggal=@tanggal AND jam_keluar IS NULL"
                Dim updateCmd As New MySqlCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("@jam_keluar", waktu)
                updateCmd.Parameters.AddWithValue("@nim", nim)
                updateCmd.Parameters.AddWithValue("@tanggal", tanggal)
                updateCmd.ExecuteNonQuery()

                ' --- Notifikasi sukses (Guna2) ---
                Dim msgKeluar As New Guna.UI2.WinForms.Guna2MessageDialog()
                msgKeluar.Buttons = MessageDialogButtons.OK
                msgKeluar.Icon = MessageDialogIcon.Information
                msgKeluar.Style = MessageDialogStyle.Light
                msgKeluar.Caption = "Absen Keluar"
                msgKeluar.Text = "✅ Absen keluar tercatat pada " & waktu & vbCrLf & "Kerja bagus hari ini!"
                msgKeluar.Parent = Me
                msgKeluar.Show()

            Else
                dr.Close()

                ' --- Cek apakah sudah pernah absen matkul ini hari ini ---
                Dim checkMatkulQuery As String = "SELECT * FROM tb_absensi WHERE nim=@nim AND tanggal=@tanggal AND matakuliah=@matakuliah"
                Dim checkMatkulCmd As New MySqlCommand(checkMatkulQuery, conn)
                checkMatkulCmd.Parameters.AddWithValue("@nim", nim)
                checkMatkulCmd.Parameters.AddWithValue("@tanggal", tanggal)
                checkMatkulCmd.Parameters.AddWithValue("@matakuliah", matakuliah)
                Dim drMatkul As MySqlDataReader = checkMatkulCmd.ExecuteReader()

                If drMatkul.HasRows Then
                    drMatkul.Close()

                    Dim msgSudah As New Guna.UI2.WinForms.Guna2MessageDialog()
                    msgSudah.Buttons = MessageDialogButtons.OK
                    msgSudah.Icon = MessageDialogIcon.Warning
                    msgSudah.Style = MessageDialogStyle.Light
                    msgSudah.Caption = "Sudah Absen"
                    msgSudah.Text = "Anda sudah absen untuk mata kuliah ini hari ini."
                    msgSudah.Parent = Me
                    msgSudah.Show()

                Else
                    drMatkul.Close()

                    ' --- Insert record baru (absen masuk matkul baru) ---
                    Dim insertQuery As String = "INSERT INTO tb_absensi (nama, nim, kelas, prodi, tanggal, waktu, jam_masuk, matakuliah, foto) VALUES (@nama, @nim, @kelas, @prodi, @tanggal, @waktu, @jam_masuk, @matakuliah, @foto)"
                    Dim insertCmd As New MySqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@nama", nama)
                    insertCmd.Parameters.AddWithValue("@nim", nim)
                    insertCmd.Parameters.AddWithValue("@kelas", kelas)
                    insertCmd.Parameters.AddWithValue("@prodi", prodi)
                    insertCmd.Parameters.AddWithValue("@tanggal", tanggal)
                    insertCmd.Parameters.AddWithValue("@waktu", waktu)
                    insertCmd.Parameters.AddWithValue("@jam_masuk", waktu)
                    insertCmd.Parameters.AddWithValue("@matakuliah", matakuliah)
                    insertCmd.Parameters.AddWithValue("@foto", fotoBytes)
                    insertCmd.ExecuteNonQuery()

                    ' --- Notifikasi sukses absen masuk ---
                    Dim msgMasuk As New Guna.UI2.WinForms.Guna2MessageDialog()
                    msgMasuk.Buttons = MessageDialogButtons.OK
                    msgMasuk.Icon = MessageDialogIcon.Information
                    msgMasuk.Style = MessageDialogStyle.Light
                    msgMasuk.Caption = "Absen Masuk"
                    msgMasuk.Text = "✅ Absen berhasil untuk mata kuliah: " & matakuliah & vbCrLf & "Waktu: " & waktu
                    msgMasuk.Parent = Me
                    msgMasuk.Show()
                End If
            End If

            conn.Close()

            Form1.Show()
            Me.Close()

        Catch ex As Exception
            ' --- Notifikasi error ---
            Dim msgError As New Guna.UI2.WinForms.Guna2MessageDialog()
            msgError.Buttons = MessageDialogButtons.OK
            msgError.Icon = MessageDialogIcon.Error
            msgError.Style = MessageDialogStyle.Light
            msgError.Caption = "Error"
            msgError.Text = "Gagal menyimpan data: " & ex.Message
            msgError.Parent = Me
            msgError.Show()
        End Try
    End Sub


    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        txtnama.Text = ""
        txtnim.Text = ""
        txtwaktu.Text = ""

        cbkelas.SelectedIndex = -1
        cbprodi.SelectedIndex = -1
        cb_matakuliah.SelectedIndex = -1


        DateTimePicker1.Value = DateTime.Now


        PictureBox1.Image = Nothing
    End Sub
End Class