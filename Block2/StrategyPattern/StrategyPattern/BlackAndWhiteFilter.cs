namespace StrategyPattern {
    internal class BlackAndWhiteFilter : IFilter {
        public void Apply(string fileName) {
            Console.WriteLine($"Applying black and white filter on {fileName}...");
        }
    }
}
