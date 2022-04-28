using Esercitazione1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione1.Esercitazione1.Repository
{
    internal class RepositoryCerchiFile : IRepository<Cerchio>
    {
        string path = @"D:\Lavoro\lezioni\codice\Lezione1\Esercitazione1\Repository\Cerchi.txt";
        public bool Aggiungi(Cerchio item)
        {
            if (item == null)
            {
                return false;
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"{item.Nome},{item.CoordinataX},{item.CoordinataY},{item.Raggio}");
                return true;
            }
        }

        public List<Cerchio> GetAll()
        {
            List<Cerchio> listaCerchi = new List<Cerchio>();
            using (StreamReader sr = new StreamReader(path))
            {
                string contenuto = sr.ReadToEnd();
                if (string.IsNullOrEmpty(contenuto))
                {
                    return listaCerchi;
                }
                else
                {
                    string[] cerchi = contenuto.Split('\n');
                    for (int i = 0; i < cerchi.Length-1; i++)
                    {
                        string nome;
                        int x, y;
                        double r;
                        string[] cerchio = cerchi[i].Split(",");
                        nome = cerchio[0];
                        if (!int.TryParse(cerchio[1], out x))
                        {
                            Console.WriteLine("Errore caricando la x del cerchio da file!");
                            return new List<Cerchio>();
                        }
                        if (!int.TryParse(cerchio[2], out y))
                        {
                            Console.WriteLine("Errore caricando la y del cerchio da file!");
                            return new List<Cerchio>();
                        }
                        if (!double.TryParse(cerchio[3], out r))
                        {
                            Console.WriteLine("Errore caricando il raggio del cerchio da file!");
                            return new List<Cerchio>();
                        }
                        Cerchio rett = new Cerchio(nome, x, y, r);
                        listaCerchi.Add(rett);
                    }
                    return listaCerchi;
                }
            }
        }
    }
}
