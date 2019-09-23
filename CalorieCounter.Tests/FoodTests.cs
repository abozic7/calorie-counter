using CalorieCounter.BaseLib;
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
    public class FoodTests
    {
        List<Food> foods = new List<Food>();

        public FoodTests()
        {
            Food testFood1 = new Food()
            {
                Name = "testFood1",
                ServingSize = 100,
                ServingSizeUnit = "g",
                NumberOfServings = 1,
                CaloriesInServing = 234,
                ProteinsInServing = 543,
                CarbsInServing = 23,
                FatsInServing = 321,
                IsConsumed = false
            };

            Food testFood2 = new Food()
            {
                Name = "testFood2",
                ServingSize = 250,
                ServingSizeUnit = "g",
                NumberOfServings = 1,
                CaloriesInServing = 434,
                ProteinsInServing = 32,
                CarbsInServing = 33,
                FatsInServing = 42,
                IsConsumed = true
            };

            foods.Add(testFood1);
            foods.Add(testFood2);
        }

        [TestMethod]
        public void TestFood_SearchFood()
        {
            var _foodDatabaseController = new Mock<IFoodDatabaseController>();
            _foodDatabaseController.Setup(x => x.Search("foodTest1", foods)).Returns(() => new List<Food> { foods.FirstOrDefault(t => t.Name.Equals("testFood1")) });
            Assert.AreEqual("testFood1", _foodDatabaseController.Object.Search("foodTest1", foods).First().Name);
        }

        [TestMethod]
        public void TestFood_GetAllFood_Count()
        {

            var _foodDatabaseController = new Mock<IFoodDatabaseController>();
            _foodDatabaseController.Setup(x => x.GetAllFood()).Returns(() => new List<Food> { new Food() { Name = "Banana" }, new Food() { Name = "Jabuka" }, new Food() { Name = "Jagoda" }, new Food() { Name = "Kruška" } });
            Assert.AreEqual(4, _foodDatabaseController.Object.GetAllFood().Count);
        }

        [TestMethod]
        public void TestFood_GetAllFood_Contains()
        {

            var _foodDatabaseController = new Mock<IFoodDatabaseController>();
            _foodDatabaseController.Setup(x => x.GetAllFood()).Returns(() => new List<Food> { new Food() { Name = "Banana" }, new Food() { Name = "Jabuka" }, new Food() { Name = "Jagoda" }, new Food() { Name = "Kruška" } });
            Assert.IsTrue(_foodDatabaseController.Object.GetAllFood().Find(t => t.Name.Equals("Banana")) != null);
        }
    }
}
