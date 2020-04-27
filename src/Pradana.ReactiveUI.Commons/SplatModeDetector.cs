using Splat;

namespace Pradana.ReactiveUI.Commons
{
    public class SplatModeDetector : IModeDetector
    {
        public bool? InDesignMode() => false;

        public bool? InUnitTestRunner() => false;

    }
}