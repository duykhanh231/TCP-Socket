﻿namespace TCPSocket
{
    partial class NavForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbUserMgmt = new Label();
            btnLogin = new Button();
            btnSignup = new Button();
            SuspendLayout();
            // 
            // lbUserMgmt
            // 
            lbUserMgmt.AutoSize = true;
            lbUserMgmt.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserMgmt.Location = new Point(208, 80);
            lbUserMgmt.Name = "lbUserMgmt";
            lbUserMgmt.Size = new Size(395, 59);
            lbUserMgmt.TabIndex = 0;
            lbUserMgmt.Text = "User Management";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(324, 198);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(324, 295);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(150, 46);
            btnSignup.TabIndex = 2;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(lbUserMgmt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserMgmt;
        private Button btnLogin;
        private Button btnSignup;
    }
}
