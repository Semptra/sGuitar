using ReactiveUI;
using Splat;
using sGuitar.UI.Views;
using System;

namespace sGuitar.UI.ViewModels
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public AppBootstrapper()
        {
            this.RegisterParts(Locator.CurrentMutable);

            Router = new RoutingState();

            Router
                .NavigateAndReset
                .Execute(Locator.Current.GetService<IMainViewModel>())
                .Subscribe();
        }

        private void RegisterParts(IMutableDependencyResolver dependencyResolver)
        {
            Locator.CurrentMutable.InitializeSplat();
            Locator.CurrentMutable.InitializeReactiveUI();

            dependencyResolver.Register<IMainViewModel>(() => new MainViewModel());

            dependencyResolver.Register<IViewFor<AppBootstrapper>>(() => new StartupWindow());
            dependencyResolver.Register<IViewFor<IMainViewModel>>(() => new MainView());
        }

        public RoutingState Router { get; }
    }
}
