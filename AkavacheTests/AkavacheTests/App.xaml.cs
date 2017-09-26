using Microsoft.Practices.Unity;
using Akavache;
using Prism.Unity;
using Xamarin.Forms;
using AkavacheTests.Views;
using AkavacheTests.Services;

namespace AkavacheTests
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            BlobCache.ApplicationName = "AkavacheTests";

            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<PhotoService>(new ContainerControlledLifetimeManager());

            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
        }
    }
}
