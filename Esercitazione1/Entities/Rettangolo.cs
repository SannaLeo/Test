using Esercitazione1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione1
{
    /// <summary>
    /// Rappresenta la forma geometrica Rettangolo con alcune operazioni
    /// </summary>
    internal class Rettangolo : Forma, IProva
    {
        #region Props
        public double Altezza { get; private set; } = 2;
        public double Larghezza { get; private set; } = 3;
        #endregion


        #region Constructors
        public Rettangolo(){}
        public Rettangolo(string nome, double altezza, double larghezza) : base(nome)
        {
            Altezza = altezza;  
            Larghezza = larghezza;
        }
        #endregion


        #region Public Methods
        public override double CalcolaArea()
        {
            return Altezza * Larghezza;
        }

        public override void Disegna()
        {
            Console.WriteLine($"Il rettangolo {Nome} ha altezza {Altezza}, Larghezza {Larghezza} e area di {Area.ToString("0.00000")}");
        }

        public void StampaQualcosa()
        {
            Console.WriteLine("Qualcosa");
        }
        #endregion
    }
}
