using ReactiveUI;
using Splat;

namespace Pradana.ReactiveUI.Commons.Helpers
{
    public static class SplatHelper
    {
        public static void Register(bool isDebugMode)
        {
            if (isDebugMode)
            {
                Locator.CurrentMutable.RegisterConstant(new DebugLogger(), typeof(ILogger));
                RxApp.DefaultExceptionHandler = new NavigationExceptionHandler();
            }
            else
            {
                Locator.CurrentMutable.RegisterConstant(new AppCenterLogger(), typeof(ILogger));
                ModeDetector.OverrideModeDetector(new SplatModeDetector());
            }
        }
    }
}