using StudyBuddyApp.Components;
using StudyBuddyApp.Views.LogInSignUp;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StudyBuddyApp.Views.ForumAlfa;

namespace StudyBuddyApp
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public static MasterDetailPage MasterDetailPage;

        [Obsolete]
        public App()
        {
            InitializeComponent();

            MainPage = new FeedbackPage();


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
