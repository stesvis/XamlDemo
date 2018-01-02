using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamlDemo.ViewModels
{
    public class Star
    {
        public string rate { get; set; }
    }
    public class MovieSelectionViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Star> ratingStars;
        public ObservableCollection<Star> RatingStars
        {
            get { return ratingStars; }
            set
            {
                ratingStars = value;
                OnPropertyChanged(nameof(RatingStars));
            }
        }

        private ObservableCollection<Star> movies;
        public ObservableCollection<Star> Movies
        {
            get { return movies; }
            set
            {
                movies = value;
                OnPropertyChanged(nameof(Movies));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MovieSelectionViewModel()
        {
            GetRatings();
            GetMovies();
        }

        public void GetRatings()
        {
            RatingStars = new ObservableCollection<Star>();
            RatingStars.Add(new Star());
            RatingStars.Add(new Star());
            RatingStars.Add(new Star());
            RatingStars.Add(new Star());
            RatingStars.Add(new Star());
        }
        public void GetMovies()
        {
            Movies = new ObservableCollection<Star>();
            Movies.Add(new Star());
            Movies.Add(new Star());
            Movies.Add(new Star());
            Movies.Add(new Star());
            Movies.Add(new Star());
        }
    }
}

