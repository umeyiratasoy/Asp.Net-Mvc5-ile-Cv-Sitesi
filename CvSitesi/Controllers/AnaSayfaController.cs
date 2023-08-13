using CvSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace CvSitesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        Context c = new Context();
        // GET: AnaSayfa
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult MobilSol()
        {
            var deger = c.GenelAyarlars.Take(1).ToList();
            return PartialView(deger);
        }

        public PartialViewResult PcSol()
        {
            var deger = c.GenelAyarlars.Take(1).ToList();
            return PartialView(deger);
        }

        public PartialViewResult PcHakkimda()
        {
            var deger = c.Hakkimdas.Take(1).ToList();
            return PartialView(deger);
        }

        public PartialViewResult PcEgitim()
        {
            var deger = c.Egitims.ToList();
            return PartialView(deger);
        }

        public PartialViewResult PcSertifika1()
        {
            var deger = c.Sertifikas.ToList();
            return PartialView(deger);
        }

        public PartialViewResult PcSertifika2()
        {
            var deger = c.Sertifikas.ToList();
            return PartialView(deger);
        }

        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult iletisim(Iletisim i)
        {
            if (ModelState.IsValid)
            {
                c.Iletisims.Add(i);
                c.SaveChanges();
            }

            return PartialView();
        }

        public PartialViewResult MobilEgitim()
        {
            var deger = c.Egitims.ToList();
            return PartialView(deger);
        }

        public PartialViewResult MobilSertifika(int p = 1)
        {
            var deger = c.Sertifikas.ToList().ToPagedList(p, 2);
            return PartialView(deger);
        }
    }
}