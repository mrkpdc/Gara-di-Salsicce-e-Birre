using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_di_Salsicce_e_Birre
{
    public class Giocatore
    {
        public string Name { get; set; }
        public int PuntiPanza { get; set; } = 0;

        public Giocatore(string name)
        {
            this.Name = name;
            Random rnd = new Random();
            PuntiPanza = rnd.Next(10, 20);
        }
        public void MangiaBevi(Giocatore avversario)
        {
            Console.WriteLine("Vuoi mangiare una salsiccia o bere una birra? (1 = salsiccia, 2 = birra)");
            int scelta = 0;
            bool sceltaValida = false;
            while (sceltaValida == false)
            {
                bool successfulParse = int.TryParse(Console.ReadLine(), out scelta);
                if (successfulParse && scelta >= 1 && scelta <= 2)
                {
                    sceltaValida = true;
                }
                else
                {
                    Console.WriteLine("Scelta non valida, riprova.");
                }
            }

            Random rnd = new Random();
            int dadoAzione = rnd.Next(1, 100);
            if (dadoAzione >= 50)
            {
                if (scelta == 1)
                {
                    Console.WriteLine(this.Name + " ha scelto di mangiare la salsiccia");
                    this.PuntiPanza -= 3;
                    avversario.PuntiPanza -= 2;
                }
                else if (scelta == 2)
                {
                    Console.WriteLine(this.Name + " ha scelto di bere la birra");
                    this.PuntiPanza -= 2;
                }
            }
            else
            {
                Console.WriteLine("Azione non riuscita.");

                if (scelta == 1)
                    this.PuntiPanza -= 3;
                else if (scelta == 2)
                    this.PuntiPanza -= 2;
            }
        }
    }
}
