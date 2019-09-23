using CalorieCounter.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.DAL
{
    public interface IRepositoryFactory
    {
        IUserRepository GetUserRepository();
        IFoodRepository GetFoodRepository();
        IProgressRepository GetProgressRepository();
        IFoodDatabaseRepository GetFoodDatabaseRepository();
    }
}
