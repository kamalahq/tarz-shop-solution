using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarz.WebUI.Models.DataContexts;
using Tarz.WebUI.Models.Entities;
using Tarz.WebUI.Models.ViewModel;

namespace Tarz.WebUI.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            TarzDbContext db = new TarzDbContext();

            ShopFilterViewModel vm = new ShopFilterViewModel();

            vm.Brands = db.Brands

                .Where(b => b.DeletedByUserId == null)
                .ToList();

            vm.Colors = db.Colors
                .Where(b => b.DeletedByUserId == null)
                .ToList();
            return View(vm);

            vm.Sizes = db.Sizes
                .Where(b => b.DeletedByUserId == null)
                .ToList();
            return View(vm);

            vm.Categories = db.Categories
                .Where(b => b.DeletedByUserId == null)
                .ToList();
            return View(vm);

        }
        public IActionResult Details()
        {
            return View();
        }

    }
    
}
