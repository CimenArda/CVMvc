﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }
		public PartialViewResult SosyalMedya()
		{
			var sosyalmedya = db.TblSosyalMedya.Where(x=> x.Durum==true).ToList();
			return PartialView(sosyalmedya);
		}

		public PartialViewResult Egitimler()
		{
			var egitimler = db.TblEgitimlerim.ToList();
			return PartialView(egitimler);
		}
		public PartialViewResult Yeteneklerim()
		{
			var yetenekler = db.TblYeteneklerim.ToList();
			return PartialView(yetenekler);
		}

		public PartialViewResult Hobilerim()
		{
			var hobiler = db.TblHobilerim.ToList();
			return PartialView(hobiler);
		}

		public PartialViewResult Sertifikalarım()
		{
			var sertifikalar = db.TblSertifikalarım.ToList();
			return PartialView(sertifikalar);
		}

		[HttpGet]
		public PartialViewResult iletisim()
		{
			var iletisim = db.Tbliletisim.ToList();
			return PartialView(iletisim);
		}
		[HttpPost]
		public PartialViewResult iletisim(Tbliletisim t)
		{
			
			db.Tbliletisim.Add(t);
			db.SaveChanges();
			return PartialView();
		}





	}
}