using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

//using dataNeeds;
using System.Linq;
using studyBuddy.programComponents.loginNeeds;
using studyBuddy.dataNeeds;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace StudyBuddyApp.Views.LogInSignUp
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleLoginPage
    {
        string text = "adsadasdasdsadasdas";
        private UserDataFetcherEntity UDF;// = new UserDataFetcherEntity(-88);

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
            text = "textas";

            InitializeComponent();
            text = "textas2222";
            PasswordEntry.Text = "penis";
            PasswordEntry.IsPassword = false;
            UDF = new UserDataFetcherEntity();
            LoginButton.Clicked += (sender, e) => OnClickLogIn();

            System.Console.WriteLine("I am in somewhere");
            //System.Console.ReadKey();


        }
        void OnClickLogIn()
        {
            DisplayAlert("Alert", "You have been alerted", "OK");
            string mailAdr = EmailEntry.EmailText;
            System.Net.Mail.MailAddress mail;
            try
            {
                mail = new System.Net.Mail.MailAddress(mailAdr);
            }
            catch
            {
                DisplayAlert("Not good", "Your email seems to be invalid", "OK, I know");
                return;
            }
            //string pass = PasswordEntry.Text;

            System.Console.WriteLine("I am in before get salt by email");
            //System.Console.ReadKey();
            string test = UDF.GetSalt(mail);

            System.Console.WriteLine("I am in after get salt by email");
            //System.Console.ReadKey();
            //PasswordEntry.Text = test;
            //EmailEntry.EmailText = "kurwa";
            this.UpdateChildrenLayout();
            test = "given email: " + mail.Address;
            test += "\nudf getsalt: " + UDF.GetSalt(mail);
            //test += "\npassword text: " + PasswordEntry.Text;
            DisplayAlert("Alert", "You have been alerteeeed\n" + test, "OK");
            /*if (Auth.LogIn(UDF, mail, pass))
                EmailEntry.EmailText = "penis";
            else
                EmailEntry.EmailText = "kurwa, nepaejo tau login";*/
            int i = 690 * 690;
            while (i > 0)
            {
                test += test;
            }
            return;
        }

    }
}