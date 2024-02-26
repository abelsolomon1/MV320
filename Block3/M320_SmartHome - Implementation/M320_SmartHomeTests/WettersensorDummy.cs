using M320_SmartHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_SmartHomeTests
{
    public class WettersensorDummy : IWettersensor
    {
        private Wetterdaten daten;

        public WettersensorDummy(bool regen, double aussentemperatur = 0, double windgeschwindigkeit = 0)
        {
            daten = new Wetterdaten
            {
                Regen = regen,
                Aussentemperatur = aussentemperatur,
                Windgeschwindigkeit = windgeschwindigkeit
            };
        }

        public Wetterdaten GetWetterdaten()
        {
            return daten;
        }
    }
}