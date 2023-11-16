-- $$$$$$$$$$ NOMENCLATURA -> TG_NOMBRETABLA $$$$$$$$$$

--TABLA EMPLEADOS

CREATE TRIGGER TG_EMPLEADOS
ON EMPLEADOS
FOR INSERT 
AS
	IF ((SELECT COUNT(*) FROM INSERTED WHERE NOMBRE IS NULL OR
	APELLIDO IS NULL OR ID_PUESTO IS NULL OR ID_SEDE IS NULL OR
	FECHA_INGRESO IS NULL)> 0)
		BEGIN
			RAISERROR('EMPLEADO NO VALIDO', 16, 1)
			ROLLBACK TRANSACTION
		END;
GO


CREATE TRIGGER TG_EMPLEADOS_ACT
ON EMPLEADOS
FOR UPDATE 
AS
	IF UPDATE(FECHA_INGRESO)
		BEGIN
			RAISERROR('NO PUEDE ACTUALIZAR LA FECHA', 16, 1)
			ROLLBACK TRANSACTION
		END;
GO

--TABLA SEDES

CREATE TRIGGER TG_SEDES
ON SEDES
FOR INSERT
AS
	IF((SELECT COUNT(*) FROM inserted WHERE NOMBRE IS NULL OR CALLE IS NULL OR ID_BARRIO IS NULL) > 0)
		BEGIN
			RAISERROR('SEDE NO VALIDA', 16, 1)
			ROLLBACK TRANSACTION
		END;
GO


CREATE TRIGGER TG_CLIENTES
ON CLIENTES
FOR INSERT
AS
	IF((SELECT COUNT(*) FROM INSERTED WHERE ID_BARRIO IS NULL OR 
	NOMBRE IS NULL OR APELLIDO IS NULL)>0)
		BEGIN
			RAISERROR('EL CLIENTE CARGADO NO ES VALIDO', 16, 1)
			ROLLBACK TRANSACTION
		END;
GO


CREATE TRIGGER TG_FACTURAS
ON FACTURAS
FOR INSERT 
AS
	IF((SELECT COUNT(*)  FROM INSERTED WHERE FECHA IS NULL OR
	LEGAJO IS NULL OR ID_CLIENTE IS NULL OR ID_PAGO IS NULL
	OR ID_SEDE IS NULL OR ID_ENVIO IS NULL)>0)
		BEGIN 
			RAISERROR('LA FACTURA CARGADA NO ES VALIDA', 16, 1)
			ROLLBACK TRANSACTION
		END;
GO


CREATE TRIGGER TG_DETALLES_FACTURA
ON DETALLE_FACTURA
FOR INSERT 
AS
	IF((SELECT COUNT(*)  FROM INSERTED WHERE NRO_FACTURA IS NULL OR
	ID_PRODUCTO IS NULL OR CANTIDAD IS NULL OR PRECIO IS NULL
	)>0)
		BEGIN 
			RAISERROR('EL DETALLE DE FACTURA ES NULO', 16, 1)
			ROLLBACK TRANSACTION 
		END;
GO

CREATE TRIGGER TG_DETALLES_SERVICIO
ON DETALLE_SERVICIO
FOR INSERT 
AS
	IF((SELECT COUNT(*)  FROM INSERTED WHERE NRO_FACTURA IS NULL OR
	ID_T_SERV IS NULL OR PRECIO_X_HORA IS NULL OR HORAS IS NULL)>0)
		BEGIN 
			RAISERROR('EL DETALLE DE SERVICIO ES NULO', 16, 1)
			ROLLBACK TRANSACTION 
		END;
GO


--TRIGGER AGUS

CREATE TRIGGER TG_DET_PEDIDO
ON DETALLE_PEDIDO
FOR INSERT
AS
    IF( ( SELECT COUNT(*) FROM INSERTED WHERE CANTIDAD IS NULL OR PRECIO IS NULL ) > 0 )
        BEGIN
            RAISERROR('DETALLE NO VALIDO', 16, 1)
            ROLLBACK TRANSACTION
        END;
GO

CREATE TRIGGER TG_PEDIDOS
ON PEDIDOS
FOR INSERT
AS
    IF( ( SELECT COUNT(*) FROM INSERTED WHERE FECHA IS NULL) >  0 )
        BEGIN
            RAISERROR('PEDIDO SIN FECHA',16,1)
            ROLLBACK TRANSACTION
        END;
GO

CREATE TRIGGER TG_PROVEEDORES
ON PROVEEDORES
FOR INSERT
AS
    IF( ( SELECT COUNT(*) FROM INSERTED WHERE NOMBRE IS NULL ) > 0 )
        BEGIN
            RAISERROR('PROVEEDOR NO VALIDO',16,1)
            ROLLBACK TRANSACTION
		END;
GO

CREATE TRIGGER TG_PRODUCTOS
ON PRODUCTOS
FOR INSERT
AS
    IF( ( SELECT COUNT(*) FROM INSERTED WHERE NOMBRE IS NULL ) > 0 )
        BEGIN
            RAISERROR('PRODUCTO NO VALIDO',16,1)
            ROLLBACK TRANSACTION
        END;
GO

CREATE TRIGGER TG_CARACTERISTICAS
ON CARACTERISTICAS
FOR INSERT
AS
BEGIN
    IF( ( SELECT COUNT(*) FROM INSERTED WHERE ID_T_CARACTERISTICA IS NULL ) > 0 )
        BEGIN
            RAISERROR('CARACTERISTICA SIN TIPO',16,1)
            ROLLBACK TRANSACTION
        END
END;
GO