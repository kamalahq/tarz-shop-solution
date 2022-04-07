using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarz.WebUI.Models.DataContexts;

namespace Tarz.WebUI.Controllers
{
    public class MenController : Controller
    {
        readonly TarzDbContext db;
        public MenController(TarzDbContext db)
        {
            this.db = db;
        }

     
        public IActionResult Index()
        {
            var product = db.Products.Where(p => p.GenderId == 1).ToList();
                
            return View();
        }
    }
}
