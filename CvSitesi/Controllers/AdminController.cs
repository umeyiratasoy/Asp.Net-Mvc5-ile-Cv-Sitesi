// Decompiled with JetBrains decompiler
// Type: CvSitesi.Controllers.AdminController
// Assembly: CvSitesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 341537B9-DF21-466C-88FA-070FF3F01145
// Assembly location: C:\Users\omerr\OneDrive\Masaüstü\CvSitesi.dll

using CvSitesi.Models;
using PagedList;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Security;

namespace CvSitesi.Controllers
{
    public class AdminController : Controller
    {
        private Context c = new Context();

        public ActionResult Index() => (ActionResult)this.View();

        [HttpPost]
        public ActionResult Index(CvSitesi.Models.Admin ad)
        {
            CvSitesi.Models.Admin admin = ((IQueryable<CvSitesi.Models.Admin>)this.c.Admins).FirstOrDefault<CvSitesi.Models.Admin>((Expression<Func<CvSitesi.Models.Admin, bool>>)(x => x.Eposta == ad.Eposta && x.Sifre == ad.Sifre));
            if (admin == null)
                return (ActionResult)this.View();
            FormsAuthentication.SetAuthCookie(admin.Eposta, false);
            this.Session["Eposta"] = (object)admin.Eposta.ToString();
            return (ActionResult)this.RedirectToAction("GenelAyarlar", "Admin");
        }

        public ActionResult CıkısYap()
        {
            FormsAuthentication.SignOut();
            return (ActionResult)this.RedirectToAction("Index", "Admin");
        }

        [Authorize]
        public ActionResult GenelAyarlar() => (ActionResult)this.View((object)((IQueryable<CvSitesi.Models.GenelAyarlar>)this.c.GenelAyarlars).Take<CvSitesi.Models.GenelAyarlar>(1).ToList<CvSitesi.Models.GenelAyarlar>());

        [Authorize]
        public ActionResult GenelAyarlarGetir(int id) => (ActionResult)this.View(nameof(GenelAyarlarGetir), (object)this.c.GenelAyarlars.Find(new object[1]
        {
      (object) id
        }));

        [Authorize]
        public ActionResult GenelAyarlarGuncelle(CvSitesi.Models.GenelAyarlar g)
        {
            CvSitesi.Models.GenelAyarlar genelAyarlar = this.c.GenelAyarlars.Find(new object[1]
            {
        (object) g.ID
            });
            genelAyarlar.PpImage = g.PpImage;
            genelAyarlar.IsimSoyisim = g.IsimSoyisim;
            genelAyarlar.Biyografi = g.Biyografi;
            genelAyarlar.Instagram = g.Instagram;
            genelAyarlar.Twitter = g.Twitter;
            genelAyarlar.Facebook = g.Facebook;
            genelAyarlar.Eposta = g.Eposta;
            this.c.SaveChanges();
            return (ActionResult)this.RedirectToAction("/GenelAyarlar/");
        }

        [Authorize]
        public ActionResult Hakkimizda() => (ActionResult)this.View((object)((IQueryable<Hakkimda>)this.c.Hakkimdas).Take<Hakkimda>(1).ToList<Hakkimda>());

        [Authorize]
        public ActionResult HakkimizdaGetir(int id) => (ActionResult)this.View(nameof(HakkimizdaGetir), (object)this.c.Hakkimdas.Find(new object[1]
        {
      (object) id
        }));

        [Authorize]
        public ActionResult HakkimizdaGuncelle(Hakkimda h)
        {
            Hakkimda hakkimda = this.c.Hakkimdas.Find(new object[1]
            {
        (object) h.ID
            });
            hakkimda.Baslik = h.Baslik;
            hakkimda.Aciklama = h.Aciklama;
            this.c.SaveChanges();
            return (ActionResult)this.RedirectToAction("Hakkimizda");
        }

        [Authorize]
        public ActionResult Egitim() => (ActionResult)this.View((object)((IQueryable<CvSitesi.Models.Egitim>)this.c.Egitims).OrderByDescending<CvSitesi.Models.Egitim, int>((Expression<Func<CvSitesi.Models.Egitim, int>>)(x => x.ID)).ToList<CvSitesi.Models.Egitim>());

        [Authorize]
        public ActionResult EgitimGetir(int id) => (ActionResult)this.View(nameof(EgitimGetir), (object)this.c.Egitims.Find(new object[1]
        {
      (object) id
        }));

        [Authorize]
        public ActionResult EgitimGuncelle(CvSitesi.Models.Egitim e)
        {
            CvSitesi.Models.Egitim egitim = this.c.Egitims.Find(new object[1]
            {
        (object) e.ID
            });
            egitim.OkulAdi = e.OkulAdi;
            egitim.BolumAdi = e.BolumAdi;
            this.c.SaveChanges();
            return (ActionResult)this.RedirectToAction("/Egitim/");
        }

        [Authorize]
        public ActionResult EgitimSil(int id)
        {
            this.c.Egitims.Remove(this.c.Egitims.Find(new object[1]
            {
        (object) id
            }));
            this.c.SaveChanges();
            return (ActionResult)this.RedirectToAction("Egitim");
        }

        [Authorize]
        [HttpGet]
        public ActionResult YeniEgitim() => (ActionResult)this.View();

