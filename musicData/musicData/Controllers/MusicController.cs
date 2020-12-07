using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace musicData.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int Id)
        {
            var music = Models.MusicData.VeriListe.Where(x => x.Id == Id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Models.MusicData MusicData)
        {
            var music = Models.MusicData.VeriListe.FirstOrDefault(x => x.Id == MusicData.Id);
            music.Ad = MusicData.Ad;
            music.Sanatci = MusicData.Sanatci;
            music.Yapimci = MusicData.Yapimci;
            music.Dinlenme = MusicData.Dinlenme;

            return RedirectToAction("Listele");
        }
        public ActionResult Delete(int Id)
        {
            var supplament = Models.MusicData.VeriListe.Where(x => x.Id == Id).FirstOrDefault();
            return View(supplament);
        }
        [HttpPost]
        public ActionResult Delete(Models.MusicData MusicData)
        {
            var music = Models.MusicData.VeriListe.FirstOrDefault(x => x.Id == MusicData.Id);
            Models.MusicData.VeriListe.Remove(music);
            return RedirectToAction("Listele");
        }
        public ActionResult Listele()
        {
            return View(Models.MusicData.VeriListe);
        }
    }
}