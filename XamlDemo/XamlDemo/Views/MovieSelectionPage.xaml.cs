using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamlDemo.ViewModels;

namespace XamlDemo.Views
{
    public partial class MovieSelectionPage : ContentPage
    {
        MovieSelectionViewModel MovieSelectionViewModel;

        public MovieSelectionPage()
        {
            InitializeComponent();

            MovieSelectionViewModel = new MovieSelectionViewModel();
            BindingContext = MovieSelectionViewModel;
        }
       
    }
}
