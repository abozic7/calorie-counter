using CalorieCounter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BaseLib
{
    public interface IFoodDatabaseController
    {
        List<Food> GetAllFood();
        List<Food> Search(string input, List<Food> foodDatabase);
    }
}
