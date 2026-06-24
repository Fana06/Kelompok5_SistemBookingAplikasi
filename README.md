# Sistem Booking Kontrol Pasien

## Deskripsi Project

Sistem Booking Kontrol Pasien merupakan aplikasi desktop berbasis Windows Forms menggunakan bahasa pemrograman C# dan SQL Server sebagai database.

Aplikasi ini digunakan untuk membantu proses:
- registrasi pasien
- login pengguna
- booking kontrol pasien
- pengelolaan dokter
- pengelolaan jadwal dokter
- monitoring booking pasien

Project ini juga menerapkan:
- Stored Procedure
- SQL View
- Binding DataGridView
- BindingNavigator
- Simulasi SQL Injection

sesuai dengan ketentuan tugas praktikum basis data dan pemrograman desktop.

---

# Teknologi yang Digunakan

- C#
- Windows Forms
- SQL Server
- ADO.NET
- Stored Procedure
- SQL View
- BindingSource
- BindingNavigator

---

# Fitur Aplikasi

## Pasien
- Login pasien
- Registrasi pasien
- Melihat jadwal dokter
- Booking kontrol
- Riwayat booking pasien

## Admin
- Melihat data booking
- Menyetujui booking
- Menolak booking
- Menyelesaikan booking
- CRUD dokter
- CRUD jadwal dokter
- Monitoring data pasien

---

# Implementasi Stored Procedure

Project ini menggunakan Stored Procedure untuk:
- Insert data
- Update data
- Delete data
- Search data

Stored Procedure dibuat langsung pada SQL Server kemudian dipanggil melalui aplikasi Windows Forms menggunakan:
- SqlCommand
- CommandType.StoredProcedure
- SqlParameter

## Contoh Stored Procedure

```sql
CREATE PROCEDURE sp_LoginUser
    @email VARCHAR(100),
    @password VARCHAR(100)
AS
BEGIN
    SELECT *
    FROM users
    WHERE email = @email
    AND password = @password
END
```

---

# Implementasi SQL View

Project ini menggunakan SQL View untuk menampilkan data hasil relasi tabel.

## View yang Digunakan

```sql
vw_booking_detail
```

## Contoh View

```sql
CREATE VIEW vw_booking_detail AS
SELECT
    b.id AS booking_id,
    p.nama_lengkap,
    p.nik,
    d.nama_dokter,
    j.hari,
    j.jam_mulai,
    b.tanggal_booking,
    b.keluhan,
    b.status_booking
FROM booking b
JOIN pasien p ON b.pasien_id = p.id
JOIN jadwal_dokter j ON b.jadwal_id = j.id
JOIN dokter d ON j.dokter_id = d.id
```

---

# Implementasi Binding DataGridView

Project menggunakan konsep Binding pada DataGridView menggunakan:
- BindingSource
- DataTable

## Contoh Binding

```csharp
bsBooking.DataSource = dt;

dgvBooking.DataSource = bsBooking;
```

Binding digunakan pada:
- Data booking
- Data dokter
- Data jadwal dokter
- Riwayat booking pasien

---

# Implementasi BindingNavigator

Project menggunakan BindingNavigator untuk navigasi data pada DataGridView.

Fitur navigator:
- First
- Previous
- Next
- Last

BindingNavigator diterapkan pada:
- Booking Admin
- Data Dokter
- Jadwal Dokter
- Riwayat Booking Pasien
- Jadwal Booking Pasien

## Contoh BindingNavigator

```csharp
bindingNavigator1.BindingSource = bsBooking;
```

---

# Skenario SQL Injection

Pada project Sistem Booking Kontrol Pasien dilakukan simulasi SQL Injection pada halaman Dashboard Admin untuk menunjukkan bagaimana query SQL yang tidak diamankan dapat dimanipulasi.

## Lokasi SQL Injection

SQL Injection diterapkan pada fitur:
- tombol Inject
- halaman Dashboard Admin

## Tujuan Simulasi

Simulasi ini dibuat untuk menunjukkan bahwa query SQL yang tidak menggunakan:
- Stored Procedure
- Parameterized Query
- SqlParameter

dapat dimanipulasi sehingga menghasilkan data palsu pada DataGridView.

---

# Langkah Simulasi SQL Injection

## 1. Admin Login

Admin login menggunakan akun administrator.

## 2. Membuka Dashboard Admin

Admin membuka menu:
- Booking Pasien

## 3. Menekan Tombol Inject

Ketika tombol Inject ditekan, sistem menjalankan query vulnerable berikut:

