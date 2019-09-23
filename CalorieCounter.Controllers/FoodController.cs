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
    public class FoodController : IFoodController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private IRepositoryFactory _repositoryFactory;
        private readonly IFoodRepository _foodRepository;

        public FoodController(IWindowFormsFactory inWindowFormsFactory, IRepositoryFactory inRepositoryFactory)
        {
            _formsFactory = inWindowFormsFactory;
            _repositoryFactory = inRepositoryFactory;
            _foodRepository = _repositoryFactory.GetFoodRepository();
        }

        public List<Food> GetConsumedFood()
        {
            return _foodRepository.GetConsumedFood();
        }

        public void UpdateFood(Food food)
        {
            _foodRepository.UpdateFood(food);
        }

        public void AddFood(Food food)
        {
            _foodRepository.AddFood(food);
        }

        public void RemoveFood(Food food)
        {
            _foodRepository.RemoveFood(food.Id);
        }
    }
}
