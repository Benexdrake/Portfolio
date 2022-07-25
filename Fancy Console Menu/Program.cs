namespace Fancy_Console_Menu
{

    class Program
    {
        public static void Main()
        {
                string prompt = "This is a Fancy Menu";

                string[] options = { "Play", "About", "Exit" };

                Menu menu = new Menu(options);
                int selectedIndex = menu.Run();
                Console.WriteLine(selectedIndex);
        }

    }
}
