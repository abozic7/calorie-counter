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
    public class UserController : IUserController
    {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IUserRepository _userRepository = null;

        public UserController(IWindowFormsFactory inFormFactory, IRepositoryFactory inRepositoryFactory)
        {
            _repositoryFactory = inRepositoryFactory;
            _formsFactory = inFormFactory;
            _userRepository = inRepositoryFactory.GetUserRepository();
        }

        public void AddUser(double calorieLimit)
        {
            User user = new User();
            user.CalorieLimit = calorieLimit;
            _userRepository.AddUser(user);
        }

        public void UpdateUser(double calorieLimit)
        {
            User user = _userRepository.GetAllUsers()[0];
            user.CalorieLimit = calorieLimit;
            _userRepository.UpdateUser(user);
        }

        public User GetUser()
        {
            return _userRepository.GetAllUsers()[0];
        }
    }
}
