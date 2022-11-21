-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 08, 2017 at 08:37 AM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 7.0.6

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
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`IDNo`, `fullName`, `username`, `password`, `status`) VALUES
(1, 'Michael Estrella', 'admin', 'admin', 'ADMIN'),
(2, 'Employee 1', 'userA', 'user', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_catering`
--

CREATE TABLE `tbl_catering` (
  `CateringID` int(11) NOT NULL,
  `ViandID` int(11) NOT NULL,
  `reservation_id` int(11) NOT NULL,
  `pax` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  `ItemPrice` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_inventoryitem`
--

INSERT INTO `tbl_inventoryitem` (`ItemCode`, `ItemName`, `ItemDescription`, `ItemStock`, `SupplierID`, `ItemPrice`) VALUES
(1, 'Happy Birthday Multi Color Foil Balloons', 'Can be sealed automatically and easy to blow air into it', 20, 5, '300.00'),
(2, '100pcs 10" Pearl Colorful Latex Balloon', 'Can resistance to extreme temperatures', 26, 4, '400.00'),
(3, 'Aluminum Foil Balloon', 'Five Star Store Number 0 - 9 Aluminum Foil Balloon Birthday Party Wedding Carnival', 40, 5, '297.00'),
(4, 'Long Twist DIY Latex Balloons', 'Tying Making Decor Mixed Mix-color', 90, 1, '340.00'),
(5, 'Ai Home Pie Face Cream Game Home Funny Rocket Pate', 'Novelty Fun Anti Stress Prank Toys.', 30, 5, '659.00'),
(6, 'Colorful Pearl Latex Balloon', 'Fancytoy Hot 100pcs 10 inch Colorful Pearl Latex Balloon for Party Wedding Birthday ', 30, 1, '335.00'),
(7, 'Mustache Mask', '62pcs Funny Photo Booth Props Mustache Mask for Wedding / Party / Christmas', 10, 1, '378.00'),
(8, 'A1 Chair Covers', 'Chair Covers for the Wedding Party S Chair Covers', 200, 5, '20.00'),
(9, 'Chair Cover Bow-knot Sash Band', 'Organza Chair Cover Bow-knot Sash Band Wedding Party Reception Banquet DecorRed ', 300, 6, '50.00'),
(10, 'Kiddie Monobloc', 'Monobloc Plastic Kiddie Party Study Chair', 300, 7, '10.00'),
(11, 'Sash Bowknot Tie Chair Cover', 'Chair Cover Wedding Party Venue Banquet Organza Decor PurpleWhite - intl', 300, 5, '60.00'),
(12, 'Square Tablecloth', 'Square Tablecloth Elegant Flower Pattern Wedding Banquet Party Table Cover Coffee', 200, 3, '30.00'),
(13, 'White Plastic Table Cloth Cover', 'Table Cloth Cover For Wedding Birthday Party Tablecovers 54x108"', 200, 7, '20.00'),
(14, '1M Dia Round Tablecloth Table Cover Cloth', 'Flower Pattern Wedding Party', 312, 1, '25.00');

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
(1, 'Michael Estrella', 'admin', '02-06-2017', '02:15:59'),
(2, 'Michael Estrella', 'admin', '02-07-2017', '01:13:07'),
(3, 'Michael Estrella', 'admin', '02-07-2017', '01:35:31'),
(4, 'Michael Estrella', 'admin', '02-07-2017', '01:50:59'),
(5, 'Michael Estrella', 'admin', '02-07-2017', '01:55:25'),
(6, 'Michael Estrella', 'admin', '02-07-2017', '02:03:48'),
(7, 'Michael Estrella', 'admin', '02-07-2017', '03:39:11'),
(8, 'Michael Estrella', 'admin', '02-07-2017', '03:40:30'),
(9, 'Michael Estrella', 'admin', '02-07-2017', '03:44:52'),
(10, 'Michael Estrella', 'admin', '02-07-2017', '03:48:22'),
(11, 'Michael Estrella', 'admin', '02-07-2017', '04:17:12'),
(12, 'Michael Estrella', 'admin', '02-07-2017', '04:19:15'),
(13, 'Michael Estrella', 'admin', '02-07-2017', '04:20:21'),
(14, 'Michael Estrella', 'admin', '02-07-2017', '04:35:19'),
(15, 'Michael Estrella', 'admin', '02-07-2017', '04:40:31'),
(16, 'Michael Estrella', 'admin', '02-07-2017', '04:45:19'),
(17, 'Michael Estrella', 'admin', '02-07-2017', '04:50:23');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_logsactivity`
--

CREATE TABLE `tbl_logsactivity` (
  `LogsID` int(11) NOT NULL,
  `LogsActivity` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchaseorder`
--

CREATE TABLE `tbl_purchaseorder` (
  `purchase_id` int(11) NOT NULL,
  `item_name` varchar(255) NOT NULL,
  `item_price` int(11) NOT NULL,
  `order_quantity` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `purchase_status` int(11) NOT NULL,
  `reservation_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_purchaseorder`
--

INSERT INTO `tbl_purchaseorder` (`purchase_id`, `item_name`, `item_price`, `order_quantity`, `total`, `purchase_status`, `reservation_id`) VALUES
(1, 'QQQ', 20, 50, 1000, 1, 0),
(2, 'THAT XX', 110, 5, 550, 1, 0),
(3, 'QQQ', 20, 5, 100, 1, 0),
(4, 'SSSSS', 10, 5, 50, 1, 0),
(5, 'SSSSS', 10, 5, 50, 1, 0),
(6, 'Chair', 900, 5, 4500, 1, 0),
(7, 'SSSSS', 10, 8, 80, 1, 0),
(8, 'QQQ', 20, 5, 100, 1, 0),
(9, 'Chair', 900, 5, 4500, 1, 0),
(10, 'QQQ', 20, 3, 60, 1, 0),
(11, 'QQQ', 20, 4, 80, 1, 0),
(12, 'SSSSS', 10, 5, 50, 1, 0),
(14, 'QQQ', 20, 2, 40, 1, 0),
(15, 'Chair', 900, 5, 4500, 1, 0),
(17, 'SSSSS', 10, 5, 50, 1, 0),
(18, 'Aluminum Foil Balloon', 297, 7, 2079, 1, 0),
(19, 'Happy Birthday Multi Color Foil Balloons', 300, 8, 2400, 1, 0),
(20, '100pcs 10" Pearl Colorful Latex Balloon', 400, 9, 3600, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_reservation`
--

CREATE TABLE `tbl_reservation` (
  `reservation_id` int(11) NOT NULL,
  `customer_name` varchar(50) NOT NULL,
  `event_name` varchar(50) NOT NULL,
  `event_address` text NOT NULL,
  `date_needed` date NOT NULL,
  `time_needed` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_reservation`
--

INSERT INTO `tbl_reservation` (`reservation_id`, `customer_name`, `event_name`, `event_address`, `date_needed`, `time_needed`) VALUES
(0, 'Sheil', 'debut', 'talomo dc', '2017-02-13', '9:00:00 PM');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sales`
--

CREATE TABLE `tbl_sales` (
  `SalesID` int(11) NOT NULL,
  `SalesAmountDue` decimal(10,0) NOT NULL,
  `SalesDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
(2, 'Designs on Us', 'Tabang Guiguinto', '9175099744', 'ACTIVE'),
(3, 'My Little Party Shop Manila', 'Manila, Philippines', '9872637847', 'ACTIVE'),
(4, 'Party in the City-MNL', 'Market Market BGC', '9989994842', 'ACTIVE'),
(5, 'Party Starters', 'Eco West Drive, Talomo, Davao City, 8000 Davao del Sur', '9128373654', 'ACTIVE'),
(6, '8 Spoons', 'GSIS Heights, Calinan District, Davao City, Davao del Sur', '9118273678', 'ACTIVE'),
(7, 'Almost Gourmet', 'Spain Street, Davao City, 8000 Davao del Sur', '9186761762', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaction`
--

CREATE TABLE `tbl_transaction` (
  `TransID` int(11) NOT NULL,
  `SalesID` int(11) NOT NULL,
  `ItemCode` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  ADD PRIMARY KEY (`purchase_id`);

--
-- Indexes for table `tbl_reservation`
--
ALTER TABLE `tbl_reservation`
  ADD PRIMARY KEY (`reservation_id`);

--
-- Indexes for table `tbl_sales`
--
ALTER TABLE `tbl_sales`
  ADD PRIMARY KEY (`SalesID`);

--
-- Indexes for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  ADD PRIMARY KEY (`SupplierID`);

--
-- Indexes for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  ADD PRIMARY KEY (`TransID`);

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
  MODIFY `IDNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbl_catering`
--
ALTER TABLE `tbl_catering`
  MODIFY `CateringID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_inventoryitem`
--
ALTER TABLE `tbl_inventoryitem`
  MODIFY `ItemCode` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `tbl_logs`
--
ALTER TABLE `tbl_logs`
  MODIFY `LogsID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `tbl_purchaseorder`
--
ALTER TABLE `tbl_purchaseorder`
  MODIFY `purchase_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `tbl_sales`
--
ALTER TABLE `tbl_sales`
  MODIFY `SalesID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  MODIFY `SupplierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  MODIFY `TransID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_viand`
--
ALTER TABLE `tbl_viand`
  MODIFY `ViandID` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
