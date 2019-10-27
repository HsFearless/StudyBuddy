using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudyBuddyApp.Components.SlideOutBar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        [Obsolete]
        public MenuPage()
        {
            InitializeComponent();

            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform<int>(20, 0, 0), 0, 0),
                Children = {
                new MainLink("Profile"),
                new MainLink("Forum"),
                new MainLink("Find Buddy"),
                new MainLink("Help and Settings"),
                new MainLink("Sign Out"),

            }
            };
            Title = "Master";
            BackgroundColor = Color.Gray.WithLuminosity(0.9);
        }
    }
}