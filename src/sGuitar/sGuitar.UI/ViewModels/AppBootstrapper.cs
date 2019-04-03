using ReactiveUI;
using sGuitar.UI.Views;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace sGuitar.UI.ViewModels
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public AppBootstrapper(RoutingState testRouter = null)
        {
            this.Router = testRouter ?? new RoutingState();
            this.RegisterParts(Locator.CurrentMutable);
                
            this.Router.Navigate.Execute(Locator.Current.GetService<IMainViewModel>()).Subscribe();
        }

        public RoutingState Router { get; }

        private void RegisterParts(IMutableDependencyResolver dependencyResolver)
        {
            Locator.CurrentMutable.InitializeSplat();
            Locator.CurrentMutable.InitializeReactiveUI();

            dependencyResolver.RegisterConstant<IScreen>(this);
            dependencyResolver.Register<IMainViewModel>(() => new MainViewModel());
            dependencyResolver.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());
        }
    }
}
