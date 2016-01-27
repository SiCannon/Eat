using System.Diagnostics;
using System.Linq;
using Eat.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eat.IntegrationTests.Database
{
    [TestClass]
    public class EatContextTests
    {
        [TestMethod]
        public void Can_Query_Foods()
        {
            var db = new EatContext();
            var food = db.Foods.ToList();
            Debug.WriteLine(food.Count);
        }
    }
}
