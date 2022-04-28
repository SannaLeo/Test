

Console.WriteLine("Demo Lettura Scrittura File");
string path = @"D:\Lavoro\lezioni\codice\Lezione1\Lezione1.ScritturaFile\FileProva.txt";
//Scrittura con chiusura manuale
StreamWriter sw = new StreamWriter(path);
sw.WriteLine("Ciao a tutti");
sw.Close();


//Scrittura con chiusura automatica
using(StreamWriter sw2 = new StreamWriter(path))
{
    sw2.WriteLine("Buongiorno");
}


//scrittura mantendendo il contunuto precedente
using (StreamWriter sw2 = new StreamWriter(path,true))
{
    sw2.WriteLine("Questo e' stato appeso al file");
}



//Lettura di tutto il file
using (StreamReader sw2 = new StreamReader(path))
{
    string contentutoFile = sw2.ReadToEnd();
}


//Lettura di una riga
using (StreamReader sw2 = new StreamReader(path))
{
    string contentutoFile = sw2.ReadLine();
}


//Lettura e divisione del file, ogni riga è messa in una cella dell'array
using (StreamReader sw2 = new StreamReader(path))
{
    string contentutoFile = sw2.ReadToEnd();
    var arrayrighe = contentutoFile.Split("\r\n");
    Console.WriteLine(arrayrighe);
}



