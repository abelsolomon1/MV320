using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Schlafzimmer : Zimmer
    {
        public DateTime Weckzeit { get; set; }

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            Console.WriteLine($"Weckzeit im Schlafzimmer: {Weckzeit}");
        }
    }
}