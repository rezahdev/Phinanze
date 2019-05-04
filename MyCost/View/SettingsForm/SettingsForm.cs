﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using MyCost.Common;
using MyCost.Common.WebHandler;

namespace MyCost.View
{
    public partial class SettingsForm : Form
    {
        private bool _quitAppOnFormClosing;

        public SettingsForm()
        {
            InitializeComponent();

            _quitAppOnFormClosing = true;
        }

        private void ThisFormLoading(object sender, EventArgs e)
        {
            UserNameLaabel.Text = "username: " + GlobalSpace.Username;
        }

        private void UsernameTextBoxesClicked(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.ForeColor != Color.Black)
            {
                //remove the placeholder
                tb.ForeColor = Color.Black;
                tb.Text = "";

                if(tb.Name == "passwordTextBox")
                {
                    tb.PasswordChar = '*';
                }
            }
        }

        private void UserNameTextBoxesTextChanged(object sender, EventArgs e)
        {
            if (CurrentUserNameTextBox.ForeColor == Color.Black
                && CurrentUserNameTextBox.Text != ""
                && NewUserNameTextBox.ForeColor == Color.Black
                && NewUserNameTextBox.Text != ""
                && PasswordTextBox.ForeColor == Color.Black
                && PasswordTextBox.Text != "")
            {
                UpdateUsernameButton.Enabled = true;
            }
            else
            {
                UpdateUsernameButton.Enabled = false;
            }
        }

        private void PasswordTextBoxesClicked(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if(tb.ForeColor != Color.Black)
            {
                tb.ForeColor = Color.Black;
                tb.Text = "";
                tb.PasswordChar = '*';
            }
        }

        private void PasswordTextBoxesTextChanged(object sender, EventArgs e)
        {
            if (CurrentPasswordTextBox.ForeColor == Color.Black
               && CurrentPasswordTextBox.Text != ""
               && NewPasswordTextBox.ForeColor == Color.Black
               && NewPasswordTextBox.Text != ""
               && ConfirmPasswordTextBox.ForeColor == Color.Black
               && ConfirmPasswordTextBox.Text != "")
            {
                UpdatePasswordButton.Enabled = true;
            }
            else
            {
                UpdatePasswordButton.Enabled = false;
            }
        }

        private void SubmitNewUsernameButtonClicked(object sender, EventArgs e)
        {
            if (CurrentUserNameTextBox.Text != GlobalSpace.Username)
            {
                MessageBox.Show("Current username is incorrect");
                return;
            }

            string result = WebHandler.UpdateUsername(NewUserNameTextBox.Text, PasswordTextBox.Text);

            if (result == "SUCCESS")
            {
                 //log out user from the current session                    
                 GlobalSpace.LogOutUser();
                 _quitAppOnFormClosing = false;
                 this.Close();
            }
            else
            {
                 //if the update doesn't succeed, the error message is returned
                 MessageBox.Show(result);
            }
        }

        private void SubmitNewPasswordButtonClicked(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password doesn't match!");
            }
            else //all fields are correct
            {
                string result = WebHandler.UpdatePassword(CurrentPasswordTextBox.Text, NewPasswordTextBox.Text);

                if (result == "SUCCESS")
                {
                    //log out user from the current session                   
                    GlobalSpace.LogOutUser();
                    _quitAppOnFormClosing = false;
                    this.Close();
                }
                else
                {
                    //if the update doesn't succeed, error message is returned
                    MessageBox.Show(result);
                }
            }
        }

        private void MenuButtonsMouseHovering(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.ForestGreen;
            button.ForeColor = Color.White;
        }

        private void MenuButtonsMouseLeaving(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.White;
            button.ForeColor = Color.ForestGreen;
        }

        private void MenuButtonsClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "HomeButton")
            {
                OpenNewForm(new MainForm());
            }
            else if (button.Name == "MonthlyReportButton")
            {
                OpenNewForm(new MonthlyReportForm());
            }
            else if (button.Name == "StatisticsButton")
            {
                OpenNewForm(new StatisticsForm());
            }
            else if (button.Name == "AddNewDataButton")
            {
                OpenNewForm(new AddNewDataForm());
            }
            else if (button.Name == "LogOutButton")
            {
                GlobalSpace.LogOutUser();
                _quitAppOnFormClosing = false;
                this.Close();
            }
        }

        new private void HelpButtonClicked(object sender, EventArgs e)
        {
            try
            {
                Process.Start(GlobalSpace.HelpPath);
            }
            catch
            {
                MessageBox.Show("Could not open default browser!");
            }
        }

        private void ReportIssueButtonClicked(object sender, EventArgs e)
        {
            try
            {
                Process.Start(GlobalSpace.ReportAppPath);
            }
            catch
            {
                MessageBox.Show("Could not open the default browser!");
            }
        }

        private void AboutAppButtonClicked(object sender, EventArgs e)
        {
            try
            {
                Process.Start(GlobalSpace.AboutAppPath);
            }
            catch
            {
                MessageBox.Show("Could not open the default browser!");
            }
        }

        private void ThisFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_quitAppOnFormClosing)
            {
                Application.Exit();
            }
        }

        private void OpenNewForm(Form form)
        {
            form.Location = this.Location;
            form.Show();

            _quitAppOnFormClosing = false;
            this.Close();
        }
    }
}
