using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione1
{
    /// <summary>
    /// Rappresenta la forma geometrica generale
    /// </summary>
    internal abstract class Forma
    {
        #region Props
        public string Nome { get; set; } = "FormaBellina";
        public double Area { get { return CalcolaArea(); }}
        #endregion

        #region Constructors
        public Forma() { }
        public Forma(string nome)
        {
            Nome = nome;
        }
        #endregion

        #region Methods
        public virtual double CalcolaArea()
        {
            return 0;
        }

        public virtual void Disegna()
        {
            Console.WriteLine($"Generica figura {Nome}");
        }
        #endregion
    }
}
