using CalorieCounter.BaseLib;
using CalorieCounter.Controllers;
using CalorieCounter.DAL;
using CalorieCounter.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class frmCalorieLimitCalculatorWindow : Form
    {
        private readonly IInitialRunController _controller = null;
        private ICalorieLimitCalculationController _calorieLimitCalculationController = null;
        private IUserController _userController = null;
        private IRepositoryFactory _repositoryFactory;
        private readonly WindowFormsFactory _formsFactory = new WindowFormsFactory();
        private User user;
        private Thread th;

        public frmCalorieLimitCalculatorWindow(IInitialRunController inController, IUserController inUserController, IRepositoryFactory inRepositoryFactory, User inUser)
        {
            _controller = inController;
            _userController = inUserController;
            _repositoryFactory = inRepositoryFactory;
            user = inUser;
            InitializeComponent();
        }

        private void clcGoalLoseRadioBtn_Click(object sender, MouseEventArgs e)
        {
            clcGoalAmountLabel.Visible = true;
            clcGoalAmountPanel.Visible = true;
        }

        private void clcGoalMaintainRadioBtn_Click(object sender, MouseEventArgs e)
        {
            clcGoalAmountLabel.Visible = false;
            clcGoalAmountPanel.Visible = false;
        }

        private void clcGoalGainRadioBtn_Click(object sender, MouseEventArgs e)
        {
            clcGoalAmountLabel.Visible = true;
            clcGoalAmountPanel.Visible = true;
        }

        public void ShowModaless(ICalorieLimitCalculationController inCalorieLimitCalculationController)
        {
            _calorieLimitCalculationController = inCalorieLimitCalculationController;
            this.Show();
        }

        public int ParseActivityLevel(string input)
        {
            int activityLvl = 0;
            switch (input.Split(' ')[0])
            {
                case "Sedentary":
                    activityLvl = (int)ActivityLevelEnum.Sedentary;
                    break;
                case "Light":
                    activityLvl = (int)ActivityLevelEnum.LightActivity;
                    break;
                case "Moderate":
                    activityLvl = (int)ActivityLevelEnum.ModerateActivity;
                    break;
                case "Very":
                    activityLvl = (int)ActivityLevelEnum.VeryActive;
                    break;
                case "Extra":
                    activityLvl = (int)ActivityLevelEnum.ExtraActive;
                    break;
                default:
                    break;
            }

            return activityLvl;
        }

        public int ParseGoal(string input)
        {
            int goalValue = 0;
            switch (input.Split(' ')[0])
            {
                case "lose":
                    goalValue = (int)GoalsEnum.LoseWeight;
                    break;
                case "maintain":
                    goalValue = (int)GoalsEnum.MaintainWeight;
                    break;
                case "gain":
                    goalValue = (int)GoalsEnum.GainWeight;
                    break;
                default:
                    break;
            }

            return goalValue;
        }

        public int ParseGoalAmount(string input)
        {
            int goalAmountValue = 0;
            switch (input.Split(' ')[0])
            {
                case "0.25":
                    goalAmountValue = (int)GoalAmountEnum.Quarter;
                    break;
                case "0.5":
                    goalAmountValue = (int)GoalAmountEnum.Half;
                    break;
                case "0.75":
                    goalAmountValue = (int)GoalAmountEnum.ThreeQuarters;
                    break;
                case "1":
                    goalAmountValue = (int)GoalAmountEnum.One;
                    break;
                default:
                    break;
            }

            return goalAmountValue;
        }

        private void clcCalculateCalorieLimitBtn_Click(object sender, EventArgs e)
        {
            int gender = (int)(clcGenderComboBox.Text.Equals("Male") ? GenderEnum.Male : GenderEnum.Female);
            string activityLevelInput = clcActivityLevelPanel.Controls.OfType<RadioButton>().FirstOrDefault(t => t.Checked).Text;
            int activityLevel = ParseActivityLevel(activityLevelInput);
            string goalInput = clcGoalPanel.Controls.OfType<RadioButton>().FirstOrDefault(t => t.Checked).Text;
            int goal = ParseGoal(goalInput);
            int goalAmount;
            if ((int)GoalsEnum.MaintainWeight != goal) {
                string goalAmountInput = clcGoalAmountPanel.Controls.OfType<RadioButton>().FirstOrDefault(t => t.Checked).Text;
                goalAmount = ParseGoalAmount(goalAmountInput);
            }
            else
            {
                goalAmount = 0;
            }
            //string goalAmountInput = clcGoalAmountPanel.Controls.OfType<RadioButton>().FirstOrDefault(t => t.Checked).Text;
            //int goalAmount = ((int)GoalsEnum.MaintainWeight == goal) ? 0 : ParseGoalAmount(goalAmountInput);
            double height = 0, weight = 0;
            int age = 0;

            try
            {
                height = Double.Parse(clcHeightTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + clcHeightTextBox.Text + "' koju ste unijeli za visinu nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            try
            {
                weight = Double.Parse(clcWeightTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + clcWeightTextBox.Text + "' koju ste unijeli za masu nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            try
            {
                age = Int32.Parse(clcAgeTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + clcAgeTextBox.Text + "' koju ste unijeli za godine nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            double calorieLimit = _controller.ShowCalorieLimit(height, weight, age, gender, activityLevel, goal, goalAmount);
            clcCalorieLimitTextBox.Text = calorieLimit.ToString(CultureInfo.InvariantCulture);
        }

        private void clcSaveCalorieLimitBtn_Click(object sender, EventArgs e)
        {
            if (clcCalorieLimitTextBox.Text == null || clcCalorieLimitTextBox.Text == "")
            {
                MessageBox.Show("Ne možete spremiti dnevni kalorijski unos jer ga niste izračunali! Ispunite formu, izračunajte kalorijski unos i pokušajte ponovno spremiti.");
                return;
            }

            _userController.UpdateUser(Double.Parse(clcCalorieLimitTextBox.Text, CultureInfo.InvariantCulture));
        }

        private void RunOnNextForm(Form form)
        {
            Application.Run(form);
        }

        private void dailyIntakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFoodDatabaseController _foodDatabaseController = new FoodDatabaseController(_formsFactory, _repositoryFactory);
            IFoodController _foodController = new FoodController(_formsFactory, _repositoryFactory);
            var dailyIntakeForm = new frmDailyIntakeWindow(_foodDatabaseController, _foodController, _repositoryFactory, user);
            this.Close();
            th = new Thread(delegate () {
                RunOnNextForm(dailyIntakeForm);
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void foodDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFoodDatabaseController _foodDatabaseController = new FoodDatabaseController(_formsFactory, _repositoryFactory);
            IFoodController _foodController = new FoodController(_formsFactory, _repositoryFactory);
            var foodDatabaseForm = new frmFoodDatabaseWindow(_foodDatabaseController, _foodController, _repositoryFactory, user);
            this.Close();
            th = new Thread(delegate ()
            {
                RunOnNextForm(foodDatabaseForm);
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void calorieLimitCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void myProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IUserController _userController = new UserController(_formsFactory, _repositoryFactory);
            IProgressController _progressController = new ProgressController(_formsFactory, _repositoryFactory);
            var progressForm = new frmUserProgressWindow(_userController, _progressController, _repositoryFactory);
            this.Close();
            th = new Thread(delegate () {
                RunOnNextForm(progressForm);
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
