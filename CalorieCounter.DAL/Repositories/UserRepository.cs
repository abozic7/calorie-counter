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
    public class UserRepository : IUserRepository
    {
        ISession _currSession = null;

        public UserRepository(ISession inSession)
        {
            _currSession = inSession;
        }

        public User GetUser(int userID)
        {
            return _currSession.Get<User>(userID);
        }

        public List<User> GetAllUsers()
        {
            return _currSession.Query<User>().ToList();
        }

        public void AddUser(User user)
        {
            using (var transaction = _currSession.BeginTransaction())
            {
                _currSession.SaveOrUpdate(user);
                transaction.Commit();
            }
        }

        public void UpdateUser(User user)
        {
            using (var transaction = _currSession.BeginTransaction())
            {
                _currSession.SaveOrUpdate(user);
                transaction.Commit();
            }
        }
    }
}
