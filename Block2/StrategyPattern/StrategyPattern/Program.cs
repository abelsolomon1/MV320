namespace StrategyPattern {
    internal class Program {
        static void Main(string[] args) {
            ImageStorage imageStorage = new ImageStorage();
            imageStorage.Store("Selfie", new JpegCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("Holiday Picture", new JpegCompressor(), new HighContrastFilter());
            imageStorage.Store("Mountains of Switzerland", new PngCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("Wallpaper", new PngCompressor(), new HighContrastFilter());
        }
    }
}