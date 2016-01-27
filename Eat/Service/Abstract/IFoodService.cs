using System.Collections.Generic;
using Eat.Entity;

namespace Eat.Service.Abstract
{
    public interface IFoodService
    {
        void Save(Food food);
        Food GetById(int? id);
        IEnumerable<Food> Query();
        void DeleteAll();
    }
}
