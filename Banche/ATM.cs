namespace Banche
{
    public class ATM
    {

        private double _saldodisponibile;
        public string _indirizzo;
        private string _gps;
        private int _id;


        public ATM(double saldodisponibile, string indirizzo, string gps, int id)
        {
            _saldodisponibile = saldodisponibile;
            _indirizzo = indirizzo;
            _gps = gps;
            _id = id;
        }
    }
}



