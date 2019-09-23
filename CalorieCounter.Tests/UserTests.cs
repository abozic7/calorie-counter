using CalorieCounter.BaseLib;
using CalorieCounter.Controllers;
using CalorieCounter.DAL;
using CalorieCounter.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Tests
{
    [TestClass]
    public class UserTests
    {
        IWindowFormsFactory _formsFactory = new WindowFormsFactory();

        [TestMethod]
        public void TestUser_CalculateCalorieLimit()
        {
            double height = 164;
            double weight = 62;
            int age = 22;
            int gender = 2;
            int activityLevel = 1;
            int goal = 1;
            int goalAmount = 2;

            ICalorieLimitCalculationController _clcController = new CalorieLimitCalculationController(_formsFactory);
            double calories = _clcController.CalculateCalorieLimit(height, weight, age, gender, activityLevel, goal, goalAmount);
            Assert.AreEqual(1220.4628, calories);
        }

        [TestMethod]
        public void TestUser_GetUser()
        {
            User user = new User()
            {
                CalorieLimit = 1198.27
            };

            var _foodDatabaseController = new Mock<IUserController>();
            _foodDatabaseController.Setup(x => x.GetUser()).Returns(user);
            Assert.AreEqual(user.CalorieLimit, _foodDatabaseController.Object.GetUser().CalorieLimit);
        }
    }
}
