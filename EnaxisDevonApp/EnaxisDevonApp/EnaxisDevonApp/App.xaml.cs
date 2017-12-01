using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EnaxisDevonApp.Views;
using EnaxisDevonApp.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EnaxisDevonApp
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/Login");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<Login, LoginViewModel>();
            Container.RegisterTypeForNavigation<RequestAccess, RequestAccessViewModel>();
            Container.RegisterTypeForNavigation<Home, HomeViewModel>();
            Container.RegisterTypeForNavigation<Contacts, ContactsViewModel>();
            Container.RegisterTypeForNavigation<Summary, SummaryViewModel>();
            Container.RegisterTypeForNavigation<Alert, AlertViewModel>();
        }
    }
}
