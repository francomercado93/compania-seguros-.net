select ms.Descripcion, count(*) as Cantidad 
from cuentacon cc inner join medidaseguridad ms on cc.id_med_seguridad = ms.idMedidaSeguridad 
group by cc.id_med_seguridad;

select r.Descripcion, count(*) as Cantidad 
from cubre c inner join riesgo r on c.idRiesgo = r.idRiesgo
group by c.idRiesgo;

select Descripcion from riesgo;

select Descripcion from medidaseguridad;

select h.*, ms.Descripcion from hogar h 
inner join cuentacon cc on h.idSeguro = cc.id_seguro_hogar
inner join  medidaseguridad ms on cc.id_med_Seguridad = ms.idMedidaSeguridad 
where ms.Descripcion = "Alarma";

select h.*, ms.Descripcion from hogar h 
inner join cuentacon cc on h.idSeguro = cc.id_seguro_hogar
inner join  medidaseguridad ms on cc.id_med_Seguridad = ms.idMedidaSeguridad 
where ms.idMedidaSeguridad = 1;

select Descripcion from estado;

select * from hogar where Contenido > 10000 and Contenido < 80000;

select t.Nombre, t.Apellido, a.Nombre , a.Apellido from tomador t 
inner join poliza p on t.idTomador = p.Id_tomador
inner join agente a on p.Id_tomador = a.idAgente;

select CONCAT(a.Apellido,' ', a.Nombre)AS 'Agente', CONCAT(t.Apellido,' ', t.Nombre)AS 'Cliente', p.prima as Prima,
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
/*estado puede ser todos, valor puede estar vacio el min, el max o ambos*/
where e.Descripcion = "En curso"
and ms.Descripcion = "Rejas" 
and r.Descripcion = "Incendio edificio"
and i.Valor > 70000 and i.Valor < 900000 ;

/* LOGIN DEL AGENTE IDAGENTE + DNI */
SELECT COUNT(*) FROM AGENTE WHERE idAgente = @user AND DNI = @pass;

/* CARGA COMBOBOX DE BUSQUEDA POR ESTADO */
SELECT idEstado, Descripcion FROM ESTADO;

/* CARGA COMBOBOX DE BUSQUEDA POR AGENTE */
SELECT idAgente, Nombre, Apellido FROM AGENTE;

/* CARGA COMBOBOX DE BUSQUEDA POR CLIENTE */
SELECT idTomador, Nombre, Apellido FROM TOMADOR;

/* UPDATE: CAMBIA EL ESTADO DE LOS SEGUROS A 'ANULADA' */
UPDATE SEGURO SET idEstado = 22204 WHERE idSeguro IN ({0});

/* CARGA GRILLA DE SEGUROS SEGUN FILTROS DE BUSQUEDA */
PROCEDURE `buscarSeguros`(IN IdSeguro int, IN IdTomador int, IN IdAgente int,
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
END