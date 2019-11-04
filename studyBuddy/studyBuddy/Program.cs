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
            while(true)
            {
                try
                {
                    Console.WriteLine("tryBlock");
                    var loginForm = new programComponents.loginNeeds.loginForm();
                    loginForm.ShowDialog();
                    //Application.Run(loginForm);
                    if (loginForm.itWasExpectedExit)
                        break;
                }
                catch (studyBuddy.exceptions.InvalidSession exis)
                {
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
