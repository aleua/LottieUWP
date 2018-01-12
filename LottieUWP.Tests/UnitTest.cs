using System.Diagnostics;
using Xunit;

namespace LottieUWP.Tests
{
    public class UnitTest1
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();

        [Fact]
        public void PerformanceTest()
        {
            _stopwatch.Restart();
            LottieComposition.Factory.FromFileSync("Assets/lottiefiles.com - Nudge.json");
            _stopwatch.Stop();
            Debug.WriteLine(_stopwatch.ElapsedTicks);
        }
    }
}
