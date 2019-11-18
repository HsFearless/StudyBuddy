using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy.programComponents
{
    public abstract class FormConfig
    {
        private static bool firstCall = true;
        public static int FormHeight;
        public static int FormWidth;
        public static System.Drawing.Point FormPosition;
        public static int FormMinHeight;
        public static int FormMinWidth;

        public static void GetFormConfig (Form form)
        { //^config
            if (firstCall)
                FirstCall();

            form.Height = FormConfig.FormHeight;
            form.Width = FormConfig.FormWidth;
            form.Location = FormConfig.FormPosition;

            form.StartPosition = FormStartPosition.Manual;
        }

        public static void SaveFormConfig(Form next)
        {
            Properties.Settings.Default.FormHeight = next.Height;
            Properties.Settings.Default.FormWidth = next.Width;
            Properties.Settings.Default.FormPosition = next.Location;
            Properties.Settings.Default.Save();
        }

        public static void GetMinSize(Form form)
        {
            if (firstCall)
                FirstCall();

            form.MinimumSize = new System.Drawing.Size(FormMinWidth, FormMinHeight);
        }

        private static void FirstCall()
        {
            FormHeight = Properties.Settings.Default.FormHeight;
            FormWidth = Properties.Settings.Default.FormWidth;
            FormPosition = Properties.Settings.Default.FormPosition;
            FormMinHeight = Properties.Settings.Default.FormMinHeight;
            FormMinWidth = Properties.Settings.Default.FormMinWidth;

            firstCall = false;
        }

    }
}
