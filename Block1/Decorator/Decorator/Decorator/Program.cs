namespace Decorator {
    internal class Program {
        static void Main(string[] args) {
            var myRoom = new Room();
            var myRoomWithBlind = new Blind(myRoom);
            var myRoomWithBlindAndHeating = new Heating(myRoomWithBlind);
            myRoomWithBlindAndHeating.ProcessWeather();
        }
    }
}