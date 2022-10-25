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
  `sinopse` varchar(1000) DEFAULT NULL,
  `classificacao` char(50) DEFAULT NULL,
  `genero` varchar(50) DEFAULT NULL,
  `duracao` varchar(50) DEFAULT NULL,
  `foto` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codigo_filme`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cine_auto.filmes: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `filmes` DISABLE KEYS */;
INSERT INTO `filmes` (`codigo_filme`, `nome_filme`, `sinopse`, `classificacao`, `genero`, `duracao`, `foto`) VALUES
	(1, 'Adão Negro', 'O poderoso Adão Negro é libertado de sua tumba para lançar sua justiça cruel sob a Terra.', '13', 'Ação/Fantasia', '125 min', 'black_adam'),
	(2, 'Caça Implacável', 'No filme CAÇA IMPLACÁVEL, Will Spann (Gerard Butler) está levando sua ex-esposa, Lisa (Jaimie Alexander), para a casa dos pais dela em uma pequena cidade. Quando param o carro em um posto de gasolina próximo à casa de Lisa, ela desaparece misteriosamente. Desesperado, Will recorre à polícia, mas não recebe apoio e ainda se torna o principal suspeito do caso. Decidido a encontrar Lisa de qualquer forma, Will começa uma corrida contra o tempo para achar Lisa com vida.', '14', 'Suspense', '95 min', 'caca_implacavel'),
	(3, 'Amsterdam', 'Uma fascinante história com um rico enredo que brilhantemente mescla fatos históricos e ficção para trazer uma experiência cinematográfica oportuna, o épico romance criminal original sobre três amigos que se encontram no centro de uma das mais secretas conspirações da história dos Estados Unidos.', '16', 'Drama', '135 min', 'amsterdam'),
	(4, 'As Aventuras de Tadeo 3', 'Neste novo capítulo, Tadeo mostra que seu maior sonho é ser aceito por seus colegas arqueólogos, mas seu comportamento naturalmente desastrado o atrapalha quando, acidentalmente, ele destrói um sarcófago raro e, como consequência, lança um feitiço que coloca em risco a vida de seus amigos. A jornada para salvar Mummy, Jeff e Belzoni desencadeará uma aventura carregada de ação que levará Tadeo e Sara a viajar para os mais distantes cantos do mundo em busca de uma forma de impedir a maldição da tábua de esmeralda.', 'Livre', 'Animação', '85 min', 'tadeo3'),
	(5, 'Sorria', 'Em Sorria, a narrativa acompanha Rose Cotter (Sosie Bacon), uma médica que começa a viver experiências aterrorizantes e que ela não consegue explicar, após testemunhar uma série de eventos traumáticos com seus pacientes. Enquanto Rose vê sua vida ser tomada por situações de horror, ela precisará confrontar seu passado conturbado para sobreviver a essa nova realidade.', '16', 'Terror', '115 min', 'sorria'),
	(6, 'A mulher Rei', 'A Mulher Rei é uma história memorável da Agojie, uma unidade de guerreiras composta apenas por mulheres que protegiam o reino africano de Dahomey nos anos 1800, com habilidades e uma força diferentes de tudo já visto. Inspirado em eventos reais, A Mulher Rei acompanha a emocionante jornada épica da General Nanisca (a atriz vencedora do Oscar® Viola Davis) enquanto ela treina uma nova geração de recrutas e as prepara para a batalha contra um inimigo determinado a destruir o modo de vida delas. Algumas coisas valem a luta…', '14', 'Ação', '135 min', 'mulher_rei');
/*!40000 ALTER TABLE `filmes` ENABLE KEYS */;

-- Copiando estrutura para tabela cine_auto.salas
CREATE TABLE IF NOT EXISTS `salas` (
  `numero_sala` int(11) NOT NULL,
  `3d` int(11) DEFAULT NULL,
  `dub_leg` char(50) DEFAULT NULL,
  PRIMARY KEY (`numero_sala`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cine_auto.salas: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `salas` DISABLE KEYS */;
INSERT INTO `salas` (`numero_sala`, `3d`, `dub_leg`) VALUES
	(1, 0, 'DUB'),
	(2, 0, 'DUB'),
	(3, 0, 'LEG'),
	(4, 1, 'LEG'),
	(5, 0, 'DUB'),
	(6, 1, 'DUB');
/*!40000 ALTER TABLE `salas` ENABLE KEYS */;

-- Copiando estrutura para tabela cine_auto.sessao
CREATE TABLE IF NOT EXISTS `sessao` (
  `cod_sessao` int(11) NOT NULL AUTO_INCREMENT,
  `numero_sala` int(11) NOT NULL DEFAULT '0',
  `cod_filme` int(11) DEFAULT NULL,
  `horario` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cod_sessao`),
  KEY `cod_filme` (`cod_filme`),
  KEY `numero_sala` (`numero_sala`),
  CONSTRAINT `FK_sessao_filmes` FOREIGN KEY (`cod_filme`) REFERENCES `filmes` (`codigo_filme`),
  CONSTRAINT `FK_sessao_salas` FOREIGN KEY (`numero_sala`) REFERENCES `salas` (`numero_sala`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cine_auto.sessao: ~11 rows (aproximadamente)
/*!40000 ALTER TABLE `sessao` DISABLE KEYS */;
INSERT INTO `sessao` (`cod_sessao`, `numero_sala`, `cod_filme`, `horario`) VALUES
	(1, 1, 1, '16:35'),
	(2, 1, 1, '19:10'),
	(3, 2, 1, '18:30'),
	(4, 2, 1, '21:10'),
	(5, 3, 1, '17:55'),
	(6, 3, 1, '20:30'),
	(7, 4, 1, '17:15'),
	(8, 4, 1, '19:50'),
	(9, 5, 1, '18:50'),
	(10, 5, 1, '21:25'),
	(11, 6, 1, '17:30');
/*!40000 ALTER TABLE `sessao` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
