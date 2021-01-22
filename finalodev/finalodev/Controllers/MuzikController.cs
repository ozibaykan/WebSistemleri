using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace finalodev.Controllers
{
    public class MuzikController : Controller
    {
        // GET: Muzik
        public ActionResult Index()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var teams = session.Query<Models.Muzik>().Fetch(x => x.Muzik).ToList();
                return View(teams);
                //var teams = session.Query<Models.Teams>().ToList();
                //return View(teams);
            }
        }

        public ActionResult Listele()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var teams = session.Query<Models.Muzik>().ToList();
                return View(teams);
            }
        }

        public ActionResult Yeni()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var team = session.Query<Models.Muzik>().FirstOrDefault(x => x.TEAMID == id);
                return View(team);
            }
        }


        public ActionResult Delete(int Id)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var team = session.Query<Models.Muzik>().FirstOrDefault(x => x.TEAMID == Id);
                return View(team);
            }
        }

        [HttpPost]
        public ActionResult Delete(Models.Muzik teamdata)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var muzk = session.Query<Models.Muzik>().FirstOrDefault(x => x.Muzikid == teamdata.Muzikid);

                session.Delete(muzk);
                session.Flush();
                return RedirectToAction("/Index");
            }

        }

        [HttpPost]
        public ActionResult Edit(Models.Muzik Muzik)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var Muzik = session.Query<Models.Muzik>().FirstOrDefault(x => x.Muzikid == Muzik.Muzikid);
                Muzik.sanatciadi = Muzik.sanatciadi;
                Muzik.sanatcisoyadi = Muzik.sanatcisoyadi;
                Muzik.sarki = Muzik.sarki;
                session.SaveOrUpdate(Muzik);
                session.Flush();
                return RedirectToAction("/Index");
            }
        }
    }
}