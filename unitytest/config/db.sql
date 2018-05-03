SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

CREATE DATABASE `login`;

USE `login`;

CREATE TABLE `player` (
  `userid` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `username` varchar(32) NOT NULL,
  `password` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


INSERT INTO `player` (`username`, `password`) VALUES
('Khayreddine21', '123456789'),
('Mohamed'   , '159aaabr');
