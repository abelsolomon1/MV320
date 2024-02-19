using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Markiesensteuerung
    {
        //Methoden
        public void VerarbeiteWetterdaten(Wetterdaten Wetterdaten, IZimmer zimmer)
        {
            
            if (Wetterdaten.Aussentemperatur > zimmer.TemperaturVorgabe && Wetterdaten.Windgeschwindigkeit < 30)
            {
                Console.WriteLine("Markise wird ausgefahren.");
               
            }
            else
            {
                Console.WriteLine("Markise bleibt in Ruheposition.");
               
            }
        }
    }
}
