﻿namespace Csharp_Project
{
    partial class FORM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_LOGIN));
            this.TB_USERNAME = new System.Windows.Forms.TextBox();
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.CB_PASSWORD = new System.Windows.Forms.CheckBox();
            this.PANEL_CLOSE = new System.Windows.Forms.Panel();
            this.PANEL_LOGIN = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TB_USERNAME
            // 
            this.TB_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_USERNAME.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_USERNAME.Location = new System.Drawing.Point(336, 294);
            this.TB_USERNAME.Multiline = true;
            this.TB_USERNAME.Name = "TB_USERNAME";
            this.TB_USERNAME.Size = new System.Drawing.Size(392, 42);
            this.TB_USERNAME.TabIndex = 0;
            this.TB_USERNAME.Text = "admin";
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_PASSWORD.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PASSWORD.Location = new System.Drawing.Point(336, 360);
            this.TB_PASSWORD.Multiline = true;
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.PasswordChar = '*';
            this.TB_PASSWORD.Size = new System.Drawing.Size(392, 45);
            this.TB_PASSWORD.TabIndex = 1;
            this.TB_PASSWORD.Text = "password";
            this.TB_PASSWORD.TextChanged += new System.EventHandler(this.TB_PASSWORD_TextChanged);
            // 
            // CB_PASSWORD
            // 
            this.CB_PASSWORD.Location = new System.Drawing.Point(578, 416);
            this.CB_PASSWORD.Name = "CB_PASSWORD";
            this.CB_PASSWORD.Size = new System.Drawing.Size(14, 14);
            this.CB_PASSWORD.TabIndex = 2;
            this.CB_PASSWORD.UseVisualStyleBackColor = true;
            this.CB_PASSWORD.CheckedChanged += new System.EventHandler(this.CB_PASSWORD_CheckedChanged);
            // 
            // PANEL_CLOSE
            // 
            this.PANEL_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_CLOSE.Location = new System.Drawing.Point(964, 24);
            this.PANEL_CLOSE.Name = "PANEL_CLOSE";
            this.PANEL_CLOSE.Size = new System.Drawing.Size(50, 44);
            this.PANEL_CLOSE.TabIndex = 4;
            this.PANEL_CLOSE.Click += new System.EventHandler(this.PANEL_CLOSE_Click);
            // 
            // PANEL_LOGIN
            // 
            this.PANEL_LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_LOGIN.Location = new System.Drawing.Point(337, 442);
            this.PANEL_LOGIN.Name = "PANEL_LOGIN";
            this.PANEL_LOGIN.Size = new System.Drawing.Size(392, 59);
            this.PANEL_LOGIN.TabIndex = 5;
            this.PANEL_LOGIN.Click += new System.EventHandler(this.PANEL_LOGIN_Click);
            // 
            // FORM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 571);
            this.ControlBox = false;
            this.Controls.Add(this.PANEL_LOGIN);
            this.Controls.Add(this.PANEL_CLOSE);
            this.Controls.Add(this.CB_PASSWORD);
            this.Controls.Add(this.TB_PASSWORD);
            this.Controls.Add(this.TB_USERNAME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_USERNAME;
        private System.Windows.Forms.TextBox TB_PASSWORD;
        private System.Windows.Forms.CheckBox CB_PASSWORD;
        private System.Windows.Forms.Panel PANEL_CLOSE;
        private System.Windows.Forms.Panel PANEL_LOGIN;
    }
}