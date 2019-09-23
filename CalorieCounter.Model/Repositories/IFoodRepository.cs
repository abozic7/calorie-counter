using CalorieCounter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Model.Repositories
{
    public interface IFoodRepository
    {
        Food GetFoodByName(string foodName);
        void AddFood(Food food);
        void UpdateFood(Food food);
        void RemoveFood(int foodID);
        List<Food> GetAllFood();
        List<Food> GetConsumedFood();
    }
}
