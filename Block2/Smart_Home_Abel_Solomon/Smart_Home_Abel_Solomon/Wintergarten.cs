using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Wintergarten : Zimmer
    {
        public double Sonneneinstrahlung { get; set; }

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            Console.WriteLine($"Sonneneinstrahlung im Wintergarten: {Sonneneinstrahlung} Lux");
        }
    }
}
