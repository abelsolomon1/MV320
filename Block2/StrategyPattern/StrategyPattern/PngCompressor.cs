namespace StrategyPattern {
    internal class PngCompressor : ICompressor {
        public void Compress(string fileName) {
            Console.WriteLine($"Compressing {fileName} using Png...");
        }
    }
}
