using System;
using System.Linq;
using Eat.Database;
using Eat.Entity;
using Eat.Service.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eat.IntegrationTests.Service
{
    [TestClass]
    public class FoodServiceTests
    {
        [TestMethod]
        public void Can_Save_New_Food()
        {
            var work = new UnitOfWork();
            var service = new FoodService(work);
            var food = new Food { Name = "Test Food" };
            service.Save(food);
            var savedId = food.FoodId;

            Assert.IsNotNull(savedId);
            Assert.AreNotEqual(0, savedId);

            using (var db = new EatContext())
            {
                var fs = db.Foods.SingleOrDefault(x => x.FoodId == savedId);
                Assert.IsNotNull(fs);
                Assert.IsNotNull(fs.FoodId);
                Assert.AreNotEqual(0, fs.FoodId);
                Assert.AreEqual(savedId, fs.FoodId);
            }
        }
    }
}
