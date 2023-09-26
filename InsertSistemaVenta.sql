use DBSISTEMA_VENTA_WINDOWSFORM
/*
insert into rol (Descripcion)
 values('ADMINISTRADOR')


 insert into rol (Descripcion)
 values('EMPLEADO')

 insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
 values 
 ('101010','ADMIN','@GMAIL.COM','123',1,1)


 insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
 values 
 ('20','EMPLEADO','@GMAIL.COM','456',2,1)

 */


 select * from usuario;


 select p.IdRol,p.NombreMenu from permiso p
 inner join Rol r on r.IdRol = p.IdRol
 inner join Usuario u on u.IdRol = r.IdRol
 Where u.IdUsuario = 2



 select * from rol;
/*
 insert into PERMISO(IdRol,NombreMenu) values
  (1,'menuUsuarios'),
  (1,'menuMantenedor'),
  (1,'menuVentas'),
  (1,'menuCompras'),
  (1,'menuClientes'),
  (1,'menuProveedores'),
  (1,'menuReportes'),
  (1,'menuAcercaDe')


  insert into PERMISO(IdRol,NombreMenu) values
  (2,'menuVentas'),
  (2,'menuCompras'),
  (2,'menuClientes'),
  (2,'menuProveedores'),
  (2,'menuAcercaDe')
  */

go

CREATE PROCEDURE SP_REGISTRARUSUARIO
(
    @Documento VARCHAR(50),
    @NombreCompleto VARCHAR(100),
    @Correo VARCHAR(100),
    @Clave VARCHAR(100),
    @IdRol INT,
    @Estado BIT,
    @IdUsuarioResultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @IdUsuarioResultado = 0
    SET @Mensaje = ''

    -- Verifica si el documento ya existe en la tabla USUARIO
    IF NOT EXISTS (SELECT * FROM USUARIO WHERE Documento = @Documento)
    BEGIN
        -- Si el documento no existe, inserta un nuevo registro
        INSERT INTO Usuario (Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
        VALUES (@Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Estado)

        -- Obtiene el ID del usuario recién insertado
        SET @IdUsuarioResultado = SCOPE_IDENTITY()
    END
    ELSE
    BEGIN
        -- Si el documento ya existe, establece un mensaje de error
        SET @Mensaje = 'No se puede repetir el documento para más de un usuario'
    END
END

go

CREATE PROCEDURE SP_EDITARUSUARIO
(
    @IdUsuario INT,
    @Documento VARCHAR(50),
    @NombreCompleto VARCHAR(100),
    @Correo VARCHAR(100),
    @Clave VARCHAR(100),
    @IdRol INT,
    @Estado BIT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0
    SET @Mensaje = ''

    -- Verifica si el documento ya existe en la tabla USUARIO para otro usuario
    IF NOT EXISTS (SELECT * FROM USUARIO WHERE Documento = @Documento AND IdUsuario != @IdUsuario)
    BEGIN
        -- Si el documento no existe para otro usuario, actualiza el registro
        UPDATE Usuario
        SET Documento = @Documento,
            NombreCompleto = @NombreCompleto,
            Correo = @Correo,
            Clave = @Clave,
            IdRol = @IdRol,
            Estado = @Estado
        WHERE IdUsuario = @IdUsuario

        -- Establece la respuesta como 1 para indicar éxito
        SET @Respuesta = 1
    END
    ELSE
    BEGIN
        -- Si el documento ya existe para otro usuario, establece un mensaje de error
        SET @Mensaje = 'No se puede repetir el documento para más de un usuario'
    END
END

go


CREATE PROCEDURE SP_ELIMINARUSUARIO
(
    @IdUsuario INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0
    SET @Mensaje = ''
    DECLARE @pasoVerificacion BIT = 1

    -- Verifica si el usuario está relacionado con compras
    IF EXISTS (
        SELECT * FROM COMPRA C
        INNER JOIN USUARIO U ON U.IdUsuario = C.IdUsuario
        WHERE U.IDUSUARIO = @IdUsuario
    )
    BEGIN
        SET @pasoVerificacion = 0
        SET @Respuesta = 0
        SET @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario está relacionado a una COMPRA\n'
    END

    -- Verifica si el usuario está relacionado con ventas
    IF EXISTS (
        SELECT * FROM VENTA V
        INNER JOIN USUARIO U ON U.IdUsuario = V.IdUsuario
        WHERE U.IDUSUARIO = @IdUsuario
    )
    BEGIN
        SET @pasoVerificacion = 0
        SET @Respuesta = 0
        SET @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario está relacionado a una VENTA\n'
    END

    -- Si no hay relaciones, se puede eliminar el usuario
    IF (@pasoVerificacion = 1)
    BEGIN
        DELETE FROM USUARIO WHERE IdUsuario = @IdUsuario
        SET @Respuesta = 1
    END
END


go