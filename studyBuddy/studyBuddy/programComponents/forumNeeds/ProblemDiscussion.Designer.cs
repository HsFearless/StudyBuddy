namespace studyBuddyForm
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
            this.SuspendLayout();
            // 
            // problemNameLabel
            // 
            this.problemNameLabel.AutoSize = true;
            this.problemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemNameLabel.Location = new System.Drawing.Point(69, 9);
            this.problemNameLabel.Name = "problemNameLabel";
            this.problemNameLabel.Size = new System.Drawing.Size(228, 29);
            this.problemNameLabel.TabIndex = 0;
            this.problemNameLabel.Text = "Name placeholder";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(70, 279);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(104, 20);
            this.commentsLabel.TabIndex = 2;
            this.commentsLabel.Text = "Comments:";
            this.commentsLabel.Click += new System.EventHandler(this.CommentsLabel_Click);
            // 
            // commentsPanel
            // 
            this.commentsPanel.AutoScroll = true;
            this.commentsPanel.Location = new System.Drawing.Point(72, 302);
            this.commentsPanel.Name = "commentsPanel";
            this.commentsPanel.Size = new System.Drawing.Size(1024, 248);
            this.commentsPanel.TabIndex = 3;
            // 
            // addCommnetLabel
            // 
            this.addCommnetLabel.AutoSize = true;
            this.addCommnetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCommnetLabel.Location = new System.Drawing.Point(68, 148);
            this.addCommnetLabel.Name = "addCommnetLabel";
            this.addCommnetLabel.Size = new System.Drawing.Size(135, 20);
            this.addCommnetLabel.TabIndex = 4;
            this.addCommnetLabel.Text = "Add comment: ";
            // 
            // addCommentTextBox
            // 
            this.addCommentTextBox.Location = new System.Drawing.Point(72, 181);
            this.addCommentTextBox.Multiline = true;
            this.addCommentTextBox.Name = "addCommentTextBox";
            this.addCommentTextBox.Size = new System.Drawing.Size(899, 86);
            this.addCommentTextBox.TabIndex = 5;
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(984, 235);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(110, 32);
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
            this.problemDescriptionLabel.Location = new System.Drawing.Point(74, 51);
            this.problemDescriptionLabel.MaximumSize = new System.Drawing.Size(1024, 90);
            this.problemDescriptionLabel.MinimumSize = new System.Drawing.Size(1024, 90);
            this.problemDescriptionLabel.Name = "problemDescriptionLabel";
            this.problemDescriptionLabel.Size = new System.Drawing.Size(1024, 90);
            this.problemDescriptionLabel.TabIndex = 13;
            this.problemDescriptionLabel.Text = "Description placeholder";
            // 
            // ProblemDiscussion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1171, 562);
            this.Controls.Add(this.problemDescriptionLabel);
            this.Controls.Add(this.addCommentButton);
            this.Controls.Add(this.addCommentTextBox);
            this.Controls.Add(this.addCommnetLabel);
            this.Controls.Add(this.commentsPanel);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.problemNameLabel);
            this.Name = "ProblemDiscussion";
            this.Text = "Study Buddy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProblemDiscussion_FormClosing);
            this.Load += new System.EventHandler(this.ProblemDiscussion_Load);
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
    }
}