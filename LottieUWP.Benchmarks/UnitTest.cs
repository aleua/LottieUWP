using System.Diagnostics;
using Windows.Graphics.Display;
using Xunit;

namespace LottieUWP.Benchmarks
{
    public class UnitTest1
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();

        [Fact]
        public void PerformanceTest()
        {
            _stopwatch.Restart();
            for (int i = 0; i < 50; i++)
            {
                var result = LottieComposition.Factory.FromFileSync("Assets/lottiefiles.com - Nudge.json");
            }
            _stopwatch.Stop();
            Debug.WriteLine(_stopwatch.ElapsedMilliseconds);
        }
    }
}
