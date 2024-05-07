using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rubrica
{
    internal class Indirizzo
    {
        /*L’indirizzo, a sua volta conterrà la via, cap, città e provincia.*/

        public string Via { get; set; }
        public int Cap {get; set; }

        public string Citta { get; set; }

        public string Provincia { get; set; }


        public Indirizzo() { }

        public Indirizzo(string via, int cap, string citta, string provincia)
        {
            Via = via;
            Cap = cap;
            Citta = citta;
            Provincia = provincia;
        }

        public string Stampa()
        {
            return $"" +
                $"\nVia: {Via}" +
                $"\nCap: {Cap}" +
                $"\nCitta: {Citta}" +
                $"\n: {Provincia}"
                ;
        }
    }
}
