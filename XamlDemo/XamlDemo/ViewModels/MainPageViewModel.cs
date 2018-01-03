using Prism.Navigation;
using XamlDemo.Include;

namespace XamlDemo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Star { get; set; }

        public string BtnHomeTitle { get; set; }

        public string BtnCallTitle { get; set; }

        public string Signout { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            Star = FontAwesome.FAStar;
            BtnHomeTitle = FontAwesome.FAHome;
            BtnCallTitle = string.Concat(FontAwesome.FAPhone, " Call");
            Signout = FontAwesome.FASignOut;
        }
    }
}