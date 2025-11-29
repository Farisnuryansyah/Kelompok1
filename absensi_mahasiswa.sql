-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2025 at 10:56 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `absensi_mahasiswa`
--

-- --------------------------------------------------------

--
-- Table structure for table `kehadiran`
--

CREATE TABLE `kehadiran` (
  `id` int(11) NOT NULL,
  `nim` varchar(15) NOT NULL,
  `mata_kuliah` varchar(50) NOT NULL,
  `status_kehadiran` varchar(20) NOT NULL,
  `waktu_absensi` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kehadiran`
--

INSERT INTO `kehadiran` (`id`, `nim`, `mata_kuliah`, `status_kehadiran`, `waktu_absensi`) VALUES
(1, '312310676', 'Pemograman Visual (Desktop)', 'Hadir', '2025-11-22 14:35:19'),
(2, '312310676', 'Big Data', 'Izin', '2025-11-22 14:40:15'),
(3, '312310676', 'Pemograman Visual (Desktop)', 'Izin', '2025-11-22 15:23:02'),
(4, '312310676', 'Pemograman Visual (Desktop)', 'Izin', '2025-11-22 16:00:06'),
(5, '312310724', 'Pemograman Visual (Desktop)', 'Izin', '2025-11-22 16:34:06');

-- --------------------------------------------------------

--
-- Table structure for table `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `nim` varchar(15) NOT NULL,
  `nama_mahasiswa` varchar(100) NOT NULL,
  `kelas` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `mahasiswa`
--

INSERT INTO `mahasiswa` (`nim`, `nama_mahasiswa`, `kelas`) VALUES
('312310656', 'MUHAMMAD RIZAL SATRIAWAN', 'TI.23.C.7'),
('312310676', 'RISKI SEPTIANTO', 'TI.23.C.7'),
('312310691', 'FARIS NURYANSYAH', 'TI.23.C.7'),
('312310724', 'MAHESA FATHIR MUHAMMAD', 'TI.23.C.7'),
('312310788', 'AHMAD RIFAI', 'TI.23.C.7');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kehadiran`
--
ALTER TABLE `kehadiran`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nim` (`nim`);

--
-- Indexes for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`nim`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `kehadiran`
--
ALTER TABLE `kehadiran`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `kehadiran`
--
ALTER TABLE `kehadiran`
  ADD CONSTRAINT `kehadiran_ibfk_1` FOREIGN KEY (`nim`) REFERENCES `mahasiswa` (`nim`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
