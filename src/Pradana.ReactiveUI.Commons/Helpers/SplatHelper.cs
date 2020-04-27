using ReactiveUI;
using Splat;

namespace Pradana.ReactiveUI.Commons.Helpers
{
    public static class SplatHelper
    {
        public static void Register()
        {
#if DEBUG
            Locator.CurrentMutable.RegisterConstant(new DebugLogger(), typeof(ILogger));
            RxApp.DefaultExceptionHandler = new NavigationExceptionHandler();

#else
            Locator.CurrentMutable.RegisterConstant(new AppCenterLogger(), typeof(ILogger));
            ModeDetector.OverrideModeDetector(new SplatModeDetector());

#endif
        }
    }
}