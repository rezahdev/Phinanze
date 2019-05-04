﻿using System;
using System.Drawing;
using System.Windows.Forms;
using MyCost.Common;
using MyCost.Common.WebHandler;

namespace MyCost.View
{
    public partial class UserAuthenticationForm : Form
    {
        private bool _quitAppOnFormClosing;

        private WebHandler _webHandlerObject;
        private ProgressViewerForm _progressViewerObject;

        private delegate void UserAuthenticationDelegate();
        private delegate void UserRegistrationDelegate();
        private delegate void FetchDailyInfoDelegate();
        private delegate void FetchCategoriesDelegate();

        public UserAuthenticationForm()
        {
            InitializeComponent();

            _quitAppOnFormClosing = true;
        }

        #region UI EventHandler Methods

        private void ThisFormLoading(object sender, EventArgs e)
        {
            DisplayLoginPanel();
        }

        private void ThisFormShown(object sender, EventArgs e)
        {
            string username = Properties.Settings.Default.Username;
            string password = Properties.Settings.Default.Password;

            //if the user opted to auto login by checking the remmeberMeCheckBox 
            if (username != "" && password != "")
            {
                //make the text color black so that the login method 
                //doesn't detect the texts as placeholder texts
                UsernameTextBox.ForeColor = Color.Black;
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.PasswordChar = '*';

                //fills the username and password field with pre-saved info
                UsernameTextBox.Text = Properties.Settings.Default.Username;
                PasswordTextBox.Text = Properties.Settings.Default.Password;

                //attempt login
                SubmitButton.PerformClick();
            }
        }

        private void ShowRegisterPanelButtonClicked(object sender, EventArgs e)
        {
            DisplayRegisterPanel();
        }

        private void ShowLoginPanelButoonClicked(object sender, EventArgs e)
        {
            DisplayLoginPanel();
        }

