namespace CalorieCounter
{
    partial class frmDailyIntakeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailyIntakeWindow));
            this.NavigationBar = new System.Windows.Forms.MenuStrip();
            this.dailyIntakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calorieLimitCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyIntakeFoodDtbPanel = new System.Windows.Forms.Panel();
            this.chosenFoodNumberOfServingsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.chosenFoodCaloriesTextBox = new System.Windows.Forms.TextBox();
            this.chosenFoodServingSizeTextBox = new System.Windows.Forms.TextBox();
            this.chosenFoodCaloriesLabel = new System.Windows.Forms.Label();
            this.chosenFoodNumberOfServingsLabel = new System.Windows.Forms.Label();
            this.chosenFoodServingSizeLabel = new System.Windows.Forms.Label();
            this.chosenFoodNameLabel = new System.Windows.Forms.Label();
            this.chosenFoodNameTextBox = new System.Windows.Forms.TextBox();
            this.dailyIntakeFoodDtbTable = new System.Windows.Forms.DataGridView();
            this.dailyIntakeFoodDtbSearchBtn = new System.Windows.Forms.Button();
            this.dailyIntakeFoodDtbSearchTextBox = new System.Windows.Forms.TextBox();
            this.dailyIntakeConsumedFoodPanel = new System.Windows.Forms.Panel();
            this.clearAllConsumedFoodBtn = new System.Windows.Forms.Button();
            this.caloriesRemainingTextBox = new System.Windows.Forms.TextBox();
            this.caloriesConsumedTextBox = new System.Windows.Forms.TextBox();
            this.caloriesRemainingLabel = new System.Windows.Forms.Label();
            this.caloriesConsumedLabel = new System.Windows.Forms.Label();
            this.consumedFoodTable = new System.Windows.Forms.DataGridView();
            this.consumedFoodTitle = new System.Windows.Forms.Label();
            this.DailyIntakeFoodDtbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyIntakeFoodDtbServingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyIntakeFoodDtbCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyIntakeFoodDtbChooseBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ConsumedFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumedFoodSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumedFoodCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumedFoodRemoveBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NavigationBar.SuspendLayout();
            this.dailyIntakeFoodDtbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenFoodNumberOfServingsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyIntakeFoodDtbTable)).BeginInit();
            this.dailyIntakeConsumedFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumedFoodTable)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigationBar
            // 
            this.NavigationBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyIntakeToolStripMenuItem,
            this.foodDatabaseToolStripMenuItem,
            this.calorieLimitCounterToolStripMenuItem,
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
            // calorieLimitCounterToolStripMenuItem
            // 
            this.calorieLimitCounterToolStripMenuItem.Name = "calorieLimitCounterToolStripMenuItem";
            this.calorieLimitCounterToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.calorieLimitCounterToolStripMenuItem.Text = "Calorie Limit Counter";
            this.calorieLimitCounterToolStripMenuItem.Click += new System.EventHandler(this.calorieLimitCounterToolStripMenuItem_Click);
            // 
            // myProgressToolStripMenuItem
            // 
            this.myProgressToolStripMenuItem.Name = "myProgressToolStripMenuItem";
            this.myProgressToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.myProgressToolStripMenuItem.Text = "My Progress";
            this.myProgressToolStripMenuItem.Click += new System.EventHandler(this.myProgressToolStripMenuItem_Click);
            // 
            // dailyIntakeFoodDtbPanel
            // 
            this.dailyIntakeFoodDtbPanel.BackColor = System.Drawing.Color.Transparent;
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.chosenFoodNumberOfServingsNumericUpDown);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.addToListBtn);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.chosenFoodCaloriesTextBox);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.chosenFoodServingSizeTextBox);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.chosenFoodCaloriesLabel);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.chosenFoodNumberOfServingsLabel);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.chosenFoodServingSizeLabel);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.chosenFoodNameLabel);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.chosenFoodNameTextBox);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.dailyIntakeFoodDtbTable);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.dailyIntakeFoodDtbSearchBtn);
            this.dailyIntakeFoodDtbPanel.Controls.Add(this.dailyIntakeFoodDtbSearchTextBox);
            this.dailyIntakeFoodDtbPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dailyIntakeFoodDtbPanel.Location = new System.Drawing.Point(0, 24);
            this.dailyIntakeFoodDtbPanel.Name = "dailyIntakeFoodDtbPanel";
            this.dailyIntakeFoodDtbPanel.Size = new System.Drawing.Size(402, 426);
            this.dailyIntakeFoodDtbPanel.TabIndex = 1;
            // 
            // chosenFoodNumberOfServingsNumericUpDown
            // 
            this.chosenFoodNumberOfServingsNumericUpDown.DecimalPlaces = 2;
            this.chosenFoodNumberOfServingsNumericUpDown.Location = new System.Drawing.Point(118, 306);
            this.chosenFoodNumberOfServingsNumericUpDown.Name = "chosenFoodNumberOfServingsNumericUpDown";
            this.chosenFoodNumberOfServingsNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.chosenFoodNumberOfServingsNumericUpDown.TabIndex = 13;
            // 
            // addToListBtn
            // 
            this.addToListBtn.Location = new System.Drawing.Point(108, 358);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(75, 23);
            this.addToListBtn.TabIndex = 11;
            this.addToListBtn.Text = "Add to List";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // chosenFoodCaloriesTextBox
            // 
            this.chosenFoodCaloriesTextBox.Location = new System.Drawing.Point(62, 332);
            this.chosenFoodCaloriesTextBox.Name = "chosenFoodCaloriesTextBox";
            this.chosenFoodCaloriesTextBox.ReadOnly = true;
            this.chosenFoodCaloriesTextBox.Size = new System.Drawing.Size(121, 20);
            this.chosenFoodCaloriesTextBox.TabIndex = 10;
            // 
            // chosenFoodServingSizeTextBox
            // 
            this.chosenFoodServingSizeTextBox.Location = new System.Drawing.Point(84, 280);
            this.chosenFoodServingSizeTextBox.Name = "chosenFoodServingSizeTextBox";
            this.chosenFoodServingSizeTextBox.ReadOnly = true;
            this.chosenFoodServingSizeTextBox.Size = new System.Drawing.Size(99, 20);
            this.chosenFoodServingSizeTextBox.TabIndex = 8;
            // 
            // chosenFoodCaloriesLabel
            // 
            this.chosenFoodCaloriesLabel.AutoSize = true;
            this.chosenFoodCaloriesLabel.Location = new System.Drawing.Point(12, 335);
            this.chosenFoodCaloriesLabel.Name = "chosenFoodCaloriesLabel";
            this.chosenFoodCaloriesLabel.Size = new System.Drawing.Size(44, 13);
            this.chosenFoodCaloriesLabel.TabIndex = 7;
            this.chosenFoodCaloriesLabel.Text = "Calories";
            // 
            // chosenFoodNumberOfServingsLabel
            // 
            this.chosenFoodNumberOfServingsLabel.AutoSize = true;
            this.chosenFoodNumberOfServingsLabel.Location = new System.Drawing.Point(12, 308);
            this.chosenFoodNumberOfServingsLabel.Name = "chosenFoodNumberOfServingsLabel";
            this.chosenFoodNumberOfServingsLabel.Size = new System.Drawing.Size(100, 13);
            this.chosenFoodNumberOfServingsLabel.TabIndex = 6;
            this.chosenFoodNumberOfServingsLabel.Text = "Number of Servings";
            // 
            // chosenFoodServingSizeLabel
            // 
            this.chosenFoodServingSizeLabel.AutoSize = true;
            this.chosenFoodServingSizeLabel.Location = new System.Drawing.Point(12, 283);
            this.chosenFoodServingSizeLabel.Name = "chosenFoodServingSizeLabel";
            this.chosenFoodServingSizeLabel.Size = new System.Drawing.Size(66, 13);
            this.chosenFoodServingSizeLabel.TabIndex = 5;
            this.chosenFoodServingSizeLabel.Text = "Serving Size";
            // 
            // chosenFoodNameLabel
            // 
            this.chosenFoodNameLabel.AutoSize = true;
            this.chosenFoodNameLabel.Location = new System.Drawing.Point(12, 257);
            this.chosenFoodNameLabel.Name = "chosenFoodNameLabel";
            this.chosenFoodNameLabel.Size = new System.Drawing.Size(35, 13);
            this.chosenFoodNameLabel.TabIndex = 4;
            this.chosenFoodNameLabel.Text = "Name";
            // 
            // chosenFoodNameTextBox
            // 
            this.chosenFoodNameTextBox.Location = new System.Drawing.Point(53, 254);
            this.chosenFoodNameTextBox.Name = "chosenFoodNameTextBox";
            this.chosenFoodNameTextBox.ReadOnly = true;
            this.chosenFoodNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.chosenFoodNameTextBox.TabIndex = 3;
            // 
            // dailyIntakeFoodDtbTable
            // 
            this.dailyIntakeFoodDtbTable.AllowUserToAddRows = false;
            this.dailyIntakeFoodDtbTable.AllowUserToDeleteRows = false;
            this.dailyIntakeFoodDtbTable.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dailyIntakeFoodDtbTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyIntakeFoodDtbTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DailyIntakeFoodDtbName,
            this.DailyIntakeFoodDtbServingSize,
            this.DailyIntakeFoodDtbCalories,
            this.DailyIntakeFoodDtbChooseBtn});
            this.dailyIntakeFoodDtbTable.Location = new System.Drawing.Point(12, 31);
            this.dailyIntakeFoodDtbTable.Name = "dailyIntakeFoodDtbTable";
            this.dailyIntakeFoodDtbTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dailyIntakeFoodDtbTable.Size = new System.Drawing.Size(383, 217);
            this.dailyIntakeFoodDtbTable.TabIndex = 2;
            // 
            // dailyIntakeFoodDtbSearchBtn
            // 
            this.dailyIntakeFoodDtbSearchBtn.Location = new System.Drawing.Point(303, 3);
            this.dailyIntakeFoodDtbSearchBtn.Name = "dailyIntakeFoodDtbSearchBtn";
            this.dailyIntakeFoodDtbSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.dailyIntakeFoodDtbSearchBtn.TabIndex = 1;
            this.dailyIntakeFoodDtbSearchBtn.Text = "Search";
            this.dailyIntakeFoodDtbSearchBtn.UseVisualStyleBackColor = true;
            this.dailyIntakeFoodDtbSearchBtn.Click += new System.EventHandler(this.dailyIntakeFoodDtbSearchBtn_Click);
            // 
            // dailyIntakeFoodDtbSearchTextBox
            // 
            this.dailyIntakeFoodDtbSearchTextBox.Location = new System.Drawing.Point(12, 5);
            this.dailyIntakeFoodDtbSearchTextBox.Name = "dailyIntakeFoodDtbSearchTextBox";
            this.dailyIntakeFoodDtbSearchTextBox.Size = new System.Drawing.Size(285, 20);
            this.dailyIntakeFoodDtbSearchTextBox.TabIndex = 0;
            // 
            // dailyIntakeConsumedFoodPanel
            // 
            this.dailyIntakeConsumedFoodPanel.BackColor = System.Drawing.Color.Transparent;
            this.dailyIntakeConsumedFoodPanel.Controls.Add(this.clearAllConsumedFoodBtn);
            this.dailyIntakeConsumedFoodPanel.Controls.Add(this.caloriesRemainingTextBox);
            this.dailyIntakeConsumedFoodPanel.Controls.Add(this.caloriesConsumedTextBox);
            this.dailyIntakeConsumedFoodPanel.Controls.Add(this.caloriesRemainingLabel);
            this.dailyIntakeConsumedFoodPanel.Controls.Add(this.caloriesConsumedLabel);
            this.dailyIntakeConsumedFoodPanel.Controls.Add(this.consumedFoodTable);
            this.dailyIntakeConsumedFoodPanel.Controls.Add(this.consumedFoodTitle);
            this.dailyIntakeConsumedFoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dailyIntakeConsumedFoodPanel.Location = new System.Drawing.Point(402, 24);
            this.dailyIntakeConsumedFoodPanel.Name = "dailyIntakeConsumedFoodPanel";
            this.dailyIntakeConsumedFoodPanel.Size = new System.Drawing.Size(398, 426);
            this.dailyIntakeConsumedFoodPanel.TabIndex = 2;
            // 
            // clearAllConsumedFoodBtn
            // 
            this.clearAllConsumedFoodBtn.Location = new System.Drawing.Point(229, 308);
            this.clearAllConsumedFoodBtn.Name = "clearAllConsumedFoodBtn";
            this.clearAllConsumedFoodBtn.Size = new System.Drawing.Size(157, 23);
            this.clearAllConsumedFoodBtn.TabIndex = 6;
            this.clearAllConsumedFoodBtn.Text = "Clear All Consumed Food";
            this.clearAllConsumedFoodBtn.UseVisualStyleBackColor = true;
            this.clearAllConsumedFoodBtn.Click += new System.EventHandler(this.clearAllConsumedFoodBtn_Click);
            // 
            // caloriesRemainingTextBox
            // 
            this.caloriesRemainingTextBox.Location = new System.Drawing.Point(109, 280);
            this.caloriesRemainingTextBox.Name = "caloriesRemainingTextBox";
            this.caloriesRemainingTextBox.ReadOnly = true;
            this.caloriesRemainingTextBox.Size = new System.Drawing.Size(100, 20);
            this.caloriesRemainingTextBox.TabIndex = 5;
            // 
            // caloriesConsumedTextBox
            // 
            this.caloriesConsumedTextBox.Location = new System.Drawing.Point(109, 254);
            this.caloriesConsumedTextBox.Name = "caloriesConsumedTextBox";
            this.caloriesConsumedTextBox.ReadOnly = true;
            this.caloriesConsumedTextBox.Size = new System.Drawing.Size(100, 20);
            this.caloriesConsumedTextBox.TabIndex = 4;
            // 
            // caloriesRemainingLabel
            // 
            this.caloriesRemainingLabel.AutoSize = true;
            this.caloriesRemainingLabel.Location = new System.Drawing.Point(6, 283);
            this.caloriesRemainingLabel.Name = "caloriesRemainingLabel";
            this.caloriesRemainingLabel.Size = new System.Drawing.Size(97, 13);
            this.caloriesRemainingLabel.TabIndex = 3;
            this.caloriesRemainingLabel.Text = "Calories Remaining";
            // 
            // caloriesConsumedLabel
            // 
            this.caloriesConsumedLabel.AutoSize = true;
            this.caloriesConsumedLabel.Location = new System.Drawing.Point(6, 257);
            this.caloriesConsumedLabel.Name = "caloriesConsumedLabel";
            this.caloriesConsumedLabel.Size = new System.Drawing.Size(97, 13);
            this.caloriesConsumedLabel.TabIndex = 2;
            this.caloriesConsumedLabel.Text = "Calories Consumed";
            // 
            // consumedFoodTable
            // 
            this.consumedFoodTable.AllowUserToAddRows = false;
            this.consumedFoodTable.AllowUserToDeleteRows = false;
            this.consumedFoodTable.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.consumedFoodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consumedFoodTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsumedFoodName,
            this.ConsumedFoodSize,
            this.ConsumedFoodCalories,
            this.ConsumedFoodRemoveBtn});
            this.consumedFoodTable.Location = new System.Drawing.Point(9, 31);
            this.consumedFoodTable.Name = "consumedFoodTable";
            this.consumedFoodTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.consumedFoodTable.Size = new System.Drawing.Size(377, 217);
            this.consumedFoodTable.TabIndex = 1;
            // 
            // consumedFoodTitle
            // 
            this.consumedFoodTitle.AutoSize = true;
            this.consumedFoodTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.consumedFoodTitle.Location = new System.Drawing.Point(6, 5);
            this.consumedFoodTitle.Name = "consumedFoodTitle";
            this.consumedFoodTitle.Size = new System.Drawing.Size(123, 13);
            this.consumedFoodTitle.TabIndex = 0;
            this.consumedFoodTitle.Text = "Food You Ate Today";
            // 
            // DailyIntakeFoodDtbName
            // 
            this.DailyIntakeFoodDtbName.DataPropertyName = "DailyIntakeFoodDtbName";
            this.DailyIntakeFoodDtbName.HeaderText = "Name";
            this.DailyIntakeFoodDtbName.Name = "DailyIntakeFoodDtbName";
            this.DailyIntakeFoodDtbName.ReadOnly = true;
            // 
            // DailyIntakeFoodDtbServingSize
            // 
            this.DailyIntakeFoodDtbServingSize.DataPropertyName = "DailyIntakeFoodDtbServingSize";
            this.DailyIntakeFoodDtbServingSize.HeaderText = "Serving Size";
            this.DailyIntakeFoodDtbServingSize.Name = "DailyIntakeFoodDtbServingSize";
            this.DailyIntakeFoodDtbServingSize.ReadOnly = true;
            this.DailyIntakeFoodDtbServingSize.Width = 90;
            // 
            // DailyIntakeFoodDtbCalories
            // 
            this.DailyIntakeFoodDtbCalories.DataPropertyName = "DailyIntakeFoodDtbCalories";
            this.DailyIntakeFoodDtbCalories.HeaderText = "Calories";
            this.DailyIntakeFoodDtbCalories.Name = "DailyIntakeFoodDtbCalories";
            this.DailyIntakeFoodDtbCalories.ReadOnly = true;
            this.DailyIntakeFoodDtbCalories.Width = 80;
            // 
            // DailyIntakeFoodDtbChooseBtn
            // 
            this.DailyIntakeFoodDtbChooseBtn.DataPropertyName = "DailyIntakeFoodDtbChooseBtn";
            this.DailyIntakeFoodDtbChooseBtn.HeaderText = "Choose";
            this.DailyIntakeFoodDtbChooseBtn.Name = "DailyIntakeFoodDtbChooseBtn";
            this.DailyIntakeFoodDtbChooseBtn.Width = 70;
            // 
            // ConsumedFoodName
            // 
            this.ConsumedFoodName.DataPropertyName = "ConsumedFoodName";
            this.ConsumedFoodName.HeaderText = "Name";
            this.ConsumedFoodName.Name = "ConsumedFoodName";
            this.ConsumedFoodName.ReadOnly = true;
            // 
            // ConsumedFoodSize
            // 
            this.ConsumedFoodSize.DataPropertyName = "ConsumedFoodSize";
            this.ConsumedFoodSize.HeaderText = "Size";
            this.ConsumedFoodSize.Name = "ConsumedFoodSize";
            this.ConsumedFoodSize.ReadOnly = true;
            this.ConsumedFoodSize.Width = 90;
            // 
            // ConsumedFoodCalories
            // 
            this.ConsumedFoodCalories.DataPropertyName = "ConsumedFoodCalories";
            this.ConsumedFoodCalories.HeaderText = "Calories";
            this.ConsumedFoodCalories.Name = "ConsumedFoodCalories";
            this.ConsumedFoodCalories.ReadOnly = true;
            this.ConsumedFoodCalories.Width = 80;
            // 
            // ConsumedFoodRemoveBtn
            // 
            this.ConsumedFoodRemoveBtn.DataPropertyName = "ConsumedFoodRemoveBtn";
            this.ConsumedFoodRemoveBtn.HeaderText = "Remove";
            this.ConsumedFoodRemoveBtn.Name = "ConsumedFoodRemoveBtn";
            this.ConsumedFoodRemoveBtn.Width = 64;
            // 
            // frmDailyIntakeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dailyIntakeConsumedFoodPanel);
            this.Controls.Add(this.dailyIntakeFoodDtbPanel);
            this.Controls.Add(this.NavigationBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.NavigationBar;
            this.Name = "frmDailyIntakeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalorieCounter";
            this.Load += new System.EventHandler(this.frmDailyIntakeWindow_Load);
            this.NavigationBar.ResumeLayout(false);
            this.NavigationBar.PerformLayout();
            this.dailyIntakeFoodDtbPanel.ResumeLayout(false);
            this.dailyIntakeFoodDtbPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenFoodNumberOfServingsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyIntakeFoodDtbTable)).EndInit();
            this.dailyIntakeConsumedFoodPanel.ResumeLayout(false);
            this.dailyIntakeConsumedFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumedFoodTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NavigationBar;
        private System.Windows.Forms.ToolStripMenuItem dailyIntakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calorieLimitCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProgressToolStripMenuItem;
        private System.Windows.Forms.Panel dailyIntakeFoodDtbPanel;
        private System.Windows.Forms.Panel dailyIntakeConsumedFoodPanel;
        private System.Windows.Forms.Button dailyIntakeFoodDtbSearchBtn;
        private System.Windows.Forms.TextBox dailyIntakeFoodDtbSearchTextBox;
        private System.Windows.Forms.DataGridView dailyIntakeFoodDtbTable;
        private System.Windows.Forms.Label chosenFoodServingSizeLabel;
        private System.Windows.Forms.Label chosenFoodNameLabel;
        private System.Windows.Forms.TextBox chosenFoodNameTextBox;
        private System.Windows.Forms.TextBox chosenFoodServingSizeTextBox;
        private System.Windows.Forms.Label chosenFoodCaloriesLabel;
        private System.Windows.Forms.Label chosenFoodNumberOfServingsLabel;
        private System.Windows.Forms.Button addToListBtn;
        private System.Windows.Forms.TextBox chosenFoodCaloriesTextBox;
        private System.Windows.Forms.DataGridView consumedFoodTable;
        private System.Windows.Forms.Label consumedFoodTitle;
        private System.Windows.Forms.TextBox caloriesRemainingTextBox;
        private System.Windows.Forms.TextBox caloriesConsumedTextBox;
        private System.Windows.Forms.Label caloriesRemainingLabel;
        private System.Windows.Forms.Label caloriesConsumedLabel;
        private System.Windows.Forms.NumericUpDown chosenFoodNumberOfServingsNumericUpDown;
        private System.Windows.Forms.Button clearAllConsumedFoodBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyIntakeFoodDtbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyIntakeFoodDtbServingSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyIntakeFoodDtbCalories;
        private System.Windows.Forms.DataGridViewButtonColumn DailyIntakeFoodDtbChooseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumedFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumedFoodSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumedFoodCalories;
        private System.Windows.Forms.DataGridViewButtonColumn ConsumedFoodRemoveBtn;
    }
}