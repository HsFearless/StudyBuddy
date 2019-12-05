using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace StudyBuddyApp.Views.ForumBeta
{
    /// <summary>
    /// Page to show the transaction history.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransactionHistoryPage : ContentPage
    {
        public TransactionHistoryPage()
        {
            InitializeComponent();
        }
    }
}