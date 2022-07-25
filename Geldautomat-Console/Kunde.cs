namespace Geldautomat_Console
{
    internal class Kunde
    {
        public int kID { get; set; }
        public bool available { get; set; }
        public string kVorName { get; set; }
        public string kNachName { get; set; }
        public string kIban { get; set; }
        public int kontoStand { get; set; }
        public int taschenGeld { get; set; }

        public Kunde()
        {
        }

        public Kunde(int _kID, bool _available, string _kVorname, string _kNachname, string _kIban, int _kontostand, int _taschenGeld)
        {
            kID = _kID;
            available = _available;
            kVorName = _kVorname;
            kNachName = _kNachname;
            kIban = _kIban;
            kontoStand = _kontostand;
            taschenGeld = _taschenGeld;
        }
    }
}
