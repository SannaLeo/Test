using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione1.Demo
{
    internal abstract class Person
    {
        public String FirstName { get; set; } = "nome";
        public String LastName { get; set; } = "cognome";
        public DateTime BirthDay { get; set; } = DateTime.UtcNow;
        private String _codiceFiscale;
        private double Stipendio { get { return 1200; } }
        protected string Soprannome { get; set; } = "pippo";

        public string GetInfoPersona()
        {
            string infoPersona = $"Codice fiscale: {_codiceFiscale} - Stipendio: {Stipendio}";
            Console.WriteLine(CodiceFiscale);
            Console.WriteLine(Stipendio);
            return infoPersona;

        }
        //campo calcolato
        public string CodiceFiscale 
        { 
            get 
            { 
                _codiceFiscale = FirstName.Substring(0,3) + LastName.Substring(0,3) + BirthDay.Year;
                return _codiceFiscale;
            }
        }
        
        public override string ToString()
        {
            return $"{FirstName} {LastName} nato il {BirthDay.ToShortDateString()}";
        }

        public virtual void Saluta()
        {
            Console.WriteLine("Ciao sono un persona.");
        }

        public abstract void ChiamaTizio();
    }
}
