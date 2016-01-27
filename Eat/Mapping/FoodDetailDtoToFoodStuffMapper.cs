using Eat.Dto;
using Eat.Entity;

namespace Eat.Mapping
{
    public class FoodDetailDtoToFoodMapper // : IMapper<FoodDetailDto, Food>
    {
        public static void Map(FoodDetailDto source, Food target)
        {
            target.FoodId = source.FoodId;
            target.Name = source.Name;
            target.Brand = source.Brand;
            target.Quantity = source.Quantity;
            target.Calories = source.Calories;
        }

        public static Food Map(FoodDetailDto source)
        {
            var result = new Food();
            Map(source, result);
            return result;
        }
    }
}