        [Authorize]
        [HttpPost]
        public ActionResult YeniEgitim(CvSitesi.Models.Egitim e)
        {
            if (this.ModelState.IsValid)
                this.c.Egitims.Add(e);
            this.c.SaveChanges();
            return (ActionResult)this.View(nameof(YeniEgitim));
        }

        [Authorize]
        public ActionResult Sertifika(int p = 1)
        {
            var degerler = c.Sertifikas.OrderByDescending(x => x.ID).ToList().ToPagedList(p, 2);
            return View(degerler);
        }
        [Authorize]
        public ActionResult SertifikaGetir(int id) => (ActionResult)this.View(nameof(SertifikaGetir), (object)this.c.Sertifikas.Find(new object[1]
        {
      (object) id
        }));

        [Authorize]
        public ActionResult SertifikaGuncelle(CvSitesi.Models.Sertifika s)
        {
            CvSitesi.Models.Sertifika sertifika = this.c.Sertifikas.Find(new object[1]
            {
        (object) s.ID
            });
            sertifika.Baslik = s.Baslik;
            sertifika.Aciklama = s.Aciklama;
            sertifika.SImage = s.SImage;
            sertifika.SLink = s.SLink;
            this.c.SaveChanges();
            return (ActionResult)this.RedirectToAction("/Sertifika/");
        }

        [Authorize]
        public ActionResult SertifikaSil(int id)
        {
            this.c.Sertifikas.Remove(this.c.Sertifikas.Find(new object[1]
            {
        (object) id
            }));
            this.c.SaveChanges();
            return (ActionResult)this.RedirectToAction("Sertifika");
        }

        [Authorize]
        [HttpGet]
        public ActionResult YeniSertifika() => (ActionResult)this.View();

        [Authorize]
        [HttpPost]
        public ActionResult YeniSertifika(CvSitesi.Models.Sertifika s)
        {
            if (this.ModelState.IsValid)
                this.c.Sertifikas.Add(s);
            this.c.SaveChanges();
            return (ActionResult)this.View(nameof(YeniSertifika));
        }

        [Authorize]
        public ActionResult Iletisim(int p = 1)
        {
            var degerler = c.Iletisims.OrderByDescending(x => x.ID).ToList().ToPagedList(p, 5);
            return View(degerler);
        }

        [Authorize]
        public ActionResult IletisimSil(int id)
        {
            object[] keyValues = new object[] { id };
            Iletisim entity = this.c.Iletisims.Find(keyValues);
            this.c.Iletisims.Remove(entity);
            this.c.SaveChanges();
            return base.RedirectToAction("Iletisim");
        }

        [Authorize]
        public ActionResult Admin() => (ActionResult)this.View((object)((IQueryable<CvSitesi.Models.Admin>)this.c.Admins).OrderByDescending<CvSitesi.Models.Admin, int>((Expression<Func<CvSitesi.Models.Admin, int>>)(x => x.ID)).ToList<CvSitesi.Models.Admin>());

        [Authorize]
        public ActionResult AdminGetir(int id) => (ActionResult)this.View(nameof(AdminGetir), (object)this.c.Admins.Find(new object[1]
        {
      (object) id
        }));

        [Authorize]
        public ActionResult AdminGuncelle(CvSitesi.Models.Admin a)
        {
            CvSitesi.Models.Admin admin = this.c.Admins.Find(new object[1]
            {
        (object) a.ID
            });
            admin.Eposta = a.Eposta;
            admin.Sifre = a.Sifre;
            this.c.SaveChanges();
            return (ActionResult)this.RedirectToAction("/Admin/");
        }

        [Authorize]
        public ActionResult AdminSil(int id)
        {
            this.c.Admins.Remove(this.c.Admins.Find(new object[1]
            {
        (object) id
            }));
            this.c.SaveChanges();
            return (ActionResult)this.RedirectToAction("Admin");
        }

        [Authorize]
        [HttpGet]
        public ActionResult YeniAdmin() => (ActionResult)this.View();

        [Authorize]
        [HttpPost]
        public ActionResult YeniAdmin(CvSitesi.Models.Admin a)
        {
            if (this.ModelState.IsValid)
                this.c.Admins.Add(a);
            this.c.SaveChanges();
            return (ActionResult)this.View(nameof(YeniAdmin));
        }


        [Authorize]
        [HttpGet]
        public ActionResult YeniGenelAyarlar() => (ActionResult)this.View();

        [Authorize]
        [HttpPost]
        public ActionResult YeniGenelAyarlar(CvSitesi.Models.GenelAyarlar a)
        {
            if (this.ModelState.IsValid)
                this.c.GenelAyarlars.Add(a);
            this.c.SaveChanges();
            return (ActionResult)this.View(nameof(YeniGenelAyarlar));
        }

        [Authorize]
        [HttpGet]
        public ActionResult YeniHakkimda() => (ActionResult)this.View();

        [Authorize]
        [HttpPost]
        public ActionResult YeniHakkimda(CvSitesi.Models.Hakkimda a)
        {
            if (this.ModelState.IsValid)
                this.c.Hakkimdas.Add(a);
            this.c.SaveChanges();
            return (ActionResult)this.View(nameof(YeniHakkimda));
        }
    }
}
