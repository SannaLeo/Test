using Esercitazione1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione1.Esercitazione1.Repository
{
    /// <summary>
    /// Fornisce una repository(MOCK) di cerchi
    /// </summary>
    internal class RepositoryCerchiMOCK : IRepository<Cerchio>
    {
        private static List<Cerchio> cerchi = new List<Cerchio>()
        {
            new Cerchio("c1", 0, 0, 10),
            new Cerchio("r2", 0, 0, 20),
            new Cerchio("r3", 0, 0, 30)
        };
        /// <summary>
        /// Aggiunge un item all'interno della repository
        /// </summary>
        /// <param name="item">Rettangolo da aggiungere alla repository</param>
        /// <returns>vero se l'operazione è andata a buon fine, false altrimenti</returns>
        public bool Aggiungi(Cerchio item)
        {
            if (item == null)
            {
                return false;
            }
            cerchi.Add(item);
            return true;
        }

        /// <summary>
        /// Fornisce la repository di Cerchi
        /// </summary>
        /// <returns>Lista di Cerchio</returns>
        public List<Cerchio> GetAll()
        {
            return cerchi;
        }
    }
}
