
namespace UmwandlerForms
{
    public class Wandler
    {
        string[] menuItems;
        string[][] items;
        string[] datenGroesse;
        string[] datenUebertragungsRate;
        string[] druck;
        string[] energie;
        string[] flaeche;
        string[] flaechenWinkel;
        string[] frequenz;
        string[] geschwindigkeit;
        string[] kraftstoffVerbrauch;
        string[] laenge;
        string[] masse;
        string[] temperatur;
        string[] volumen;
        string[] zeit;

        public string[][] Items { get { return items; } set { items = value; } }
        public string[] MenuItems { get { return menuItems; } set { menuItems = value; } }


        public Wandler()
        {
            NewItems();
            ItemsFiller();
        }

        private void ItemsFiller()
        {
            menuItems = new string[]
            {
                "Datengröße",
                "Datenübertragungsrate",
                "Druck",
                "Energie",
                "Fläche",
                "Flächenwinkel",
                "Frequenz",
                "Geschwindigkeit",
                "Kraftstoffverbrauch",
                "Länge",
                "Masse",
                "Temperatur",
                "Volumen",
                "Zeit"
            };

            items = new string[][]
            {
                datenGroesse,
                datenUebertragungsRate,
                druck,
                energie,
                flaeche,
                flaechenWinkel,
                frequenz,
                geschwindigkeit,
                kraftstoffVerbrauch,
                laenge,
                masse,
                temperatur,
                volumen,
                zeit
            };
        }

        private void NewItems()
        {
            datenGroesse = new string[]
            {
                "Bit",
                "Kilobit",
                "Kibibit",
                "Megabit",
                "Mebibit",
                "Gigabit",
                "Gibibit",
                "Terabit",
                "Tebibit",
                "Petabit",
                "Pebibit",
                "Byte",
                "Kilobyte",
                "Kibibyte",
                "Megabyte",
                "Mebibyte",
                "Gigabyte",
                "Gibibyte",
                "Terabyte",
                "Tebibyte",
                "Petabyte",
                "Pebibyte"
            };
            datenUebertragungsRate = new string[]
            {
                "Bit pro Sekunde",
                "Kilobit pro Sekunde",
                "Kilobyte pro Sekunde",
                "Kibibit pro Sekunde",
                "Megabit pro Sekunde",
                "Megabyte pro Sekunde",
                "Mebibit pro Sekunde",
                "Gigabit pro Sekunde",
                "Gigabyte pro Sekunde",
                "Gibibit pro Sekunde",
                "Terabit pro Sekunde",
                "Terabyte pro Sekunde",
                "Tebibit pro Sekunde",
            };
            druck = new string[]
            {
                "Bar",
                "Pascal",
                "Physikalische Atmosphäre",
                "Pound-force per square inch",
                "Torr"
            };
            energie = new string[]
            {
                "Joule",
                "Kilojoule",
                "Kalorie",
                "Kilokalorie",
                "Wattstunde",
                "Kilowattstunde",
                "Elektronvolt",
                "British thermal unit",
                "US-amerikanisches Therm",
                "Foot-pound",
            };
            flaeche = new string[]
            {
                "Quadratkilometer",
                "Quadratmeter",
                "Quadratmeile",
                "Quadratyard",
                "Quadratfuß",
                "Quadratzoll",
                "Hektar",
                "Acre",
            };
            flaechenWinkel = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };
            frequenz = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };
            geschwindigkeit = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };
            kraftstoffVerbrauch = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };
            laenge = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };
            masse = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };
            temperatur = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };
            volumen = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };
            zeit = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };
        }


    }
}
