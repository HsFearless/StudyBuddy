namespace studyBuddy
{
    partial class createProblemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.problemsNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.problemsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.co = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problem\'s title";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // problemsNameTextBox
            // 
            this.problemsNameTextBox.Location = new System.Drawing.Point(255, 52);
            this.problemsNameTextBox.Multiline = true;
            this.problemsNameTextBox.Name = "problemsNameTextBox";
            this.problemsNameTextBox.Size = new System.Drawing.Size(390, 31);
            this.problemsNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Problem\'s description";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // problemsDescriptionTextBox
            // 
            this.problemsDescriptionTextBox.Location = new System.Drawing.Point(18, 195);
            this.problemsDescriptionTextBox.Multiline = true;
            this.problemsDescriptionTextBox.Name = "problemsDescriptionTextBox";
            this.problemsDescriptionTextBox.Size = new System.Drawing.Size(627, 155);
            this.problemsDescriptionTextBox.TabIndex = 3;
            // 
            // co
            // 
            this.co.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.co.Location = new System.Drawing.Point(504, 397);
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(141, 58);
            this.co.TabIndex = 4;
            this.co.Text = "CONFIRM";
            this.co.UseVisualStyleBackColor = true;
            this.co.Click += new System.EventHandler(this.Co_Click);
            // 
            // createProblemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(679, 494);
            this.Controls.Add(this.co);
            this.Controls.Add(this.problemsDescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.problemsNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "createProblemForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CreateProblemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox problemsNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox problemsDescriptionTextBox;
        private System.Windows.Forms.Button co;
    }
}