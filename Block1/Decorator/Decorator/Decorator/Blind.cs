namespace Decorator {
    internal class Blind : WeatherDecorator {
        public Blind(IProcessWeather wetterProcessor) : base(wetterProcessor) { }

        public override void ProcessWeather() {
            base.ProcessWeather();
            Console.WriteLine("Blind.ProcessWeather()");
        }
    }
}
