using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudyBuddyApp.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public ListView ListView;

        public MainPageMaster()
        {
            InitializeComponent();

            BindingContext = new MainPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainPageMasterMenuItem> MenuItems { get; set; }

            public MainPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainPageMasterMenuItem>(new[]
                {
                    new MainPageMasterMenuItem { Id = 0, Title = "Profile", TargetType = typeof(Profile)},
                    new MainPageMasterMenuItem { Id = 1, Title = "Forums", TargetType = typeof(Forum)},
                    new MainPageMasterMenuItem { Id = 2, Title = "Find Buddy", TargetType = typeof(FindBuddy)},
                    new MainPageMasterMenuItem { Id = 3, Title = "Help & Settings", TargetType = typeof(HelpAndSettings)},
                    new MainPageMasterMenuItem { Id = 4, Title = "Sign Out", TargetType = typeof(SignOut)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            #endregion
        }
    }
}