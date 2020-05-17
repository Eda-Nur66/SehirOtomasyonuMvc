using SehirOtomasyonuMvc.DAL;
using SehirOtomasyonuMvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SehirOtomasyonuMvc.Controllers
{
    public class BolgeController : Controller
    {
        // GET: Bolge
        TurkeyContext tx = new TurkeyContext();
      
        public ActionResult Index()
        {
            using (TurkeyContext tx = new TurkeyContext())
            {
                BolgeviewModel bvm = new BolgeviewModel();
                bvm.Bolgeler = tx.Bolgeler.ToList();

                return View(bvm);
            }
        }

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public bool Ekle(Bolge b)
        {

            if (ModelState.IsValid)
            {
                using (TurkeyContext tx = new TurkeyContext())
                {
                    tx.Bolgeler.Add(b);
                    int sonuc = tx.SaveChanges();
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
            List<Bolge> bhrlistesi = tx.Bolgeler.ToList();
            foreach (var list in bhrlistesi)
            {
                liste += "<br>" + list.BolgeAd ;
            }
            return liste;
        }

        public ActionResult Duzenle(int? id)
        {
            using (TurkeyContext tx = new TurkeyContext())
            {
                var bhr = tx.Bolgeler.Find(id);

                return View(bhr);
            }
        }


        [HttpPost]
        public ActionResult Duzenle(Bolge bhr)
        {
            using (TurkeyContext tx = new TurkeyContext())
            {
                tx.Entry(bhr).State = EntityState.Modified;
                int sonuc = tx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
        }

        public ActionResult Sil(int? id)
        {
            using (TurkeyContext tx = new TurkeyContext())
            {
                var bhr = tx.Bolgeler.Find(id);
                tx.Bolgeler.Remove(bhr);
                tx.SaveChanges();
                return RedirectToAction("Index");

            }
        }
    }
}