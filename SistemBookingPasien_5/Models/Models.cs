using System;

namespace SistemBookingPasien_5.Models
{
    public class User
    {
        public int    Id        { get; set; }
        public string Email     { get; set; }
        public string Password  { get; set; }
        public string Role      { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class Pasien
    {
        public int    Id           { get; set; }
        public int    UserId       { get; set; }
        public string Nik          { get; set; }
        public string NamaLengkap  { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string JenisKelamin { get; set; }
        public string Alamat       { get; set; }
        public string NoHp         { get; set; }
        public string Email        { get; set; }
    }

    public class Dokter
    {
        public int    Id           { get; set; }
        public string NamaDokter   { get; set; }
        public string Spesialisasi { get; set; }
        public string NoHp         { get; set; }
        public bool   StatusAktif  { get; set; }
    }

    public class JadwalDokter
    {
        public int    Id          { get; set; }
        public int    DokterId    { get; set; }
        public string NamaDokter  { get; set; }
        public string Hari        { get; set; }
        public TimeSpan JamMulai  { get; set; }
        public TimeSpan JamSelesai { get; set; }
        public int    Kuota       { get; set; }
        public int    SisaKuota   { get; set; }
    }

    public class Booking
    {
        public int    Id             { get; set; }
        public int    PasienId       { get; set; }
        public int    JadwalId       { get; set; }
        public DateTime TanggalBooking { get; set; }
        public string Keluhan        { get; set; }
        public string StatusBooking  { get; set; }
        public DateTime TanggalDibuat { get; set; }

        public string NamaPasien     { get; set; }
        public string NamaDokter     { get; set; }
        public string Spesialisasi   { get; set; }
        public string Hari           { get; set; }
        public TimeSpan JamMulai     { get; set; }
        public TimeSpan JamSelesai   { get; set; }
    }
}
