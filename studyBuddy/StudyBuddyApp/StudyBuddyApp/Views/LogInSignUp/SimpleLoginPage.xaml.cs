using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

//using dataNeeds;
using System.Linq;

namespace StudyBuddyApp.Views.LogInSignUp
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleLoginPage
    {

        //Problem problem;
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLoginPage" /> class.
        /// </summary>
        public SimpleLoginPage()
        {
            /*using (var db = new ForumPostsContext())
            {
                problem = db.ForumPosts.Single(p => p.ID == 1);
            }*/
            InitializeComponent();
            
        }
    }
}