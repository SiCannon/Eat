using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using Eat.Dto;
using Eat.Mapping;
using Eat.Service.Abstract;

namespace Eat.Controllers.api
{
    public class FoodController : ApiController
    {
        IMappingEngine mapper;
        IFoodService foodService;

        public FoodController(IMappingEngine mapper, IFoodService foodService)
        {
            this.mapper = mapper;
            this.foodService = foodService;
        }

        [HttpGet]
        [Route("api/food")]
        public IEnumerable<FoodListItemDto> Query()
        {
            return mapper.Map<IEnumerable<FoodListItemDto>>(foodService.Query());
        }

        [Route("api/food/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var food = foodService.GetById(id);
            if (food != null)
            {
                return Ok(mapper.Map<FoodDetailDto>(food));
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/food")]
        public void Post([FromBody]FoodDetailDto food)
        {
            //var response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.UnsupportedMediaType



            if (food.FoodId.HasValue)
            {
                var existingfood = foodService.GetById(food.FoodId.Value);
                FoodDetailDtoToFoodMapper.Map(food, existingfood);
                foodService.Save(existingfood);
            }
            else
            {
                var newfood = FoodDetailDtoToFoodMapper.Map(food);
                foodService.Save(newfood);
            }
        }
    }
}
