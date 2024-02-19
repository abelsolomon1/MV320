using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Heizungsventil
    {
        private bool heizungsventilOffen { get; set; }

        //Methoden      
        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten, IZimmer zimmer)
        {
            
            if (wetterdaten.Aussentemperatur < zimmer.TemperaturVorgabe)
            {
                heizungsventilOffen = true;
                Console.WriteLine("Heizungsventil wurde geöffnet.");
                
            }
            else
            {
                heizungsventilOffen = false;
                Console.WriteLine("Heizungsventil wurde geschlossen.");
                
            }
        }
    }
}