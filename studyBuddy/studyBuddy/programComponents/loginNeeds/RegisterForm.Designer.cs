namespace studyBuddy.programComponents.loginNeeds
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
            this.textUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPassword2 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(152, 30);
            this.textUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUsername.MaxLength = 24;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(167, 22);
            this.textUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(4, 30);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(79, 17);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "username :";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(152, 108);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPassword.MaxLength = 33;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '◙';
            this.textPassword.Size = new System.Drawing.Size(167, 22);
            this.textPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(7, 108);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 17);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "password :";
            // 
            // textPassword2
            // 
            this.textPassword2.Location = new System.Drawing.Point(152, 144);
            this.textPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPassword2.MaxLength = 33;
            this.textPassword2.Name = "textPassword2";
            this.textPassword2.PasswordChar = '◙';
            this.textPassword2.Size = new System.Drawing.Size(167, 22);
            this.textPassword2.TabIndex = 4;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(7, 147);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(76, 17);
            this.labelPassword2.TabIndex = 6;
            this.labelPassword2.Text = "password :";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(116, 185);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(15, 393);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(66, 17);
            this.labelTest.TabIndex = 10;
            this.labelTest.Text = "labelTest";
            this.labelTest.Click += new System.EventHandler(this.LabelTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.buttonSubmit);
            this.groupBox1.Controls.Add(this.textPassword2);
            this.groupBox1.Controls.Add(this.labelPassword2);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Controls.Add(this.textUsername);
            this.groupBox1.Location = new System.Drawing.Point(395, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(340, 222);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create an account";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(4, 67);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 17);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "email:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(152, 67);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmail.MaxLength = 24;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(167, 22);
            this.textEmail.TabIndex = 2;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTest);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1189, 609);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword2;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
    }
}