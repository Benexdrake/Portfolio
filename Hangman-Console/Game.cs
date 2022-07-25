using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console
{
    public class Game
    {
        public void hangman(String[] _words, int lives)
        {
            Random r = new Random();
            bool isCorrect = false;
            bool isEmpty = true;
            string eingabe;
            char buchstabe;
            int wahl = r.Next(0, _words.Length);
            char[] word = _words[wahl].ToCharArray();
            char[] empty = new char[word.Length];

            int round = 1;

            for (int i = 0; i < word.Length; i++)
            {
                empty[i] = '_';
            }

            Console.WriteLine("Willkommen bei Hangman, sie haben " + lives +" Versuche");
            

            while(true)
            {
                if(round > 1)
                {
                    
                }
                Console.WriteLine("Bitte geben Sie einen Buchstaben ein");

                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(empty[i]);
                }
                Console.WriteLine();

                eingabe = Console.ReadLine();

                buchstabe = eingabe.First();

                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0)
                    {
                        eingabe = eingabe.ToUpper();
                        buchstabe = eingabe.First();
                    }
                    else
                    {
                        eingabe = eingabe.ToLower();
                        buchstabe = eingabe.First();
                    }

                    if (buchstabe == word[i])
                    {
                        if (word[i] == empty[i])
                        {
                            Console.WriteLine(word[i]);
                            Console.WriteLine(empty[i]);
                            isCorrect = false;
                        }
                        else
                        {
                        empty[i] = buchstabe;
                        isCorrect = true;
                        }
                        
                    }
                    else
                    {
                        
                    }
                }
                

                if (isCorrect == false)
                {
                    lives--;
                    
                }


                for (int i = 0; i < word.Length; i++)
                {
                    if (empty[i] == '_')
                    {
                        isEmpty = true;
                    }

                }
                Console.Clear();

                if (lives >= 0)
                {
                    Console.WriteLine("Sie haben noch " + lives + " Leben übrig");
                    hangmanASCII(lives);
                }

                if (lives <= 0)
                {
                    Console.WriteLine("Game Over!");
                    break;
                }
                else if (lives >= 0 && isEmpty == false)
                {
                    Console.Write("Gewonnen, das gesuchte Wort war: ");
                    for (int i = 0; i < word.Length; i++)
                    {
                        Console.Write(empty[i]);
                    }
                    break;
                }
                isEmpty = false;

                round++;
                isCorrect = false;

            }
        }

        void hangmanASCII(int lives)
        {

            switch(lives)
            {
                case 6:
                    {
                                          Console.WriteLine("  +---+");
                                          Console.WriteLine("  |   |");
                                          Console.WriteLine("      |");
                                          Console.WriteLine("      |");
                                          Console.WriteLine("      |");
                                          Console.WriteLine("      |");
                                          Console.WriteLine("=========");
                        break;
                    }
                case 5:
                    {
                                          Console.WriteLine("  +---+"); 
                                          Console.WriteLine("  |   |"); 
                                          Console.WriteLine("  O   |"); 
                                          Console.WriteLine("      |"); 
                                          Console.WriteLine("      |"); 
                                          Console.WriteLine("      |");
                                          Console.WriteLine("=========");

                        break;
                    }
                    case 4:
                    {
                                          Console.WriteLine("  +---+");
                                          Console.WriteLine("  |   |");
                                          Console.WriteLine("  O   |");
                                          Console.WriteLine("  |   |");
                                          Console.WriteLine("      |");
                                          Console.WriteLine("      |");
                                          Console.WriteLine("=========");
                        break;
                    }
                    case 3:
                    {
                                        Console.WriteLine("  +---+");
                                        Console.WriteLine("  |   |");
                                        Console.WriteLine("  O   |");
                                        Console.WriteLine(" /|   |");
                                        Console.WriteLine("      |");
                                        Console.WriteLine("      |");
                                        Console.WriteLine("=========");
                        break;
                    }
                    case 2:
                    {
                                        Console.WriteLine("  +---+");
                                        Console.WriteLine("  |   |" );
                                        Console.WriteLine("  O   |" );
                                        Console.WriteLine(@" /|\  |");
                                        Console.WriteLine("      |" );
                                        Console.WriteLine("      |");
                                        Console.WriteLine("=========");
                        break;
                    }
                    case 1:
                    {
                                         Console.WriteLine("  +---+");
                                         Console.WriteLine("  |   |");
                                         Console.WriteLine("  O   |");
                                         Console.WriteLine(@" /|\  |");
                                         Console.WriteLine(" /    |");
                                         Console.WriteLine("      |");
                                         Console.WriteLine("=========");
                        break;
                    }
                    case 0:
                    {
                                        Console.WriteLine("  +---+");
                                        Console.WriteLine("  |   |");
                                        Console.WriteLine("  O   |");
                                        Console.WriteLine(@" /|\  |");
                                        Console.WriteLine(@" / \  |");
                                        Console.WriteLine("      |");
                                        Console.WriteLine("=========");
                        break;
                    }
            }



        }
    }

   

}
