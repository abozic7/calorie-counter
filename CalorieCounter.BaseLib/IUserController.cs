using CalorieCounter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BaseLib
{
    public interface IUserController
    {
        void AddUser(double calorieLimit);
        void UpdateUser(double calorieLimit);
        User GetUser();
    }
}
