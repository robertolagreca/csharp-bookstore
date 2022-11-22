// See https://aka.ms/new-console-template for more information
//In questo esercizio vogliamo inserire in maniera “hardcoded”
//(ossia scritte nel codice senza dover chiedere all’utente nessun input)
//tutte le informazioni che troviamo su Amazon di un libro (per esempio "Clean Code")
//per poi stamparne una piccola sintesi fatta bene.

//Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
//Titolo, Autore, ISBN, Numero pagine, Peso del libro, Larghezza, Altezza e Profondità del libro, Valutazione media,
//Numero di recensioni se è disponibile in versione Kindle, se la copertina flessibile è disponibile

string title, author, codeISBN, availabilityKindle, bookCover;
int pages, numbersReview;
float bookWeight, bookWidth, bookHeight, bookDepth, userMeanScore;

title = "Il deserto dei tartari";
author = "Dino Buzzati";
codeISBN = "978-8804735106";

pages = 300;
bookWeight = 250f;
bookWidth = 14f;
bookHeight = 21.6f;
bookDepth = 2.3f;

userMeanScore = 4.5f;
numbersReview = 953;

availabilityKindle = "Si";
bookCover = "Si";

Console.WriteLine();

Console.WriteLine("------------- IL LIBRO DI OGGI: " + title + " di " + author + "-------------");

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


