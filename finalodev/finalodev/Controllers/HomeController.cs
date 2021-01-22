using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace finalodev.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var Muzik = session.Query<Models.Muzik>().ToList();
                return View(Muzik);
            }
        }
    }
}