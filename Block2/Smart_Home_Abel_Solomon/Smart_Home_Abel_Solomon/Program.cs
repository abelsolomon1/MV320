namespace Smart_Home_Abel_Solomon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wohnung wohnung = new Wohnung();

             
            wohnung.GeneriereWetterdaten();

            
            wohnung.SetPersonenImZimmer();

            
            double temperatur = 20.0; // Vorübergehender Beispielwert für die temperatur

            wohnung.SetTemperaturvorgabe(temperatur);
        }
    }
}