using CalorieCounter.BaseLib;
using CalorieCounter.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Controllers
{
    public class InitialRunController : IInitialRunController 
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private IRepositoryFactory _repositoryFactory;

        public InitialRunController(IWindowFormsFactory inFormFactory, IRepositoryFactory inRepositoryFactory)
        {
            _formsFactory = inFormFactory;
            _repositoryFactory = inRepositoryFactory;
        }
        
        public double ShowCalorieLimit(double height, double weight, int age, int gender, int activityLvl, int goal, int goalAmount)
        {
            var clcController = new CalorieLimitCalculationController(_formsFactory);
            var userController = new UserController(_formsFactory, _repositoryFactory);
            var newFrm = _formsFactory.CreateCalorieLimitCalculationView(this, userController, _repositoryFactory);
            double result = clcController.CalculateCalorieLimit(height, weight, age, gender, activityLvl, goal, goalAmount);
            return result;
        }
    }
}
