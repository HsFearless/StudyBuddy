using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StudyBuddyApp.Components.SlideOutBar
{
    public class MainLink : Button
    {

        public MainLink(string name)
        {
            Text = name;
            Command = new Command(o => {
                App.MasterDetailPage.Detail = new NavigationPage(new LinkPage(name));
                App.MasterDetailPage.IsPresented = false;
            });
        }

    }
}
