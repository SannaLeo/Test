using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione1
{
    /// <summary>
    /// Rappresenta la forma geometrica Triangolo con alcune operazioni
    /// </summary>
    internal class Triangolo : Forma
    {
        #region Props
        public double Base { get; set; } = 2;
        public double Altezza { get; set; } = 4;
        #endregion

        #region Contructors
        public Triangolo(){}

        public Triangolo(string nome, double basee, double altezza) : base(nome)
        {
            Base = basee;
            Altezza = altezza;
        }
        
        #endregion

        #region Public Methods
        public override double CalcolaArea()
        {
            return (Base * Altezza) / 2f;        
        }

        public override void Disegna()
        {
            Console.WriteLine($"Il triangolo {Nome}\t ha altezza \t{Altezza}\t Base \t{Base}\t area di \t{Area.ToString("0.00")}");
        }
        #endregion 
    }
}
