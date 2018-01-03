using Prism.Navigation;

namespace XamlDemo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _cartIcon;
        public string CartIcon
        {
            get { return _cartIcon; }
            set { SetProperty(ref _cartIcon, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            CartIcon = "&#xf07a;";
        }
    }
}