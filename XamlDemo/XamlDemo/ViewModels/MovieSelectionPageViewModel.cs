using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XamlDemo.ViewModels
{
    public class MovieSelectionPageViewModel : BindableBase
    {
        private IEnumerable<string> _castList;
        public IEnumerable<string> CastList
        {
            get { return _castList; }
            set { SetProperty(ref _castList, value); }
        }

        private IEnumerable<string> _imageUrls;
        public IEnumerable<string> ImageUrls
        {
            get { return _imageUrls; }
            set { SetProperty(ref _imageUrls, value); }
        }

        public MovieSelectionPageViewModel()
        {
            CastList = new List<string>
            {
                "Jeff Bridges",
                "Garrett Hedlund",
                "Olivia Wilde"
            };

            ImageUrls = new List<string>
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