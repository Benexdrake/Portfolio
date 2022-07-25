namespace Geldautomat_Console
{
    static class Program
    {
        static void Main()
        {
            GeldAutomat geldautomat = new GeldAutomat();
            geldautomat.bankName = "Sparkasse";
            Kunde kunde1 = new Kunde(1, true, "Ben", "Drake", "12AB30056", 5_000, 5_000);
            geldautomat.menu(kunde1);
        }
    }
}