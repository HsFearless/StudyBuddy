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
    public partial class LinkPage : ContentPage
    {
        public LinkPage(string name)
        {
            InitializeComponent();

            Title = name;
            Content = new StackLayout
            {
                Children = {
                    //Create new sublinks here
                    //new SubLink(name + ".1")
                },
            };
        }
    }
}