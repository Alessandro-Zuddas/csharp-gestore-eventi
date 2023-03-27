using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        string titolo;
        List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> TrovaEvento(DateTime data)
        {
            var filteredEvents = new List<Evento>();

            foreach (Evento evento in eventi)
            {
                if(evento.getData() == data)
                {
                    filteredEvents.Add(evento);
                }
                else
                {
                    Console.WriteLine("Nessun evento in programma per questa data!");
                }
            }

            return filteredEvents;
        }
    }
}
