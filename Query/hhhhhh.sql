EXEC sp_ReportDokter

CREATE PROCEDURE sp_ReportDokter
AS
BEGIN

SELECT
    id AS ID,
    nama_dokter AS NamaDokter,
    spesialisasi AS Spesialisasi,
    no_hp AS NoHP,
    CASE
        WHEN status_aktif = 1 THEN 'Aktif'
        ELSE 'Nonaktif'
    END AS Status

FROM dokter

ORDER BY id

END

EXEC sp_ReportDokter


WITH CTE AS
(
    SELECT *,
           ROW_NUMBER() OVER (
               PARTITION BY nama_dokter, spesialisasi, no_hp
               ORDER BY id
           ) AS urutan
    FROM dokter
)
DELETE FROM CTE
WHERE urutan > 1;


ALTER PROCEDURE sp_ImportDokter
    @nama VARCHAR(100),
    @spesialisasi VARCHAR(100),
    @hp VARCHAR(20),
    @source_file VARCHAR(100)
AS
BEGIN

    IF NOT EXISTS
    (
        SELECT *
        FROM dokter
        WHERE nama_dokter = @nama
          AND spesialisasi = @spesialisasi
          AND no_hp = @hp
    )
    BEGIN
        INSERT INTO dokter
        (
            nama_dokter,
            spesialisasi,
            no_hp,
            status_aktif
        )
        VALUES
        (
            @nama,
            @spesialisasi,
            @hp,
            1
        );
    END

END

ALTER PROCEDURE sp_ImportDokter
    @nama VARCHAR(100),
    @spesialisasi VARCHAR(100),
    @hp VARCHAR(20),
    @source_file VARCHAR(100)
AS
BEGIN

    IF NOT EXISTS
    (
        SELECT *
        FROM dokter
        WHERE nama_dokter=@nama
          AND spesialisasi=@spesialisasi
          AND no_hp=@hp
    )
    BEGIN
        INSERT INTO dokter
        (
            nama_dokter,
            spesialisasi,
            no_hp,
            status_aktif
        )
        VALUES
        (
            @nama,
            @spesialisasi,
            @hp,
            1
        )
    END

END

WITH CTE AS
(
    SELECT *,
           ROW_NUMBER() OVER
           (
               PARTITION BY nama_dokter, spesialisasi, no_hp
               ORDER BY id
           ) AS urutan
    FROM dokter
)
DELETE FROM CTE
WHERE urutan > 1;


ALTER PROCEDURE sp_ImportDokter
    @nama VARCHAR(100),
    @spesialisasi VARCHAR(100),
    @hp VARCHAR(20),
    @source_file VARCHAR(100)
AS
BEGIN

    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM dokter
        WHERE nama_dokter = @nama
          AND spesialisasi = @spesialisasi
          AND no_hp = @hp
    )
    BEGIN
        INSERT INTO dokter
        (
            nama_dokter,
            spesialisasi,
            no_hp,
            status_aktif
        )
        VALUES
        (
            @nama,
            @spesialisasi,
            @hp,
            1
        );
    END

END




EXEC sp_help dokter;


ALTER PROCEDURE sp_ImportDokter
    @nama VARCHAR(100),
    @spesialisasi VARCHAR(100),
    @hp VARCHAR(20),
    @source_file VARCHAR(100)
AS
BEGIN

    IF NOT EXISTS
    (
        SELECT *
        FROM dokter
        WHERE nama_dokter=@nama
          AND spesialisasi=@spesialisasi
          AND no_hp=@hp
    )
    BEGIN
        INSERT INTO dokter
        (
            nama_dokter,
            spesialisasi,
            no_hp,
            status_aktif
        )
        VALUES
        (
            @nama,
            @spesialisasi,
            @hp,
            1
        );

        RETURN 1;
    END

    RETURN 0;
END

ALTER PROCEDURE sp_ImportDokter
    @nama VARCHAR(100),
    @spesialisasi VARCHAR(100),
    @hp VARCHAR(20),
    @source_file VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM dokter
        WHERE nama_dokter=@nama
          AND spesialisasi=@spesialisasi
          AND no_hp=@hp
    )
    BEGIN
        INSERT INTO dokter
        (
            nama_dokter,
            spesialisasi,
            no_hp,
            status_aktif
        )
        VALUES
        (
            @nama,
            @spesialisasi,
            @hp,
            1
        );

        SELECT 1;
    END
    ELSE
    BEGIN
        SELECT 0;
    END
END

ALTER PROCEDURE sp_ImportDokter
    @nama VARCHAR(100),
    @spesialisasi VARCHAR(100),
    @hp VARCHAR(20),
    @source_file VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM dokter
        WHERE nama_dokter = @nama
          AND spesialisasi = @spesialisasi
          AND no_hp = @hp
    )
    BEGIN
        INSERT INTO dokter
        (
            nama_dokter,
            spesialisasi,
            no_hp,
            status_aktif
        )
        VALUES
        (
            @nama,
            @spesialisasi,
            @hp,
            1
        );

        SELECT 1;
    END
    ELSE
    BEGIN
        SELECT 0;
    END
END