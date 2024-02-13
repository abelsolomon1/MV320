namespace Decorator {
    internal abstract class WeatherDecorator : IProcessWeather {
        private IProcessWeather wetterProcessor;
        public WeatherDecorator(IProcessWeather wetterProcessor) {
            this.wetterProcessor = wetterProcessor;
        }
        public virtual void ProcessWeather() {
            wetterProcessor.ProcessWeather();
        }
    }
}
