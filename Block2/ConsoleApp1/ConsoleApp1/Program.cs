using System;
using System.Collections.Generic;

namespace Smart_Home_Abel_Solomon
{
    internal class BadWC : ZimmerDecorator
    {
        public double Feuchtigkeit { get; set; }

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            Feuchtigkeit = wetterdaten.Regen ? 80 : 40; // Setze die Feuchtigkeit basierend auf Regen
        }
    }

    internal class Heizungsventil : ZimmerDecorator
    {
        private bool heizungsventilOffen;

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            if (TemperaturVorgabe > wetterdaten.Aussentemperatur)
                heizungsventilOffen = true;
            else
                heizungsventilOffen = false;
        }
    }

    internal class Jalousiensteuerung : ZimmerDecorator
    {
        private bool jalousieRunter;

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            if (PersonenImZimmer == false && wetterdaten.Aussentemperatur > TemperaturVorgabe)
                jalousieRunter = true;
            else
                jalousieRunter = false;
        }
    }

    internal class KochherdStatus
    {
        public enum Status
        {
            Aus,
            Ein,
            AusAberNochWarm
        }
    }

    internal class Kueche
    {
        public KochherdStatus.Status KochherdStatus { get; set; }
    }

    internal class Markiesensteuerung
    {
        private bool markiseAusgefahren;

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            if (TemperaturVorgabe < wetterdaten.Aussentemperatur && wetterdaten.Windgeschwindigkeit <= 30)
                markiseAusgefahren = true;
            else
                markiseAusgefahren = false;
        }
    }

    internal class Schlafzimmer : ZimmerDecorator
    {
        public DateTime Weckzeit { get; set; }
    }

    internal class Wohnzimmer : ZimmerDecorator
    {
        public RgbColor Ambientebeleuchtung { get; set; }
    }

    internal class Wintergarten : ZimmerDecorator
    {
        public double Sonneneinstrahlung { get; set; }
    }

    internal class Wohnung
    {
        private List<ZimmerDecorator> zimmerListe = new List<ZimmerDecorator>();

        public void GeneriereWetterdaten(Wettersensor sensor)
        {
            Wetterdaten wetterdaten = sensor.GetWetterdaten();
            // Verarbeite Wetterdaten für jedes Zimmer
            foreach (ZimmerDecorator zimmer in zimmerListe)
            {
                zimmer.VerarbeiteWetterdaten(wetterdaten);
            }
        }

        public void SetPersonenImZimmer(string zimmerName, bool personenImZimmer)
        {
            foreach (ZimmerDecorator zimmer in zimmerListe)
            {
                if (zimmer.Name == zimmerName)
                {
                    zimmer.PersonenImZimmer = personenImZimmer;
                    break;
                }
            }
        }

        public void SetTemperaturvorgabe(string zimmerName, double temperatur)
        {
            foreach (ZimmerDecorator zimmer in zimmerListe)
            {
                if (zimmer.Name == zimmerName)
                {
                    zimmer.TemperaturVorgabe = temperatur;
                    break;
                }
            }
        }
    }

    internal class RgbColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
    }

    internal class Wetterdaten
    {
        public double Aussentemperatur { get; set; }
        public bool Regen { get; set; }
        public double Windgeschwindigkeit { get; set; }
    }

    internal class Wettersensor
    {
        private Random zufaellig = new Random();

        //Methode
        public Wetterdaten GetWetterdaten()
        {
            return new Wetterdaten
            {
                Aussentemperatur = ZufaelligeTemperatur(),
                Regen = ZufaelligerBoolean(),
                Windgeschwindigkeit = ZufaelligeWindgeschwindigkeit()
            };
        }

        private double ZufaelligeTemperatur()
        {
            double temperatur = zufaellig.Next(-10, 40); // Generiere eine zufällige Temperatur zwischen -10 und 40 Grad Celsius
            return temperatur;
        }

        private bool ZufaelligerBoolean()
        {
            return zufaellig.Next(0, 2) == 1; // Generiere zufällig true oder false
        }

        private double ZufaelligeWindgeschwindigkeit()
        {
            double windgeschwindigkeit = zufaellig.Next(0, 60); // Generiere eine zufällige Windgeschwindigkeit zwischen 0 und 60 km/h
            return windgeschwindigkeit;
        }
    }

    internal abstract class ZimmerDecorator : IZimmer
    {
        protected IZimmer zimmer;

        public string Name { get; set; }
        public bool PersonenImZimmer { get; set; }
        public double TemperaturVorgabe { get; set; }

        public abstract void VerarbeiteWetterdaten(Wetterdaten wetterdaten);
    }

    internal interface IZimmer
    {
        string Name { get; set; }
        bool PersonenImZimmer { get; set; }
        double TemperaturVorgabe { get; set; }

        void VerarbeiteWetterdaten(Wetterdaten wetterdaten);
    }
}
