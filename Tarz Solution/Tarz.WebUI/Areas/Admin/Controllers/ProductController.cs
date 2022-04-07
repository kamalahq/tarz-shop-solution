using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarz.WebUI.Models.DataContexts;

namespace Tarz.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        readonly TarzDbContext db;
        public ProductController(TarzDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Gender).Include(p => p.ProductImages).OrderByDescending(p => p.Id).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            ModelState.Clear();
            ViewData["CategoryId"] = new SelectList(db.Categories, "Id", "Name");
            ViewData["GenderId"] = new SelectList(db.Genders, "Id", "Name");
            ViewData["SizeId"] = new SelectList(db.Sizes, "Id", "Abbr");
            ViewData["ColorId"] = new SelectList(db.Sizes, "Id", "Name");

            return View();
        }




        



    }
}
