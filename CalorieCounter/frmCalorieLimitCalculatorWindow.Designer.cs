namespace CalorieCounter
{
    partial class frmCalorieLimitCalculatorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalorieLimitCalculatorWindow));
            this.NavigationBar = new System.Windows.Forms.MenuStrip();
            this.dailyIntakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calorieLimitCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clcGenderLabel = new System.Windows.Forms.Label();
            this.clcAgeLabel = new System.Windows.Forms.Label();
            this.clcWeightLabel = new System.Windows.Forms.Label();
            this.clcHeightLabel = new System.Windows.Forms.Label();
            this.clcGenderComboBox = new System.Windows.Forms.ComboBox();
            this.clcAgeTextBox = new System.Windows.Forms.TextBox();
            this.clcWeightTextBox = new System.Windows.Forms.TextBox();
            this.clcWeightMeasureUnit = new System.Windows.Forms.Label();
            this.clcHeightTextBox = new System.Windows.Forms.TextBox();
            this.clcHeightMeasureUnit = new System.Windows.Forms.Label();
            this.clcActivityLevelLabel = new System.Windows.Forms.Label();
            this.clcActivityLevelPanel = new System.Windows.Forms.Panel();
            this.clcExtraActiveRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcSedentaryRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcVeryActiveRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcLightActivityRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcModerateActivityRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcGoalPanel = new System.Windows.Forms.Panel();
            this.clcGoalGainRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcGoalLoseRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcGoalMaintainRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcGoalLabel = new System.Windows.Forms.Label();
            this.clcGoalAmountPanel = new System.Windows.Forms.Panel();
            this.clcOneRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcQuarterRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcThreeQuartersRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcHalfRadioBtn = new System.Windows.Forms.RadioButton();
            this.clcGoalAmountLabel = new System.Windows.Forms.Label();
            this.clcCalorieLimitTextBox = new System.Windows.Forms.TextBox();
            this.clcCalculateCalorieLimitBtn = new System.Windows.Forms.Button();
            this.clcSaveCalorieLimitBtn = new System.Windows.Forms.Button();
            this.clcCalorieLimitLabel = new System.Windows.Forms.Label();
            this.NavigationBar.SuspendLayout();
            this.clcActivityLevelPanel.SuspendLayout();
            this.clcGoalPanel.SuspendLayout();
            this.clcGoalAmountPanel.SuspendLayout();
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
            // clcGenderLabel
            // 
            this.clcGenderLabel.AutoSize = true;
            this.clcGenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.clcGenderLabel.Location = new System.Drawing.Point(62, 52);
            this.clcGenderLabel.Name = "clcGenderLabel";
            this.clcGenderLabel.Size = new System.Drawing.Size(42, 13);
            this.clcGenderLabel.TabIndex = 1;
            this.clcGenderLabel.Text = "Gender";
            // 
            // clcAgeLabel
            // 
            this.clcAgeLabel.AutoSize = true;
            this.clcAgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.clcAgeLabel.Location = new System.Drawing.Point(78, 79);
            this.clcAgeLabel.Name = "clcAgeLabel";
            this.clcAgeLabel.Size = new System.Drawing.Size(26, 13);
            this.clcAgeLabel.TabIndex = 2;
            this.clcAgeLabel.Text = "Age";
            // 
            // clcWeightLabel
            // 
            this.clcWeightLabel.AutoSize = true;
            this.clcWeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.clcWeightLabel.Location = new System.Drawing.Point(378, 52);
            this.clcWeightLabel.Name = "clcWeightLabel";
            this.clcWeightLabel.Size = new System.Drawing.Size(41, 13);
            this.clcWeightLabel.TabIndex = 4;
            this.clcWeightLabel.Text = "Weight";
            // 
            // clcHeightLabel
            // 
            this.clcHeightLabel.AutoSize = true;
            this.clcHeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.clcHeightLabel.Location = new System.Drawing.Point(381, 78);
            this.clcHeightLabel.Name = "clcHeightLabel";
            this.clcHeightLabel.Size = new System.Drawing.Size(38, 13);
            this.clcHeightLabel.TabIndex = 5;
            this.clcHeightLabel.Text = "Height";
            // 
            // clcGenderComboBox
            // 
            this.clcGenderComboBox.FormattingEnabled = true;
            this.clcGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.clcGenderComboBox.Location = new System.Drawing.Point(110, 49);
            this.clcGenderComboBox.Name = "clcGenderComboBox";
            this.clcGenderComboBox.Size = new System.Drawing.Size(121, 21);
            this.clcGenderComboBox.TabIndex = 8;
            // 
            // clcAgeTextBox
            // 
            this.clcAgeTextBox.Location = new System.Drawing.Point(110, 76);
            this.clcAgeTextBox.Name = "clcAgeTextBox";
            this.clcAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.clcAgeTextBox.TabIndex = 9;
            // 
            // clcWeightTextBox
            // 
            this.clcWeightTextBox.Location = new System.Drawing.Point(425, 49);
            this.clcWeightTextBox.Name = "clcWeightTextBox";
            this.clcWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.clcWeightTextBox.TabIndex = 10;
            // 
            // clcWeightMeasureUnit
            // 
            this.clcWeightMeasureUnit.AutoSize = true;
            this.clcWeightMeasureUnit.BackColor = System.Drawing.Color.Transparent;
            this.clcWeightMeasureUnit.Location = new System.Drawing.Point(531, 52);
            this.clcWeightMeasureUnit.Name = "clcWeightMeasureUnit";
            this.clcWeightMeasureUnit.Size = new System.Drawing.Size(19, 13);
            this.clcWeightMeasureUnit.TabIndex = 11;
            this.clcWeightMeasureUnit.Text = "kg";
            // 
            // clcHeightTextBox
            // 
            this.clcHeightTextBox.Location = new System.Drawing.Point(425, 75);
            this.clcHeightTextBox.Name = "clcHeightTextBox";
            this.clcHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.clcHeightTextBox.TabIndex = 12;
            // 
            // clcHeightMeasureUnit
            // 
            this.clcHeightMeasureUnit.AutoSize = true;
            this.clcHeightMeasureUnit.BackColor = System.Drawing.Color.Transparent;
            this.clcHeightMeasureUnit.Location = new System.Drawing.Point(531, 79);
            this.clcHeightMeasureUnit.Name = "clcHeightMeasureUnit";
            this.clcHeightMeasureUnit.Size = new System.Drawing.Size(21, 13);
            this.clcHeightMeasureUnit.TabIndex = 13;
            this.clcHeightMeasureUnit.Text = "cm";
            // 
            // clcActivityLevelLabel
            // 
            this.clcActivityLevelLabel.AutoSize = true;
            this.clcActivityLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.clcActivityLevelLabel.Location = new System.Drawing.Point(34, 107);
            this.clcActivityLevelLabel.Name = "clcActivityLevelLabel";
            this.clcActivityLevelLabel.Size = new System.Drawing.Size(70, 13);
            this.clcActivityLevelLabel.TabIndex = 14;
            this.clcActivityLevelLabel.Text = "Activity Level";
            // 
            // clcActivityLevelPanel
            // 
            this.clcActivityLevelPanel.BackColor = System.Drawing.Color.Transparent;
            this.clcActivityLevelPanel.Controls.Add(this.clcExtraActiveRadioBtn);
            this.clcActivityLevelPanel.Controls.Add(this.clcSedentaryRadioBtn);
            this.clcActivityLevelPanel.Controls.Add(this.clcVeryActiveRadioBtn);
            this.clcActivityLevelPanel.Controls.Add(this.clcLightActivityRadioBtn);
            this.clcActivityLevelPanel.Controls.Add(this.clcModerateActivityRadioBtn);
            this.clcActivityLevelPanel.Location = new System.Drawing.Point(110, 102);
            this.clcActivityLevelPanel.Name = "clcActivityLevelPanel";
            this.clcActivityLevelPanel.Size = new System.Drawing.Size(398, 116);
            this.clcActivityLevelPanel.TabIndex = 15;
            // 
            // clcExtraActiveRadioBtn
            // 
            this.clcExtraActiveRadioBtn.AutoSize = true;
            this.clcExtraActiveRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcExtraActiveRadioBtn.Location = new System.Drawing.Point(3, 95);
            this.clcExtraActiveRadioBtn.Name = "clcExtraActiveRadioBtn";
            this.clcExtraActiveRadioBtn.Size = new System.Drawing.Size(390, 17);
            this.clcExtraActiveRadioBtn.TabIndex = 16;
            this.clcExtraActiveRadioBtn.Text = "Extra active (very hard exercise/sports 6 to 7 days per week and physical job)\r\n";
            this.clcExtraActiveRadioBtn.UseVisualStyleBackColor = false;
            // 
            // clcSedentaryRadioBtn
            // 
            this.clcSedentaryRadioBtn.AutoSize = true;
            this.clcSedentaryRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcSedentaryRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.clcSedentaryRadioBtn.Name = "clcSedentaryRadioBtn";
            this.clcSedentaryRadioBtn.Size = new System.Drawing.Size(175, 17);
            this.clcSedentaryRadioBtn.TabIndex = 12;
            this.clcSedentaryRadioBtn.Text = "Sedentary (little or no excercise)\r\n";
            this.clcSedentaryRadioBtn.UseVisualStyleBackColor = false;
            // 
            // clcVeryActiveRadioBtn
            // 
            this.clcVeryActiveRadioBtn.AutoSize = true;
            this.clcVeryActiveRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcVeryActiveRadioBtn.Location = new System.Drawing.Point(3, 72);
            this.clcVeryActiveRadioBtn.Name = "clcVeryActiveRadioBtn";
            this.clcVeryActiveRadioBtn.Size = new System.Drawing.Size(285, 17);
            this.clcVeryActiveRadioBtn.TabIndex = 15;
            this.clcVeryActiveRadioBtn.Text = "Very active (hard exercise/sports 6 to 7 days per week)\r\n";
            this.clcVeryActiveRadioBtn.UseVisualStyleBackColor = false;
            // 
            // clcLightActivityRadioBtn
            // 
            this.clcLightActivityRadioBtn.AutoSize = true;
            this.clcLightActivityRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcLightActivityRadioBtn.Location = new System.Drawing.Point(3, 26);
            this.clcLightActivityRadioBtn.Name = "clcLightActivityRadioBtn";
            this.clcLightActivityRadioBtn.Size = new System.Drawing.Size(289, 17);
            this.clcLightActivityRadioBtn.TabIndex = 13;
            this.clcLightActivityRadioBtn.Text = "Light activity (light exercise/sports 1 to 3 days per week)\r\n";
            this.clcLightActivityRadioBtn.UseVisualStyleBackColor = false;
            // 
            // clcModerateActivityRadioBtn
            // 
            this.clcModerateActivityRadioBtn.AutoSize = true;
            this.clcModerateActivityRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcModerateActivityRadioBtn.Location = new System.Drawing.Point(3, 49);
            this.clcModerateActivityRadioBtn.Name = "clcModerateActivityRadioBtn";
            this.clcModerateActivityRadioBtn.Size = new System.Drawing.Size(336, 17);
            this.clcModerateActivityRadioBtn.TabIndex = 14;
            this.clcModerateActivityRadioBtn.Text = "Moderate activity (moderate exercise/sports 3 to 5 days per week)\r\n";
            this.clcModerateActivityRadioBtn.UseVisualStyleBackColor = false;
            // 
            // clcGoalPanel
            // 
            this.clcGoalPanel.BackColor = System.Drawing.Color.Transparent;
            this.clcGoalPanel.Controls.Add(this.clcGoalGainRadioBtn);
            this.clcGoalPanel.Controls.Add(this.clcGoalLoseRadioBtn);
            this.clcGoalPanel.Controls.Add(this.clcGoalMaintainRadioBtn);
            this.clcGoalPanel.Location = new System.Drawing.Point(110, 224);
            this.clcGoalPanel.Name = "clcGoalPanel";
            this.clcGoalPanel.Size = new System.Drawing.Size(115, 69);
            this.clcGoalPanel.TabIndex = 16;
            // 
            // clcGoalGainRadioBtn
            // 
            this.clcGoalGainRadioBtn.AutoSize = true;
            this.clcGoalGainRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcGoalGainRadioBtn.Location = new System.Drawing.Point(3, 49);
            this.clcGoalGainRadioBtn.Name = "clcGoalGainRadioBtn";
            this.clcGoalGainRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.clcGoalGainRadioBtn.TabIndex = 16;
            this.clcGoalGainRadioBtn.TabStop = true;
            this.clcGoalGainRadioBtn.Text = "gain weight";
            this.clcGoalGainRadioBtn.UseVisualStyleBackColor = false;
            this.clcGoalGainRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clcGoalGainRadioBtn_Click);

            // 
            // clcGoalLoseRadioBtn
            // 
            this.clcGoalLoseRadioBtn.AutoSize = true;
            this.clcGoalLoseRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcGoalLoseRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.clcGoalLoseRadioBtn.Name = "clcGoalLoseRadioBtn";
            this.clcGoalLoseRadioBtn.Size = new System.Drawing.Size(78, 17);
            this.clcGoalLoseRadioBtn.TabIndex = 14;
            this.clcGoalLoseRadioBtn.TabStop = true;
            this.clcGoalLoseRadioBtn.Text = "lose weight";
            this.clcGoalLoseRadioBtn.UseVisualStyleBackColor = false;
            this.clcGoalLoseRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clcGoalLoseRadioBtn_Click);
            // 
            // clcGoalMaintainRadioBtn
            // 
            this.clcGoalMaintainRadioBtn.AutoSize = true;
            this.clcGoalMaintainRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcGoalMaintainRadioBtn.Location = new System.Drawing.Point(3, 26);
            this.clcGoalMaintainRadioBtn.Name = "clcGoalMaintainRadioBtn";
            this.clcGoalMaintainRadioBtn.Size = new System.Drawing.Size(98, 17);
            this.clcGoalMaintainRadioBtn.TabIndex = 15;
            this.clcGoalMaintainRadioBtn.TabStop = true;
            this.clcGoalMaintainRadioBtn.Text = "maintain weight";
            this.clcGoalMaintainRadioBtn.UseVisualStyleBackColor = false;
            this.clcGoalMaintainRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clcGoalMaintainRadioBtn_Click);
            // 
            // clcGoalLabel
            // 
            this.clcGoalLabel.AutoSize = true;
            this.clcGoalLabel.BackColor = System.Drawing.Color.Transparent;
            this.clcGoalLabel.Location = new System.Drawing.Point(56, 229);
            this.clcGoalLabel.Name = "clcGoalLabel";
            this.clcGoalLabel.Size = new System.Drawing.Size(48, 13);
            this.clcGoalLabel.TabIndex = 17;
            this.clcGoalLabel.Text = "I want to";
            // 
            // clcGoalAmountPanel
            // 
            this.clcGoalAmountPanel.BackColor = System.Drawing.Color.Transparent;
            this.clcGoalAmountPanel.Controls.Add(this.clcOneRadioBtn);
            this.clcGoalAmountPanel.Controls.Add(this.clcQuarterRadioBtn);
            this.clcGoalAmountPanel.Controls.Add(this.clcThreeQuartersRadioBtn);
            this.clcGoalAmountPanel.Controls.Add(this.clcHalfRadioBtn);
            this.clcGoalAmountPanel.Location = new System.Drawing.Point(360, 224);
            this.clcGoalAmountPanel.Name = "clcGoalAmountPanel";
            this.clcGoalAmountPanel.Size = new System.Drawing.Size(102, 90);
            this.clcGoalAmountPanel.TabIndex = 18;
            this.clcGoalAmountPanel.Visible = false;
            // 
            // clcOneRadioBtn
            // 
            this.clcOneRadioBtn.AutoSize = true;
            this.clcOneRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcOneRadioBtn.Location = new System.Drawing.Point(3, 72);
            this.clcOneRadioBtn.Name = "clcOneRadioBtn";
            this.clcOneRadioBtn.Size = new System.Drawing.Size(77, 17);
            this.clcOneRadioBtn.TabIndex = 19;
            this.clcOneRadioBtn.TabStop = true;
            this.clcOneRadioBtn.Text = "1 kg/week";
            this.clcOneRadioBtn.UseVisualStyleBackColor = false;
            // 
            // clcQuarterRadioBtn
            // 
            this.clcQuarterRadioBtn.AutoSize = true;
            this.clcQuarterRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcQuarterRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.clcQuarterRadioBtn.Name = "clcQuarterRadioBtn";
            this.clcQuarterRadioBtn.Size = new System.Drawing.Size(92, 17);
            this.clcQuarterRadioBtn.TabIndex = 16;
            this.clcQuarterRadioBtn.TabStop = true;
            this.clcQuarterRadioBtn.Text = "0.25 kg/week";
            this.clcQuarterRadioBtn.UseVisualStyleBackColor = false;
            // 
            // clcThreeQuartersRadioBtn
            // 
            this.clcThreeQuartersRadioBtn.AutoSize = true;
            this.clcThreeQuartersRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcThreeQuartersRadioBtn.Location = new System.Drawing.Point(3, 49);
            this.clcThreeQuartersRadioBtn.Name = "clcThreeQuartersRadioBtn";
            this.clcThreeQuartersRadioBtn.Size = new System.Drawing.Size(92, 17);
            this.clcThreeQuartersRadioBtn.TabIndex = 18;
            this.clcThreeQuartersRadioBtn.TabStop = true;
            this.clcThreeQuartersRadioBtn.Text = "0.75 kg/week";
            this.clcThreeQuartersRadioBtn.UseVisualStyleBackColor = false;
            // 
            // clcHalfRadioBtn
            // 
            this.clcHalfRadioBtn.AutoSize = true;
            this.clcHalfRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.clcHalfRadioBtn.Location = new System.Drawing.Point(3, 26);
            this.clcHalfRadioBtn.Name = "clcHalfRadioBtn";
            this.clcHalfRadioBtn.Size = new System.Drawing.Size(86, 17);
            this.clcHalfRadioBtn.TabIndex = 17;
            this.clcHalfRadioBtn.TabStop = true;
            this.clcHalfRadioBtn.Text = "0.5 kg/week";
            this.clcHalfRadioBtn.UseVisualStyleBackColor = false;
            // 
            // clcGoalAmountLabel
            // 
            this.clcGoalAmountLabel.AutoSize = true;
            this.clcGoalAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.clcGoalAmountLabel.Location = new System.Drawing.Point(259, 229);
            this.clcGoalAmountLabel.Name = "clcGoalAmountLabel";
            this.clcGoalAmountLabel.Size = new System.Drawing.Size(95, 13);
            this.clcGoalAmountLabel.TabIndex = 19;
            this.clcGoalAmountLabel.Text = "I want to lose/gain";
            this.clcGoalAmountLabel.Visible = false;
            // 
            // clcCalorieLimitTextBox
            // 
            this.clcCalorieLimitTextBox.AcceptsReturn = true;
            this.clcCalorieLimitTextBox.Location = new System.Drawing.Point(237, 326);
            this.clcCalorieLimitTextBox.Name = "clcCalorieLimitTextBox";
            this.clcCalorieLimitTextBox.ReadOnly = true;
            this.clcCalorieLimitTextBox.Size = new System.Drawing.Size(100, 20);
            this.clcCalorieLimitTextBox.TabIndex = 20;
            // 
            // clcCalculateCalorieLimitBtn
            // 
            this.clcCalculateCalorieLimitBtn.Location = new System.Drawing.Point(343, 324);
            this.clcCalculateCalorieLimitBtn.Name = "clcCalculateCalorieLimitBtn";
            this.clcCalculateCalorieLimitBtn.Size = new System.Drawing.Size(75, 23);
            this.clcCalculateCalorieLimitBtn.TabIndex = 21;
            this.clcCalculateCalorieLimitBtn.Text = "Calculate";
            this.clcCalculateCalorieLimitBtn.UseVisualStyleBackColor = true;
            this.clcCalculateCalorieLimitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clcCalculateCalorieLimitBtn_Click);
            // 
            // clcSaveCalorieLimitBtn
            // 
            this.clcSaveCalorieLimitBtn.Location = new System.Drawing.Point(424, 324);
            this.clcSaveCalorieLimitBtn.Name = "clcSaveCalorieLimitBtn";
            this.clcSaveCalorieLimitBtn.Size = new System.Drawing.Size(75, 23);
            this.clcSaveCalorieLimitBtn.TabIndex = 22;
            this.clcSaveCalorieLimitBtn.Text = "Save";
            this.clcSaveCalorieLimitBtn.UseVisualStyleBackColor = true;
            this.clcSaveCalorieLimitBtn.Click += new System.EventHandler(this.clcSaveCalorieLimitBtn_Click);
            // 
            // clcCalorieLimitLabel
            // 
            this.clcCalorieLimitLabel.AutoSize = true;
            this.clcCalorieLimitLabel.BackColor = System.Drawing.Color.Transparent;
            this.clcCalorieLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clcCalorieLimitLabel.Location = new System.Drawing.Point(49, 329);
            this.clcCalorieLimitLabel.Name = "clcCalorieLimitLabel";
            this.clcCalorieLimitLabel.Size = new System.Drawing.Size(182, 13);
            this.clcCalorieLimitLabel.TabIndex = 23;
            this.clcCalorieLimitLabel.Text = "My ideal daily calorie intake is:";
            // 
            // frmCalorieLimitCalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clcCalorieLimitLabel);
            this.Controls.Add(this.clcSaveCalorieLimitBtn);
            this.Controls.Add(this.clcCalculateCalorieLimitBtn);
            this.Controls.Add(this.clcCalorieLimitTextBox);
            this.Controls.Add(this.clcGoalAmountLabel);
            this.Controls.Add(this.clcGoalAmountPanel);
            this.Controls.Add(this.clcGoalLabel);
            this.Controls.Add(this.clcGoalPanel);
            this.Controls.Add(this.clcActivityLevelPanel);
            this.Controls.Add(this.clcActivityLevelLabel);
            this.Controls.Add(this.clcHeightMeasureUnit);
            this.Controls.Add(this.clcHeightTextBox);
            this.Controls.Add(this.clcWeightMeasureUnit);
            this.Controls.Add(this.clcWeightTextBox);
            this.Controls.Add(this.clcAgeTextBox);
            this.Controls.Add(this.clcGenderComboBox);
            this.Controls.Add(this.clcHeightLabel);
            this.Controls.Add(this.clcWeightLabel);
            this.Controls.Add(this.clcAgeLabel);
            this.Controls.Add(this.clcGenderLabel);
            this.Controls.Add(this.NavigationBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.NavigationBar;
            this.Name = "frmCalorieLimitCalculatorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalorieCounter";
            this.NavigationBar.ResumeLayout(false);
            this.NavigationBar.PerformLayout();
            this.clcActivityLevelPanel.ResumeLayout(false);
            this.clcActivityLevelPanel.PerformLayout();
            this.clcGoalPanel.ResumeLayout(false);
            this.clcGoalPanel.PerformLayout();
            this.clcGoalAmountPanel.ResumeLayout(false);
            this.clcGoalAmountPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NavigationBar;
        private System.Windows.Forms.ToolStripMenuItem dailyIntakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calorieLimitCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProgressToolStripMenuItem;
        private System.Windows.Forms.Label clcGenderLabel;
        private System.Windows.Forms.Label clcAgeLabel;
        private System.Windows.Forms.Label clcWeightLabel;
        private System.Windows.Forms.Label clcHeightLabel;
        private System.Windows.Forms.ComboBox clcGenderComboBox;
        private System.Windows.Forms.TextBox clcAgeTextBox;
        private System.Windows.Forms.TextBox clcWeightTextBox;
        private System.Windows.Forms.Label clcWeightMeasureUnit;
        private System.Windows.Forms.TextBox clcHeightTextBox;
        private System.Windows.Forms.Label clcHeightMeasureUnit;
        private System.Windows.Forms.Label clcActivityLevelLabel;
        private System.Windows.Forms.Panel clcActivityLevelPanel;
        private System.Windows.Forms.RadioButton clcExtraActiveRadioBtn;
        private System.Windows.Forms.RadioButton clcSedentaryRadioBtn;
        private System.Windows.Forms.RadioButton clcVeryActiveRadioBtn;
        private System.Windows.Forms.RadioButton clcLightActivityRadioBtn;
        private System.Windows.Forms.RadioButton clcModerateActivityRadioBtn;
        private System.Windows.Forms.Panel clcGoalPanel;
        private System.Windows.Forms.RadioButton clcGoalGainRadioBtn;
        private System.Windows.Forms.RadioButton clcGoalLoseRadioBtn;
        private System.Windows.Forms.RadioButton clcGoalMaintainRadioBtn;
        private System.Windows.Forms.Label clcGoalLabel;
        private System.Windows.Forms.Panel clcGoalAmountPanel;
        private System.Windows.Forms.RadioButton clcOneRadioBtn;
        private System.Windows.Forms.RadioButton clcQuarterRadioBtn;
        private System.Windows.Forms.RadioButton clcThreeQuartersRadioBtn;
        private System.Windows.Forms.RadioButton clcHalfRadioBtn;
        private System.Windows.Forms.Label clcGoalAmountLabel;
        private System.Windows.Forms.TextBox clcCalorieLimitTextBox;
        private System.Windows.Forms.Button clcCalculateCalorieLimitBtn;
        private System.Windows.Forms.Button clcSaveCalorieLimitBtn;
        private System.Windows.Forms.Label clcCalorieLimitLabel;
    }
}