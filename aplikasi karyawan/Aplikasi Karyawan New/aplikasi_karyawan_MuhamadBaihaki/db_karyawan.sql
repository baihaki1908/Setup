-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Nov 2019 pada 04.54
-- Versi server: 10.4.6-MariaDB
-- Versi PHP: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_karyawan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_absensi`
--

CREATE TABLE `t_absensi` (
  `id_absen` int(11) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `jam_masuk` time NOT NULL,
  `jam_kerja` time NOT NULL,
  `tgl_kerja` date NOT NULL,
  `jam_pulang` time NOT NULL,
  `telat_masuk` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_gaji`
--

CREATE TABLE `t_gaji` (
  `id_gaji` int(11) NOT NULL,
  `no_slip` varchar(15) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `tgl_gaji` date NOT NULL,
  `id_jabatan` int(2) NOT NULL,
  `nama_jabatan` varchar(45) NOT NULL,
  `gaji_pokok` decimal(8,0) NOT NULL,
  `tunjangan` decimal(8,0) NOT NULL,
  `uang_lembur` decimal(8,0) NOT NULL,
  `pot_bpjs_kes` decimal(8,0) NOT NULL,
  `pot_bpjs_ket` decimal(8,0) NOT NULL,
  `pot_lain2` decimal(8,0) NOT NULL,
  `no_rekening` varchar(40) NOT NULL,
  `nama_rekening` varchar(45) NOT NULL,
  `nama_bank` varchar(20) NOT NULL,
  `ttl_gaji` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_gaji`
--

INSERT INTO `t_gaji` (`id_gaji`, `no_slip`, `nik`, `tgl_gaji`, `id_jabatan`, `nama_jabatan`, `gaji_pokok`, `tunjangan`, `uang_lembur`, `pot_bpjs_kes`, `pot_bpjs_ket`, `pot_lain2`, `no_rekening`, `nama_rekening`, `nama_bank`, `ttl_gaji`) VALUES
(3232, 'slip01', '027827382', '2019-11-20', 1, 'Head Of', '5000000', '500000', '5000000', '400000', '400000', '400000', '903850385', 'udin', 'BRI', '5000000'),
(3233, 'Slip02', '0646446', '2019-11-20', 1, 'Head Of', '5000000', '500000', '300000', '500000', '500000', '200000', '07675565', 'Jack', 'BNI', '646446');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_jabatan`
--

CREATE TABLE `t_jabatan` (
  `id_jabatan` int(2) NOT NULL,
  `nama_jabatan` varchar(45) NOT NULL,
  `gaji_pokok` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_jabatan`
--

INSERT INTO `t_jabatan` (`id_jabatan`, `nama_jabatan`, `gaji_pokok`) VALUES
(1, 'Head Of', '5000000'),
(2, 'Head Of', '5000000'),
(9, 'Head Os', '99999999');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_karyawan`
--

CREATE TABLE `t_karyawan` (
  `nik` varchar(15) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tempat_lahir` varchar(20) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `agama` varchar(15) NOT NULL,
  `status` varchar(15) NOT NULL,
  `kewarganegaraan` varchar(3) NOT NULL,
  `no_hp` varchar(13) NOT NULL,
  `email` varchar(25) NOT NULL,
  `alamat` varchar(35) NOT NULL,
  `pendidikan_terakhir` varchar(4) NOT NULL,
  `pt_terakhir` varchar(50) NOT NULL,
  `jabatan` varchar(15) NOT NULL,
  `tgl_masuk` date NOT NULL,
  `bagian` varchar(20) NOT NULL,
  `gaji` varchar(10) NOT NULL,
  `status_karyawan` varchar(15) NOT NULL,
  `status_kerja` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_karyawan`
--

INSERT INTO `t_karyawan` (`nik`, `nama`, `tempat_lahir`, `tgl_lahir`, `agama`, `status`, `kewarganegaraan`, `no_hp`, `email`, `alamat`, `pendidikan_terakhir`, `pt_terakhir`, `jabatan`, `tgl_masuk`, `bagian`, `gaji`, `status_karyawan`, `status_kerja`) VALUES
('01', 'udin', 'plk', '2019-11-12', 'Islam', 'Kawin', 'WNI', '09768565', 'a@gmail.com', 'jln. maju', 'LP3I', 'S2', 'Head Of', '2019-11-12', 'Keuangan', '50000000', 'Tetap', 'Aktif'),
('02', 'Jack', 'palangkaraya', '2019-11-05', 'islam', 'kawin', 'WNI', '083726461728', 'jack@gmail.com', 'jln. maju-mundur', 'S2', 'LP3I', 'Head Of', '2019-11-19', 'Keuangan', '5000000', 'Kontrak', 'Aktif');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_lembur`
--

CREATE TABLE `t_lembur` (
  `id_lembur` int(10) NOT NULL,
  `nik` int(20) NOT NULL,
  `nama_karyawan` varchar(45) NOT NULL,
  `id_jabatan` int(2) NOT NULL,
  `tgl_lembur` date NOT NULL,
  `jml_jam_lembur` int(2) NOT NULL,
  `uang_lembur` decimal(8,0) NOT NULL,
  `ttl_uang_lembur` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_lembur`
--

INSERT INTO `t_lembur` (`id_lembur`, `nik`, `nama_karyawan`, `id_jabatan`, `tgl_lembur`, `jml_jam_lembur`, `uang_lembur`, `ttl_uang_lembur`) VALUES
(1, 1, 'Udin Laso', 9, '2019-11-15', 6, '300000', '300000'),
(2, 2, 'Jack', 2, '2019-11-21', 7, '500000', '500000');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `t_absensi`
--
ALTER TABLE `t_absensi`
  ADD PRIMARY KEY (`id_absen`);

--
-- Indeks untuk tabel `t_gaji`
--
ALTER TABLE `t_gaji`
  ADD PRIMARY KEY (`id_gaji`);

--
-- Indeks untuk tabel `t_jabatan`
--
ALTER TABLE `t_jabatan`
  ADD PRIMARY KEY (`id_jabatan`);

--
-- Indeks untuk tabel `t_karyawan`
--
ALTER TABLE `t_karyawan`
  ADD PRIMARY KEY (`nik`);

--
-- Indeks untuk tabel `t_lembur`
--
ALTER TABLE `t_lembur`
  ADD PRIMARY KEY (`id_lembur`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `t_absensi`
--
ALTER TABLE `t_absensi`
  MODIFY `id_absen` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `t_gaji`
--
ALTER TABLE `t_gaji`
  MODIFY `id_gaji` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3235;

--
-- AUTO_INCREMENT untuk tabel `t_jabatan`
--
ALTER TABLE `t_jabatan`
  MODIFY `id_jabatan` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT untuk tabel `t_lembur`
--
ALTER TABLE `t_lembur`
  MODIFY `id_lembur` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
