using CalorieCounter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Model.Repositories
{
    public interface IFoodDatabaseRepository
    {
        List<Food> GetAllFood();
    }
}
