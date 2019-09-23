using CalorieCounter.BaseLib;
using CalorieCounter.DAL;
using CalorieCounter.Model.Entities;
using CalorieCounter.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Controllers
{
    public class FoodDatabaseController : IFoodDatabaseController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private IRepositoryFactory _repositoryFactory;
        private readonly IFoodDatabaseRepository _foodDatabaseRepository;

        public FoodDatabaseController(IWindowFormsFactory inFormFactory, IRepositoryFactory inRepositoryFactory)
        {
            _formsFactory = inFormFactory;
            _repositoryFactory = inRepositoryFactory;
            _foodDatabaseRepository = _repositoryFactory.GetFoodDatabaseRepository();
        }

        public List<Food> GetAllFood()
        {
            return _foodDatabaseRepository.GetAllFood();
        }

        public List<Food> Search(string input, List<Food> foodDatabase)
        {
            return foodDatabase.Where(t => t.Name.Equals(input)).ToList();
        }
    }
}
