using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace XamlDemo.ViewModels
{
    public class MasterPageViewModel : ViewModelBase
    {
        private ObservableCollection<NavMenuItem> _menuItems;
        public ObservableCollection<NavMenuItem> MenuItems
        {
            get { return _menuItems; }
            set { SetProperty(ref _menuItems, value); }
        }

        private DelegateCommand<NavMenuItem> delegateCommand;
        public DelegateCommand<NavMenuItem> ItemTappedCommand =>
            delegateCommand ?? (delegateCommand = new DelegateCommand<NavMenuItem>(ExecuteItemTappedCommand));

        private DelegateCommand<string> _navigateCommand;
        public DelegateCommand<string> NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteNavigateCommand));

        private async void ExecuteNavigateCommand(string parameter)
        {
            await NavigationService.NavigateAsync(parameter);
        }

        private void ExecuteItemTappedCommand(NavMenuItem parameter)
        {
            NavigationService.NavigateAsync(parameter.CommandParameter.ToString());
        }

        public MasterPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Master Page";

            MenuItems = new ObservableCollection<NavMenuItem>(new[]
            {
                new NavMenuItem { Text = "Movie Selection", FAIconCode = "&#xf008;", CommandParameter="MasterDetailNavPage/MovieSelectionPage" },
                new NavMenuItem { Text = "Logout", FAIconCode = "&#xf08b;" },
            });
        }
    }

    public class NavMenuItem : MenuItem
    {
        public string FAIconCode { get; set; }
    }
}