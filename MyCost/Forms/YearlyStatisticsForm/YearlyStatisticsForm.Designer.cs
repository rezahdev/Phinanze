﻿namespace MyCost.Forms
{
    partial class YearlyStatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearlyStatisticsForm));
            this.logOutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.yearlyStatisticsButton = new System.Windows.Forms.Button();
            this.dailyReportButton = new System.Windows.Forms.Button();
            this.addNewDataButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.yearlyReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yearlyRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.earningRadioButton = new System.Windows.Forms.RadioButton();
            this.expenseRadioButton = new System.Windows.Forms.RadioButton();
            this.generalReportRadioButton = new System.Windows.Forms.RadioButton();
            this.categorywiseReportRadioButton = new System.Windows.Forms.RadioButton();
            this.bothEarningAndExpenseRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.monthlyReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyReportChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyReportChart)).BeginInit();
            this.SuspendLayout();
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
            this.logOutButton.Location = new System.Drawing.Point(664, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(123, 38);
            this.logOutButton.TabIndex = 52;
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
            this.settingsButton.BackColor = System.Drawing.Color.White;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.settingsButton.Location = new System.Drawing.Point(537, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(123, 38);
            this.settingsButton.TabIndex = 51;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            this.settingsButton.MouseLeave += new System.EventHandler(this.MenuButtonsMouseLeaving);
            this.settingsButton.MouseHover += new System.EventHandler(this.MenuButtonsMouseHovering);
            // 
            // yearlyStatisticsButton
            // 
            this.yearlyStatisticsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearlyStatisticsButton.BackColor = System.Drawing.Color.ForestGreen;
            this.yearlyStatisticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yearlyStatisticsButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.yearlyStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearlyStatisticsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyStatisticsButton.ForeColor = System.Drawing.Color.White;
            this.yearlyStatisticsButton.Location = new System.Drawing.Point(408, 12);
            this.yearlyStatisticsButton.Name = "yearlyStatisticsButton";
            this.yearlyStatisticsButton.Size = new System.Drawing.Size(123, 38);
            this.yearlyStatisticsButton.TabIndex = 50;
            this.yearlyStatisticsButton.Text = "Statistics";
            this.yearlyStatisticsButton.UseVisualStyleBackColor = false;
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
            this.dailyReportButton.Location = new System.Drawing.Point(279, 12);
            this.dailyReportButton.Name = "dailyReportButton";
            this.dailyReportButton.Size = new System.Drawing.Size(123, 38);
            this.dailyReportButton.TabIndex = 49;
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
            this.addNewDataButton.Location = new System.Drawing.Point(150, 12);
            this.addNewDataButton.Name = "addNewDataButton";
            this.addNewDataButton.Size = new System.Drawing.Size(123, 38);
            this.addNewDataButton.TabIndex = 48;
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
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(132, 38);
            this.homeButton.TabIndex = 47;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            this.homeButton.MouseLeave += new System.EventHandler(this.MenuButtonsMouseLeaving);
            this.homeButton.MouseHover += new System.EventHandler(this.MenuButtonsMouseHovering);
            // 
            // yearlyReportChart
            // 
            this.yearlyReportChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearlyReportChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.yearlyReportChart.ChartAreas.Add(chartArea3);
            this.yearlyReportChart.Location = new System.Drawing.Point(12, 152);
            this.yearlyReportChart.Name = "yearlyReportChart";
            series5.ChartArea = "ChartArea1";
            series5.CustomProperties = "MaxPixelPointWidth=30";
            series5.EmptyPointStyle.Label = "jan";
            series5.IsVisibleInLegend = false;
            series5.Name = "earning";
            series6.ChartArea = "ChartArea1";
            series6.CustomProperties = "MaxPixelPointWidth=30";
            series6.IsVisibleInLegend = false;
            series6.Name = "expense";
            this.yearlyReportChart.Series.Add(series5);
            this.yearlyReportChart.Series.Add(series6);
            this.yearlyReportChart.Size = new System.Drawing.Size(776, 323);
            this.yearlyReportChart.TabIndex = 53;
            // 
            // yearlyRadioButton
            // 
            this.yearlyRadioButton.AutoSize = true;
            this.yearlyRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyRadioButton.ForeColor = System.Drawing.Color.Black;
            this.yearlyRadioButton.Location = new System.Drawing.Point(10, 15);
            this.yearlyRadioButton.Name = "yearlyRadioButton";
            this.yearlyRadioButton.Size = new System.Drawing.Size(67, 22);
            this.yearlyRadioButton.TabIndex = 54;
            this.yearlyRadioButton.TabStop = true;
            this.yearlyRadioButton.Text = "Yearly";
            this.yearlyRadioButton.UseVisualStyleBackColor = true;
            this.yearlyRadioButton.Click += new System.EventHandler(this.YearlyRadioButtonClicked);
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyRadioButton.ForeColor = System.Drawing.Color.Black;
            this.monthlyRadioButton.Location = new System.Drawing.Point(10, 49);
            this.monthlyRadioButton.Name = "monthlyRadioButton";
            this.monthlyRadioButton.Size = new System.Drawing.Size(78, 22);
            this.monthlyRadioButton.TabIndex = 55;
            this.monthlyRadioButton.TabStop = true;
            this.monthlyRadioButton.Text = "Monthly";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            this.monthlyRadioButton.Click += new System.EventHandler(this.MonthlyRadioButtonClicked);
            // 
            // yearComboBox
            // 
            this.yearComboBox.BackColor = System.Drawing.Color.White;
            this.yearComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(94, 9);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(150, 28);
            this.yearComboBox.TabIndex = 56;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBoxSelectedIndexChanged);
            // 
            // monthComboBox
            // 
            this.monthComboBox.BackColor = System.Drawing.Color.White;
            this.monthComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox.ForeColor = System.Drawing.Color.Black;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
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
            this.monthComboBox.Location = new System.Drawing.Point(94, 49);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(150, 28);
            this.monthComboBox.TabIndex = 57;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthComboBoxSelectedIndexChanged);
            // 
            // earningRadioButton
            // 
            this.earningRadioButton.AutoSize = true;
            this.earningRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningRadioButton.ForeColor = System.Drawing.Color.Black;
            this.earningRadioButton.Location = new System.Drawing.Point(8, 7);
            this.earningRadioButton.Name = "earningRadioButton";
            this.earningRadioButton.Size = new System.Drawing.Size(114, 22);
            this.earningRadioButton.TabIndex = 58;
            this.earningRadioButton.TabStop = true;
            this.earningRadioButton.Text = "Earning Only";
            this.earningRadioButton.UseVisualStyleBackColor = true;
            this.earningRadioButton.Click += new System.EventHandler(this.EarningRadioButtonClicked);
            // 
            // expenseRadioButton
            // 
            this.expenseRadioButton.AutoSize = true;
            this.expenseRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseRadioButton.ForeColor = System.Drawing.Color.Black;
            this.expenseRadioButton.Location = new System.Drawing.Point(156, 7);
            this.expenseRadioButton.Name = "expenseRadioButton";
            this.expenseRadioButton.Size = new System.Drawing.Size(121, 22);
            this.expenseRadioButton.TabIndex = 59;
            this.expenseRadioButton.TabStop = true;
            this.expenseRadioButton.Text = "Expense Only";
            this.expenseRadioButton.UseVisualStyleBackColor = true;
            this.expenseRadioButton.Click += new System.EventHandler(this.ExpenseRadioButtonClicked);
            // 
            // generalReportRadioButton
            // 
            this.generalReportRadioButton.AutoSize = true;
            this.generalReportRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalReportRadioButton.ForeColor = System.Drawing.Color.Black;
            this.generalReportRadioButton.Location = new System.Drawing.Point(8, 6);
            this.generalReportRadioButton.Name = "generalReportRadioButton";
            this.generalReportRadioButton.Size = new System.Drawing.Size(126, 22);
            this.generalReportRadioButton.TabIndex = 60;
            this.generalReportRadioButton.TabStop = true;
            this.generalReportRadioButton.Text = "General report";
            this.generalReportRadioButton.UseVisualStyleBackColor = true;
            this.generalReportRadioButton.Click += new System.EventHandler(this.GeneralReportRadioButtonClicked);
            // 
            // categorywiseReportRadioButton
            // 
            this.categorywiseReportRadioButton.AutoSize = true;
            this.categorywiseReportRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorywiseReportRadioButton.ForeColor = System.Drawing.Color.Black;
            this.categorywiseReportRadioButton.Location = new System.Drawing.Point(156, 6);
            this.categorywiseReportRadioButton.Name = "categorywiseReportRadioButton";
            this.categorywiseReportRadioButton.Size = new System.Drawing.Size(172, 22);
            this.categorywiseReportRadioButton.TabIndex = 61;
            this.categorywiseReportRadioButton.TabStop = true;
            this.categorywiseReportRadioButton.Text = "Category-wise report";
            this.categorywiseReportRadioButton.UseVisualStyleBackColor = true;
            this.categorywiseReportRadioButton.Click += new System.EventHandler(this.CategorywiseReportRadioButton);
            // 
            // bothEarningAndExpenseRadioButton
            // 
            this.bothEarningAndExpenseRadioButton.AutoSize = true;
            this.bothEarningAndExpenseRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bothEarningAndExpenseRadioButton.ForeColor = System.Drawing.Color.Black;
            this.bothEarningAndExpenseRadioButton.Location = new System.Drawing.Point(298, 7);
            this.bothEarningAndExpenseRadioButton.Name = "bothEarningAndExpenseRadioButton";
            this.bothEarningAndExpenseRadioButton.Size = new System.Drawing.Size(207, 22);
            this.bothEarningAndExpenseRadioButton.TabIndex = 62;
            this.bothEarningAndExpenseRadioButton.TabStop = true;
            this.bothEarningAndExpenseRadioButton.Text = "Both earning and expense";
            this.bothEarningAndExpenseRadioButton.UseVisualStyleBackColor = true;
            this.bothEarningAndExpenseRadioButton.Click += new System.EventHandler(this.BothEarningAndExpenseRadionButtonClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.monthComboBox);
            this.panel1.Controls.Add(this.yearComboBox);
            this.panel1.Controls.Add(this.monthlyRadioButton);
            this.panel1.Controls.Add(this.yearlyRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 90);
            this.panel1.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bothEarningAndExpenseRadioButton);
            this.panel2.Controls.Add(this.expenseRadioButton);
            this.panel2.Controls.Add(this.earningRadioButton);
            this.panel2.Location = new System.Drawing.Point(279, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 42);
            this.panel2.TabIndex = 64;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.categorywiseReportRadioButton);
            this.panel3.Controls.Add(this.generalReportRadioButton);
            this.panel3.Location = new System.Drawing.Point(279, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 41);
            this.panel3.TabIndex = 65;
            // 
            // monthlyReportChart
            // 
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.monthlyReportChart.ChartAreas.Add(chartArea4);
            this.monthlyReportChart.Location = new System.Drawing.Point(12, 154);
            this.monthlyReportChart.Name = "monthlyReportChart";
            this.monthlyReportChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Name = "earning";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "expense";
            this.monthlyReportChart.Series.Add(series7);
            this.monthlyReportChart.Series.Add(series8);
            this.monthlyReportChart.Size = new System.Drawing.Size(775, 321);
            this.monthlyReportChart.TabIndex = 66;
            this.monthlyReportChart.Visible = false;
            // 
            // YearlyStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.monthlyReportChart);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yearlyReportChart);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.yearlyStatisticsButton);
            this.Controls.Add(this.dailyReportButton);
            this.Controls.Add(this.addNewDataButton);
            this.Controls.Add(this.homeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YearlyStatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyCost - Earning and Expense Statistics";
            this.Load += new System.EventHandler(this.ThisFormLoading);
            ((System.ComponentModel.ISupportInitialize)(this.yearlyReportChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyReportChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button yearlyStatisticsButton;
        private System.Windows.Forms.Button dailyReportButton;
        private System.Windows.Forms.Button addNewDataButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart yearlyReportChart;
        private System.Windows.Forms.RadioButton yearlyRadioButton;
        private System.Windows.Forms.RadioButton monthlyRadioButton;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.RadioButton earningRadioButton;
        private System.Windows.Forms.RadioButton expenseRadioButton;
        private System.Windows.Forms.RadioButton generalReportRadioButton;
        private System.Windows.Forms.RadioButton categorywiseReportRadioButton;
        private System.Windows.Forms.RadioButton bothEarningAndExpenseRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthlyReportChart;
    }
}