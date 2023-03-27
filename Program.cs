﻿
using GestoreEventi;

//Console.WriteLine("Inserisci il nome dell'evento:");
//string? nomeEvento = Console.ReadLine();

//Console.WriteLine("Inserisci la data dell'evento:");
//DateTime dataEvento = Convert.ToDateTime(Console.ReadLine());

//Console.WriteLine("Inserisci la capacità dell'evento:");
//int capacita = Convert.ToInt32(Console.ReadLine());

var evento = new Evento(/*nomeEvento, dataEvento, capacita*/ "Prova", Convert.ToDateTime("10/12/2024"), 120);

Console.WriteLine(evento);

Console.WriteLine("/----------------------------/");

Console.WriteLine("Quanti posti desideri prenotare?");
int postiPrenotati = Convert.ToInt32(Console.ReadLine());
evento.PrenotaPosti(postiPrenotati);

Console.WriteLine($"Hai prenotato {evento.getPostiPrenotati()} posti!");
Console.WriteLine($"Rimangono {/*capacita*/120 - postiPrenotati} posti per questo evento!");

Console.WriteLine("/----------------------------/");

while (true)
{
    Console.WriteLine("Vuoi disdire dei posti? (s/n)");
    var sceltaUtente = Console.ReadLine();

    if(postiPrenotati == 0)
    {
        Console.WriteLine("Non hai posti prenotati!");
        break;

    }
    else if (sceltaUtente == "n")
    {
        Console.WriteLine("Va bene, ti aspettiamo all'evento!");
        break;

    }
    else if(sceltaUtente == "s")
    {
        Console.WriteLine("Quanti posti vuoi disdire?");
        var numeroDisdetta = Convert.ToInt32(Console.ReadLine());
        evento.DisdiciPosti(numeroDisdetta);
        Console.WriteLine($"I tuoi posti rimasti sono: {evento.getPostiPrenotati()}");
        Console.WriteLine($"Rimangono {evento.getCapienza() - evento.getPostiPrenotati()} per questo evento!");
    }
}