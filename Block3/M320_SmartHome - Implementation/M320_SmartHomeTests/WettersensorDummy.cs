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
        public WettersensorDummy(bool regen) {
            daten.Regen = regen;
        }
        private Wetterdaten daten;
        public Wetterdaten GetWetterdaten()
        {
            return daten;
        }
    }
}
