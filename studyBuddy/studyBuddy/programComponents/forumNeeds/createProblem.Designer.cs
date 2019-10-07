namespace studyBuddy.forumNeeds
{
    partial class CreateProblem
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
            this.newProblemGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.problemsNameTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.problemsNameLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.newProblemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newProblemGroupBox
            // 
            this.newProblemGroupBox.Controls.Add(this.confirmButton);
            this.newProblemGroupBox.Controls.Add(this.problemsNameTextBox);
            this.newProblemGroupBox.Controls.Add(this.subjectLabel);
            this.newProblemGroupBox.Controls.Add(this.descriptionLabel);
            this.newProblemGroupBox.Controls.Add(this.SubjectComboBox);
            this.newProblemGroupBox.Controls.Add(this.problemsNameLabel);
            this.newProblemGroupBox.Controls.Add(this.descriptionTextBox);
            this.newProblemGroupBox.Location = new System.Drawing.Point(286, 79);
            this.newProblemGroupBox.Name = "newProblemGroupBox";
            this.newProblemGroupBox.Size = new System.Drawing.Size(598, 405);
            this.newProblemGroupBox.TabIndex = 19;
            this.newProblemGroupBox.TabStop = false;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(459, 341);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(103, 33);
            this.confirmButton.TabIndex = 18;
            this.confirmButton.Text = "CONFIRM";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // problemsNameTextBox
            // 
            this.problemsNameTextBox.Location = new System.Drawing.Point(148, 42);
            this.problemsNameTextBox.Name = "problemsNameTextBox";
            this.problemsNameTextBox.Size = new System.Drawing.Size(193, 22);
            this.problemsNameTextBox.TabIndex = 12;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(25, 91);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(55, 17);
            this.subjectLabel.TabIndex = 17;
            this.subjectLabel.Text = "Subject";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(22, 138);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 15;
            this.descriptionLabel.Text = "Description";
            // 
            // SubjectComboBox
            // 
            this.SubjectComboBox.FormattingEnabled = true;
            this.SubjectComboBox.Items.AddRange(new object[] {
            "Math",
            "Physics",
            "Foreign language",
            "Music",
            "Biology",
            "Chemistry",
            "Other"});
            this.SubjectComboBox.Location = new System.Drawing.Point(148, 91);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(193, 24);
            this.SubjectComboBox.TabIndex = 16;
            // 
            // problemsNameLabel
            // 
            this.problemsNameLabel.AutoSize = true;
            this.problemsNameLabel.Location = new System.Drawing.Point(22, 47);
            this.problemsNameLabel.Name = "problemsNameLabel";
            this.problemsNameLabel.Size = new System.Drawing.Size(109, 17);
            this.problemsNameLabel.TabIndex = 14;
            this.problemsNameLabel.Text = "Problem\'s name";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(145, 138);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(417, 169);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // CreateProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 562);
            this.Controls.Add(this.newProblemGroupBox);
            this.Name = "CreateProblem";
            this.Text = "Study Buddy";
            this.Load += new System.EventHandler(this.CreateProblem_Load);
            this.newProblemGroupBox.ResumeLayout(false);
            this.newProblemGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newProblemGroupBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox problemsNameTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ComboBox SubjectComboBox;
        private System.Windows.Forms.Label problemsNameLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}