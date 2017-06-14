










































-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 06/12/2017 16:32:19

-- Generated from EDMX file: F:\Works\SimpleDemo\SimpleDemo\MySQLConn.edmx
-- Target version: 3.0.0.0

-- --------------------------------------------------



-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------



-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;

    DROP TABLE IF EXISTS `tab1`;

SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------


CREATE TABLE `tab1`(
	`id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`name` varchar (100));

ALTER TABLE `tab1` ADD PRIMARY KEY (`id`);





CREATE TABLE `tab2Set`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Amount` decimal( 10, 2 )  NOT NULL);

ALTER TABLE `tab2Set` ADD PRIMARY KEY (`Id`);







-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
