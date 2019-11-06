namespace studyBuddy
{
    partial class InterestsForm
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
            this.chooseInterestLabel = new System.Windows.Forms.Label();
            this.confirmAddInterestButton = new System.Windows.Forms.Button();
            this.chooseInterestComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chooseInterestLabel
            // 
            this.chooseInterestLabel.AutoSize = true;
            this.chooseInterestLabel.Location = new System.Drawing.Point(111, 70);
            this.chooseInterestLabel.Name = "chooseInterestLabel";
            this.chooseInterestLabel.Size = new System.Drawing.Size(111, 17);
            this.chooseInterestLabel.TabIndex = 0;
            this.chooseInterestLabel.Text = "Choose interest:";
            // 
            // confirmAddInterestButton
            // 
            this.confirmAddInterestButton.Location = new System.Drawing.Point(114, 188);
            this.confirmAddInterestButton.Name = "confirmAddInterestButton";
            this.confirmAddInterestButton.Size = new System.Drawing.Size(108, 31);
            this.confirmAddInterestButton.TabIndex = 2;
            this.confirmAddInterestButton.Text = "CONFIRM";
            this.confirmAddInterestButton.UseVisualStyleBackColor = true;
            this.confirmAddInterestButton.Click += new System.EventHandler(this.ConfirmAddInterestButton_Click);
            // 
            // chooseInterestComboBox
            // 
            this.chooseInterestComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseInterestComboBox.FormattingEnabled = true;
            this.chooseInterestComboBox.Items.AddRange(new object[] {
            "Diskrečioji matematika",
            "IT ir komunikacijos įgūdžiai",
            "Kompiuterių architektūra",
            "Matematika programų sistemoms I/III",
            "Procedūrinis programavimas",
            "Užsienio kalba (anglų) I/II"});
            this.chooseInterestComboBox.Location = new System.Drawing.Point(31, 120);
            this.chooseInterestComboBox.Name = "chooseInterestComboBox";
            this.chooseInterestComboBox.Size = new System.Drawing.Size(271, 24);
            this.chooseInterestComboBox.TabIndex = 3;
            // 
            // InterestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.chooseInterestComboBox);
            this.Controls.Add(this.confirmAddInterestButton);
            this.Controls.Add(this.chooseInterestLabel);
            this.Name = "InterestsForm";
            this.Text = "InterestsForm";
            this.Load += new System.EventHandler(this.InterestsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseInterestLabel;
        private System.Windows.Forms.Button confirmAddInterestButton;
        private System.Windows.Forms.ComboBox chooseInterestComboBox;
    }
}