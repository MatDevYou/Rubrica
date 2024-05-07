using System.Text.RegularExpressions;

namespace Rubrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Indirizzo i1 = new Indirizzo()
            {
               Via = "Via Trento 28",
               Cap = 10100,
               Citta = "Torino",
               Provincia = "TO"
            };


            Contatto c1 = new Contatto()
            {
                Nome = "Matteo",
                Cognome = "Meringolo",
                Indirizzo = i1,
                Email = "m@gmail.com",
                Telefono = "011-4329612"
            };

            Contatto v1 = new Contatto()
            {
                Nome = "MArio",
                Cognome = "Rossi"
            };

            //Console.WriteLine(v1.ToString());

            Console.WriteLine(c1.Stampa());
           


        }
    }
}