        private void UsernameTextBoxClicked(object sender, MouseEventArgs e)
        {
            if (UsernameTextBox.ForeColor != Color.Black)
            {
                //remove the placeholder
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordTextboxClicked(object sender, MouseEventArgs e)
        {
            if (PasswordTextBox.ForeColor != Color.Black)
            {
                //remove the placeholder
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void ConfirmPasswordTextBoxClicked(object sender, MouseEventArgs e)
        {
            if (ConfirmPasswordTextBox.ForeColor != Color.Black)
            {
                //remove the placeholder
                ConfirmPasswordTextBox.Text = "";
                ConfirmPasswordTextBox.ForeColor = Color.Black;
                ConfirmPasswordTextBox.PasswordChar = '*';
            }
        }

        private void ActivationCodeTextBoxClicked(object sender, MouseEventArgs e)
        {
            if(ActivationCodeTextBox.ForeColor != Color.Black)
            {
                //remove the placeholder
                ActivationCodeTextBox.Text = "";
                ActivationCodeTextBox.ForeColor = Color.Black;
            }
        }

        private void SubmitButtonClicked(object sender, EventArgs e)
        {          
            if (SubmitButton.Text == "Log in")
            {
                LoginUser();
            }
            else
            {
                RegisterUser();
            }
        }                    

        private void ThisFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_quitAppOnFormClosing)
            {
                Application.Exit();
            }
        }
        #endregion

        #region General Private Methods

        private void DisplayLoginPanel()
        {
            //reset everything so the panel appears as a login form 
            ShowRegisterPanelButton.BackColor = Color.RoyalBlue;
            ShowRegisterPanelButton.ForeColor = Color.White;
            ShowLoginPanelButton.BackColor = Color.White;
            ShowLoginPanelButton.ForeColor = Color.Black;

            SubmitButton.Text = "Log in";
            SubmitButton.Location = new Point(280, 280);

            ConfirmPasswordTextBox.Visible = false;
            ConfirmPasswordTextBox.Enabled = false;
            ActivationCodeTextBox.Visible = false;
            ActivationCodeTextBox.Enabled = false;

            RememberMeCheckBox.Location = new Point(146, 250);
            this.Size = new Size(800, 410);

            ResetTextBoxProperties();
        }

        private void DisplayRegisterPanel()
        {
            //reset everything so the panel appears as a register form
            ShowRegisterPanelButton.BackColor = Color.White;
            ShowRegisterPanelButton.ForeColor = Color.Black;
            ShowLoginPanelButton.BackColor = Color.RoyalBlue;
            ShowLoginPanelButton.ForeColor = Color.White;

            SubmitButton.Text = "Register";
            SubmitButton.Location = new Point(280, 368);

            ConfirmPasswordTextBox.Visible = true;
            ConfirmPasswordTextBox.Enabled = true;
            ActivationCodeTextBox.Visible = true;
            ActivationCodeTextBox.Enabled = true;

            RememberMeCheckBox.Location = new Point(146, 343);
            this.Size = new Size(800, 465);

            ResetTextBoxProperties();
        }

        private void ResetTextBoxProperties()
        {
            //reset the placeholders in the TextBoxes
            StatusLabel.Text = "";
            UsernameTextBox.Text = "Username";
            UsernameTextBox.ForeColor = Color.DarkGray;
            PasswordTextBox.Text = "Password";
            PasswordTextBox.ForeColor = Color.DarkGray;
            PasswordTextBox.PasswordChar = '\0';
            ConfirmPasswordTextBox.Text = "Confirm Password";
            ConfirmPasswordTextBox.ForeColor = Color.DarkGray;
            ConfirmPasswordTextBox.PasswordChar = '\0';
            ActivationCodeTextBox.Text = "Activation Code";
            ActivationCodeTextBox.ForeColor = Color.DarkGray;
        }

        private void LoginUser()
        {
            //if fore-color of a textBox is not black, that means the textbox 
            //contains the placeholder text and user didn't enter any value
            string username = UsernameTextBox.ForeColor == Color.Black?
                UsernameTextBox.Text : "";
            string password = PasswordTextBox.ForeColor == Color.Black?
                PasswordTextBox.Text : "";

            if(username.Length < 1)
            {
                ShowErrorMessage("Please enter username.");
                return;
            }
            else if(password.Length < 1)
            {
                ShowErrorMessage("Please enter password.");
                return;
            }

            //disable all controls so that the user cannot
            //change anything until the login process ends
            DisableAllControls();

            //show progress bar
            string status = "Verifying your login credentials, please wait...";
            ProgressViewerForm progressViewer = new ProgressViewerForm(status);
            progressViewer.Location = new Point(this.Location.X + 70, this.Location.Y + 100);
            progressViewer.Show();
            _progressViewerObject = progressViewer;

            //send web request to verify user's login credentials
            WebHandler webRequest = new WebHandler();
            webRequest.WebRequestSuccessEventHandler += OnLoginSuccess;
            webRequest.WebRequestFailedEventHandler += OnLoginFailed;
            _webHandlerObject = webRequest;
            webRequest.AuthenticateUser(username, password);           
        }

        private void OnLoginSuccess(object sender, EventArgs e)
        {
            this.Invoke(new UserAuthenticationDelegate(ActionUponLoginSuccess), new object[] { });
        }

        private void OnLoginFailed(object sender, EventArgs e)
        {
            this.Invoke(new UserAuthenticationDelegate(ActionUponLoginFailed), new object[] { });
        }

        private void ActionUponLoginSuccess()
        {
            string result = _webHandlerObject.Response;

            string[] data = result.Split('|');

            //if the login succeeds, 
            //user's id and a temporary access token are returned
            //otherwise, the error message is returned
            if (int.TryParse(data[0], out int userId))
            {
                GlobalSpace.UserID = Convert.ToInt16(data[0]);
                GlobalSpace.AccessToken = data[1];
                GlobalSpace.Username = UsernameTextBox.Text;

                if (RememberMeCheckBox.Checked)
                {
                    Properties.Settings.Default.Username = UsernameTextBox.Text;
                    Properties.Settings.Default.Password = PasswordTextBox.Text;
                    Properties.Settings.Default.Save();
                }

                //get daily info of this user from database
                FetchDailyInfo();
            }
            else
            {
                _progressViewerObject.StopProgress();
                ShowErrorMessage(result);

                //enable all controls so that the user can attempt to login again
                EnableAllControls();
            }
        }

        private void ActionUponLoginFailed()
        {
            _progressViewerObject.StopProgress();
            ShowErrorMessage("Server connection error. Please check your internet connection.");

            //enable all controls so that the user can attempt to login again
            EnableAllControls();      
        }

        private void RegisterUser()
        {
            //if fore-color of a textBox is not black, that means the TextBox 
            //contains the placeholder text and user didn't enter any value
            string username = UsernameTextBox.ForeColor == Color.Black? 
                UsernameTextBox.Text : "";
            string password = PasswordTextBox.ForeColor == Color.Black?
                PasswordTextBox.Text : "";
            string confirmPassword = ConfirmPasswordTextBox.ForeColor == Color.Black?
                ConfirmPasswordTextBox.Text : "";
            string activationCode = ActivationCodeTextBox.ForeColor == Color.Black ?
                ActivationCodeTextBox.Text : "";

            if (username.Length < 1)
            {
                ShowErrorMessage("Please enter a username.");
                return;
            }
            else if (password.Length < 1)
            {
                ShowErrorMessage("Please enter a password.");
                return;
            }
            else if (confirmPassword != password)
            {
                ShowErrorMessage("Password does not match.");
                return;
            }
            else if(activationCode.Length < 1)
            {
                ShowErrorMessage("Please enter the activation code.");
                return;
            }

            //disable all controls so that the user cannot change
            //anything until the registration process ends
            DisableAllControls();

            //show progress bar
            string status = "Creating your account, please wait...";
            ProgressViewerForm progressViewer = new ProgressViewerForm(status);
            progressViewer.Location = new Point(this.Location.X + 70, this.Location.Y + 200);
            progressViewer.Show();
            _progressViewerObject = progressViewer;

            //send web request to create new user account
            WebHandler webRequest = new WebHandler();
            webRequest.WebRequestSuccessEventHandler += OnRegisterSuccess;
            webRequest.WebRequestFailedEventHandler += OnRegisterFailed;
            _webHandlerObject = webRequest;
            webRequest.RegisterNewUser(username, password, activationCode);
        }

        private void OnRegisterSuccess(object sender, EventArgs e)
        {
            this.Invoke(new UserRegistrationDelegate(ActionUponLoginSuccess), new object[] { });
        }

        private void OnRegisterFailed(object sender, EventArgs e)
        {
            this.Invoke(new UserRegistrationDelegate(ActionUponLoginFailed), new object[] { });
        }

        private void ActionUponRegisterSuccess()
        {
            string result = _webHandlerObject.Response;

            string[] data = result.Split('|');

            //if the registration process succeeds, 
            //user's id and a temporary access token are retured
            //otherwise, the error message is returned
            if (int.TryParse(data[0], out int userId))
            {
                GlobalSpace.UserID = userId;
                GlobalSpace.AccessToken = data[1];
                GlobalSpace.Username = UsernameTextBox.Text;

                if (RememberMeCheckBox.Checked)
                {
                    Properties.Settings.Default.Username = UsernameTextBox.Text;
                    Properties.Settings.Default.Password = PasswordTextBox.Text;
                    Properties.Settings.Default.Save();
                }

                //get daily info of this user from database
                FetchDailyInfo();
            }
            else
            {
                _progressViewerObject.StopProgress();
                ShowErrorMessage(result);

                //enable all controls so that the user can attempt to login again
                EnableAllControls();               
            }
        }

        private void ActionUponRegisterFailed()
        {
            _progressViewerObject.StopProgress();
            ShowErrorMessage("Server connection error. Please check your internet connection.");

            //enable all controls so that the user can attempt to login again
            EnableAllControls();           
        }

        private void FetchDailyInfo()
        {
            string status = "Fetching daily information from database, please wait...";
            _progressViewerObject.UpdateStatus(status);

            //get daily expenses and earnings from database
            WebHandler webRequest = new WebHandler();
            webRequest.WebRequestSuccessEventHandler += OnFetchDailyInfoSuccess;
            webRequest.WebRequestFailedEventHandler += OnFetchDailyInfoFailed;
            _webHandlerObject = webRequest;
            webRequest.RetrieveDailyInfo();         
        }

        private void OnFetchDailyInfoSuccess(object sender, EventArgs e)
        {
            this.Invoke(new FetchDailyInfoDelegate(ActionUponFetchDailyInfoSuccess), new object[] { });
        }

        private void OnFetchDailyInfoFailed(object  sender, EventArgs e)
        {
            this.Invoke(new FetchDailyInfoDelegate(ActionUponFetchDailyInfoFailed), new object[] { });
        }

        private void ActionUponFetchDailyInfoSuccess()
        {                  
            string result = _webHandlerObject.Response;

            string[] rows = result.Split('^');

            if (rows[0] == "Server connection error")
            {
                //some server error occurred
                _progressViewerObject.StopProgress();
                ShowErrorMessage("Server connection error. Please check your internet connection.");             
                return;
            }

            //start fetching categories from database on a seperate thread
            //before starting to process the fetched daily info
            FetchCategories();

            if (rows[0] == "")
            {
                //no daily info found for this user in database
                //so no need to process the info
                return;
            }

            //process the fetched daily info and store them in StaticStorage class
            foreach (string row in rows)
            {
                string[] cols = row.Split('|');

                int day = Convert.ToInt16(cols[0]);
                int month = Convert.ToInt16(cols[1]);
                int year = Convert.ToInt32(cols[2]);

                string note = cols[3];
                string[] expenseReasons = cols[4].Split('~');
                string[] expenseAmounts = cols[5].Split('~');
                string[] expenseCategories = cols[6].Split('~');
                string[] expenseComments = cols[7].Split('~');
                string[] earningSources = cols[8].Split('~');
                string[] earningAmounts = cols[9].Split('~');
                string[] earningCategories = cols[10].Split('~');
                string[] earningComments = cols[11].Split('~');
                string totalExpense = cols[12];
                string totalEarning = cols[13];

                DailyInfo daily = new DailyInfo
                {
                    Day = day,
                    Month = month,
                    Year = year,
                    Note = note,
                    TotalEarning = Convert.ToDouble(totalEarning),
                    TotalExpense = Convert.ToDouble(totalExpense)
                };

                if (expenseAmounts[0] != "")
                {
                    for (int i = 0; i < expenseReasons.Length; i++)
                    {
                        double amount = Convert.ToDouble(expenseAmounts[i]);
                        string reason = expenseReasons[i];
                        string category = expenseCategories[i];
                        string comment = expenseComments[i];

                        ExpenseInfo expense = new ExpenseInfo
                        {
                            Reason = reason,
                            Amount = amount,
                            Category = category,
                            Comment = comment
                        };
                        daily.ExpenseList.Add(expense);
                    }
                }

                if (earningAmounts[0] != "")
                {
                    for (int i = 0; i < earningSources.Length; i++)
                    {
                        double amount = Convert.ToDouble(earningAmounts[i]);
                        string source = earningSources[i];
                        string category = earningCategories[i];
                        string comment = earningComments[i];

                        EarningInfo earning = new EarningInfo
                        {
                            Source = source,
                            Amount = amount,
                            Category = category,
                            Comment = comment
                        };
                        daily.EarningList.Add(earning);
                    }
                }
                GlobalSpace.DailyInfoList.Add(daily);
            }
        }

        private void ActionUponFetchDailyInfoFailed()
        {
            _progressViewerObject.StopProgress();
            ShowErrorMessage("Server connection error. Please check your internet connection.");
        }

        private void FetchCategories()
        {
            string status = "Fetching categories from database, please wait...";
            _progressViewerObject.UpdateStatus(status);

            //get all categories made by user from the database
            WebHandler webRequest = new WebHandler();
            webRequest.WebRequestSuccessEventHandler += OnFetchCategoriesSuccess;
            webRequest.WebRequestFailedEventHandler += OnFetchCategoriesFailed;
            _webHandlerObject = webRequest;
            webRequest.RetrieveCategories();
        }

        private void OnFetchCategoriesSuccess(object sender, EventArgs e)
        {
            this.Invoke(new FetchCategoriesDelegate(ActionUponFetchCategoriesSuccess), new object[] { });
        }

        private void OnFetchCategoriesFailed(object sender, EventArgs e)
        {
            this.Invoke(new FetchCategoriesDelegate(ActionUponFetchCategoriesFailed), new object[] { });
        }

        private void ActionUponFetchCategoriesSuccess()
        {
            string result = _webHandlerObject.Response;

            if (result == "Server connection error")
            {
                //some server error occurred
                _progressViewerObject.StopProgress();
                ShowErrorMessage("Server connection error. Please check your internet connect.");
                return;
            }

            string[] earningCategories = result.Split('^')[0].Split('|');
            string[] expenseCategories = result.Split('^')[1].Split('|');

            foreach (string cat in earningCategories)
            {
                GlobalSpace.EarningCategories.Add(cat);
            }

            foreach (string cat in expenseCategories)
            {
                GlobalSpace.ExpenseCategories.Add(cat);
            }

            _progressViewerObject.StopProgress();

            MainForm form = new MainForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();

            _quitAppOnFormClosing = false;
            this.Close();
        }

        private void ActionUponFetchCategoriesFailed()
        {
            _progressViewerObject.StopProgress();
            ShowErrorMessage("Server connection error. Please check your internet connection.");
        }

        private void EnableAllControls()
        {
            foreach(Control control in this.Controls)
            {
                control.Enabled = true;
            }
        }

        private void DisableAllControls()
        {
            foreach(Control control in this.Controls)
            {
                if (control.Name != "appLogoLabel")
                {
                    control.Enabled = false;
                }
            }
        }

        private void ShowErrorMessage(string message)
        {
            StatusLabel.Text = message;
            StatusLabel.ForeColor = Color.Red;
        }
        #endregion
    }
}
