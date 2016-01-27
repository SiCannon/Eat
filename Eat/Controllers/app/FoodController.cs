using System.Web.Mvc;
using Eat.Data.Abstract;

namespace Eat.Controllers.app
{
    public class FoodController : Controller
    {
        public ActionResult List()
        {
            return PartialView();
        }

        public ActionResult Detail()
        {
            return PartialView();
        }
    }
}