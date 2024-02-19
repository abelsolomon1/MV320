using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Wohnzimmer : Zimmer
    {
        public RgbColor Ambientebeleuchtung { get; set; }


        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            Console.WriteLine("Logik zur Verarbeitung der Wetterdaten im Wohnzimmer");
        }
    }
}