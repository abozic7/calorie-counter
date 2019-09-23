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
    public partial class frmDailyIntakeWindow : Form
    {
        private IFoodDatabaseController _foodDatabaseController = null;
        private IFoodController _foodController;
        private IRepositoryFactory _repositoryFactory;
        private readonly WindowFormsFactory _formsFactory = new WindowFormsFactory();
        private List<Food> foodDatabase;
        private List<Food> consumedFood;
        private User user;
        private double noOfServingsPrevValue;
        private Thread th;

        public frmDailyIntakeWindow(IFoodDatabaseController inFoodDatabaseController, IFoodController inFoodController, IRepositoryFactory inRepositoryFactory, User inUser)
        {
            user = inUser;
            _foodDatabaseController = inFoodDatabaseController;
            _foodController = inFoodController;
            _repositoryFactory = inRepositoryFactory;
            foodDatabase = new List<Food>();
            consumedFood = new List<Food>();
            InitializeComponent();
            dailyIntakeFoodDtbTable.CellClick += new DataGridViewCellEventHandler(dailyIntakeFoodDtbTable_CellClick);
            consumedFoodTable.CellClick += new DataGridViewCellEventHandler(consumedFoodTable_CellClick);
            //chosenFoodNumberOfServingsTextBox.TextChanged += chosenFoodNumberOfServingsTextBox_TextChanged;
            chosenFoodNumberOfServingsNumericUpDown.ValueChanged += chosenFoodNumberOfServingsNumericUpDown_ValueChanged;
        }

        private void InitializeTables()
        {
            InitializeFoodDatabaseTable();
            InitializeConsumedFoodTable();
        }

        private void InitializeFoodDatabaseTable()
        {
            foodDatabase = _foodDatabaseController.GetAllFood();
            var foodTable = new DataTable();
            foodTable.Columns.Add("DailyIntakeFoodDtbName", typeof(string));
            foodTable.Columns.Add("DailyIntakeFoodDtbServingSize", typeof(string));
            foodTable.Columns.Add("DailyIntakeFoodDtbCalories", typeof(string));
            foreach (var food in foodDatabase)
            {
                DataRow entry = foodTable.NewRow();
                entry[0] = food.Name;
                entry[1] = food.ServingSize + " " + food.ServingSizeUnit;
                entry[2] = food.CaloriesInServing;
                foodTable.Rows.Add(entry);
            }
            dailyIntakeFoodDtbTable.DataSource = foodTable;
        }

        private void InitializeConsumedFoodTable()
        {
            consumedFood = _foodController.GetConsumedFood();
            var foodTable = new DataTable();
            foodTable.Columns.Add("ConsumedFoodName", typeof(string));
            foodTable.Columns.Add("ConsumedFoodSize", typeof(string));
            foodTable.Columns.Add("ConsumedFoodCalories", typeof(string));
            foreach (var food in consumedFood)
            {
                DataRow entry = foodTable.NewRow();
                entry[0] = food.Name;
                entry[1] = food.ServingSize * food.NumberOfServings + " " + food.ServingSizeUnit;
                entry[2] = food.CaloriesInServing * food.NumberOfServings;
                foodTable.Rows.Add(entry);
            }
            consumedFoodTable.DataSource = foodTable;
        }

        private void ChangeCaloriesRatio()
        {
            DataTable foodTable = (DataTable)consumedFoodTable.DataSource;
            var rows = foodTable.Rows;
            if (rows.Count == 0)
            {
                caloriesConsumedTextBox.Text = 0.ToString();
                caloriesRemainingTextBox.Text = user.CalorieLimit.ToString();
            }
            else
            {
                double consumedCalories = 0;
                foreach (DataRow row in rows)
                {
                    consumedCalories += Double.Parse(row["ConsumedFoodCalories"].ToString(), CultureInfo.InvariantCulture);
                }
                caloriesConsumedTextBox.Text = consumedCalories.ToString();
                caloriesRemainingTextBox.Text = (user.CalorieLimit - consumedCalories).ToString();
            }
        }

        private void dailyIntakeFoodDtbSearchBtn_Click(object sender, EventArgs e)
        {
            string input = dailyIntakeFoodDtbSearchTextBox.Text;
            List<Food> searchResults = _foodDatabaseController.Search(input, foodDatabase);
            var foodTable = new DataTable();
            foodTable.Columns.Add("DailyIntakeFoodDtbName", typeof(string));
            foodTable.Columns.Add("DailyIntakeFoodDtbServingSize", typeof(string));
            foodTable.Columns.Add("DailyIntakeFoodDtbCalories", typeof(string));
            foreach (var food in searchResults)
            {
                DataRow entry = foodTable.NewRow();
                entry[0] = food.Name;
                entry[1] = food.ServingSize + " " + food.ServingSizeUnit;
                entry[2] = food.CaloriesInServing;
                foodTable.Rows.Add(entry);
            }
            dailyIntakeFoodDtbTable.DataSource = foodTable;
        }

        private void frmDailyIntakeWindow_Load(object sender, EventArgs e)
        {
            InitializeTables();
            ChangeCaloriesRatio();
        }

        public void AddRowToConsumedFoodTable(Food food)
        {
            DataTable foodTable = (DataTable) consumedFoodTable.DataSource;
            DataRow entry = foodTable.NewRow();
            entry[0] = food.Name;
            entry[1] = food.ServingSize * food.NumberOfServings + " " + food.ServingSizeUnit;
            entry[2] = food.CaloriesInServing * food.NumberOfServings;
            foodTable.Rows.Add(entry);
        }

        private void addToListBtn_Click(object sender, EventArgs e)
        {
            string chosenFoodName = chosenFoodNameTextBox.Text;
            double chosenFoodNumberOfServings = (double)chosenFoodNumberOfServingsNumericUpDown.Value;
            Food chosenFood = foodDatabase.Where(t => t.Name.Equals(chosenFoodName)).FirstOrDefault();
            if (chosenFood.IsConsumed == false)
            {
                chosenFood.User = user;
                chosenFood.NumberOfServings = chosenFoodNumberOfServings;
                chosenFood.IsConsumed = true;
                consumedFood.Add(chosenFood);
                foodDatabase.Where(t => t.Id == chosenFood.Id).FirstOrDefault().IsConsumed = true;
                AddRowToConsumedFoodTable(chosenFood);
            }
            else
            {
                DataTable foodTable = (DataTable)consumedFoodTable.DataSource;
                foreach (DataRow row in foodTable.Rows)
                {
                    if (row["ConsumedFoodName"].ToString().Equals(chosenFoodName))
                    {
                        row["ConsumedFoodSize"] = 
                            Double.Parse(row["ConsumedFoodSize"].ToString().Split(' ')[0], CultureInfo.InvariantCulture)
                            + chosenFoodNumberOfServings * chosenFood.ServingSize + " g";
                        row["ConsumedFoodCalories"] = Double.Parse(row["ConsumedFoodCalories"].ToString(), CultureInfo.InvariantCulture)
                            + chosenFoodNumberOfServings * chosenFood.CaloriesInServing;
                        break;
                    }
                }
                chosenFood.NumberOfServings += chosenFoodNumberOfServings;
            }
            _foodController.UpdateFood(chosenFood);
            ChangeCaloriesRatio();
        }

        private void dailyIntakeFoodDtbTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = dailyIntakeFoodDtbTable.Rows[e.RowIndex];
                chosenFoodNameTextBox.Text = row.Cells["DailyIntakeFoodDtbName"].Value.ToString();
                chosenFoodServingSizeTextBox.Text = row.Cells["DailyIntakeFoodDtbServingSize"].Value.ToString();
                chosenFoodNumberOfServingsNumericUpDown.Value = (decimal)foodDatabase
                    .Where(t => t.Name.Equals(chosenFoodNameTextBox.Text)).FirstOrDefault().NumberOfServings;
                noOfServingsPrevValue = (double)chosenFoodNumberOfServingsNumericUpDown.Value;
                chosenFoodCaloriesTextBox.Text = row.Cells["DailyIntakeFoodDtbCalories"].Value.ToString();
            }
        }

        private void consumedFoodTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = consumedFoodTable.Rows[e.RowIndex];
                string foodNameToDeleteFromConsumed = row.Cells["ConsumedFoodName"].Value.ToString();
                Food foodToDeleteFromConsumed = consumedFood.Where(t => t.Name.Equals(foodNameToDeleteFromConsumed)).FirstOrDefault();
                consumedFood.Remove(foodToDeleteFromConsumed);
                foodToDeleteFromConsumed.IsConsumed = false;
                foodToDeleteFromConsumed.NumberOfServings = 1;
                foodDatabase.Where(t => t.Id == foodToDeleteFromConsumed.Id).FirstOrDefault().IsConsumed = false;
                foodDatabase.Where(t => t.Id == foodToDeleteFromConsumed.Id).FirstOrDefault().NumberOfServings = 1;
                _foodController.UpdateFood(foodToDeleteFromConsumed);
                consumedFoodTable.Rows.RemoveAt(e.RowIndex);
                ChangeCaloriesRatio();
            }
        }

        private void chosenFoodNumberOfServingsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double numberOfServings = (double)chosenFoodNumberOfServingsNumericUpDown.Value;
            chosenFoodCaloriesTextBox.Text = (foodDatabase.Where(t => t.Name.Equals(chosenFoodNameTextBox.Text))
                    .FirstOrDefault().CaloriesInServing * numberOfServings).ToString();
            noOfServingsPrevValue = numberOfServings;
        }

        private void chosenFoodNumberOfServingsNumericUpDown_KeyPress(object sender, EventArgs e)
        {
            double numberOfServings = (double)chosenFoodNumberOfServingsNumericUpDown.Value;
            chosenFoodCaloriesTextBox.Text = (foodDatabase.Where(t => t.Name.Equals(chosenFoodNameTextBox.Text))
                    .FirstOrDefault().CaloriesInServing * numberOfServings).ToString();
            noOfServingsPrevValue = numberOfServings;
        }

        private void clearAllConsumedFoodBtn_Click(object sender, EventArgs e)
        {
            int noOfRows = consumedFoodTable.Rows.Count;
            for (int i = 0; i < noOfRows; i++)
            {
                consumedFoodTable.Rows.RemoveAt(0);
            }
            foreach (var food in foodDatabase)
            {
                if (food.IsConsumed)
                {
                    food.IsConsumed = false;
                    food.NumberOfServings = 1;
                    _foodController.UpdateFood(food);
                }
            }
            consumedFood = new List<Food>();
            ChangeCaloriesRatio();
        }

        private void RunOnNextForm(Form form)
        {
            Application.Run(form);
        }

        private void dailyIntakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void foodDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foodDatabaseForm = new frmFoodDatabaseWindow(_foodDatabaseController, _foodController, _repositoryFactory, user);
            this.Close();
            th = new Thread(delegate () {
                RunOnNextForm(foodDatabaseForm);
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void calorieLimitCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IInitialRunController _initialRunController = new InitialRunController(_formsFactory, _repositoryFactory);
            IUserController _userController = new UserController(_formsFactory, _repositoryFactory);
            var clcForm = new frmCalorieLimitCalculatorWindow(_initialRunController, _userController, _repositoryFactory, user);
            this.Close();
            th = new Thread(delegate () {
                RunOnNextForm(clcForm);
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
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
