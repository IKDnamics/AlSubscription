using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almal.Web.Areas.Auth.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth/Auth
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}