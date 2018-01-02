using System;
using Xamarin.Forms;

namespace XamlDemo.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            Page movieSelectionPage = (Page)Activator.CreateInstance(typeof(MovieSelectionPage));
            await Navigation.PushAsync(movieSelectionPage);
        }
    }
}