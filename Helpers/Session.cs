namespace BookingKontrolPasien.Helpers
{
    public static class Session
    {
        public static int UserId { get; set; }
        public static string Email { get; set; }
        public static string Role { get; set; }
        public static int PasienId { get; set; }
        public static string NamaLengkap { get; set; }

        public static void Clear()
        {
            UserId = 0;
            Email = null;
            Role = null;
            PasienId = 0;
            NamaLengkap = null;
        }
    }
}
