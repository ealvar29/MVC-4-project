using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFoodFour.Controllers
{
    public class CuisineController : Controller
    {
        [Authorize]
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);
            return Content("Hello World" + message);
        }
    }
}