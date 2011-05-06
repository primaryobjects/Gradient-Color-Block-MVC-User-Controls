using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCColorUserControl.Models;
using MVCColorUserControl.Managers;

namespace MVCColorUserControl.Controllers
{
    public class ColorBlockUserControlController : Controller
    {
        /// <summary>
        /// Callback method for ColorBlockUserControl's AJAX form.
        /// </summary>
        /// <param name="model">ColorModel</param>
        /// <returns>HTML string to be dispalyed within target DIV tag.</returns>
        [HttpPost]
        public ActionResult DrawColor(ColorModel model)
        {
            if (ModelState.IsValid)
            {
                return Content(ColorManager.GetGradientDiv(model.RGBColor, model.Width, model.Height));
            }
            else
            {
                return Redirect("/");
            }
        }
    }
}
