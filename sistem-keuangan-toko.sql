-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.4.22-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for sistem-keuangan-toko
CREATE DATABASE IF NOT EXISTS `sistem-keuangan-toko` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `sistem-keuangan-toko`;

-- Dumping structure for table sistem-keuangan-toko.barang
CREATE TABLE IF NOT EXISTS `barang` (
  `id_barang` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `nama_barang` varchar(255) NOT NULL DEFAULT '0',
  `stock` int(255) unsigned NOT NULL DEFAULT 0,
  `harga` decimal(20,2) unsigned NOT NULL DEFAULT 0.00,
  `tanggal_masuk` date NOT NULL,
  `tanggal_kadaluarsa` date NOT NULL,
  PRIMARY KEY (`id_barang`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem-keuangan-toko.barang: ~0 rows (approximately)
/*!40000 ALTER TABLE `barang` DISABLE KEYS */;
/*!40000 ALTER TABLE `barang` ENABLE KEYS */;

-- Dumping structure for table sistem-keuangan-toko.barang_masuk
CREATE TABLE IF NOT EXISTS `barang_masuk` (
  `id_barang_masuk` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_barang` int(11) unsigned NOT NULL,
  `jumlah_barang_masuk` int(11) unsigned NOT NULL,
  `tanggal_barang_masuk` date NOT NULL,
  PRIMARY KEY (`id_barang_masuk`) USING BTREE,
  KEY `FK_barang_masuk_barang` (`id_barang`) USING BTREE,
  CONSTRAINT `FK_barang_masuk_barang` FOREIGN KEY (`id_barang`) REFERENCES `barang` (`id_barang`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem-keuangan-toko.barang_masuk: ~0 rows (approximately)
/*!40000 ALTER TABLE `barang_masuk` DISABLE KEYS */;
/*!40000 ALTER TABLE `barang_masuk` ENABLE KEYS */;

-- Dumping structure for table sistem-keuangan-toko.jenis_barang
CREATE TABLE IF NOT EXISTS `jenis_barang` (
  `id_jenis_barang` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `jenis_barang` varchar(255) NOT NULL,
  PRIMARY KEY (`id_jenis_barang`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem-keuangan-toko.jenis_barang: ~0 rows (approximately)
/*!40000 ALTER TABLE `jenis_barang` DISABLE KEYS */;
/*!40000 ALTER TABLE `jenis_barang` ENABLE KEYS */;

-- Dumping structure for table sistem-keuangan-toko.penjualan
CREATE TABLE IF NOT EXISTS `penjualan` (
  `id_penjualan` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `id_barang` int(20) unsigned NOT NULL,
  `jumlah_barang` int(20) unsigned NOT NULL DEFAULT 0,
  `tanggal_jual` date NOT NULL,
  PRIMARY KEY (`id_penjualan`) USING BTREE,
  KEY `FK_penjualan_barang` (`id_barang`) USING BTREE,
  CONSTRAINT `FK_penjualan_barang` FOREIGN KEY (`id_barang`) REFERENCES `barang` (`id_barang`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem-keuangan-toko.penjualan: ~0 rows (approximately)
/*!40000 ALTER TABLE `penjualan` DISABLE KEYS */;
/*!40000 ALTER TABLE `penjualan` ENABLE KEYS */;

-- Dumping structure for table sistem-keuangan-toko.users
CREATE TABLE IF NOT EXISTS `users` (
  `id_user` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(100) NOT NULL,
  PRIMARY KEY (`id_user`) USING BTREE,
  UNIQUE KEY `username` (`username`) USING BTREE,
  UNIQUE KEY `email` (`email`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem-keuangan-toko.users: ~0 rows (approximately)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
