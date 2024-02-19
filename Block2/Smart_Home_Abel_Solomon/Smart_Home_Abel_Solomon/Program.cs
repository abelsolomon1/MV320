namespace Smart_Home_Abel_Solomon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wohnung wohnung = new Wohnung();

            // Generiere Wetterdaten und verteile sie auf die Zimmer
            wohnung.GeneriereWetterdaten();

            // Setze die Anwesenheit von Personen in den Zimmern
            wohnung.SetPersonenImZimmer();

            // Setze die Temperaturvorgabe für die Zimmer
            double temperatur = 20.0; // Beispielwert
            wohnung.SetTemperaturvorgabe(temperatur);
        }
    }
}