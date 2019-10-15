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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.newProblemGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.problemsNameTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.problemsNameLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.similarProblemsLabel = new System.Windows.Forms.Label();
            this.similarProblemsGridView = new System.Windows.Forms.DataGridView();
            this.problemsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newProblemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.similarProblemsGridView)).BeginInit();
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
            this.newProblemGroupBox.Location = new System.Drawing.Point(12, 68);
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
            this.SubjectComboBox.TextChanged += new System.EventHandler(this.SubjectComboBox_TextChanged);
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
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // similarProblemsLabel
            // 
            this.similarProblemsLabel.AutoSize = true;
            this.similarProblemsLabel.Location = new System.Drawing.Point(662, 115);
            this.similarProblemsLabel.Name = "similarProblemsLabel";
            this.similarProblemsLabel.Size = new System.Drawing.Size(123, 17);
            this.similarProblemsLabel.TabIndex = 20;
            this.similarProblemsLabel.Text = "Similar promblems";
            // 
            // similarProblemsGridView
            // 
            this.similarProblemsGridView.AllowUserToOrderColumns = true;
            this.similarProblemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.similarProblemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.problemsNameColumn,
            this.subjectColumn,
            this.descriptionColumn});
            this.similarProblemsGridView.Location = new System.Drawing.Point(616, 144);
            this.similarProblemsGridView.Name = "similarProblemsGridView";
            this.similarProblemsGridView.RowHeadersWidth = 51;
            this.similarProblemsGridView.RowTemplate.Height = 24;
            this.similarProblemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.similarProblemsGridView.Size = new System.Drawing.Size(433, 329);
            this.similarProblemsGridView.TabIndex = 21;
            this.similarProblemsGridView.Visible = false;
            // 
            // problemsNameColumn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemsNameColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.problemsNameColumn.HeaderText = "Problem\'s Name";
            this.problemsNameColumn.MinimumWidth = 6;
            this.problemsNameColumn.Name = "problemsNameColumn";
            this.problemsNameColumn.Width = 175;
            // 
            // subjectColumn
            // 
            this.subjectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectColumn.HeaderText = "Subject";
            this.subjectColumn.MinimumWidth = 6;
            this.subjectColumn.Name = "subjectColumn";
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.MinimumWidth = 6;
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.Visible = false;
            // 
            // CreateProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 562);
            this.Controls.Add(this.similarProblemsGridView);
            this.Controls.Add(this.similarProblemsLabel);
            this.Controls.Add(this.newProblemGroupBox);
            this.Name = "CreateProblem";
            this.Text = "Study Buddy";
            this.Load += new System.EventHandler(this.CreateProblem_Load);
            this.newProblemGroupBox.ResumeLayout(false);
            this.newProblemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.similarProblemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label similarProblemsLabel;
        private System.Windows.Forms.DataGridView similarProblemsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
    }
}