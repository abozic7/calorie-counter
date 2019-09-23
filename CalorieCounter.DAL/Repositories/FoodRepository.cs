using CalorieCounter.Model.Entities;
using CalorieCounter.Model.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.DAL.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        ISession _currSession = null;

        public FoodRepository(ISession inSession)
        {
            _currSession = inSession;
        }

        public List<Food> GetAllFood()
        {
            return _currSession.Query<Food>().ToList();
        }

        public Food GetFoodByName(string foodName)
        {
            return _currSession.Query<Food>().FirstOrDefault(p => p.Name == foodName);
        }

        public void AddFood(Food food)
        {
            using (var transaction = _currSession.BeginTransaction())
            {
                _currSession.SaveOrUpdate(food);
                transaction.Commit();
            }
        }

        public void UpdateFood(Food food)
        {
            using (var transaction = _currSession.BeginTransaction())
            {
                _currSession.SaveOrUpdate(food);
                transaction.Commit();
            }
        }

        public void RemoveFood(int foodID)
        {
            Food foodToRemove = _currSession.Get<Food>(foodID);

            if (foodToRemove != null)
            {
                using (var transaction = _currSession.BeginTransaction())
                {
                    _currSession.Delete(foodToRemove);
                    transaction.Commit();
                }
            }
        }

        public List<Food> GetConsumedFood()
        {
            return _currSession.Query<Food>().Where(t => t.IsConsumed == true).ToList();
        }
    }
}
