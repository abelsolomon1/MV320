using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Wettersensor
    {
        private double aktuelleTemperatur;
        private Random zufaellig;
        private const int MAX_TEMP = 40;
        private const int MIN_TEMP = -15;

        //Methode
        public Wetterdaten GetWetterdaten()
        {
            Random zufaellig = new Random(); // Initialisiere das Zufallsobjekt
                                             
            Wetterdaten wetterdaten = new Wetterdaten();
            
            // Generierung von Wetterdaten
            wetterdaten.Aussentemperatur = zufaellig.Next(MIN_TEMP, MAX_TEMP);
            wetterdaten.Regen = (zufaellig.Next(0, 2) == 1) ? true : false;
            wetterdaten.Windgeschwindigkeit = zufaellig.Next(0, 60); 

            return wetterdaten;
        }
    }
}
