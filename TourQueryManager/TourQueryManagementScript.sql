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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `finalizedqueries`
--

DROP TABLE IF EXISTS `finalizedqueries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `finalizedqueries` (
  `idfinalizedqueries` int(11) NOT NULL AUTO_INCREMENT,
  `queryid` varchar(20) NOT NULL,
  `userid` int(11) NOT NULL,
  `totalcost` int(11) NOT NULL,
  `specialinstructions` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`queryid`),
  UNIQUE KEY `idfinalizedqueries_UNIQUE` (`idfinalizedqueries`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `flightbookinginfo`
--

DROP TABLE IF EXISTS `flightbookinginfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `flightbookinginfo` (
  `idflightbookinginfo` int(11) NOT NULL AUTO_INCREMENT,
  `queryid` varchar(20) NOT NULL,
  `pnr` varchar(20) NOT NULL,
  `issuedate` date NOT NULL,
  `passangername` varchar(256) NOT NULL,
  `ticketnumber` varchar(256) DEFAULT NULL,
  `ffy` varchar(256) DEFAULT NULL,
  `amountfare` int(11) NOT NULL,
  `amountgst` int(11) NOT NULL,
  `amountsurcharge` int(11) NOT NULL,
  `flightinfo` varchar(100) NOT NULL,
  `departureinfo` varchar(256) NOT NULL,
  `arrivalinfo` varchar(256) NOT NULL,
  `statusinfo` varchar(256) NOT NULL,
  PRIMARY KEY (`pnr`,`queryid`,`departureinfo`),
  UNIQUE KEY `idflightbookinginfo_UNIQUE` (`idflightbookinginfo`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `hotelbookinginfo`
--

DROP TABLE IF EXISTS `hotelbookinginfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `hotelbookinginfo` (
  `idhotelbookinginfo` int(11) NOT NULL AUTO_INCREMENT,
  `queryid` varchar(20) NOT NULL,
  `idconfirmation` varchar(20) NOT NULL,
  `idhotelinfo` int(11) NOT NULL,
  `confirmby` varchar(45) DEFAULT NULL,
  `checkindate` datetime DEFAULT NULL,
  `checkoutdate` datetime DEFAULT NULL,
  `bookingprice` int(11) DEFAULT NULL,
  `leadpassangername` varchar(45) DEFAULT NULL,
  `roomtype` varchar(45) NOT NULL,
  `mealplan` varchar(45) DEFAULT NULL,
  `countroom` int(11) DEFAULT '0',
  `countadults` int(11) DEFAULT '0',
  `countchildren` int(11) DEFAULT '0',
  `countinfants` int(11) DEFAULT '0',
  PRIMARY KEY (`queryid`,`idconfirmation`,`idhotelinfo`,`roomtype`),
  UNIQUE KEY `idhotelbookinginfo_UNIQUE` (`idhotelbookinginfo`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ledger`
--

DROP TABLE IF EXISTS `ledger`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ledger` (
  `idledger` int(11) NOT NULL AUTO_INCREMENT,
  `queryid` varchar(20) NOT NULL,
  `transactionid` varchar(20) NOT NULL,
  `transactiontime` datetime NOT NULL,
  `transactionmode` varchar(20) NOT NULL,
  `transactionamount` int(11) NOT NULL,
  `note` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`queryid`,`transactionid`),
  UNIQUE KEY `idledger_UNIQUE` (`idledger`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

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
  `narrationhdr` varchar(100) DEFAULT NULL,
  `narration` varchar(2500) DEFAULT NULL,
  `tourinclusions` varchar(2500) DEFAULT NULL,
  `sim` varchar(5) DEFAULT 'NO',
  `guide` varchar(5) DEFAULT 'NO',
  `additionalcost` int(11) DEFAULT NULL,
  PRIMARY KEY (`queryid`,`dayno`),
  UNIQUE KEY `idqueryworkinghotel_UNIQUE` (`idqueryworkingday`),
  KEY `foreignworkinghotelqueryid_idx` (`queryid`),
  CONSTRAINT `foreignworkinghotelqueryid` FOREIGN KEY (`queryid`) REFERENCES `queries` (`queryid`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

/* Insert default VALUES in	appusers and agents table using following two commnds */
LOCK TABLES `appusers` WRITE;
INSERT INTO `appusers` ( `username`, `password`, `name`, `phone`, `email`, `information`) VALUES ( 'Administrator', 'Password', 'Administrator', '1234567890', 'admin@office.123', 'Admin Account of the company' );
UNLOCK TABLES;
LOCK TABLES `agents` WRITE;
INSERT INTO `agents` ( `name`, `phone`, `email`, `information`) VALUES ( 'INDIVIDUAL', '9876543210', 'individual@company.com', 'This is the default entry in the database');
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

-- Dump completed on 2018-11-27 14:07:21
