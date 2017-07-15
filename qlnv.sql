/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50505
Source Host           : 127.0.0.1:3306
Source Database       : qlnv

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2016-12-27 23:23:47
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for chamcong
-- ----------------------------
DROP TABLE IF EXISTS `chamcong`;
CREATE TABLE `chamcong` (
  `MaCN` varchar(5) NOT NULL,
  `NgayCC` date DEFAULT NULL,
  `MaSP` varchar(10) NOT NULL,
  `SoLuongSP` int(5) NOT NULL,
  PRIMARY KEY (`MaCN`,`MaSP`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of chamcong
-- ----------------------------
INSERT INTO `chamcong` VALUES ('01', '2016-12-13', '01', '3');
INSERT INTO `chamcong` VALUES ('02', '2016-12-13', '02', '10');
INSERT INTO `chamcong` VALUES ('03', '2016-12-13', '03', '15');

-- ----------------------------
-- Table structure for danhmucsp
-- ----------------------------
DROP TABLE IF EXISTS `danhmucsp`;
CREATE TABLE `danhmucsp` (
  `MaSP` varchar(5) NOT NULL,
  `TenSP` varchar(20) NOT NULL,
  `DVT` varchar(10) NOT NULL,
  PRIMARY KEY (`MaSP`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of danhmucsp
-- ----------------------------
INSERT INTO `danhmucsp` VALUES ('01', 'áo vét', 'cái');
INSERT INTO `danhmucsp` VALUES ('02', 'váy công sở', 'cái');
INSERT INTO `danhmucsp` VALUES ('03', 'quần tây', 'cái');

-- ----------------------------
-- Table structure for hosocn
-- ----------------------------
DROP TABLE IF EXISTS `hosocn`;
CREATE TABLE `hosocn` (
  `MaCN` varchar(5) NOT NULL,
  `HoTen` varchar(50) NOT NULL,
  `GioiTinh` bit(1) DEFAULT NULL,
  `NgaySinh` date NOT NULL,
  `NoiSinh` varchar(50) NOT NULL,
  `DiaChiHT` varchar(50) NOT NULL,
  `TrinhDoHV` varchar(10) NOT NULL,
  `NgayVaoLV` date NOT NULL,
  PRIMARY KEY (`MaCN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of hosocn
-- ----------------------------
INSERT INTO `hosocn` VALUES ('01', 'Lê Văn Khuê', '', '2016-12-28', 'quảng Ngãi', 'Nha Trang', '12/12', '2016-12-12');
INSERT INTO `hosocn` VALUES ('02', 'Nguyễn Xuân Phi', '', '1995-04-26', 'Quảng Trị', 'Nha Trang', '12/12', '2009-10-29');
INSERT INTO `hosocn` VALUES ('03', 'Trần Trương Huân', '', '2016-12-07', 'Nha Trang', 'Nha Trang', '12/12', '2016-12-31');

-- ----------------------------
-- Table structure for luong
-- ----------------------------
DROP TABLE IF EXISTS `luong`;
CREATE TABLE `luong` (
  `MaCN` varchar(5) NOT NULL,
  `NgayThang` date DEFAULT NULL,
  `Thuong` int(15) NOT NULL,
  `Luong` int(15) NOT NULL,
  PRIMARY KEY (`MaCN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of luong
-- ----------------------------
INSERT INTO `luong` VALUES ('', null, '0', '0');
INSERT INTO `luong` VALUES ('01', '2016-12-16', '500000', '5000000');
INSERT INTO `luong` VALUES ('02', '2016-12-16', '400000', '6500000');
INSERT INTO `luong` VALUES ('03', '2016-12-16', '200000', '3000000');

-- ----------------------------
-- Table structure for tamung
-- ----------------------------
DROP TABLE IF EXISTS `tamung`;
CREATE TABLE `tamung` (
  `MaCN` varchar(5) NOT NULL,
  `NgayTU` date DEFAULT NULL,
  `SoTien` int(15) NOT NULL,
  PRIMARY KEY (`MaCN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tamung
-- ----------------------------
INSERT INTO `tamung` VALUES ('', null, '0');
INSERT INTO `tamung` VALUES ('01', '2016-06-21', '1000000');
INSERT INTO `tamung` VALUES ('02', '2016-12-06', '1500000');
