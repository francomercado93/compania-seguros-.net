USE `companiadesegurostp`;
DROP procedure IF EXISTS `tablaReporte`;

DELIMITER $$
USE `companiadesegurostp`$$
CREATE PROCEDURE `tablaReporte`(IN estadoSeleccionado varchar(45),
IN medidaSeleccionada varchar(45),
IN riesgoSeleccionado varchar(45),
IN valorMin int,
IN valorMax int)
BEGIN
		select distinct CONCAT(t.Apellido,' ', t.Nombre)AS 'Cliente',CONCAT(a.Apellido,' ', a.Nombre)AS 'Agente', ROUND((i.Valor / r.Valor / ms.Valor * 0.67), 2) as Prima,
		ms.Descripcion AS 'Medida de seguridad', r.Descripcion AS 'Riesgo contratado', i.Valor, e.Descripcion as Estado
		from poliza p 
		inner join agente a on p.Id_agente = a.idAgente
		inner join tomador t on t.idTomador = p.Id_tomador
		inner join seguro s on s.idSeguro = p.Id_seguro and TipoSeguro="H"
		inner join estado e on e.idEstado = s.idEstado
		inner join hogar h on h.idSeguro = s.idSeguro
		inner join cuentacon cc on cc.id_seguro_hogar = h.idSeguro
		inner join medidaseguridad ms on ms.idMedidaSeguridad = cc.id_med_seguridad
		inner join cubre c on c.idSeguroHogar = h.idSeguro
		inner join riesgo r on r.idRiesgo = c.idRiesgo
		inner join continente i on i.idContinente = h.idContinente
		where estadoSeleccionado IN (e.Descripcion, 'Todos')
        and (medidaSeleccionada  is null or ms.Descripcion = medidaSeleccionada)
        and (riesgoSeleccionado is null or r.Descripcion = riesgoSeleccionado)
		and i.Valor > valorMin and i.Valor < valorMax 
        order by t.apellido;
END$$

DELIMITER ;