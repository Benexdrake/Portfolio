namespace Geldautomat_Console_SQL
{
    internal class GeldAutomat
    {
        public string bankName { get; set; }


        bool escape = false;
        string iban;
        string pin;
        Kunde kunde;
        LoginDB login;
        public void menu()
        {
            login = new LoginDB();
            while (true)
            {
                Console.WriteLine("Willkommen bei der Sparkasse, bitte geben Sie ihre Iban, so wie ihren Pin ein");
                Console.Write("Iban: ");
                iban = Console.ReadLine();
                Console.Write("Pin: ");
                pin = Console.ReadLine();
                Console.WriteLine();

                login.readSql("select * from Kunde join Konto on Konto.id = Kunde.id where iban ='" + iban + "' and pin = '" + pin + "';");
                Console.WriteLine("Hi1");
                if (login.isloginOk == true)
                {

                    while (true)
                    {


                        kunde = login.kunde;
                        Console.Clear();
                        Console.WriteLine("Bitte wählen sie zwischen 1-4 aus oder Escape zum beenden");
                        Console.WriteLine(">1< Kontostand");
                        Console.WriteLine(">2< Einzahlen");
                        Console.WriteLine(">3< Auszahlen");
                        Console.WriteLine(">4< Überweisen");

                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:

                                kontostand();
                                break;

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
                        {
                            Environment.Exit(0);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Iban oder Pin falsch, bitte Tastedrücken um es noch einmal zu versuchen");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }


        }

        public void einzahlung(Kunde kunde)
        {
            Console.Clear();

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

                        kunde.kontoStand += einzahlung;
                        login.writeSql("update Konto set kontostand  = "+ kunde.kontoStand +" where id = "+ login.kunde.kID +";");

                        kontostand();
                        break;


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

    

    public void auszahlung(Kunde kunde)
    {
        Console.Clear();

        while (true)
        {
            Console.Write("Wieviel möchten Sie abheben?: ");
            string zahlung = Console.ReadLine();
            bool zahl = int.TryParse(zahlung, out int auszahlung);
            if (zahl == true)
            {
                Console.WriteLine("Möchten Sie " + auszahlung + " abheben? J/N");
                if (Console.ReadKey().Key == ConsoleKey.J)
                {
                    if (kunde.kontoStand >= auszahlung)
                    {
                        kunde.kontoStand -= auszahlung;
                            login.writeSql("update Konto set kontostand  = " + kunde.kontoStand + " where id = " + login.kunde.kID + ";");
                            kontostand();
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



    public void kontostand()
    {
        login.readSql("select * from Kunde join Konto on Konto.id = Kunde.id where iban ='" + iban + "' and pin = '" + pin + "';");
        Console.Clear();
        Console.WriteLine("Ihr Kontostand beträgt: " + login.kunde.kontoStand);
        Console.WriteLine("Bitte Taste drücken...");
        Console.ReadKey();
    }

    public void ueberweisung(Kunde kunde)
    {
        Console.Clear();
            //Kunde kundeUeberweisung = new Kunde();
            LoginDB loginUeberweisung = new LoginDB();
            
            Console.WriteLine("Iban und Betrag zum überweisen angeben!");
            while (true)
            {

                Console.Write("Iban: ");
                string ibanUeberweisung = Console.ReadLine();
                loginUeberweisung.readSql("select * from Kunde join Konto on Konto.id = Kunde.id where iban ='" + iban + "';");

                if (loginUeberweisung.isloginOk == true)
                {


                    Console.WriteLine("Betrag: ");
                    bool zahl = int.TryParse(Console.ReadLine(), out int geld);
                    if (zahl)
                    {
                        Console.WriteLine("Sie möchten " + geld + " an " + ibanUeberweisung + " überweisen? J/N");
                        if (Console.ReadKey().Key == ConsoleKey.J)
                        {
                            int zwischenstand = loginUeberweisung.kunde.kontoStand + geld;
                            loginUeberweisung.writeSql("update Konto set kontostand  = " + zwischenstand + " where id = " + loginUeberweisung.kunde.kID + ";");
                            zwischenstand = login.kunde.kontoStand - geld;
                            login.writeSql("update Konto set kontostand  = " + zwischenstand + " where id = " + login.kunde.kID + ";");

                            Console.WriteLine("Sie haben " + geld + " an die Iban: " + iban + " gesendet.");
                            kontostand();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sie werden zum Menü weiter geleiten, taste drücke zum fortfahren...");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else
                {
                    Console.WriteLine("Diese Iban existiert nicht, wollen Sie es erneut versuchen? J/N");
                    if(Console.ReadKey().Key == ConsoleKey.J)
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Sie werden zum Menü weiter geleiten, taste drücke zum fortfahren...");
                        Console.ReadKey();
                        break;
                    }
                }
            }


        
        Console.WriteLine("Bitte Taste drücken...");
        Console.ReadKey();
    }

    }
 }

