namespace studyBuddy.programComponents.forumNeeds
{
    partial class ForumForm
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
            this.leftToolBar = new System.Windows.Forms.TableLayoutPanel();
            this.toolBarExitButton = new System.Windows.Forms.Button();
            this.toolBarSettingsButton = new System.Windows.Forms.Button();
            this.toolBarHelpButton = new System.Windows.Forms.Button();
            this.toolBarFindBuddyButton = new System.Windows.Forms.Button();
            this.toolBarForumButton = new System.Windows.Forms.Button();
            this.toolBarProfileButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.addProblemButton = new System.Windows.Forms.Button();
            this.addProblemLabel = new System.Windows.Forms.Label();
            this.sortByNameButton = new System.Windows.Forms.Button();
            this.problemsGridView = new System.Windows.Forms.DataGridView();
            this.Votes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortBySubjectButton = new System.Windows.Forms.Button();
            this.addNewGroupBox = new System.Windows.Forms.GroupBox();
            this.filterSubjectsComboBox = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.leftToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problemsGridView)).BeginInit();
            this.addNewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftToolBar
            // 
            this.leftToolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftToolBar.ColumnCount = 1;
            this.leftToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftToolBar.Controls.Add(this.toolBarExitButton, 0, 6);
            this.leftToolBar.Controls.Add(this.toolBarSettingsButton, 0, 5);
            this.leftToolBar.Controls.Add(this.toolBarHelpButton, 0, 4);
            this.leftToolBar.Controls.Add(this.toolBarFindBuddyButton, 0, 2);
            this.leftToolBar.Controls.Add(this.toolBarForumButton, 0, 1);
            this.leftToolBar.Controls.Add(this.toolBarProfileButton, 0, 0);
            this.leftToolBar.Controls.Add(this.logoLabel, 0, 3);
            this.leftToolBar.Location = new System.Drawing.Point(-4, -4);
            this.leftToolBar.Margin = new System.Windows.Forms.Padding(4);
            this.leftToolBar.Name = "leftToolBar";
            this.leftToolBar.RowCount = 7;
            this.leftToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.leftToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.leftToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.leftToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.leftToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.leftToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.leftToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.leftToolBar.Size = new System.Drawing.Size(121, 580);
            this.leftToolBar.TabIndex = 1;
            // 
            // toolBarExitButton
            // 
            this.toolBarExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBarExitButton.Location = new System.Drawing.Point(0, 493);
            this.toolBarExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.toolBarExitButton.Name = "toolBarExitButton";
            this.toolBarExitButton.Size = new System.Drawing.Size(121, 87);
            this.toolBarExitButton.TabIndex = 6;
            this.toolBarExitButton.Text = "Exit";
            this.toolBarExitButton.UseVisualStyleBackColor = true;
            // 
            // toolBarSettingsButton
            // 
            this.toolBarSettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBarSettingsButton.Location = new System.Drawing.Point(0, 406);
            this.toolBarSettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.toolBarSettingsButton.Name = "toolBarSettingsButton";
            this.toolBarSettingsButton.Size = new System.Drawing.Size(121, 87);
            this.toolBarSettingsButton.TabIndex = 5;
            this.toolBarSettingsButton.Text = "Settings";
            this.toolBarSettingsButton.UseVisualStyleBackColor = true;
            this.toolBarSettingsButton.Click += new System.EventHandler(this.ToolBarSettingsButton_Click);
            // 
            // toolBarHelpButton
            // 
            this.toolBarHelpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBarHelpButton.Location = new System.Drawing.Point(0, 319);
            this.toolBarHelpButton.Margin = new System.Windows.Forms.Padding(0);
            this.toolBarHelpButton.Name = "toolBarHelpButton";
            this.toolBarHelpButton.Size = new System.Drawing.Size(121, 87);
            this.toolBarHelpButton.TabIndex = 4;
            this.toolBarHelpButton.Text = "Help";
            this.toolBarHelpButton.UseVisualStyleBackColor = true;
            // 
            // toolBarFindBuddyButton
            // 
            this.toolBarFindBuddyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBarFindBuddyButton.Location = new System.Drawing.Point(0, 174);
            this.toolBarFindBuddyButton.Margin = new System.Windows.Forms.Padding(0);
            this.toolBarFindBuddyButton.Name = "toolBarFindBuddyButton";
            this.toolBarFindBuddyButton.Size = new System.Drawing.Size(121, 87);
            this.toolBarFindBuddyButton.TabIndex = 2;
            this.toolBarFindBuddyButton.Text = "Study Buddy";
            this.toolBarFindBuddyButton.UseVisualStyleBackColor = true;
            this.toolBarFindBuddyButton.Click += new System.EventHandler(this.ToolBarFindBuddyButton_Click);
            // 
            // toolBarForumButton
            // 
            this.toolBarForumButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBarForumButton.Location = new System.Drawing.Point(0, 87);
            this.toolBarForumButton.Margin = new System.Windows.Forms.Padding(0);
            this.toolBarForumButton.Name = "toolBarForumButton";
            this.toolBarForumButton.Size = new System.Drawing.Size(121, 87);
            this.toolBarForumButton.TabIndex = 1;
            this.toolBarForumButton.Text = "Forum";
            this.toolBarForumButton.UseVisualStyleBackColor = true;
            // 
            // toolBarProfileButton
            // 
            this.toolBarProfileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBarProfileButton.Location = new System.Drawing.Point(0, 0);
            this.toolBarProfileButton.Margin = new System.Windows.Forms.Padding(0);
            this.toolBarProfileButton.Name = "toolBarProfileButton";
            this.toolBarProfileButton.Size = new System.Drawing.Size(121, 87);
            this.toolBarProfileButton.TabIndex = 0;
            this.toolBarProfileButton.Text = "Profile";
            this.toolBarProfileButton.UseVisualStyleBackColor = true;
            this.toolBarProfileButton.Click += new System.EventHandler(this.ToolBarProfileButton_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoLabel.Location = new System.Drawing.Point(4, 261);
            this.logoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(113, 58);
            this.logoLabel.TabIndex = 7;
            this.logoLabel.Text = "Logo\r\n";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addProblemButton
            // 
            this.addProblemButton.Location = new System.Drawing.Point(211, 78);
            this.addProblemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProblemButton.Name = "addProblemButton";
            this.addProblemButton.Size = new System.Drawing.Size(109, 32);
            this.addProblemButton.TabIndex = 11;
            this.addProblemButton.Text = "ADD";
            this.addProblemButton.UseVisualStyleBackColor = true;
            this.addProblemButton.Click += new System.EventHandler(this.AddProblemButton_Click);
            // 
            // addProblemLabel
            // 
            this.addProblemLabel.AutoSize = true;
            this.addProblemLabel.Location = new System.Drawing.Point(53, 86);
            this.addProblemLabel.Name = "addProblemLabel";
            this.addProblemLabel.Size = new System.Drawing.Size(117, 17);
            this.addProblemLabel.TabIndex = 10;
            this.addProblemLabel.Text = "Add new problem";
            // 
            // sortByNameButton
            // 
            this.sortByNameButton.Location = new System.Drawing.Point(159, 82);
            this.sortByNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortByNameButton.Name = "sortByNameButton";
            this.sortByNameButton.Size = new System.Drawing.Size(153, 39);
            this.sortByNameButton.TabIndex = 13;
            this.sortByNameButton.Text = "SORT BY NAME";
            this.sortByNameButton.UseVisualStyleBackColor = true;
            this.sortByNameButton.Click += new System.EventHandler(this.SortByNameButton_Click);
            // 
            // problemsGridView
            // 
            this.problemsGridView.AllowUserToOrderColumns = true;
            this.problemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.problemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Votes,
            this.problemsNameColumn,
            this.subjectColumn,
            this.descriptionColumn,
            this.Id});
            this.problemsGridView.Location = new System.Drawing.Point(120, 170);
            this.problemsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.problemsGridView.Name = "problemsGridView";
            this.problemsGridView.RowHeadersWidth = 51;
            this.problemsGridView.RowTemplate.Height = 24;
            this.problemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.problemsGridView.Size = new System.Drawing.Size(1056, 406);
            this.problemsGridView.TabIndex = 12;
            this.problemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProblemsGridView_CellContentClick);
            this.problemsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProblemsGridView_CellDoubleClick);
            // 
            // Votes
            // 
            this.Votes.HeaderText = "Votes";
            this.Votes.MinimumWidth = 6;
            this.Votes.Name = "Votes";
            this.Votes.ReadOnly = true;
            this.Votes.Width = 125;
            // 
            // problemsNameColumn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemsNameColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.problemsNameColumn.HeaderText = "Problem\'s Name";
            this.problemsNameColumn.MinimumWidth = 6;
            this.problemsNameColumn.Name = "problemsNameColumn";
            this.problemsNameColumn.ReadOnly = true;
            this.problemsNameColumn.Width = 175;
            // 
            // subjectColumn
            // 
            this.subjectColumn.HeaderText = "Subject";
            this.subjectColumn.MinimumWidth = 6;
            this.subjectColumn.Name = "subjectColumn";
            this.subjectColumn.ReadOnly = true;
            this.subjectColumn.Width = 175;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.MinimumWidth = 6;
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "InvisibleColumn";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // sortBySubjectButton
            // 
            this.sortBySubjectButton.Location = new System.Drawing.Point(159, 31);
            this.sortBySubjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortBySubjectButton.Name = "sortBySubjectButton";
            this.sortBySubjectButton.Size = new System.Drawing.Size(153, 39);
            this.sortBySubjectButton.TabIndex = 14;
            this.sortBySubjectButton.Text = "SORT BY SUBJECT";
            this.sortBySubjectButton.UseVisualStyleBackColor = true;
            this.sortBySubjectButton.Click += new System.EventHandler(this.SortBySubjectButton_Click);
            // 
            // addNewGroupBox
            // 
            this.addNewGroupBox.Controls.Add(this.addProblemButton);
            this.addNewGroupBox.Controls.Add(this.addProblemLabel);
            this.addNewGroupBox.Location = new System.Drawing.Point(769, -4);
            this.addNewGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewGroupBox.Name = "addNewGroupBox";
            this.addNewGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewGroupBox.Size = new System.Drawing.Size(407, 174);
            this.addNewGroupBox.TabIndex = 15;
            this.addNewGroupBox.TabStop = false;
            // 
            // filterSubjectsComboBox
            // 
            this.filterSubjectsComboBox.FormattingEnabled = true;
            this.filterSubjectsComboBox.Location = new System.Drawing.Point(339, 50);
            this.filterSubjectsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.filterSubjectsComboBox.Name = "filterSubjectsComboBox";
            this.filterSubjectsComboBox.Size = new System.Drawing.Size(152, 24);
            this.filterSubjectsComboBox.TabIndex = 16;
            this.filterSubjectsComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterSubjectsComboBox_SelectedIndexChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(372, 31);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(95, 17);
            this.filterLabel.TabIndex = 17;
            this.filterLabel.Text = "Filter subjects";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(493, 98);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(137, 22);
            this.textBoxSearch.TabIndex = 18;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(645, 82);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 43);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "search in Description";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ForumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 572);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterSubjectsComboBox);
            this.Controls.Add(this.addNewGroupBox);
            this.Controls.Add(this.sortBySubjectButton);
            this.Controls.Add(this.sortByNameButton);
            this.Controls.Add(this.problemsGridView);
            this.Controls.Add(this.leftToolBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1189, 606);
            this.Name = "ForumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Buddy";
            this.Load += new System.EventHandler(this.ForumForm_Load);
            this.leftToolBar.ResumeLayout(false);
            this.leftToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problemsGridView)).EndInit();
            this.addNewGroupBox.ResumeLayout(false);
            this.addNewGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel leftToolBar;
        private System.Windows.Forms.Button toolBarExitButton;
        private System.Windows.Forms.Button toolBarSettingsButton;
        private System.Windows.Forms.Button toolBarHelpButton;
        private System.Windows.Forms.Button toolBarFindBuddyButton;
        private System.Windows.Forms.Button toolBarForumButton;
        private System.Windows.Forms.Button toolBarProfileButton;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button addProblemButton;
        private System.Windows.Forms.Label addProblemLabel;
        private System.Windows.Forms.Button sortByNameButton;
        private System.Windows.Forms.DataGridView problemsGridView;
        private System.Windows.Forms.Button sortBySubjectButton;
        private System.Windows.Forms.GroupBox addNewGroupBox;
        private System.Windows.Forms.ComboBox filterSubjectsComboBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Votes;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}