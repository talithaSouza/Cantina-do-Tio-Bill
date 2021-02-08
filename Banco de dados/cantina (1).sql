-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 08-Fev-2021 às 03:12
-- Versão do servidor: 10.4.17-MariaDB
-- versão do PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cantina`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `Nome` varchar(30) DEFAULT NULL,
  `Sobrenome` varchar(30) DEFAULT NULL,
  `Telefone` varchar(20) NOT NULL,
  `Bairro` varchar(10) NOT NULL,
  `rua` varchar(10) NOT NULL,
  `numero` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`id`, `Nome`, `Sobrenome`, `Telefone`, `Bairro`, `rua`, `numero`) VALUES
(1, 'Teste', 'um', '6666-9999', '', '', 0),
(2, 'Cliente', 'Um', '00000000000', '', '', 0),
(5, 'Caroline', 'Araujo de França', '', 'Junco', 'Paulo', 90);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedidos`
--

CREATE TABLE `pedidos` (
  `id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_quentinha` int(11) NOT NULL,
  `valor_pedido` decimal(10,0) NOT NULL,
  `data_criacao` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `quentinhas`
--

CREATE TABLE `quentinhas` (
  `id` int(11) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `opCarne` varchar(11) NOT NULL,
  `ingrediente1` varchar(30) NOT NULL,
  `ingrediente2` varchar(30) NOT NULL,
  `ingrediente3` varchar(30) NOT NULL,
  `Ingrediente4` varchar(30) NOT NULL,
  `Ingrediente5` varchar(30) NOT NULL,
  `valor` decimal(30,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `quentinhas`
--

INSERT INTO `quentinhas` (`id`, `nome`, `opCarne`, `ingrediente1`, `ingrediente2`, `ingrediente3`, `Ingrediente4`, `Ingrediente5`, `valor`) VALUES
(1, 'Baião', 'frango', 'macarrão', 'farofa de cuscuz', 'batata frita', 'alface', 'vinagrete', '8'),
(2, 'Vegetariana', 'Strognoff d', 'arrroz', 'macarrão', 'batata palha', 'salada de batata', 'alface', '9'),
(3, 'Fit', 'Frango Grel', 'Arroz Integral', 'Macarrão integral', 'Alface', 'salade de legumes', 'purê', '11'),
(5, 'Duas opções de Carne', 'Frango', 'Linguiça', 'Arroz', 'Macarrão', 'Farofa', 'Salada', '10'),
(6, 'Maria Isabel', 'Frango desf', 'Arroz com caldo de galinha', 'milho', 'cheiro verde', 'purê de batata', 'cenoura ralada', '10');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `sobrenome` varchar(30) NOT NULL,
  `user` varchar(30) NOT NULL,
  `senha` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `sobrenome`, `user`, `senha`) VALUES
(1, 'tio', 'bill', 'bill', 'bill'),
(2, 'talitha', 'souza', 'talitha_souza', 'talithasouza'),
(3, 'user1', 'teste', 'user1_teste', 'user'),
(4, 'carol', 'araujo', 'carol_araujo', 'carol'),
(9, 'julia', 'silva', 'julia_SIlva', 'silvasilva');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_id_cliente_clientes` (`id_cliente`),
  ADD KEY `fk_id_quentinha_quentinhas` (`id_quentinha`);

--
-- Índices para tabela `quentinhas`
--
ALTER TABLE `quentinhas`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `quentinhas`
--
ALTER TABLE `quentinhas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `fk_id_cliente_clientes` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id`),
  ADD CONSTRAINT `fk_id_quentinha_quentinhas` FOREIGN KEY (`id_quentinha`) REFERENCES `quentinhas` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
