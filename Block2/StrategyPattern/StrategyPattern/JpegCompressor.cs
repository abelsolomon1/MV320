﻿namespace StrategyPattern {
    internal class JpegCompressor : ICompressor {
        public void Compress(string fileName) {
            Console.WriteLine($"Compressing {fileName} using JPEG...");
        }
    }
}
