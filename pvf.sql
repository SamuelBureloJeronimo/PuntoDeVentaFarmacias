-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 21, 2023 at 07:23 AM
-- Server version: 5.7.36
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pvf`
--

-- --------------------------------------------------------

--
-- Table structure for table `calles`
--

DROP TABLE IF EXISTS `calles`;
CREATE TABLE IF NOT EXISTS `calles` (
  `clvCalle` int(11) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `clvCol` int(11) NOT NULL,
  PRIMARY KEY (`clvCalle`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `calles`
--

INSERT INTO `calles` (`clvCalle`, `Nombre`, `clvCol`) VALUES
(1902, 'Calle Juárez', 140),
(427, 'Avenida Las Palmas', 71),
(3040, 'Calle del Sol', 142),
(1231, 'Avenida Lerma', 101),
(19, 'Calle 27 de Febrero', 9),
(1, 'Calle Juárez', 9),
(25, 'Avenida Paseo Tabasco', 9),
(13, 'Calle Ignacio Allende', 9),
(27, 'Calle 5 de Mayo', 9);

-- --------------------------------------------------------

--
-- Table structure for table `colonias`
--

DROP TABLE IF EXISTS `colonias`;
CREATE TABLE IF NOT EXISTS `colonias` (
  `clvCol` int(11) NOT NULL,
  `Nombre` varchar(25) NOT NULL,
  `clvMun` int(11) NOT NULL,
  PRIMARY KEY (`clvCol`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `colonias`
--

INSERT INTO `colonias` (`clvCol`, `Nombre`, `clvMun`) VALUES
(140, 'San Miguel', 32),
(71, 'Santa Cruz', 100),
(142, 'Costa de Oro', 30),
(101, 'San Buenaventura', 57),
(9, 'Gaviotas Norte', 4);

-- --------------------------------------------------------

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
CREATE TABLE IF NOT EXISTS `departamentos` (
  `clvD` varchar(15) NOT NULL,
  `nombDep` varchar(45) NOT NULL,
  PRIMARY KEY (`clvD`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `departamentos`
--

INSERT INTO `departamentos` (`clvD`, `nombDep`) VALUES
('001', 'Salchichoneria'),
('002', 'Otro departamento');

-- --------------------------------------------------------

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
CREATE TABLE IF NOT EXISTS `empleados` (
  `clvE` varchar(12) NOT NULL,
  `horario` varchar(35) NOT NULL,
  `fechContr` varchar(35) NOT NULL,
  `clvDep` varchar(15) NOT NULL,
  `salario` double NOT NULL,
  `img` longblob,
  PRIMARY KEY (`clvE`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `empleados`
--

INSERT INTO `empleados` (`clvE`, `horario`, `fechContr`, `clvDep`, `salario`, `img`) VALUES
('BUJS030806', '7 am - 2 pm', '15/04/2023', '001', 25000, NULL),
('Spartan', '7 am - 2 pm', '15/04/2023', '002', 21000, NULL),
('Sparmertan', '7 am - 2 pm', '15/04/2023', '001', 25000, NULL),
('Samuel117', '7 am - 2 pm', '15/04/2023', '002', 25000, NULL),
('asdfdff', 'sadfasdfasf', '4/19/2023 2:41:42 AM', '1', 90000, NULL),
('21345435', '9 a 8', '4/21/2023 1:18:50 AM', '1', 12000, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `estados`
--

DROP TABLE IF EXISTS `estados`;
CREATE TABLE IF NOT EXISTS `estados` (
  `clvEst` int(11) NOT NULL,
  `Nombre` varchar(25) NOT NULL,
  PRIMARY KEY (`clvEst`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `estados`
--

INSERT INTO `estados` (`clvEst`, `Nombre`) VALUES
(15, 'Estado de México'),
(14, 'Jalisco'),
(30, 'Veracruz'),
(7, 'Chiapas'),
(27, 'Tabasco');

-- --------------------------------------------------------

--
-- Table structure for table `municipios`
--

DROP TABLE IF EXISTS `municipios`;
CREATE TABLE IF NOT EXISTS `municipios` (
  `clvMun` int(11) NOT NULL,
  `Nombre` varchar(25) NOT NULL,
  `clvEst` int(11) NOT NULL,
  PRIMARY KEY (`clvMun`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `municipios`
--

INSERT INTO `municipios` (`clvMun`, `Nombre`, `clvEst`) VALUES
(100, 'Tuxtla Gutiérrez', 7),
(32, 'Lagos de Moreno', 14),
(30, 'Boca del Río', 30),
(57, 'Toluca', 15),
(4, 'Centro', 27);

-- --------------------------------------------------------

--
-- Table structure for table `personas`
--

DROP TABLE IF EXISTS `personas`;
CREATE TABLE IF NOT EXISTS `personas` (
  `rfc` varchar(12) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `app` varchar(30) NOT NULL,
  `apm` varchar(30) NOT NULL,
  `clvCalle` int(11) DEFAULT NULL,
  PRIMARY KEY (`rfc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `personas`
--

INSERT INTO `personas` (`rfc`, `nombre`, `app`, `apm`, `clvCalle`) VALUES
('BUJS030806', 'Samuelon', 'Burelos', 'Jerónimo', NULL),
('Spartan', 'El pepe', 'Gabiria', 'nose', NULL),
('Sparmertan', 'SpartanLuck 117', '117', 'UNSC', NULL),
('Samuel117', 'Samuel', 'Burelos', '2', NULL),
('21345435', 'Tilo de Jesus', 'Burelo', 'Jeronimo', 101),
('241096', 'Tilo de Jesus', 'Burelos', 'Jeronimo', 9),
('asdfdff', 'Samjsda', 'saf', 'asdf', 140);

-- --------------------------------------------------------

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
CREATE TABLE IF NOT EXISTS `productos` (
  `clv` varchar(15) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `precioComp` double NOT NULL,
  `precioVent` double NOT NULL,
  `tipo` varchar(25) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `ivaPorc` int(11) NOT NULL,
  `caducidad` varchar(25) NOT NULL,
  `img` longblob,
  PRIMARY KEY (`clv`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `productos`
--

INSERT INTO `productos` (`clv`, `nombre`, `precioComp`, `precioVent`, `tipo`, `cantidad`, `ivaPorc`, `caducidad`, `img`) VALUES
('COD001', 'Paracetamol', 15, 25, 'Farmaco', 710, 15, 'Sunday, January 1, 2023', 0x40696d616765),
('COD009', 'Alcanfor', 15, 25, 'Farmaco', 250, 15, 'Hoy', NULL),
('COD005', 'Diclofenaco', 19, 29, 'Farmacos', 400, 15, 'Sunday, January 1, 2023', 0x40696d616765),
('COD2410', 'Tetraciclina', 12, 21, 'Farmacos', 400, 15, 'Sunday, January 1, 2023', 0x40696d616765);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `user` varchar(12) NOT NULL,
  `pass` varchar(18) NOT NULL,
  `tipo` varchar(10) NOT NULL,
  PRIMARY KEY (`user`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user`, `pass`, `tipo`) VALUES
('BUJS030806', '117', 'Admin'),
('Spartan', '117', 'Gerente');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
