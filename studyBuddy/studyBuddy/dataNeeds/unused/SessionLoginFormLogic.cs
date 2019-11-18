using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace studyBuddy.programComponents.loginNeeds
{
    static class SessionLoginFormLogic//this time static ok
    {
        public static bool done = false;
        public static bool success = false;
        public static bool reacted = false;
        public static Thread logInThread;
        public static Thread reactThread;

        public static void LoginThreadsStartFor(Form form, ProgressBar progressVal)
        {
            done = false;
            success = false;
            reacted = false;
            //loginThread
            //^thread
            logInThread = new Thread
            (
                delegate ()
                { //^delegate
                    SessionLoginFormLogic.RunSessionLogin(
                    progressVal);
                }
            );
            logInThread.Start();

            //reactThread
            reactThread = new Thread
            (
                delegate ()
                { //^delegate
                    SessionLoginFormLogic.ReactToSessionLoginThread(form);
                }
            );
            reactThread.Start();
        }

        public static void RunSessionLogin(ProgressBar progressVal)
        {
            done = false;
            success = Auth.LogInUsingSession(progressVal);
            done = true;
            return;
        }

        public static void ReactToSessionLoginThread(Form form)
        {

            while (done != true)
                continue;
            //finally it is done
            if (!success)
            MessageBox.Show(Auth.error.Message());
            reacted = true;
            form.Close();
        }

        public static void Exit(bool wait = false)
        {
            if (reacted)
                return;
            if (wait)
            {
                logInThread.Join();
                reactThread.Join();
            }
            else
            {
                logInThread.Abort();
                reactThread.Abort();
            }
        }

        public static bool SessionSuccess()
        {
            if (done)
            {
                return success;
            }
            else
            {
                return false;
            }
        }

    }
}
