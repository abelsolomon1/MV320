using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Jalousiensteuerung
    {
        //Methoden
        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten, IZimmer zimmer)
        {
            
            if (wetterdaten.Aussentemperatur > zimmer.TemperaturVorgabe && !zimmer.PersonenImZimmer)
            {
                Console.WriteLine("Jalousie wird heruntergefahren.");
                
            }
            else
            {
                Console.WriteLine("Jalousie bleibt in Ruheposition.");
               
            }
        }
    }
}
