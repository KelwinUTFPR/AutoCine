-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.36-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para cine_auto
CREATE DATABASE IF NOT EXISTS `cine_auto` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `cine_auto`;

-- Copiando estrutura para tabela cine_auto.filmes
CREATE TABLE IF NOT EXISTS `filmes` (
  `codigo_filme` int(11) NOT NULL AUTO_INCREMENT,
  `nome_filme` varchar(50) DEFAULT NULL,
  `sinopse` varchar(400) DEFAULT NULL,
  `classificacao` char(50) DEFAULT NULL,
  `genero` varchar(50) DEFAULT NULL,
  `duracao` varchar(50) DEFAULT NULL,
  `foto` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codigo_filme`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cine_auto.filmes: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `filmes` DISABLE KEYS */;
INSERT INTO `filmes` (`codigo_filme`, `nome_filme`, `sinopse`, `classificacao`, `genero`, `duracao`, `foto`) VALUES
	(1, 'Adão Negro', 'O poderoso Adão Negro é libertado de sua tumba para lançar sua justiça cruel sob a Terra.', '13', 'Ação/fantasia', '02:04:00', 'black_adam');
/*!40000 ALTER TABLE `filmes` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
