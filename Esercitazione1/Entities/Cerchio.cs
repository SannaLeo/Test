using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione1
{
    /// <summary>
    /// Rappresenta la forma geometrica Cerchio con alcune operazioni
    /// </summary>
    internal class Cerchio : Forma
    {
        #region Props
        public int CoordinataX { get; set; } = 0;
        public int CoordinataY { get; set; } = 0;
        public double Raggio { get; set; } = 3;
        #endregion
        
        #region Constructors
        public Cerchio() { }

        public Cerchio(string nome, int x, int y, double raggio) : base(nome)
        {
            CoordinataX = x;
            CoordinataY = y;    
            Raggio = raggio;
        }
        #endregion
        #region Public Methods
        public override double CalcolaArea()
        {
            return Math.Pow(Raggio, 2) * Math.PI;
        }

        public override void Disegna()
        {
            Console.WriteLine($"Il cerchio \t{Nome}\t ha raggio \t{Raggio}\t Cordinate del centro\t({CoordinataX},{CoordinataY})\t area di \t{Area.ToString("0.00")}");
        }
        #endregion
    }
}
