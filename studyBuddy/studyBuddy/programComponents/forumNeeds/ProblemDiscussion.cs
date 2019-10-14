using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyBuddyForm
{
    public partial class ProblemDiscussion : Form
    {
        public ProblemDiscussion()
        {
            InitializeComponent();
        }

        private void ProblemDiscussion_Load(object sender, EventArgs e)
        {

        }

        private void CommentsLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddCommentButton_Click(object sender, EventArgs e)
        {
            Label comment = new Label();
            //comment.BorderStyle = Border3DStyle;
            comment.Text = addCommentTextBox.Text;
            commentsPanel.Controls.Add(comment);
        }
    }
}
