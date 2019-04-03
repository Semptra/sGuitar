using ReactiveUI;

namespace sGuitar.UI.ViewModels
{
    public interface IMainViewModel : IReactiveObject, IRoutableViewModel
    {

    }

    public class MainViewModel : ReactiveObject, IMainViewModel
    {
        public string UrlPathSegment => string.Empty;

        public IScreen HostScreen { get; }
    }
}
