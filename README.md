# Compañia de seguros

Aplicacion creada usando la interfaz de Windows Form.

### Enunciado del tp

Una compañía de seguros desea que se haga un diseño de una base de datos para gestionar toda la información referente a los seguros que ofrece, los clientes a los que atiende y los agentes de seguros que trabajan para la compañía. Esta compañía ofrece tres tipos de seguros:
* Seguros de Hogar: los seguros de este tipo ofrecidos por la compañía están ofertados de forma fija (es decir se han hecho estudios previos), según el valor del continente (la casa), el contenido (muebles, electrodomésticos, joyas, etc.), riesgos auxiliares (responsabilidad civil, asalto y otros).Para cada oferta hay una prima asignada.
* Seguros de Vida: de la misma forma que los de hogar, existen varias ofertas fijas según la edad y profesión del cliente, y la cobertura económica del seguro. De la misma forma que en los seguros de Hogar, existe una prima fija para cada oferta.
* Seguros de Automóvil: también existen ofertas fijas, según la categoría de coche
(Utilitario, gama media, gama alta, gran turismo, lujo, etc.), años del vehículo, edad del conductor y cobertura (todo riesgo, franquicia, terceros, etc.). A cada una de estas ofertas le corresponde una prima.

Para llevar un control de las comisiones que se llevan los agentes y de sus carteras correspondientes, la compañía necesita tener almacenados los datos de los agentes, considerándose de interés el nombre, DNI, dirección y teléfono. Para el pago de comisiones y carteras (se entiende por “cartera” la comisión anual del agente mientras el seguro este vigente), será necesario saber qué agente ha realizado qué seguro y en qué fecha.

La compañía considera como datos de interés referentes al cliente (sea cual sea el seguro que contrate), los siguientes: Nombre, dirección, teléfono y DNI.

Otras consideraciones sobre la contratación de seguros por parte del cliente son:
* Seguros Hogar: fecha del contrato del seguro y dirección del inmueble asegurado.
* Seguros Automóvil: fecha contratación, matrícula del vehículo, recargos y   descuentos.
* Otras consideraciones: Un cliente puede contratar más de un seguro de Vida, más de un seguro de Hogar y más de un seguro de Automóvil. 

Además estos contratos pueden realizarse a través de distintos agentes. Los beneficiarios de seguros de vida pueden serlo de varios seguros, e incluso de varios clientes distintos. Por supuesto un cliente puede nombrar a varios beneficiarios de un mismo seguro de vida.

## Resumen del funcionamiento de la aplicacion

Esta aplicacion permite hacer consultas a la base de datos y una baja: 
* pantalla de login, donde el agente ingresa su usuario (idUsuario) y su pass(DNI)
* pantalla de reportes de los clientes del seguro de hogar, se puede elegir mediante combos, checkboxs, y rangos de valores y mostrar los clientes que cumplen con los valores seleccionado (Ej: clientes que tienen un determinado riesgo contratado, el estado de su seguro, que medida de seguridad tiene , el valor del inmuble asegurado, o combinaciones de todas esas).
* pantalla de estadisticas de seguros de hogar.
*baja de una poliza de seguro para un cliente (a travez de distintos combos)

Para ejecutarlo y hacer consultas a la base de datos es necesario cargar la query de creacion de tablas e insercion de datos, asi como tambien los stored procedures en Mysql.
