// See https://aka.ms/new-console-template for more information
//BONUS
//modificare questo programma, creando un nuovo progetto BONUS dove
//può cimentarsi nel rendere le variabili non più “hardcoded” nel
//codice e provare invece a chiedere le informazioni del libro
//direttamente all’utente tramite l’input della console.

string title, author, codeISBN, availabilityKindle, bookCover;
int pages, numbersReview;
float bookWeight, bookWidth, bookHeight, bookDepth, userMeanScore;


Console.WriteLine();
Console.WriteLine("Inserisci le informazioni riguardanti il libro che ti interessa");
Console.WriteLine();

Console.WriteLine("Nome del libro");
title = Console.ReadLine();

Console.WriteLine("Autore del libro");
author = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Informazioni Generiche");
Console.WriteLine();

Console.WriteLine("Inserisci il codice ISBN");
codeISBN = Console.ReadLine();

Console.WriteLine("Il numero delle pagine");
pages = int.Parse(Console.ReadLine());          //NOTA MIA metodo altenativo ToInt32(string);

Console.WriteLine("Peso del libro in grammi");
bookWeight = float.Parse(Console.ReadLine());

Console.WriteLine("Dimensioni del libro:");
Console.WriteLine("Larghezza in cm:");
bookWidth = float.Parse(Console.ReadLine());
Console.WriteLine("Lunghezza in cm:");
bookHeight = float.Parse(Console.ReadLine());
Console.WriteLine("Profondità in cm:");
bookDepth = float.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Informazioni Amazon");
Console.WriteLine();

Console.WriteLine("Numero recensioni");
numbersReview = int.Parse(Console.ReadLine());
Console.WriteLine("Valutazione media");
userMeanScore = float.Parse(Console.ReadLine());
Console.WriteLine("Disponibilità in formato KINDLE");
availabilityKindle = (Console.ReadLine());
Console.WriteLine("Disponibilità copertina flessibile");
bookCover = (Console.ReadLine());


Console.WriteLine();
Console.WriteLine("---------------------------- STAMPA LIBRO -----------------------------------");
Console.WriteLine();

Console.WriteLine("------------- IL LIBRO DI OGGI: " + title + " di " + author + " -------------");

Console.WriteLine();

Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + codeISBN);
Console.WriteLine("Numero delle pagine " + pages + " pagine");
Console.WriteLine("Peso del libro " + bookWeight + " g");
Console.WriteLine("Dimensioni del libro: " + bookWidth + " cm x " + bookHeight + " cm x " + bookDepth + " cm");

Console.WriteLine();

Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + numbersReview);
Console.WriteLine("Valutazione media: " + userMeanScore);
Console.WriteLine("KINDLE disponibile: " + availabilityKindle);
Console.WriteLine("Copertina flessibile disponibile: " + bookCover);