# APP ABSENSI MAHASISWA 

## Pendahuluan
Aplikasi **App Absensi Mahasiswa** dikembangkan menggunakan bahasa pemrograman **Visual Basic .NET** dengan tujuan untuk membantu proses pencatatan kehadiran mahasiswa secara digital.  
Sistem ini dirancang agar mudah digunakan oleh dosen maupun operator administrasi, serta dapat menghasilkan laporan rekap absensi secara otomatis dalam bentuk file Excel.  

Proyek ini dibuat sebagai bentuk implementasi pembelajaran pemrograman berbasis desktop di lingkungan akademik, dengan mengedepankan aspek kemudahan, efisiensi, dan tampilan antarmuka yang modern.

---

## Latar Belakang
Proses absensi manual masih umum digunakan di banyak kampus dan sekolah. Metode tersebut memiliki beberapa kelemahan seperti:
- Data rawan hilang atau rusak
- Proses rekap membutuhkan waktu lama
- Sulit melakukan analisis kehadiran

Melihat kondisi tersebut, aplikasi ini hadir sebagai solusi sederhana yang dapat mempercepat dan mempermudah kegiatan absensi.  
Dengan tampilan futuristik berwarna neon biru, aplikasi ini tidak hanya fungsional tetapi juga memberikan pengalaman visual yang menarik bagi pengguna.

---

## Tujuan Pengembangan
1. Membangun sistem absensi yang mudah digunakan dan efisien.  
2. Mengotomatiskan proses rekap data kehadiran.  
3. Mempermudah ekspor data ke dalam format Excel.  
4. Memberikan contoh nyata implementasi pemrograman Visual Basic dalam dunia pendidikan.  
5. Menjadi dasar untuk pengembangan sistem absensi yang lebih besar dan terintegrasi.

---

## Fitur Utama
1. **Form Input Absensi**  
   Pengguna dapat memasukkan data kehadiran mahasiswa secara langsung melalui antarmuka yang sederhana.  
2. **Rekap Otomatis**  
   Sistem akan otomatis menghitung jumlah kehadiran dan ketidakhadiran berdasarkan input yang diberikan.  
3. **Ekspor ke Excel**  
   Data absensi dapat diekspor menjadi file Excel untuk keperluan laporan.  
4. **Tampilan Modern**  
   Desain menggunakan tema futuristik dengan warna dominan biru dan efek cahaya neon.  
5. **Struktur Modular**  
   Setiap form memiliki tanggung jawab spesifik agar mudah dikelola dan dikembangkan lebih lanjut.  

---

## Teknologi yang Digunakan
- **Bahasa Pemrograman:** Visual Basic .NET  
- **IDE:** Microsoft Visual Studio 2022  
- **Framework:** .NET 8.0  
- **Database:** MySQL (opsional untuk pengembangan lanjut)  
- **Library Tambahan:** Microsoft.Office.Interop.Excel  

---

## Struktur Proyek
- Form1.vb // Halaman utama (Welcome Screen)
- inputabsensi.vb // Form input data kehadiran
- rekapabsensi.vb // Form rekap data absensi
- resources/ // Folder berisi gambar, ikon, dan background
- regis_process.vb // Script pemrosesan pendaftaran akun
- techstore.mdb // Database lokal (jika digunakan)
- README.md // Dokumentasi proyek

---

## Desain Antarmuka
Tampilan aplikasi mengusung konsep futuristik dengan perpaduan warna biru dan hitam yang kontras.  
Elemen-elemen utama seperti tombol, teks, dan ikon dibuat tegas agar tetap jelas saat dijalankan dalam mode layar penuh.

Beberapa elemen visual penting:
- Logo profil di tengah layar  
- Teks “SELAMAT DATANG” dengan efek tebal dan warna putih terang  
- Latar belakang berupa pola garis bercahaya yang dinamis  

---

## Alur Penggunaan
1. Jalankan aplikasi dari file `.sln` menggunakan Visual Studio.  
2. Form utama akan menampilkan halaman sambutan dengan tampilan futuristik.  
3. Navigasikan ke form input absensi untuk mengisi data kehadiran.  
4. Setelah selesai, buka form rekap untuk melihat hasil rekapitulasi.  
5. Tekan tombol **Ekspor ke Excel** untuk menyimpan hasil rekap ke file `.xlsx`.

---

## Pengujian dan Validasi
Selama proses pengujian, aplikasi diuji pada beberapa perangkat dengan sistem operasi **Windows 10 dan Windows 11**.  
Fokus pengujian meliputi:
- Fungsi input data
- Kebenaran hasil rekap
- Proses ekspor ke Excel
- Stabilitas tampilan saat layar diperbesar

Hasil pengujian menunjukkan bahwa seluruh fungsi utama berjalan sesuai harapan, dengan waktu rekap rata-rata di bawah 2 detik untuk 100 data.

---

## Rencana Pengembangan
- Menambahkan fitur login dosen dan mahasiswa  
- Menghubungkan sistem ke database MySQL secara online  
- Menambahkan sistem deteksi lokasi (absensi berbasis GPS)  
- Membuat dashboard analitik untuk statistik kehadiran  
- Mengintegrasikan dengan sistem akademik kampus  

---

## Tim Pengembang
| Nama | Tugas |
|------|--------|
| **Faris Nuryansyah** | Project Manager |
| **Ahmad Rifai** | Backend |
| **Riski Septianto** | Frontend |
| **Mahesa Fatir** | Frontend |
| **M.Rizal Satriawan** | Helper Front & Backend |

---

## Kesimpulan
Aplikasi **App Absensi Mahasiswa** merupakan langkah awal menuju digitalisasi proses kehadiran di lingkungan kampus.  
Dengan fitur rekap otomatis dan desain yang modern, sistem ini diharapkan dapat meningkatkan efisiensi administrasi akademik.  
Struktur modular dan bahasa yang digunakan juga memungkinkan aplikasi ini dikembangkan lebih lanjut menjadi sistem absensi berbasis jaringan atau mobile di masa mendatang.

---

## Lisensi
Proyek ini bersifat **open source** dan dapat digunakan untuk kepentingan pembelajaran maupun pengembangan lebih lanjut, selama tetap mencantumkan kredit kepada pengembang asli.

