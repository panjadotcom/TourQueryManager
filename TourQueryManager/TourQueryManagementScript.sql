CREATE DATABASE `tourquerymanagement` /*!40100 DEFAULT CHARACTER SET latin1 */;

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
 
 CREATE TABLE `agents` (
   `agentid` int(11) NOT NULL AUTO_INCREMENT,
   `name` varchar(45) NOT NULL,
   `phone` varchar(45) NOT NULL,
   `email` varchar(45) DEFAULT NULL,
   `information` varchar(255) DEFAULT NULL,
   PRIMARY KEY (`clientid`)
 ) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
 
CREATE TABLE `queries` (
   `queryno` int(11) NOT NULL AUTO_INCREMENT,
   `queryid` bigint(20) NOT NULL,
   `clientid` int(11) DEFAULT NULL,
   `userid` int(11) DEFAULT NULL,
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
   `arrivaldate` date DEFAULT NULL,
   `departuredate` date DEFAULT NULL,
   `arrivalcity` varchar(45) DEFAULT NULL,
   `departurecity` varchar(45) DEFAULT NULL,
   `vehicalcategory` varchar(45) DEFAULT NULL,
   `requirement` varchar(45) DEFAULT NULL,
   `budget` int(11) DEFAULT NULL,
   `note` varchar(255) DEFAULT NULL,
   PRIMARY KEY (`queryno`),
   UNIQUE KEY `queryid_UNIQUE` (`queryid`),
   KEY `userid_idx` (`userid`),
   KEY `foreignclient_idx` (`clientid`),
   CONSTRAINT `foreignappuser` FOREIGN KEY (`userid`) REFERENCES `appusers` (`userid`) ON DELETE SET NULL ON UPDATE NO ACTION,
   CONSTRAINT `foreignclient` FOREIGN KEY (`clientid`) REFERENCES `clients` (`clientid`) ON DELETE SET NULL ON UPDATE NO ACTION
 ) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
 
 CREATE TABLE `tourquerymanagement`.`queryworkinghotel` (
  `idqueryworkinghotel` INT NOT NULL AUTO_INCREMENT,
  `queryid` BIGINT(20) NOT NULL,
  `dayno` INT NOT NULL,
  `roomno` INT NOT NULL,
  `area` VARCHAR(45) NULL,
  `city` VARCHAR(45) NULL,
  `hotel` VARCHAR(45) NULL,
  `roomtype` VARCHAR(45) NULL,
  `mealplan` VARCHAR(45) NULL,
  `extrabed` VARCHAR(45) NULL,
  `extrameal` VARCHAR(45) NULL,
  `price` DOUBLE NULL,
  INDEX `foreignworkinghotelqueryid_idx` (`queryid` ASC),
  PRIMARY KEY (`queryid`, `dayno`, `roomno`),
  UNIQUE INDEX `idqueryworkinghotel_UNIQUE` (`idqueryworkinghotel` ASC),
  CONSTRAINT `foreignworkinghotelqueryid`
    FOREIGN KEY (`queryid`)
    REFERENCES `tourquerymanagement`.`queries` (`queryid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


  CREATE TABLE `hotelinfo` (
   `idhotelinfo` int(11) NOT NULL AUTO_INCREMENT,
   `hotelarea` varchar(45) NOT NULL,
   `hotelcity` varchar(45) NOT NULL,
   `hotelname` varchar(45) NOT NULL,
   `hotelrating` int(11) DEFAULT NULL,
   `hoteladdress` varchar(255) DEFAULT NULL,
   `hotelextrainfo` varchar(255) DEFAULT NULL,
   `contact` varchar(45) DEFAULT NULL,
   `hotelemail` varchar(45) DEFAULT NULL,
   `hotelphone` varchar(45) DEFAULT NULL,
   `hotelmobile` varchar(45) DEFAULT NULL,
   `roomtype` varchar(45) DEFAULT NULL,
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
   PRIMARY KEY (`hotelarea`,`hotelcity`,`hotelname`),
   UNIQUE KEY `idhotelinfo_UNIQUE` (`idhotelinfo`)
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
 
 ALTER TABLE `tourquerymanagement`.`queries`
 AUTO_INCREMENT = 1 ;
 
 ALTER TABLE `tourquerymanagement`.`clients`
 AUTO_INCREMENT = 1 ;
 
 ALTER TABLE `tourquerymanagement`.`appusers`
 AUTO_INCREMENT = 1 ;
 
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
 'This is the default entry in the database');
 
 SELECT * FROM `appusers`;
 SELECT * FROM `clients`;
 SELECT * FROM `queries`;
 SHOW CREATE TABLE `appusers`;
 SHOW CREATE TABLE `clients`;
 SHOW CREATE TABLE `queries`;