USE `companiadesegurostp`;
DROP procedure IF EXISTS `buscarSeguros`;

DELIMITER $$
USE `companiadesegurostp`$$
CREATE PROCEDURE `buscarSeguros`(IN IdSeguro int, IN IdTomador int, IN IdAgente int,
IN fechaInicio DATE, IN fechaFin date, IN fechaContratacion date, IN tipoSeguro varchar(45), IN estadoSeguro int)

BEGIN
SELECT p.Id_seguro AS Seguro, CONCAT(c.Nombre, ' ', c.Apellido) AS Cliente, CONCAT(a.Nombre, ' ', a.Apellido) AS Agente,
p.fechaInicio AS 'Fecha Inicio', p.fechaFin AS 'Fecha Finalizacion', p.fechaContratacion AS 'Fecha Contratacion', s.TipoSeguro AS 'Tipo Seguro', e.Descripcion AS 'Estado Seguro'
FROM POLIZA P 
INNER JOIN TOMADOR C ON P.Id_tomador = C.IdTomador
INNER JOIN AGENTE A ON P.Id_agente = A.idAgente
INNER JOIN SEGURO S ON P.Id_seguro = S.idSeguro
INNER JOIN ESTADO E ON S.idEstado = E.idEstado
WHERE (P.Id_seguro = IdSeguro OR IdSeguro IS NULL)
AND (P.Id_tomador = IdTomador OR IdTomador IS NULL)
AND (P.Id_agente = IdAgente OR IdAgente IS NULL)
AND (P.fechaInicio >= fechaInicio OR fechaInicio IS NULL)
AND (P.fechaFin <= fechaFin OR fechaFin IS NULL)
AND (P.fechaContratacion = fechaContratacion OR fechaContratacion IS NULL)
AND (S.TipoSeguro = tipoSeguro OR tipoSeguro IS NULL)
AND (E.idEstado = estadoSeguro OR estadoSeguro IS NULL);
END$$

DELIMITER ;

