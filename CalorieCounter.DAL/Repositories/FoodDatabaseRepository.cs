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
    public class FoodDatabaseRepository : IFoodDatabaseRepository
    {
        ISession _currSession = null;

        public FoodDatabaseRepository(ISession inSession)
        {
            _currSession = inSession;
        }

        public List<Food> GetAllFood()
        {
            return _currSession.Query<Food>().ToList();
        }
    }
}
