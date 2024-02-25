using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    abstract class ZimmerDecorator : IZimmer
    {
        protected IZimmer zimmer { get; set; }

        public string Name { get; set; }

        public bool PersonenImZimmer { get; set; }

        public double TemperaturVorgabe { get; set; }


        //Methoden
        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            
        }

    }
}
