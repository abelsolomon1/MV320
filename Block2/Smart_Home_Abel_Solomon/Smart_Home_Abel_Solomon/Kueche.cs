using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Kueche : Zimmer
    {
        public KochherdStatus KochherdStatus { get; set; }

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            // Logik zur Verarbeitung der Wetterdaten in der Küche
            if (KochherdStatus == KochherdStatus.Ein)
            {
                Console.WriteLine("Überprüfung der Temperatur des Kochherdes und gegebenenfalls Anpassung");
            }
        }


    }
}
