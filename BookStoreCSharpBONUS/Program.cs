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

