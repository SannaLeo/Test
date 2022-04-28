using Esercitazione1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione1.Esercitazione1.Repository
{
    internal class RepositoryRettangoliFile : IRepository<Rettangolo>
    {
        /// <summary>
        /// Repositori file dei rettangoli
        /// </summary>
        string path = @"D:\Lavoro\lezioni\codice\Lezione1\Esercitazione1\Repository\Rettangoli.txt";
        public bool Aggiungi(Rettangolo item)
        {
            if(item == null)
            {
                return false;
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"{item.Nome},{item.Larghezza},{item.Altezza}");
                return true;
            }
            
        }

        public List<Rettangolo> GetAll()
        {
            List<Rettangolo> listarettangoli = new List<Rettangolo>();
            using (StreamReader sr = new StreamReader(path))
            {
                string contenuto = sr.ReadToEnd();
                if(string.IsNullOrEmpty(contenuto))
                {
                    return listarettangoli;
                }
                else
                {
                    string[] rettangoli = contenuto.Split('\n');
                    for(int i = 0; i < rettangoli.Length-1; i++)
                    {
                        string nome;
                        double b,h;
                        string[] rettangolo = rettangoli[i].Split(",");
                        nome = rettangolo[0];
                        if(!double.TryParse(rettangolo[1], out b))
                        {
                            Console.WriteLine("Errore caricando la base del rettangolo da file!");
                            return new List<Rettangolo>();
                        }
                        if (!double.TryParse(rettangolo[2], out h))
                        {
                            Console.WriteLine("Errore caricando l'altezza del rettangolo da file!");
                            return new List<Rettangolo>();
                        }
                        Rettangolo rett = new Rettangolo(nome, h, b);
                        listarettangoli.Add(rett);
                    }
                    return listarettangoli;
                }
            }
        }
    }
}
