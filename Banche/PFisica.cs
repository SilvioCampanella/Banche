using System.Diagnostics.Contracts;

namespace Banche
{
    public class PFisica
    {

        private string _name;
        private string _cognome;
        private string _cf;
        private string _datadinascita;
        private string _residenza;

        public PFisica(string name, string cognome, string cf, string datadinascita, string residenza)
        {
            _name = name;
            _cognome = cognome;
            _cf = cf;
            _datadinascita = datadinascita;
            _residenza = residenza;
        }
    }
}

