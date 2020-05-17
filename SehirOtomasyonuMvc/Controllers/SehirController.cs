using SehirOtomasyonuMvc.DAL;
using SehirOtomasyonuMvc.Models;
using SehirOtomasyonuMvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SehirOtomasyonuMvc.Controllers
{
    public class SehirController : Controller
    {
        TurkeyContext ctx = new TurkeyContext();
        // GET: Sehir
        public ActionResult Index()
        {
            using (TurkeyContext ctx = new TurkeyContext())
            {
                SehirviewModel svm = new SehirviewModel();
                svm.Sehirler = ctx.Sehirler.ToList();
                
                return View(svm);
            }
        }

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public bool Ekle(Sehir s)
        {

            if (ModelState.IsValid)//bu dogrulama düzenlede de olmalı projede
            {
                using (TurkeyContext ctx = new TurkeyContext())
                {
                    ctx.Sehirler.Add(s);
                    int sonuc = ctx.SaveChanges();
                    if (sonuc > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public string Listele()
        {
            string liste = "";
            List<Sehir> shrlistesi = ctx.Sehirler.ToList();
            foreach (var list in shrlistesi)
            {
                liste += "<br>" + list.SehirAd+ " " + list.TarihiEser + "<hr>";
            }
            return liste;
        }

        public ActionResult Duzenle(int? id)
        {
            using (TurkeyContext ctx = new TurkeyContext())
            {
                var shr = ctx.Sehirler.Find(id);

                return View(shr);
            }
        }


        [HttpPost]
        public ActionResult Duzenle(Sehir shr)
        {
            using (TurkeyContext ctx = new TurkeyContext())
            {
                ctx.Entry(shr).State = EntityState.Modified;
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
        }

        public ActionResult Sil(int? id)
        {
            using (TurkeyContext ctx = new TurkeyContext())
            {
                var shr = ctx.Sehirler.Find(id);
                ctx.Sehirler.Remove(shr);
                ctx.SaveChanges();
                return RedirectToAction("Index");

            }
        }
        public ActionResult CkEditor()
        {
            return View();
        }

   

    }
}