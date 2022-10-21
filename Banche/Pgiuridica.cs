using System.Diagnostics.Contracts;

namespace Banche
{
    public class Pgiuridica
    {

        private string _name;
        private string _cf;
        private string _piva;
        private string _indirizzo;

        public Pgiuridica(string nome, string CF, string PIVA, string indirizzo)
        {
            _name = nome;
            _cf = CF;
            _piva = PIVA;
            _indirizzo = indirizzo;
        }
    }
}

