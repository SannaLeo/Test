using Esercitazione1;
using Lezione1.Esercitazione1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione1.Esercitazione1
{
    /// <summary>
    /// Classe per l'interazione utente con le forme geometriche, contiente un menu interagibile dall'utente.
    /// Il metodo Start() è l'entry point
    /// </summary>

    internal static class InterazioneUtente
    {
        //static RepositoryRettangoliMOCK repoRettangoli = new RepositoryRettangoliMOCK();
        static IRepository<Rettangolo> repoRettangoli = new RepositoryRettangoliFile();
        //static IRepository<Cerchio> repoCerchi = new RepositoryCerchiMOCK();
        static IRepository<Cerchio> repoCerchi = new RepositoryCerchiFile();
        #region Start Method 
        public static void Start()
        {
            bool continua = true;

            while (continua)//fintanto che contunua==true cicla.
            {
                int risposta = Menu();
                //controllo la risposta tramite uno switch
                switch (risposta)
                {
                    case 1:
                        VisualizzaRettangoli();
                        break;
                    case 2:
                        AggiungiRettangolo();
                        break;
                    case 3:
                        RicercaRettangoloPerNome();
                        break;
                    case 4:
                        VisualizzaCerchi();
                        break;
                    case 5:
                        AggiungiCerchio();
                        break;
                    case 6:
                        RicercaCerchiPerRaggio();
                        break;
                    case 0:
                        continua = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Scelta non consentita, riprova");
                        break;
                }
            }
        }
        #endregion

        #region Secondary methods
        /// <summary>
        /// Stampa a video tutti i rettangoli presenti nella repository
        /// </summary>
        private static void VisualizzaRettangoli()
        {
            Console.Clear();
            var forme = repoRettangoli.GetAll();
            int n = forme.Count;
            if (n == 0)
            {
                Console.WriteLine("Nessun Rettangolo nella lista");
                return;
            }
            else
            {
                Console.WriteLine($"Sono presenti questi {n} rettangoli:");
                foreach (var f in forme)
                {
                    f.Disegna();
                }
            }

        }
        /// <summary>
        /// Stampa a video tutti i cerchi presenti nella repository
        /// </summary>
        private static void VisualizzaCerchi()
        {
            Console.Clear();
            var forme = repoCerchi.GetAll();
            int n = forme.Count;
            if (n == 0)
            {
                Console.WriteLine("Nessun Cerchio nella lista");
                return;
            }
            else
            {
                Console.WriteLine($"Sono presenti questi {n} cerchi:");
                foreach (var f in forme)
                {
                    f.Disegna();
                }
            }
        }
        /// <summary>
        /// Metodo per la ricerca di più cerchi per il raggio
        /// </summary>
        private static void RicercaCerchiPerRaggio()
        {
            Console.Clear();
            var listaCerchi = repoCerchi.GetAll();
            Console.WriteLine("Inserisci il raggio del cerchio da cercare ");
            double raggio;
            while(!double.TryParse(Console.ReadLine(), out raggio))
            {
                Console.WriteLine("Valore non consentito, riprova");
            }
            int n = 0;
            foreach (var r in listaCerchi)
            {
                if (r.Raggio == raggio)
                {
                    n++;
                    r.Disegna();
                }
            }
            if(n == 0)
            {
                Console.WriteLine("Nessun cerchio trovato");
            }
            else
            {
                Console.WriteLine($"Sono stati trovati {n} cerchi con il raggio indicato");
            }
            
        }
        /// <summary>
        /// Metodo per la ricerca di un rettangolo per il nome
        /// </summary>
        private static void RicercaRettangoloPerNome()
        {
            Console.Clear();
            string nome;
            var listarett = repoRettangoli.GetAll();
            Console.WriteLine("Inserisci il nome del rettangolo da cercare ");
            nome = Console.ReadLine();
            foreach (var r in listarett)
            {
                if (r.Nome == nome)
                {
                    r.Disegna();
                    return;
                }
            }
            Console.WriteLine("Rettangolo non trovato");
        }
        /// <summary>
        /// Consente di aggiungere un rettangolo nella repository
        /// </summary>
        private static void AggiungiRettangolo()
        {
            string nome = null;
            double b, h;
            //chiedo le informazioni necessarie del rettangolo
            Console.WriteLine("Inserisci il nome del rettangolo che vuoi inserire ");
            nome = Console.ReadLine();
            while (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Valore non consentito, riprova");
                nome = Console.ReadLine();
            }
            //finché non inserisce un valore valido richiedo la base
            Console.WriteLine("Inserisci la base del Rettangolo ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Valore non consentito, riprova");
            }

            //stessa cosa per la base
            Console.WriteLine("Inserisci l'altezza del Rettangolo ");
            while (!double.TryParse(Console.ReadLine(), out h))
            {
                Console.WriteLine("Valore non consentito, riprova");
            }

            if (repoRettangoli.Aggiungi(new Rettangolo(nome, h, b)))
            {
                Console.WriteLine("Rettangolo aggiunto correttamente!");
            }
            else
            {
                Console.WriteLine("Errore nell'inserimento del rettangolo");
            }
            Console.Clear();
        }
        /// <summary>
        /// Consente di aggiungere un cerchio alla repository
        /// </summary>
        private static void AggiungiCerchio()
        {
            string nome = null;
            double r;
            int x, y;
            //chiedo le informazioni necessarie del cerchio
            Console.WriteLine("Inserisci il nome del Cerchio che vuoi inserire ");
            nome = Console.ReadLine();
            while (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Valore non consentito, riprova");
                nome = Console.ReadLine();
            }
            //finché non inserisce un valore valido richiedo il raggio
            Console.WriteLine("Inserisci il raggio del Cerchio ");
            while (!double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Valore non consentito, riprova");
            }

            //stessa cosa per la x
            Console.WriteLine("Inserisci la x del centro del cerchio");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Valore non consentito, riprova");
            }
            //stessa cosa per la y
            Console.WriteLine("Inserisci la y del centro del cerchio");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Valore non consentito, riprova");
            }
            //controllo se l'aggiunta è andata a buon fine
            if (repoCerchi.Aggiungi(new Cerchio(nome, x, y, r)))
            {
                //messaggio positivo
                Console.WriteLine("Cerchio aggiunto correttamente!");
            }
            else
            {
                //messaggio negativo
                Console.WriteLine("Errore nell'inserimento del cerchio");
            }
            Console.Clear();
        }
        /// <summary>
        /// Implementazione di un menu a console
        /// </summary>
        /// <returns>il numero corrispondente alla scelta</returns>
        private static int Menu()
        {
            int scelta;
            Console.WriteLine("----------------------MENU----------------------");
            Console.WriteLine("\n1. Visualizza tutti i Rettangoli");
            Console.WriteLine("\n2. Aggiungi un Rettangolo");
            Console.WriteLine("\n3. Cerca un Rettangolo per nome");
            Console.WriteLine("\n4. Visualizza tutti i Cerchi");
            Console.WriteLine("\n5. Aggiungi un Cerchio");
            Console.WriteLine("\n6. Cerca i Cerchio con un determinato raggio");
            Console.WriteLine("\n0. Esci");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("\nInserisci la tua scelta");
            while (!int.TryParse(Console.ReadLine(), out scelta))
            {
                Console.WriteLine("\nRiprova, devi inserire un numero valido");
            }
            return scelta;
        }
        #endregion
    }
}
