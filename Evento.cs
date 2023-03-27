using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        string titolo;
        DateTime data;
        int capienza;
        int postiPrenotati;

        public Evento(string titolo, DateTime data, int capienza)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienza = capienza;
            postiPrenotati = 0;
        }

        public string getTitolo()
        {
            return titolo;
        }
        public string setTitolo(string _titolo)
        {
            try
            {
                if (_titolo != null && _titolo != "")
                {
                    return this.titolo = _titolo;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Titolo non valido! E stato impostato un titolo generico!");
                return "Evento generico";
            }
        }

        public DateTime getData()
        {
            return data;
        }
        public DateTime setData(DateTime _data)
        {

            var currentData = DateTime.Now;

            try
            {
                if (_data > currentData)
                {
                    return this.data = _data;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Data non valida! L'evento è stato impostato per oggi!");
                return currentData;
            }
        }

        public int getCapienza()
        {
            return capienza;
        }
        public int setCapienza(int _capienza)
        {
            try
            {
                if (_capienza > 0)
                {
                    return this.capienza = _capienza;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("La capienza deve essere superiore a 0!");
                return 0;
            }
        }

        public int getPostiPrenotati()
        {
            return postiPrenotati;
        }

        public int PrenotaPosti(int _posti)
        {
            try
            {
                if (data > DateTime.Now && capienza > postiPrenotati)
                {
                    return postiPrenotati += _posti;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Qualcosa è andato storto nella prenotazione!");
                return 0;
            }
        }

        public int DisdiciPosti(int _posti)
        {
            try
            {
                if (data > DateTime.Now && postiPrenotati > _posti)
                {
                    return postiPrenotati -= _posti;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hai provato a disdire più posti di quelli prenotati!");
                return _posti;
            }
        }

        public override string ToString()
        {
            var dateAndTitle = $"Nome evento: {setTitolo(titolo)} - " + $"Capienza evento: {setCapienza(capienza)} - " + "Data evento: " + setData(data).ToString("dd/MM/yyyy");

            return dateAndTitle;
        }
    }
}
