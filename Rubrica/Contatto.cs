using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica
{
    internal class Contatto
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public Indirizzo Indirizzo { get; set; } // Aggiunto un attributo di tipo Indirizzo

        public string Email { get; set; }
        public string Telefono { get; set; }

        public Contatto() { }

        public Contatto(string cognome, string nome, Indirizzo indirizzo, string email, string telefono)
        {
            Cognome = cognome;
            Nome = nome;
            Indirizzo = indirizzo; // Inizializzato l'attributo Indirizzo con l'istanza fornita
            Email = email;
            Telefono = telefono;
        }

        public Contatto(string cognome, string nome)
        {
            Cognome = cognome;
            Nome = nome;
        }


        public string Stampa()
        {
            return $"{Nome} {Cognome} - {Indirizzo.Via} {Indirizzo.Cap}, {Indirizzo.Citta} ({Indirizzo.Provincia}) Tel. {Telefono} - email: {Email}";
        }

        public override string ToString()
        {
            return $"{{{nameof(Cognome)}={Cognome}, {nameof(Nome)}={Nome}, {nameof(Indirizzo)}={Indirizzo}, {nameof(Email)}={Email}, {nameof(Telefono)}={Telefono}}}";
        }
    }
}
