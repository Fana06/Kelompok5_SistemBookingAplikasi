namespace SistemBookingPasien_5.Helpers
{
    public static class SessionHelper
    {
        public static int    UserId     { get; set; }
        public static string Email      { get; set; }
        public static string Role       { get; set; }
        public static int    PasienId   { get; set; }
        public static string NamaLengkap { get; set; }

        public static void Clear()
        {
            UserId      = 0;
            Email       = null;
            Role        = null;
            PasienId    = 0;
            NamaLengkap = null;
        }

        public static bool IsAdmin  => Role == "admin";
        public static bool IsPasien => Role == "pasien";
    }
}