```sql
SELECT 
    booking_id,
    'HACKED' AS nama_lengkap,
    'HACKED' AS nik,
    'HACKED' AS nama_dokter,
    'HACKED' AS hari,
    '10:00' AS jam_mulai,
    '2025-01-01' AS tanggal_booking,
    'DATABASE HACKED' AS keluhan,
    'HACKED' AS status_booking
FROM booking_detail
```

## 4. Hasil SQL Injection

Seluruh data pada DataGridView berubah menjadi:

| booking_id | nama_lengkap | nama_dokter | status_booking |
|------------|--------------|--------------|----------------|
| 2          | HACKED       | HACKED       | HACKED         |
| 3          | HACKED       | HACKED       | HACKED         |
| 4          | HACKED       | HACKED       | HACKED         |

Hal ini menunjukkan bahwa query SQL berhasil dimanipulasi sehingga menghasilkan data palsu.

---

# Dampak SQL Injection

SQL Injection dapat menyebabkan:
- manipulasi hasil query
- kebocoran data database
- akses data tanpa otorisasi
- perubahan tampilan informasi aplikasi

---

# Pencegahan SQL Injection

Pada fitur utama aplikasi, keamanan diterapkan menggunakan:
- Stored Procedure
- Parameterized Query
- SqlParameter
- SQL View

Sehingga query utama aplikasi aman dari SQL Injection.

---

# Tombol Reset

Project menyediakan tombol Reset untuk mengembalikan data normal setelah simulasi SQL Injection dijalankan.

Tombol Reset menjalankan kembali query aman menggunakan:
- Stored Procedure
- BindingSource

---

# Struktur Database

## Tabel
- users
- pasien
- dokter
- jadwal_dokter
- booking

## View
- vw_booking_detail

## Stored Procedure
- sp_LoginUser
- sp_RegisterPasien
- sp_InsertBooking
- sp_LoadBooking
- sp_UpdateBookingStatus
- sp_InsertDokter
- sp_InsertJadwal
- sp_HapusJadwal
- dan lainnya

---

# Kesimpulan

Project Sistem Booking Kontrol Pasien berhasil mengimplementasikan:
- Stored Procedure
- SQL View
- Binding DataGridView
- BindingNavigator
- Simulasi SQL Injection

sesuai dengan ketentuan tugas praktikum.

Selain itu, project juga menerapkan keamanan database menggunakan:
- Parameterized Query
- SqlParameter
- Stored Procedure

untuk mencegah SQL Injection pada fitur utama aplikasi.

---

## Berikut ScreenShoot Aplikasi

<img width="654" height="793" alt="image" src="https://github.com/user-attachments/assets/e7ca2eda-e529-4388-bd8b-d8f83f672b06" />
<img width="648" height="787" alt="image" src="https://github.com/user-attachments/assets/80a88032-9fde-4a5d-bc72-5aaa6b01a3dd" />
<img width="806" height="493" alt="image" src="https://github.com/user-attachments/assets/fd16f298-57e2-4276-bd3d-2c5e12f46518" />
<img width="986" height="633" alt="image" src="https://github.com/user-attachments/assets/e6e2df58-30cd-4ce9-87ce-83119da2ca86" />
<img width="985" height="629" alt="image" src="https://github.com/user-attachments/assets/2d322aa7-81da-4bcd-b43f-721e32e0714a" />
<img width="986" height="633" alt="image" src="https://github.com/user-attachments/assets/a9371537-5474-45d7-948b-db4c070340e0" />
<img width="806" height="493" alt="image" src="https://github.com/user-attachments/assets/5106ce12-ed06-4434-9045-218ac736b8f0" />
<img width="1084" height="665" alt="image" src="https://github.com/user-attachments/assets/5563b7b8-2bfb-4ba1-87b6-b38381d3f262" />
<img width="1084" height="665" alt="image" src="https://github.com/user-attachments/assets/bdc54942-fe17-441f-ac6e-1c745b6e48bd" />
<img width="1084" height="665" alt="image" src="https://github.com/user-attachments/assets/982e3825-aba7-49b8-b172-d0b552d8ab01" />
<img width="1084" height="665" alt="image" src="https://github.com/user-attachments/assets/0462e10b-500c-4ee4-9b41-af382c359971" />

SQL INJECTION
<img width="1084" height="665" alt="image" src="https://github.com/user-attachments/assets/d8d59f73-5c43-4a68-bf0a-e97da41dee39" />
<img width="1078" height="654" alt="image" src="https://github.com/user-attachments/assets/4b14e80f-3003-4179-9afb-32df772f9dff" />
