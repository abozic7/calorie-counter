using CalorieCounter.BaseLib;
using CalorieCounter.Controllers;
using CalorieCounter.DAL;
using CalorieCounter.DAL.Repositories;
using CalorieCounter.Model.Entities;
using CalorieCounter.Model.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ISession _session = NHibernateService.OpenSession();

            IRepositoryFactory _repositoryFactory = new RepositoryFactory(_session);
            IWindowFormsFactory _formsFactory = new WindowFormsFactory();

            IUserRepository _userRepository = _repositoryFactory.GetUserRepository();
            IInitialRunController _initialRunController = new InitialRunController(_formsFactory, _repositoryFactory);
            IUserController _userController = new UserController(_formsFactory, _repositoryFactory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<User> users = _userRepository.GetAllUsers();

            if (users.Count == 0)
            {
                Application.Run(new frmStartCalorieLimitWindow(_initialRunController, _userController, _repositoryFactory));
            }
            else
            {
                IFoodDatabaseController _foodDatabaseController = new FoodDatabaseController(_formsFactory, _repositoryFactory);
                IFoodController _foodController = new FoodController(_formsFactory, _repositoryFactory);
                Application.Run(new frmDailyIntakeWindow(_foodDatabaseController, _foodController, _repositoryFactory, users[0]));
            }
        }
    }
}
