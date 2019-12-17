using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudyBuddyApp.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

   
    public partial class Profile : ContentPage
    {
        public IList<Monkey> Monkeys { get; private set; }
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public Profile()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            // ObservableCollection allows items to be added after ItemsSource
            // is set and the UI will react to changes
            employees.Add(new Employee { DisplayName = "Rob Finnerty" });
            employees.Add(new Employee { DisplayName = "Bill Wrestler" });
            employees.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper" });
            employees.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy" });
            employees.Add(new Employee { DisplayName = "Sheri Spruce" });
            employees.Add(new Employee { DisplayName = "Burt Indybrick" });
        }

        void onAddInterestClicked(object sender, EventArgs e)
        {
            DataHandler1 dh = new DataHandler1();
            dh.GetForum();
        }
    }
}