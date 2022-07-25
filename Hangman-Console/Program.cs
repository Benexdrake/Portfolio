namespace Hangman_Console;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        string[] words = new string[] { "Test", "Anwendungsentwickler" };
        game.hangman(words,7);
    }
}