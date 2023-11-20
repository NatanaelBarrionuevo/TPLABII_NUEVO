CREATE PROCEDURE SP_REPORTE_FACTURACION_MENSUAL
AS
BEGIN
	SELECT YEAR(FECHA) 'A�O' ,MONTH(FECHA) 'MES',
	SUM(DF.CANTIDAD * DF.PRECIO) 'TOTAL FACTURADO',
	AVG(DF.CANTIDAD * DF.PRECIO) 'PROMEDIO FACTURADO',
	AVG(DF.PRECIO) 'PROMEDIO DE PRECIOS'
	FROM FACTURAS F, DETALLE_FACTURA DF
	WHERE F.NRO_FACTURA = DF.NRO_FACTURA
	GROUP BY YEAR(FECHA),MONTH(FECHA)
END;


CREATE PROCEDURE SP_REPORTE_FIDELIDAD
AS
BEGIN
	SELECT ID_CLIENTE, APELLIDO + ', ' + NOMBRE 'CLIENTE',
	EMAIL, TELEFONO, 'Regular' OBSERVACION

	FROM CLIENTES C
	WHERE ID_CLIENTE IN (
		SELECT ID_CLIENTE FROM FACTURAS F
		WHERE F.ID_CLIENTE = C.ID_CLIENTE AND
		DATEDIFF(YEAR, FECHA, GETDATE()) = 0 AND
		DATEDIFF(MONTH, FECHA, GETDATE()) BETWEEN 0
		AND 5 AND
		DATEDIFF(MONTH, FECHA, GETDATE()) BETWEEN 5
		AND 11)
	UNION
	SELECT ID_CLIENTE, APELLIDO + ', ' + NOMBRE 'CLIENTE',
	EMAIL, TELEFONO, 'Irregular' OBSERVACION
	FROM CLIENTES C
	WHERE ID_CLIENTE NOT IN (
		SELECT ID_CLIENTE FROM FACTURAS F
		WHERE F.ID_CLIENTE = C.ID_CLIENTE AND
		DATEDIFF(YEAR, FECHA, GETDATE()) = 0 AND
		(DATEDIFF(MONTH, FECHA, GETDATE()) NOT
		BETWEEN 0 AND 5 OR
		DATEDIFF(MONTH, FECHA, GETDATE()) NOT
		BETWEEN 5 AND 11))
END;

CREATE PROCEDURE SP_REPORTE_PRODUCTOS
@cantidad INT
AS
BEGIN
SELECT NOMBRE,
DESCRIPCION,
COUNT(*) 'NRO'
FROM PRODUCTOS P
JOIN DETALLE_FACTURA DT ON DT.ID_PRODUCTO =
P.ID_PRODUCTO
WHERE DT.ID_PRODUCTO NOT IN ( SELECT ID_PRODUCTO
FROM DETALLE_FACTURA
GROUP BY ID_PRODUCTO
HAVING AVG(CANTIDAD) > 10)
GROUP BY NOMBRE,DESCRIPCION
ORDER BY COUNT(*) DESC
END;

-- VISTA DEL SP REPORTE MESES +++++++++++++++++++++++++++++++++++++++
CREATE VIEW VS_PROMEDIO_MENSUAL
AS
	SELECT YEAR(FECHA) 'A�O', MONTH(FECHA) 'MES', SUM(PRECIO*CANTIDAD) 'TOTAL', 
	SUM(PRECIO*CANTIDAD)/COUNT(DISTINCT D.NRO_FACTURA) 'PROMEDIO'
	FROM FACTURAS F
	JOIN DETALLE_FACTURA D ON D.NRO_FACTURA = F.NRO_FACTURA
	WHERE DATEDIFF(YEAR,FECHA,GETDATE()) = 0
	GROUP BY YEAR(FECHA), MONTH(FECHA)

CREATE PROCEDURE SP_REPORTE_MESES
AS
SELECT V.A�O 'A�O', V.MES 'MES', V.PROMEDIO 'PROMEDIO'
FROM VS_PROMEDIO_MENSUAL V
WHERE V.PROMEDIO < (SELECT
SUM(PRECIO*CANTIDAD)/COUNT(DISTINCT D1.NRO_FACTURA)
FROM DETALLE_FACTURA D1
JOIN FACTURAS F1 ON F1.NRO_FACTURA = D1.NRO_FACTURA
WHERE
DATEDIFF(YEAR,FECHA,GETDATE()) = 1)
