using M320_SmartHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_SmartHomeTests
{
    public class SchlafzimmerMock : Schlafzimmer
    {
        public bool JalousieRuntergefahren { get; private set; }

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            base.VerarbeiteWetterdaten(wetterdaten);
            if (wetterdaten.Aussentemperatur > TemperaturVorgabe && !PersonenImZimmer)
            {
                JalousieRuntergefahren = true;
            }
            else
            {
                JalousieRuntergefahren = false;
            }
        }
    }
}
