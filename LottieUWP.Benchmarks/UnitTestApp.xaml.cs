using System;
using System.Reflection;
using Windows.ApplicationModel.Activation;
using Windows.Graphics.Display;
using Windows.UI.Core;
using Xunit.Runners.UI;

namespace LottieUWP.Benchmarks
{
    sealed partial class App : RunnerApplication
    {
        protected async override void OnLaunched(LaunchActivatedEventArgs e)
        {
            await CoreWindow.GetForCurrentThread().Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
            {
                try
                {
                    LottieComposition.Factory.FromJsonSync(null);
                }
                catch
                {
                    // ignored
                }
            });
            base.OnLaunched(e);
        }

        protected override void OnInitializeRunner()
        {
            AddTestAssembly(GetType().GetTypeInfo().Assembly);
            InitializeRunner();
        }

        partial void InitializeRunner();
    }
}
