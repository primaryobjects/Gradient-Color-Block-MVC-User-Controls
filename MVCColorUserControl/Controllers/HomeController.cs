using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCColorUserControl.Models;
using MVCColorUserControl.Managers;

namespace MVCColorUserControl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new HomeModel());
        }

        /// <summary>
        /// Initialization method for the ColorBlockUserControl. Allows running server-side code before displaying partial view.
        /// </summary>
        /// <returns>PartialView</returns>
        public ActionResult InitializeUserControl()
        {
            ColorModel colorModel = new ColorModel
            {
                Width = 200,
                Height = 200,
                RGBColor = "#FF0000"
            };

            return PartialView("UserControls/ColorBlockUserControl", colorModel);
        }
    }
}
