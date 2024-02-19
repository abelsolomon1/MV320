using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class BadWC : Zimmer
    {
        public double Feuchtigkeit { get; set; }

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            Console.WriteLine($"Feuchtigkeit im Bad/WC: {Feuchtigkeit}%");
        }
    }
}