
namespace Geldautomat_Console_SQL
{
    static class Program
    {
        static void Main()
        {
            GeldAutomat geld = new GeldAutomat();
            geld.bankName = "Sparkasse";
            geld.menu();   
        }
    }
}