using System.Collections.Generic;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using Prism.Navigation;
using XamlDemo.Include;

namespace XamlDemo.ViewModels
{
    public class MovieSelectionPageViewModel : ViewModelBase
    {
        private ObservableCollection<string> _castList;
        public ObservableCollection<string> CastList
        {
            get { return _castList; }
            set { SetProperty(ref _castList, value); }
        }

        public string Star { get; set; }

        public string Cast { get; set; }

        private ObservableCollection<string> _imageUrls;
        public ObservableCollection<string> ImageUrls
        {
            get { return _imageUrls; }
            set { SetProperty(ref _imageUrls, value); }
        }

        public MovieSelectionPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            CastList = new ObservableCollection<string>
            {
                "Jeff Bridges",
                "Garrett Hedlund",
                "Olivia Wilde"
            };

            Star = FontAwesome.FAStar;

            Cast = string.Join(", ", CastList);

            ImageUrls = new ObservableCollection<string>
            {
                "https://upload.wikimedia.org/wikipedia/commons/e/e6/Jackie_Chan_Cannes_2012.jpg",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Burt_Lancaster_-_publicity_1947.JPG/627px-Burt_Lancaster_-_publicity_1947.JPG",
                "https://upload.wikimedia.org/wikipedia/commons/1/13/Circus-Clowns-1922-Poster.jpg",
                "https://upload.wikimedia.org/wikipedia/commons/c/c0/The_Birds_original_poster.jpg",
                "https://upload.wikimedia.org/wikipedia/commons/e/e6/Jackie_Chan_Cannes_2012.jpg",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Burt_Lancaster_-_publicity_1947.JPG/627px-Burt_Lancaster_-_publicity_1947.JPG",
                "https://upload.wikimedia.org/wikipedia/commons/1/13/Circus-Clowns-1922-Poster.jpg",
                "https://upload.wikimedia.org/wikipedia/commons/c/c0/The_Birds_original_poster.jpg",
            };
        }
    }
}