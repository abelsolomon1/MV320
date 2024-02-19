using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Zimmer : IZimmer
    {
        public string Name { get; set; }
        public bool PersonenImZimmer { get; set; }
        public double TemperaturVorgabe { get; set; }

        public virtual void VerarbeiteWetterdaten(Wetterdaten Wetterdaten) //virtual weil es sonst fehlermeldungen in den anderen Klassen gibt
        {
            
        }
    }
}
