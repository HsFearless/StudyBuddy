using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy.programComponents
{
    static class NavigationHelper
    {
        private static forumNeeds.ForumForm forum = null;
        private static profileNeeds.userProfileForm profile = null;
        private static settingsNeeds.settingsForm settings = null;
        private static studyBuddyNeeds.studyBuddyForm studyBuddy = null;
        private static exitNeeds.exitForm exit = null;

        public static void SwitchToForumFrom(Form form, bool closeAfterwards=false)
        {
            try
            {
                Console.WriteLine("Blogai!!!");
                if (forum == null)
                    forum = new forumNeeds.ForumForm();
            }
            catch
            {
               // System.Diagnostics.Debug.WriteLine("zsbs1");
                Console.WriteLine("Blogai!!!");
            }
                NormalSwitch(form, forum, closeAfterwards);

            
        }

        public static void SwitchToProfileFrom(Form form, bool closeAfterwards = false)
        {
            try
            {
                if (profile == null)
                    profile = new profileNeeds.userProfileForm();
                NormalSwitch(form, profile, closeAfterwards);
            }
            catch
            {
                //System.Diagnostics.Debug.WriteLine("zsbs2");
               // Console.WriteLine("Blogai!!!");
            }
        }

        public static void SwitchToSettingsFrom(Form form, bool closeAfterwards = false)
        {
            if (settings == null)
                settings = new settingsNeeds.settingsForm();
            NormalSwitch(form, settings, closeAfterwards);
        }

        public static void SwitchToStudyBuddyFrom(Form form, bool closeAfterwards = false)
        {
            if (studyBuddy == null)
                studyBuddy = new studyBuddyNeeds.studyBuddyForm();
            NormalSwitch(form, studyBuddy, closeAfterwards);
        }

        public static void SwitchToExitFrom(Form form, bool closeAfterwards = false)
        {
            if (exit == null)
                exit = new exitNeeds.exitForm();
            NormalSwitch(form, exit, closeAfterwards);
        }

        private static void NormalSwitch(Form one, Form two, bool closeAfterwards)
        {
            one.Hide();
            try
            {
                two.ShowDialog();
            }
            catch (System.InvalidOperationException)
            {
                //MessageBox.Show("Catched EX");
                two.Show();
                return;
            }
            if (closeAfterwards)
            {
                //MessageBox.Show("Closing one");
                one.Close();
            }
        }
    }
}
