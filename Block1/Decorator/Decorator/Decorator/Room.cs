namespace Decorator {
    public class Room : IProcessWeather {
        public void ProcessWeather() {
            Console.WriteLine("Room.ProcessWeather()");
        }
    }
}
