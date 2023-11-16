-- SP empleado cliente tipo de pago sede y envio

CREATE PROCEDURE SP_GET_EMPLEADO_X_SEDE
@SEDE INT
AS
BEGIN
	SELECT LEGAJO, NOMBRE, APELLIDO
	FROM EMPLEADOS
	WHERE ID_SEDE = @SEDE
	ORDER BY APELLIDO
END;

CREATE PROCEDURE SP_GET_CLIENTE
AS
BEGIN
	SELECT ID_CLIENTE, NOMBRE, APELLIDO 
	FROM CLIENTES
	ORDER BY APELLIDO
END;

CREATE PROCEDURE SP_GET_FORMA_PAGO
AS
BEGIN
	SELECT ID_PAGO, PAGO 
	FROM FORMA_PAGO
	ORDER BY PAGO
END;

CREATE PROCEDURE SP_GET_FORMA_ENVIO
AS
BEGIN
	SELECT ID_ENVIO, ENVIO 
	FROM FORMA_ENVIO
	ORDER BY ENVIO
END;


CREATE PROCEDURE SP_GET_LUTHIERS
AS 
BEGIN
	SELECT ID_LUTHIER, NOMBRE, APELLIDO
	FROM LUTHIERS
	ORDER BY APELLIDO
END 

CREATE PROCEDURE SP_GET_TIPO_SERVICIOS
AS 
BEGIN
	SELECT ID_T_SERV, SERVICIO 
	FROM TIPO_SERVICIO
	ORDER BY SERVICIO
END 