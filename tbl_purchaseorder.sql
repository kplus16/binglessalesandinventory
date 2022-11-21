-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Feb 13, 2017 at 07:08 AM
-- Server version: 5.5.24-log
-- PHP Version: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `binglessai`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchaseorder`
--

CREATE TABLE IF NOT EXISTS `tbl_purchaseorder` (
  `purchase_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_name` varchar(255) NOT NULL,
  `item_price` int(11) NOT NULL,
  `order_quantity` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `purchase_status` int(11) NOT NULL,
  `reservation_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`purchase_id`),
  KEY `reservation_id` (`reservation_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=42 ;

--
-- Dumping data for table `tbl_purchaseorder`
--

INSERT INTO `tbl_purchaseorder` (`purchase_id`, `item_name`, `item_price`, `order_quantity`, `total`, `purchase_status`, `reservation_id`) VALUES
(1, 'Chair', 900, 6, 5400, 0, 5),
(2, 'SSSSS', 10, 5, 50, 0, 5),
(3, 'QQQ', 20, 6, 120, 0, 5),
(4, 'Menudo', 90, 11, 990, 0, 7),
(5, 'SSSSS', 10, 6, 60, 0, 8),
(6, 'Chair', 900, 6, 5400, 0, 9),
(7, 'SSSSS', 10, 7, 70, 0, 9),
(8, 'THAT XX', 110, 16, 1760, 0, 9),
(9, 'SSSSS', 10, 5, 50, 0, 10),
(10, 'QQQ', 20, 7, 140, 0, 10),
(11, 'QQQ', 20, 8, 160, 0, 10),
(12, 'Chair', 900, 3, 2700, 0, 12),
(13, 'SSSSS', 10, 4, 40, 0, 12),
(14, 'QQQ', 20, 5, 100, 0, 12),
(16, 'QQQ', 20, 4, 80, 0, 13),
(17, 'SSSSS', 10, 4, 40, 0, 14),
(18, 'SSSSS', 10, 1, 10, 0, 15),
(19, 'QQQ', 20, 4, 80, 0, 15),
(20, 'THAT XX', 110, 6, 660, 0, 15),
(21, 'SSSSS', 10, 6, 60, 0, 16),
(23, 'QQQ', 20, 6, 120, 0, 17),
(25, 'Chair', 900, 5, 4500, 0, 18),
(26, 'SSSSS', 10, 6, 60, 0, 18),
(27, 'QQQ', 20, 11, 220, 0, 18),
(28, 'Chair', 900, 6, 5400, 0, 19),
(29, 'SSSSS', 10, 11, 110, 0, 19),
(30, 'QQQ', 20, 50, 1000, 0, 19),
(31, 'SSSSS', 10, 5, 50, 0, 20),
(32, 'Chair', 900, 5, 4500, 0, 21),
(33, 'SSSSS', 10, 6, 60, 0, 21),
(34, 'SSSSS', 10, 7, 70, 0, 21),
(35, 'SSSSS', 10, 5, 50, 0, 22),
(36, 'SSSSS', 10, 5, 50, 0, 23),
(37, 'Chair', 900, 10, 9000, 0, 23),
(38, 'YOUNGK', 316, 6, 1896, 0, 24),
(39, 'THAT XX', 110, 3, 330, 0, 25),
(40, 'THAT XX', 110, 3, 330, 0, 25),
(41, 'THAT XX', 110, 3, 330, 0, 26);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_purchaseorder`
--
ALTER TABLE `tbl_purchaseorder`
  ADD CONSTRAINT `tbl_purchaseorder_ibfk_1` FOREIGN KEY (`reservation_id`) REFERENCES `tbl_reservation` (`reservation_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
