namespace CalorieCounter
{
    partial class frmFoodDatabaseWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodDatabaseWindow));
            this.NavigationBar = new System.Windows.Forms.MenuStrip();
            this.dailyIntakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calorieLimitCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodDatabasePanel = new System.Windows.Forms.Panel();
            this.selectedFoodDetails = new System.Windows.Forms.TextBox();
            this.foodDatabaseTable = new System.Windows.Forms.DataGridView();
            this.foodDatabaseSearchBtn = new System.Windows.Forms.Button();
            this.foodDatabaseSearchTextBox = new System.Windows.Forms.TextBox();
            this.foodFormPanel = new System.Windows.Forms.Panel();
            this.foodFormClearFormBtn = new System.Windows.Forms.Button();
            this.foodFormSaveBtn = new System.Windows.Forms.Button();
            this.fatsMeasurementUnitLabel = new System.Windows.Forms.Label();
            this.carbsMeasurementUnitLabel = new System.Windows.Forms.Label();
            this.proteinsMeasurementUnitLabel = new System.Windows.Forms.Label();
            this.caloriesMeasurementUnitLabel = new System.Windows.Forms.Label();
            this.foodFormFatsTextBox = new System.Windows.Forms.TextBox();
            this.foodFormCarbsTextBox = new System.Windows.Forms.TextBox();
            this.foodFormProteinsTextBox = new System.Windows.Forms.TextBox();
            this.foodFormCaloriesTextBox = new System.Windows.Forms.TextBox();
            this.foodFormServingSizeUnitComboBox = new System.Windows.Forms.ComboBox();
            this.foodFormServingSizeTextBox = new System.Windows.Forms.TextBox();
            this.foodFormNameTextBox = new System.Windows.Forms.TextBox();
            this.foodFormFatsLabel = new System.Windows.Forms.Label();
            this.foodFormCarbsLabel = new System.Windows.Forms.Label();
            this.foodFormProteinsLabel = new System.Windows.Forms.Label();
            this.foodFormCaloriesLabel = new System.Windows.Forms.Label();
            this.foodFormServingSizeLabel = new System.Windows.Forms.Label();
            this.foodFormNameLabel = new System.Windows.Forms.Label();
            this.FoodDatabaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodDatabaseServingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodDatabaseCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodDatabaseDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FoodDatabaseUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FoodDatabaseRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NavigationBar.SuspendLayout();
            this.foodDatabasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodDatabaseTable)).BeginInit();
            this.foodFormPanel.SuspendLayout();
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
            // foodDatabasePanel
            // 
            this.foodDatabasePanel.BackColor = System.Drawing.Color.Transparent;
            this.foodDatabasePanel.Controls.Add(this.selectedFoodDetails);
            this.foodDatabasePanel.Controls.Add(this.foodDatabaseTable);
            this.foodDatabasePanel.Controls.Add(this.foodDatabaseSearchBtn);
            this.foodDatabasePanel.Controls.Add(this.foodDatabaseSearchTextBox);
            this.foodDatabasePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.foodDatabasePanel.Location = new System.Drawing.Point(0, 24);
            this.foodDatabasePanel.Name = "foodDatabasePanel";
            this.foodDatabasePanel.Size = new System.Drawing.Size(509, 426);
            this.foodDatabasePanel.TabIndex = 1;
            // 
            // selectedFoodDetails
            // 
            this.selectedFoodDetails.Location = new System.Drawing.Point(12, 270);
            this.selectedFoodDetails.Multiline = true;
            this.selectedFoodDetails.Name = "selectedFoodDetails";
            this.selectedFoodDetails.ReadOnly = true;
            this.selectedFoodDetails.Size = new System.Drawing.Size(494, 144);
            this.selectedFoodDetails.TabIndex = 3;
            // 
            // foodDatabaseTable
            // 
            this.foodDatabaseTable.AllowUserToAddRows = false;
            this.foodDatabaseTable.AllowUserToDeleteRows = false;
            this.foodDatabaseTable.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.foodDatabaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDatabaseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodDatabaseName,
            this.FoodDatabaseServingSize,
            this.FoodDatabaseCalories,
            this.FoodDatabaseDetails,
            this.FoodDatabaseUpdate,
            this.FoodDatabaseRemove});
            this.foodDatabaseTable.Location = new System.Drawing.Point(12, 31);
            this.foodDatabaseTable.Name = "foodDatabaseTable";
            this.foodDatabaseTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.foodDatabaseTable.Size = new System.Drawing.Size(494, 233);
            this.foodDatabaseTable.TabIndex = 2;
            // 
            // foodDatabaseSearchBtn
            // 
            this.foodDatabaseSearchBtn.Location = new System.Drawing.Point(255, 3);
            this.foodDatabaseSearchBtn.Name = "foodDatabaseSearchBtn";
            this.foodDatabaseSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.foodDatabaseSearchBtn.TabIndex = 1;
            this.foodDatabaseSearchBtn.Text = "Search";
            this.foodDatabaseSearchBtn.UseVisualStyleBackColor = true;
            this.foodDatabaseSearchBtn.Click += new System.EventHandler(this.foodDatabaseSearchBtn_Click);
            // 
            // foodDatabaseSearchTextBox
            // 
            this.foodDatabaseSearchTextBox.Location = new System.Drawing.Point(12, 5);
            this.foodDatabaseSearchTextBox.Name = "foodDatabaseSearchTextBox";
            this.foodDatabaseSearchTextBox.Size = new System.Drawing.Size(237, 20);
            this.foodDatabaseSearchTextBox.TabIndex = 0;
            // 
            // foodFormPanel
            // 
            this.foodFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.foodFormPanel.Controls.Add(this.foodFormClearFormBtn);
            this.foodFormPanel.Controls.Add(this.foodFormSaveBtn);
            this.foodFormPanel.Controls.Add(this.fatsMeasurementUnitLabel);
            this.foodFormPanel.Controls.Add(this.carbsMeasurementUnitLabel);
            this.foodFormPanel.Controls.Add(this.proteinsMeasurementUnitLabel);
            this.foodFormPanel.Controls.Add(this.caloriesMeasurementUnitLabel);
            this.foodFormPanel.Controls.Add(this.foodFormFatsTextBox);
            this.foodFormPanel.Controls.Add(this.foodFormCarbsTextBox);
            this.foodFormPanel.Controls.Add(this.foodFormProteinsTextBox);
            this.foodFormPanel.Controls.Add(this.foodFormCaloriesTextBox);
            this.foodFormPanel.Controls.Add(this.foodFormServingSizeUnitComboBox);
            this.foodFormPanel.Controls.Add(this.foodFormServingSizeTextBox);
            this.foodFormPanel.Controls.Add(this.foodFormNameTextBox);
            this.foodFormPanel.Controls.Add(this.foodFormFatsLabel);
            this.foodFormPanel.Controls.Add(this.foodFormCarbsLabel);
            this.foodFormPanel.Controls.Add(this.foodFormProteinsLabel);
            this.foodFormPanel.Controls.Add(this.foodFormCaloriesLabel);
            this.foodFormPanel.Controls.Add(this.foodFormServingSizeLabel);
            this.foodFormPanel.Controls.Add(this.foodFormNameLabel);
            this.foodFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodFormPanel.Location = new System.Drawing.Point(509, 24);
            this.foodFormPanel.Name = "foodFormPanel";
            this.foodFormPanel.Size = new System.Drawing.Size(291, 426);
            this.foodFormPanel.TabIndex = 2;
            // 
            // foodFormClearFormBtn
            // 
            this.foodFormClearFormBtn.Location = new System.Drawing.Point(125, 198);
            this.foodFormClearFormBtn.Name = "foodFormClearFormBtn";
            this.foodFormClearFormBtn.Size = new System.Drawing.Size(75, 23);
            this.foodFormClearFormBtn.TabIndex = 18;
            this.foodFormClearFormBtn.Text = "Clear Form";
            this.foodFormClearFormBtn.UseVisualStyleBackColor = true;
            this.foodFormClearFormBtn.Click += new System.EventHandler(this.foodFormClearFormBtn_Click);
            // 
            // foodFormSaveBtn
            // 
            this.foodFormSaveBtn.Location = new System.Drawing.Point(206, 198);
            this.foodFormSaveBtn.Name = "foodFormSaveBtn";
            this.foodFormSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.foodFormSaveBtn.TabIndex = 17;
            this.foodFormSaveBtn.Text = "Save";
            this.foodFormSaveBtn.UseVisualStyleBackColor = true;
            this.foodFormSaveBtn.Click += new System.EventHandler(this.foodFormSaveBtn_Click);
            // 
            // fatsMeasurementUnitLabel
            // 
            this.fatsMeasurementUnitLabel.AutoSize = true;
            this.fatsMeasurementUnitLabel.Location = new System.Drawing.Point(214, 164);
            this.fatsMeasurementUnitLabel.Name = "fatsMeasurementUnitLabel";
            this.fatsMeasurementUnitLabel.Size = new System.Drawing.Size(13, 13);
            this.fatsMeasurementUnitLabel.TabIndex = 16;
            this.fatsMeasurementUnitLabel.Text = "g";
            // 
            // carbsMeasurementUnitLabel
            // 
            this.carbsMeasurementUnitLabel.AutoSize = true;
            this.carbsMeasurementUnitLabel.Location = new System.Drawing.Point(214, 138);
            this.carbsMeasurementUnitLabel.Name = "carbsMeasurementUnitLabel";
            this.carbsMeasurementUnitLabel.Size = new System.Drawing.Size(13, 13);
            this.carbsMeasurementUnitLabel.TabIndex = 15;
            this.carbsMeasurementUnitLabel.Text = "g";
            // 
            // proteinsMeasurementUnitLabel
            // 
            this.proteinsMeasurementUnitLabel.AutoSize = true;
            this.proteinsMeasurementUnitLabel.Location = new System.Drawing.Point(214, 112);
            this.proteinsMeasurementUnitLabel.Name = "proteinsMeasurementUnitLabel";
            this.proteinsMeasurementUnitLabel.Size = new System.Drawing.Size(13, 13);
            this.proteinsMeasurementUnitLabel.TabIndex = 14;
            this.proteinsMeasurementUnitLabel.Text = "g";
            // 
            // caloriesMeasurementUnitLabel
            // 
            this.caloriesMeasurementUnitLabel.AutoSize = true;
            this.caloriesMeasurementUnitLabel.Location = new System.Drawing.Point(214, 86);
            this.caloriesMeasurementUnitLabel.Name = "caloriesMeasurementUnitLabel";
            this.caloriesMeasurementUnitLabel.Size = new System.Drawing.Size(27, 13);
            this.caloriesMeasurementUnitLabel.TabIndex = 13;
            this.caloriesMeasurementUnitLabel.Text = "kcal";
            // 
            // foodFormFatsTextBox
            // 
            this.foodFormFatsTextBox.Location = new System.Drawing.Point(108, 161);
            this.foodFormFatsTextBox.Name = "foodFormFatsTextBox";
            this.foodFormFatsTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodFormFatsTextBox.TabIndex = 12;
            // 
            // foodFormCarbsTextBox
            // 
            this.foodFormCarbsTextBox.Location = new System.Drawing.Point(108, 135);
            this.foodFormCarbsTextBox.Name = "foodFormCarbsTextBox";
            this.foodFormCarbsTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodFormCarbsTextBox.TabIndex = 11;
            // 
            // foodFormProteinsTextBox
            // 
            this.foodFormProteinsTextBox.Location = new System.Drawing.Point(108, 109);
            this.foodFormProteinsTextBox.Name = "foodFormProteinsTextBox";
            this.foodFormProteinsTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodFormProteinsTextBox.TabIndex = 10;
            // 
            // foodFormCaloriesTextBox
            // 
            this.foodFormCaloriesTextBox.Location = new System.Drawing.Point(108, 83);
            this.foodFormCaloriesTextBox.Name = "foodFormCaloriesTextBox";
            this.foodFormCaloriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodFormCaloriesTextBox.TabIndex = 9;
            // 
            // foodFormServingSizeUnitComboBox
            // 
            this.foodFormServingSizeUnitComboBox.FormattingEnabled = true;
            this.foodFormServingSizeUnitComboBox.Items.AddRange(new object[] {
            "g",
            "ml"});
            this.foodFormServingSizeUnitComboBox.Location = new System.Drawing.Point(211, 57);
            this.foodFormServingSizeUnitComboBox.Name = "foodFormServingSizeUnitComboBox";
            this.foodFormServingSizeUnitComboBox.Size = new System.Drawing.Size(70, 21);
            this.foodFormServingSizeUnitComboBox.TabIndex = 8;
            // 
            // foodFormServingSizeTextBox
            // 
            this.foodFormServingSizeTextBox.Location = new System.Drawing.Point(108, 57);
            this.foodFormServingSizeTextBox.Name = "foodFormServingSizeTextBox";
            this.foodFormServingSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodFormServingSizeTextBox.TabIndex = 7;
            // 
            // foodFormNameTextBox
            // 
            this.foodFormNameTextBox.Location = new System.Drawing.Point(108, 31);
            this.foodFormNameTextBox.Name = "foodFormNameTextBox";
            this.foodFormNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.foodFormNameTextBox.TabIndex = 6;
            // 
            // foodFormFatsLabel
            // 
            this.foodFormFatsLabel.AutoSize = true;
            this.foodFormFatsLabel.Location = new System.Drawing.Point(25, 164);
            this.foodFormFatsLabel.Name = "foodFormFatsLabel";
            this.foodFormFatsLabel.Size = new System.Drawing.Size(77, 13);
            this.foodFormFatsLabel.TabIndex = 5;
            this.foodFormFatsLabel.Text = "Fats in Serving";
            // 
            // foodFormCarbsLabel
            // 
            this.foodFormCarbsLabel.AutoSize = true;
            this.foodFormCarbsLabel.Location = new System.Drawing.Point(18, 138);
            this.foodFormCarbsLabel.Name = "foodFormCarbsLabel";
            this.foodFormCarbsLabel.Size = new System.Drawing.Size(84, 13);
            this.foodFormCarbsLabel.TabIndex = 4;
            this.foodFormCarbsLabel.Text = "Carbs in Serving";
            // 
            // foodFormProteinsLabel
            // 
            this.foodFormProteinsLabel.AutoSize = true;
            this.foodFormProteinsLabel.Location = new System.Drawing.Point(7, 112);
            this.foodFormProteinsLabel.Name = "foodFormProteinsLabel";
            this.foodFormProteinsLabel.Size = new System.Drawing.Size(95, 13);
            this.foodFormProteinsLabel.TabIndex = 3;
            this.foodFormProteinsLabel.Text = "Proteins in Serving";
            // 
            // foodFormCaloriesLabel
            // 
            this.foodFormCaloriesLabel.AutoSize = true;
            this.foodFormCaloriesLabel.Location = new System.Drawing.Point(8, 86);
            this.foodFormCaloriesLabel.Name = "foodFormCaloriesLabel";
            this.foodFormCaloriesLabel.Size = new System.Drawing.Size(94, 13);
            this.foodFormCaloriesLabel.TabIndex = 2;
            this.foodFormCaloriesLabel.Text = "Calories in Serving";
            // 
            // foodFormServingSizeLabel
            // 
            this.foodFormServingSizeLabel.AutoSize = true;
            this.foodFormServingSizeLabel.Location = new System.Drawing.Point(36, 60);
            this.foodFormServingSizeLabel.Name = "foodFormServingSizeLabel";
            this.foodFormServingSizeLabel.Size = new System.Drawing.Size(66, 13);
            this.foodFormServingSizeLabel.TabIndex = 1;
            this.foodFormServingSizeLabel.Text = "Serving Size";
            // 
            // foodFormNameLabel
            // 
            this.foodFormNameLabel.AutoSize = true;
            this.foodFormNameLabel.Location = new System.Drawing.Point(67, 34);
            this.foodFormNameLabel.Name = "foodFormNameLabel";
            this.foodFormNameLabel.Size = new System.Drawing.Size(35, 13);
            this.foodFormNameLabel.TabIndex = 0;
            this.foodFormNameLabel.Text = "Name";
            // 
            // FoodDatabaseName
            // 
            this.FoodDatabaseName.DataPropertyName = "FoodDatabaseName";
            this.FoodDatabaseName.HeaderText = "Name";
            this.FoodDatabaseName.Name = "FoodDatabaseName";
            this.FoodDatabaseName.ReadOnly = true;
            this.FoodDatabaseName.Width = 90;
            // 
            // FoodDatabaseServingSize
            // 
            this.FoodDatabaseServingSize.DataPropertyName = "FoodDatabaseServingSize";
            this.FoodDatabaseServingSize.HeaderText = "Serving Size";
            this.FoodDatabaseServingSize.Name = "FoodDatabaseServingSize";
            this.FoodDatabaseServingSize.ReadOnly = true;
            this.FoodDatabaseServingSize.Width = 90;
            // 
            // FoodDatabaseCalories
            // 
            this.FoodDatabaseCalories.DataPropertyName = "FoodDatabaseCalories";
            this.FoodDatabaseCalories.HeaderText = "Calories";
            this.FoodDatabaseCalories.Name = "FoodDatabaseCalories";
            this.FoodDatabaseCalories.ReadOnly = true;
            this.FoodDatabaseCalories.Width = 75;
            // 
            // FoodDatabaseDetails
            // 
            this.FoodDatabaseDetails.DataPropertyName = "FoodDatabaseDetails";
            this.FoodDatabaseDetails.HeaderText = "Details";
            this.FoodDatabaseDetails.Name = "FoodDatabaseDetails";
            this.FoodDatabaseDetails.Width = 65;
            // 
            // FoodDatabaseUpdate
            // 
            this.FoodDatabaseUpdate.DataPropertyName = "FoodDatabaseUpdate";
            this.FoodDatabaseUpdate.HeaderText = "Update";
            this.FoodDatabaseUpdate.Name = "FoodDatabaseUpdate";
            this.FoodDatabaseUpdate.Width = 65;
            // 
            // FoodDatabaseRemove
            // 
            this.FoodDatabaseRemove.DataPropertyName = "FoodDatabaseRemove";
            this.FoodDatabaseRemove.HeaderText = "Remove";
            this.FoodDatabaseRemove.Name = "FoodDatabaseRemove";
            this.FoodDatabaseRemove.Width = 65;
            // 
            // frmFoodDatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foodFormPanel);
            this.Controls.Add(this.foodDatabasePanel);
            this.Controls.Add(this.NavigationBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.NavigationBar;
            this.Name = "frmFoodDatabaseWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalorieCounter";
            this.Load += new System.EventHandler(this.frmFoodDatabaseWindow_Load);
            this.NavigationBar.ResumeLayout(false);
            this.NavigationBar.PerformLayout();
            this.foodDatabasePanel.ResumeLayout(false);
            this.foodDatabasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodDatabaseTable)).EndInit();
            this.foodFormPanel.ResumeLayout(false);
            this.foodFormPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NavigationBar;
        private System.Windows.Forms.ToolStripMenuItem dailyIntakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calorieLimitCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProgressToolStripMenuItem;
        private System.Windows.Forms.Panel foodDatabasePanel;
        private System.Windows.Forms.Button foodDatabaseSearchBtn;
        private System.Windows.Forms.TextBox foodDatabaseSearchTextBox;
        private System.Windows.Forms.Panel foodFormPanel;
        private System.Windows.Forms.DataGridView foodDatabaseTable;
        private System.Windows.Forms.TextBox selectedFoodDetails;
        private System.Windows.Forms.Label foodFormServingSizeLabel;
        private System.Windows.Forms.Label foodFormNameLabel;
        private System.Windows.Forms.Label foodFormCaloriesLabel;
        private System.Windows.Forms.Label foodFormProteinsLabel;
        private System.Windows.Forms.Label foodFormCarbsLabel;
        private System.Windows.Forms.Label foodFormFatsLabel;
        private System.Windows.Forms.TextBox foodFormNameTextBox;
        private System.Windows.Forms.ComboBox foodFormServingSizeUnitComboBox;
        private System.Windows.Forms.TextBox foodFormServingSizeTextBox;
        private System.Windows.Forms.TextBox foodFormCaloriesTextBox;
        private System.Windows.Forms.Button foodFormSaveBtn;
        private System.Windows.Forms.Label fatsMeasurementUnitLabel;
        private System.Windows.Forms.Label carbsMeasurementUnitLabel;
        private System.Windows.Forms.Label proteinsMeasurementUnitLabel;
        private System.Windows.Forms.Label caloriesMeasurementUnitLabel;
        private System.Windows.Forms.TextBox foodFormFatsTextBox;
        private System.Windows.Forms.TextBox foodFormCarbsTextBox;
        private System.Windows.Forms.TextBox foodFormProteinsTextBox;
        private System.Windows.Forms.Button foodFormClearFormBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodDatabaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodDatabaseServingSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodDatabaseCalories;
        private System.Windows.Forms.DataGridViewButtonColumn FoodDatabaseDetails;
        private System.Windows.Forms.DataGridViewButtonColumn FoodDatabaseUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn FoodDatabaseRemove;
    }
}