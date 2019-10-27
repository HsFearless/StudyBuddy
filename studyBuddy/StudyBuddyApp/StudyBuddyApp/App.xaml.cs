using StudyBuddyApp.Components.SlideOutBar;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudyBuddyApp
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetailPage;

        [Obsolete]
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            MasterDetailPage = new MasterDetailPage
            {
                Master = new MenuPage(),
                Detail = new NavigationPage(new LinkPage("Profile")),
            };
            MainPage = MasterDetailPage;
        }

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
