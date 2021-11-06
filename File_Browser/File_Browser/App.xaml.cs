using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace File_Browser
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            NavigationService.Configure("ListPage", typeof(ListPage));
            NavigationService.Configure("DetailPage", typeof(DetailPage));
            var mainPage = ((ViewNavigationService) NavigationService).SetRootPage("ListPage");

            MainPage = mainPage;


            //MainPage = new ListPage();
        }
        
        public static INavigationService NavigationService { get; } = new ViewNavigationService();


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}