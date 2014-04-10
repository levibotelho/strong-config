using StrongConfig.Example.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrongConfig.Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new ConfigModel
            {
                BoolValue = ConfigurationFacade.BooleanKey,
                DateTimeValue = ConfigurationFacade.DateKey,
                IntValue = ConfigurationFacade.IntKey,
                StringValue = ConfigurationFacade.StringKey
            };

            return View(model);
        }
    }
}
