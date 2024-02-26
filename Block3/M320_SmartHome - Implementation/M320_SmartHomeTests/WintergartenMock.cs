using M320_SmartHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_SmartHomeTests
{
    public class WintergartenMock : Wintergarten
    {
        public bool MarkiseEingefahren { get; private set; }

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            base.VerarbeiteWetterdaten(wetterdaten);
            if (wetterdaten.Aussentemperatur > TemperaturVorgabe && wetterdaten.Windgeschwindigkeit <= 30)
            {
                MarkiseEingefahren = false;
            }
            else
            {
                MarkiseEingefahren = true;
            }
        }
    }
}
