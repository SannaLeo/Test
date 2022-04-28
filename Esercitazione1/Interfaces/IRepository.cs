using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione1.Esercitazione1.Repository
{
    /// <summary>
    /// Interfaccia generica che chiede l'implementazione di alcuni metodi
    /// </summary>
    /// <typeparam name="T">Tipo generico T, elemento della lista</typeparam>
    internal interface IRepository<T>
    {
        List<T> GetAll();
        bool Aggiungi(T item);

    }
}
