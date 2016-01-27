using System;

namespace Eat.Dto
{
    public class FoodListItemDto
    {
        public int? FoodId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Calories { get; set; }
    }
}