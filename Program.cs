using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_di_Salsicce_e_Birre
{
    internal class Program
    {
        /*
        Gara di salsicce e birre:
        - regole:
            - 2 giocatori simulati
            - randomizzare un punteggio arbitrario di punti "panza"
            per i due giocatori
            - ogni giocatore deve ad ogni turno tentare di mangiare
            una salsiccia o bere una birra
            - mangiare una salsiccia richiede uno "panza" di 3, però
            sottrae anche 2 punti all'avversario
            - bere una birra richiede uno "panza" di 2
            - ogni volta che si sceglie se mangiare o bere, randomizzare
            un numero che indica se l'azione è andata a buon fine o meno
                - se non va a buon fine, si subisce una penalità di 2 punti
                per la birra, 3 punti per la salsiccia
            - si vince se:
                - alla fine dei turni, si è conservato il maggior 
                numero di punti "panza"
                - l'avversario scende a 0 punti "panza"
        *
        */
        static void Main(string[] args)
        {
            Partita partita = new Partita();

            Console.ReadKey();
        }


    }
}
