using System.Diagnostics.Contracts;

namespace Banche
{
    public class Personale {
        internal string _name;
        private string _cognome;
        private string _cf;
        internal string _sesso;
        private string _datanascita;
        internal string _mansione;
        private string _statosociale;


        public Personale(string name, string cognome, string cf, string sesso, string datanascita, string mansione, string statosociale)
        {
            _name = name;
            _cognome = cognome;
            _cf = cf;
            _sesso = sesso;
            _datanascita = datanascita;
            _mansione = mansione;
            _statosociale = statosociale;
        }
    }

    
}


