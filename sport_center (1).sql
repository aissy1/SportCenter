-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 26, 2023 at 02:00 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sport center`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `Id` int(11) NOT NULL,
  `NamaAdmin` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `Password` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Id`, `NamaAdmin`, `username`, `Password`) VALUES
(1, 'rafifrais', 'admin01', 'admin01'),
(2, 'Andin', 'admin02', 'admin02'),
(3, 'Anton', 'admin03', 'admin03');

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `KodeBarang` varchar(10) NOT NULL,
  `JenisBarang` varchar(20) NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `Kondisi` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`KodeBarang`, `JenisBarang`, `Jumlah`, `Kondisi`) VALUES
('1A', 'shuttlecock', 18, 'Bagus'),
('1B', 'Raket', 5, 'Bagus');

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

CREATE TABLE `booking` (
  `KodeBooking` int(8) NOT NULL,
  `Nama` varchar(25) NOT NULL,
  `KodeLapangan` varchar(5) NOT NULL,
  `Waktu` datetime NOT NULL,
  `TanggalMain` date NOT NULL,
  `WaktuMain` time NOT NULL,
  `WaktuSelesai` datetime NOT NULL,
  `Tarif` int(10) NOT NULL,
  `Durasi` double NOT NULL,
  `Bayar` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `booking`
--

INSERT INTO `booking` (`KodeBooking`, `Nama`, `KodeLapangan`, `Waktu`, `TanggalMain`, `WaktuMain`, `WaktuSelesai`, `Tarif`, `Durasi`, `Bayar`) VALUES
(3, 'harcy', '1A', '2023-11-03 22:58:36', '2023-10-24', '11:00:00', '2023-10-24 14:00:00', 120000, 3, 'Lunas'),
(8, 'Budi', '1A', '2023-10-31 00:37:51', '2023-10-28', '10:00:00', '2023-10-28 02:37:35', 80000, 2, 'Lunas'),
(9, 'rehan', '1A', '2023-10-31 00:41:25', '2023-10-27', '00:00:00', '2023-10-27 01:40:57', 40000, 1, 'Lunas'),
(10, 'rendy', '1A', '2023-10-31 09:02:39', '2023-10-31', '20:00:00', '2023-10-31 11:01:39', 80000, 2, 'Lunas'),
(11, 'Randi', '1A', '2023-11-03 22:06:31', '2023-11-02', '10:00:00', '2023-11-03 00:05:49', 80000, 2, 'Lunas'),
(18, 'saip', '1A', '2023-11-03 22:43:48', '2023-11-03', '10:00:00', '2023-11-03 12:00:00', 80000, 2, 'Lunas'),
(19, 'andi', '1A', '2023-11-03 23:23:17', '2023-11-03', '11:00:00', '2023-11-03 13:00:00', 80000, 2, 'Lunas'),
(22, 'bisma', '1A', '2023-11-03 23:35:57', '2023-11-03', '11:00:00', '2023-11-03 13:00:00', 80000, 2, 'Lunas');

-- --------------------------------------------------------

--
-- Table structure for table `jadwal`
--

CREATE TABLE `jadwal` (
  `kodeJadwal` int(4) NOT NULL,
  `KodeLapangan` varchar(4) NOT NULL,
  `TanggalMain` date NOT NULL,
  `WaktuMain` time NOT NULL,
  `WaktuSelesai` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `jadwal`
--

INSERT INTO `jadwal` (`kodeJadwal`, `KodeLapangan`, `TanggalMain`, `WaktuMain`, `WaktuSelesai`) VALUES
(3, '1A', '2023-10-24', '11:00:00', '2023-10-24 14:00:00'),
(8, '1A', '2023-10-28', '10:00:00', '2023-10-28 02:37:35'),
(9, '1A', '2023-10-27', '00:00:00', '2023-10-27 01:40:57'),
(10, '1A', '2023-10-31', '20:00:00', '2023-10-31 11:01:39'),
(11, '1A', '2023-11-02', '10:00:00', '2023-11-03 00:05:49'),
(18, '1A', '2023-11-03', '10:00:00', '2023-11-03 12:00:00'),
(19, '1A', '2023-11-03', '11:00:00', '2023-11-03 13:00:00'),
(22, '1A', '2023-11-03', '11:00:00', '2023-11-03 13:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `lapangan`
--

CREATE TABLE `lapangan` (
  `Id` int(5) NOT NULL,
  `KodeLapangan` varchar(3) NOT NULL,
  `JenisLapangan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lapangan`
--

INSERT INTO `lapangan` (`Id`, `KodeLapangan`, `JenisLapangan`) VALUES
(1, '1A', 'Badminton'),
(2, '1B', 'Badminton'),
(3, '2A', 'Futsal'),
(4, '2B', 'Futsal'),
(6, '1C', 'Badminton');

-- --------------------------------------------------------

--
-- Table structure for table `lokasi`
--

CREATE TABLE `lokasi` (
  `id` int(11) NOT NULL,
  `KodeLapangan` varchar(5) NOT NULL,
  `JenisLapangan` varchar(20) NOT NULL,
  `Lokasi` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lokasi`
--

INSERT INTO `lokasi` (`id`, `KodeLapangan`, `JenisLapangan`, `Lokasi`) VALUES
(1, '1A', 'Badminton', 'Jl. Dharmahusada Indah Barat III No.64-66, Mojo, Kec. Gubeng, Surabaya, Jawa Timu'),
(2, '2A', 'Futsal', 'Hockey');

-- --------------------------------------------------------

--
-- Table structure for table `pegawai`
--

CREATE TABLE `pegawai` (
  `IdPegawai` int(11) NOT NULL,
  `NamaPegawai` varchar(50) NOT NULL,
  `Umur` varchar(2) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `jabatan` varchar(10) NOT NULL,
  `NoHandphone` varchar(15) DEFAULT NULL,
  `Password` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pegawai`
--

INSERT INTO `pegawai` (`IdPegawai`, `NamaPegawai`, `Umur`, `Alamat`, `jabatan`, `NoHandphone`, `Password`) VALUES
(1, 'rais', '20', 'Jl Ambengan Batu 4/34', 'Admin', '082173687755', 'rais853'),
(2, 'Rehan', '21', 'Jl Pegangsangan timur 3/24', 'Pegawai', '082155677823', 'Rehan123'),
(3, 'Andin', '22', 'Jl Opak 1/14', 'Admin', '081234362231', 'andini1'),
(4, 'Anton', '19', 'Jl Anyar 2/33', 'Admin', '081268093425', 'Antoni23');

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `IdMember` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `NamaMember` varchar(100) NOT NULL,
  `umur` int(3) NOT NULL,
  `Alamat` varchar(100) NOT NULL,
  `NoHandphone` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`IdMember`, `email`, `NamaMember`, `umur`, `Alamat`, `NoHandphone`) VALUES
(1, 'harcy11@gmail.com', 'harcy', 20, 'Jl peneleh', '082123419976'),
(3, 'budisento22@gmail.com', 'Budi Setiawan', 20, 'JL Krembangan', '089235673377');

-- --------------------------------------------------------

--
-- Table structure for table `sewa`
--

CREATE TABLE `sewa` (
  `Id` int(11) NOT NULL,
  `Penyewa` varchar(25) NOT NULL,
  `JenisBarang` varchar(25) NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `Status` varchar(15) NOT NULL,
  `Waktu` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sewa`
--

INSERT INTO `sewa` (`Id`, `Penyewa`, `JenisBarang`, `Jumlah`, `Status`, `Waktu`) VALUES
(1, 'harcy', 'shuttlecock', 2, 'Dipinjam', '2023-10-15 00:55:10'),
(6, 'Budi', 'Raket', 2, 'Dikembalikan', '2023-10-15 22:53:08'),
(21, 'rais', 'Raket', 2, 'Dikembalikan', '2023-11-06 18:19:48');

-- --------------------------------------------------------

--
-- Table structure for table `tarif`
--

CREATE TABLE `tarif` (
  `id` int(5) NOT NULL,
  `KodeLapangan` varchar(2) NOT NULL,
  `JenisLapangan` varchar(20) NOT NULL,
  `TarifUmum` int(10) NOT NULL,
  `TarifSpesial` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tarif`
--

INSERT INTO `tarif` (`id`, `KodeLapangan`, `JenisLapangan`, `TarifUmum`, `TarifSpesial`) VALUES
(1, '1A', 'Badminton', 40000, 60000),
(2, '2A', 'Futsal', 30000, 50000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`KodeBarang`);

--
-- Indexes for table `booking`
--
ALTER TABLE `booking`
  ADD PRIMARY KEY (`KodeBooking`);

--
-- Indexes for table `jadwal`
--
ALTER TABLE `jadwal`
  ADD PRIMARY KEY (`kodeJadwal`);

--
-- Indexes for table `lapangan`
--
ALTER TABLE `lapangan`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `lokasi`
--
ALTER TABLE `lokasi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD PRIMARY KEY (`IdPegawai`);

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`IdMember`);

--
-- Indexes for table `sewa`
--
ALTER TABLE `sewa`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tarif`
--
ALTER TABLE `tarif`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `booking`
--
ALTER TABLE `booking`
  MODIFY `KodeBooking` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `lapangan`
--
ALTER TABLE `lapangan`
  MODIFY `Id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `lokasi`
--
ALTER TABLE `lokasi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `pegawai`
--
ALTER TABLE `pegawai`
  MODIFY `IdPegawai` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `pelanggan`
--
ALTER TABLE `pelanggan`
  MODIFY `IdMember` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `sewa`
--
ALTER TABLE `sewa`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `tarif`
--
ALTER TABLE `tarif`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
