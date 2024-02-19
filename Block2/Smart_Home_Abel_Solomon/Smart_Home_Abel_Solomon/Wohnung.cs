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

            // Beispiel: Verteilung der Wetterdaten auf die Zimmer
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
            // Logik zur Festlegung der Anwesenheit von Personen in den Zimmern
            // Beispiel: Personen sind im Wohnzimmer anwesend
            Wohnzimmer wohnzimmer = new Wohnzimmer();
            wohnzimmer.PersonenImZimmer = true;
        }

        public void SetTemperaturvorgabe(double temperatur)
        {
            // Logik zur Festlegung der Temperaturvorgabe in den Zimmern
            // Beispiel: Temperaturvorgabe für alle Zimmer auf 20 Grad setzen
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
