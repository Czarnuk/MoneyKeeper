using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyKeeper.Controllers
{
    public class StartApplicationController : Controller
    {
        // GET: StartApplication
        public ActionResult Login()
        {
            return View();
        }
    }
}