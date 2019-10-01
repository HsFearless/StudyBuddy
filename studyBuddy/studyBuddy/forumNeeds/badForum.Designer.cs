namespace studyBuddy
{
    partial class forumForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topBar = new System.Windows.Forms.Panel();
            this.sortMenu = new System.Windows.Forms.Panel();
            this.sortWorstButton = new System.Windows.Forms.Button();
            this.sortRecentButton = new System.Windows.Forms.Button();
            this.sortBestButton = new System.Windows.Forms.Button();
            this.sortByButton = new System.Windows.Forms.Button();
            this.roundButton1 = new studyBuddy.roundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.componentsHolderPanel = new System.Windows.Forms.Panel();
            this.topBar.SuspendLayout();
            this.sortMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 488);
            this.panel1.TabIndex = 0;
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.DimGray;
            this.topBar.Controls.Add(this.sortMenu);
            this.topBar.Controls.Add(this.roundButton1);
            this.topBar.Controls.Add(this.label1);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(154, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(2);
            this.topBar.MaximumSize = new System.Drawing.Size(622, 406);
            this.topBar.MinimumSize = new System.Drawing.Size(622, 81);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(622, 81);
            this.topBar.TabIndex = 1;
            this.topBar.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // sortMenu
            // 
            this.sortMenu.Controls.Add(this.sortWorstButton);
            this.sortMenu.Controls.Add(this.sortRecentButton);
            this.sortMenu.Controls.Add(this.sortBestButton);
            this.sortMenu.Controls.Add(this.sortByButton);
            this.sortMenu.Location = new System.Drawing.Point(66, 15);
            this.sortMenu.Margin = new System.Windows.Forms.Padding(2);
            this.sortMenu.MaximumSize = new System.Drawing.Size(190, 171);
            this.sortMenu.MinimumSize = new System.Drawing.Size(190, 50);
            this.sortMenu.Name = "sortMenu";
            this.sortMenu.Size = new System.Drawing.Size(190, 50);
            this.sortMenu.TabIndex = 2;
            // 
            // sortWorstButton
            // 
            this.sortWorstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(77)))));
            this.sortWorstButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sortWorstButton.FlatAppearance.BorderSize = 0;
            this.sortWorstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortWorstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortWorstButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortWorstButton.Location = new System.Drawing.Point(0, 129);
            this.sortWorstButton.Margin = new System.Windows.Forms.Padding(2);
            this.sortWorstButton.Name = "sortWorstButton";
            this.sortWorstButton.Size = new System.Drawing.Size(190, 40);
            this.sortWorstButton.TabIndex = 3;
            this.sortWorstButton.Text = "worst";
            this.sortWorstButton.UseVisualStyleBackColor = false;
            this.sortWorstButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // sortRecentButton
            // 
            this.sortRecentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(77)))));
            this.sortRecentButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sortRecentButton.FlatAppearance.BorderSize = 0;
            this.sortRecentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortRecentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortRecentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortRecentButton.Location = new System.Drawing.Point(0, 89);
            this.sortRecentButton.Margin = new System.Windows.Forms.Padding(2);
            this.sortRecentButton.Name = "sortRecentButton";
            this.sortRecentButton.Size = new System.Drawing.Size(190, 40);
            this.sortRecentButton.TabIndex = 2;
            this.sortRecentButton.Text = "most recent";
            this.sortRecentButton.UseVisualStyleBackColor = false;
            this.sortRecentButton.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // sortBestButton
            // 
            this.sortBestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(77)))));
            this.sortBestButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sortBestButton.FlatAppearance.BorderSize = 0;
            this.sortBestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBestButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortBestButton.Location = new System.Drawing.Point(0, 50);
            this.sortBestButton.Margin = new System.Windows.Forms.Padding(2);
            this.sortBestButton.Name = "sortBestButton";
            this.sortBestButton.Size = new System.Drawing.Size(190, 40);
            this.sortBestButton.TabIndex = 1;
            this.sortBestButton.Text = "best";
            this.sortBestButton.UseVisualStyleBackColor = false;
            this.sortBestButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // sortByButton
            // 
            this.sortByButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.sortByButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sortByButton.FlatAppearance.BorderSize = 0;
            this.sortByButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortByButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortByButton.Location = new System.Drawing.Point(0, 10);
            this.sortByButton.Margin = new System.Windows.Forms.Padding(2);
            this.sortByButton.Name = "sortByButton";
            this.sortByButton.Size = new System.Drawing.Size(190, 40);
            this.sortByButton.TabIndex = 0;
            this.sortByButton.Text = "      Sort by     ⯆";
            this.sortByButton.UseVisualStyleBackColor = false;
            this.sortByButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.roundButton1.Location = new System.Drawing.Point(537, 15);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(67, 63);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "+";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.RoundButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(368, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new problem";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // componentsHolderPanel
            // 
            this.componentsHolderPanel.AutoScroll = true;
            this.componentsHolderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentsHolderPanel.Location = new System.Drawing.Point(154, 81);
            this.componentsHolderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.componentsHolderPanel.Name = "componentsHolderPanel";
            this.componentsHolderPanel.Size = new System.Drawing.Size(623, 407);
            this.componentsHolderPanel.TabIndex = 2;
            this.componentsHolderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ComponentsHolderPanel_Paint);
            // 
            // forumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(777, 488);
            this.Controls.Add(this.componentsHolderPanel);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "forumForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.sortMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Label label1;
        private roundButton roundButton1;
        private System.Windows.Forms.Panel sortMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button sortByButton;
        private System.Windows.Forms.Button sortWorstButton;
        private System.Windows.Forms.Button sortRecentButton;
        private System.Windows.Forms.Button sortBestButton;
        private System.Windows.Forms.Panel componentsHolderPanel;
    }
}

