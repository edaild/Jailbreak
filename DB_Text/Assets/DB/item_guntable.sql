-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: item
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
-- Table structure for table `guntable`
--

DROP TABLE IF EXISTS `guntable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `guntable` (
  `num` int NOT NULL AUTO_INCREMENT,
  `name` varchar(32) NOT NULL,
  `price` int NOT NULL,
  `bulletCount` int NOT NULL,
  `damage` varchar(32) NOT NULL,
  `gamePass` varchar(32) NOT NULL,
  PRIMARY KEY (`num`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `guntable`
--

LOCK TABLES `guntable` WRITE;
/*!40000 ALTER TABLE `guntable` DISABLE KEYS */;
INSERT INTO `guntable` VALUES (1,'권총',0,8,'15','N'),(2,'소음기 권총',0,8,'15','SWAT'),(3,'리볼버',10000,6,'25','N'),(4,'플린트락',10000,1,'45','N'),(5,'우지 기관단총',25000,15,'7','N'),(6,'소총',0,30,'5','SWAT, BOSS'),(7,'AK-47',15000,30,'6','N'),(8,'저격소총',50000,1,'40','N'),(9,'샷건',1000,5,'30','N'),(10,'플라즈마 권총',50000,20,'6','N'),(11,'플라즈마 샷건',50000,4,'6','N'),(12,'로켓 런처',40000,10,'76','N');
/*!40000 ALTER TABLE `guntable` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-01-11 16:48:47
