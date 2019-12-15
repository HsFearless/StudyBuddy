//using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy
{

    static class Program
    {

        //public static AutoResetEvent _blockThread1 = new AutoResetEvent(false);
        //public static AutoResetEvent _blockThread2 = new AutoResetEvent(true);



            //^thread
            //private static Thread SessionCheckerThread = null;
            //private static bool threadCreated = false;
            //public static int mainThreadId;
            //public static bool ThreadSaysYes = true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


                //mainThreadId = Thread.CurrentThread.ManagedThreadId;
            //_blockThread2.Set();

            //session login attempt

            var SessionLoginForm = new programComponents.loginNeeds.SessionLoginForm();
            SessionLoginForm.ShowDialog();
            bool successSession = SessionLoginForm.success;
            


            while (true)
            {

                try
                {
                        //threadCreated = false;
                    Console.WriteLine("tryBlock");


                    if(!successSession)
                    {
                        var loginForm = new programComponents.loginNeeds.loginForm();
                        loginForm.ShowDialog(); //sesijos login pries tai perkelti
                        if(loginForm.success)
                        {
                            YouAreIn(loginForm);
                            break;
                        }

                        if (loginForm.itWasExpectedExit)
                            break;
                    }
                    else
                    {
                        successSession = false;
                        YouAreIn(SessionLoginForm);
                        break;
                        //# invalid session exception gali buti kazkas kitas suvalgo.
                    }
                    
                    //Console.WriteLine($" start: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                    
                    //Application.Run(loginForm);
                    
                }
                catch (studyBuddy.exceptions.InvalidSession exis) //^exception
                {
                        //if (threadCreated)
                            //SessionCheckerThread.Abort();
                    Console.WriteLine($" exception: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                    if (exis.wasNotLogged)
                        MessageBox.Show("Your session seems to be corrupted");
                    MessageBox.Show("catchBlock");
                    Console.WriteLine("catchBlock");
                }
                finally
                {
                        //if (threadCreated)
                            //SessionCheckerThread.Abort();
                    Console.WriteLine("finallyBlock");
                }
            } // while
            
        }//main

        private static void YouAreIn(Form loginOrSessionLoginForm)
        {
                //SessionCheckerThread = new Thread(
                //           () => programComponents.loginNeeds.Auth.DoCheckSessionOverTakenLoopForThread()
                //       );
                //threadCreated = true;
                //ThreadSaysYes = false;//^thread
                //SessionCheckerThread.Start();
            programComponents.NavigationHelper.SwitchToProfileFrom(loginOrSessionLoginForm);
            
        }

    }
}
