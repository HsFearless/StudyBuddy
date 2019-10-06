﻿namespace studyBuddy.programComponents.loginNeeds
{
    partial class loginForm
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupLogin = new System.Windows.Forms.GroupBox();
            this.groupLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(13, 18);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(101, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "username or e-mail :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(13, 40);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(58, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "password :";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(122, 18);
            this.textUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textUsername.MaxLength = 33;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(126, 20);
            this.textUsername.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(122, 41);
            this.textPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textPassword.MaxLength = 33;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '◙';
            this.textPassword.Size = new System.Drawing.Size(126, 20);
            this.textPassword.TabIndex = 3;
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Location = new System.Drawing.Point(207, 102);
            this.linkLabelRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(41, 13);
            this.linkLabelRegister.TabIndex = 2;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "register";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRegister_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(66, 63);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 24);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "say Hello";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // groupLogin
            // 
            this.groupLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLogin.Controls.Add(this.buttonLogin);
            this.groupLogin.Controls.Add(this.linkLabelRegister);
            this.groupLogin.Controls.Add(this.textPassword);
            this.groupLogin.Controls.Add(this.textUsername);
            this.groupLogin.Controls.Add(this.labelPassword);
            this.groupLogin.Controls.Add(this.labelUsername);
            this.groupLogin.Location = new System.Drawing.Point(302, 154);
            this.groupLogin.Margin = new System.Windows.Forms.Padding(2);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Padding = new System.Windows.Forms.Padding(2);
            this.groupLogin.Size = new System.Drawing.Size(262, 135);
            this.groupLogin.TabIndex = 1;
            this.groupLogin.TabStop = false;
            this.groupLogin.Text = "Login";
            // 
            // loginForm
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.groupLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(896, 504);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You shall not pass";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupLogin;
    }
}

