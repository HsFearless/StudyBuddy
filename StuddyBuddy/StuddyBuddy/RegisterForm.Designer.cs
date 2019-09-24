namespace StuddyBuddy
{
    partial class RegisterForm
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
            this.labelFilthyLiar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFilthyLiar
            // 
            this.labelFilthyLiar.AutoSize = true;
            this.labelFilthyLiar.Location = new System.Drawing.Point(452, 170);
            this.labelFilthyLiar.Name = "labelFilthyLiar";
            this.labelFilthyLiar.Size = new System.Drawing.Size(140, 17);
            this.labelFilthyLiar.TabIndex = 0;
            this.labelFilthyLiar.Text = "You will register here";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFilthyLiar);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilthyLiar;
    }
}