using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

//using dataNeeds;
using System.Linq;
using studyBuddy.programComponents.loginNeeds;
using studyBuddy.dataNeeds;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Collections.Generic;
using StudyBuddyApp.MyModelsc;

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
            PasswordEntry.Text = "senis";
            PasswordEntry.IsPassword = false;
            UDF = new UserDataFetcherEntity();
            LoginButton.Clicked += (sender, e) => OnClickLogIn();

            System.Console.WriteLine("I am in somewhere");
            //System.Console.ReadKey();
            using (var db = new MyModelsc.MyDbContext())
            {

                if (db.Users.Count() == 0)
                {
                    var uzeriai = new List<Users>();
                    uzeriai.Add(
                        new Users()
                        {
                            Email = "user@user.user",
                            Username = "user",
                            Id = 1,
                            Password = "MPHLqx0yd/wDufaA9lt3eWtSxITHRSafptB5JRYkLKo+UKExr6vJ",
                            Salt = "jyOvDxA6FpyQsTWM",
                            Karma = 81,
                            ProfileInfo = "asdff huehuehuehue",
                            Rating = -1,
                            UpForTeaching = 1,
                            LoggedInHash = "uCz8upbdZ31kfL4modQcGwAT5oo =",
                            LastActivity = 1576438551


                        }
                        );
                    uzeriai.Add(
                        new Users()
                        {
                            Email = "user04@user.user",
                            Username = "user04",
                            Id = 2,
                            Password = "ToC6pFqY2SK7+Gog2zspDcTcbpeUXCAZn3t7TEGo2ZQkaD9jx+31",
                            Salt = "KJQ4cRT/DDxJqCyr",
                            Karma = 81,
                            ProfileInfo = "asdff huehuehuehue",
                            Rating = -1,
                            UpForTeaching = 1,
                            LoggedInHash = "uCz8upbdZ31kfL4modQcGwAT5oo =",
                            LastActivity = 1571837767

                        }
                        );
                    db.Users.AddRange(uzeriai);
                    db.SaveChanges();
                }

            }



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
                EmailEntry.EmailText = "senis";
            else
                EmailEntry.EmailText = "deja, nepaejo tau login";*/
            int i = 690 * 690;
            while (i > 0)
            {
                test += test;
            }
            return;
        }

    }
}