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
using System.Windows.Forms.DataVisualization.Charting;

namespace CalorieCounter
{
    public partial class frmUserProgressWindow : Form
    {
        private IUserController _userController = null;
        private IProgressController _progressController;
        private IRepositoryFactory _repositoryFactory;
        private readonly WindowFormsFactory _formsFactory = new WindowFormsFactory();
        private User user;
        private List<Progress> progressDatabase;
        private Thread th;

        public frmUserProgressWindow(IUserController inUserController, IProgressController inProgressController, IRepositoryFactory inRepositoryFactory)
        {
            _userController = inUserController;
            _progressController = inProgressController;
            _repositoryFactory = inRepositoryFactory;
            user = _userController.GetUser();
            InitializeComponent();
        }

        private void frmUserProgressWindow_Load(object sender, EventArgs e)
        {
            InitializeProgressDatabaseTable();
            CreateChart();
        }

        private void InitializeProgressDatabaseTable()
        {
            progressDatabase = _progressController.GetProgress();
            var progressDataTable = new DataTable();
            progressDataTable.Columns.Add("ProgressWeight", typeof(string));
            progressDataTable.Columns.Add("ProgressDate", typeof(string));
            foreach (var progress in progressDatabase)
            {
                DataRow entry = progressDataTable.NewRow();
                entry[0] = progress.Weight + " kg";
                entry[1] = progress.Date.ToShortDateString();
                progressDataTable.Rows.Add(entry);
            }
            progressTable.DataSource = progressDataTable;
        }

        private void progressAddBtn_Click(object sender, EventArgs e)
        {
            double weight = 0;
            try
            {
                weight = Double.Parse(progressCurrentWeightTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Vrijednost '" + progressCurrentWeightTextBox.Text + "' koju ste unijeli za tjelesnu masu nije odgovarajuća. Molimo Vas pokušajte ponovno.");
                return;
            }

            Progress progress = new Progress()
            {
                Weight = weight,
                Date = DateTime.Now,
                User = user,
                IsUsersProgress = true
            };

            _progressController.AddProgress(progress);
            progressDatabase.Add(progress);
            AddRowToProgressTable(progress);
            RefreshChart();
            progressCurrentWeightTextBox.Text = "";
        }

        public void CreateChart()
        {
            DataTable progressDataTable = (DataTable)progressTable.DataSource;
            foreach (DataRow row in progressDataTable.Rows)
            {
                string weight = row["ProgressWeight"].ToString().Split(' ')[0];
                string date = row["ProgressDate"].ToString();
                progressChart.Series["Weight"].Points.AddXY(date, weight);
            }
        }

        public void RefreshChart()
        {
            DataTable progressDataTable = (DataTable)progressTable.DataSource;
            DataRow row = progressDataTable.Rows[progressDataTable.Rows.Count - 1];
            string weight = row["ProgressWeight"].ToString().Split(' ')[0];
            string date = row["ProgressDate"].ToString();
            progressChart.Series["Weight"].Points.AddXY(date, weight);
        }

        public void AddRowToProgressTable(Progress progress)
        {
            DataTable progressDataTable = (DataTable)progressTable.DataSource;
            DataRow entry = progressDataTable.NewRow();
            entry[0] = progress.Weight + " kg";
            entry[1] = progress.Date.ToShortDateString();
            progressDataTable.Rows.Add(entry);
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
        }
    }
}
