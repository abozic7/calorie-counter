namespace CalorieCounter
{
    partial class frmUserProgressWindow
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserProgressWindow));
            this.NavigationBar = new System.Windows.Forms.MenuStrip();
            this.dailyIntakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calorieLimitCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressTable = new System.Windows.Forms.DataGridView();
            this.ProgressWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgressDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressCurrentWeightLabel = new System.Windows.Forms.Label();
            this.progressCurrentWeightTextBox = new System.Windows.Forms.TextBox();
            this.progressWeightUnitLabel = new System.Windows.Forms.Label();
            this.progressAddBtn = new System.Windows.Forms.Button();
            this.progressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigationBar
            // 
            this.NavigationBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyIntakeToolStripMenuItem,
            this.foodDatabaseToolStripMenuItem,
            this.calorieLimitCalculatorToolStripMenuItem,
            this.myProgressToolStripMenuItem});
            this.NavigationBar.Location = new System.Drawing.Point(0, 0);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.Size = new System.Drawing.Size(800, 24);
            this.NavigationBar.TabIndex = 0;
            this.NavigationBar.Text = "NavigationBar";
            // 
            // dailyIntakeToolStripMenuItem
            // 
            this.dailyIntakeToolStripMenuItem.Name = "dailyIntakeToolStripMenuItem";
            this.dailyIntakeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dailyIntakeToolStripMenuItem.Text = "Daily Intake";
            this.dailyIntakeToolStripMenuItem.Click += new System.EventHandler(this.dailyIntakeToolStripMenuItem_Click);
            // 
            // foodDatabaseToolStripMenuItem
            // 
            this.foodDatabaseToolStripMenuItem.Name = "foodDatabaseToolStripMenuItem";
            this.foodDatabaseToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.foodDatabaseToolStripMenuItem.Text = "Food Database";
            this.foodDatabaseToolStripMenuItem.Click += new System.EventHandler(this.foodDatabaseToolStripMenuItem_Click);
            // 
            // calorieLimitCalculatorToolStripMenuItem
            // 
            this.calorieLimitCalculatorToolStripMenuItem.Name = "calorieLimitCalculatorToolStripMenuItem";
            this.calorieLimitCalculatorToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.calorieLimitCalculatorToolStripMenuItem.Text = "Calorie Limit Calculator";
            this.calorieLimitCalculatorToolStripMenuItem.Click += new System.EventHandler(this.calorieLimitCounterToolStripMenuItem_Click);
            // 
            // myProgressToolStripMenuItem
            // 
            this.myProgressToolStripMenuItem.Name = "myProgressToolStripMenuItem";
            this.myProgressToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.myProgressToolStripMenuItem.Text = "My Progress";
            this.myProgressToolStripMenuItem.Click += new System.EventHandler(this.myProgressToolStripMenuItem_Click);
            // 
            // progressTable
            // 
            this.progressTable.AllowUserToAddRows = false;
            this.progressTable.AllowUserToDeleteRows = false;
            this.progressTable.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progressTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgressWeight,
            this.ProgressDate});
            this.progressTable.Location = new System.Drawing.Point(527, 65);
            this.progressTable.Name = "progressTable";
            this.progressTable.Size = new System.Drawing.Size(240, 150);
            this.progressTable.TabIndex = 1;
            // 
            // ProgressWeight
            // 
            this.ProgressWeight.DataPropertyName = "ProgressWeight";
            this.ProgressWeight.HeaderText = "Weight";
            this.ProgressWeight.Name = "ProgressWeight";
            this.ProgressWeight.ReadOnly = true;
            this.ProgressWeight.Width = 97;
            // 
            // ProgressDate
            // 
            this.ProgressDate.DataPropertyName = "ProgressDate";
            this.ProgressDate.HeaderText = "Date";
            this.ProgressDate.Name = "ProgressDate";
            this.ProgressDate.ReadOnly = true;
            // 
            // progressCurrentWeightLabel
            // 
            this.progressCurrentWeightLabel.AutoSize = true;
            this.progressCurrentWeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressCurrentWeightLabel.Location = new System.Drawing.Point(524, 224);
            this.progressCurrentWeightLabel.Name = "progressCurrentWeightLabel";
            this.progressCurrentWeightLabel.Size = new System.Drawing.Size(81, 13);
            this.progressCurrentWeightLabel.TabIndex = 3;
            this.progressCurrentWeightLabel.Text = "Current Weight:";
            // 
            // progressCurrentWeightTextBox
            // 
            this.progressCurrentWeightTextBox.Location = new System.Drawing.Point(611, 221);
            this.progressCurrentWeightTextBox.Name = "progressCurrentWeightTextBox";
            this.progressCurrentWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.progressCurrentWeightTextBox.TabIndex = 4;
            // 
            // progressWeightUnitLabel
            // 
            this.progressWeightUnitLabel.AutoSize = true;
            this.progressWeightUnitLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressWeightUnitLabel.Location = new System.Drawing.Point(717, 224);
            this.progressWeightUnitLabel.Name = "progressWeightUnitLabel";
            this.progressWeightUnitLabel.Size = new System.Drawing.Size(19, 13);
            this.progressWeightUnitLabel.TabIndex = 5;
            this.progressWeightUnitLabel.Text = "kg";
            // 
            // progressAddBtn
            // 
            this.progressAddBtn.Location = new System.Drawing.Point(692, 247);
            this.progressAddBtn.Name = "progressAddBtn";
            this.progressAddBtn.Size = new System.Drawing.Size(75, 23);
            this.progressAddBtn.TabIndex = 6;
            this.progressAddBtn.Text = "Add";
            this.progressAddBtn.UseVisualStyleBackColor = true;
            this.progressAddBtn.Click += new System.EventHandler(this.progressAddBtn_Click);
            // 
            // progressChart
            // 
            this.progressChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.progressChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.progressChart.Legends.Add(legend1);
            this.progressChart.Location = new System.Drawing.Point(12, 45);
            this.progressChart.Name = "progressChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            this.progressChart.Series.Add(series1);
            this.progressChart.Size = new System.Drawing.Size(482, 300);
            this.progressChart.TabIndex = 7;
            this.progressChart.Text = "Progress Chart";
            // 
            // frmUserProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressChart);
            this.Controls.Add(this.progressAddBtn);
            this.Controls.Add(this.progressWeightUnitLabel);
            this.Controls.Add(this.progressCurrentWeightTextBox);
            this.Controls.Add(this.progressCurrentWeightLabel);
            this.Controls.Add(this.progressTable);
            this.Controls.Add(this.NavigationBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.NavigationBar;
            this.Name = "frmUserProgressWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalorieCounter";
            this.Load += new System.EventHandler(this.frmUserProgressWindow_Load);
            this.NavigationBar.ResumeLayout(false);
            this.NavigationBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NavigationBar;
        private System.Windows.Forms.ToolStripMenuItem dailyIntakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calorieLimitCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProgressToolStripMenuItem;
        private System.Windows.Forms.DataGridView progressTable;
        private System.Windows.Forms.Label progressCurrentWeightLabel;
        private System.Windows.Forms.TextBox progressCurrentWeightTextBox;
        private System.Windows.Forms.Label progressWeightUnitLabel;
        private System.Windows.Forms.Button progressAddBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart progressChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgressWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgressDate;
    }
}