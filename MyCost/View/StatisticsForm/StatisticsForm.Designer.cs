﻿namespace MyCost.View
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.MonthlyReportButton = new System.Windows.Forms.Button();
            this.AddNewDataButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.YearlyReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShowYearlyReportRadioButton = new System.Windows.Forms.RadioButton();
            this.ShowMonthlyReportRadioButton = new System.Windows.Forms.RadioButton();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.ShowEarningReportRadioButton = new System.Windows.Forms.RadioButton();
            this.ShowExpenseReportRadioButton = new System.Windows.Forms.RadioButton();
            this.ShowGeneralReportRadioButton = new System.Windows.Forms.RadioButton();
            this.ShowCategorywiseReportRadioButton = new System.Windows.Forms.RadioButton();
            this.ShowBothEarningAndExpenseReportRadioButton = new System.Windows.Forms.RadioButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.MonthlyReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RedButton = new System.Windows.Forms.Button();
            this.GrennButton = new System.Windows.Forms.Button();
            this.EarningLabel = new System.Windows.Forms.Label();
            this.ExpenseLabel = new System.Windows.Forms.Label();
            this.LogoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YearlyReportChart)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyReportChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutButton.BackColor = System.Drawing.Color.LimeGreen;
            this.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(710, 8);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(117, 33);
            this.LogOutButton.TabIndex = 52;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileButton.BackColor = System.Drawing.Color.LimeGreen;
            this.ProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.ForeColor = System.Drawing.Color.White;
            this.ProfileButton.Location = new System.Drawing.Point(588, 8);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(118, 33);
            this.ProfileButton.TabIndex = 51;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatisticsButton.BackColor = System.Drawing.Color.White;
            this.StatisticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StatisticsButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.StatisticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.StatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.StatisticsButton.Location = new System.Drawing.Point(463, 8);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(121, 33);
            this.StatisticsButton.TabIndex = 50;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = false;
            // 
            // MonthlyReportButton
            // 
            this.MonthlyReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthlyReportButton.BackColor = System.Drawing.Color.LimeGreen;
            this.MonthlyReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonthlyReportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.MonthlyReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthlyReportButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyReportButton.ForeColor = System.Drawing.Color.White;
            this.MonthlyReportButton.Location = new System.Drawing.Point(307, 8);
            this.MonthlyReportButton.Name = "MonthlyReportButton";
            this.MonthlyReportButton.Size = new System.Drawing.Size(152, 33);
            this.MonthlyReportButton.TabIndex = 49;
            this.MonthlyReportButton.Text = "Monthly Report";
            this.MonthlyReportButton.UseVisualStyleBackColor = false;
            this.MonthlyReportButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            // 
            // AddNewDataButton
            // 
            this.AddNewDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewDataButton.BackColor = System.Drawing.Color.LimeGreen;
            this.AddNewDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.AddNewDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewDataButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewDataButton.ForeColor = System.Drawing.Color.White;
            this.AddNewDataButton.Location = new System.Drawing.Point(188, 8);
            this.AddNewDataButton.Name = "AddNewDataButton";
            this.AddNewDataButton.Size = new System.Drawing.Size(115, 33);
            this.AddNewDataButton.TabIndex = 48;
            this.AddNewDataButton.Text = "Add New";
            this.AddNewDataButton.UseVisualStyleBackColor = false;
            this.AddNewDataButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton.BackColor = System.Drawing.Color.LimeGreen;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(67, 8);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(117, 33);
            this.HomeButton.TabIndex = 47;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            // 
            // YearlyReportChart
            // 
            this.YearlyReportChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearlyReportChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            this.YearlyReportChart.BorderlineColor = System.Drawing.Color.Gray;
            this.YearlyReportChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.YearlyReportChart.ChartAreas.Add(chartArea1);
            this.YearlyReportChart.Location = new System.Drawing.Point(12, 152);
            this.YearlyReportChart.Name = "YearlyReportChart";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "MaxPixelPointWidth=30";
            series1.EmptyPointStyle.Label = "jan";
            series1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.Name = "earning";
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "MaxPixelPointWidth=30";
            series2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsVisibleInLegend = false;
            series2.Name = "expense";
            this.YearlyReportChart.Series.Add(series1);
            this.YearlyReportChart.Series.Add(series2);
            this.YearlyReportChart.Size = new System.Drawing.Size(815, 327);
            this.YearlyReportChart.TabIndex = 53;
            // 
            // ShowYearlyReportRadioButton
            // 
            this.ShowYearlyReportRadioButton.AutoSize = true;
            this.ShowYearlyReportRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowYearlyReportRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ShowYearlyReportRadioButton.Location = new System.Drawing.Point(10, 8);
            this.ShowYearlyReportRadioButton.Name = "ShowYearlyReportRadioButton";
            this.ShowYearlyReportRadioButton.Size = new System.Drawing.Size(76, 25);
            this.ShowYearlyReportRadioButton.TabIndex = 54;
            this.ShowYearlyReportRadioButton.TabStop = true;
            this.ShowYearlyReportRadioButton.Text = "Yearly";
            this.ShowYearlyReportRadioButton.UseVisualStyleBackColor = true;
            this.ShowYearlyReportRadioButton.Click += new System.EventHandler(this.YearlyReportRadioButtonClicked);
            // 
            // ShowMonthlyReportRadioButton
            // 
            this.ShowMonthlyReportRadioButton.AutoSize = true;
            this.ShowMonthlyReportRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMonthlyReportRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ShowMonthlyReportRadioButton.Location = new System.Drawing.Point(10, 49);
            this.ShowMonthlyReportRadioButton.Name = "ShowMonthlyReportRadioButton";
            this.ShowMonthlyReportRadioButton.Size = new System.Drawing.Size(91, 25);
            this.ShowMonthlyReportRadioButton.TabIndex = 55;
            this.ShowMonthlyReportRadioButton.TabStop = true;
            this.ShowMonthlyReportRadioButton.Text = "Monthly";
            this.ShowMonthlyReportRadioButton.UseVisualStyleBackColor = true;
            this.ShowMonthlyReportRadioButton.Click += new System.EventHandler(this.MonthlyReportRadioButtonClicked);
            // 
            // YearComboBox
            // 
            this.YearComboBox.BackColor = System.Drawing.Color.White;
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(107, 7);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(170, 29);
            this.YearComboBox.TabIndex = 56;
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBoxSelectedIndexChanged);
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.BackColor = System.Drawing.Color.White;
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthComboBox.ForeColor = System.Drawing.Color.Black;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthComboBox.Location = new System.Drawing.Point(107, 47);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(170, 29);
            this.MonthComboBox.TabIndex = 57;
            this.MonthComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthComboBoxSelectedIndexChanged);
            // 
            // ShowEarningReportRadioButton
            // 
            this.ShowEarningReportRadioButton.AutoSize = true;
            this.ShowEarningReportRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEarningReportRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ShowEarningReportRadioButton.Location = new System.Drawing.Point(8, 7);
            this.ShowEarningReportRadioButton.Name = "ShowEarningReportRadioButton";
            this.ShowEarningReportRadioButton.Size = new System.Drawing.Size(126, 25);
            this.ShowEarningReportRadioButton.TabIndex = 58;
            this.ShowEarningReportRadioButton.TabStop = true;
            this.ShowEarningReportRadioButton.Text = "Earning Only";
            this.ShowEarningReportRadioButton.UseVisualStyleBackColor = true;
            this.ShowEarningReportRadioButton.Click += new System.EventHandler(this.ShowEarningReportRadioButtonClicked);
            // 
            // ShowExpenseReportRadioButton
            // 
            this.ShowExpenseReportRadioButton.AutoSize = true;
            this.ShowExpenseReportRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowExpenseReportRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ShowExpenseReportRadioButton.Location = new System.Drawing.Point(156, 7);
            this.ShowExpenseReportRadioButton.Name = "ShowExpenseReportRadioButton";
            this.ShowExpenseReportRadioButton.Size = new System.Drawing.Size(131, 25);
            this.ShowExpenseReportRadioButton.TabIndex = 59;
            this.ShowExpenseReportRadioButton.TabStop = true;
            this.ShowExpenseReportRadioButton.Text = "Expense Only";
            this.ShowExpenseReportRadioButton.UseVisualStyleBackColor = true;
            this.ShowExpenseReportRadioButton.Click += new System.EventHandler(this.ShowExpenseReportRadioButtonClicked);
            // 
            // ShowGeneralReportRadioButton
            // 
            this.ShowGeneralReportRadioButton.AutoSize = true;
            this.ShowGeneralReportRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGeneralReportRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ShowGeneralReportRadioButton.Location = new System.Drawing.Point(8, 4);
            this.ShowGeneralReportRadioButton.Name = "ShowGeneralReportRadioButton";
            this.ShowGeneralReportRadioButton.Size = new System.Drawing.Size(143, 25);
            this.ShowGeneralReportRadioButton.TabIndex = 60;
            this.ShowGeneralReportRadioButton.TabStop = true;
            this.ShowGeneralReportRadioButton.Text = "General report";
            this.ShowGeneralReportRadioButton.UseVisualStyleBackColor = true;
            this.ShowGeneralReportRadioButton.Click += new System.EventHandler(this.GeneralReportRadioButtonClicked);
            // 
            // ShowCategorywiseReportRadioButton
            // 
            this.ShowCategorywiseReportRadioButton.AutoSize = true;
            this.ShowCategorywiseReportRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCategorywiseReportRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ShowCategorywiseReportRadioButton.Location = new System.Drawing.Point(156, 4);
            this.ShowCategorywiseReportRadioButton.Name = "ShowCategorywiseReportRadioButton";
            this.ShowCategorywiseReportRadioButton.Size = new System.Drawing.Size(193, 25);
            this.ShowCategorywiseReportRadioButton.TabIndex = 61;
            this.ShowCategorywiseReportRadioButton.TabStop = true;
            this.ShowCategorywiseReportRadioButton.Text = "Category-wise report";
            this.ShowCategorywiseReportRadioButton.UseVisualStyleBackColor = true;
            this.ShowCategorywiseReportRadioButton.Click += new System.EventHandler(this.CategorywiseReportRadioButton);
            // 
            // ShowBothEarningAndExpenseReportRadioButton
            // 
            this.ShowBothEarningAndExpenseReportRadioButton.AutoSize = true;
            this.ShowBothEarningAndExpenseReportRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBothEarningAndExpenseReportRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ShowBothEarningAndExpenseReportRadioButton.Location = new System.Drawing.Point(298, 7);
            this.ShowBothEarningAndExpenseReportRadioButton.Name = "ShowBothEarningAndExpenseReportRadioButton";
            this.ShowBothEarningAndExpenseReportRadioButton.Size = new System.Drawing.Size(231, 25);
            this.ShowBothEarningAndExpenseReportRadioButton.TabIndex = 62;
            this.ShowBothEarningAndExpenseReportRadioButton.TabStop = true;
            this.ShowBothEarningAndExpenseReportRadioButton.Text = "Both Earning and Expense";
            this.ShowBothEarningAndExpenseReportRadioButton.UseVisualStyleBackColor = true;
            this.ShowBothEarningAndExpenseReportRadioButton.Click += new System.EventHandler(this.BothEarningAndExpenseRadionButtonClicked);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.MonthComboBox);
            this.Panel1.Controls.Add(this.YearComboBox);
            this.Panel1.Controls.Add(this.ShowMonthlyReportRadioButton);
            this.Panel1.Controls.Add(this.ShowYearlyReportRadioButton);
            this.Panel1.Location = new System.Drawing.Point(12, 56);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(282, 90);
            this.Panel1.TabIndex = 63;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.ShowBothEarningAndExpenseReportRadioButton);
            this.Panel2.Controls.Add(this.ShowExpenseReportRadioButton);
            this.Panel2.Controls.Add(this.ShowEarningReportRadioButton);
            this.Panel2.Location = new System.Drawing.Point(300, 56);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(527, 42);
            this.Panel2.TabIndex = 64;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.ShowCategorywiseReportRadioButton);
            this.Panel3.Controls.Add(this.ShowGeneralReportRadioButton);
            this.Panel3.Location = new System.Drawing.Point(300, 105);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(406, 41);
            this.Panel3.TabIndex = 65;
            // 
            // MonthlyReportChart
            // 
            this.MonthlyReportChart.BorderlineColor = System.Drawing.Color.Gray;
            this.MonthlyReportChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.MonthlyReportChart.ChartAreas.Add(chartArea2);
            this.MonthlyReportChart.Location = new System.Drawing.Point(12, 152);
            this.MonthlyReportChart.Name = "MonthlyReportChart";
            this.MonthlyReportChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Name = "earning";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Name = "expense";
            this.MonthlyReportChart.Series.Add(series3);
            this.MonthlyReportChart.Series.Add(series4);
            this.MonthlyReportChart.Size = new System.Drawing.Size(815, 327);
            this.MonthlyReportChart.TabIndex = 66;
            this.MonthlyReportChart.Visible = false;
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.YellowGreen;
            this.RedButton.Enabled = false;
            this.RedButton.FlatAppearance.BorderSize = 0;
            this.RedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedButton.Location = new System.Drawing.Point(719, 104);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(28, 18);
            this.RedButton.TabIndex = 67;
            this.RedButton.UseVisualStyleBackColor = false;
            // 
            // GrennButton
            // 
            this.GrennButton.BackColor = System.Drawing.Color.OrangeRed;
            this.GrennButton.Enabled = false;
            this.GrennButton.FlatAppearance.BorderSize = 0;
            this.GrennButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrennButton.Location = new System.Drawing.Point(719, 128);
            this.GrennButton.Name = "GrennButton";
            this.GrennButton.Size = new System.Drawing.Size(28, 18);
            this.GrennButton.TabIndex = 68;
            this.GrennButton.UseVisualStyleBackColor = false;
            // 
            // EarningLabel
            // 
            this.EarningLabel.AutoSize = true;
            this.EarningLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EarningLabel.Location = new System.Drawing.Point(753, 101);
            this.EarningLabel.Name = "EarningLabel";
            this.EarningLabel.Size = new System.Drawing.Size(69, 21);
            this.EarningLabel.TabIndex = 69;
            this.EarningLabel.Text = "Earning";
            // 
            // ExpenseLabel
            // 
            this.ExpenseLabel.AutoSize = true;
            this.ExpenseLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseLabel.ForeColor = System.Drawing.Color.Black;
            this.ExpenseLabel.Location = new System.Drawing.Point(753, 125);
            this.ExpenseLabel.Name = "ExpenseLabel";
            this.ExpenseLabel.Size = new System.Drawing.Size(74, 21);
            this.ExpenseLabel.TabIndex = 70;
            this.ExpenseLabel.Text = "Expense";
            // 
            // LogoButton
            // 
            this.LogoButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoButton.BackgroundImage = global::MyCost.Properties.Resources.AppIcon;
            this.LogoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.LogoButton.FlatAppearance.BorderSize = 0;
            this.LogoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoButton.ForeColor = System.Drawing.Color.White;
            this.LogoButton.Location = new System.Drawing.Point(12, 8);
            this.LogoButton.Name = "LogoButton";
            this.LogoButton.Size = new System.Drawing.Size(49, 33);
            this.LogoButton.TabIndex = 71;
            this.LogoButton.UseVisualStyleBackColor = false;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 491);
            this.Controls.Add(this.LogoButton);
            this.Controls.Add(this.ExpenseLabel);
            this.Controls.Add(this.EarningLabel);
            this.Controls.Add(this.GrennButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.MonthlyReportChart);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.YearlyReportChart);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.StatisticsButton);
            this.Controls.Add(this.MonthlyReportButton);
            this.Controls.Add(this.AddNewDataButton);
            this.Controls.Add(this.HomeButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyCost - Earning and Expense Statistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisFormClosing);
            this.Load += new System.EventHandler(this.ThisFormLoading);
            ((System.ComponentModel.ISupportInitialize)(this.YearlyReportChart)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyReportChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button StatisticsButton;
        private System.Windows.Forms.Button MonthlyReportButton;
        private System.Windows.Forms.Button AddNewDataButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart YearlyReportChart;
        private System.Windows.Forms.RadioButton ShowYearlyReportRadioButton;
        private System.Windows.Forms.RadioButton ShowMonthlyReportRadioButton;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.RadioButton ShowEarningReportRadioButton;
        private System.Windows.Forms.RadioButton ShowExpenseReportRadioButton;
        private System.Windows.Forms.RadioButton ShowGeneralReportRadioButton;
        private System.Windows.Forms.RadioButton ShowCategorywiseReportRadioButton;
        private System.Windows.Forms.RadioButton ShowBothEarningAndExpenseReportRadioButton;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthlyReportChart;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button GrennButton;
        private System.Windows.Forms.Label EarningLabel;
        private System.Windows.Forms.Label ExpenseLabel;
        private System.Windows.Forms.Button LogoButton;
    }
}