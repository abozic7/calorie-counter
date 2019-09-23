using CalorieCounter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BaseLib
{
    public interface IFoodController
    {
        List<Food> GetConsumedFood();
        void UpdateFood(Food food);
        void AddFood(Food food);
        void RemoveFood(Food food);
    }
}
