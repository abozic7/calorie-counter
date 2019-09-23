using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCounter.DAL.Repositories;
using CalorieCounter.Model.Repositories;
using NHibernate;

namespace CalorieCounter.DAL
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private ISession _session;

        public RepositoryFactory(ISession inSession)
        {
            _session = inSession;
        }

        public IFoodRepository GetFoodRepository()
        {
            IFoodRepository foodRepository = new FoodRepository(_session);
            return foodRepository;
        }

        public IProgressRepository GetProgressRepository()
        {
            IProgressRepository progressRepository = new ProgressRepository(_session);
            return progressRepository;
        }

        public IUserRepository GetUserRepository()
        {
            IUserRepository userRepository = new UserRepository(_session);
            return userRepository;
        }

        public IFoodDatabaseRepository GetFoodDatabaseRepository()
        {
            IFoodDatabaseRepository foodDatabaseRepository = new FoodDatabaseRepository(_session);
            return foodDatabaseRepository;
        }
    }
}
