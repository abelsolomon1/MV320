namespace Decorator {
    internal class Heating : WeatherDecorator {
        public Heating(IProcessWeather wetterProcessor) : base(wetterProcessor) { }
        public override void ProcessWeather() {
            base.ProcessWeather();
            Console.WriteLine("Heating.ProcessWeather()");
        }
    }
}