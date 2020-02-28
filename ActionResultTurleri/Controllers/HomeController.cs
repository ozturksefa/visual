using ActionResultTurleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultTurleri.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public RedirectResult Hakkimizda()
        {
            //Belirtilen url'ye yöenlendirme.
            return Redirect("/Home/Index");
        }

        public RedirectResult GoogleGit()
        {
            return Redirect("www.google.com.tr");
        }

        public PartialViewResult UrunListele()
        {
            Urun urun = new Urun()
            {
                Adi = "Ayakkabı",
                Fiyati = (decimal)1200.50,
                Id = 1
            };
            return PartialView("_UrunListesiPartial", urun);
        }
        public PartialViewResult UrunListele2()
        {
            var liste = new List<Urun>()
            {
                new Urun()
                {
                    Adi = "Ayakkabı",
                    Fiyati = (decimal)1200.50,
                    Id = 1
                },
                new Urun()
                {
                    Adi = "Kazak",
                    Fiyati = (decimal)100.50,
                    Id = 2
                },
                new Urun()
                {
                    Adi = "Kemer",
                    Fiyati = (decimal)500.00,
                    Id = 3
                },
                new Urun()
                {
                    Adi = "Lahmacun",
                    Fiyati = (decimal)50.00,
                    Id = 4
                }
            };
            return PartialView("_UrunListesiPartial2", liste);
        }

        public JsonResult UrunGetir()
        {
            Urun urun = new Urun()
            {
                Id = 1,
                Adi = "Kebap",
                Fiyati = 25.99m
            };
            return Json(urun,JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult UrunGetir(int? id)
        {
            Urun urun = new Urun()
            {
                Id = 1,
                Adi = "Kebap",
                Fiyati = 25.99m
            };
            return Json(urun);
        }

        public ActionResult Kaydet()
        {
            return RedirectToAction("Index");
        }

        public JavaScriptResult MesajVer()
        {
            string js = "alert('Uyan Sınıf Uyan...')";
            return JavaScript(js);
        }

        public JavaScriptResult Mesaj()
        {
            string js = "function btn_click (){alert('Sınıf Ne Durumdayız...')}";
            return JavaScript(js);
        }

        public ActionResult Index6(string kod)
        {
            return View();
        }


        public ActionResult Sil()
        {
            return new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new
            {
                action= "Index6",
                controller="Home",
                kod=Guid.NewGuid().ToString()
            }));
        }
        public EmptyResult Guncelle()
        {
            return null;
        }
        public ViewResult Guncelle2()
        {
            return View();
        }
        //public FilePathResult DosyaYolu()
        //{

        //}
        public FileResult TeklifFormunuIndir()
        {
            string file = "formu.doc";
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/Dosyalar/" + file + ""));
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, file);
        }
        //public FileStreamResult DosyaStream()
        //{

        //}
    }
}