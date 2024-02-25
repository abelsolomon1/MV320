using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Wohnung
    {
        //Methoden
        public void GeneriereWetterdaten()
        {
            Wettersensor sensor = new Wettersensor();
            Wetterdaten wetterdaten = sensor.GetWetterdaten();

            //Verteilung der Wetterdaten auf die Zimmer
            Kueche kueche = new Kueche();
            kueche.VerarbeiteWetterdaten(wetterdaten);

            BadWC badWC = new BadWC();
            badWC.VerarbeiteWetterdaten(wetterdaten);

            Wohnzimmer wohnzimmer = new Wohnzimmer();
            wohnzimmer.VerarbeiteWetterdaten(wetterdaten);

            Schlafzimmer schlafzimmer = new Schlafzimmer();
            schlafzimmer.VerarbeiteWetterdaten(wetterdaten);

            Wintergarten wintergarten = new Wintergarten();
            wintergarten.VerarbeiteWetterdaten(wetterdaten);
        }

        public void SetPersonenImZimmer()
        {
            
            Wohnzimmer wohnzimmer = new Wohnzimmer();
            wohnzimmer.PersonenImZimmer = true;
        }

        public void SetTemperaturvorgabe(double temperatur)
        {
            
            Kueche kueche = new Kueche();
            kueche.TemperaturVorgabe = temperatur;

            BadWC badWC = new BadWC();
            badWC.TemperaturVorgabe = temperatur;

            Wohnzimmer wohnzimmer = new Wohnzimmer();
            wohnzimmer.TemperaturVorgabe = temperatur;

            Schlafzimmer schlafzimmer = new Schlafzimmer();
            schlafzimmer.TemperaturVorgabe = temperatur;

            Wintergarten wintergarten = new Wintergarten();
            wintergarten.TemperaturVorgabe = temperatur;
        }
    }
}
