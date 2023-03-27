using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

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

        public List<Evento> getEventi()
        {
            return eventi;
        }

        public List<Evento> TrovaEvento(DateTime data)
        {
            var filteredEvents = new List<Evento>();

            foreach (Evento evento in eventi)
            {
                if (evento.getData() == data)
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


        public static string StampaListaEventi(List<Evento> listaEventi)
        {
            string result = "";

            foreach(Evento evento in listaEventi)
            {
                result += $"{evento.getTitolo()}" + $"{evento.getData()}" + NewLine;
            }

            return result;
        }

        public int NumeroEventi()
        {
            return eventi.Count;
        }

        public void SvuotaEventi()
        {
            eventi.Clear();
        }

        public string StampaEventi(List<Evento> listaEventi)
        {
            return StampaListaEventi(listaEventi);
        }
    }
}
