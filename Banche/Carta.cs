using System.Diagnostics.Contracts;

namespace Banche
{
    public class Carta
    {
        private string _numerocarta;
        private string _data;
        private int _cvv;



        public Carta(string numerocarta, string data, int cvv)
        {
            _numerocarta = numerocarta;
            _data = data;
            _cvv = cvv;


        }
    }
}


