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
    public partial class frmFoodDatabaseWindow : Form
    {
        private IFoodDatabaseController _foodDatabaseController = null;
        private IFoodController _foodController;
        private IRepositoryFactory _repositoryFactory;
        private readonly WindowFormsFactory _formsFactory = new WindowFormsFactory();
        private List<Food> foodDatabase;
        private User user;
        private Thread th;

        public frmFoodDatabaseWindow(IFoodDatabaseController inFoodDatabaseController, IFoodController inFoodController, IRepositoryFactory inRepositoryFactory, User inUser)
        {
            _foodDatabaseController = inFoodDatabaseController;
            _foodController = inFoodController;
            _repositoryFactory = inRepositoryFactory;
            user = inUser;
            foodDatabase = new List<Food>();
            InitializeComponent();
            foodDatabaseTable.CellClick += new DataGridViewCellEventHandler(foodDatabaseTable_CellClick);
        }

        private void foodDatabaseTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = foodDatabaseTable.Rows[e.RowIndex];
                Food food = foodDatabase.Where(t => t.Name.Equals(row.Cells["FoodDatabaseName"].Value.ToString())).FirstOrDefault();
                if (senderGrid.Columns[e.ColumnIndex].Name.Equals("FoodDatabaseUpdate"))
                {
                    foodFormNameTextBox.Text = food.Name;
                    foodFormServingSizeTextBox.Text = food.ServingSize.ToString();
                    foodFormServingSizeUnitComboBox.SelectedText = food.ServingSizeUnit;
                    foodFormCaloriesTextBox.Text = food.CaloriesInServing.ToString();
                    foodFormProteinsTextBox.Text = food.ProteinsInServing.ToString();
                    foodFormCarbsTextBox.Text = food.CarbsInServing.ToString();
                    foodFormFatsTextBox.Text = food.FatsInServing.ToString();
                    foodFormNameTextBox.ReadOnly = true;
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("FoodDatabaseRemove"))
                {
                    foodDatabaseTable.Rows.RemoveAt(e.RowIndex);
                    foodDatabase.Remove(food);
                    _foodController.RemoveFood(food);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("FoodDatabaseDetails"))
                {
                    selectedFoodDetails.Text = "Name: " + food.Name + "\r\n"
                        + "Serving Size: " + food.ServingSize + " " + food.ServingSizeUnit + "\r\n"
                        + "Calories in Serving: " + food.CaloriesInServing + " kcal\r\n"
                        + "Proteins in Serving: " + food.ProteinsInServing + " g\r\n"
                        + "Carbs in Serving: " + food.CarbsInServing + " g\r\n"
                        + "Fats in Serving: " + food.FatsInServing + " g\r\n";
                }
            }
        }

        private void foodDatabaseSearchBtn_Click(object sender, EventArgs e)
        {
            string input = foodDatabaseSearchTextBox.Text;
            List<Food> searchResults = _foodDatabaseController.Search(input, foodDatabase);
            var foodTable = new DataTable();
            foodTable.Columns.Add("FoodDatabaseName", typeof(string));
            foodTable.Columns.Add("FoodDatabaseServingSize", typeof(string));
            foodTable.Columns.Add("FoodDatabaseCalories", typeof(string));
            foreach (var food in searchResults)
            {
                DataRow entry = foodTable.NewRow();
                entry[0] = food.Name;
                entry[1] = food.ServingSize + " " + food.ServingSizeUnit;
                entry[2] = food.CaloriesInServing;
                foodTable.Rows.Add(entry);
            }
            foodDatabaseTable.DataSource = foodTable;
        }

        private void frmFoodDatabaseWindow_Load(object sender, EventArgs e)
        {
            InitializeFoodDatabaseTable();
        }

        private void InitializeFoodDatabaseTable()
        {
            foodDatabase = _foodDatabaseController.GetAllFood();
            var foodTable = new DataTable();
            foodTable.Columns.Add("FoodDatabaseName", typeof(string));
            foodTable.Columns.Add("FoodDatabaseServingSize", typeof(string));
            foodTable.Columns.Add("FoodDatabaseCalories", typeof(string));
            foreach (var food in foodDatabase)
            {
                DataRow entry = foodTable.NewRow();
                entry[0] = food.Name;
                entry[1] = food.ServingSize + " " + food.ServingSizeUnit;
                entry[2] = food.CaloriesInServing;
                foodTable.Rows.Add(entry);
            }
            foodDatabaseTable.DataSource = foodTable;
        }

        private void foodFormSaveBtn_Click(object sender, EventArgs e)
        {
            string foodName = foodFormNameTextBox.Text;
            double foodServingSize = 0, foodCalories = 0, foodProteins = 0, foodCarbs = 0, foodFats = 0;
            string foodServingSizeUnit = foodFormServingSizeUnitComboBox.Text;

            if (foodName == null || foodName == ""
                || foodServingSizeUnit == null || foodServingSizeUnit == "")
            {
                MessageBox.Show("Niste ispunili sve podatke u formi! Provjerite unesene podatke i pokušajte ponovno.");
                return;
            }

            try
            {
                foodServingSize = Double.Parse(foodFormServingSizeTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + foodFormServingSizeTextBox.Text + "' koju ste unijeli za veličinu porcije nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            try
            {
                foodCalories = Double.Parse(foodFormCaloriesTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + foodFormCaloriesTextBox.Text + "' koju ste unijeli za kalorije nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            try
            {
                foodProteins = Double.Parse(foodFormProteinsTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + foodFormProteinsTextBox.Text + "' koju ste unijeli za proteine nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            try
            {
                foodCarbs = Double.Parse(foodFormCarbsTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + foodFormCarbsTextBox.Text + "' koju ste unijeli za ugljikohidrate nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            try
            {
                foodFats = Double.Parse(foodFormFatsTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + foodFormFatsTextBox.Text + "' koju ste unijeli za masti nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            Food entry = foodDatabase.Where(t => t.Name.Equals(foodName)).FirstOrDefault();

            if (entry == null)
            {
                Food food = new Food()
                {
                    Name = foodName,
                    ServingSize = foodServingSize,
                    ServingSizeUnit = foodServingSizeUnit,
                    CaloriesInServing = foodCalories,
                    ProteinsInServing = foodProteins,
                    CarbsInServing = foodCarbs,
                    FatsInServing = foodFats,
                    NumberOfServings = 1,
                    IsConsumed = false
                };
                _foodController.AddFood(food);
                foodDatabase.Add(food);
                AddRowToFoodDatabaseTable(food);
            }
            else
            {
                entry.ServingSize = foodServingSize;
                entry.ServingSizeUnit = foodServingSizeUnit;
                entry.CaloriesInServing = foodCalories;
                entry.ProteinsInServing = foodProteins;
                entry.CarbsInServing = foodCarbs;
                entry.FatsInServing = foodFats;
                _foodController.UpdateFood(entry);

                DataTable foodTable = (DataTable)foodDatabaseTable.DataSource;
                foreach (DataRow row in foodTable.Rows)
                {
                    if (row["FoodDatabaseName"].ToString().Equals(foodName))
                    {
                        row["FoodDatabaseServingSize"] = foodServingSize + " " + foodServingSizeUnit;
                        row["FoodDatabaseCalories"] = foodCalories;
                        break;
                    }
                }
            }
            ClearFoodForm();
            foodFormNameTextBox.ReadOnly = false;
        }

        public void AddRowToFoodDatabaseTable(Food food)
        {
            DataTable foodTable = (DataTable)foodDatabaseTable.DataSource;
            DataRow entry = foodTable.NewRow();
            entry[0] = food.Name;
            entry[1] = food.ServingSize + " " + food.ServingSizeUnit;
            entry[2] = food.CaloriesInServing;
            foodTable.Rows.Add(entry);
        }

        private void RunOnNextForm(Form form)
        {
            Application.Run(form);
        }

        private void dailyIntakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void ClearFoodForm()
        {
            foodFormNameTextBox.Text = "";
            foodFormServingSizeTextBox.Text = "";
            foodFormServingSizeUnitComboBox.Text = "";
            foodFormCaloriesTextBox.Text = "";
            foodFormProteinsTextBox.Text = "";
            foodFormCarbsTextBox.Text = "";
            foodFormFatsTextBox.Text = "";
        }

        private void foodFormClearFormBtn_Click(object sender, EventArgs e)
        {
            ClearFoodForm();
            foodFormNameTextBox.ReadOnly = false;
        }
    }
}
