namespace Geldautomat_Console
{
    internal class GeldAutomat
    {
        public string bankName { get; set; }
        const int maxGeld = 1_000_000;
        const int minGeld = 0;
        int totalGeld = 500_000;
        bool escape = false;

        public void menu(Kunde kunde)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Willkommen bei der " + bankName + ", bitte wählen sie zwischen 1-4 aus oder Escape zum beenden");
                Console.WriteLine(">1< Kontostand");

                Console.WriteLine(">2< Einzahlen");
                Console.WriteLine(">3< Auszahlen");
                Console.WriteLine(">4< Überweisen");


                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        {
                            kontostand(kunde);
                            break;
                        }

                    case ConsoleKey.D2:
                        einzahlung(kunde);
                        break;

                    case ConsoleKey.D3:
                        auszahlung(kunde);
                        break;

                    case ConsoleKey.D4:
                        ueberweisung(kunde);
                        break;

                    case ConsoleKey.Escape:
                        escape = true;
                        break;

                    default:
                        Console.WriteLine("Bitte zwischen 1-4 auswählen, Escape zum beenden");
                        break;
                }
                if (escape)
                    break;
            }
        }

        public void einzahlung(Kunde kunde)
        {
            Console.Clear();
            if (totalGeld > 0 && totalGeld < maxGeld && kunde.taschenGeld > 0)
            {
                while (true)
                {
                    Console.Write("Wieviel möchten Sie einzahlen?: ");
                    string zahlung = Console.ReadLine();
                    bool zahl = int.TryParse(zahlung, out int einzahlung);
                    if (zahl == true)
                    {
                        Console.WriteLine("Möchten Sie " + einzahlung + " einzahlen? J/N");
                        if (Console.ReadKey().Key == ConsoleKey.J)
                        {
                            if (kunde.taschenGeld >= einzahlung && einzahlung <= totalGeld && totalGeld <= maxGeld && totalGeld >= minGeld)
                            {
                                kunde.kontoStand += einzahlung;
                                kunde.taschenGeld -= einzahlung;
                                totalGeld += einzahlung;
                                kontostand(kunde);
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sie wollen " + einzahlung + " einzahlen, haben aber nur " + kunde.taschenGeld);
                                Console.WriteLine("Bitte Taste drücken...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sie haben Nein gewählt, bitte erneut eingeben\n");
                            continue;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error, Geld konnte nicht gezählt werden, bitte erneut versuchen\n");
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ihr Geld reicht nicht aus");
                Console.WriteLine("Bitte Taste drücken...");
                Console.ReadKey();
            }
        }

        public void auszahlung(Kunde kunde)
        {
            Console.Clear();
            if (totalGeld > 0 && totalGeld < maxGeld && kunde.kontoStand > 0)
            {
                while (true)
                {
                    Console.Write("Wieviel möchten Sie einzahlen?: ");
                    string zahlung = Console.ReadLine();
                    bool zahl = int.TryParse(zahlung, out int auszahlung);
                    if (zahl == true)
                    {
                        Console.WriteLine("Möchten Sie " + auszahlung + " einzahlen? J/N");
                        if (Console.ReadKey().Key == ConsoleKey.J)
                        {
                            if (kunde.kontoStand >= auszahlung && auszahlung <= totalGeld && totalGeld <= maxGeld && totalGeld >= minGeld)
                            {
                                kunde.kontoStand -= auszahlung;
                                kunde.taschenGeld += auszahlung;
                                totalGeld -= auszahlung;
                                kontostand(kunde);
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sie wollen " + auszahlung + " abheben, haben aber nur " + kunde.kontoStand + " auf dem Konto");
                                Console.WriteLine("Bitte Taste drücken...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sie haben Nein gewählt, bitte erneut eingeben\n");
                            continue;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error, Geld konnte nicht gezählt werden, bitte erneut versuchen\n");
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ihr Geld reicht nicht aus");
                Console.WriteLine("Bitte Taste drücken...");
                Console.ReadKey();
            }
        }

        public void kontostand(Kunde kunde)
        {
            Console.Clear();
            Console.WriteLine("Ihr Kontostand beträgt: " + kunde.kontoStand);
            Console.WriteLine("Bitte Taste drücken...");
            Console.ReadKey();
        }

        public void ueberweisung(Kunde kunde)
        {
            Console.Clear();
            Console.WriteLine("Dieser Bereich wird es erst mit SQL geben");
            Console.WriteLine("Bitte Taste drücken...");
            Console.ReadKey();
        }


    }
}
