using ReactiveUI;
using Splat;

namespace sGuitar.UI.ViewModels
{
    public class MainViewModel : ReactiveObject, IMainViewModel
    {
        public MainViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
        }

        public string UrlPathSegment => "MainView";

        public IScreen HostScreen { get; }

    }
}
