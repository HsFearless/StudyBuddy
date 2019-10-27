using studyBuddy.dataNeeds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studyBuddy.programComponents.profileNeeds;

namespace studyBuddy
{
    public partial class InterestsForm : Form
    {
        FlowLayoutPanel userInterestsFLP;
        

        public InterestsForm(FlowLayoutPanel flp)
        {
            userInterestsFLP = flp;
            InitializeComponent();
        }

        private void InterestsForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmAddInterestButton_Click(object sender, EventArgs e)
        {
            //if user doest already have choosen interest, add it
            if (!CurrentUser.interests.Contains(chooseInterestComboBox.Text) && CurrentUser.isLoggedIn)
            {
                CurrentUser.interests.Add(chooseInterestComboBox.Text);
                UserDataPusher.PushNewInterest(chooseInterestComboBox.Text);
                //show interest in profile
                Label interestsLabel = new Label();
                interestsLabel.AutoSize = true;
                interestsLabel.Text = chooseInterestComboBox.Text;
                userInterestsFLP.Controls.Add(interestsLabel);
            } 
            else
                MessageBox.Show("You already have this interest!");
            
        }
    }
}
