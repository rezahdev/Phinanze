﻿namespace MyCost.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.userNameLaabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentUserNameTextBox = new System.Windows.Forms.TextBox();
            this.newUserNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmUserNameTextBox = new System.Windows.Forms.TextBox();
            this.submitUserNameButton = new System.Windows.Forms.Button();
            this.submitPasswordButton = new System.Windows.Forms.Button();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reportIssueButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.viewSourceButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.yearlyStatisticsButton = new System.Windows.Forms.Button();
            this.dailyReportButton = new System.Windows.Forms.Button();
            this.addNewDataButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLaabel
            // 
            this.userNameLaabel.AutoSize = true;
            this.userNameLaabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLaabel.ForeColor = System.Drawing.Color.Black;
            this.userNameLaabel.Location = new System.Drawing.Point(12, 63);
            this.userNameLaabel.Name = "userNameLaabel";
            this.userNameLaabel.Size = new System.Drawing.Size(97, 19);
            this.userNameLaabel.TabIndex = 46;
            this.userNameLaabel.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Change username";
            // 
            // currentUserNameTextBox
            // 
            this.currentUserNameTextBox.BackColor = System.Drawing.Color.White;
            this.currentUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentUserNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.currentUserNameTextBox.Location = new System.Drawing.Point(15, 159);
            this.currentUserNameTextBox.Name = "currentUserNameTextBox";
            this.currentUserNameTextBox.Size = new System.Drawing.Size(346, 26);
            this.currentUserNameTextBox.TabIndex = 48;
            this.currentUserNameTextBox.Text = "Current username";
            this.currentUserNameTextBox.Click += new System.EventHandler(this.UsernameTextBoxesClicked);
            this.currentUserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBoxesTextChanged);
            // 
            // newUserNameTextBox
            // 
            this.newUserNameTextBox.BackColor = System.Drawing.Color.White;
            this.newUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newUserNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.newUserNameTextBox.Location = new System.Drawing.Point(16, 208);
            this.newUserNameTextBox.Name = "newUserNameTextBox";
            this.newUserNameTextBox.Size = new System.Drawing.Size(345, 26);
            this.newUserNameTextBox.TabIndex = 49;
            this.newUserNameTextBox.Text = "New username";
            this.newUserNameTextBox.Click += new System.EventHandler(this.UsernameTextBoxesClicked);
            this.newUserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBoxesTextChanged);
            // 
            // confirmUserNameTextBox
            // 
            this.confirmUserNameTextBox.BackColor = System.Drawing.Color.White;
            this.confirmUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmUserNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmUserNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.confirmUserNameTextBox.Location = new System.Drawing.Point(16, 256);
            this.confirmUserNameTextBox.Name = "confirmUserNameTextBox";
            this.confirmUserNameTextBox.Size = new System.Drawing.Size(345, 26);
            this.confirmUserNameTextBox.TabIndex = 50;
            this.confirmUserNameTextBox.Text = "Confirm new username";
            this.confirmUserNameTextBox.Click += new System.EventHandler(this.UsernameTextBoxesClicked);
            this.confirmUserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBoxesTextChanged);
            // 
            // submitUserNameButton
            // 
            this.submitUserNameButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.submitUserNameButton.Enabled = false;
            this.submitUserNameButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.submitUserNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitUserNameButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUserNameButton.ForeColor = System.Drawing.Color.White;
            this.submitUserNameButton.Location = new System.Drawing.Point(16, 310);
            this.submitUserNameButton.Name = "submitUserNameButton";
            this.submitUserNameButton.Size = new System.Drawing.Size(345, 35);
            this.submitUserNameButton.TabIndex = 51;
            this.submitUserNameButton.Text = "Submit";
            this.submitUserNameButton.UseVisualStyleBackColor = false;
            this.submitUserNameButton.Click += new System.EventHandler(this.SubmitNewUsernameButtonClicked);
            // 
            // submitPasswordButton
            // 
            this.submitPasswordButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.submitPasswordButton.Enabled = false;
            this.submitPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.submitPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitPasswordButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitPasswordButton.ForeColor = System.Drawing.Color.White;
            this.submitPasswordButton.Location = new System.Drawing.Point(444, 310);
            this.submitPasswordButton.Name = "submitPasswordButton";
            this.submitPasswordButton.Size = new System.Drawing.Size(340, 35);
            this.submitPasswordButton.TabIndex = 56;
            this.submitPasswordButton.Text = "Submit";
            this.submitPasswordButton.UseVisualStyleBackColor = false;
            this.submitPasswordButton.Click += new System.EventHandler(this.SubmitNewPasswordButtonClicked);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(444, 256);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(340, 26);
            this.confirmPasswordTextBox.TabIndex = 55;
            this.confirmPasswordTextBox.Text = "Confirm new password";
            this.confirmPasswordTextBox.Click += new System.EventHandler(this.PasswordTextBoxesClicked);
            this.confirmPasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBoxesTextChanged);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.newPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.newPasswordTextBox.Location = new System.Drawing.Point(445, 208);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(340, 26);
            this.newPasswordTextBox.TabIndex = 54;
            this.newPasswordTextBox.Text = "New password";
            this.newPasswordTextBox.Click += new System.EventHandler(this.PasswordTextBoxesClicked);
            this.newPasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBoxesTextChanged);
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.currentPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.currentPasswordTextBox.Location = new System.Drawing.Point(443, 159);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(341, 26);
            this.currentPasswordTextBox.TabIndex = 53;
            this.currentPasswordTextBox.Text = "Current password";
            this.currentPasswordTextBox.Click += new System.EventHandler(this.PasswordTextBoxesClicked);
            this.currentPasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBoxesTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(442, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Change username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(399, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 198);
            this.label3.TabIndex = 57;
            this.label3.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(782, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "_________________________________________________________________________________" +
    "_____";
            // 
            // reportIssueButton
            // 
            this.reportIssueButton.BackColor = System.Drawing.Color.White;
            this.reportIssueButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.reportIssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportIssueButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportIssueButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reportIssueButton.Location = new System.Drawing.Point(496, 422);
            this.reportIssueButton.Name = "reportIssueButton";
            this.reportIssueButton.Size = new System.Drawing.Size(141, 31);
            this.reportIssueButton.TabIndex = 64;
            this.reportIssueButton.Text = "Report Issues";
            this.reportIssueButton.UseVisualStyleBackColor = false;
            this.reportIssueButton.Click += new System.EventHandler(this.ReportIssueButtonClicked);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.White;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.helpButton.Location = new System.Drawing.Point(344, 422);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(133, 31);
            this.helpButton.TabIndex = 65;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.HelpButtonClicked);
            // 
            // viewSourceButton
            // 
            this.viewSourceButton.BackColor = System.Drawing.Color.White;
            this.viewSourceButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.viewSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSourceButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSourceButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.viewSourceButton.Location = new System.Drawing.Point(654, 422);
            this.viewSourceButton.Name = "viewSourceButton";
            this.viewSourceButton.Size = new System.Drawing.Size(131, 31);
            this.viewSourceButton.TabIndex = 66;
            this.viewSourceButton.Text = "View Source";
            this.viewSourceButton.UseVisualStyleBackColor = false;
            this.viewSourceButton.Click += new System.EventHandler(this.ViewSourceButtonClicked);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.BackColor = System.Drawing.Color.White;
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.logOutButton.Location = new System.Drawing.Point(662, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(123, 38);
            this.logOutButton.TabIndex = 73;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            this.logOutButton.MouseLeave += new System.EventHandler(this.MenuButtonsMouseLeaving);
            this.logOutButton.MouseHover += new System.EventHandler(this.MenuButtonsMouseHovering);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackColor = System.Drawing.Color.ForestGreen;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(535, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(121, 38);
            this.settingsButton.TabIndex = 72;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // yearlyStatisticsButton
            // 
            this.yearlyStatisticsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearlyStatisticsButton.BackColor = System.Drawing.Color.White;
            this.yearlyStatisticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yearlyStatisticsButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.yearlyStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearlyStatisticsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyStatisticsButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.yearlyStatisticsButton.Location = new System.Drawing.Point(406, 12);
            this.yearlyStatisticsButton.Name = "yearlyStatisticsButton";
            this.yearlyStatisticsButton.Size = new System.Drawing.Size(123, 38);
            this.yearlyStatisticsButton.TabIndex = 71;
            this.yearlyStatisticsButton.Text = "Statistics";
            this.yearlyStatisticsButton.UseVisualStyleBackColor = false;
            this.yearlyStatisticsButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            this.yearlyStatisticsButton.MouseLeave += new System.EventHandler(this.MenuButtonsMouseLeaving);
            this.yearlyStatisticsButton.MouseHover += new System.EventHandler(this.MenuButtonsMouseHovering);
            // 
            // dailyReportButton
            // 
            this.dailyReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dailyReportButton.BackColor = System.Drawing.Color.White;
            this.dailyReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dailyReportButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.dailyReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyReportButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyReportButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.dailyReportButton.Location = new System.Drawing.Point(277, 12);
            this.dailyReportButton.Name = "dailyReportButton";
            this.dailyReportButton.Size = new System.Drawing.Size(123, 38);
            this.dailyReportButton.TabIndex = 70;
            this.dailyReportButton.Text = "Daily Report";
            this.dailyReportButton.UseVisualStyleBackColor = false;
            this.dailyReportButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            this.dailyReportButton.MouseLeave += new System.EventHandler(this.MenuButtonsMouseLeaving);
            this.dailyReportButton.MouseHover += new System.EventHandler(this.MenuButtonsMouseHovering);
            // 
            // addNewDataButton
            // 
            this.addNewDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewDataButton.BackColor = System.Drawing.Color.White;
            this.addNewDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewDataButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.addNewDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewDataButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewDataButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.addNewDataButton.Location = new System.Drawing.Point(148, 12);
            this.addNewDataButton.Name = "addNewDataButton";
            this.addNewDataButton.Size = new System.Drawing.Size(123, 38);
            this.addNewDataButton.TabIndex = 69;
            this.addNewDataButton.Text = "Add New";
            this.addNewDataButton.UseVisualStyleBackColor = false;
            this.addNewDataButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            this.addNewDataButton.MouseLeave += new System.EventHandler(this.MenuButtonsMouseLeaving);
            this.addNewDataButton.MouseHover += new System.EventHandler(this.MenuButtonsMouseHovering);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.BackColor = System.Drawing.Color.White;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.homeButton.Location = new System.Drawing.Point(10, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(132, 38);
            this.homeButton.TabIndex = 68;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            this.homeButton.MouseLeave += new System.EventHandler(this.MenuButtonsMouseLeaving);
            this.homeButton.MouseHover += new System.EventHandler(this.MenuButtonsMouseHovering);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.yearlyStatisticsButton);
            this.Controls.Add(this.dailyReportButton);
            this.Controls.Add(this.addNewDataButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.viewSourceButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.reportIssueButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitPasswordButton);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitUserNameButton);
            this.Controls.Add(this.confirmUserNameTextBox);
            this.Controls.Add(this.newUserNameTextBox);
            this.Controls.Add(this.currentUserNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameLaabel);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisFormClosing);
            this.Load += new System.EventHandler(this.ThisFormLoading);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userNameLaabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentUserNameTextBox;
        private System.Windows.Forms.TextBox newUserNameTextBox;
        private System.Windows.Forms.TextBox confirmUserNameTextBox;
        private System.Windows.Forms.Button submitUserNameButton;
        private System.Windows.Forms.Button submitPasswordButton;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reportIssueButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button viewSourceButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button yearlyStatisticsButton;
        private System.Windows.Forms.Button dailyReportButton;
        private System.Windows.Forms.Button addNewDataButton;
        private System.Windows.Forms.Button homeButton;
    }
}