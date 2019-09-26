using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy
{
    public partial class forumForm : Form
    {
        createProblemForm createProblemForm;
        private bool isCollapsed = true;

        public forumForm()
        {
            InitializeComponent();
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                sortMenu.Height += 150;
                topBar.Height += 150;
                if(sortMenu.Size == sortMenu.MaximumSize)
                {
                    isCollapsed = false;
                    timer1.Stop();                   
                }
            }
            else
            {
                sortMenu.Height -= 150;
                topBar.Height -= 150;
                if (sortMenu.Size == sortMenu.MinimumSize)
                {
                    isCollapsed = true;
                    timer1.Stop();
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            if (createProblemForm == null) createProblemForm = new createProblemForm(this);
            createProblemForm.Show();
            this.Hide();
        }

        private void ComponentsHolderPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
