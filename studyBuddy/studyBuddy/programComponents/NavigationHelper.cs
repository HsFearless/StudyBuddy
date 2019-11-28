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

        public static void SwitchToForumFrom(Form form)
        {
            //if (forum == null)
            forum = new forumNeeds.ForumForm();
            NormalSwitch(form, forum);
        }

        public static void SwitchToProfileFrom(Form form)
        {
            //if (profile == null)
            profile = new profileNeeds.userProfileForm();
            NormalSwitch(form, profile);
        }

        public static void SwitchToSettingsFrom(Form form)
        {
            //if (settings == null)
            settings = new settingsNeeds.settingsForm();
            NormalSwitch(form, settings);
        }

        public static void SwitchToStudyBuddyFrom(Form form)
        {
            //if (studyBuddy == null)
            studyBuddy = new studyBuddyNeeds.studyBuddyForm();
            NormalSwitch(form, studyBuddy);
        }

        public static void SwitchToExitFrom(Form form)
        {
            //if (exit == null)
            exit = new exitNeeds.exitForm();
            NormalSwitch(form, exit);  
        }

        private static void NormalSwitch(Form current, Form next)
        {
            FormConfig.FormHeight = current.Height;
            FormConfig.FormWidth = current.Width;
            FormConfig.FormPosition = current.Location;

            current.Visible = false;
            current.Close();

            FormConfig.GetMinSize(next);
            FormConfig.GetFormConfig(next);

            loginNeeds.Auth.DoCheckCurrentUser();

            next.FormClosing += (o, e) => FormConfig.SaveFormConfig(next); //^delegate //^lambda
            next.ShowDialog();

            // WARNING -- garbage code ahead -- WARNING

            //    one.Hide();
            //    try
            //    {
            //        two.ShowDialog();
            //    }
            //    catch (System.InvalidOperationException)
            //    {
            //        MessageBox.Show("Catched EX");
            //        two.Show();
            //        return;
            //    }
            //    if (closeAfterwards)
            //    {
            //        //MessageBox.Show("Closing one");
            //        one.Close();
            //    }

        }
    }
}
