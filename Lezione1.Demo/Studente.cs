using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione1.Demo
{
    internal class Studente : Person
    {
        public int Matricola { get; set; }


        public override void Saluta()
        {
            Console.WriteLine("Ciao sono uno studente.");
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override void ChiamaTizio()
        {
            Console.WriteLine("ciao sono uno studente e sto chiamando tizio");
        }
    }

    
}
