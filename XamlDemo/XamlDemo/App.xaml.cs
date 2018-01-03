using Prism.Ninject;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamlDemo.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace XamlDemo
{
    public partial class App : PrismApplication
    {
        /*
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor.
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */

        public App() : this(null)
        {
        }

        public App(IPlatformInitializer initializer) : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            if (Device.Idiom == TargetIdiom.Desktop || Device.Idiom == TargetIdiom.Tablet)
            {
                // Destop or Tablet mode
            }
            else
            {
                // Phone mode
            }

            await NavigationService.NavigateAsync("MasterDetailNavPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MovieSelectionPage>();
            Container.RegisterTypeForNavigation<TimelinePage>();
            Container.RegisterTypeForNavigation<MasterDetailNavPage>();
            Container.RegisterTypeForNavigation<MasterPage>();
        }
    }
}