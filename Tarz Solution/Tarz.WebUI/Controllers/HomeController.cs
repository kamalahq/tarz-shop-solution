using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarz.WebUI.Models.DataContexts;
using Tarz.WebUI.Models.Entities;

namespace Tarz.WebUI.Controllers
{
    public class HomeController : Controller
    {
        readonly TarzDbContext db;
        public HomeController(TarzDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Faq()
        {
            var faqs = db.Faqs.Where(f => f.DeletedByUserId == null).ToList();
            return View(faqs);
        }


        public IActionResult AllProducts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactUs(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = "Sizin sorğunuz qəbul edilmişdir.Tezliklə geri dönüş edəcəyik.";
                return View();
            }
            

            return View(contact);
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Subscribe([Bind("Email")] Subscribe model)
        {
            if (ModelState.IsValid)
            {
                db.Subscribes.Add(model);
                db.SaveChanges();
                //todo
                return Json(new
                {
                    error = false,
                    message = "Sorğunuz uğurla qeydə alindi.Zəhmət olmasa E-poçtunuza göndərilmiş linkdən abunəliyi tamamlayasınız"
                });
            }
            return Json(new
            {
                error = true,
                message="Sorğunun icrası zamanı xəta yarandı.Biraz sonra yeniden yoxlayın"
            });
        }
    }
}
