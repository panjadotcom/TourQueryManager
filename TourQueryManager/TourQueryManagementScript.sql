CREATE DATABASE `tourquerymanagement` /*!40100 DEFAULT CHARACTER SET latin1 */;

CREATE TABLE `tourquerymanagement`.`appusers` (
  `userid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `phone` varchar(45) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  `information` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`userid`),
  UNIQUE KEY `username_UNIQUE` (`username`)
);

CREATE TABLE `tourquerymanagement`.`agents` (
  `agentid` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `phone` varchar(45) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  `information` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`agentid`)
);

CREATE TABLE `tourquerymanagement`.`hotelinfo` (
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
);

CREATE TABLE `tourquerymanagement`.`hotelrates` (
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
);

CREATE TABLE `tourquerymanagement`.`queries` (
  `queryno` int(11) NOT NULL AUTO_INCREMENT,
  `queryid` varchar(20) NOT NULL,
  `agentid` int(11) DEFAULT NULL,
  `userid` int(11) DEFAULT NULL,
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
  PRIMARY KEY (`queryno`),
  UNIQUE KEY `queryid_UNIQUE` (`queryid`),
  KEY `foreignagents_idx` (`agentid`),
  KEY `foreignappuser_idx` (`userid`),
  CONSTRAINT `foreignagents` FOREIGN KEY (`agentid`) REFERENCES `agents` (`agentid`) ON DELETE SET NULL,
  CONSTRAINT `foreignappuser` FOREIGN KEY (`userid`) REFERENCES `appusers` (`userid`) ON DELETE SET NULL
);

CREATE TABLE `queryworkingday` (
  `idqueryworkingday` int(11) NOT NULL AUTO_INCREMENT,
  `queryid` varchar(20) NOT NULL,
  `dayno` int(11) NOT NULL,
  `area` varchar(45) DEFAULT NULL,
  `city` varchar(45) DEFAULT NULL,
  `hotel` varchar(45) DEFAULT NULL,
  `pricehotel` int(11) DEFAULT NULL,
  `narrationhdr` varchar(45) DEFAULT NULL,
  `narration` varchar(2500) DEFAULT NULL,
  `additionalcost` int(11) DEFAULT NULL,
  `usercomment` varchar(2500) DEFAULT NULL,
  `sim` varchar(5) DEFAULT 'NO',
  `guide` varchar(5) DEFAULT 'NO',
  PRIMARY KEY (`queryid`,`dayno`),
  UNIQUE KEY `idqueryworkinghotel_UNIQUE` (`idqueryworkingday`),
  KEY `foreignworkinghotelqueryid_idx` (`queryid`),
  CONSTRAINT `foreignworkinghotelqueryid` FOREIGN KEY (`queryid`) REFERENCES `queries` (`queryid`)
);

CREATE TABLE `queryworkingroom` (
  `idqueryworkingroom` int(11) NOT NULL AUTO_INCREMENT,
  `idqueryqorkingday` int(11) NOT NULL,
  `queryid` varchar(20) NOT NULL,
  `dayno` int(11) NOT NULL,
  `roomtype` varchar(45) NOT NULL,
  `mealplan` varchar(45) DEFAULT NULL,
  `extrabed` varchar(5) NOT NULL DEFAULT 'NO',
  `roomprice` int(11) DEFAULT NULL,
  UNIQUE KEY `idqueryworkingroom_UNIQUE` (`idqueryworkingroom`),
  KEY `foriegnkeyqueryid_idx` (`queryid`),
  CONSTRAINT `foriegnkeyqueryid` FOREIGN KEY (`queryid`) REFERENCES `queries` (`queryid`)
);


INSERT INTO `tourquerymanagement`.`appusers` (
 `username`,
 `password`,
 `name`,
 `phone`,
 `email`,
 `information`)
 VALUES (
 'Administrator',
 'Password',
 'Administrator',
 '1234567890',
 'admin@office.123',
 'Admin Account of the company'
 );


INSERT INTO `tourquerymanagement`.`agents` (
 `name`,
 `phone`,
 `email`,
 `information`)
 VALUES (
 'INDIVIDUAL',
 '9876543210',
 'individual@company.com',
 'This is the default entry in the database'
 );