-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Feb 13, 2017 at 07:09 AM
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
-- Table structure for table `tbl_reservation`
--

CREATE TABLE IF NOT EXISTS `tbl_reservation` (
  `reservation_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_name` varchar(255) NOT NULL,
  `event_name` varchar(255) NOT NULL,
  `event_address` text NOT NULL,
  `date_needed` date NOT NULL,
  `time_needed` varchar(255) NOT NULL,
  PRIMARY KEY (`reservation_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=28 ;

--
-- Dumping data for table `tbl_reservation`
--

INSERT INTO `tbl_reservation` (`reservation_id`, `customer_name`, `event_name`, `event_address`, `date_needed`, `time_needed`) VALUES
(5, 'Keith Mundiz', 'Birthday', 'Juna Subd. Davao City', '2017-02-12', '8:54:05 PM'),
(6, 'Tzuyu', 'Fan Meeting', 'SMX Convention Center', '2017-02-12', '8:57:19 PM'),
(7, 'Shin Min-a', 'Wedding', 'Church', '2017-02-12', '8:58:50 PM'),
(8, 'Nayeon', 'Cheer UP', 'SMX', '2017-02-12', '9:01:47 PM'),
(9, 'templar assasin', 'rampage', 'rosh pit', '2017-02-12', '9:03:09 PM'),
(10, 'Adrian Abrasaldo', 'Going out party', 'Buhangin', '2017-02-13', '9:38:58 PM'),
(11, '', '', '', '2017-02-12', '9:41:26 PM'),
(12, 'omg', 'omg', 'omg', '2017-02-12', '9:41:51 PM'),
(13, 'holy', 'holy', 'yh-oas', '2017-02-12', '9:42:59 PM'),
(14, 'jaf', 'jaf', 'kasf', '2017-02-12', '9:43:53 PM'),
(15, 'jndvn', 'asklfkasl', 'klafklf', '2017-02-12', '9:45:20 PM'),
(16, 'bhf', 'jhaf', 'asjfbh', '2017-02-12', '9:47:28 PM'),
(17, 'jknjkas', 'ajksnfjk', 'nkajsf', '2017-02-12', '9:48:44 PM'),
(18, 'lkasnv', 'klasmfklas', 'mkalfsmk', '2017-02-12', '9:49:44 PM'),
(19, 'kjsanj', 'jkasnfjkasfn', 'kjasnjk', '2017-02-12', '9:55:07 PM'),
(20, 'jkfas', 'kjasfn', 'jkasfn', '2017-02-12', '9:57:28 PM'),
(21, 'sd', 'asd', 'asd', '2017-02-12', '9:57:28 PM'),
(22, 'asln', 'aslfn', 'klasfm', '2017-02-12', '10:00:12 PM'),
(23, 'jkan', 'jnanjnj', 'jnnaj', '2017-02-12', '10:00:49 PM'),
(24, 'Alicia', 'Birthdau', 'Juna', '2017-11-25', '10:05:59 PM'),
(25, 'sheila', 'birthday', 'davao', '2017-02-13', '12:00:00 PM'),
(26, 'safAFADFf', 'dfaaa', '', '2017-02-12', '10:53:02 PM'),
(27, 'h', 'k', 'k', '2017-02-12', '10:55:39 PM');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
