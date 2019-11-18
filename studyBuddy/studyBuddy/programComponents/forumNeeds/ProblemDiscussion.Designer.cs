namespace studyBuddy.programComponents.forumNeeds
{
    partial class ProblemDiscussion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.problemNameLabel = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.commentsPanel = new System.Windows.Forms.Panel();
            this.addCommnetLabel = new System.Windows.Forms.Label();
            this.addCommentTextBox = new System.Windows.Forms.TextBox();
            this.addCommentButton = new System.Windows.Forms.Button();
            this.problemDescriptionLabel = new System.Windows.Forms.Label();
            this.votesCountLabel = new System.Windows.Forms.Label();
            this.votesGroupBox = new System.Windows.Forms.GroupBox();
            this.votesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // problemNameLabel
            // 
            this.problemNameLabel.AutoSize = true;
            this.problemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemNameLabel.Location = new System.Drawing.Point(52, 7);
            this.problemNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.problemNameLabel.Name = "problemNameLabel";
            this.problemNameLabel.Size = new System.Drawing.Size(182, 24);
            this.problemNameLabel.TabIndex = 0;
            this.problemNameLabel.Text = "Name placeholder";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(52, 227);
            this.commentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(87, 17);
            this.commentsLabel.TabIndex = 2;
            this.commentsLabel.Text = "Comments:";
            this.commentsLabel.Click += new System.EventHandler(this.CommentsLabel_Click);
            // 
            // commentsPanel
            // 
            this.commentsPanel.AutoScroll = true;
            this.commentsPanel.Location = new System.Drawing.Point(54, 245);
            this.commentsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.commentsPanel.Name = "commentsPanel";
            this.commentsPanel.Size = new System.Drawing.Size(768, 202);
            this.commentsPanel.TabIndex = 3;
            // 
            // addCommnetLabel
            // 
            this.addCommnetLabel.AutoSize = true;
            this.addCommnetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCommnetLabel.Location = new System.Drawing.Point(51, 120);
            this.addCommnetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addCommnetLabel.Name = "addCommnetLabel";
            this.addCommnetLabel.Size = new System.Drawing.Size(115, 17);
            this.addCommnetLabel.TabIndex = 4;
            this.addCommnetLabel.Text = "Add comment: ";
            // 
            // addCommentTextBox
            // 
            this.addCommentTextBox.Location = new System.Drawing.Point(54, 147);
            this.addCommentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addCommentTextBox.Multiline = true;
            this.addCommentTextBox.Name = "addCommentTextBox";
            this.addCommentTextBox.Size = new System.Drawing.Size(675, 71);
            this.addCommentTextBox.TabIndex = 5;
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(738, 191);
            this.addCommentButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(82, 26);
            this.addCommentButton.TabIndex = 12;
            this.addCommentButton.Text = "ADD";
            this.addCommentButton.UseVisualStyleBackColor = true;
            this.addCommentButton.Click += new System.EventHandler(this.AddCommentButton_Click);
            // 
            // problemDescriptionLabel
            // 
            this.problemDescriptionLabel.AutoSize = true;
            this.problemDescriptionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.problemDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.problemDescriptionLabel.Location = new System.Drawing.Point(56, 41);
            this.problemDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.problemDescriptionLabel.MaximumSize = new System.Drawing.Size(768, 73);
            this.problemDescriptionLabel.MinimumSize = new System.Drawing.Size(768, 73);
            this.problemDescriptionLabel.Name = "problemDescriptionLabel";
            this.problemDescriptionLabel.Size = new System.Drawing.Size(768, 73);
            this.problemDescriptionLabel.TabIndex = 13;
            this.problemDescriptionLabel.Text = "Description placeholder";
            // 
            // votesCountLabel
            // 
            this.votesCountLabel.AutoSize = true;
            this.votesCountLabel.ForeColor = System.Drawing.Color.Green;
            this.votesCountLabel.Location = new System.Drawing.Point(15, 15);
            this.votesCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.votesCountLabel.Name = "votesCountLabel";
            this.votesCountLabel.Size = new System.Drawing.Size(13, 13);
            this.votesCountLabel.TabIndex = 15;
            this.votesCountLabel.Text = "?";
            // 
            // votesGroupBox
            // 
            this.votesGroupBox.Controls.Add(this.votesCountLabel);
            this.votesGroupBox.Location = new System.Drawing.Point(-4, 51);
            this.votesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.votesGroupBox.Name = "votesGroupBox";
            this.votesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.votesGroupBox.Size = new System.Drawing.Size(56, 67);
            this.votesGroupBox.TabIndex = 16;
            this.votesGroupBox.TabStop = false;
            this.votesGroupBox.Text = "Votes:";
            // 
            // ProblemDiscussion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(878, 457);
            this.Controls.Add(this.votesGroupBox);
            this.Controls.Add(this.problemDescriptionLabel);
            this.Controls.Add(this.addCommentButton);
            this.Controls.Add(this.addCommentTextBox);
            this.Controls.Add(this.addCommnetLabel);
            this.Controls.Add(this.commentsPanel);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.problemNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProblemDiscussion";
            this.Text = "Study Buddy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProblemDiscussion_FormClosing);
            this.Load += new System.EventHandler(this.ProblemDiscussion_Load);
            this.votesGroupBox.ResumeLayout(false);
            this.votesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label problemNameLabel;
        public System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Panel commentsPanel;
        public System.Windows.Forms.Label addCommnetLabel;
        private System.Windows.Forms.TextBox addCommentTextBox;
        private System.Windows.Forms.Button addCommentButton;
        public System.Windows.Forms.Label problemDescriptionLabel;
        private System.Windows.Forms.Label votesCountLabel;
        private System.Windows.Forms.GroupBox votesGroupBox;
        private System.Windows.Forms.Button upvoteButton;
    }
}