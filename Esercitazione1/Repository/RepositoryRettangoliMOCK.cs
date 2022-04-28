using Esercitazione1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione1.Esercitazione1.Repository
{
    /// <summary>
    /// Repostory di tutti i Rettangoli
    /// </summary>
    internal class RepositoryRettangoliMOCK : IRepository<Rettangolo>
    {
        private static List<Rettangolo> rettangoli = new List<Rettangolo>()
        {
            new Rettangolo("r1", 10, 1),
            new Rettangolo("r2", 20, 2),
            new Rettangolo("r3", 30, 3)
        };
        /// <summary>
        /// Aggiunge un item all'interno della repository
        /// </summary>
        /// <param name="item">Rettangolo da aggiungere alla repository</param>
        /// <returns>vero se l'operazione è andata a buon fine, false altrimenti</returns>
        public bool Aggiungi(Rettangolo item)
        {
            if(item == null)
            {
                return false;
            }
            rettangoli.Add(item);
            return true;
        }

        /// <summary>
        /// Fornisce i rettangoli nella repository(MOCK)
        /// </summary>
        /// <returns>Una lista di Rettangoli</returns>
        public List<Rettangolo> GetAll()
        {
            return rettangoli;
        }
    }
}
