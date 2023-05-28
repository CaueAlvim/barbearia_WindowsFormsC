-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 28-Maio-2023 às 23:22
-- Versão do servidor: 8.0.31
-- versão do PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `barbearia`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `administrador`
--

DROP TABLE IF EXISTS `administrador`;
CREATE TABLE IF NOT EXISTS `administrador` (
  `adm_id` int NOT NULL AUTO_INCREMENT,
  `adm_nome` varchar(50) NOT NULL,
  `adm_usuario` varchar(50) NOT NULL,
  `adm_senha` varchar(50) NOT NULL,
  PRIMARY KEY (`adm_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `administrador`
--

INSERT INTO `administrador` (`adm_id`, `adm_nome`, `adm_usuario`, `adm_senha`) VALUES
(1, 'caue', 'caue', 'admin123');

-- --------------------------------------------------------

--
-- Estrutura da tabela `agendamento`
--

DROP TABLE IF EXISTS `agendamento`;
CREATE TABLE IF NOT EXISTS `agendamento` (
  `agn_id` int NOT NULL AUTO_INCREMENT,
  `agn_cli_nome` varchar(50) DEFAULT NULL,
  `agn_bar_nome` varchar(50) DEFAULT NULL,
  `agn_ser_tiposervico` varchar(70) DEFAULT NULL,
  `agn_datahora` datetime NOT NULL,
  PRIMARY KEY (`agn_id`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `agendamento`
--

INSERT INTO `agendamento` (`agn_id`, `agn_cli_nome`, `agn_bar_nome`, `agn_ser_tiposervico`, `agn_datahora`) VALUES
(37, 'AAIN ZE DA MANGA', 'Marcos Navalha', 'Corte completo', '2023-06-01 13:00:30'),
(38, 'Edson Varella', 'Marcos Navalha', 'Corte infantil', '2023-06-02 17:00:00'),
(39, 'Chico Bioca', 'Janette Mão de Tesoura', 'Lavagem', '2023-06-03 17:00:30');

-- --------------------------------------------------------

--
-- Estrutura da tabela `barbeiro`
--

DROP TABLE IF EXISTS `barbeiro`;
CREATE TABLE IF NOT EXISTS `barbeiro` (
  `bar_id` int NOT NULL AUTO_INCREMENT,
  `bar_nome` varchar(50) DEFAULT NULL,
  `bar_telefone` varchar(50) DEFAULT NULL,
  `bar_email` varchar(50) DEFAULT NULL,
  `bar_cpf` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`bar_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `barbeiro`
--

INSERT INTO `barbeiro` (`bar_id`, `bar_nome`, `bar_telefone`, `bar_email`, `bar_cpf`) VALUES
(10, 'Marcos Navalha', '(11)94321-1243', 'marcao@gmail.com', '123.456.789-02'),
(11, 'Pedro Picafio', '(11)95421-5231', 'pedraoo@gmail.com', '152.256.629-12'),
(12, 'Janette Mão de Tesoura', '(11)92421-5121', 'jane@gmail.com', '212.256.629-12');

-- --------------------------------------------------------

--
-- Estrutura da tabela `barbeiro_agendamento`
--

DROP TABLE IF EXISTS `barbeiro_agendamento`;
CREATE TABLE IF NOT EXISTS `barbeiro_agendamento` (
  `BARBEIRO_bar_id` int NOT NULL,
  `AGENDAMENTO_agn_cli_nome` varchar(50) NOT NULL,
  `AGENDAMENTO_agn_bar_nome` varchar(50) NOT NULL,
  `AGENDAMENTO_agn_ser_tiposervico` varchar(70) NOT NULL,
  `AGENDAMENTO_agn_datahora` datetime NOT NULL,
  `AGENDAMENTO_agn_id` int NOT NULL,
  PRIMARY KEY (`BARBEIRO_bar_id`),
  KEY `barbeiro_agendamento_AGENDAMENTO_FK` (`AGENDAMENTO_agn_id`,`AGENDAMENTO_agn_cli_nome`,`AGENDAMENTO_agn_bar_nome`,`AGENDAMENTO_agn_ser_tiposervico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `barbeiro_cliente`
--

DROP TABLE IF EXISTS `barbeiro_cliente`;
CREATE TABLE IF NOT EXISTS `barbeiro_cliente` (
  `BARBEIRO_bar_id` int NOT NULL,
  `CLIENTE_cli_id` int NOT NULL,
  PRIMARY KEY (`BARBEIRO_bar_id`,`CLIENTE_cli_id`),
  KEY `CLIENTE_cli_id` (`CLIENTE_cli_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `barbeiro_servico`
--

DROP TABLE IF EXISTS `barbeiro_servico`;
CREATE TABLE IF NOT EXISTS `barbeiro_servico` (
  `BARBEIRO_bar_id` int NOT NULL,
  `SERVICO_ser_id` int NOT NULL,
  PRIMARY KEY (`BARBEIRO_bar_id`,`SERVICO_ser_id`),
  KEY `SERVICO_ser_id` (`SERVICO_ser_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `cli_id` int NOT NULL AUTO_INCREMENT,
  `cli_nome` varchar(50) DEFAULT NULL,
  `cli_telefone` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cli_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`cli_id`, `cli_nome`, `cli_telefone`) VALUES
(8, 'AAIN ZE DA MANGA', '469696969696'),
(17, 'Edson Varella', '(11)92251-2314'),
(19, 'Chico Bioca', '(11)96961-2314');

-- --------------------------------------------------------

--
-- Estrutura da tabela `servico`
--

DROP TABLE IF EXISTS `servico`;
CREATE TABLE IF NOT EXISTS `servico` (
  `ser_id` int NOT NULL AUTO_INCREMENT,
  `ser_tiposervico` varchar(70) DEFAULT NULL,
  PRIMARY KEY (`ser_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `servico`
--

INSERT INTO `servico` (`ser_id`, `ser_tiposervico`) VALUES
(2, 'Corte completo'),
(5, 'Aparar barba'),
(7, 'Corte infantil'),
(9, 'Lavagem');

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `barbeiro_agendamento`
--
ALTER TABLE `barbeiro_agendamento`
  ADD CONSTRAINT `barbeiro_agendamento_ibfk_1` FOREIGN KEY (`BARBEIRO_bar_id`) REFERENCES `barbeiro` (`bar_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `barbeiro_agendamento_ibfk_2` FOREIGN KEY (`AGENDAMENTO_agn_id`) REFERENCES `agendamento` (`agn_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `barbeiro_cliente`
--
ALTER TABLE `barbeiro_cliente`
  ADD CONSTRAINT `barbeiro_cliente_ibfk_1` FOREIGN KEY (`BARBEIRO_bar_id`) REFERENCES `barbeiro` (`bar_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `barbeiro_cliente_ibfk_2` FOREIGN KEY (`CLIENTE_cli_id`) REFERENCES `cliente` (`cli_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `barbeiro_servico`
--
ALTER TABLE `barbeiro_servico`
  ADD CONSTRAINT `barbeiro_servico_ibfk_1` FOREIGN KEY (`BARBEIRO_bar_id`) REFERENCES `barbeiro` (`bar_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `barbeiro_servico_ibfk_2` FOREIGN KEY (`SERVICO_ser_id`) REFERENCES `servico` (`ser_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
