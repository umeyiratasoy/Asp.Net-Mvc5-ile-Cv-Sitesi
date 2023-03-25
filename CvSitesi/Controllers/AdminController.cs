using CvSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CvSitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Eposta == ad.Eposta && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Eposta, false);
                Session["Eposta"] = bilgiler.Eposta.ToString();
                return RedirectToAction("GenelAyarlar", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult CıkısYap()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Admin");
        }

        [Authorize]
        public ActionResult GenelAyarlar()
        {
            return View();
        }
    }
}