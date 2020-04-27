using System;
using System.Reactive;
using ReactiveUI;

namespace Pradana.ReactiveUI.Commons
{
    public static class Interactions
    {
        public static Interaction<Unit, Unit> LoadingStarted { get; } = new Interaction<Unit, Unit>();
        public static Interaction<Unit, Unit> LoadingFinished { get; } = new Interaction<Unit, Unit>();
        public static Interaction<Exception, Unit> LoadingError { get; } = new Interaction<Exception, Unit>();
    }
}