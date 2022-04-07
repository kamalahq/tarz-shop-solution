using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarz.WebUI.Models.DataContexts;
using Tarz.WebUI.Models.Entities;

namespace Tarz.WebUI.Controllers
{

    public class ShopController : Controller
    {

        public IActionResult Index()
        {
            // TarzDbContext db = new TarzDbContext();

            //List<Brand> brands = db.Brands
             //   .Where(b => b.DeletedByUserId == null)
             //   .ToList();
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}



