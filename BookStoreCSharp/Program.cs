// Inserire tutte le informazioni che troviamo su Amazon di un libro
// per poi stamparne una piccola sintesi fatta bene.

// Dichiaro le variabili

using System.Xml.Linq;

string titolo = "Clean Code";
string autore = "Robert C. Martin";
long isbn = 9780132350884;
int numeroPagine = 431;
int pesoLibro = 800;
double larghezza = 17.78;
double altezza = 2.79;
double profondita = 23.37;
double valutazione = 4.7;
int numeroRecensioni = 4571;
string versioneKindle = "SI";
string copertinaFlessibile = "SI";

// Stampo le variabili in console

Console.WriteLine("--------------- IL LIBRO DI OGGI: " + titolo + "di " + autore + "----------------");
Console.WriteLine("INFORMAZIONI GENERICHE:");
Console.WriteLine("");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibro + " gr");
Console.WriteLine("Dimensioni del libro: " + larghezza + " cm X " + altezza + " cm X " + profondita + " cm");
Console.WriteLine("");
Console.WriteLine("INFORMAZIONI AMAZON:");
Console.WriteLine("Numero di recensioni: " + numeroRecensioni + " recensioni");
Console.WriteLine("Valutazione media: " + valutazione + " stelle su 5");
Console.WriteLine("Kindle disponibile: " + versioneKindle);
Console.WriteLine("Copertina flessibile disponibile: " + copertinaFlessibile);
