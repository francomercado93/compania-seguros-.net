CREATE DATABASE  IF NOT EXISTS `companiadesegurostp` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `companiadesegurostp`;
-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: companiadesegurostp
-- ------------------------------------------------------
-- Server version	8.0.13

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
-- Table structure for table `agente`
--

DROP TABLE IF EXISTS `agente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `agente` (
  `idAgente` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `Telefono` int(11) DEFAULT NULL,
  `DNI` int(11) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idAgente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agente`
--

LOCK TABLES `agente` WRITE;
/*!40000 ALTER TABLE `agente` DISABLE KEYS */;
INSERT INTO `agente` VALUES (1,'Fabian','Park',1231231,1,'Av. Falsa 123'),(774415,'Homero','Thompson',7181989,12408090,'Av. de los Incas 220'),(774420,'Bob','Patiño',4598353,28564545,'Matheu 3565'),(774956,'Frank','Grimes',5246566,31649788,'Alvear 1340');
/*!40000 ALTER TABLE `agente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asegurado`
--

DROP TABLE IF EXISTS `asegurado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `asegurado` (
  `idA` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `DNI` int(11) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `LazoFamiiar` varchar(45) DEFAULT NULL,
  `idCostoEdad` int(11) NOT NULL,
  `idprofesion` int(11) NOT NULL,
  PRIMARY KEY (`idA`),
  KEY `IdProfesion_idx` (`idprofesion`),
  KEY `IdCostoEdad_idx` (`idCostoEdad`),
  CONSTRAINT `IdCostoEdad` FOREIGN KEY (`idCostoEdad`) REFERENCES `costoedad` (`idedad`),
  CONSTRAINT `IdProfesion` FOREIGN KEY (`idprofesion`) REFERENCES `profesion` (`idprofesion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asegurado`
--

LOCK TABLES `asegurado` WRITE;
/*!40000 ALTER TABLE `asegurado` DISABLE KEYS */;
/*!40000 ALTER TABLE `asegurado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `automovil`
--

DROP TABLE IF EXISTS `automovil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `automovil` (
  `idSeguro` int(11) NOT NULL,
  `Descuento` int(11) DEFAULT NULL,
  `Recargo` int(11) DEFAULT NULL,
  `Antiguedad` int(11) DEFAULT NULL,
  `Patente` varchar(45) DEFAULT NULL,
  `idCobertura` int(11) DEFAULT NULL,
  `idConductor` int(11) DEFAULT NULL,
  `idModelo` int(11) DEFAULT NULL,
  `idZona` int(11) DEFAULT NULL,
  `idFranquicia` int(11) DEFAULT NULL,
  PRIMARY KEY (`idSeguro`),
  KEY `fk_Automovil_Cobertura1_idx` (`idCobertura`),
  KEY `idConductor_idx` (`idConductor`),
  KEY `idZona_idx` (`idZona`),
  KEY `idFranquiciaFK_idx` (`idFranquicia`),
  KEY `idModeloFK_idx` (`idModelo`),
  CONSTRAINT `IdSeguroAutFK` FOREIGN KEY (`idSeguro`) REFERENCES `seguro` (`idseguro`),
  CONSTRAINT `fk_Automovil_Cobertura1` FOREIGN KEY (`idCobertura`) REFERENCES `cobertura` (`idcobertura`),
  CONSTRAINT `idConductorFK` FOREIGN KEY (`idConductor`) REFERENCES `conductor` (`idconductor`),
  CONSTRAINT `idFranquiciaFK` FOREIGN KEY (`idFranquicia`) REFERENCES `franquicia` (`idfranquicia`),
  CONSTRAINT `idModeloFK` FOREIGN KEY (`idModelo`) REFERENCES `modelo` (`idmodelo`),
  CONSTRAINT `idZonaFK` FOREIGN KEY (`idZona`) REFERENCES `zona` (`idzona`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `automovil`
--

LOCK TABLES `automovil` WRITE;
/*!40000 ALTER TABLE `automovil` DISABLE KEYS */;
/*!40000 ALTER TABLE `automovil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `autoscoring`
--

DROP TABLE IF EXISTS `autoscoring`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `autoscoring` (
  `Dni` int(11) NOT NULL,
  `CantidadSiniestros` int(11) DEFAULT NULL,
  PRIMARY KEY (`Dni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autoscoring`
--

LOCK TABLES `autoscoring` WRITE;
/*!40000 ALTER TABLE `autoscoring` DISABLE KEYS */;
/*!40000 ALTER TABLE `autoscoring` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `beneficiario`
--

DROP TABLE IF EXISTS `beneficiario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `beneficiario` (
  `idB` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `DNI` int(11) DEFAULT NULL,
  `Porcentaje` int(11) DEFAULT NULL,
  `LazoFamiliar` varchar(45) NOT NULL,
  PRIMARY KEY (`idB`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `beneficiario`
--

LOCK TABLES `beneficiario` WRITE;
/*!40000 ALTER TABLE `beneficiario` DISABLE KEYS */;
/*!40000 ALTER TABLE `beneficiario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cambioestado`
--

DROP TABLE IF EXISTS `cambioestado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cambioestado` (
  `idEstadoAnterior` int(11) NOT NULL,
  `idEstadoSiguiente` int(11) NOT NULL,
  `fechaCambioEstado` date DEFAULT NULL,
  PRIMARY KEY (`idEstadoAnterior`,`idEstadoSiguiente`),
  KEY `idEstadoSigFK_idx` (`idEstadoSiguiente`),
  CONSTRAINT `idEstadoAntFK` FOREIGN KEY (`idEstadoAnterior`) REFERENCES `estado` (`idestado`),
  CONSTRAINT `idEstadoSigFK` FOREIGN KEY (`idEstadoSiguiente`) REFERENCES `estado` (`idestado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cambioestado`
--

LOCK TABLES `cambioestado` WRITE;
/*!40000 ALTER TABLE `cambioestado` DISABLE KEYS */;
/*!40000 ALTER TABLE `cambioestado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `categoria` (
  `idCategoria` int(11) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Valor` double DEFAULT NULL,
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cobertura`
--

DROP TABLE IF EXISTS `cobertura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cobertura` (
  `idCobertura` int(11) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Valor` int(11) DEFAULT NULL,
  PRIMARY KEY (`idCobertura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cobertura`
--

LOCK TABLES `cobertura` WRITE;
/*!40000 ALTER TABLE `cobertura` DISABLE KEYS */;
/*!40000 ALTER TABLE `cobertura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comision`
--

DROP TABLE IF EXISTS `comision`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `comision` (
  `idComision` int(11) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `PorcentajePorTipo` int(11) DEFAULT NULL,
  PRIMARY KEY (`idComision`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comision`
--

LOCK TABLES `comision` WRITE;
/*!40000 ALTER TABLE `comision` DISABLE KEYS */;
/*!40000 ALTER TABLE `comision` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conductor`
--

DROP TABLE IF EXISTS `conductor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `conductor` (
  `idConductor` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `DNI` int(11) DEFAULT NULL,
  `idCostoEdad` int(11) DEFAULT NULL,
  PRIMARY KEY (`idConductor`),
  KEY `DNIFK_idx` (`DNI`),
  KEY `idCostoEdadFK_idx` (`idCostoEdad`),
  CONSTRAINT `DNIFK` FOREIGN KEY (`DNI`) REFERENCES `autoscoring` (`dni`),
  CONSTRAINT `idCostoEdadFK` FOREIGN KEY (`idCostoEdad`) REFERENCES `costoedad` (`idedad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conductor`
--

LOCK TABLES `conductor` WRITE;
/*!40000 ALTER TABLE `conductor` DISABLE KEYS */;
/*!40000 ALTER TABLE `conductor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `continente`
--

DROP TABLE IF EXISTS `continente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `continente` (
  `idContinente` int(11) NOT NULL,
  `Descripcion` varchar(45) NOT NULL,
  `Valor` double NOT NULL,
  PRIMARY KEY (`idContinente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `continente`
--

LOCK TABLES `continente` WRITE;
/*!40000 ALTER TABLE `continente` DISABLE KEYS */;
INSERT INTO `continente` VALUES (1,'Casa',900000),(2,'Departamento',800000);
/*!40000 ALTER TABLE `continente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `costoedad`
--

DROP TABLE IF EXISTS `costoedad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `costoedad` (
  `idEdad` int(11) NOT NULL,
  `Edad` int(11) DEFAULT NULL,
  `IndiceRiesgo` int(11) DEFAULT NULL,
  `CostoEdadcol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idEdad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `costoedad`
--

LOCK TABLES `costoedad` WRITE;
/*!40000 ALTER TABLE `costoedad` DISABLE KEYS */;
/*!40000 ALTER TABLE `costoedad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cubre`
--

DROP TABLE IF EXISTS `cubre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cubre` (
  `idSeguroHogar` int(11) NOT NULL,
  `idRiesgo` int(11) NOT NULL,
  PRIMARY KEY (`idSeguroHogar`,`idRiesgo`),
  KEY `idRiesgo_fk_idx` (`idRiesgo`),
  CONSTRAINT `idRiesgo_fk` FOREIGN KEY (`idRiesgo`) REFERENCES `riesgo` (`idriesgo`),
  CONSTRAINT `idSeguroHogar_fk` FOREIGN KEY (`idSeguroHogar`) REFERENCES `hogar` (`idseguro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cubre`
--

LOCK TABLES `cubre` WRITE;
/*!40000 ALTER TABLE `cubre` DISABLE KEYS */;
INSERT INTO `cubre` VALUES (480020,1),(480033,1),(480099,1),(480304,1),(480875,1),(480962,1),(486989,1),(480099,2),(480256,2),(480962,2),(480099,3),(480256,3),(480598,3),(480905,3),(480020,4),(480099,4),(480875,4),(480962,4);
/*!40000 ALTER TABLE `cubre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuentacon`
--

DROP TABLE IF EXISTS `cuentacon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cuentacon` (
  `id_seguro_hogar` int(11) NOT NULL,
  `id_med_Seguridad` int(11) NOT NULL,
  PRIMARY KEY (`id_seguro_hogar`,`id_med_Seguridad`),
  KEY `id_SeguridaFK_idx` (`id_med_Seguridad`),
  CONSTRAINT `FKidMedidaSegurida` FOREIGN KEY (`id_med_Seguridad`) REFERENCES `medidaseguridad` (`idmedidaseguridad`),
  CONSTRAINT `fk_seguro_h` FOREIGN KEY (`id_seguro_hogar`) REFERENCES `hogar` (`idseguro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuentacon`
--

LOCK TABLES `cuentacon` WRITE;
/*!40000 ALTER TABLE `cuentacon` DISABLE KEYS */;
INSERT INTO `cuentacon` VALUES (480020,1),(480256,1),(480304,1),(480875,1),(480905,1),(486989,1),(480020,2),(480304,2),(480020,3),(480962,3),(486989,3),(480020,4),(480962,4),(480020,5),(486989,5),(480033,6),(480598,6),(480875,6),(486989,6),(480099,7),(480875,7),(480962,7);
/*!40000 ALTER TABLE `cuentacon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado`
--

DROP TABLE IF EXISTS `estado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `estado` (
  `idEstado` int(11) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idEstado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado`
--

LOCK TABLES `estado` WRITE;
/*!40000 ALTER TABLE `estado` DISABLE KEYS */;
INSERT INTO `estado` VALUES (22201,'Finalizado'),(22202,'En curso'),(22203,'Suspendido'),(22204,'Anulado');
/*!40000 ALTER TABLE `estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `franquicia`
--

DROP TABLE IF EXISTS `franquicia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `franquicia` (
  `idFranquicia` int(11) NOT NULL,
  `Valor` int(11) DEFAULT NULL,
  PRIMARY KEY (`idFranquicia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `franquicia`
--

LOCK TABLES `franquicia` WRITE;
/*!40000 ALTER TABLE `franquicia` DISABLE KEYS */;
/*!40000 ALTER TABLE `franquicia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historialpagos`
--

DROP TABLE IF EXISTS `historialpagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `historialpagos` (
  `idComisionFk` int(11) NOT NULL,
  `idAgenteFk` int(11) NOT NULL,
  `FechaPago` date DEFAULT NULL,
  PRIMARY KEY (`idComisionFk`,`idAgenteFk`),
  KEY `fk_Comisiones_has_Agente_Agente1_idx` (`idAgenteFk`),
  KEY `fk_Comisiones_has_Agente_Comisiones1_idx` (`idComisionFk`),
  CONSTRAINT `idAgenteFk` FOREIGN KEY (`idAgenteFk`) REFERENCES `agente` (`idagente`),
  CONSTRAINT `idComisionFK` FOREIGN KEY (`idComisionFk`) REFERENCES `comision` (`idcomision`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historialpagos`
--

LOCK TABLES `historialpagos` WRITE;
/*!40000 ALTER TABLE `historialpagos` DISABLE KEYS */;
/*!40000 ALTER TABLE `historialpagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hogar`
--

DROP TABLE IF EXISTS `hogar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `hogar` (
  `idSeguro` int(11) NOT NULL,
  `Contenido` int(11) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `idContinente` int(11) NOT NULL,
  `MetrosCuadrados` int(11) DEFAULT NULL,
  PRIMARY KEY (`idSeguro`),
  KEY `fk_Hogar_Continente1_idx` (`idContinente`),
  CONSTRAINT `IdSeguro` FOREIGN KEY (`idSeguro`) REFERENCES `seguro` (`idseguro`),
  CONSTRAINT `fk_Hogar_Continente1` FOREIGN KEY (`idContinente`) REFERENCES `continente` (`idcontinente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hogar`
--

LOCK TABLES `hogar` WRITE;
/*!40000 ALTER TABLE `hogar` DISABLE KEYS */;
INSERT INTO `hogar` VALUES (480020,9000,'Jose Hernandez 8785',1,90),(480033,15000,'Santos Vega 369',1,110),(480099,8650,'Av. Tres de Febrero 9599',2,74),(480256,450000,'Martin Fierro 654',1,120),(480304,8970,'Av. Santa Fe 10005',2,88),(480598,78000,'Mitre 5458',2,70),(480875,50060,'Calle Falsa 123',1,300),(480905,26500,'Belgrano 45',1,54),(480962,56000,'Av. Balbin 1115',2,90),(486989,12650,'Av de los Incas 3498',1,20);
/*!40000 ALTER TABLE `hogar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `marca` (
  `idMarca` int(11) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `idCategoria` int(11) DEFAULT NULL,
  PRIMARY KEY (`idMarca`),
  KEY `fk_Marca_Categoria1_idx` (`idCategoria`),
  CONSTRAINT `fk_Marca_Categoria1` FOREIGN KEY (`idCategoria`) REFERENCES `categoria` (`idcategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medidaseguridad`
--

DROP TABLE IF EXISTS `medidaseguridad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `medidaseguridad` (
  `idMedidaSeguridad` int(11) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Valor` double DEFAULT NULL,
  PRIMARY KEY (`idMedidaSeguridad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medidaseguridad`
--

LOCK TABLES `medidaseguridad` WRITE;
/*!40000 ALTER TABLE `medidaseguridad` DISABLE KEYS */;
INSERT INTO `medidaseguridad` VALUES (1,'Rejas',12),(2,'Alarma',50),(3,'Camaras de seguridad',140),(4,'Matafuegos',30),(5,'Cerco electrico',120),(6,'Detector de humo',50),(7,'Detector movimiento',60);
/*!40000 ALTER TABLE `medidaseguridad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modelo`
--

DROP TABLE IF EXISTS `modelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `modelo` (
  `idModelo` int(11) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `idMarca` int(11) DEFAULT NULL,
  PRIMARY KEY (`idModelo`),
  KEY `fk_Modelo_Marca_idx` (`idMarca`),
  CONSTRAINT `fk_Modelo_Marca` FOREIGN KEY (`idMarca`) REFERENCES `marca` (`idmarca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modelo`
--

LOCK TABLES `modelo` WRITE;
/*!40000 ALTER TABLE `modelo` DISABLE KEYS */;
/*!40000 ALTER TABLE `modelo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `poliza`
--

DROP TABLE IF EXISTS `poliza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `poliza` (
  `Id_seguro` int(11) NOT NULL,
  `Id_tomador` int(11) NOT NULL,
  `Id_agente` int(11) NOT NULL,
  `fechaInicio` date DEFAULT NULL,
  `fechaFin` date DEFAULT NULL,
  `fechaContratacion` date DEFAULT NULL,
  `prima` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_seguro`,`Id_tomador`),
  KEY `IdAgente_idx` (`Id_agente`),
  KEY `IdTomador_idx` (`Id_tomador`),
  CONSTRAINT `FkAgente` FOREIGN KEY (`Id_agente`) REFERENCES `agente` (`idagente`),
  CONSTRAINT `fkSeguro` FOREIGN KEY (`Id_seguro`) REFERENCES `seguro` (`idseguro`),
  CONSTRAINT `fkTomador` FOREIGN KEY (`Id_tomador`) REFERENCES `tomador` (`idtomador`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `poliza`
--

LOCK TABLES `poliza` WRITE;
/*!40000 ALTER TABLE `poliza` DISABLE KEYS */;
INSERT INTO `poliza` VALUES (480020,1019988,774956,'2015-01-30','2017-12-01','2015-01-25',NULL),(480033,1012453,774415,'2016-12-10','2017-12-10','2016-12-09',NULL),(480099,1019908,774956,'2015-05-16','2016-05-18','2015-05-15',NULL),(480256,1012454,774415,'2017-09-09','2018-12-31','2017-09-01',NULL),(480304,1019099,774420,'2018-02-15','2019-03-06','2018-02-02',NULL),(480598,1019123,774420,'2018-06-30','2020-06-30','2018-06-05',NULL),(480875,1019265,774956,'2018-09-15','2019-11-21','2018-09-03',NULL),(480905,1019519,774956,'2018-06-05','2019-06-20','2018-05-30',NULL),(480962,1019753,774415,'2017-09-06','2018-10-30','2017-09-01',NULL),(486989,1019901,774415,'2017-08-25','2018-12-12','2017-08-22',NULL);
/*!40000 ALTER TABLE `poliza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profesion`
--

DROP TABLE IF EXISTS `profesion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `profesion` (
  `idProfesion` int(11) NOT NULL,
  `Descripcion` varchar(45) NOT NULL,
  `IndiceRiesgo` int(11) NOT NULL,
  PRIMARY KEY (`idProfesion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesion`
--

LOCK TABLES `profesion` WRITE;
/*!40000 ALTER TABLE `profesion` DISABLE KEYS */;
/*!40000 ALTER TABLE `profesion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `riesgo`
--

DROP TABLE IF EXISTS `riesgo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `riesgo` (
  `idRiesgo` int(11) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Valor` double DEFAULT NULL,
  PRIMARY KEY (`idRiesgo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `riesgo`
--

LOCK TABLES `riesgo` WRITE;
/*!40000 ALTER TABLE `riesgo` DISABLE KEYS */;
INSERT INTO `riesgo` VALUES (1,'Incendio edificio',70),(2,'Robos',50),(3,'Responsabilidad civil',90),(4,'Incendio electrodomesticos',30);
/*!40000 ALTER TABLE `riesgo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `seguro`
--

DROP TABLE IF EXISTS `seguro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `seguro` (
  `idSeguro` int(11) NOT NULL,
  `TipoSeguro` varchar(45) NOT NULL,
  `idEstado` int(11) NOT NULL,
  PRIMARY KEY (`idSeguro`),
  KEY `IdEstado_idx` (`idEstado`),
  CONSTRAINT `IdEstadoFK` FOREIGN KEY (`idEstado`) REFERENCES `estado` (`idestado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seguro`
--

LOCK TABLES `seguro` WRITE;
/*!40000 ALTER TABLE `seguro` DISABLE KEYS */;
INSERT INTO `seguro` VALUES (480020,'V',22201),(480033,'H',22204),(480099,'A',22201),(480256,'H',22202),(480304,'H',22202),(480598,'H',22202),(480875,'H',22202),(480905,'H',22203),(480962,'H',22201),(486989,'H',22204);
/*!40000 ALTER TABLE `seguro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `segurovida_beneficiario_asegurado`
--

DROP TABLE IF EXISTS `segurovida_beneficiario_asegurado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `segurovida_beneficiario_asegurado` (
  `id_seguro_v` int(11) NOT NULL,
  `id_Beneficiario` int(11) NOT NULL,
  `id_Asegurado` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_seguro_v`,`id_Beneficiario`),
  KEY `fkBeneficiario_idx` (`id_Beneficiario`),
  KEY `fkAsegurado_idx` (`id_Asegurado`),
  CONSTRAINT `fkAsegurado` FOREIGN KEY (`id_Asegurado`) REFERENCES `asegurado` (`ida`),
  CONSTRAINT `fkBeneficiario` FOREIGN KEY (`id_Beneficiario`) REFERENCES `beneficiario` (`idb`),
  CONSTRAINT `fkSeguroVida` FOREIGN KEY (`id_seguro_v`) REFERENCES `vida` (`idsegurovida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `segurovida_beneficiario_asegurado`
--

LOCK TABLES `segurovida_beneficiario_asegurado` WRITE;
/*!40000 ALTER TABLE `segurovida_beneficiario_asegurado` DISABLE KEYS */;
/*!40000 ALTER TABLE `segurovida_beneficiario_asegurado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tomador`
--

DROP TABLE IF EXISTS `tomador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tomador` (
  `idTomador` int(11) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellido` varchar(45) NOT NULL,
  `Telefono` int(11) NOT NULL,
  `DNI` int(11) NOT NULL,
  `Direccion` varchar(45) NOT NULL,
  PRIMARY KEY (`idTomador`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tomador`
--

LOCK TABLES `tomador` WRITE;
/*!40000 ALTER TABLE `tomador` DISABLE KEYS */;
INSERT INTO `tomador` VALUES (1012453,'Antonella','Ramirez',11827391,22345689,'Santos Vega 369'),(1012454,'Norma','Calabrese',115151556,21548786,'Martin Fierro 654'),(1019099,'Martin','Benitez',21214488,44567893,'Av. Santa Fe 10005'),(1019123,'Fabian','Park',47484142,39656565,'Mitre 5458'),(1019265,'Maria','Aranda',4843689,19191919,'Calle Falsa 123'),(1019519,'Franco','Mercado',12145468,37197360,'Belgrano 45'),(1019753,'Leonardo','Albanese',45464948,32546789,'Av. Balbin 1115'),(1019901,'Francisco','Lopez',21547846,4154457,'Av de los Incas 3498'),(1019908,'Mariano','Lopez',21569595,415557,'Av. Tres de Febrero 9599'),(1019988,'Agustina','Marquez',2145698,37898785,'Jose Hernandez 8785');
/*!40000 ALTER TABLE `tomador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vida`
--

DROP TABLE IF EXISTS `vida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `vida` (
  `idSeguroVida` int(11) NOT NULL,
  `MontoAsegurado` double NOT NULL,
  PRIMARY KEY (`idSeguroVida`),
  CONSTRAINT `IdSeguroVidaFK` FOREIGN KEY (`idSeguroVida`) REFERENCES `seguro` (`idseguro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vida`
--

LOCK TABLES `vida` WRITE;
/*!40000 ALTER TABLE `vida` DISABLE KEYS */;
/*!40000 ALTER TABLE `vida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zona`
--

DROP TABLE IF EXISTS `zona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `zona` (
  `idZona` int(11) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Valor` int(11) DEFAULT NULL,
  `Codigo Postal` int(11) DEFAULT NULL,
  PRIMARY KEY (`idZona`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zona`
--

LOCK TABLES `zona` WRITE;
/*!40000 ALTER TABLE `zona` DISABLE KEYS */;
/*!40000 ALTER TABLE `zona` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-12-07  4:01:28
