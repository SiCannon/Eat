using System.Web.Mvc;
using AutoMapper;
using Eat.Entity;
using Eat.Service.Abstract;

namespace Eat.Controllers.app
{
    public class HomeController : Controller
    {
        IMappingEngine mapper;
        IFoodService foodService;

        public HomeController(IMappingEngine mapper, IFoodService foodService)
        {
            this.mapper = mapper;
            this.foodService = foodService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateFood(string name)
        {
            var fs = new Food { Name = name };
            foodService.Save(fs);
            return Content(string.Format("Saved {0}, ID = {1}", fs.Name, fs.FoodId));
        }
    }
}