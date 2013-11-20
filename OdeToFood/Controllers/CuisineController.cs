using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        public ActionResult Search(string search = "french")
        {
            var message = Server.HtmlEncode(search);
            return Content(message);
        }

    }
}
