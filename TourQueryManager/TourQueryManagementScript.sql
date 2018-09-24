CREATE DATABASE  IF NOT EXISTS `tourquerymanagement` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `tourquerymanagement`;
-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: 10.0.2.2    Database: tourquerymanagement
-- ------------------------------------------------------
-- Server version	8.0.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `agents`
--

DROP TABLE IF EXISTS `agents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `agents` (
  `agentid` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `phone` varchar(45) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  `information` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`agentid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agents`
--

LOCK TABLES `agents` WRITE;
/*!40000 ALTER TABLE `agents` DISABLE KEYS */;
INSERT INTO `agents` VALUES (1,'INDIVIDUAL','9876543210','individual@company.com','This is the default entry in the database');
/*!40000 ALTER TABLE `agents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appusers`
--

DROP TABLE IF EXISTS `appusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `appusers` (
  `userid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `phone` varchar(45) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  `information` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`userid`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appusers`
--

LOCK TABLES `appusers` WRITE;
/*!40000 ALTER TABLE `appusers` DISABLE KEYS */;
INSERT INTO `appusers` VALUES (1,'Administrator','Password','Administrator','1234567890','admin@office.123','Admin Account of the company'),(2,'manoj','manoj','manoj','898908','jkhkjh','jkhk');
/*!40000 ALTER TABLE `appusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hotelinfo`
--

DROP TABLE IF EXISTS `hotelinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `hotelinfo` (
  `idhotelinfo` int(11) NOT NULL AUTO_INCREMENT,
  `hotelarea` varchar(45) NOT NULL,
  `hotelcity` varchar(45) NOT NULL,
  `hotelname` varchar(45) NOT NULL,
  `hotelrating` varchar(10) DEFAULT NULL,
  `hoteladdress` varchar(255) DEFAULT NULL,
  `hotelextrainfo` varchar(255) DEFAULT NULL,
  `contact` varchar(45) DEFAULT NULL,
  `hotelemail` varchar(45) DEFAULT NULL,
  `hotelphone` varchar(45) DEFAULT NULL,
  `hotelmobile` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`hotelarea`,`hotelcity`,`hotelname`),
  UNIQUE KEY `idhotelinfo_UNIQUE` (`idhotelinfo`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hotelinfo`
--

LOCK TABLES `hotelinfo` WRITE;
/*!40000 ALTER TABLE `hotelinfo` DISABLE KEYS */;
INSERT INTO `hotelinfo` VALUES (3,'north east','guwahati','oberoi','5 STAR','hkjh','hkjhkjhk','4585','vggjhghj','678676798','6967969687'),(1,'north east','tezpur','taj','5 STAR','hkjhk','hjkhjkhkj','7879987','bhjkhkj','789789798','7987897897');
/*!40000 ALTER TABLE `hotelinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hotelrates`
--

DROP TABLE IF EXISTS `hotelrates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `hotelrates` (
  `idhotelrates` int(11) NOT NULL AUTO_INCREMENT,
  `idhotelinfo` int(11) NOT NULL,
  `roomtype` varchar(45) NOT NULL,
  `seasontype` varchar(45) NOT NULL,
  `seasonyear` varchar(5) NOT NULL,
  `mealepaipricesingle` int(11) DEFAULT NULL,
  `mealepaipricedouble` int(11) DEFAULT NULL,
  `mealepaipriceextbed` int(11) DEFAULT NULL,
  `mealcpaipricesingle` int(11) DEFAULT NULL,
  `mealcpaipricedouble` int(11) DEFAULT NULL,
  `mealcpaipriceextbed` int(11) DEFAULT NULL,
  `mealmapaipricesingle` int(11) DEFAULT NULL,
  `mealmapaipricedouble` int(11) DEFAULT NULL,
  `mealmapaipriceextbed` int(11) DEFAULT NULL,
  `mealapaipricesingle` int(11) DEFAULT NULL,
  `mealapaipricedouble` int(11) DEFAULT NULL,
  `mealapaipriceextbed` int(11) DEFAULT NULL,
  PRIMARY KEY (`idhotelinfo`,`roomtype`,`seasontype`,`seasonyear`),
  UNIQUE KEY `idhotelrates_UNIQUE` (`idhotelrates`),
  CONSTRAINT `foreignKeyHotelId` FOREIGN KEY (`idhotelinfo`) REFERENCES `hotelinfo` (`idhotelinfo`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hotelrates`
--

LOCK TABLES `hotelrates` WRITE;
/*!40000 ALTER TABLE `hotelrates` DISABLE KEYS */;
INSERT INTO `hotelrates` VALUES (1,1,'basic','OFF SEASON','2018',789,7987,878,787,97,7,7777786,6666,6,77979,7877,7798),(2,1,'delux','OFF SEASON','2018',7,98,888,8098,898,88908,88,898,88,989,898,988),(3,3,'basic','PEAK SEASON','2018',789789,7878,777789,7787797,8979798,787,98798,79877,7979,9798,7987,8977),(4,3,'delux','OFF SEASON','2018',56,556,767,6759,6556,454564,658,697,78,876,68768,768);
/*!40000 ALTER TABLE `hotelrates` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `queries`
--

DROP TABLE IF EXISTS `queries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `queries` (
  `queryno` int(11) NOT NULL AUTO_INCREMENT,
  `queryid` varchar(20) NOT NULL,
  `agentid` int(11) DEFAULT NULL,
  `userid` int(11) DEFAULT NULL,
  `profitmargin` int(11) DEFAULT NULL,
  `gstrate` int(11) DEFAULT NULL,
  `name` varchar(45) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `querystartdate` date NOT NULL,
  `querylastupdatetime` datetime NOT NULL,
  `querystoptime` datetime DEFAULT NULL,
  `querycurrentstate` int(11) NOT NULL,
  `place` varchar(45) NOT NULL,
  `destinationcovered` varchar(255) DEFAULT NULL,
  `fromdate` date DEFAULT NULL,
  `todate` date DEFAULT NULL,
  `adults` int(11) DEFAULT NULL,
  `children` int(11) DEFAULT NULL,
  `babies` int(11) DEFAULT NULL,
  `roomcount` int(11) DEFAULT NULL,
  `meal` varchar(45) DEFAULT NULL,
  `hotelcategory` varchar(45) DEFAULT NULL,
  `arrivaldate` time DEFAULT '00:00:00',
  `departuredate` time DEFAULT '00:00:00',
  `arrivalcity` varchar(45) DEFAULT NULL,
  `departurecity` varchar(45) DEFAULT NULL,
  `vehicalcategory` varchar(45) DEFAULT NULL,
  `requirement` varchar(45) DEFAULT NULL,
  `budget` int(11) DEFAULT NULL,
  `note` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`queryid`),
  UNIQUE KEY `queryid_UNIQUE` (`queryid`),
  UNIQUE KEY `queryno_UNIQUE` (`queryno`),
  KEY `foreignagents_idx` (`agentid`),
  KEY `foreignappuser_idx` (`userid`),
  CONSTRAINT `foreignagents` FOREIGN KEY (`agentid`) REFERENCES `agents` (`agentid`) ON DELETE SET NULL,
  CONSTRAINT `foreignappuser` FOREIGN KEY (`userid`) REFERENCES `appusers` (`userid`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `queries`
--

LOCK TABLES `queries` WRITE;
/*!40000 ALTER TABLE `queries` DISABLE KEYS */;
INSERT INTO `queries` VALUES (4,'51362018919121549',1,2,12,23,'Pankaj Yadav','989898','2018-09-19','2018-09-21 22:04:02',NULL,3,'GHAZIABAD','','2018-09-27','2018-09-30',5,2,0,3,'No Meal','','15:48:38','15:48:38','','','','Hotel Only',0,''),(5,'51362018922121222',1,2,15,25,'NIKHIL','NIKHIL CONTACT','2018-09-22','2018-09-22 12:22:50',NULL,1,'JAIPUR','','2018-09-27','2018-09-30',0,0,0,0,'No Meal','','15:48:38','15:48:38','','','','Hotel Only',0,'');
/*!40000 ALTER TABLE `queries` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `queryworkingday`
--

DROP TABLE IF EXISTS `queryworkingday`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `queryworkingday` (
  `idqueryworkingday` int(11) NOT NULL AUTO_INCREMENT,
  `queryid` varchar(20) NOT NULL,
  `dayno` int(11) NOT NULL,
  `date` date NOT NULL,
  `narrationhdr` varchar(45) DEFAULT NULL,
  `narration` varchar(2500) DEFAULT NULL,
  `tourinclusions` varchar(2500) DEFAULT NULL,
  `sim` varchar(5) DEFAULT 'NO',
  `guide` varchar(5) DEFAULT 'NO',
  `additionalcost` int(11) DEFAULT NULL,
  PRIMARY KEY (`queryid`,`dayno`),
  UNIQUE KEY `idqueryworkinghotel_UNIQUE` (`idqueryworkingday`),
  KEY `foreignworkinghotelqueryid_idx` (`queryid`),
  CONSTRAINT `foreignworkinghotelqueryid` FOREIGN KEY (`queryid`) REFERENCES `queries` (`queryid`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `queryworkingday`
--

LOCK TABLES `queryworkingday` WRITE;
/*!40000 ALTER TABLE `queryworkingday` DISABLE KEYS */;
INSERT INTO `queryworkingday` VALUES (10,'51362018919121549',1,'2018-09-29','DAY 1','Narration for day one',NULL,'NO','NO',2345),(11,'51362018919121549',2,'2018-09-30','DAY 2','Narration for day 2',NULL,'NO','NO',2345);
/*!40000 ALTER TABLE `queryworkingday` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `queryworkingflight`
--

DROP TABLE IF EXISTS `queryworkingflight`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `queryworkingflight` (
  `idqueryworkingflight` int(11) NOT NULL AUTO_INCREMENT,
  `idqueryworkingday` int(11) NOT NULL,
  `queryid` varchar(20) NOT NULL,
  `date` datetime DEFAULT NULL,
  `fromcity` varchar(45) DEFAULT NULL,
  `tocity` varchar(45) DEFAULT NULL,
  `flightnumber` varchar(45) DEFAULT NULL,
  `rateperticket` int(11) DEFAULT NULL,
  `personcount` int(11) DEFAULT NULL,
  `note` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idqueryworkingday`,`queryid`),
  UNIQUE KEY `idqueryworkingflight_UNIQUE` (`idqueryworkingflight`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `queryworkingflight`
--

LOCK TABLES `queryworkingflight` WRITE;
/*!40000 ALTER TABLE `queryworkingflight` DISABLE KEYS */;
INSERT INTO `queryworkingflight` VALUES (1,10,'51362018919121549','2018-09-29 12:12:12','ghaziabad','meerut','AI123',12345,3,NULL),(2,11,'51362018919121549','2018-09-30 13:14:15','meerut','ghaziabad','AI234',12234,3,NULL);
/*!40000 ALTER TABLE `queryworkingflight` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `queryworkinghotel`
--

DROP TABLE IF EXISTS `queryworkinghotel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `queryworkinghotel` (
  `idqueryworkingroom` int(11) NOT NULL AUTO_INCREMENT,
  `idqueryworkingday` int(11) NOT NULL,
  `queryid` varchar(20) NOT NULL,
  `hotelrating` varchar(10) NOT NULL,
  `idhotelinfo` int(11) NOT NULL,
  `date` date NOT NULL,
  `roomtype` varchar(45) NOT NULL,
  `mealplan` varchar(45) DEFAULT NULL,
  `singlebedprice` int(11) DEFAULT NULL,
  `doublebedprice` int(11) DEFAULT NULL,
  `extrabedprice` int(11) DEFAULT NULL,
  `note` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idqueryworkingday`,`queryid`,`hotelrating`),
  UNIQUE KEY `idqueryworkingroom_UNIQUE` (`idqueryworkingroom`),
  KEY `foriegnkeyqueryid_idx` (`queryid`),
  KEY `foreignkeyhotelid_idx` (`idhotelinfo`),
  CONSTRAINT `foriegnkeydayid` FOREIGN KEY (`idqueryworkingday`) REFERENCES `queryworkingday` (`idqueryworkingday`),
  CONSTRAINT `foriegnkeyqueryid` FOREIGN KEY (`queryid`) REFERENCES `queries` (`queryid`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `queryworkinghotel`
--

LOCK TABLES `queryworkinghotel` WRITE;
/*!40000 ALTER TABLE `queryworkinghotel` DISABLE KEYS */;
INSERT INTO `queryworkinghotel` VALUES (15,10,'51362018919121549','4 STAR',3,'2018-09-29','deluxe','mapai',2000,2000,500,NULL),(13,10,'51362018919121549','5 STAR',1,'2018-09-29','deluxe','mapai',1500,2000,700,NULL),(14,11,'51362018919121549','4 STAR',3,'2018-09-30','deluxe','mapai',2000,2000,500,NULL),(16,11,'51362018919121549','5 STAR',1,'2018-09-30','deluxe','mapai',1500,2000,700,NULL);
/*!40000 ALTER TABLE `queryworkinghotel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `queryworkingtravel`
--

DROP TABLE IF EXISTS `queryworkingtravel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `queryworkingtravel` (
  `idqueryworkingtravel` int(11) NOT NULL AUTO_INCREMENT,
  `idqueryworkingday` int(11) NOT NULL,
  `queryid` varchar(20) NOT NULL,
  `date` date DEFAULT NULL,
  `cartype` varchar(45) DEFAULT NULL,
  `carcount` int(11) DEFAULT NULL,
  `pricepercar` int(11) DEFAULT NULL,
  `carhirefor` varchar(45) DEFAULT NULL,
  `note` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idqueryworkingday`,`queryid`),
  UNIQUE KEY `idqueryworkingtravel_UNIQUE` (`idqueryworkingtravel`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `queryworkingtravel`
--

LOCK TABLES `queryworkingtravel` WRITE;
/*!40000 ALTER TABLE `queryworkingtravel` DISABLE KEYS */;
INSERT INTO `queryworkingtravel` VALUES (1,10,'51362018919121549','2018-09-29','SEDAN',1,12345,'FULL DAY',NULL);
/*!40000 ALTER TABLE `queryworkingtravel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'tourquerymanagement'
--

--
-- Dumping routines for database 'tourquerymanagement'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-09-24 21:56:55
