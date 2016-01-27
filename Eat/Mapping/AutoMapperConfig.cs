using AutoMapper;
using Eat.Dto;
using Eat.Entity;

namespace Eat.Mapping
{
    public class AutoMapperConfig
    {
        public static void RegisterAutoMaps()
        {
            Mapper.CreateMap<Food, FoodListItemDto>();
            Mapper.CreateMap<Food, FoodDetailDto>();

            Mapper.AssertConfigurationIsValid();
        }
    }
}