using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_di_Salsicce_e_Birre
{
    internal class Partita
    {
        public Giocatore giocatore1 = new Giocatore("Giocatore 1");
        public Giocatore giocatore2 = new Giocatore("Giocatore 2");

        public Partita()
        {
            Intro();
            Gioco();
            FinePartita();
        }

        public void Intro()
        {
            Console.WriteLine("Benvenuto alla gara di salsicce e birre!");
            Console.WriteLine("Premi ENTER per iniziare la partita.");
            Console.ReadKey();
        }

        public void Gioco()
        {
            int round = 10;
            bool partita = true;
            Giocatore attivo = giocatore1;
            Giocatore passivo = giocatore2;

            while (round > 0 && partita == true)
            {
                Console.Clear();
                Console.Clear();
                MostraPunteggio();
                Console.WriteLine();
                Console.WriteLine($"È il turno di {attivo.Name}!");
                attivo.MangiaBevi(passivo);
                if (attivo.PuntiPanza <= 0 || passivo.PuntiPanza <= 0)
                {
                    partita = false;
                    break;
                }
                Console.ReadKey();

                // cambio turno
                if (attivo == giocatore1 && passivo == giocatore2)
                {
                    passivo = giocatore1;
                    attivo = giocatore2;
                }
                else if (attivo == giocatore2 && passivo == giocatore1)
                {
                    passivo = giocatore2;
                    attivo = giocatore1;
                }
            }

        }
        public void FinePartita()
        {
            Console.WriteLine("Partita finita!");
            MostraPunteggio();

            if (giocatore1.PuntiPanza > giocatore2.PuntiPanza)
            {
                Console.WriteLine("Ha vinto il giocatore " + giocatore1.Name);
            }
            else if (giocatore1.PuntiPanza == giocatore2.PuntiPanza)
            {
                Console.WriteLine("Pareggio!");
            }
            else
            {
                Console.WriteLine("Ha vinto il giocatore " + giocatore2.Name);
            }
        }

        public void MostraPunteggio()
        {
            Console.WriteLine("Punteggio:");
            Console.WriteLine($"{giocatore1.Name}: {giocatore1.PuntiPanza}");
            Console.WriteLine($"{giocatore2.Name}: {giocatore2.PuntiPanza}");
        }



    }
}
