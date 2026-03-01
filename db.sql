-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: errekuperaketa
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `erreserba`
--

DROP TABLE IF EXISTS `erreserba`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `erreserba` (
  `erreserbaId` int NOT NULL AUTO_INCREMENT,
  `pelikulaId` int NOT NULL,
  `erreserbaIzena` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `eserlekuKopurua` int NOT NULL,
  `erreserbaData` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`erreserbaId`),
  KEY `pelikulaId` (`pelikulaId`),
  CONSTRAINT `erreserba_ibfk_1` FOREIGN KEY (`pelikulaId`) REFERENCES `pelikula` (`pelikulaId`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `erreserba`
--

LOCK TABLES `erreserba` WRITE;
/*!40000 ALTER TABLE `erreserba` DISABLE KEYS */;
INSERT INTO `erreserba` VALUES (1,1,'Aitor Etxeberria',3,'2026-02-10 18:30:00'),(2,1,'Maialen Garai',2,'2026-02-10 19:00:00'),(3,1,'Jon Aranburu',5,'2026-02-10 19:15:00'),(4,2,'Ane Lasa',4,'2026-02-11 17:00:00'),(5,2,'Mikel Sanz',1,'2026-02-11 17:10:00'),(6,3,'Leire Agirre',2,'2026-02-12 20:00:00'),(7,3,'Unai Mendizabal',5,'2026-02-12 20:05:00'),(8,3,'Iker Ruiz',3,'2026-02-12 20:10:00'),(9,4,'Nerea Lopez',5,'2026-02-13 21:00:00'),(10,4,'Ander Perez',5,'2026-02-13 21:05:00'),(11,4,'June Garcia',5,'2026-02-13 21:10:00'),(12,4,'Asier Torres',5,'2026-02-13 21:15:00'),(13,5,'Ibai Fernandez',2,'2026-02-14 18:00:00'),(14,6,'Irati Alonso',4,'2026-02-15 16:00:00'),(15,7,'Gorka Martinez',1,'2026-02-15 22:00:00'),(16,1,'Andoni',5,'2026-02-28 14:29:50'),(17,1,'Maialen',3,'2026-02-28 18:01:47');
/*!40000 ALTER TABLE `erreserba` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pelikula`
--

DROP TABLE IF EXISTS `pelikula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pelikula` (
  `pelikulaId` int NOT NULL AUTO_INCREMENT,
  `izenburua` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `deskribapena` text COLLATE utf8mb4_unicode_ci,
  `eserlekuGuztira` int NOT NULL,
  `ezabatuta` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`pelikulaId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pelikula`
--

LOCK TABLES `pelikula` WRITE;
/*!40000 ALTER TABLE `pelikula` DISABLE KEYS */;
INSERT INTO `pelikula` VALUES (1,'Avatar','Zientzia fikziozko pelikula epikoa',95,0),(2,'Inception','Ametsen barruan gertatzen den thriller psikologikoa',80,0),(3,'Interstellar 2','Espazioan zehar bidaia gizateriaren etorkizuna salbatzeko',120,0),(4,'Titanic','Drama erromantikoa eta historikoa',150,0),(5,'The Dark Knight','Batmanen istorio iluna Jokerrekin',90,0),(6,'Frozen','Animaziozko pelikula familiarra',60,1),(7,'Matrix','Errealitate birtualaren inguruko zientzia fikzioa',2,0),(8,'Gladiator','Erromatar inperioan kokatutako akzio drama',110,0);
/*!40000 ALTER TABLE `pelikula` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-03-01 16:42:06
