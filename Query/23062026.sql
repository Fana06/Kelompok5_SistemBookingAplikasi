SELECT TOP 1 *
FROM dbo.booking_detail;

EXEC sp_helptext 'dbo.booking_detail'

ALTER VIEW booking_detail
AS
SELECT
    b.id AS booking_id,
    b.pasien_id,
    p.nama_lengkap,
    p.nik,
    d.nama_dokter,
    d.spesialisasi,
    j.hari,
    j.jam_mulai,
    j.jam_selesai,
    b.tanggal_booking,
    b.keluhan,
    b.status_booking,
    b.tanggal_dibuat
FROM booking b
JOIN pasien p
    ON b.pasien_id = p.id
JOIN jadwal_dokter j
    ON b.jadwal_id = j.id
JOIN dokter d
    ON j.dokter_id = d.id;
GO