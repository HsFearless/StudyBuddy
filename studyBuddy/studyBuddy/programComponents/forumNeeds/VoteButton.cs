using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddy.programComponents.forumNeeds
{


    class VoteButton : System.Windows.Forms.Button
    {
        bool toUpvote = false;
        bool previousToUpvote;
        IVotable votable;
        public VoteButton(IVotable votable, bool toUpvote = false) //^dependency
        {
            //Delegate deleUpvote = delegate(object o, EventArgs e)
            //{ votable.TakeBackUpvote(ref toUpvote); }
            //deleUpvote = delegate void KK(Object o, EventArgs E){
            //    votable.Upvote(ref toUpvote);
            //}
            // deleUpvote = (Object o, EventArgs e) => return votable.Upvote(ref toUpvote);

            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "upvoteButton";
            this.Size = new System.Drawing.Size(46, 25);
            this.TabIndex = 16;
            this.Text = "Vote++";
            this.UseVisualStyleBackColor = false;

            //
            //
            //
            this.toUpvote = toUpvote;
            this.previousToUpvote = !toUpvote;
            this.votable = votable;
            this.Click += (obj, args) => this.AfterClick(); //^events standard
        }

        public void AfterClick()
        {
            if (toUpvote == previousToUpvote)
                return;


            //if (previousToUpvote == true)
            //{
            //    toUpvote = !votable.Upvote();
            //    this.BackColor = Color.Green;
            //    this.Text = "Vote++";
            //}
            //else
            //{
            //    toUpvote = votable.TakeBackUpvote();
            //    this.BackColor = Color.MediumSlateBlue;
            //    this.Text = "Vote --";
            //}
            //previousToUpvote = !toUpvote;


            //MessageBox.Show("Test");
            if (toUpvote)
            {
                try
                {
                    if (!votable.Upvote())
                        MessageBox.Show(votable.VoteErrorMessage());
                    else
                    {
                        AfterUpvote();
                    }
                }
                catch (exceptions.DoneBefore) //^exceptions
                {
                    AfterUpvote();
                    MessageBox.Show("You have already upvoted it!");
                }
            }//still upvote
            else
            { //take back upvote
                if (!votable.TakeBackUpvote())
                    if (votable.GetError().no == dataNeeds.ErrorCode.NOT_FOUND)
                    {
                        MessageBox.Show("Your vote did not exist");
                        AfterTakeBackUpvote();
                    }
                    else
                        MessageBox.Show(votable.VoteErrorMessage());
                else
                    AfterTakeBackUpvote();
            }


        }

        private void AfterUpvote()
        {
            Button button = this;
            toUpvote = false;
            previousToUpvote = !toUpvote;
            button.BackColor = Color.MediumSlateBlue;
            button.Text = "Vote--";
        }

        private void AfterTakeBackUpvote()
        {
            Button button = this;
            toUpvote = true;
            previousToUpvote = !toUpvote;
            button.BackColor = Color.Green;
            button.Text = "Vote++";
        }

    }
}
