-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 23, 2017 at 07:01 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `binglessai`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `IDNo` int(11) NOT NULL,
  `fullName` varchar(50) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `status` varchar(10) NOT NULL,
  `TYPE` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`IDNo`, `fullName`, `username`, `password`, `status`, `TYPE`) VALUES
(3, 'Mabelle Estrella', 'admin', 'pIbvhgmpVHahDBTYUgQvew==', 'ACTIVE', 'ADMIN'),
(4, 'Song Jongki', 'user1', 'Ao5ZnFYo344iWqv/Jr9euw==', 'ACTIVE', 'USER');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_archive`
--

CREATE TABLE `tbl_archive` (
  `archive` int(11) NOT NULL,
  `customer_name` varchar(30) NOT NULL,
  `event_name` varchar(50) NOT NULL,
  `date_needed` date NOT NULL,
  `time_needed` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_catering`
--

CREATE TABLE `tbl_catering` (
  `CateringID` int(11) NOT NULL,
  `Viand` varchar(100) NOT NULL,
  `Description` text NOT NULL,
  `Price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_catering`
--

INSERT INTO `tbl_catering` (`CateringID`, `Viand`, `Description`, `Price`) VALUES
(1, 'Beef Caldereta', 'Good for 20-23 pax', '1000.00'),
(2, 'Fish ''n Chips', 'Good for 20-23 pax', '1000.00'),
(3, 'Beef Casserole', 'Good for 20-23 pax', '1500.00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_dummy`
--

CREATE TABLE `tbl_dummy` (
  `customer_name` varchar(50) NOT NULL,
  `event_address` text NOT NULL,
  `datenow` varchar(15) NOT NULL,
  `order_quantity` int(11) NOT NULL,
  `item_name` varchar(100) NOT NULL,
  `item_price` decimal(10,2) NOT NULL,
  `total` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_dummy`
--

INSERT INTO `tbl_dummy` (`customer_name`, `event_address`, `datenow`, `order_quantity`, `item_name`, `item_price`, `total`) VALUES
('Sheila Young', 'Davao', '03-21-2017', 9, 'Adult Chair', '20.00', '180.00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_inventoryitem`
--

CREATE TABLE `tbl_inventoryitem` (
  `ItemCode` int(11) NOT NULL,
  `ItemName` varchar(50) NOT NULL,
  `ItemDescription` varchar(200) NOT NULL,
  `ItemStock` int(11) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `ItemPrice` decimal(10,2) NOT NULL,
  `itemCategory` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_inventoryitem`
--

INSERT INTO `tbl_inventoryitem` (`ItemCode`, `ItemName`, `ItemDescription`, `ItemStock`, `SupplierID`, `ItemPrice`, `itemCategory`) VALUES
(1, 'Adult Chair', 'Adult Chair', -9, 0, '20.00', 'RENTAL'),
(2, 'Adult Table', 'Adult Table', 243, 0, '50.00', 'RENTAL'),
(3, 'Table Cloth', 'Table Cloth', 0, 0, '10.00', 'RENTAL'),
(4, 'Kiddie Chair', 'Kiddie Chair', 50, 5, '20.00', 'RENTAL'),
(5, 'Kiddie Table', 'Kiddie Table', 40, 5, '50.00', 'RENTAL'),
(6, 'Round Table', 'Round Table', 40, 4, '100.00', 'RENTAL'),
(7, 'Chair Cover', 'Chair Cover', 300, 5, '25.00', 'RENTAL'),
(8, 'Chair Ribbon', 'Chair Ribbon', 292, 1, '30.00', 'RENTAL'),
(9, 'Balloon', 'Flying', 239, 1, '40.00', 'SELLING'),
(10, 'Party Hats', 'Party Hats', 6, 1, '20.00', 'SELLING');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_logs`
--

CREATE TABLE `tbl_logs` (
  `LogsID` int(11) NOT NULL,
  `fullName` varchar(30) NOT NULL,
  `username` varchar(20) NOT NULL,
  `date` varchar(15) NOT NULL,
  `time` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_logs`
--

INSERT INTO `tbl_logs` (`LogsID`, `fullName`, `username`, `date`, `time`) VALUES
(1, 'Michael Estrella', 'admin', '02-17-2017', '12:09:00'),
(2, 'Michael Estrella', 'admin', '02-17-2017', '12:13:45'),
(3, 'Michael Estrella', 'admin', '02-17-2017', '12:16:02'),
(4, 'Michael Estrella', 'admin', '02-17-2017', '12:16:40'),
(5, 'Michael Estrella', 'admin', '02-17-2017', '12:18:14'),
(6, 'Michael Estrella', 'admin', '02-17-2017', '12:20:12'),
(7, 'Michael Estrella', 'admin', '02-17-2017', '12:20:56'),
(8, 'Michael Estrella', 'admin', '02-17-2017', '12:21:47'),
(9, 'Michael Estrella', 'admin', '02-17-2017', '12:22:56'),
(10, 'Michael Estrella', 'admin', '02-17-2017', '01:04:24'),
(11, 'Michael Estrella', 'admin', '02-17-2017', '01:10:30'),
(12, 'Michael Estrella', 'admin', '02-17-2017', '01:13:13'),
(13, 'Michael Estrella', 'admin', '02-17-2017', '01:19:17'),
(14, 'Michael Estrella', 'admin', '02-17-2017', '01:25:28'),
(15, 'Michael Estrella', 'admin', '02-17-2017', '01:27:16'),
(16, 'Michael Estrella', 'admin', '02-17-2017', '01:35:29'),
(17, 'Michael Estrella', 'admin', '02-17-2017', '01:41:13'),
(18, 'Michael Estrella', 'admin', '02-17-2017', '01:45:30'),
(19, 'Michael Estrella', 'admin', '02-17-2017', '01:55:21'),
(20, 'Michael Estrella', 'admin', '02-17-2017', '02:06:20'),
(21, 'Michael Estrella', 'admin', '02-17-2017', '02:39:00'),
(22, 'Michael Estrella', 'admin', '02-17-2017', '02:42:33'),
(23, 'Michael Estrella', 'admin', '02-17-2017', '02:45:00'),
(24, 'Michael Estrella', 'admin', '02-17-2017', '01:30:44'),
(25, 'Mabelle Estrella', 'admin', '02-17-2017', '01:33:31'),
(26, 'Mabelle Estrella', 'admin', '02-17-2017', '01:35:04'),
(27, 'Mabelle Estrella', 'admin', '02-17-2017', '01:43:40'),
(28, 'Mabelle Estrella', 'admin', '02-17-2017', '02:00:01'),
(29, 'Mabelle Estrella', 'admin', '02-17-2017', '02:03:09'),
(30, 'Mabelle Estrella', 'admin', '02-17-2017', '02:04:10'),
(31, 'Mabelle Estrella', 'admin', '02-17-2017', '02:06:50'),
(32, 'Mabelle Estrella', 'admin', '02-17-2017', '02:08:44'),
(33, 'Mabelle Estrella', 'admin', '02-17-2017', '02:12:03'),
(34, 'Mabelle Estrella', 'admin', '02-17-2017', '02:16:56'),
(35, 'Mabelle Estrella', 'admin', '02-17-2017', '02:20:17'),
(36, 'Mabelle Estrella', 'admin', '02-17-2017', '03:35:28'),
(37, 'Mabelle Estrella', 'admin', '02-17-2017', '03:38:23'),
(38, 'Mabelle Estrella', 'admin', '02-17-2017', '03:39:53'),
(39, 'Mabelle Estrella', 'admin', '02-17-2017', '04:48:01'),
(40, 'Mabelle Estrella', 'admin', '02-17-2017', '04:50:05'),
(41, 'Mabelle Estrella', 'admin', '02-17-2017', '04:50:53'),
(42, 'Mabelle Estrella', 'admin', '02-17-2017', '04:51:40'),
(43, 'Mabelle Estrella', 'admin', '02-17-2017', '04:53:29'),
(44, 'Mabelle Estrella', 'admin', '02-17-2017', '04:54:20'),
(45, 'Mabelle Estrella', 'admin', '02-17-2017', '07:23:01'),
(46, 'Mabelle Estrella', 'admin', '02-17-2017', '07:27:00'),
(47, 'Mabelle Estrella', 'admin', '02-17-2017', '07:30:23'),
(48, 'Mabelle Estrella', 'admin', '02-17-2017', '07:34:24'),
(49, 'Mabelle Estrella', 'admin', '02-17-2017', '07:39:46'),
(50, 'Mabelle Estrella', 'admin', '02-19-2017', '07:46:12'),
(51, 'Mabelle Estrella', 'admin', '02-17-2017', '10:38:25'),
(52, 'Mabelle Estrella', 'admin', '02-17-2017', '10:40:55'),
(53, 'Mabelle Estrella', 'admin', '02-17-2017', '10:48:44'),
(54, 'Mabelle Estrella', 'admin', '02-18-2017', '06:41:02'),
(55, 'Mabelle Estrella', 'admin', '02-18-2017', '06:47:54'),
(56, 'Mabelle Estrella', 'admin', '02-18-2017', '06:55:20'),
(57, 'Mabelle Estrella', 'admin', '02-18-2017', '06:58:01'),
(58, 'Mabelle Estrella', 'admin', '02-18-2017', '07:54:28'),
(59, 'Mabelle Estrella', 'admin', '02-18-2017', '08:09:46'),
(60, 'Mabelle Estrella', 'admin', '02-22-2017', '04:21:01'),
(61, 'Mabelle Estrella', 'admin', '02-25-2017', '11:45:29'),
(62, 'Mabelle Estrella', 'admin', '02-25-2017', '05:37:30'),
(63, 'Mabelle Estrella', 'admin', '02-25-2017', '05:41:53'),
(64, 'Mabelle Estrella', 'admin', '02-25-2017', '05:48:26'),
(65, 'Mabelle Estrella', 'admin', '02-25-2017', '05:55:44'),
(66, 'Mabelle Estrella', 'admin', '02-25-2017', '06:00:16'),
(67, 'Mabelle Estrella', 'admin', '02-25-2017', '06:06:04'),
(68, 'Mabelle Estrella', 'admin', '02-25-2017', '07:12:03'),
(69, 'Mabelle Estrella', 'admin', '02-25-2017', '07:16:39'),
(70, 'Mabelle Estrella', 'admin', '02-25-2017', '07:20:45'),
(71, 'Mabelle Estrella', 'admin', '02-25-2017', '07:22:31'),
(72, 'Mabelle Estrella', 'admin', '02-25-2017', '07:24:07'),
(73, 'Mabelle Estrella', 'admin', '02-25-2017', '07:24:51'),
(74, 'Mabelle Estrella', 'admin', '02-25-2017', '07:48:35'),
(75, 'Mabelle Estrella', 'admin', '02-25-2017', '07:59:19'),
(76, 'Mabelle Estrella', 'admin', '02-25-2017', '08:15:06'),
(77, 'Mabelle Estrella', 'admin', '02-25-2017', '08:18:50'),
(78, 'Mabelle Estrella', 'admin', '02-25-2017', '08:20:01'),
(79, 'Mabelle Estrella', 'admin', '02-25-2017', '08:24:40'),
(80, 'Mabelle Estrella', 'admin', '02-25-2017', '08:37:40'),
(81, 'Mabelle Estrella', 'admin', '02-25-2017', '08:41:08'),
(82, 'Mabelle Estrella', 'admin', '02-25-2017', '08:51:58'),
(83, 'Mabelle Estrella', 'admin', '02-25-2017', '08:59:01'),
(84, 'Mabelle Estrella', 'admin', '02-25-2017', '09:06:41'),
(85, 'Mabelle Estrella', 'admin', '02-25-2017', '09:25:53'),
(86, 'Mabelle Estrella', 'admin', '02-25-2017', '09:28:29'),
(87, 'Mabelle Estrella', 'admin', '02-25-2017', '09:33:49'),
(88, 'Mabelle Estrella', 'admin', '02-25-2017', '09:38:34'),
(89, 'Mabelle Estrella', 'admin', '02-25-2017', '09:43:16'),
(90, 'Mabelle Estrella', 'admin', '02-25-2017', '09:52:23'),
(91, 'Mabelle Estrella', 'admin', '02-25-2017', '10:32:14'),
(92, 'Mabelle Estrella', 'admin', '02-25-2017', '10:42:37'),
(93, 'Mabelle Estrella', 'admin', '02-25-2017', '10:44:30'),
(94, 'Mabelle Estrella', 'admin', '02-25-2017', '10:49:54'),
(95, 'Mabelle Estrella', 'admin', '02-25-2017', '10:52:37'),
(96, 'Mabelle Estrella', 'admin', '02-25-2017', '10:54:49'),
(97, 'Mabelle Estrella', 'admin', '02-25-2017', '11:00:33'),
(98, 'Mabelle Estrella', 'admin', '02-25-2017', '11:03:36'),
(99, 'Mabelle Estrella', 'admin', '02-25-2017', '11:11:44'),
(100, 'Mabelle Estrella', 'admin', '02-25-2017', '11:13:33'),
(101, 'Mabelle Estrella', 'admin', '02-25-2017', '11:14:52'),
(102, 'Mabelle Estrella', 'admin', '02-25-2017', '11:16:14'),
(103, 'Mabelle Estrella', 'admin', '02-25-2017', '11:26:28'),
(104, 'Mabelle Estrella', 'admin', '02-25-2017', '11:29:12'),
(105, 'Mabelle Estrella', 'admin', '02-25-2017', '11:31:03'),
(106, 'Mabelle Estrella', 'admin', '02-25-2017', '11:35:13'),
(107, 'Mabelle Estrella', 'admin', '02-25-2017', '11:37:18'),
(108, 'Mabelle Estrella', 'admin', '02-25-2017', '11:38:41'),
(109, 'Mabelle Estrella', 'admin', '02-25-2017', '11:47:37'),
(110, 'Mabelle Estrella', 'admin', '02-26-2017', '12:48:45'),
(111, 'Mabelle Estrella', 'admin', '02-26-2017', '01:02:24'),
(112, 'Mabelle Estrella', 'admin', '02-26-2017', '01:11:29'),
(113, 'Mabelle Estrella', 'admin', '02-26-2017', '01:14:28'),
(114, 'Mabelle Estrella', 'admin', '02-26-2017', '01:23:10'),
(115, 'Mabelle Estrella', 'admin', '02-26-2017', '01:26:54'),
(116, 'Mabelle Estrella', 'admin', '02-26-2017', '01:28:13'),
(117, 'Mabelle Estrella', 'admin', '02-26-2017', '01:43:49'),
(118, 'Mabelle Estrella', 'admin', '02-26-2017', '01:47:35'),
(119, 'Mabelle Estrella', 'admin', '02-26-2017', '01:48:54'),
(120, 'Song Jongki', 'user1', '02-26-2017', '01:52:50'),
(121, 'Song Jongki', 'user1', '02-26-2017', '02:00:20'),
(122, 'Mabelle Estrella', 'admin', '03-12-2017', '12:44:44'),
(123, 'Mabelle Estrella', 'admin', '03-12-2017', '01:20:23'),
(124, 'Mabelle Estrella', 'admin', '03-12-2017', '01:35:55'),
(125, 'Mabelle Estrella', 'admin', '03-12-2017', '04:38:57'),
(126, 'Mabelle Estrella', 'admin', '03-14-2017', '12:54:14'),
(127, 'Mabelle Estrella', 'admin', '03-14-2017', '01:06:33'),
(128, 'Mabelle Estrella', 'admin', '03-14-2017', '01:12:24'),
(129, 'Mabelle Estrella', 'admin', '03-14-2017', '04:14:01'),
(130, 'Mabelle Estrella', 'admin', '03-14-2017', '04:44:55'),
(131, 'Mabelle Estrella', 'admin', '03-14-2017', '04:46:07'),
(132, 'Mabelle Estrella', 'admin', '03-15-2017', '04:46:28'),
(133, 'Mabelle Estrella', 'admin', '03-16-2017', '02:04:15'),
(134, 'Mabelle Estrella', 'admin', '03-16-2017', '02:18:44'),
(135, 'Mabelle Estrella', 'admin', '03-16-2017', '02:22:50'),
(136, 'Mabelle Estrella', 'admin', '03-16-2017', '02:58:35'),
(137, 'Mabelle Estrella', 'admin', '03-16-2017', '03:27:18'),
(138, 'Mabelle Estrella', 'admin', '03-16-2017', '03:42:54'),
(139, 'Mabelle Estrella', 'admin', '03-16-2017', '03:44:19'),
(140, 'Mabelle Estrella', 'admin', '03-16-2017', '04:09:58'),
(141, 'Mabelle Estrella', 'admin', '03-16-2017', '04:33:31'),
(142, 'Mabelle Estrella', 'admin', '03-16-2017', '04:48:03'),
(143, 'Mabelle Estrella', 'admin', '03-16-2017', '04:51:45'),
(144, 'Mabelle Estrella', 'admin', '03-16-2017', '02:50:14'),
(145, 'Mabelle Estrella', 'admin', '03-16-2017', '04:20:16'),
(146, 'Mabelle Estrella', 'admin', '03-16-2017', '04:25:15'),
(147, 'Mabelle Estrella', 'admin', '03-16-2017', '04:30:04'),
(148, 'Mabelle Estrella', 'admin', '03-16-2017', '04:34:37'),
(149, 'Mabelle Estrella', 'admin', '03-16-2017', '05:26:58'),
(150, 'Mabelle Estrella', 'admin', '03-16-2017', '05:29:03'),
(151, 'Mabelle Estrella', 'admin', '03-16-2017', '05:33:23'),
(152, 'Mabelle Estrella', 'admin', '03-16-2017', '05:38:19'),
(153, 'Mabelle Estrella', 'admin', '03-16-2017', '05:43:38'),
(154, 'Mabelle Estrella', 'admin', '03-16-2017', '05:45:40'),
(155, 'Mabelle Estrella', 'admin', '03-16-2017', '05:47:13'),
(156, 'Mabelle Estrella', 'admin', '03-16-2017', '05:49:09'),
(157, 'Mabelle Estrella', 'admin', '03-16-2017', '05:52:14'),
(158, 'Mabelle Estrella', 'admin', '03-16-2017', '05:54:17'),
(159, 'Mabelle Estrella', 'admin', '03-16-2017', '05:55:15'),
(160, 'Mabelle Estrella', 'admin', '03-16-2017', '05:57:18'),
(161, 'Mabelle Estrella', 'admin', '03-16-2017', '06:11:48'),
(162, 'Mabelle Estrella', 'admin', '03-16-2017', '06:13:20'),
(163, 'Mabelle Estrella', 'admin', '03-16-2017', '06:14:45'),
(164, 'Mabelle Estrella', 'admin', '03-16-2017', '06:15:58'),
(165, 'Mabelle Estrella', 'admin', '03-16-2017', '06:21:51'),
(166, 'Mabelle Estrella', 'admin', '03-16-2017', '06:23:40'),
(167, 'Mabelle Estrella', 'admin', '03-16-2017', '06:27:18'),
(168, 'Mabelle Estrella', 'admin', '03-17-2017', '06:15:01'),
(169, 'Mabelle Estrella', 'admin', '03-18-2017', '12:33:36'),
(170, 'Mabelle Estrella', 'admin', '03-18-2017', '12:52:47'),
(171, 'Mabelle Estrella', 'admin', '03-18-2017', '01:58:16'),
(172, 'Mabelle Estrella', 'admin', '03-18-2017', '02:03:32'),
(173, 'Mabelle Estrella', 'admin', '03-18-2017', '02:13:48'),
(174, 'Mabelle Estrella', 'admin', '03-18-2017', '02:16:32'),
(175, 'Mabelle Estrella', 'admin', '03-18-2017', '02:19:15'),
(176, 'Mabelle Estrella', 'admin', '03-18-2017', '02:20:54'),
(177, 'Mabelle Estrella', 'admin', '03-18-2017', '02:23:46'),
(178, 'Mabelle Estrella', 'admin', '03-18-2017', '03:03:45'),
(179, 'Mabelle Estrella', 'admin', '03-18-2017', '03:07:17'),
(180, 'Mabelle Estrella', 'admin', '03-18-2017', '03:10:15'),
(181, 'Mabelle Estrella', 'admin', '03-18-2017', '03:11:32'),
(182, 'Mabelle Estrella', 'admin', '03-18-2017', '03:16:08'),
(183, 'Mabelle Estrella', 'admin', '03-18-2017', '03:19:59'),
(184, 'Mabelle Estrella', 'admin', '03-18-2017', '03:53:23'),
(185, 'Mabelle Estrella', 'admin', '03-18-2017', '04:02:46'),
(186, 'Mabelle Estrella', 'admin', '03-18-2017', '04:14:36'),
(187, 'Mabelle Estrella', 'admin', '03-18-2017', '04:18:17'),
(188, 'Mabelle Estrella', 'admin', '03-18-2017', '04:22:05'),
(189, 'Mabelle Estrella', 'admin', '03-18-2017', '04:22:49'),
(190, 'Mabelle Estrella', 'admin', '03-18-2017', '04:26:12'),
(191, 'Mabelle Estrella', 'admin', '03-18-2017', '04:27:44'),
(192, 'Mabelle Estrella', 'admin', '03-18-2017', '04:28:37'),
(193, 'Mabelle Estrella', 'admin', '03-18-2017', '05:19:11'),
(194, 'Mabelle Estrella', 'admin', '03-18-2017', '05:30:11'),
(195, 'Mabelle Estrella', 'admin', '03-18-2017', '05:34:32'),
(196, 'Mabelle Estrella', 'admin', '03-18-2017', '05:36:28'),
(197, 'Mabelle Estrella', 'admin', '03-18-2017', '05:38:57'),
(198, 'Mabelle Estrella', 'admin', '03-18-2017', '05:41:34'),
(199, 'Mabelle Estrella', 'admin', '03-18-2017', '05:47:52'),
(200, 'Mabelle Estrella', 'admin', '03-18-2017', '06:06:17'),
(201, 'Mabelle Estrella', 'admin', '03-18-2017', '06:12:54'),
(202, 'Mabelle Estrella', 'admin', '03-18-2017', '06:16:51'),
(203, 'Mabelle Estrella', 'admin', '03-18-2017', '06:18:25'),
(204, 'Mabelle Estrella', 'admin', '03-18-2017', '06:19:47'),
(205, 'Mabelle Estrella', 'admin', '03-18-2017', '06:20:48'),
(206, 'Mabelle Estrella', 'admin', '03-18-2017', '06:22:51'),
(207, 'Mabelle Estrella', 'admin', '03-18-2017', '09:26:31'),
(208, 'Mabelle Estrella', 'admin', '03-18-2017', '09:43:26'),
(209, 'Mabelle Estrella', 'admin', '03-18-2017', '09:58:46'),
(210, 'Mabelle Estrella', 'admin', '03-18-2017', '10:00:19'),
(211, 'Mabelle Estrella', 'admin', '03-18-2017', '10:06:10'),
(212, 'Mabelle Estrella', 'admin', '03-18-2017', '10:07:48'),
(213, 'Mabelle Estrella', 'admin', '03-18-2017', '10:22:15'),
(214, 'Mabelle Estrella', 'admin', '03-18-2017', '10:24:24'),
(215, 'Mabelle Estrella', 'admin', '03-18-2017', '10:26:16'),
(216, 'Mabelle Estrella', 'admin', '03-18-2017', '10:30:38'),
(217, 'Mabelle Estrella', 'admin', '03-18-2017', '10:32:51'),
(218, 'Mabelle Estrella', 'admin', '03-18-2017', '10:34:43'),
(219, 'Mabelle Estrella', 'admin', '03-18-2017', '10:50:39'),
(220, 'Mabelle Estrella', 'admin', '03-18-2017', '10:52:01'),
(221, 'Mabelle Estrella', 'admin', '03-18-2017', '10:56:49'),
(222, 'Mabelle Estrella', 'admin', '03-18-2017', '11:04:53'),
(223, 'Mabelle Estrella', 'admin', '03-20-2017', '02:01:36'),
(224, 'Mabelle Estrella', 'admin', '03-20-2017', '02:18:01'),
(225, 'Mabelle Estrella', 'admin', '03-20-2017', '02:20:35'),
(226, 'Mabelle Estrella', 'admin', '03-20-2017', '04:15:28'),
(227, 'Mabelle Estrella', 'admin', '03-20-2017', '04:26:40'),
(228, 'Mabelle Estrella', 'admin', '03-20-2017', '04:31:01'),
(229, 'Mabelle Estrella', 'admin', '03-20-2017', '04:38:37'),
(230, 'Mabelle Estrella', 'admin', '03-20-2017', '10:52:04'),
(231, 'Mabelle Estrella', 'admin', '03-20-2017', '11:22:00'),
(232, 'Mabelle Estrella', 'admin', '03-20-2017', '11:25:28'),
(233, 'Mabelle Estrella', 'admin', '03-20-2017', '11:28:56'),
(234, 'Mabelle Estrella', 'admin', '03-20-2017', '11:40:44'),
(235, 'Mabelle Estrella', 'admin', '03-20-2017', '11:47:59'),
(236, 'Mabelle Estrella', 'admin', '03-20-2017', '11:51:36'),
(237, 'Mabelle Estrella', 'admin', '03-20-2017', '11:52:49'),
(238, 'Mabelle Estrella', 'admin', '03-20-2017', '11:55:41'),
(239, 'Mabelle Estrella', 'admin', '03-20-2017', '11:59:20'),
(240, 'Mabelle Estrella', 'admin', '03-21-2017', '12:03:51'),
(241, 'Mabelle Estrella', 'admin', '03-21-2017', '12:32:11'),
(242, 'Mabelle Estrella', 'admin', '03-21-2017', '12:46:21'),
(243, 'Mabelle Estrella', 'admin', '03-21-2017', '12:50:23'),
(244, 'Mabelle Estrella', 'admin', '03-21-2017', '12:59:08'),
(245, 'Mabelle Estrella', 'admin', '03-21-2017', '01:02:35'),
(246, 'Mabelle Estrella', 'admin', '03-21-2017', '09:44:14'),
(247, 'Mabelle Estrella', 'admin', '03-21-2017', '09:49:14'),
(248, 'Mabelle Estrella', 'admin', '03-21-2017', '09:51:11'),
(249, 'Mabelle Estrella', 'admin', '03-21-2017', '10:00:23'),
(250, 'Mabelle Estrella', 'admin', '03-21-2017', '10:09:26'),
(251, 'Mabelle Estrella', 'admin', '03-21-2017', '10:20:34'),
(252, 'Mabelle Estrella', 'admin', '03-21-2017', '10:21:33'),
(253, 'Mabelle Estrella', 'admin', '03-21-2017', '10:24:52'),
(254, 'Mabelle Estrella', 'admin', '03-21-2017', '10:30:58'),
(255, 'Mabelle Estrella', 'admin', '03-21-2017', '10:34:42'),
(256, 'Mabelle Estrella', 'admin', '03-21-2017', '10:36:55'),
(257, 'Mabelle Estrella', 'admin', '03-21-2017', '10:38:11'),
(258, 'Mabelle Estrella', 'admin', '03-21-2017', '10:39:00'),
(259, 'Mabelle Estrella', 'admin', '03-21-2017', '10:42:41'),
(260, 'Mabelle Estrella', 'admin', '03-21-2017', '10:45:44'),
(261, 'Mabelle Estrella', 'admin', '03-21-2017', '10:48:34'),
(262, 'Mabelle Estrella', 'admin', '03-21-2017', '10:49:37'),
(263, 'Mabelle Estrella', 'admin', '03-21-2017', '10:50:10'),
(264, 'Mabelle Estrella', 'admin', '03-21-2017', '10:50:49'),
(265, 'Mabelle Estrella', 'admin', '03-21-2017', '10:52:17'),
(266, 'Mabelle Estrella', 'admin', '03-21-2017', '10:59:04'),
(267, 'Mabelle Estrella', 'admin', '03-21-2017', '11:13:47'),
(268, 'Mabelle Estrella', 'admin', '03-21-2017', '11:16:15'),
(269, 'Mabelle Estrella', 'admin', '03-21-2017', '11:19:38'),
(270, 'Mabelle Estrella', 'admin', '03-21-2017', '11:45:31');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_logsactivity`
--

CREATE TABLE `tbl_logsactivity` (
  `LogsID` int(11) NOT NULL,
  `LogsActivity` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_logsactivity`
--

INSERT INTO `tbl_logsactivity` (`LogsID`, `LogsActivity`) VALUES
(1, 'Adds a reservation'),
(1, 'Process an order'),
(1, 'Updates an item'),
(1, 'Updates a viand'),
(1, 'Updates a service'),
(2, 'Updates a supplier'),
(2, 'Updates a service'),
(3, 'Updates a service'),
(4, 'Updates a service'),
(5, 'Updates a service'),
(6, 'Updates a service'),
(7, 'Updates a service'),
(8, 'Updates a service'),
(10, 'Adds a reservation'),
(11, 'Adds a reservation'),
(12, 'Adds a reservation'),
(13, 'Adds a reservation'),
(14, 'Adds a reservation'),
(15, 'Adds a reservation'),
(16, 'Adds a reservation'),
(17, 'Adds a reservation'),
(18, 'Adds a reservation'),
(19, 'Adds a reservation'),
(20, 'Adds a reservation'),
(26, 'Updates an item'),
(33, 'Adds a reservation'),
(34, 'Adds a reservation'),
(34, 'Process an order'),
(35, 'Adds a reservation'),
(35, 'Process an order'),
(38, 'Adds a reservation'),
(38, 'Process an order'),
(38, 'Adds a reservation'),
(38, 'Process an order'),
(49, 'Adds a reservation'),
(49, 'Process an order'),
(49, 'Adds a reservation'),
(49, 'Process an order'),
(50, 'Adds a reservation'),
(50, 'Process an order'),
(51, 'Adds a reservation'),
(51, 'Process an order'),
(53, 'Adds a reservation'),
(53, 'Process an order'),
(53, 'Adds a reservation'),
(54, 'Adds an item'),
(55, 'Adds an item'),
(55, 'Adds an item'),
(62, 'Adds a reservation'),
(62, 'Process an order'),
(63, 'Adds a reservation'),
(63, 'Process an order'),
(64, 'Adds a reservation'),
(64, 'Process an order'),
(65, 'Adds a reservation'),
(65, 'Process an order'),
(68, 'Adds a reservation'),
(68, 'Process an order'),
(74, 'Adds a reservation'),
(74, 'Process an order'),
(75, 'Adds a reservation'),
(75, 'Process an order'),
(76, 'Adds a reservation'),
(76, 'Process an order'),
(79, 'Adds a reservation'),
(80, 'Adds a reservation'),
(81, 'Adds a reservation'),
(82, 'Adds a reservation'),
(83, 'Adds a reservation'),
(83, 'Process an order'),
(84, 'Adds a reservation'),
(84, 'Process an order'),
(90, 'Adds an item'),
(90, 'Adds an item'),
(90, 'Adds an item'),
(90, 'Adds an item'),
(90, 'Adds an item'),
(90, 'Adds an item'),
(90, 'Adds an item'),
(90, 'Adds an item'),
(90, 'Adds an item'),
(90, 'Adds an item'),
(91, 'Adds a reservation'),
(91, 'Process an order'),
(114, 'Adds a reservation'),
(114, 'Process an order'),
(123, 'Adds a reservation'),
(123, 'Process an order'),
(124, 'Adds a reservation'),
(125, 'Adds a reservation'),
(125, 'Process an order'),
(126, 'Adds a reservation'),
(127, 'Adds a reservation'),
(127, 'Process an order'),
(128, 'Adds a reservation'),
(128, 'Process an order'),
(149, 'Adds a reservation'),
(149, 'Process an order'),
(150, 'Adds a reservation'),
(150, 'Process an order'),
(151, 'Adds a reservation'),
(151, 'Process an order'),
(152, 'Adds a reservation'),
(152, 'Process an order'),
(153, 'Adds a reservation'),
(153, 'Process an order'),
(154, 'Adds a reservation'),
(154, 'Process an order'),
(155, 'Adds a reservation'),
(155, 'Process an order'),
(156, 'Adds a reservation'),
(156, 'Process an order'),
(157, 'Adds a reservation'),
(157, 'Process an order'),
(158, 'Adds a reservation'),
(158, 'Process an order'),
(159, 'Adds a reservation'),
(159, 'Process an order'),
(160, 'Adds a reservation'),
(160, 'Process an order'),
(161, 'Adds a reservation'),
(161, 'Process an order'),
(162, 'Adds a reservation'),
(162, 'Process an order'),
(163, 'Adds a reservation'),
(163, 'Process an order'),
(164, 'Adds a reservation'),
(164, 'Process an order'),
(165, 'Adds a reservation'),
(165, 'Process an order'),
(166, 'Adds a reservation'),
(166, 'Process an order'),
(167, 'Adds a reservation'),
(167, 'Process an order'),
(168, 'Adds a reservation'),
(168, 'Process an order'),
(170, 'Adds a reservation'),
(178, 'Adds a reservation'),
(179, 'Adds a reservation'),
(180, 'Adds a reservation'),
(181, 'Adds a reservation'),
(181, 'Process an order'),
(182, 'Adds a reservation'),
(182, 'Process an order'),
(183, 'Adds a reservation'),
(183, 'Process an order'),
(184, 'Adds a reservation'),
(184, 'Process an order'),
(210, 'Adds a reservation'),
(210, 'Process an order'),
(221, 'Adds a reservation'),
(221, 'Process an order'),
(221, 'Updates an item'),
(222, 'Adds a reservation'),
(222, 'Process an order'),
(224, 'Adds a reservation'),
(225, 'Adds a reservation'),
(228, 'Adds a reservation'),
(228, 'Process an order'),
(228, 'Adds a reservation'),
(228, 'Process an order'),
(234, 'Adds a reservation'),
(234, 'Process an order'),
(235, 'Adds a reservation'),
(235, 'Process an order'),
(236, 'Adds a reservation'),
(236, 'Process an order'),
(237, 'Adds a reservation'),
(237, 'Process an order'),
(238, 'Adds a reservation'),
(238, 'Process an order'),
(239, 'Adds a reservation'),
(239, 'Process an order'),
(240, 'Adds a reservation'),
(240, 'Process an order'),
(240, 'Adds a reservation'),
(240, 'Process an order'),
(249, 'Adds a reservation'),
(249, 'Process an order'),
(249, 'Updates an item'),
(249, 'Updates an item'),
(253, 'Adds a reservation'),
(253, 'Process an order'),
(266, 'Adds a reservation'),
(266, 'Process an order'),
(266, 'Adds a reservation'),
(266, 'Process an order'),
(266, 'Adds a reservation'),
(266, 'Process an order'),
(266, 'Adds a reservation'),
(266, 'Process an order'),
(270, 'Adds a reservation'),
(270, 'Process an order'),
(270, 'Adds a reservation'),
(270, 'Process an order'),
(270, 'Adds a reservation'),
(270, 'Process an order'),
(270, 'Adds a reservation'),
(270, 'Process an order'),
(270, 'Adds a reservation'),
(270, 'Process an order'),
(270, 'Adds a reservation'),
(270, 'Process an order');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_payment`
--

CREATE TABLE `tbl_payment` (
  `reservation_id` int(11) NOT NULL,
  `customer_name` varchar(100) NOT NULL,
  `amountDue` decimal(10,2) NOT NULL,
  `payment` decimal(10,2) NOT NULL,
  `balance` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_payment`
--

INSERT INTO `tbl_payment` (`reservation_id`, `customer_name`, `amountDue`, `payment`, `balance`) VALUES
(1, 'Jeremy Lin', '6050.00', '6050.00', '0.00'),
(2, 'Nikko Nemenzo', '800.00', '400.00', '400.00'),
(3, 'Kyle Jaham', '3750.00', '1000.00', '2750.00'),
(4, 'Nikko Nemenzo', '4500.00', '4500.00', '0.00'),
(5, 'Jeremy Lin', '1000.00', '1000.00', '0.00'),
(6, 'Gordon Ramsay', '3000.00', '3000.00', '0.00'),
(7, 'Sheila Young', '6000.00', '500.00', '5500.00'),
(8, 'Kendrick Mundiz', '4500.00', '500.00', '4000.00'),
(9, 'Juan Dela Cruz', '6500.00', '500.00', '6000.00'),
(10, 'Nikko Nemenzo', '12680.00', '12680.00', '0.00'),
(11, 'Duterte', '1500.00', '1500.00', '0.00'),
(12, 'Sheila Young', '180.00', '180.00', '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchaseorder`
--

CREATE TABLE `tbl_purchaseorder` (
  `purchase_id` int(11) NOT NULL,
  `item_name` varchar(255) NOT NULL,
  `item_price` decimal(10,2) NOT NULL,
  `order_quantity` int(11) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `purchase_status` int(11) NOT NULL,
  `reservation_id` int(11) DEFAULT NULL,
  `rental` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_purchaseorder`
--

INSERT INTO `tbl_purchaseorder` (`purchase_id`, `item_name`, `item_price`, `order_quantity`, `total`, `purchase_status`, `reservation_id`, `rental`) VALUES
(2, 'Fish ''n Chips', '1000.00', 1, '1000.00', 0, 1, 0),
(3, 'Fish ''n Chips', '1000.00', 1, '1000.00', 0, 1, 0),
(4, 'Table Cloth', '10.00', 5, '50.00', 0, 1, 1),
(6, 'Adult Table', '50.00', 0, '600.00', 0, 2, 1),
(7, 'Adult Table', '50.00', 5, '250.00', 0, 3, 1),
(8, 'Beef Caldereta', '1000.00', 1, '1000.00', 0, 3, 0),
(9, 'Beef Caldereta', '1000.00', 1, '1000.00', 0, 3, 0),
(10, 'Fish ''n Chips', '1000.00', 1, '1000.00', 0, 4, 0),
(11, 'Bubble Show', '2500.00', 1, '2500.00', 0, 4, 0),
(12, 'Beef Caldereta', '1000.00', 1, '1000.00', 0, 5, 0),
(13, 'Fish ''n Chips', '1000.00', 1, '1000.00', 0, 6, 0),
(14, 'Beef Caldereta', '1000.00', 1, '1000.00', 0, 6, 0),
(15, 'Bubble Show', '2500.00', 1, '2500.00', 0, 7, 0),
(16, 'Fish ''n Chips', '1000.00', 1, '1000.00', 0, 7, 0),
(17, 'Fish ''n Chips', '1000.00', 1, '1000.00', 0, 8, 0),
(18, 'Bubble Show', '2500.00', 1, '2500.00', 0, 8, 0),
(19, 'Beef Caldereta', '1000.00', 1, '1000.00', 0, 9, 0),
(20, 'Fish ''n Chips', '1000.00', 1, '1000.00', 0, 9, 0),
(21, 'Beef Casserole', '1500.00', 1, '1500.00', 0, 9, 0),
(22, 'Adult Chair', '20.00', 192, '3840.00', 0, 10, 1),
(23, 'Kiddie Chair', '20.00', 250, '5000.00', 0, 10, 1),
(24, 'Table Cloth', '10.00', 150, '1500.00', 0, 11, 1),
(25, 'Adult Chair', '20.00', 9, '180.00', 0, 12, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_reservation`
--

CREATE TABLE `tbl_reservation` (
  `reservation_id` int(11) NOT NULL,
  `customer_name` varchar(255) NOT NULL,
  `event_name` varchar(255) NOT NULL,
  `event_address` text NOT NULL,
  `date_needed` date NOT NULL,
  `time_needed` varchar(255) NOT NULL,
  `reservation_status` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_reservation`
--

INSERT INTO `tbl_reservation` (`reservation_id`, `customer_name`, `event_name`, `event_address`, `date_needed`, `time_needed`, `reservation_status`) VALUES
(1, 'Jeremy Lin', 'Linsanity Party', 'Brooklyn, New york', '2017-03-22', '10:00:24 AM', 0),
(2, 'Nikko Nemenzo', 'Sweet 16', 'Agdao, DC', '2017-03-23', '10:24:53 AM', 1),
(3, 'Kyle Jaham', 'Birthday', 'Matina', '2017-03-21', '10:59:05 AM', 1),
(4, 'Nikko Nemenzo', 'Birthday', 'Agdao', '2017-03-30', '10:59:05 AM', 1),
(5, 'Jeremy Lin', 'Trade Party', 'Brooklyn', '2017-03-25', '10:59:05 AM', 1),
(6, 'Gordon Ramsay', 'Michelin', 'London', '2017-03-23', '10:59:05 AM', 1),
(7, 'Sheila Young', 'Birthday', 'Talomo', '2017-03-23', '11:45:33 AM', 1),
(8, 'Kendrick Mundiz', 'Birthday', 'Juna', '2017-03-23', '11:45:33 AM', 1),
(9, 'Juan Dela Cruz', 'Birthday', 'Davao', '2017-03-21', '12:04:00 PM', 1),
(10, 'Nikko Nemenzo', 'Wedding', 'UM', '2017-03-21', '12:09:16 PM', 1),
(11, 'Duterte', 'Rally', 'Rizal Park', '2017-03-21', '12:12:16 PM', 1),
(12, 'Sheila Young', 'Birthday', 'Davao', '2017-03-21', '12:18:00 PM', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_services`
--

CREATE TABLE `tbl_services` (
  `ServiceID` int(11) NOT NULL,
  `ServiceName` varchar(100) NOT NULL,
  `ServiceDescription` text NOT NULL,
  `ServiceFee` decimal(10,2) NOT NULL,
  `SupplierID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_services`
--

INSERT INTO `tbl_services` (`ServiceID`, `ServiceName`, `ServiceDescription`, `ServiceFee`, `SupplierID`) VALUES
(1, 'Photobooth', 'P3,000 unli for 2hrs\nP500 /succeeding hr', '3000.00', 1),
(2, 'Magician Clowns', 'P2,000 for 2hrs\nP500 /succeeding hr', '2000.00', 0),
(3, 'Bubble Show', 'P2,500 for 30 mins\nP2000 /succeeding hr', '2500.00', 1),
(4, 'Dirty Ice Cream', '1 flavor each tube', '1600.00', 7);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supplier`
--

CREATE TABLE `tbl_supplier` (
  `SupplierID` int(11) NOT NULL,
  `SupplierName` varchar(50) NOT NULL,
  `SupplierAddress` varchar(100) NOT NULL,
  `SupplierContact` varchar(15) NOT NULL,
  `SupplierStatus` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_supplier`
--

INSERT INTO `tbl_supplier` (`SupplierID`, `SupplierName`, `SupplierAddress`, `SupplierContact`, `SupplierStatus`) VALUES
(1, 'Celebrations Party Central', ' 3890 Araro Street, Palanan, Makati ', '9428282106', 'ACTIVE'),
(2, 'Celebrations Party Central', ' 3890 Araro Street, Palanan, Makati ', '9428282106', 'ACTIVE'),
(3, 'My Little Party Shop Manila', 'Manila, Philippines', '9872637847', 'ACTIVE'),
(4, 'Party in the City-MNL', 'Market Market BGC', '9989994842', 'ACTIVE'),
(5, 'Party Starters', 'Eco West Drive, Talomo, Davao City, 8000 Davao del Sur', '9128373654', 'ACTIVE'),
(6, '8 Spoons', 'GSIS Heights, Calinan District, Davao City, Davao del Sur', '9118273678', 'ACTIVE'),
(7, 'Almost Gourmet', 'Spain Street, Davao City, 8000 Davao del Sur', '9186761762', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_totalsales`
--

CREATE TABLE `tbl_totalsales` (
  `SaleID` int(11) NOT NULL,
  `reservation_id` int(11) NOT NULL,
  `totalsales` decimal(10,2) NOT NULL,
  `customer_name` varchar(100) NOT NULL,
  `Event` varchar(200) NOT NULL,
  `TransactionDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_totalsales`
--

INSERT INTO `tbl_totalsales` (`SaleID`, `reservation_id`, `totalsales`, `customer_name`, `Event`, `TransactionDate`) VALUES
(1, 1, '6050.00', 'Jeremy Lin', 'Linsanity Party', '2017-03-01'),
(3, 2, '800.00', 'Nikko Nemenzo', 'Sweet 16', '2017-03-07'),
(4, 3, '3750.00', 'Kyle Jaham', 'Birthday', '2017-03-07'),
(5, 4, '4500.00', 'Nikko Nemenzo', 'Birthday', '2017-03-15'),
(7, 5, '1000.00', 'Jeremy Lin', 'Trade Party', '2017-03-21'),
(9, 6, '3000.00', 'Gordon Ramsay', 'Michelin', '2017-03-21'),
(11, 7, '6000.00', 'Sheila Young', 'Birthday', '2017-03-21'),
(12, 8, '4500.00', 'Kendrick Mundiz', 'Birthday', '2017-03-21'),
(13, 9, '6500.00', 'Juan Dela Cruz', 'Birthday', '2017-03-21'),
(14, 10, '12680.00', 'Nikko Nemenzo', 'Wedding', '2017-03-21'),
(15, 10, '12680.00', 'Nikko Nemenzo', 'Wedding', '0000-00-00'),
(16, 11, '1500.00', 'Duterte', 'Rally', '2017-03-21'),
(17, 11, '1500.00', 'Duterte', 'Rally', '0000-00-00'),
(18, 12, '180.00', 'Sheila Young', 'Birthday', '2017-03-21'),
(19, 12, '180.00', 'Sheila Young', 'Birthday', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_totalsalesmonthly`
--

CREATE TABLE `tbl_totalsalesmonthly` (
  `MonthlyID` int(11) NOT NULL,
  `reservation_id` int(11) NOT NULL,
  `totalsales` decimal(10,2) NOT NULL,
  `customer_name` varchar(50) NOT NULL,
  `event` text NOT NULL,
  `transactiondate` varchar(15) NOT NULL,
  `transactionMonth` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_totalsalesmonthly`
--

INSERT INTO `tbl_totalsalesmonthly` (`MonthlyID`, `reservation_id`, `totalsales`, `customer_name`, `event`, `transactiondate`, `transactionMonth`) VALUES
(1, 38, '360.00', 'Jeremy', 'Lin', '03-18-2017', '03/2017'),
(2, 39, '400.00', 'Kendrick', 'Birthday', '03-18-2017', '03/2017'),
(3, 41, '1000.00', 'p', 'p', '03-20-2017', '03/2017'),
(4, 42, '3000.00', 'p', 'p', '03-20-2017', '03/2017'),
(5, 43, '1100.00', 'o', 'p', '03-20-2017', '03/2017'),
(6, 44, '1000.00', 'i', 'i', '03-20-2017', '03/2017'),
(7, 45, '1500.00', 'uiuiui', 'iii', '03-20-2017', '03/2017'),
(8, 46, '1000.00', 'ui', 'y', '03-20-2017', '03/2017'),
(9, 47, '180.00', 'u', 'u', '03-20-2017', '03/2017'),
(10, 48, '1000.00', '9', '9', '03-20-2017', '03/2017'),
(11, 49, '1000.00', 'u', 'u', '03-21-2017', '03/2017'),
(12, 50, '2500.00', 'u', 'u', '03-21-2017', '03/2017'),
(13, 1, '6050.00', 'Jeremy Lin', 'Linsanity Party', '03-21-2017', '03/2017'),
(14, 2, '800.00', 'Nikko Nemenzo', 'Sweet 16', '03-21-2017', '03/2017'),
(15, 3, '3750.00', 'Kyle Jaham', 'Birthday', '03-21-2017', '03/2017'),
(16, 4, '4500.00', 'Nikko Nemenzo', 'Birthday', '03-21-2017', '03/2017'),
(17, 5, '1000.00', 'Jeremy Lin', 'Trade Party', '03-21-2017', '03/2017'),
(18, 6, '3000.00', 'Gordon Ramsay', 'Michelin', '03-21-2017', '03/2017'),
(19, 7, '6000.00', 'Sheila Young', 'Birthday', '03-21-2017', '03/2017'),
(20, 8, '4500.00', 'Kendrick Mundiz', 'Birthday', '03-21-2017', '03/2017'),
(21, 9, '6500.00', 'Juan Dela Cruz', 'Birthday', '03-21-2017', '03/2017'),
(22, 10, '12680.00', 'Nikko Nemenzo', 'Wedding', '03-21-2017', '03/2017'),
(23, 11, '1500.00', 'Duterte', 'Rally', '03-21-2017', '03/2017'),
(24, 12, '180.00', 'Sheila Young', 'Birthday', '03-21-2017', '03/2017');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_totalsalesyearly`
--

CREATE TABLE `tbl_totalsalesyearly` (
  `YearlyID` int(11) NOT NULL,
  `reservation_id` int(11) NOT NULL,
  `totalsales` decimal(10,2) NOT NULL,
  `customer_name` varchar(50) NOT NULL,
  `event` text NOT NULL,
  `transactiondate` varchar(15) NOT NULL,
  `transactionyear` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_totalsalesyearly`
--

INSERT INTO `tbl_totalsalesyearly` (`YearlyID`, `reservation_id`, `totalsales`, `customer_name`, `event`, `transactiondate`, `transactionyear`) VALUES
(1, 38, '360.00', 'Jeremy', 'Lin', '03-18-2017', '2017'),
(2, 39, '400.00', 'Kendrick', 'Birthday', '03-18-2017', '2017'),
(3, 41, '1000.00', 'p', 'p', '03-20-2017', '2017'),
(4, 42, '3000.00', 'p', 'p', '03-20-2017', '2017'),
(5, 43, '1100.00', 'o', 'p', '03-20-2017', '2017'),
(6, 44, '1000.00', 'i', 'i', '03-20-2017', '2017'),
(7, 45, '1500.00', 'uiuiui', 'iii', '03-20-2017', '2017'),
(8, 46, '1000.00', 'ui', 'y', '03-20-2017', '2017'),
(9, 47, '180.00', 'u', 'u', '03-20-2017', '2017'),
(10, 48, '1000.00', '9', '9', '03-20-2017', '2017'),
(11, 49, '1000.00', 'u', 'u', '03-21-2017', '2017'),
(12, 50, '2500.00', 'u', 'u', '03-21-2017', '2017'),
(13, 1, '6050.00', 'Jeremy Lin', 'Linsanity Party', '03-21-2017', '2017'),
(14, 2, '800.00', 'Nikko Nemenzo', 'Sweet 16', '03-21-2017', '2017'),
(15, 3, '3750.00', 'Kyle Jaham', 'Birthday', '03-21-2017', '2017'),
(16, 4, '4500.00', 'Nikko Nemenzo', 'Birthday', '03-21-2017', '2017'),
(17, 5, '1000.00', 'Jeremy Lin', 'Trade Party', '03-21-2017', '2017'),
(18, 6, '3000.00', 'Gordon Ramsay', 'Michelin', '03-21-2017', '2017'),
(19, 7, '6000.00', 'Sheila Young', 'Birthday', '03-21-2017', '2017'),
(20, 8, '4500.00', 'Kendrick Mundiz', 'Birthday', '03-21-2017', '2017'),
(21, 9, '6500.00', 'Juan Dela Cruz', 'Birthday', '03-21-2017', '2017'),
(22, 10, '12680.00', 'Nikko Nemenzo', 'Wedding', '03-21-2017', '2017'),
(23, 11, '1500.00', 'Duterte', 'Rally', '03-21-2017', '2017'),
(24, 12, '180.00', 'Sheila Young', 'Birthday', '03-21-2017', '2017');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_viand`
--

CREATE TABLE `tbl_viand` (
  `ViandID` int(11) NOT NULL,
  `Viand` varchar(50) NOT NULL,
  `ViandDescription` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`IDNo`);

--
-- Indexes for table `tbl_archive`
--
ALTER TABLE `tbl_archive`
  ADD PRIMARY KEY (`archive`);

--
-- Indexes for table `tbl_catering`
--
ALTER TABLE `tbl_catering`
  ADD PRIMARY KEY (`CateringID`);

--
-- Indexes for table `tbl_inventoryitem`
--
ALTER TABLE `tbl_inventoryitem`
  ADD PRIMARY KEY (`ItemCode`);

--
-- Indexes for table `tbl_logs`
--
ALTER TABLE `tbl_logs`
  ADD PRIMARY KEY (`LogsID`);

--
-- Indexes for table `tbl_purchaseorder`
--
ALTER TABLE `tbl_purchaseorder`
  ADD PRIMARY KEY (`purchase_id`),
  ADD KEY `reservation_id` (`reservation_id`);

--
-- Indexes for table `tbl_reservation`
--
ALTER TABLE `tbl_reservation`
  ADD PRIMARY KEY (`reservation_id`);

--
-- Indexes for table `tbl_services`
--
ALTER TABLE `tbl_services`
  ADD PRIMARY KEY (`ServiceID`);

--
-- Indexes for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  ADD PRIMARY KEY (`SupplierID`);

--
-- Indexes for table `tbl_totalsales`
--
ALTER TABLE `tbl_totalsales`
  ADD PRIMARY KEY (`SaleID`);

--
-- Indexes for table `tbl_totalsalesmonthly`
--
ALTER TABLE `tbl_totalsalesmonthly`
  ADD PRIMARY KEY (`MonthlyID`);

--
-- Indexes for table `tbl_totalsalesyearly`
--
ALTER TABLE `tbl_totalsalesyearly`
  ADD PRIMARY KEY (`YearlyID`);

--
-- Indexes for table `tbl_viand`
--
ALTER TABLE `tbl_viand`
  ADD PRIMARY KEY (`ViandID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `IDNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbl_archive`
--
ALTER TABLE `tbl_archive`
  MODIFY `archive` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_catering`
--
ALTER TABLE `tbl_catering`
  MODIFY `CateringID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbl_inventoryitem`
--
ALTER TABLE `tbl_inventoryitem`
  MODIFY `ItemCode` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `tbl_logs`
--
ALTER TABLE `tbl_logs`
  MODIFY `LogsID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=271;
--
-- AUTO_INCREMENT for table `tbl_purchaseorder`
--
ALTER TABLE `tbl_purchaseorder`
  MODIFY `purchase_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT for table `tbl_reservation`
--
ALTER TABLE `tbl_reservation`
  MODIFY `reservation_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `tbl_services`
--
ALTER TABLE `tbl_services`
  MODIFY `ServiceID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  MODIFY `SupplierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tbl_totalsales`
--
ALTER TABLE `tbl_totalsales`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT for table `tbl_totalsalesmonthly`
--
ALTER TABLE `tbl_totalsalesmonthly`
  MODIFY `MonthlyID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT for table `tbl_totalsalesyearly`
--
ALTER TABLE `tbl_totalsalesyearly`
  MODIFY `YearlyID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT for table `tbl_viand`
--
ALTER TABLE `tbl_viand`
  MODIFY `ViandID` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
