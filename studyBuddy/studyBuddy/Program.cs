using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var SessionLoginForm = new programComponents.loginNeeds.SessionLoginForm();
            SessionLoginForm.ShowDialog();
            bool successSession = SessionLoginForm.success;

            while (true)
            {

                try
                {
                    Console.WriteLine("tryBlock");
                    if(!successSession)
                    {
                        var loginForm = new programComponents.loginNeeds.loginForm();
                        loginForm.ShowDialog(); //sesijos login pries tai perkelti
                        successSession = false;
                        if (loginForm.itWasExpectedExit)
                            break;
                    }
                    else
                    {
                        programComponents.NavigationHelper.SwitchToProfileFrom(SessionLoginForm, true);
                        break;
                        //# invalid session exception gali buti kazkas kitas suvalgo.
                    }
                    
                    //Console.WriteLine($" start: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                    
                    //Application.Run(loginForm);
                    
                }
                catch (studyBuddy.exceptions.InvalidSession exis)
                {
                    Console.WriteLine($" exception: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                    if (exis.wasNotLogged)
                        MessageBox.Show("Your session seems to be corrupted");
                    MessageBox.Show("catchBlock");
                    Console.WriteLine("catchBlock");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Testing + "+ ex.ToString() );
                }
                finally
                {
                    Console.WriteLine("finallyBlock");
                }
            }
            
        }
    }
}
