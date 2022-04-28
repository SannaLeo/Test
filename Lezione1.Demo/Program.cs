// See https://aka.ms/new-console-template for more information
using Lezione1.Demo;

Console.WriteLine("Hello, World!");

int a;//dichiarazione
a = 3;//assegnazione
int b = 1;//inizializzazione
double c = a + b;

c = 3.45;
float d = 5.6f;
double w = c + d;
bool e = false;// o true
e = !e;
int i=1;

//si può aggiungere il valore null alle variabili non-nullable, aggiungendo un ? vicino al tipo
int? n = null;
if (n == null) {; }

//dalla versione 6 non funziona più, aveva default 0 -> Console.WriteLine($"Valore default di i e': {i}");
Console.WriteLine($"Valore default di i e': {i}");//variabili nelle graffe
Console.WriteLine("Valore di i e': " + i);//concatenazione
Console.WriteLine("Valore di i e' {0} - a invece vale: {1}", i, a);//posizionale



DateTime data = new DateTime(2022, 4, 26);//oggetto DateTime
DateTime dataOggi = DateTime.Now;//oggetto DateTime con data di oggi
Console.WriteLine(data);//data più ora, ma l'ora non è iniziallizzata
Console.WriteLine(dataOggi);//data più ora, ma l'ora non è iniziallizzata
Console.WriteLine(data.ToShortDateString());//visualizza solo la data


//enum 
GiorniDellaSettimana g = GiorniDellaSettimana.Lunedi;
Console.WriteLine(g);
int primo = 22;
int secondo = primo;//copia del valore
Console.WriteLine(primo);
Console.WriteLine(secondo);
Console.WriteLine("------------------");

secondo = 10;
Console.WriteLine(primo);
Console.WriteLine(secondo);
Console.WriteLine("------------------");
/*
Person persona = new Person();
persona.FirstName = "Mario";
persona.LastName = "Rossi";
persona.BirthDay = new DateTime(1999, 2, 22);
Console.WriteLine($"nome: {persona.FirstName}; cognome: {persona.LastName}; data di nascita: {persona.BirthDay.ToShortDateString()}.");
*/

//stampa
//Person persona2 = persona;
//Console.WriteLine($"nome: {persona.FirstName}; cognome: {persona.LastName}; data di nascita: {persona.BirthDay.ToShortDateString()}.");

//cambio attributi della seconda
//persona2.FirstName = "Giuseppe";

//stampa
//Console.WriteLine($"nome: {persona.FirstName}; cognome: {persona.LastName}; data di nascita: {persona.BirthDay.ToShortDateString()}.");
//Console.Write($"nome: {persona2.FirstName}; cognome: {persona2.LastName}; data di nascita: {persona2.BirthDay.ToShortDateString()}.");
//cambio anche nella prima


Console.WriteLine("\n");

//la stampa di default non è il massimo, facendo l'override nella classe del metodo to string ovviamo al problema, chiamare il ToString è
//opzionale nella writeline.
/*
Console.WriteLine(persona); 
Console.WriteLine("\n"); 
Console.WriteLine(persona.ToString());
Person p4 = new Person() { FirstName = "Nome1", BirthDay = new DateTime(1999, 1, 1), LastName = "Cognome1"};
Console.WriteLine(p4);
Console.WriteLine(p4.CodiceFiscale);
*/

Console.WriteLine("------------------");
//Console.WriteLine(p4.GetInfoPersona());


Person impiegato1 = new Employee();

impiegato1.FirstName = "Giuseppe";
impiegato1.LastName = "Verdi";
Console.WriteLine(impiegato1);
impiegato1.Saluta();

Person studente = new Studente() { FirstName= "Maria", LastName= "Bianchi", BirthDay= new DateTime(1999, 10, 1), Matricola=1234};
studente.Saluta();


List<Person> persone = new List<Person>();

persone.Add(studente);
persone.Add(impiegato1);


Console.WriteLine("------------------");
foreach (Person p in persone)
{
    p.Saluta();
    p.ChiamaTizio();
    Console.WriteLine(p);
}

enum GiorniDellaSettimana
{
    Lunedi, 
    Martedi,
    Mercoledi,
    Giovedi=4,
    Venerdi,
    Sabato,
    Domenica
}
//di default parte da 0
//si può anche dichiarare il primo se i numeri sono in ordine
//oppure dichiararli manualmente, dall'assegnazione in poi continuerà in ordine, es. Venerdi = 5
