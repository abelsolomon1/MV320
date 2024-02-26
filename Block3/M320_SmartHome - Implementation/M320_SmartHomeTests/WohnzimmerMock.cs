using M320_SmartHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_SmartHomeTests
{

    public class WohnzimmerMock : Wohnzimmer
    {
        public bool HeizungsventilOffen { get; private set; }

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            base.VerarbeiteWetterdaten(wetterdaten);
            if (wetterdaten.Aussentemperatur < TemperaturVorgabe)
            {
                HeizungsventilOffen = true;
            }
            else
            {
                HeizungsventilOffen = false;
            }
        }
    }
}
