namespace studyBuddy.programComponents.loginNeeds
{
    partial class SessionLoginForm
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PleaseWaitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(104, 34);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(250, 17);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Trying to log in using your last session";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(107, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(247, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 1;
            // 
            // PleaseWaitLabel
            // 
            this.PleaseWaitLabel.AutoSize = true;
            this.PleaseWaitLabel.Location = new System.Drawing.Point(184, 92);
            this.PleaseWaitLabel.Name = "PleaseWaitLabel";
            this.PleaseWaitLabel.Size = new System.Drawing.Size(79, 17);
            this.PleaseWaitLabel.TabIndex = 2;
            this.PleaseWaitLabel.Text = "Please wait";
            // 
            // SessionLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 146);
            this.Controls.Add(this.PleaseWaitLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusLabel);
            this.Name = "SessionLoginForm";
            this.Text = "SessionLoginForm";
            this.Load += new System.EventHandler(this.SessionLoginForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SessionLoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label PleaseWaitLabel;
    }
}