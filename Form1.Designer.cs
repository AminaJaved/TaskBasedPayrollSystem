﻿namespace WindowsFormsApplication2
{
    partial class frmAdminReg
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.llLogin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSignup = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Change Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(177, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(115, 20);
            this.txtPassword.TabIndex = 15;
            // 
            // llLogin
            // 
            this.llLogin.AutoSize = true;
            this.llLogin.Location = new System.Drawing.Point(50, 321);
            this.llLogin.Name = "llLogin";
            this.llLogin.Size = new System.Drawing.Size(33, 13);
            this.llLogin.TabIndex = 14;
            this.llLogin.TabStop = true;
            this.llLogin.Text = "Login";
            this.llLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLogin_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "UserName";
            // 
            // cmdSignup
            // 
            this.cmdSignup.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdSignup.Location = new System.Drawing.Point(125, 262);
            this.cmdSignup.Name = "cmdSignup";
            this.cmdSignup.Size = new System.Drawing.Size(169, 27);
            this.cmdSignup.TabIndex = 12;
            this.cmdSignup.Text = "SignUp";
            this.cmdSignup.UseVisualStyleBackColor = false;
            this.cmdSignup.Click += new System.EventHandler(this.cmdSignup_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(177, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(117, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.blank_dp;
            this.pictureBox1.Location = new System.Drawing.Point(48, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdminReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.llLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSignup);
            this.Controls.Add(this.txtUserName);
            this.Name = "frmAdminReg";
            this.Text = "Admin Registration";
            this.Load += new System.EventHandler(this.frmAdminReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel llLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSignup;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

