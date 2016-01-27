using System;
using Eat.Entity.Interface;

namespace Eat.Entity
{
    public class Food : IIsNew
    {
        public int? FoodId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Calories { get; set; }

        public bool IsNew
        {
            get { return !FoodId.HasValue; }
        }
    }
}