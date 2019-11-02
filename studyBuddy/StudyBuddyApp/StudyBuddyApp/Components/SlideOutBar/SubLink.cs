using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StudyBuddyApp.Components.SlideOutBar
{
    public class SubLink : Button
    {

        public SubLink(string name)
        {
            Text = name;
            TextColor = Color.White;
            Command = new Command(o => App.MasterDetailPage.Detail.Navigation.PushAsync(new LinkPage(name)));
        }

    }
}
