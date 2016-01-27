using System.Linq;
using System.Web.Mvc;
using Eat.Data.Abstract;
using Eat.Service.Abstract;

namespace Eat.Controllers.app
{
    public class DataController : Controller
    {
        IFoodService foodService;
        IFoodData foodData;

        public DataController(IFoodService foodService, IFoodData foodData)
        {
            this.foodService = foodService;
            this.foodData = foodData;
        }

        public ActionResult Index() // This cannot be called index because there's a folder called Data 
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFood()
        {
            foodData.Create();
            int count = foodService.Query().Count();
            TempData["message"] = string.Format("Food created ok! There are now {0} foods in the database.", count);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteAllFood()
        {
            foodService.DeleteAll();
            int count = foodService.Query().Count();
            TempData["message"] = string.Format("Food deleted ok! There are now {0} foods in the database.", count);
            return RedirectToAction("Index");
        }
    }
}
