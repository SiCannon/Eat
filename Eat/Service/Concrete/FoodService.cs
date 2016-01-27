using System.Collections.Generic;
using System.Linq;
using Eat.BusinessLogic;
using Eat.Database;
using Eat.Entity;
using Eat.Service.Abstract;

namespace Eat.Service.Concrete
{
    public class FoodService : BaseService, IFoodService
    {
        public FoodService(IUnitOfWork work) : base(work) { }

        public void Save(Food food)
        {
            InternalSave(food);
        }

        public Food GetById(int? id)
        {
            return work.Foods.SingleOrDefault(x => x.FoodId == id);
        }

        public IEnumerable<Food> Query()
        {
            return work.Foods.OrderBy(x => x.Name);
        }

        public void DeleteAll()
        {
            foreach (var food in work.Foods)
            {
                InternalDelete(food, false);
            }
            work.SaveChanges();
        }
    }
}