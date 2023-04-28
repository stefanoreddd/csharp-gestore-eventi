﻿using GestoreEventi;



Console.Write("Inserisci il nome del tuo programma eventi: ");
string titoloProgramma = Console.ReadLine();
Console.WriteLine("Indica il numero di eventi da inserire: ");
int numeroEventi = int.Parse(Console.ReadLine());

ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloProgramma, numeroEventi);

for (int i = 0; i < numeroEventi; i++)
{
    Console.Write($"Inserisci il nome del {i + 1}° evento: ");
    string nome = Console.ReadLine();

    Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
    DateTime data = DateTime.Parse(Console.ReadLine());

    Console.Write("Inserisci il numero di posti totali: ");
    int posti = int.Parse(Console.ReadLine());

    Console.Write("Quanti posti vuoi prenotare? ");
    int postiUser = int.Parse(Console.ReadLine());

    try
    {
        Evento eventoSingolo = new Evento(nome, data, posti, postiUser);

        List<Evento> listaDiEventi = new List<Evento> { eventoSingolo };

        programmaEventi.AddListaEventi(listaDiEventi);

        Console.WriteLine();
        Console.WriteLine("Posti disponibili: " + posti);
        Console.WriteLine("Posti prenotati: " + postiUser);


        bool userNonVuolEliminarePosti = false;

        while (!userNonVuolEliminarePosti)
        {
            Console.Write("Vuoi disdire dei posti? (si/no) ");
            string rispostaUser = Console.ReadLine().ToLower();

            if (rispostaUser == "si")
            {
                Console.Write("Indica il numero di posti da disdire: ");
                int postiCancellatiUser = int.Parse(Console.ReadLine());
                eventoSingolo.CancellaPrenotazione(postiCancellatiUser);
                userNonVuolEliminarePosti = false;
                Console.WriteLine();
                Console.WriteLine("Posti disponibili: " + eventoSingolo.GetCapienza());
                Console.WriteLine("Posti prenotati: " + eventoSingolo.GetPostiPrenotati());
            }
            else if (rispostaUser == "no")
            {
                Console.WriteLine("Ok, va bene!");
                userNonVuolEliminarePosti = true;
            }
        }


    }
    catch (Exception ex)
    {
        Console.WriteLine("Errore: " + ex.Message);
    }

}








/*
Console.WriteLine();
Console.WriteLine("Posti disponibili: " + posti);
Console.WriteLine("Posti prenotati: " + postiUser);


bool userNonVuolEliminarePosti = false;

while (!userNonVuolEliminarePosti)
{
    Console.Write("Vuoi disdire dei posti? (si/no) ");
    string rispostaUser = Console.ReadLine().ToLower();

    if (rispostaUser == "si")
    {
        Console.Write("Indica il numero di posti da disdire: ");
        int postiCancellatiUser = int.Parse(Console.ReadLine());
        evento1.CancellaPrenotazione(postiCancellatiUser);
        userNonVuolEliminarePosti = false;
        Console.WriteLine();
        Console.WriteLine("Posti disponibili: " + evento1.GetCapienza());
        Console.WriteLine("Posti prenotati: " + evento1.GetPostiPrenotati());
    }
    else if (rispostaUser == "no")
    {
        Console.WriteLine("Ok, va bene!");
        userNonVuolEliminarePosti = true;
    }
}
*/









