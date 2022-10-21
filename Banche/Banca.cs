using System.Net.Sockets;
using System.Xml.Linq;

namespace Banche
{
    public class Banca
    {
        public string _name;
        public string _indirizzo;
        public int _numerofiliale;
        public string _piva;
        public int _numerodipendenti;
        public int _capitalesociale;



        public Banca(string name, string indirizzo, int numerofiliale, string piva, int numerodipendenti, int capitalesociale)
        {
            _name = name;
            _indirizzo = indirizzo;
            _numerofiliale = numerofiliale;
            _piva = piva;
            _numerodipendenti = numerodipendenti;
            _capitalesociale = capitalesociale;
        }
    }
}


