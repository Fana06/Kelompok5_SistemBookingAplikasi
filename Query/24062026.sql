USE master;
GO

CREATE LOGIN app_pasien
WITH PASSWORD = 'AppPasien_12345!';
GO

USE DBKontrolPasien;
GO

CREATE USER app_pasien FOR LOGIN app_pasien;
GO

GRANT EXECUTE ON dbo.sp_LoginUser TO app_pasien;
GRANT EXECUTE ON dbo.sp_GetPasienByUserId TO app_pasien;
GRANT EXECUTE ON dbo.sp_InsertUser TO app_pasien;
GRANT EXECUTE ON dbo.sp_InsertPasien TO app_pasien;
GRANT EXECUTE ON dbo.sp_LoadRiwayatBooking TO app_pasien;
GRANT EXECUTE ON dbo.sp_LoadJadwalTersedia TO app_pasien;
GRANT EXECUTE ON dbo.sp_LoadProfilPasien TO app_pasien;
GRANT EXECUTE ON dbo.sp_CekBookingAktif TO app_pasien;
GRANT EXECUTE ON dbo.sp_InsertBooking TO app_pasien;
GRANT EXECUTE ON dbo.sp_BatalBooking TO app_pasien;
GO

EXEC sp_helptext 'sp_InsertUser';

ALTER PROCEDURE sp_InsertUser
    @email NVARCHAR(100),
    @password NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO users (email, password, role)
    VALUES (@email, @password, 'pasien');

    SELECT SCOPE_IDENTITY();
END;

INSERT INTO users (email, password, role)
VALUES (@email, @password, 'pasien');

USE DBKontrolPasien;
GO

ALTER PROCEDURE sp_InsertUser
    @email NVARCHAR(100),
    @password NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT SCOPE_IDENTITY();
END;
GO

INSERT INTO users (email, password, role)
VALUES (@email, @password, 'pasien');


EXEC sp_InsertUser
    @email = 'testpasien@gmail.com',
    @password = '12345';

	SELECT TOP 5 *
FROM users
ORDER BY id DESC;

USE DBKontrolPasien;
GO

ALTER PROCEDURE sp_InsertUser
    @email NVARCHAR(100),
    @password NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO users (email, password, role)
    VALUES (@email, @password, 'pasien');

    SELECT SCOPE_IDENTITY();
END;
GO

EXEC sp_InsertUser
    @email = 'testpasien@gmail.com',
    @password = '12345';
GO

SELECT TOP 5 *
FROM users
ORDER BY id DESC;
GO

EXEC sp_InsertUser
    @email = 'testpasien2@gmail.com',
    @password = '12345';
GO

SELECT TOP 5 *
FROM users
ORDER BY id DESC;
GO








USE DBKontrolPasien;
GO

ALTER PROCEDURE sp_InsertUser
    @email NVARCHAR(100),
    @password NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO users (email, password, role)
    VALUES (@email, @password, 'pasien');

    SELECT SCOPE_IDENTITY();
END;
GO

EXEC sp_InsertUser
    @email = 'testpasien2@gmail.com',
    @password = '12345';
GO

SELECT TOP 5 *
FROM users
ORDER BY id DESC;
GO


SELECT *
FROM users
WHERE email = 'testpasien@gmail.com';