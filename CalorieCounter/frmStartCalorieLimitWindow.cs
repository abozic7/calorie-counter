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
    public partial class frmStartCalorieLimitWindow : Form, ICalorieLimitCalculationView
    {
        private readonly IInitialRunController _controller = null;
        private ICalorieLimitCalculationController _calorieLimitCalculationController = null;
        private IUserController _userController = null;
        private IRepositoryFactory _repositoryFactory;
        private readonly WindowFormsFactory _formsFactory = new WindowFormsFactory();
        private Thread th;

        public frmStartCalorieLimitWindow(IInitialRunController inController, IUserController inUserController, IRepositoryFactory inRepositoryFactory)
        {
            _controller = inController;
            _userController = inUserController;
            _repositoryFactory = inRepositoryFactory;
            InitializeComponent();
        }

        private void GoalLoseRadioBtnStart_Click(object sender, MouseEventArgs e)
        {
            goalAmountLabelStart.Visible = true;
            goalAmountPanelStart.Visible = true;
        }

        private void GoalMaintainRadioBtnStart_Click(object sender, MouseEventArgs e)
        {
            goalAmountLabelStart.Visible = false;
            goalAmountPanelStart.Visible = false;
        }

        private void GoalGainRadioBtnStart_Click(object sender, MouseEventArgs e)
        {
            goalAmountLabelStart.Visible = true;
            goalAmountPanelStart.Visible = true;
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

        private void calculateCalorieLimitBtnStart_Click(object sender, EventArgs e)
        {
            int gender = (int) (genderComboBoxStart.Text.Equals("Male") ? GenderEnum.Male : GenderEnum.Female);
            string activityLevelInput = activityLevelPanelStart.Controls.OfType<RadioButton>().FirstOrDefault(t => t.Checked).Text;
            int activityLevel = ParseActivityLevel(activityLevelInput);
            string goalInput = goalPanelStart.Controls.OfType<RadioButton>().FirstOrDefault(t => t.Checked).Text;
            int goal = ParseGoal(goalInput);
            int goalAmount;
            if ((int)GoalsEnum.MaintainWeight != goal)
            {
                string goalAmountInput = goalAmountPanelStart.Controls.OfType<RadioButton>().FirstOrDefault(t => t.Checked).Text;
                goalAmount = ParseGoalAmount(goalAmountInput);
            }
            else
            {
                goalAmount = 0;
            }
            //string goalAmountInput = goalAmountPanelStart.Controls.OfType<RadioButton>().FirstOrDefault(t => t.Checked).Text;
            //int goalAmount = ((int)GoalsEnum.MaintainWeight == goal) ? 0 : ParseGoalAmount(goalAmountInput);
            double height = 0, weight = 0;
            int age = 0;

            try
            {
                height = Double.Parse(heightTextBoxStart.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + heightTextBoxStart.Text + "' koju ste unijeli za visinu nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            try
            {
                weight = Double.Parse(weightTextBoxStart.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + weightTextBoxStart.Text + "' koju ste unijeli za masu nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            try
            {
                age = Int32.Parse(ageTextBoxStart.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + ageTextBoxStart.Text + "' koju ste unijeli za godine nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            double calorieLimit = _controller.ShowCalorieLimit(height, weight, age, gender, activityLevel, goal, goalAmount);
            calorieLimitTextBoxStart.Text = calorieLimit.ToString();
        }

        private void saveCalorieLimitBtnStart_Click(object sender, EventArgs e)
        {
            if (calorieLimitTextBoxStart.Text == null || calorieLimitTextBoxStart.Text == "")
            {
                MessageBox.Show("Ne možete spremiti dnevni kalorijski unos jer ga niste izračunali! Ispunite formu, izračunajte kalorijski unos i pokušajte ponovno spremiti.");
                return;
            }

            _userController.AddUser(Double.Parse(calorieLimitTextBoxStart.Text, CultureInfo.InvariantCulture));

            IFoodDatabaseController _foodDatabaseController = new FoodDatabaseController(_formsFactory, _repositoryFactory);
            IFoodController _foodController = new FoodController(_formsFactory, _repositoryFactory);
            User user = _userController.GetUser();
            var dailyIntakeForm = new frmDailyIntakeWindow(_foodDatabaseController, _foodController, _repositoryFactory, user);
            this.Close();
            th = new Thread(delegate ()
            {
                RunOnNextForm(dailyIntakeForm);
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void RunOnNextForm(Form form)
        {
            Application.Run(form);
        }
    }
}
