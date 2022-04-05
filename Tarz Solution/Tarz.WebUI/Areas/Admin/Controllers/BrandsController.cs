using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarz.WebUI.Models.DataContexts;

namespace Tarz.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandsController : Controller
    {
        readonly TarzDbContext db;
        public BrandsController(TarzDbContext db)
        {
            this.db = db;
        }
        public async  Task <IActionResult> Index()
        {
            var data =await db.Brands.ToListAsync();
            return View(data);
        }
    }
}
