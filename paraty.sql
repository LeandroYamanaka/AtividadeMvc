-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 18, 2020 at 12:16 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `paraty`
--

-- --------------------------------------------------------

--
-- Table structure for table `agendamento`
--

CREATE TABLE `agendamento` (
  `IdUsuario` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `Data_Agendamento` varchar(25) NOT NULL,
  `Horario` varchar(10) NOT NULL,
  `Pessoas` int(30) NOT NULL,
  `Telefone` varchar(12) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Texto_Descricao` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `agendamento`
--

INSERT INTO `agendamento` (`IdUsuario`, `Nome`, `Data_Agendamento`, `Horario`, `Pessoas`, `Telefone`, `Email`, `Texto_Descricao`) VALUES
(1, 'Leandro', '2021-03-01', '07:00', 15, '11963264010', 'leandroyamanaka@gmail.com', 'sem pet');

-- --------------------------------------------------------

--
-- Table structure for table `depoimento`
--

CREATE TABLE `depoimento` (
  `IdDepoimento` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `Mensagem` varchar(300) NOT NULL,
  `Data_Depoimento` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `depoimento`
--

INSERT INTO `depoimento` (`IdDepoimento`, `Nome`, `Mensagem`, `Data_Depoimento`) VALUES
(1, 'Sidiney Banks', 'O lugar mais bonito e incrível de Paraty, vale passar o dia por aqui, as praias em volta são cada uma mais bonita que a outra.', '17/11/2020'),
(2, 'Fernando Laz', 'Coloca na lista de aventura. Só isso. Imperdível!!!', '07/12/2020'),
(3, 'Fernando Augusto Sanchez', 'Na mata atlántica se encontra um paraíso, um lugar mágico cheio de lugares e pessoas especiais, o saco de mamangua é um de eles, neste lugar vc se perde no tempo, o silencio a noite, as praias e a floresta durante o dia!!.... as cachueiras, ríos, e o pico, bom o pico é um plus do paraíso!!!', '10/12/2019'),
(4, 'Flavia Krol', 'Um pedacinho de Paraty que é um sonho!', '15/10/2020'),
(5, 'Gloria Xavier', 'Lugar paradisíaco.  Perfeito para quem precisa descansar a mente', '20/11/2019');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `agendamento`
--
ALTER TABLE `agendamento`
  ADD PRIMARY KEY (`IdUsuario`);

--
-- Indexes for table `depoimento`
--
ALTER TABLE `depoimento`
  ADD PRIMARY KEY (`IdDepoimento`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `agendamento`
--
ALTER TABLE `agendamento`
  MODIFY `IdUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `depoimento`
--
ALTER TABLE `depoimento`
  MODIFY `IdDepoimento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
